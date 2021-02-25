using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingOfPirates.Cartina;
using KingOfPirates.Missioni.Navi;
using KingOfPirates.Nassau;

namespace KingOfPirates.GUI.MenuNassau
{
    public partial class Porto_form : Form
    {

        private Porto porto = new Porto();


        public Porto_form()
        {
            InitializeComponent();

            LoadData();
        }

        private void Porto_Salpa_Button_Click(object sender, EventArgs e)
        {
            porto.Salpa();
        }

        private void Porto_UpCannoni_Button_Click(object sender, EventArgs e)
        {
            porto.PotenziaCannoni();
        }

        private void Porto_UpScafo_Button_Click(object sender, EventArgs e)
        {
            porto.PotenziaScafo();
        }

        private void Porto_UpVela_Button_Click(object sender, EventArgs e)
        {
            porto.PotenziaVele();
        }

        private void LoadData() {
            Porto_CanPrezzo_Label.Text = (porto.PrezzoCannoni[porto.LivelloCannoni]).ToString() + " $";
            Porto_ScaPrezzo_Label.Text = (porto.PrezzoScafo[porto.LivelloScafo]).ToString() + " $";
            Porto_VelPrezzo_Label.Text = (porto.PrezzoVele[porto.LivelloVele]).ToString() + " $";
        }

        private void Porto_Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
