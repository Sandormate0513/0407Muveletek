using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0407muveletek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int szam1;
        int szam2;
        int megoldas;
        private void ujBT_Click(object sender, EventArgs e)
        {
            
            if (muveletekCB.SelectedItem.Equals("Osztás"))
            {
                szam1 = 44;
                szam2 = 4;
                megoldas = 11;
                feladatTB.Text = $"{szam1} / {szam2} = ";
            }
        }

        private void ellBT_Click(object sender, EventArgs e)
        {
            int be = Int32.Parse(valaszTB.Text);
            if (be == megoldas)
            {
                visszajelTB.Text = "Jó megoldás";

            }
            else {
                visszajelTB.Text = "nem jó megoldás";
            }
        }

    }
}
