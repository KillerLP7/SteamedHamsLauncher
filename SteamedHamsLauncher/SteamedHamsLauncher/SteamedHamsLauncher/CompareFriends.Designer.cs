namespace SteamedHamsLauncher
{
    partial class FrmCompareFriends
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.pbxFriend = new System.Windows.Forms.PictureBox();
            this.btnPrevFriend = new System.Windows.Forms.Button();
            this.btnNextFriend = new System.Windows.Forms.Button();
            this.btnSearchFriend = new System.Windows.Forms.Button();
            this.lblLastLogOff = new System.Windows.Forms.Label();
            this.lblCreatedOn = new System.Windows.Forms.Label();
            this.lblTotalFriends = new System.Windows.Forms.Label();
            this.lblFriendSince = new System.Windows.Forms.Label();
            this.lblFriendName = new System.Windows.Forms.Label();
            this.lblFriendLastLogOff = new System.Windows.Forms.Label();
            this.lblFriendCreatedOn = new System.Windows.Forms.Label();
            this.btnSwitchPlaces = new System.Windows.Forms.Button();
            this.btnGetAllGames = new System.Windows.Forms.Button();
            this.btnPrevGame = new System.Windows.Forms.Button();
            this.btnNextGame = new System.Windows.Forms.Button();
            this.lblCurrentGameName = new System.Windows.Forms.Label();
            this.lblTotalCommonGames = new System.Windows.Forms.Label();
            this.lblTotalGames = new System.Windows.Forms.Label();
            this.lblTotalFriendGames = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFavGame = new System.Windows.Forms.Label();
            this.lblFriendFavGame = new System.Windows.Forms.Label();
            this.lblLastPlayed = new System.Windows.Forms.Label();
            this.lblFriendLastPlayed = new System.Windows.Forms.Label();
            this.lblTotalGameHours = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxUser
            // 
            this.pbxUser.Location = new System.Drawing.Point(12, 149);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(411, 131);
            this.pbxUser.TabIndex = 0;
            this.pbxUser.TabStop = false;
            // 
            // pbxFriend
            // 
            this.pbxFriend.Location = new System.Drawing.Point(513, 149);
            this.pbxFriend.Name = "pbxFriend";
            this.pbxFriend.Size = new System.Drawing.Size(411, 131);
            this.pbxFriend.TabIndex = 2;
            this.pbxFriend.TabStop = false;
            // 
            // btnPrevFriend
            // 
            this.btnPrevFriend.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPrevFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevFriend.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevFriend.Location = new System.Drawing.Point(429, 149);
            this.btnPrevFriend.Name = "btnPrevFriend";
            this.btnPrevFriend.Size = new System.Drawing.Size(75, 456);
            this.btnPrevFriend.TabIndex = 0;
            this.btnPrevFriend.Text = "<";
            this.btnPrevFriend.UseVisualStyleBackColor = false;
            this.btnPrevFriend.Click += new System.EventHandler(this.btnPrevFriend_Click);
            // 
            // btnNextFriend
            // 
            this.btnNextFriend.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNextFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextFriend.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextFriend.Location = new System.Drawing.Point(930, 149);
            this.btnNextFriend.Name = "btnNextFriend";
            this.btnNextFriend.Size = new System.Drawing.Size(75, 456);
            this.btnNextFriend.TabIndex = 1;
            this.btnNextFriend.Text = ">";
            this.btnNextFriend.UseVisualStyleBackColor = false;
            this.btnNextFriend.Click += new System.EventHandler(this.btnNextFriend_Click);
            // 
            // btnSearchFriend
            // 
            this.btnSearchFriend.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearchFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFriend.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFriend.Location = new System.Drawing.Point(513, 12);
            this.btnSearchFriend.Name = "btnSearchFriend";
            this.btnSearchFriend.Size = new System.Drawing.Size(492, 131);
            this.btnSearchFriend.TabIndex = 2;
            this.btnSearchFriend.Text = "Search Friend";
            this.btnSearchFriend.UseVisualStyleBackColor = false;
            this.btnSearchFriend.Click += new System.EventHandler(this.btnSearchFriend_Click);
            // 
            // lblLastLogOff
            // 
            this.lblLastLogOff.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastLogOff.Location = new System.Drawing.Point(12, 322);
            this.lblLastLogOff.Name = "lblLastLogOff";
            this.lblLastLogOff.Size = new System.Drawing.Size(411, 42);
            this.lblLastLogOff.TabIndex = 6;
            this.lblLastLogOff.Text = "Last time logged in: ";
            this.lblLastLogOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreatedOn
            // 
            this.lblCreatedOn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedOn.Location = new System.Drawing.Point(12, 354);
            this.lblCreatedOn.Name = "lblCreatedOn";
            this.lblCreatedOn.Size = new System.Drawing.Size(411, 43);
            this.lblCreatedOn.TabIndex = 7;
            this.lblCreatedOn.Text = "Created on:";
            this.lblCreatedOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalFriends
            // 
            this.lblTotalFriends.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFriends.Location = new System.Drawing.Point(510, 556);
            this.lblTotalFriends.Name = "lblTotalFriends";
            this.lblTotalFriends.Size = new System.Drawing.Size(414, 49);
            this.lblTotalFriends.TabIndex = 8;
            this.lblTotalFriends.Text = "0 / 0";
            this.lblTotalFriends.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriendSince
            // 
            this.lblFriendSince.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriendSince.Location = new System.Drawing.Point(513, 489);
            this.lblFriendSince.Name = "lblFriendSince";
            this.lblFriendSince.Size = new System.Drawing.Size(414, 25);
            this.lblFriendSince.TabIndex = 9;
            this.lblFriendSince.Text = "2024";
            this.lblFriendSince.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriendName
            // 
            this.lblFriendName.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriendName.Location = new System.Drawing.Point(510, 283);
            this.lblFriendName.Name = "lblFriendName";
            this.lblFriendName.Size = new System.Drawing.Size(414, 53);
            this.lblFriendName.TabIndex = 10;
            this.lblFriendName.Text = "Lucca";
            this.lblFriendName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriendLastLogOff
            // 
            this.lblFriendLastLogOff.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriendLastLogOff.Location = new System.Drawing.Point(513, 331);
            this.lblFriendLastLogOff.Name = "lblFriendLastLogOff";
            this.lblFriendLastLogOff.Size = new System.Drawing.Size(411, 24);
            this.lblFriendLastLogOff.TabIndex = 11;
            this.lblFriendLastLogOff.Text = "Last time logged in: ";
            this.lblFriendLastLogOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriendCreatedOn
            // 
            this.lblFriendCreatedOn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriendCreatedOn.Location = new System.Drawing.Point(513, 363);
            this.lblFriendCreatedOn.Name = "lblFriendCreatedOn";
            this.lblFriendCreatedOn.Size = new System.Drawing.Size(411, 24);
            this.lblFriendCreatedOn.TabIndex = 12;
            this.lblFriendCreatedOn.Text = "Created on:";
            this.lblFriendCreatedOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSwitchPlaces
            // 
            this.btnSwitchPlaces.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSwitchPlaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchPlaces.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchPlaces.Location = new System.Drawing.Point(429, 12);
            this.btnSwitchPlaces.Name = "btnSwitchPlaces";
            this.btnSwitchPlaces.Size = new System.Drawing.Size(75, 131);
            this.btnSwitchPlaces.TabIndex = 13;
            this.btnSwitchPlaces.Text = "< >";
            this.btnSwitchPlaces.UseVisualStyleBackColor = false;
            this.btnSwitchPlaces.Click += new System.EventHandler(this.btnSwitchPlaces_Click);
            // 
            // btnGetAllGames
            // 
            this.btnGetAllGames.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGetAllGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAllGames.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAllGames.Location = new System.Drawing.Point(11, 12);
            this.btnGetAllGames.Name = "btnGetAllGames";
            this.btnGetAllGames.Size = new System.Drawing.Size(411, 131);
            this.btnGetAllGames.TabIndex = 14;
            this.btnGetAllGames.Text = "Get All Games";
            this.btnGetAllGames.UseVisualStyleBackColor = false;
            this.btnGetAllGames.Click += new System.EventHandler(this.btnGetAllGames_Click);
            // 
            // btnPrevGame
            // 
            this.btnPrevGame.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPrevGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevGame.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevGame.Location = new System.Drawing.Point(12, 501);
            this.btnPrevGame.Name = "btnPrevGame";
            this.btnPrevGame.Size = new System.Drawing.Size(75, 49);
            this.btnPrevGame.TabIndex = 15;
            this.btnPrevGame.Text = "<";
            this.btnPrevGame.UseVisualStyleBackColor = false;
            this.btnPrevGame.Click += new System.EventHandler(this.btnPrevGame_Click);
            // 
            // btnNextGame
            // 
            this.btnNextGame.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNextGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextGame.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextGame.Location = new System.Drawing.Point(347, 501);
            this.btnNextGame.Name = "btnNextGame";
            this.btnNextGame.Size = new System.Drawing.Size(75, 49);
            this.btnNextGame.TabIndex = 16;
            this.btnNextGame.Text = ">";
            this.btnNextGame.UseVisualStyleBackColor = false;
            this.btnNextGame.Click += new System.EventHandler(this.btnNextGame_Click);
            // 
            // lblCurrentGameName
            // 
            this.lblCurrentGameName.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentGameName.Location = new System.Drawing.Point(93, 501);
            this.lblCurrentGameName.Name = "lblCurrentGameName";
            this.lblCurrentGameName.Size = new System.Drawing.Size(248, 49);
            this.lblCurrentGameName.TabIndex = 17;
            this.lblCurrentGameName.Text = "Game";
            this.lblCurrentGameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCommonGames
            // 
            this.lblTotalCommonGames.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCommonGames.Location = new System.Drawing.Point(9, 556);
            this.lblTotalCommonGames.Name = "lblTotalCommonGames";
            this.lblTotalCommonGames.Size = new System.Drawing.Size(414, 49);
            this.lblTotalCommonGames.TabIndex = 18;
            this.lblTotalCommonGames.Text = "0 / 0";
            this.lblTotalCommonGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalGames
            // 
            this.lblTotalGames.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGames.Location = new System.Drawing.Point(11, 392);
            this.lblTotalGames.Name = "lblTotalGames";
            this.lblTotalGames.Size = new System.Drawing.Size(411, 29);
            this.lblTotalGames.TabIndex = 19;
            this.lblTotalGames.Text = "Games";
            this.lblTotalGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalFriendGames
            // 
            this.lblTotalFriendGames.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFriendGames.Location = new System.Drawing.Point(513, 393);
            this.lblTotalFriendGames.Name = "lblTotalFriendGames";
            this.lblTotalFriendGames.Size = new System.Drawing.Size(411, 26);
            this.lblTotalFriendGames.TabIndex = 20;
            this.lblTotalFriendGames.Text = "Games";
            this.lblTotalFriendGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(9, 283);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(414, 53);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Lucca";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFavGame
            // 
            this.lblFavGame.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavGame.Location = new System.Drawing.Point(11, 421);
            this.lblFavGame.Name = "lblFavGame";
            this.lblFavGame.Size = new System.Drawing.Size(411, 26);
            this.lblFavGame.TabIndex = 24;
            this.lblFavGame.Text = "Fav";
            this.lblFavGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriendFavGame
            // 
            this.lblFriendFavGame.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriendFavGame.Location = new System.Drawing.Point(513, 421);
            this.lblFriendFavGame.Name = "lblFriendFavGame";
            this.lblFriendFavGame.Size = new System.Drawing.Size(411, 26);
            this.lblFriendFavGame.TabIndex = 25;
            this.lblFriendFavGame.Text = "Fav";
            this.lblFriendFavGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastPlayed
            // 
            this.lblLastPlayed.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPlayed.Location = new System.Drawing.Point(12, 452);
            this.lblLastPlayed.Name = "lblLastPlayed";
            this.lblLastPlayed.Size = new System.Drawing.Size(411, 26);
            this.lblLastPlayed.TabIndex = 26;
            this.lblLastPlayed.Text = "Last Played";
            this.lblLastPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriendLastPlayed
            // 
            this.lblFriendLastPlayed.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriendLastPlayed.Location = new System.Drawing.Point(513, 452);
            this.lblFriendLastPlayed.Name = "lblFriendLastPlayed";
            this.lblFriendLastPlayed.Size = new System.Drawing.Size(411, 26);
            this.lblFriendLastPlayed.TabIndex = 27;
            this.lblFriendLastPlayed.Text = "Last Played";
            this.lblFriendLastPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalGameHours
            // 
            this.lblTotalGameHours.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGameHours.Location = new System.Drawing.Point(512, 525);
            this.lblTotalGameHours.Name = "lblTotalGameHours";
            this.lblTotalGameHours.Size = new System.Drawing.Size(414, 25);
            this.lblTotalGameHours.TabIndex = 28;
            this.lblTotalGameHours.Text = "You: 1000 Hour/s Me: 1000 Hour/s";
            this.lblTotalGameHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCompareFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1017, 617);
            this.Controls.Add(this.lblTotalGameHours);
            this.Controls.Add(this.lblFriendLastPlayed);
            this.Controls.Add(this.lblLastPlayed);
            this.Controls.Add(this.lblFriendFavGame);
            this.Controls.Add(this.lblFavGame);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTotalFriendGames);
            this.Controls.Add(this.lblTotalGames);
            this.Controls.Add(this.lblTotalCommonGames);
            this.Controls.Add(this.lblCurrentGameName);
            this.Controls.Add(this.btnNextGame);
            this.Controls.Add(this.btnPrevGame);
            this.Controls.Add(this.btnGetAllGames);
            this.Controls.Add(this.btnSwitchPlaces);
            this.Controls.Add(this.lblFriendCreatedOn);
            this.Controls.Add(this.lblFriendLastLogOff);
            this.Controls.Add(this.lblFriendName);
            this.Controls.Add(this.lblFriendSince);
            this.Controls.Add(this.lblTotalFriends);
            this.Controls.Add(this.lblCreatedOn);
            this.Controls.Add(this.lblLastLogOff);
            this.Controls.Add(this.btnSearchFriend);
            this.Controls.Add(this.btnNextFriend);
            this.Controls.Add(this.btnPrevFriend);
            this.Controls.Add(this.pbxFriend);
            this.Controls.Add(this.pbxUser);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCompareFriends";
            this.Opacity = 0.9D;
            this.Text = "CompareFriends";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmCompareFriends_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFriend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.PictureBox pbxFriend;
        private System.Windows.Forms.Button btnPrevFriend;
        private System.Windows.Forms.Button btnNextFriend;
        private System.Windows.Forms.Button btnSearchFriend;
        private System.Windows.Forms.Label lblLastLogOff;
        private System.Windows.Forms.Label lblCreatedOn;
        private System.Windows.Forms.Label lblTotalFriends;
        private System.Windows.Forms.Label lblFriendSince;
        private System.Windows.Forms.Label lblFriendName;
        private System.Windows.Forms.Label lblFriendLastLogOff;
        private System.Windows.Forms.Label lblFriendCreatedOn;
        private System.Windows.Forms.Button btnSwitchPlaces;
        private System.Windows.Forms.Button btnGetAllGames;
        private System.Windows.Forms.Button btnPrevGame;
        private System.Windows.Forms.Button btnNextGame;
        private System.Windows.Forms.Label lblCurrentGameName;
        private System.Windows.Forms.Label lblTotalCommonGames;
        private System.Windows.Forms.Label lblTotalGames;
        private System.Windows.Forms.Label lblTotalFriendGames;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFavGame;
        private System.Windows.Forms.Label lblFriendFavGame;
        private System.Windows.Forms.Label lblLastPlayed;
        private System.Windows.Forms.Label lblFriendLastPlayed;
        private System.Windows.Forms.Label lblTotalGameHours;
    }
}