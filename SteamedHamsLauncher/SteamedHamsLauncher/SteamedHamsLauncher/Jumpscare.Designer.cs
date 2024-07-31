namespace SteamedHamsLauncher
{
    partial class FrmJumpscare
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
            // Bereinige die Ressourcen
            if (disposing)
            {
                components?.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJumpscare));
            this.pbxJumpscare = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJumpscare)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxJumpscare
            // 
            this.pbxJumpscare.Image = ((System.Drawing.Image)(resources.GetObject("pbxJumpscare.Image")));
            this.pbxJumpscare.Location = new System.Drawing.Point(-1, 0);
            this.pbxJumpscare.Name = "pbxJumpscare";
            this.pbxJumpscare.Size = new System.Drawing.Size(1920, 1080);
            this.pbxJumpscare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxJumpscare.TabIndex = 0;
            this.pbxJumpscare.TabStop = false;
            this.pbxJumpscare.Click += new System.EventHandler(this.pbxJumpscare_Click);
            // 
            // FrmJumpscare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 386);
            this.Controls.Add(this.pbxJumpscare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmJumpscare";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Jumpscare";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmJumpscare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxJumpscare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxJumpscare;
    }
}