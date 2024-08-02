namespace SteamedHamsLauncher
{
    partial class FrmGamesSearch
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
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbxResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(12, 50);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(260, 20);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(12, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(260, 32);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbxResults
            // 
            this.lbxResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbxResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxResults.FormattingEnabled = true;
            this.lbxResults.Location = new System.Drawing.Point(12, 76);
            this.lbxResults.Name = "lbxResults";
            this.lbxResults.Size = new System.Drawing.Size(260, 184);
            this.lbxResults.TabIndex = 1;
            this.lbxResults.SelectedIndexChanged += new System.EventHandler(this.lbxResults_SelectedIndexChanged);
            // 
            // FrmGamesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(284, 273);
            this.Controls.Add(this.lbxResults);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbxSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmGamesSearch";
            this.Opacity = 0.9D;
            this.Text = "GamesSearch";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmGamesSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lbxResults;
    }
}