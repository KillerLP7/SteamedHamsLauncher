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
            this.btnSearchFriend.Location = new System.Drawing.Point(12, 12);
            this.btnSearchFriend.Name = "btnSearchFriend";
            this.btnSearchFriend.Size = new System.Drawing.Size(993, 131);
            this.btnSearchFriend.TabIndex = 2;
            this.btnSearchFriend.Text = "Search Friend";
            this.btnSearchFriend.UseVisualStyleBackColor = false;
            this.btnSearchFriend.Click += new System.EventHandler(this.btnSearchFriend_Click);
            // 
            // lblLastLogOff
            // 
            this.lblLastLogOff.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastLogOff.Location = new System.Drawing.Point(12, 336);
            this.lblLastLogOff.Name = "lblLastLogOff";
            this.lblLastLogOff.Size = new System.Drawing.Size(411, 53);
            this.lblLastLogOff.TabIndex = 6;
            this.lblLastLogOff.Text = "Last time logged in: ";
            this.lblLastLogOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreatedOn
            // 
            this.lblCreatedOn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedOn.Location = new System.Drawing.Point(12, 464);
            this.lblCreatedOn.Name = "lblCreatedOn";
            this.lblCreatedOn.Size = new System.Drawing.Size(411, 60);
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
            this.lblFriendSince.Location = new System.Drawing.Point(509, 375);
            this.lblFriendSince.Name = "lblFriendSince";
            this.lblFriendSince.Size = new System.Drawing.Size(414, 107);
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
            this.lblFriendLastLogOff.Location = new System.Drawing.Point(510, 336);
            this.lblFriendLastLogOff.Name = "lblFriendLastLogOff";
            this.lblFriendLastLogOff.Size = new System.Drawing.Size(411, 53);
            this.lblFriendLastLogOff.TabIndex = 11;
            this.lblFriendLastLogOff.Text = "Last time logged in: ";
            this.lblFriendLastLogOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriendCreatedOn
            // 
            this.lblFriendCreatedOn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriendCreatedOn.Location = new System.Drawing.Point(512, 464);
            this.lblFriendCreatedOn.Name = "lblFriendCreatedOn";
            this.lblFriendCreatedOn.Size = new System.Drawing.Size(411, 60);
            this.lblFriendCreatedOn.TabIndex = 12;
            this.lblFriendCreatedOn.Text = "Created on:";
            this.lblFriendCreatedOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCompareFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1017, 617);
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
    }
}