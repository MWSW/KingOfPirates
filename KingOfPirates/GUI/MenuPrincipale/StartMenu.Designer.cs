
namespace KingOfPirates.GUI.MenuPrincipale
{
    partial class StartMenu
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nassau_button = new System.Windows.Forms.Button();
            this.Missioni_button = new System.Windows.Forms.Button();
            this.ScontroCarte_button = new System.Windows.Forms.Button();
            this.Titolo_label = new System.Windows.Forms.Label();
            this.Start_button = new System.Windows.Forms.Button();
            this.Crediti_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nassau_button
            // 
            this.Nassau_button.Location = new System.Drawing.Point(1177, 12);
            this.Nassau_button.Name = "Nassau_button";
            this.Nassau_button.Size = new System.Drawing.Size(75, 23);
            this.Nassau_button.TabIndex = 0;
            this.Nassau_button.Text = "nassau";
            this.Nassau_button.UseVisualStyleBackColor = true;
            this.Nassau_button.Click += new System.EventHandler(this.Nassau_button_Click);
            // 
            // Missioni_button
            // 
            this.Missioni_button.Location = new System.Drawing.Point(1177, 41);
            this.Missioni_button.Name = "Missioni_button";
            this.Missioni_button.Size = new System.Drawing.Size(75, 23);
            this.Missioni_button.TabIndex = 1;
            this.Missioni_button.Text = "missioni";
            this.Missioni_button.UseVisualStyleBackColor = true;
            this.Missioni_button.Click += new System.EventHandler(this.Missioni_button_Click);
            // 
            // ScontroCarte_button
            // 
            this.ScontroCarte_button.Location = new System.Drawing.Point(1177, 70);
            this.ScontroCarte_button.Name = "ScontroCarte_button";
            this.ScontroCarte_button.Size = new System.Drawing.Size(75, 23);
            this.ScontroCarte_button.TabIndex = 2;
            this.ScontroCarte_button.Text = "Scontro";
            this.ScontroCarte_button.UseVisualStyleBackColor = true;
            this.ScontroCarte_button.Click += new System.EventHandler(this.ScontroCarte_button_Click);
            // 
            // Titolo_label
            // 
            this.Titolo_label.BackColor = System.Drawing.Color.Transparent;
            this.Titolo_label.Font = new System.Drawing.Font("Papyrus", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titolo_label.Location = new System.Drawing.Point(13, 13);
            this.Titolo_label.Name = "Titolo_label";
            this.Titolo_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Titolo_label.Size = new System.Drawing.Size(333, 108);
            this.Titolo_label.TabIndex = 3;
            this.Titolo_label.Text = "King Of Pirates";
            this.Titolo_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start_button
            // 
            this.Start_button.BackColor = System.Drawing.Color.Peru;
            this.Start_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Start_button.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.Start_button.ForeColor = System.Drawing.Color.Black;
            this.Start_button.Location = new System.Drawing.Point(12, 582);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(110, 25);
            this.Start_button.TabIndex = 4;
            this.Start_button.Text = "Inizia l\'Avventura";
            this.Start_button.UseVisualStyleBackColor = false;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Crediti_button
            // 
            this.Crediti_button.BackColor = System.Drawing.Color.Peru;
            this.Crediti_button.Location = new System.Drawing.Point(12, 613);
            this.Crediti_button.Name = "Crediti_button";
            this.Crediti_button.Size = new System.Drawing.Size(110, 25);
            this.Crediti_button.TabIndex = 5;
            this.Crediti_button.Text = "Crediti";
            this.Crediti_button.UseVisualStyleBackColor = false;
            this.Crediti_button.Click += new System.EventHandler(this.Crediti_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.Peru;
            this.Exit_button.Location = new System.Drawing.Point(12, 644);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(110, 25);
            this.Exit_button.TabIndex = 6;
            this.Exit_button.Text = "Esci";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KingOfPirates.Properties.Resources.menuBackImg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Crediti_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.Titolo_label);
            this.Controls.Add(this.ScontroCarte_button);
            this.Controls.Add(this.Missioni_button);
            this.Controls.Add(this.Nassau_button);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Nassau_button;
        private System.Windows.Forms.Button Missioni_button;
        private System.Windows.Forms.Button ScontroCarte_button;
        private System.Windows.Forms.Label Titolo_label;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Crediti_button;
        private System.Windows.Forms.Button Exit_button;
    }
}

