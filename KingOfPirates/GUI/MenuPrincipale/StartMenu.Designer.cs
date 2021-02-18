
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
            this.SuspendLayout();
            // 
            // Nassau_button
            // 
            this.Nassau_button.Location = new System.Drawing.Point(243, 201);
            this.Nassau_button.Name = "Nassau_button";
            this.Nassau_button.Size = new System.Drawing.Size(75, 23);
            this.Nassau_button.TabIndex = 0;
            this.Nassau_button.Text = "nassau";
            this.Nassau_button.UseVisualStyleBackColor = true;
            this.Nassau_button.Click += new System.EventHandler(this.Nassau_button_Click);
            // 
            // Missioni_button
            // 
            this.Missioni_button.Location = new System.Drawing.Point(399, 201);
            this.Missioni_button.Name = "Missioni_button";
            this.Missioni_button.Size = new System.Drawing.Size(75, 23);
            this.Missioni_button.TabIndex = 1;
            this.Missioni_button.Text = "missioni";
            this.Missioni_button.UseVisualStyleBackColor = true;
            this.Missioni_button.Click += new System.EventHandler(this.Missioni_button_Click);
            // 
            // ScontroCarte_button
            // 
            this.ScontroCarte_button.Location = new System.Drawing.Point(563, 201);
            this.ScontroCarte_button.Name = "ScontroCarte_button";
            this.ScontroCarte_button.Size = new System.Drawing.Size(75, 23);
            this.ScontroCarte_button.TabIndex = 2;
            this.ScontroCarte_button.Text = "Scontro";
            this.ScontroCarte_button.UseVisualStyleBackColor = true;
            this.ScontroCarte_button.Click += new System.EventHandler(this.ScontroCarte_button_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
    }
}

