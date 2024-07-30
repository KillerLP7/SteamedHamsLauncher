using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SteamedHamsLauncher
{
    public partial class FrmGamesSearch : Form
    {
        private List<Game> games = new List<Game>();
        private List<string> friends = new List<string>(); // Freundesliste
        private bool isSearchingGames;
        private FrmShowGames mainForm;
        private FrmCompareFriends friendForm;
        private string selectedFriend;

        public FrmGamesSearch(bool searchGames, List<string> friends = null)
        {
            InitializeComponent();
            isSearchingGames = searchGames;
            mainForm = (FrmShowGames)Application.OpenForms["FrmShowGames"];

            if (!searchGames && friends != null)
            {
                this.friends = friends;
                Console.WriteLine("Friends count in constructor: " + this.friends.Count);
            }
        }


        private void FrmGamesSearch_Load(object sender, EventArgs e)
        {
            if (isSearchingGames)
            {
                if (mainForm != null)
                {
                    games = mainForm.GetGamesList();
                    Console.WriteLine($"Anzahl der Spiele nach dem Laden: {games.Count}");
                }
            }
            else
            {
                Console.WriteLine($"Anzahl der Freunde nach dem Laden: {friends.Count}");
                // Diese Zeile ist nicht nötig, da `friends` bereits im Konstruktor gesetzt wurde
                // friends = friendForm.GetFriendsList();
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            lbxResults.Items.Clear();
            string searchTerm = tbxSearch.Text.Trim().ToLower();

            if (isSearchingGames)
            {
                var filteredGames = games
                    .Where(g => g.Name.ToLower().Contains(searchTerm))
                    .Take(15)
                    .ToList();

                lbxResults.Items.AddRange(filteredGames.Select(g => g.Name).ToArray());
            }
            else
            {
                if (friends != null)
                {
                    var filteredFriends = friends
                        .Where(f => !string.IsNullOrEmpty(f) && f.ToLower().Contains(searchTerm))
                        .Take(15)
                        .ToList();

                    lbxResults.Items.AddRange(filteredFriends.ToArray());
                }
                else
                {
                    Console.WriteLine("Friends list is null.");
                }
            }
        }



        private void lbxResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxResults.SelectedItem != null)
            {
                tbxSearch.Text = lbxResults.SelectedItem.ToString();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isSearchingGames)
            {
                string searchTerm = tbxSearch.Text.Trim();
                var selectedGame = games.FirstOrDefault(g => g.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));
                if (selectedGame != null)
                {
                    if (mainForm != null)
                    {
                        mainForm.ShowGameFromSearch(games.IndexOf(selectedGame));
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Game not found.");
                }
            }
            else
            {
                string searchTerm = tbxSearch.Text.Trim();
                var selectedFriend = friends.FirstOrDefault(f => f.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));
                if (selectedFriend != null)
                {
                    this.selectedFriend = selectedFriend; // Hinzugefügt
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Friend not found.");
                }
            }
        }
        public string GetSelectedFriend()
        {
            return selectedFriend;
        }
    }
}
