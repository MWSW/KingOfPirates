using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingOfPirates.Nassau;
using KingOfPirates.Cartina;

namespace KingOfPirates.GUI.MenuNassau
{
    public partial class Locanda_form : Form
    {
        Locanda locanda = new Locanda();
        GestioneDominio gestoreDominio;

        public Locanda_form(GestioneDominio gestoreDominio)
        {
            this.gestoreDominio = gestoreDominio;
            InitializeComponent();

            LoadData();
        }

        private void Locanda_Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void LoadData()
        {

        }


    }
}
