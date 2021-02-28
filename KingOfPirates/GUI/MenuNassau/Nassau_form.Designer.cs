
namespace KingOfPirates.GUI.MenuNassau
{
    partial class Nassau_form
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
            this.NegozioImgButton = new System.Windows.Forms.PictureBox();
            this.LocandaImgButton = new System.Windows.Forms.PictureBox();
            this.PortoImgButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NegozioImgButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocandaImgButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortoImgButton)).BeginInit();
            this.SuspendLayout();
            // 
            // NegozioImgButton
            // 
            this.NegozioImgButton.BackColor = System.Drawing.Color.Transparent;
            this.NegozioImgButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NegozioImgButton.Image = global::KingOfPirates.Properties.Resources.Shop_;
            this.NegozioImgButton.Location = new System.Drawing.Point(688, 473);
            this.NegozioImgButton.Margin = new System.Windows.Forms.Padding(4);
            this.NegozioImgButton.Name = "NegozioImgButton";
            this.NegozioImgButton.Size = new System.Drawing.Size(213, 284);
            this.NegozioImgButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NegozioImgButton.TabIndex = 5;
            this.NegozioImgButton.TabStop = false;
            this.NegozioImgButton.Click += new System.EventHandler(this.NegozioImgButton_Click);
            // 
            // LocandaImgButton
            // 
            this.LocandaImgButton.BackColor = System.Drawing.Color.Transparent;
            this.LocandaImgButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LocandaImgButton.Image = global::KingOfPirates.Properties.Resources.GerriInn2;
            this.LocandaImgButton.Location = new System.Drawing.Point(1209, 310);
            this.LocandaImgButton.Margin = new System.Windows.Forms.Padding(4);
            this.LocandaImgButton.Name = "LocandaImgButton";
            this.LocandaImgButton.Size = new System.Drawing.Size(248, 350);
            this.LocandaImgButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LocandaImgButton.TabIndex = 4;
            this.LocandaImgButton.TabStop = false;
            this.LocandaImgButton.Click += new System.EventHandler(this.LocandaImgButton_Click);
            // 
            // PortoImgButton
            // 
            this.PortoImgButton.BackColor = System.Drawing.Color.LightGray;
            this.PortoImgButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PortoImgButton.Image = global::KingOfPirates.Properties.Resources.Porto_;
            this.PortoImgButton.Location = new System.Drawing.Point(66, 310);
            this.PortoImgButton.Margin = new System.Windows.Forms.Padding(4);
            this.PortoImgButton.Name = "PortoImgButton";
            this.PortoImgButton.Size = new System.Drawing.Size(244, 342);
            this.PortoImgButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PortoImgButton.TabIndex = 3;
            this.PortoImgButton.TabStop = false;
            this.PortoImgButton.Click += new System.EventHandler(this.PortoImgButton_Click);
            // 
            // Nassau_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::KingOfPirates.Properties.Resources.MokeyIslandBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.NegozioImgButton);
            this.Controls.Add(this.LocandaImgButton);
            this.Controls.Add(this.PortoImgButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Nassau_form";
            this.Text = "King of Pirates - Nassau";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nassau_form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.NegozioImgButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocandaImgButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortoImgButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox NegozioImgButton;
        private System.Windows.Forms.PictureBox LocandaImgButton;
        private System.Windows.Forms.PictureBox PortoImgButton;
    }
}