namespace SteamedHamsLauncher
{
    partial class FrmShowGames
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUserSettings = new System.Windows.Forms.Button();
            this.picGameImage = new System.Windows.Forms.PictureBox();
            this.btnSortAZ = new System.Windows.Forms.Button();
            this.btnSortZA = new System.Windows.Forms.Button();
            this.btnNeverPlayed = new System.Windows.Forms.Button();
            this.btnLaunchGame = new System.Windows.Forms.Button();
            this.btnForgotten = new System.Windows.Forms.Button();
            this.btnTopTen = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFriends = new System.Windows.Forms.Button();
            this.pbarUpdate = new System.Windows.Forms.ProgressBar();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblLoadingPercentage = new System.Windows.Forms.Label();
            this.lblGameDescription = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalGames = new System.Windows.Forms.Label();
            this.lblGameData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(12, 12);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(61, 555);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(727, 12);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(61, 555);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSettings.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSettings.Location = new System.Drawing.Point(540, 12);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(181, 40);
            this.btnUserSettings.TabIndex = 2;
            this.btnUserSettings.Text = "Login";
            this.btnUserSettings.UseVisualStyleBackColor = false;
            this.btnUserSettings.Click += new System.EventHandler(this.btnUserSettings_Click);
            // 
            // picGameImage
            // 
            this.picGameImage.Location = new System.Drawing.Point(79, 58);
            this.picGameImage.Name = "picGameImage";
            this.picGameImage.Size = new System.Drawing.Size(455, 224);
            this.picGameImage.TabIndex = 4;
            this.picGameImage.TabStop = false;
            // 
            // btnSortAZ
            // 
            this.btnSortAZ.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSortAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortAZ.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortAZ.Location = new System.Drawing.Point(540, 58);
            this.btnSortAZ.Name = "btnSortAZ";
            this.btnSortAZ.Size = new System.Drawing.Size(181, 40);
            this.btnSortAZ.TabIndex = 3;
            this.btnSortAZ.Text = "Sort: A ---> Z";
            this.btnSortAZ.UseVisualStyleBackColor = false;
            this.btnSortAZ.Click += new System.EventHandler(this.btnSortAZ_Click);
            // 
            // btnSortZA
            // 
            this.btnSortZA.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSortZA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortZA.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortZA.Location = new System.Drawing.Point(540, 104);
            this.btnSortZA.Name = "btnSortZA";
            this.btnSortZA.Size = new System.Drawing.Size(181, 40);
            this.btnSortZA.TabIndex = 4;
            this.btnSortZA.Text = "Sort: Z ---> A";
            this.btnSortZA.UseVisualStyleBackColor = false;
            this.btnSortZA.Click += new System.EventHandler(this.btnSortZA_Click);
            // 
            // btnNeverPlayed
            // 
            this.btnNeverPlayed.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNeverPlayed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeverPlayed.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeverPlayed.Location = new System.Drawing.Point(540, 150);
            this.btnNeverPlayed.Name = "btnNeverPlayed";
            this.btnNeverPlayed.Size = new System.Drawing.Size(181, 40);
            this.btnNeverPlayed.TabIndex = 5;
            this.btnNeverPlayed.Text = "Never Played";
            this.btnNeverPlayed.UseVisualStyleBackColor = false;
            this.btnNeverPlayed.Click += new System.EventHandler(this.btnNeverPlayed_Click);
            // 
            // btnLaunchGame
            // 
            this.btnLaunchGame.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLaunchGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunchGame.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchGame.Location = new System.Drawing.Point(540, 380);
            this.btnLaunchGame.Name = "btnLaunchGame";
            this.btnLaunchGame.Size = new System.Drawing.Size(181, 58);
            this.btnLaunchGame.TabIndex = 10;
            this.btnLaunchGame.Text = "Play";
            this.btnLaunchGame.UseVisualStyleBackColor = false;
            this.btnLaunchGame.Click += new System.EventHandler(this.btnLaunchGame_Click_1);
            // 
            // btnForgotten
            // 
            this.btnForgotten.BackColor = System.Drawing.Color.DarkOrange;
            this.btnForgotten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotten.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotten.Location = new System.Drawing.Point(540, 196);
            this.btnForgotten.Name = "btnForgotten";
            this.btnForgotten.Size = new System.Drawing.Size(181, 40);
            this.btnForgotten.TabIndex = 6;
            this.btnForgotten.Text = "Forgotten";
            this.btnForgotten.UseVisualStyleBackColor = false;
            this.btnForgotten.Click += new System.EventHandler(this.btnForgotten_Click);
            // 
            // btnTopTen
            // 
            this.btnTopTen.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTopTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopTen.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopTen.Location = new System.Drawing.Point(540, 242);
            this.btnTopTen.Name = "btnTopTen";
            this.btnTopTen.Size = new System.Drawing.Size(181, 40);
            this.btnTopTen.TabIndex = 7;
            this.btnTopTen.Text = "Top 10";
            this.btnTopTen.UseVisualStyleBackColor = false;
            this.btnTopTen.Click += new System.EventHandler(this.btnTopTen_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(540, 288);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(181, 40);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search Game";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFriends
            // 
            this.btnFriends.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFriends.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFriends.Location = new System.Drawing.Point(540, 334);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(181, 40);
            this.btnFriends.TabIndex = 9;
            this.btnFriends.Text = "Friends";
            this.btnFriends.UseVisualStyleBackColor = false;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // pbarUpdate
            // 
            this.pbarUpdate.Location = new System.Drawing.Point(79, 573);
            this.pbarUpdate.Maximum = 900;
            this.pbarUpdate.Name = "pbarUpdate";
            this.pbarUpdate.Size = new System.Drawing.Size(642, 57);
            this.pbarUpdate.TabIndex = 13;
            // 
            // lblGameName
            // 
            this.lblGameName.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.Location = new System.Drawing.Point(79, 12);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(455, 31);
            this.lblGameName.TabIndex = 14;
            this.lblGameName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUpdate
            // 
            this.lblUpdate.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(12, 573);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(61, 57);
            this.lblUpdate.TabIndex = 15;
            this.lblUpdate.Text = "Update:";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoadingPercentage
            // 
            this.lblLoadingPercentage.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingPercentage.Location = new System.Drawing.Point(727, 573);
            this.lblLoadingPercentage.Name = "lblLoadingPercentage";
            this.lblLoadingPercentage.Size = new System.Drawing.Size(61, 57);
            this.lblLoadingPercentage.TabIndex = 16;
            this.lblLoadingPercentage.Text = "100%";
            this.lblLoadingPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameDescription
            // 
            this.lblGameDescription.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameDescription.Location = new System.Drawing.Point(79, 288);
            this.lblGameDescription.Name = "lblGameDescription";
            this.lblGameDescription.Size = new System.Drawing.Size(455, 99);
            this.lblGameDescription.TabIndex = 17;
            this.lblGameDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(540, 444);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 123);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalGames
            // 
            this.lblTotalGames.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGames.Location = new System.Drawing.Point(85, 526);
            this.lblTotalGames.Name = "lblTotalGames";
            this.lblTotalGames.Size = new System.Drawing.Size(449, 41);
            this.lblTotalGames.TabIndex = 22;
            this.lblTotalGames.Text = "0 / 0";
            this.lblTotalGames.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGameData
            // 
            this.lblGameData.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameData.Location = new System.Drawing.Point(81, 427);
            this.lblGameData.Name = "lblGameData";
            this.lblGameData.Size = new System.Drawing.Size(455, 99);
            this.lblGameData.TabIndex = 24;
            // 
            // FrmShowGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 642);
            this.Controls.Add(this.lblGameData);
            this.Controls.Add(this.lblTotalGames);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblGameDescription);
            this.Controls.Add(this.lblLoadingPercentage);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.pbarUpdate);
            this.Controls.Add(this.btnFriends);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnTopTen);
            this.Controls.Add(this.btnForgotten);
            this.Controls.Add(this.btnLaunchGame);
            this.Controls.Add(this.btnNeverPlayed);
            this.Controls.Add(this.btnSortZA);
            this.Controls.Add(this.btnSortAZ);
            this.Controls.Add(this.picGameImage);
            this.Controls.Add(this.btnUserSettings);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmShowGames";
            this.Opacity = 0.9D;
            this.Text = "Games";
            this.Load += new System.EventHandler(this.FrmShowGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGameImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUserSettings;
        private System.Windows.Forms.PictureBox picGameImage;
        private System.Windows.Forms.Button btnSortAZ;
        private System.Windows.Forms.Button btnSortZA;
        private System.Windows.Forms.Button btnNeverPlayed;
        private System.Windows.Forms.Button btnLaunchGame;
        private System.Windows.Forms.Button btnForgotten;
        private System.Windows.Forms.Button btnTopTen;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFriends;
        private System.Windows.Forms.ProgressBar pbarUpdate;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblLoadingPercentage;
        private System.Windows.Forms.Label lblGameDescription;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotalGames;
        private System.Windows.Forms.Label lblGameData;
    }
}

