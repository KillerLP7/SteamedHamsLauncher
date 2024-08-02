using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SteamKit2.CDN;
using static SteamedHamsLauncher.FrmCompareFriends;

namespace SteamedHamsLauncher
{
    public partial class FrmCompareFriends : Form
    {
        private string steamId;
        private string apiKey;
        private string appId;
        private List<Friend> friends;
        private int friendIndex = 0;
        private string selectedFriendName;
        private readonly HttpClient client = new HttpClient();


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
                // Falls ein ausgewählter Freund übergeben wurde, ihn hervorheben
                if (!string.IsNullOrEmpty(selectedFriendName))
                {
                    var selectedFriend = friends.FirstOrDefault(f => f.personaname.Equals(selectedFriendName, StringComparison.OrdinalIgnoreCase));
                    if (selectedFriend != null)
                    {
                        friendIndex = friends.IndexOf(selectedFriend);
                    }
                }
                DisplayFriendInfoAsync();
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
                try
                {
                    var response = await client.GetAsync(friendlistUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseData = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"API Response: {responseData}");

                        try
                        {
                            FriendListResponse json = Newtonsoft.Json.JsonConvert.DeserializeObject<FriendListResponse>(responseData);
                            if (json?.friendslist?.friends != null)
                            {
                                friends = json.friendslist.friends;

                                // Überprüfen, ob die Liste nur den eigenen Benutzer enthält
                                if (friends.Any(f => f.steamid == steamId) && friends.Count == 1)
                                {
                                    MessageBox.Show("You have no friends to display.");
                                    friends.Clear();
                                }
                                else
                                {
                                    Console.WriteLine($"Friends Count: {friends.Count}");
                                    await LoadFriendNames();
                                }
                            }
                            else
                            {
                                Console.WriteLine("No friends found or response is null.");
                                friends = new List<Friend>(); // Setze Freunde auf eine leere Liste
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Deserialization error: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error fetching friend list. Status code: {response.StatusCode}");
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"HTTP request error: {ex.Message}");
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
                DisplayFriendInfoAsync();
            }
        }

        private async Task DisplayFriendInfoAsync()
        {
            if (friends == null || friends.Count == 0) return;

            var friend = friends[friendIndex];
            string friendSteamId = friend.steamid;
            pbxUser.ImageLocation = $"https://www.steamidfinder.com/signature/{steamId}.png";
            pbxFriend.ImageLocation = $"https://www.steamidfinder.com/signature/{friendSteamId}.png";

            // Fetch and display profile information
            string profileUrl = $"http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key={apiKey}&steamids={steamId}";
            string profileFriendUrl = $"http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key={apiKey}&steamids={friendSteamId}";

            try
            {
                var profileTask = client.GetStringAsync(profileUrl);
                var profileFriendTask = client.GetStringAsync(profileFriendUrl);

                await Task.WhenAll(profileTask, profileFriendTask);

                dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(await profileTask);
                var friendProfile = json.response.players[0];

                dynamic jsonF = Newtonsoft.Json.JsonConvert.DeserializeObject(await profileFriendTask);
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

                lblFriendSince.Text = friend.friend_since != null ?
                    $"Friend Since: {UnixTimeStampToDateTime((double)friend.friend_since)}" :
                    "Friend Since: N/A";

                lblName.Text = $"{friendProfile.personaname}";
                lblFriendName.Text = $"{friendProfileF.personaname}";

                lblTotalFriends.Text = $"{friendIndex + 1}/{friends.Count}";

                // Lade die Spiele für die beiden Steam-IDs
                var userGamesTask = LoadOwnedGamesAsync(steamId);
                var friendGamesTask = LoadOwnedGamesAsync(friendSteamId);

                await Task.WhenAll(userGamesTask, friendGamesTask);

                var userGames = await userGamesTask;
                var friendGames = await friendGamesTask;

                // Berechnung der Gesamtspielstunden und der Spiele mit 0 Stunden
                var totalGameHours = userGames.Sum(game => game.Playtime) / 60.0; // Stunden
                var totalFriendGameHours = friendGames.Sum(game => game.Playtime) / 60.0; // Stunden

                var userGamesNeverPlayed = userGames.Count(game => game.Playtime == 0);
                var friendGamesNeverPlayed = friendGames.Count(game => game.Playtime == 0);

                lblTotalGameHours.Text = $"Wasted Hours: You: {totalGameHours:F2} / Friend: {totalFriendGameHours:F2}";
                lblTotalGames.Text = $"Never Played Games: {userGamesNeverPlayed}/{userGames.Count}";
                lblTotalFriendGames.Text = $"Never Played Games: {friendGamesNeverPlayed}/{friendGames.Count}";

                // Anzeige des am meisten und zuletzt gespielten Spiels
                var favGame = userGames.OrderByDescending(game => game.Playtime).FirstOrDefault();
                var friendFavGame = friendGames.OrderByDescending(game => game.Playtime).FirstOrDefault();

                var lastPlayedGame = GetMostRecentGame(userGames);
                var friendLastPlayedGame = GetMostRecentGame(friendGames);

                lblFavGame.Text = favGame != null ? $"Fav Game: {favGame.Name}" : "Fav Game: N/A";
                lblFriendFavGame.Text = friendFavGame != null ? $"Fav Game: {friendFavGame.Name}" : "Fav Game: N/A";

                lblLastPlayed.Text = lastPlayedGame != null ? $"Last Played: {lastPlayedGame.Name}" : "Last Played: N/A";
                lblFriendLastPlayed.Text = friendLastPlayedGame != null ? $"Last Played: {friendLastPlayedGame.Name}" : "Last Played: N/A";

                // Setze die gemeinsame Spiele-Liste
                ownedGames = GetCommonGames(userGames, friendGames);
                UpdateGameDisplay();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching or processing data: {ex.Message}");
            }
        }






        private List<GameFriend> GetCommonGames(List<GameFriend> userGames, List<GameFriend> friendGames)
        {
            var commonGames = userGames.Where(g1 => friendGames.Any(g2 => g2.AppId == g1.AppId)).ToList();
            return commonGames;
        }

        private async void btnSearchFriend_Click(object sender, EventArgs e)
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
                DisplayFriendInfoAsync();
            }
            else
            {
                MessageBox.Show("Keine Freunde zum Suchen verfügbar.");
            }
        }

        private void btnPrevFriend_Click(object sender, EventArgs e)
        {
            if (friends != null && friends.Count > 0)
            {
                if (friendIndex > 0)
                {
                    friendIndex--;
                    DisplayFriendInfoAsync();
                }
                else
                {
                    MessageBox.Show("No previous friend available.");
                }
            }
            else
            {
                MessageBox.Show("No friends to navigate.");
            }
        }

        private void btnNextFriend_Click(object sender, EventArgs e)
        {
            if (friends != null && friends.Count > 0)
            {
                if (friendIndex < friends.Count - 1)
                {
                    friendIndex++;
                    DisplayFriendInfoAsync();
                }
                else
                {
                    MessageBox.Show("No next friend available.");
                }
            }
            else
            {
                MessageBox.Show("No friends to navigate.");
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

        private void btnGetAllGames_Click(object sender, EventArgs e)
        {
            // Lade die Spiele für die aktuelle Steam-ID
            FrmShowGames.Instance.OnSteamIdUpdated(steamId);

            // Schließe das aktuelle Formular
            this.Close();
        }

        private async void btnSwitchPlaces_Click(object sender, EventArgs e)
        {
            if (friends == null || friends.Count == 0) return;

            string originalSteamId = steamId;
            string friendSteamId = friends[friendIndex].steamid;

            steamId = friendSteamId;

            var newFriend = friends.FirstOrDefault(f => f.steamid == originalSteamId);
            if (newFriend != null)
            {
                friendIndex = friends.IndexOf(newFriend);
            }
            else
            {
                friendIndex = 0;
            }

            pbxUser.ImageLocation = $"https://www.steamidfinder.com/signature/{steamId}.png";
            pbxFriend.ImageLocation = $"https://www.steamidfinder.com/signature/{friends[friendIndex].steamid}.png";

            try
            {
                await LoadFriendNames();
                await LoadFriendList();
                await DisplayFriendInfoAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while switching places: {ex.Message}");
            }
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
                lblCurrentGameName.Text = "Keine gemeinsamen Spiele verfügbar";
                lblTotalCommonGames.Text = "0 / 0";
                Console.WriteLine("No owned games to display.");
                return;
            }

            var currentGame = ownedGames[gameIndex];
            lblCurrentGameName.Text = currentGame.Name;
            lblTotalCommonGames.Text = $"{gameIndex + 1} / {ownedGames.Count}";
            Console.WriteLine($"Displaying game: {currentGame.Name}, {gameIndex + 1}/{ownedGames.Count}");
        }

        private GameFriend GetMostRecentGame(List<GameFriend> games)
        {
            if (games == null || games.Count == 0) return null;

            // Berechne den heutigen Tag
            DateTime today = DateTime.Now.Date;

            // Finde das Spiel, das am nächsten zum heutigen Datum liegt
            return games.OrderBy(game => Math.Abs((today - game.LastPlaytime.Date).TotalDays)).FirstOrDefault();
        }



        private async Task<List<GameFriend>> LoadOwnedGamesAsync(string steamId)
        {
            string url = $"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key={apiKey}&steamid={steamId}&include_appinfo=true&include_played_free_games=true&format=json";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetStringAsync(url);
                    dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(response);

                    if (json?.response?.games != null)
                    {
                        var games = json.response.games;

                        // Konvertiere die dynamische Liste in eine Liste von Game-Objekten
                        List<GameFriend> ownedGames = new List<GameFriend>();
                        foreach (var game in games)
                        {
                            ownedGames.Add(new GameFriend
                            {
                                AppId = (int)game.appid,
                                Name = (string)game.name,
                                Playtime = (int)game.playtime_forever, // Gesamtspielzeit in Minuten
                                LastPlaytime = game.last_played != null
                                    ? UnixTimeStampToDateTime((double)game.last_played)
                                    : DateTime.MinValue // Setze auf Minimum-Wert, wenn kein Datum vorhanden
                            });
                        }

                        return ownedGames;
                    }
                    else
                    {
                        return new List<GameFriend>();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching games: {ex.Message}");
                    return new List<GameFriend>();
                }
            }
        }



        // Response models


        public class GameFriend
        {
            public int AppId { get; set; }
            public string Name { get; set; }
            public int Playtime { get; set; } // Gesamtspielzeit in Minuten
            public DateTime LastPlaytime { get; set; } // Letztes Spiel-Datum als DateTime
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
