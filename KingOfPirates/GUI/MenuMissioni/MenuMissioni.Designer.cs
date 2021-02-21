using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using KingOfPirates.Missioni;
using System.Windows.Forms;

namespace KingOfPirates.GUI.MenuMissioni
{
    partial class FormMissione
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(int picBoxXSize, int picBoxYSize)
        {
            this.components = new System.ComponentModel.Container();
            this.cartinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sopra_button = new System.Windows.Forms.Button();
            this.Sinistra_button = new System.Windows.Forms.Button();
            this.Sotto_button = new System.Windows.Forms.Button();
            this.Destra_button = new System.Windows.Forms.Button();
            this.Movimento_label = new System.Windows.Forms.Label();
            this.Griglia_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Griglia_pictureBox = new System.Windows.Forms.PictureBox[picBoxXSize, picBoxYSize];
            ((System.ComponentModel.ISupportInitialize)(this.cartinaBindingSource)).BeginInit();
            this.Griglia_tableLayoutPanel.SuspendLayout();
            for (int i = 0; i < picBoxXSize; i++)
            {
                for (int j = 0; j < picBoxYSize; j++)
                {
                    this.Griglia_pictureBox[i, j] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.Griglia_pictureBox[i, j])).BeginInit();
                }
            }
            this.SuspendLayout();

            #region Joystick

            int JoystickStartPointX = 1090;
            int JoystickStartPointY = 500;
            // 
            // Sopra_button
            // 
            this.Sopra_button.Location = new System.Drawing.Point(JoystickStartPointX + 53, JoystickStartPointY);
            this.Sopra_button.Name = "Sopra_button";
            this.Sopra_button.Size = new System.Drawing.Size(50, 50);
            this.Sopra_button.TabIndex = 1;
            this.Sopra_button.Text = "Sopra";
            this.Sopra_button.UseVisualStyleBackColor = true;
            this.Sopra_button.Click += new System.EventHandler(this.Sopra_button_Click);
            // 
            // Sinistra_button
            // 
            this.Sinistra_button.Location = new System.Drawing.Point(JoystickStartPointX, JoystickStartPointY + 53);
            this.Sinistra_button.Name = "Sinistra_button";
            this.Sinistra_button.Size = new System.Drawing.Size(50, 50);
            this.Sinistra_button.TabIndex = 2;
            this.Sinistra_button.Text = "Sinistra";
            this.Sinistra_button.UseVisualStyleBackColor = true;
            this.Sinistra_button.Click += new System.EventHandler(this.Sinistra_button_Click);
            // 
            // Sotto_button
            // 
            this.Sotto_button.Location = new System.Drawing.Point(JoystickStartPointX + 53, JoystickStartPointY + 106);
            this.Sotto_button.Name = "Sotto_button";
            this.Sotto_button.Size = new System.Drawing.Size(50, 50);
            this.Sotto_button.TabIndex = 3;
            this.Sotto_button.Text = "Sotto";
            this.Sotto_button.UseVisualStyleBackColor = true;
            this.Sotto_button.Click += new System.EventHandler(this.Sotto_button_Click);
            // 
            // Destra_button
            // 
            this.Destra_button.Location = new System.Drawing.Point(JoystickStartPointX + 106, JoystickStartPointY + 53);
            this.Destra_button.Name = "Destra_button";
            this.Destra_button.Size = new System.Drawing.Size(50, 50);
            this.Destra_button.TabIndex = 4;
            this.Destra_button.Text = "Destra";
            this.Destra_button.UseVisualStyleBackColor = true;
            this.Destra_button.Click += new System.EventHandler(this.Destra_button_Click);
            // 
            // Movimento_label
            // 
            this.Movimento_label.Location = new System.Drawing.Point(JoystickStartPointX + 53, JoystickStartPointY + 53);
            this.Movimento_label.Name = "Movimento_label";
            this.Movimento_label.Size = new System.Drawing.Size(50, 50);
            this.Movimento_label.TabIndex = 5;
            this.Movimento_label.Text = "Move";
            this.Movimento_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            #endregion

            #region Matrice pictureBox

            //
            // Griglia_tableLayoutPanel
            //
            
            this.Griglia_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Griglia_tableLayoutPanel.Size = new System.Drawing.Size(1090, 680);
            this.Griglia_tableLayoutPanel.Name = "Griglia_tableLayoutPanel";
            this.Griglia_tableLayoutPanel.TabIndex = 4;
            this.Griglia_tableLayoutPanel.ColumnCount = picBoxXSize;
            this.Griglia_tableLayoutPanel.RowCount = picBoxYSize;

            for (int i = 0; i < picBoxXSize; i++)
            {
                for (int j = 0; j < picBoxYSize; j++)
                {
                    this.Griglia_tableLayoutPanel.Controls.Add(this.Griglia_pictureBox[i, j], i, j);
                }
            }

            // 
            // Griglia_pictureBox[,]
            // 50 + 3 pixel

            //int tmp_locX = 0;
            //int tmp_locY = 0;
            for (int i = 0; i < picBoxXSize; i++)
            {
                for (int j = 0; j < picBoxYSize; j++)
                {
                    //this.Griglia_pictureBox[i, j].Location = new System.Drawing.Point(tmp_locX, tmp_locY);
                    this.Griglia_pictureBox[i, j].Name = "Griglia_pictureBox" + i + j;
                    this.Griglia_pictureBox[i, j].Size = new System.Drawing.Size(50, 50);
                    this.Griglia_pictureBox[i, j].TabIndex = 0;
                    this.Griglia_pictureBox[i, j].TabStop = false;
                    this.Griglia_pictureBox[i, j].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    this.Griglia_pictureBox[i, j].BackgroundImage = Properties.Resources.mare;
                    //tmp_locY += 53;
                }
                //tmp_locX += 53;
            }

            #endregion

            // 
            // MenuMissioni
            // 16 pixel tolti dalla cornice, 39 pixel tolti dalla barra del titolo

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Griglia_tableLayoutPanel);
            this.Controls.Add(this.Movimento_label);
            this.Controls.Add(this.Destra_button);
            this.Controls.Add(this.Sotto_button);
            this.Controls.Add(this.Sinistra_button);
            this.Controls.Add(this.Sopra_button);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuMissioni_FormClosing);
            this.Name = "MenuMissioni";
            this.Text = "MenuMissioni";
            ((System.ComponentModel.ISupportInitialize)(this.cartinaBindingSource)).EndInit();
            this.Griglia_tableLayoutPanel.ResumeLayout(false);
            for (int i = 0; i < picBoxXSize; i++)
            {
                for (int j = 0; j < picBoxYSize; j++)
                {
                    ((System.ComponentModel.ISupportInitialize)(this.Griglia_pictureBox[i, j])).EndInit();
                }
            }
            this.ResumeLayout(false);
        }

        // Variabili

        private System.Windows.Forms.BindingSource cartinaBindingSource;
        private System.Windows.Forms.Button Sopra_button;
        private System.Windows.Forms.Button Sinistra_button;
        private System.Windows.Forms.Button Sotto_button;
        private System.Windows.Forms.Button Destra_button;
        private System.Windows.Forms.Label Movimento_label;
        private System.Windows.Forms.TableLayoutPanel Griglia_tableLayoutPanel;
        private System.Windows.Forms.PictureBox[,] Griglia_pictureBox;

        // Propieta'

        public PictureBox[,] Griglia_pictureBox_ { get => Griglia_pictureBox; set => Griglia_pictureBox = value; }
    }
}