using KingOfPirates.Missioni;

namespace KingOfPirates.GUI.Missioni
{
    partial class MenuMissioni
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
            this.components = new System.ComponentModel.Container();
            this.cartinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sopra_button = new System.Windows.Forms.Button();
            this.Sinistra_button = new System.Windows.Forms.Button();
            this.Sotto_button = new System.Windows.Forms.Button();
            this.Destra_button = new System.Windows.Forms.Button();
            this.Movimento_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Sopra_button
            // 
            this.Sopra_button.Location = new System.Drawing.Point(578, 496);
            this.Sopra_button.Name = "Sopra_button";
            this.Sopra_button.Size = new System.Drawing.Size(50, 50);
            this.Sopra_button.TabIndex = 1;
            this.Sopra_button.Text = "Sopra";
            this.Sopra_button.UseVisualStyleBackColor = true;
            this.Sopra_button.Click += new System.EventHandler(this.Sopra_button_Click);
            // 
            // Sinistra_button
            // 
            this.Sinistra_button.Location = new System.Drawing.Point(522, 552);
            this.Sinistra_button.Name = "Sinistra_button";
            this.Sinistra_button.Size = new System.Drawing.Size(50, 50);
            this.Sinistra_button.TabIndex = 2;
            this.Sinistra_button.Text = "Sinistra";
            this.Sinistra_button.UseVisualStyleBackColor = true;
            this.Sinistra_button.Click += new System.EventHandler(this.Sinistra_button_Click);
            // 
            // Sotto_button
            // 
            this.Sotto_button.Location = new System.Drawing.Point(578, 608);
            this.Sotto_button.Name = "Sotto_button";
            this.Sotto_button.Size = new System.Drawing.Size(50, 50);
            this.Sotto_button.TabIndex = 3;
            this.Sotto_button.Text = "Sotto";
            this.Sotto_button.UseVisualStyleBackColor = true;
            this.Sotto_button.Click += new System.EventHandler(this.Sotto_button_Click);
            // 
            // Destra_button
            // 
            this.Destra_button.Location = new System.Drawing.Point(634, 552);
            this.Destra_button.Name = "Destra_button";
            this.Destra_button.Size = new System.Drawing.Size(50, 50);
            this.Destra_button.TabIndex = 4;
            this.Destra_button.Text = "Destra";
            this.Destra_button.UseVisualStyleBackColor = true;
            this.Destra_button.Click += new System.EventHandler(this.Destra_button_Click);
            // 
            // Movimento_label
            // 
            this.Movimento_label.Location = new System.Drawing.Point(578, 552);
            this.Movimento_label.Name = "Movimento_label";
            this.Movimento_label.Size = new System.Drawing.Size(50, 50);
            this.Movimento_label.TabIndex = 5;
            this.Movimento_label.Text = "Move";
            this.Movimento_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuMissioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Movimento_label);
            this.Controls.Add(this.Destra_button);
            this.Controls.Add(this.Sotto_button);
            this.Controls.Add(this.Sinistra_button);
            this.Controls.Add(this.Sopra_button);
            this.Name = "MenuMissioni";
            this.Text = "MenuMissioni";
            ((System.ComponentModel.ISupportInitialize)(this.cartinaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource cartinaBindingSource;
        private System.Windows.Forms.Button Sopra_button;
        private System.Windows.Forms.Button Sinistra_button;
        private System.Windows.Forms.Button Sotto_button;
        private System.Windows.Forms.Button Destra_button;
        private System.Windows.Forms.Label Movimento_label;
    }
}