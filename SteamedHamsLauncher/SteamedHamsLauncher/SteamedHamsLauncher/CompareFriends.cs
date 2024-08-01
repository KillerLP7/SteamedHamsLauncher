using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SteamedHamsLauncher
{
    public partial class FrmCompareFriends : Form
    {
        public event Action<string> SteamIdUpdated;

        private string steamId;
        private string apiKey;
        private string appId;
        private List<Friend> friends;
        private int friendIndex = 0;
        private string selectedFriendName;

        public FrmCompareFriends(string steamId, string apiKey, string appId, string selectedFriendName = null)
        {
            InitializeComponent();
            this.steamId = steamId;
            this.apiKey = apiKey;
            this.appId = appId;
            this.selectedFriendName = selectedFriendName;
        }

        private async void FrmCompareFriends_Load(object sender, EventArgs e)
        {
            await LoadFriendList();
            if (friends != null && friends.Count > 0)
            {
                DisplayFriendInfo();
                // Falls ein ausgewählter Freund übergeben wurde, ihn hervorheben
                if (!string.IsNullOrEmpty(selectedFriendName))
                {
                    var selectedFriend = friends.FirstOrDefault(f => f.personaname.Equals(selectedFriendName, StringComparison.OrdinalIgnoreCase));
                    if (selectedFriend != null)
                    {
                        friendIndex = friends.IndexOf(selectedFriend);
                        DisplayFriendInfo();
                    }
                }
            }
            else
            {
                Console.WriteLine("No friends to display.");
            }
        }

        private async Task LoadFriendList()
        {
            string friendlistUrl = $"http://api.steampowered.com/ISteamUser/GetFriendList/v0001/?key={apiKey}&steamid={steamId}&relationship=friend";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(friendlistUrl);
                Console.WriteLine($"API Response: {response}");

                try
                {
                    FriendListResponse json = Newtonsoft.Json.JsonConvert.DeserializeObject<FriendListResponse>(response);
                    if (json?.friendslist?.friends != null)
                    {
                        friends = json.friendslist.friends;
                        Console.WriteLine($"Friends Count: {friends.Count}");
                        await LoadFriendNames();
                    }
                    else
                    {
                        Console.WriteLine("No friends found or response is null.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Deserialization error: {ex.Message}");
                }
            }
        }

        private async Task LoadFriendNames()
        {
            var friendIds = string.Join(",", friends.Select(f => f.steamid));
            string profileUrl = $"http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key={apiKey}&steamids={friendIds}";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(profileUrl);
                dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(response);
                var players = json.response.players;

                foreach (var player in players)
                {
                    var friend = friends.FirstOrDefault(f => f.steamid == (string)player.steamid);
                    if (friend != null)
                    {
                        friend.personaname = player.personaname;
                    }
                }
            }
        }

        private async void DisplayFriendInfo()
        {
            if (friends == null || friends.Count == 0) return;

            var friend = friends[friendIndex];
            string friendSteamId = friend.steamid;
            pbxUser.ImageLocation = $"https://www.steamidfinder.com/signature/{steamId}.png";
            pbxFriend.ImageLocation = $"https://www.steamidfinder.com/signature/{friendSteamId}.png";

            // Fetch and display friend's profile information
            string profileUrl = $"http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key={apiKey}&steamids={steamId}";
            string profileFriendUrl = $"http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key={apiKey}&steamids={friendSteamId}";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(profileUrl);
                dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(response);
                var friendProfile = json.response.players[0];

                var responseF = await client.GetStringAsync(profileFriendUrl);
                dynamic jsonF = Newtonsoft.Json.JsonConvert.DeserializeObject(responseF);
                var friendProfileF = jsonF.response.players[0];

                lblLastLogOff.Text = friendProfile.lastlogoff != null ?
                    $"Last LogOff: {UnixTimeStampToDateTime((double)friendProfile.lastlogoff)}" :
                    "Last LogOff: N/A";

                lblCreatedOn.Text = friendProfile.timecreated != null ?
                    $"Account Created On: {UnixTimeStampToDateTime((double)friendProfile.timecreated)}" :
                    "Account Created On: N/A";

                lblFriendLastLogOff.Text = friendProfileF.lastlogoff != null ?
                    $"Last LogOff: {UnixTimeStampToDateTime((double)friendProfileF.lastlogoff)}" :
                    "Last LogOff: N/A";

                lblFriendCreatedOn.Text = friendProfileF.timecreated != null ?
                    $"Account Created On: {UnixTimeStampToDateTime((double)friendProfileF.timecreated)}" :
                    "Account Created On: N/A";

                // Display friend_since from the friend list data
                if (friend.friend_since != null)
                {
                    lblFriendSince.Text = $"Friend Since: {UnixTimeStampToDateTime((double)friend.friend_since)}";
                }
                else
                {
                    lblFriendSince.Text = "Friend Since: N/A";
                }

                lblFriendName.Text = $"{friendProfileF.personaname}";
            }

            lblTotalFriends.Text = $"{friendIndex + 1}/{friends.Count}";
        }

        private void btnSearchFriend_Click(object sender, EventArgs e)
        {
            if (friends != null && friends.Count > 0)
            {
                var friendNames = friends.Select(f => f.personaname).ToList();
                FrmGamesSearch frmFriendsSearch = new FrmGamesSearch(false, friendNames);

                // Hier wird ein EventHandler hinzugefügt, der auf das Schließen der Form wartet
                frmFriendsSearch.FormClosed += (s, args) =>
                {
                    var selectedFriendName = frmFriendsSearch.GetSelectedFriend();
                    if (selectedFriendName != null)
                    {
                        // Erstelle eine neue Instanz von FrmCompareFriends mit dem ausgewählten Freund
                        FrmCompareFriends frmCompareFriends = new FrmCompareFriends(steamId, apiKey, appId, selectedFriendName);
                        frmCompareFriends.Show();
                        this.Close();
                    }
                };

                frmFriendsSearch.ShowDialog();
            }
            else
            {
                MessageBox.Show("Keine Freunde zum Suchen verfügbar.");
            }
        }




        private void btnPrevFriend_Click(object sender, EventArgs e)
        {
            if (friendIndex > 0)
            {
                friendIndex--;
                DisplayFriendInfo();
            }
        }

        private void btnNextFriend_Click(object sender, EventArgs e)
        {
            if (friendIndex < friends.Count - 1)
            {
                friendIndex++;
                DisplayFriendInfo();
            }
        }

        private DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public List<Friend> GetFriendsList()
        {
            if (friends != null)
            {
                Console.WriteLine($"Anzahl der Freunde in FrmCompareFriends: {friends.Count}");
                return friends;
            }
            else
            {
                Console.WriteLine("Freunde-Liste ist null.");
                return new List<Friend>(); // Gibt eine leere Liste zurück, wenn `friends` null ist
            }
        }

        private async void btnGetAllGames_Click(object sender, EventArgs e)
        {
            // Lade die Spiele für die aktuelle Steam-ID
            //var ownedGames = await LoadOwnedGamesAsync(steamId);

            //// Überprüfe, ob die Liste leer ist
            //if (ownedGames == null || !ownedGames.Any())
            //{
            //    MessageBox.Show("Keine Spiele gefunden.");
            //    return;
            //}

            //// Zeige das erste Spiel an
            //gameIndex = 0;
            //UpdateGameDisplay();

            // Ereignis auslösen
            SteamIdUpdated?.Invoke(steamId);
            Console.WriteLine("SteamIdUpdated event triggered with SteamId: " + steamId);

            // Schließe das aktuelle Formular
            this.Close();
        }


        private void btnSwitchPlaces_Click(object sender, EventArgs e)
        {
            if (friends == null || friends.Count == 0) return;

            // Swap the steamId and friend's steamId
            string originalSteamId = steamId;
            string friendSteamId = friends[friendIndex].steamid;

            // Update the steamId to the friend's Steam ID
            steamId = friendSteamId;

            // Find the new friend's index based on the original Steam ID
            var newFriend = friends.FirstOrDefault(f => f.steamid == originalSteamId);
            if (newFriend != null)
            {
                friendIndex = friends.IndexOf(newFriend);
            }
            else
            {
                // If the friend is not found, default to the first friend or handle as needed
                friendIndex = 0;
            }

            // Update the display with the new information
            DisplayFriendInfo();

            // Swap images
            pbxUser.ImageLocation = $"https://www.steamidfinder.com/signature/{steamId}.png";
            pbxFriend.ImageLocation = $"https://www.steamidfinder.com/signature/{friends[friendIndex].steamid}.png";
        }


        private List<GameFriend> ownedGames;
        private int gameIndex = 0;

        private void btnNextGame_Click(object sender, EventArgs e)
        {
            if (ownedGames != null && gameIndex < ownedGames.Count - 1)
            {
                gameIndex++;
                UpdateGameDisplay();
            }
        }

        private void btnPrevGame_Click(object sender, EventArgs e)
        {
            if (ownedGames != null && gameIndex > 0)
            {
                gameIndex--;
                UpdateGameDisplay();
            }
        }

        private void UpdateGameDisplay()
        {
            if (ownedGames == null || !ownedGames.Any())
            {
                lblCurrentGameName.Text = "Keine Spiele verfügbar";
                lblTotalCommonGames.Text = "0 / 0";
                return;
            }

            var currentGame = ownedGames[gameIndex];
            lblCurrentGameName.Text = currentGame.Name;
            lblTotalCommonGames.Text = $"{gameIndex + 1} / {ownedGames.Count}";
        }

        private async Task<List<GameFriend>> LoadOwnedGamesAsync(string steamId)
        {
            string url = $"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key={apiKey}&steamid={steamId}&include_appinfo=true&include_played_free_games&format=json";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(url);
                dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(response);
                var games = json.response.games;

                // Konvertiere die dynamische Liste in eine Liste von Game-Objekten
                List<GameFriend> ownedGames = new List<GameFriend>();
                foreach (var game in games)
                {
                    ownedGames.Add(new GameFriend
                    {
                        AppId = (int)game.appid,
                        Name = (string)game.name
                    });
                }

                return ownedGames;
            }
        }

        public class GameFriend
        {
            public int AppId { get; set; }
            public string Name { get; set; }
        }



    }

    public class FriendListResponse
    {
        public FriendsList friendslist { get; set; }
    }

    public class FriendsList
    {
        public List<Friend> friends { get; set; }
    }

    public class Friend
    {
        public string steamid { get; set; }
        public long friend_since { get; set; }
        public string personaname { get; set; }
    }
}
