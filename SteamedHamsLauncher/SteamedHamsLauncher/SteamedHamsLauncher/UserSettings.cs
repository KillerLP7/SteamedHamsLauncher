using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SteamedHamsLauncher
{
    public partial class FrmUserSettings : Form
    {
        public string SteamId { get; private set; }
        public string ApiKey { get; private set; }

        public FrmUserSettings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SteamId = tbxSteamId.Text;
            ApiKey = tbxApiKey.Text;

            SaveSettings();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SaveSettings()
        {
            var settings = new { SteamId, ApiKey };
            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);

            try
            {
                File.WriteAllText("SaveAccount.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern der Einstellungen: {ex.Message}");
            }
        }

        private void LoadSettings()
        {
            try
            {
                if (File.Exists("SaveAccount.json"))
                {
                    string json = File.ReadAllText("SaveAccount.json");
                    var settings = JsonConvert.DeserializeObject<dynamic>(json);

                    SteamId = settings.SteamId;
                    ApiKey = settings.ApiKey;

                    tbxSteamId.Text = SteamId;
                    tbxApiKey.Text = ApiKey;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Einstellungen: {ex.Message}");
            }
        }

        public void ResetSettings()
        {
            // Textboxen leeren
            tbxSteamId.Text = string.Empty;
            tbxApiKey.Text = string.Empty;

            // SteamId und ApiKey Felder leeren
            SteamId = string.Empty;
            ApiKey = string.Empty;

            // JSON-Datei löschen
            try
            {
                if (File.Exists("SaveAccount.json"))
                {
                    File.Delete("SaveAccount.json");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Löschen der Einstellungen: {ex.Message}");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SteamId = "";
            ApiKey = "";
            tbxSteamId.Text = "";
            tbxApiKey.Text = "";
            SaveSettings();

            // Hier benachrichtigen wir FrmShowGames über das Logout
            FrmShowGames frmShowGames = (FrmShowGames)Application.OpenForms["FrmShowGames"];
            if (frmShowGames != null)
            {
                frmShowGames.Logout();
            }

            this.Close();
        }

    }
}
