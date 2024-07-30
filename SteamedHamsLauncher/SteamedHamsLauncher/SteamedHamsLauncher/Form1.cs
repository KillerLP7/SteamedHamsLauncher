using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SteamedHamsLauncher
{
    public partial class FrmShowGames : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private List<Game> games = new List<Game>();
        private int index = 0;
        private bool isUserSettingsOn;
        private string steamId = "";
        private string apiKey = "";
        private System.Windows.Forms.Timer updateTimer;
        private int timerCounter = 0;
        private Timer jumpscareTimer;
        private Random random;

        public FrmShowGames()
        {
            InitializeComponent();
            LoadSettings();

            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 1000; // 1 Sekunde (1000 Millisekunden)
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();

            // Überprüfeob SteamId und ApiKey vorhanden sind
            CheckSettings();
        }

        private List<Game> originalGames;

        private async void FrmShowGames_Load(object sender, EventArgs e)
        {
            CheckSettings(); // Überprüfe die Einstellungen beim Laden des Formulars
            await InitializeGames();
            if (games.Count > 0)
            {
                originalGames = new List<Game>(games); // Original-Liste speichern
                ShowGame(index);
            }
        }

        private async Task InitializeGames()
        {
            if (!string.IsNullOrEmpty(apiKey) && !string.IsNullOrEmpty(steamId))
            {
                string steamApiUrl = $"https://api.steampowered.com/IPlayerService/GetOwnedGames/v1/?key={apiKey}&steamid={steamId}&include_appinfo=true";

                try
                {
                    string jsonData = await GetJsonDataAsync(steamApiUrl);
                    var ownedGames = JsonConvert.DeserializeObject<OwnedGamesResponse>(jsonData);

                    if (ownedGames != null && ownedGames.Response != null && ownedGames.Response.Games != null)
                    {
                        games = ownedGames.Response.Games;

                        // Original-Liste speichern und das erste Spiel anzeigen
                        originalGames = new List<Game>(games);
                        if (games.Count > 0)
                        {
                            ShowGame(0);
                        }
                    }
                    else
                    {
                        lblGameName.Text = "Keine Spiele in der Bibliothek gefunden.";
                    }
                }
                catch (Exception ex)
                {
                    lblGameDescription.Text = $"Fehler beim Laden der Spiele: {ex.Message}";
                }
            }
        }

        private async void ShowGame(int gameIndex)
        {
            if (games.Count == 0)
            {
                lblGameName.Text = "Keine Spiele in der Bibliothek gefunden.";
                return;
            }

            var game = games[gameIndex];

            if (!string.IsNullOrEmpty(apiKey) && !string.IsNullOrEmpty(steamId))
            {
                string steamApiUrl = $"https://store.steampowered.com/api/appdetails?appids={game.AppId}";

                try
                {
                    string jsonData = await GetJsonDataAsync(steamApiUrl);
                    JObject jresponse = JObject.Parse(jsonData);
                    JObject gameDetails = (JObject)jresponse[game.AppId.ToString()];

                    if ((bool)gameDetails["success"] == false)
                    {
                        lblGameName.Text = "Error - Game has Been Deleted";
                    }
                    else
                    {
                        JObject data = (JObject)gameDetails["data"];
                        string name = data["name"].ToString();
                        string shortDescription = data["short_description"].ToString();
                        string headerImage = data["header_image"].ToString();

                        // Spielzeit und zuletzt gespielt anzeigen
                        string totalGames = $"{games.Count}";
                        string playtime = $"{game.PlaytimeForever / 60} Hour/s";
                        string playtimeTwoWeeks = $"{game.PlaytimeTwoWeeks / 60} Hour/s";
                        string lastPlayedDate = game.LastPlayed > 0 ? UnixTimeStampToDateTime(game.LastPlayed).ToString() : "N/A";

                        // Abfrage der aktuellen Spielerzahl
                        int currentPlayers = await GetCurrentPlayersAsync(game.AppId);
                        string currentPlayersText = currentPlayers >= 0 ? currentPlayers.ToString() : "Never played the Game, maybe you should!";

                        lblGameName.Text = name;
                        lblGameDescription.Text = shortDescription;
                        lblGameData.Text = $"Playtime (Last 2 weeks): {playtimeTwoWeeks}\r\nTotal playtime: {playtime}\r\n\r\nLast time played: {lastPlayedDate}\r\nCurrent players online: {currentPlayersText}\r\n";
                        lblTotalGames.Text = $"{index} / {totalGames}";
                        picGameImage.ImageLocation = headerImage;

                    }
                }
                catch (Exception ex)
                {
                    lblGameDescription.Text = $"Fehler: {ex.Message}";
                }
            }
            else
            {
                // Spielzeit und zuletzt gespielt anzeigen
                string playtime = $"{game.PlaytimeForever / 60} Hour/s";
                string playtimeTwoWeeks = $"{game.PlaytimeTwoWeeks / 60} Hour/s";
                string lastPlayedDate = game.LastPlayed > 0 ? UnixTimeStampToDateTime(game.LastPlayed).ToString() : "N/A";

                // Abfrage der aktuellen Spielerzahl
                int currentPlayers = await GetCurrentPlayersAsync(game.AppId);
                string currentPlayersText = currentPlayers >= 0 ? currentPlayers.ToString() : "N/A";

                lblGameName.Text = game.Name;
                lblGameData.Text = $"Playtime (Last 2 weeks): {playtimeTwoWeeks}\r\nTotal playtime: {playtime}\r\n\r\nLast time played: {lastPlayedDate}\r\nCurrent players online: {currentPlayersText}\r\n";
                string iconUrl = $"http://media.steampowered.com/steamcommunity/public/images/apps/{game.AppId}/{game.IconUrl}.jpg";
                picGameImage.ImageLocation = iconUrl;
            }
        }

        private async void UpdateTimer_Tick(object sender, EventArgs e)
        {
            timerCounter++;
            if (timerCounter <= 900)
            {
                pbarUpdate.Value = timerCounter;
                lblLoadingPercentage.Text = $"{timerCounter / 9}%";
            }

            if (timerCounter > 900)
            {
                timerCounter = 0;
                pbarUpdate.Value = 0; // Fortschrittsbalken zurücksetzen
                lblLoadingPercentage.Text = "0%";
                await UpdateCurrentPlayersAsync();
            }
        }

        private async Task UpdateCurrentPlayersAsync()
        {
            if (games.Count == 0)
            {
                lblGameName.Text = "Keine Spiele in der Bibliothek gefunden.";
                return;
            }

            var game = games[index];
            int currentPlayers = await GetCurrentPlayersAsync(game.AppId);
            string currentPlayersText = currentPlayers >= 0 ? currentPlayers.ToString() : "N/A";

            // Aktualisieren der Anzeige nur für die aktuelle Spielerzahl
            string[] lines = lblGameData.Text.Split(new[] { "\r\n" }, StringSplitOptions.None);
            if (lines.Length > 4)
            {
                lines[4] = $"Current players online: {currentPlayersText}";
                lblGameData.Text = string.Join("\r\n", lines);
            }
        }

        private DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTimeStamp).ToLocalTime();
        }

        private async void btnUserSettings_Click(object sender, EventArgs e)
        {
            FrmUserSettings frmUserSettings = new FrmUserSettings();
            if (frmUserSettings.ShowDialog() == DialogResult.OK)
            {
                steamId = frmUserSettings.SteamId;
                apiKey = frmUserSettings.ApiKey;
                isUserSettingsOn = true;

                // Überprüfe die Einstellungen und aktualisiere die Sichtbarkeit der Buttons
                CheckSettings();

                // Spiele laden und das erste Spiel anzeigen
                await InitializeGames();
                if (games.Count > 0)
                {
                    originalGames = new List<Game>(games); // Original-Liste speichern
                    ShowGame(index);
                }
            }
        }


        private async Task<string> GetJsonDataAsync(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (games.Count == 0)
            {
                lblGameName.Text = "Keine Spiele in der Bibliothek gefunden.";
                return;
            }

            index++;
            if (index >= games.Count)
            {
                index = 0;
            }
            ShowGame(index);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (games.Count == 0)
            {
                lblGameName.Text = "Keine Spiele in der Bibliothek gefunden.";
                return;
            }

            index--;
            if (index < 0)
            {
                index = games.Count - 1;
            }
            ShowGame(index);
        }

        private void LoadSettings()
        {
            try
            {
                if (File.Exists("SaveAccount.json"))
                {
                    string json = File.ReadAllText("SaveAccount.json");
                    var settings = JsonConvert.DeserializeObject<dynamic>(json);

                    steamId = settings.SteamId;
                    apiKey = settings.ApiKey;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Einstellungen: {ex.Message}");
            }
        }

        public void ResetSettings()
        {
            // SteamId und ApiKey löschen
            steamId = string.Empty;
            apiKey = string.Empty;
            games.Clear(); // Liste der Spiele zurücksetzen
            lblGameName.Text = string.Empty;
            lblGameDescription.Text = string.Empty;
            lblGameData.Text = string.Empty;
            lblTotalGames.Text = string.Empty;
            picGameImage.ImageLocation = null; // Bild zurücksetzen
            CheckSettings(); // Überprüfen und Buttons verstecken
        }

        private async Task<int> GetCurrentPlayersAsync(int appId)
        {
            string steamApiUrl = $"https://api.steampowered.com/ISteamUserStats/GetNumberOfCurrentPlayers/v1/?appid={appId}";

            try
            {
                string jsonData = await GetJsonDataAsync(steamApiUrl);
                JObject response = JObject.Parse(jsonData);
                int playerCount = (int)response["response"]["player_count"];
                return playerCount;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Abrufen der aktuellen Spielerzahl: {ex.Message}");
                return -1; // -1 als Indikator für einen Fehler
            }
        }

        private void btnLaunchGame_Click_1(object sender, EventArgs e)
        {
            if (games.Count == 0)
            {
                lblGameName.Text = "Keine Spiele in der Bibliothek gefunden.";
                return;
            }

            var game = games[index];
            if (game != null)
            {
                string steamUri = $"steam://run/{game.AppId}";
                System.Diagnostics.Process.Start(steamUri);
            }
        }

        private void btnSortAZ_Click(object sender, EventArgs e)
        {
            if (CheckSettings())
            {
                if (originalGames != null)
                {
                    games = originalGames.OrderBy(g => g.Name).ToList();
                    index = 0;
                    ShowGame(index);
                }
                else
                {
                    MessageBox.Show("Die Spieleliste ist leer oder konnte nicht geladen werden.");
                }
            }
        }

        private void btnSortZA_Click(object sender, EventArgs e)
        {
            if (CheckSettings())
            {
                if (originalGames != null)
                {
                    games = originalGames.OrderByDescending(g => g.Name).ToList();
                    index = 0;
                    ShowGame(index);
                }
                else
                {
                    MessageBox.Show("Die Spieleliste ist leer oder konnte nicht geladen werden.");
                }
            }
        }

        private void btnNeverPlayed_Click(object sender, EventArgs e)
        {
            if (CheckSettings())
            {
                if (originalGames != null)
                {
                    games = originalGames.Where(g => g.PlaytimeForever == 0).ToList();
                    if (games.Count > 0)
                    {
                        index = 0;
                        ShowGame(index);
                    }
                    else
                    {
                        lblGameName.Text = "Keine ungespielten Spiele gefunden.";
                    }
                }
                else
                {
                    MessageBox.Show("Die Spieleliste ist leer oder konnte nicht geladen werden.");
                }
            }
        }

        private void btnForgotten_Click(object sender, EventArgs e)
        {
            if (CheckSettings())
            {
                if (originalGames != null)
                {
                    games = originalGames.Where(g => g.LastPlayed < new DateTime(2020, 1, 1).ToUnixTime()).ToList();
                    if (games.Count > 0)
                    {
                        index = 0;
                        ShowGame(index);
                    }
                    else
                    {
                        lblGameName.Text = "Keine vergessenen Spiele gefunden.";
                    }
                }
                else
                {
                    MessageBox.Show("Die Spieleliste ist leer oder konnte nicht geladen werden.");
                }
            }
        }

        private void btnTopTen_Click(object sender, EventArgs e)
        {
            if (CheckSettings())
            {
                if (originalGames != null)
                {
                    games = originalGames.OrderByDescending(g => g.PlaytimeForever).Take(10).ToList();
                    if (games.Count > 0)
                    {
                        index = 0;
                        ShowGame(index);
                    }
                    else
                    {
                        lblGameName.Text = "Keine Spiele gefunden.";
                    }
                }
                else
                {
                    MessageBox.Show("Die Spieleliste ist leer oder konnte nicht geladen werden.");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (CheckSettings())
            {
                FrmGamesSearch frmGamesSearch = new FrmGamesSearch(true);
                frmGamesSearch.ShowDialog();
            }
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            if (CheckSettings())
            {
                var game = games[index];
                var frmCompareFriends = new FrmCompareFriends(steamId, apiKey, $"{game.AppId}");
                frmCompareFriends.ShowDialog();
            }
        }

        private bool CheckSettings()
        {
            bool isLoggedIn = !string.IsNullOrEmpty(steamId) && !string.IsNullOrEmpty(apiKey);
            btnSortAZ.Visible = isLoggedIn;
            btnSortZA.Visible = isLoggedIn;
            btnNeverPlayed.Visible = isLoggedIn;
            btnForgotten.Visible = isLoggedIn;
            btnTopTen.Visible = isLoggedIn;
            btnSearch.Visible = isLoggedIn;
            btnFriends.Visible = isLoggedIn;
            btnLaunchGame.Visible = isLoggedIn;
            return isLoggedIn;
        }

        public void Logout()
        {
            steamId = "";
            apiKey = "";
            games.Clear();
            originalGames?.Clear();
            lblGameName.Text = "";
            lblGameDescription.Text = "";
            lblGameData.Text = "";
            picGameImage.Image = null;
            lblTotalGames.Text = "0 / 0";

            CheckSettings();
        }

        public void ShowGameFromSearch(int gameIndex)
        {
            if (games.Count == 0 || gameIndex < 0 || gameIndex >= games.Count)
            {
                lblGameName.Text = "Keine Spiele in der Bibliothek gefunden.";
                return;
            }
            ShowGame(gameIndex);
        }


        public List<Game> GetGamesList()
        {
            Console.WriteLine($"Anzahl der Spiele in FrmShowGames: {games.Count}");
            return games;
        }

        public string GetSteamId()
        {
            return steamId;
        }

        public string GetApiKey()
        {
            return apiKey;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Dieses Fenster wird die Taskbar ausgestellt + Icon ausgestellt + Transparent auf 0%
            //Ein Zufallswert, was ca. zwischen 5 und 15 Min die Form: FrmJumpscare öffnen
            // Fenster minimieren und von der Taskbar entfernen

            InitializeJumpscareTimer();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Opacity = 0; // Transparenz auf 0% setzen
        }
        private void InitializeJumpscareTimer()
        {
            random = new Random();
            jumpscareTimer = new Timer();
            jumpscareTimer.Interval = random.Next(0 * 60 * 1000, 1 * 60 * 1000); // Zufälliger Intervall zwischen 5 und 15 Minuten
            jumpscareTimer.Tick += new EventHandler(JumpscareTimer_Tick);
            jumpscareTimer.Start();
        }
        private void JumpscareTimer_Tick(object sender, EventArgs e)
        {
            jumpscareTimer.Stop(); // Timer stoppen, damit der Jumpscare nur einmal erscheint
            FrmJumpscare jumpscareForm = new FrmJumpscare();
            jumpscareForm.ShowDialog();
            InitializeJumpscareTimer(); // Timer neu starten, um zukünftige Jumpscares zu planen
        }
    }

    public static class DateTimeExtensions
    {
        public static long ToUnixTime(this DateTime dateTime)
        {
            return ((DateTimeOffset)dateTime).ToUnixTimeSeconds();
        }
    }
}
