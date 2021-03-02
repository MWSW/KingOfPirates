
namespace KingOfPirates.GUI.MenuPrincipale
{
    partial class CreditiForm
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
            this.crediti_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crediti_label
            // 
            this.crediti_label.BackColor = System.Drawing.Color.Transparent;
            this.crediti_label.Location = new System.Drawing.Point(93, 9);
            this.crediti_label.Name = "crediti_label";
            this.crediti_label.Size = new System.Drawing.Size(311, 260);
            this.crediti_label.TabIndex = 0;
            this.crediti_label.Text = "Men Who Sold The World:\r\n- Iuri Antico\r\n- Andrea Ruben Ricciardi\r\n- Emanuele Pari" +
    "netti\r\n\r\nLicenza: MIT License\r\n\r\nGitHub: https://github.com/chichibio-savoiardi/" +
    "KingOfPirates";
            this.crediti_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.crediti_label.Click += new System.EventHandler(this.crediti_label_Click);
            // 
            // CreditiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KingOfPirates.Properties.Resources.MokeyIslandBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.crediti_label);
            this.Name = "CreditiForm";
            this.Text = "CreditiForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreditiForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label crediti_label;
    }
}