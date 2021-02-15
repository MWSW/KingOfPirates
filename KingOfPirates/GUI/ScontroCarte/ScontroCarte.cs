using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingOfPirates.GUI.ScontroCarte
{
    public partial class ScontroCarte : Form
    {
        public ScontroCarte()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            //Assegnare delle carte al giocatore
            MessageBox.Show("Hello my friends!");
        }
    }
}
