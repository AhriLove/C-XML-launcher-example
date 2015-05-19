namespace MyLauncher
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.newsPanel = new System.Windows.Forms.Panel();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.hordeOnline = new System.Windows.Forms.Label();
            this.allianceOnline = new System.Windows.Forms.Label();
            this.hordeIcon = new System.Windows.Forms.PictureBox();
            this.allianceIcon = new System.Windows.Forms.PictureBox();
            this.onlinePlayers = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hordeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allianceIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // newsPanel
            // 
            this.newsPanel.Location = new System.Drawing.Point(250, 123);
            this.newsPanel.Name = "newsPanel";
            this.newsPanel.Size = new System.Drawing.Size(504, 334);
            this.newsPanel.TabIndex = 0;
            this.newsPanel.Visible = false;
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.hordeOnline);
            this.statusPanel.Controls.Add(this.allianceOnline);
            this.statusPanel.Controls.Add(this.hordeIcon);
            this.statusPanel.Controls.Add(this.allianceIcon);
            this.statusPanel.Controls.Add(this.onlinePlayers);
            this.statusPanel.Controls.Add(this.status);
            this.statusPanel.Location = new System.Drawing.Point(595, 27);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(165, 62);
            this.statusPanel.TabIndex = 1;
            this.statusPanel.Visible = false;
            // 
            // hordeOnline
            // 
            this.hordeOnline.ForeColor = System.Drawing.Color.Firebrick;
            this.hordeOnline.Location = new System.Drawing.Point(87, 37);
            this.hordeOnline.Name = "hordeOnline";
            this.hordeOnline.Size = new System.Drawing.Size(49, 20);
            this.hordeOnline.TabIndex = 5;
            this.hordeOnline.Text = "0";
            this.hordeOnline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // allianceOnline
            // 
            this.allianceOnline.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.allianceOnline.Location = new System.Drawing.Point(29, 37);
            this.allianceOnline.Name = "allianceOnline";
            this.allianceOnline.Size = new System.Drawing.Size(52, 20);
            this.allianceOnline.TabIndex = 4;
            this.allianceOnline.Text = "0";
            this.allianceOnline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hordeIcon
            // 
            this.hordeIcon.Image = global::MyLauncher.Properties.Resources.launcher_horde;
            this.hordeIcon.Location = new System.Drawing.Point(142, 37);
            this.hordeIcon.Name = "hordeIcon";
            this.hordeIcon.Size = new System.Drawing.Size(20, 20);
            this.hordeIcon.TabIndex = 3;
            this.hordeIcon.TabStop = false;
            // 
            // allianceIcon
            // 
            this.allianceIcon.Image = global::MyLauncher.Properties.Resources.launcher_alliance;
            this.allianceIcon.Location = new System.Drawing.Point(3, 37);
            this.allianceIcon.Name = "allianceIcon";
            this.allianceIcon.Size = new System.Drawing.Size(20, 20);
            this.allianceIcon.TabIndex = 2;
            this.allianceIcon.TabStop = false;
            // 
            // onlinePlayers
            // 
            this.onlinePlayers.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.onlinePlayers.Location = new System.Drawing.Point(6, 20);
            this.onlinePlayers.Name = "onlinePlayers";
            this.onlinePlayers.Size = new System.Drawing.Size(156, 14);
            this.onlinePlayers.TabIndex = 1;
            this.onlinePlayers.Text = "0 Jugadores online";
            this.onlinePlayers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // status
            // 
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(3, 4);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(159, 15);
            this.status.TabIndex = 0;
            this.status.Text = "Offline";
            this.status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::MyLauncher.Properties.Resources.back_launcher;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.newsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Launcher WoW";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hordeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allianceIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel newsPanel;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox allianceIcon;
        private System.Windows.Forms.Label onlinePlayers;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.PictureBox hordeIcon;
        private System.Windows.Forms.Label hordeOnline;
        private System.Windows.Forms.Label allianceOnline;
    }
}

