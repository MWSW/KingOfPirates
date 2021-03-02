using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KingOfPirates.GUI.MenuPrincipale
{
    /// <summary>
    /// Form che mostra i crediti
    /// </summary>
    public partial class CreditiForm : Form
    {
        public CreditiForm()
        {
            InitializeComponent();
        }

        private void crediti_label_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/chichibio-savoiardi/KingOfPirates");
        }

        private void CreditiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Gioco.startMenu.Show();
        }
    }
}
