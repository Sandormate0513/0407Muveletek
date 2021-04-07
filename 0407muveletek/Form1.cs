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
        int muvelet;
        string[] muveletek = {"+","-","*","/"};
        int[,] statisztika = { { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 } };
        private void ujBT_Click(object sender, EventArgs e)
        {
            ujkerdes();
            
        }

        private void ellBT_Click(object sender, EventArgs e)
        {
            bool helyesmegoldas = ellenoriz();
            ertekel(helyesmegoldas);
            ujkerdes();
        }

        private void muveletekCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void ujkerdes()
        {
            szamokgeneral(); 
            feladatTB.Text = $"{szam1} {muveletek[muvelet]} {szam2} = ";
        }
        private void muveletbeker() 
        {
            muvelet = muveletekCB.SelectedIndex;
        }
        Random r = new Random();
        private void szamokgeneral()
        {
            switch (muvelet)
            {
                case 0: //osszead
                    megoldas = r.Next(0, 100);
                    szam1 = r.Next(1, megoldas);
                    szam2 = megoldas - szam1;
                    break;
                case 1: //kivon
                    megoldas = r.Next(0, 100);
                    szam2 = r.Next(1, 100-megoldas);
                    szam1 = megoldas + szam2;
                    break;
                case 2: //szoroz
                    szam2 = r.Next(1, 10);
                    szam1 = r.Next(1, 10);
                    megoldas = szam1 * szam2;
                    break;
                case 3://oszt
                    megoldas = r.Next(1, 10);
                    szam2 = r.Next(1, 10);
                    szam1 = megoldas * szam2;
                    break;
            }
        }
        private bool ellenoriz() 
        {
            int be = Int32.Parse(valaszTB.Text);
            bool helyesmegoldas = be == megoldas;
            if (helyesmegoldas)
            {
                visszajelTB.Text = "Jó megoldás";
            }
            else
            {
                visszajelTB.Text = "nem jó megoldás";
            }
            return helyesmegoldas;
        }

        private void ertekel(bool helyesmegoldas)
        {
            statisztika[muvelet, 0]++;
            if (helyesmegoldas)
            {
                statisztika[muvelet, 1]++;
            }
            kiir();
        }
        private void kiir()
        {
            string[] s = { "Statisztika:" ,
                           "Összeadás:\t",
                           "Kivonás:\t\t",
                           "Szorzás:\t\t",
                           "Osztás:\t\t",
                           "Összesen:\t" 
            };
            int[] ossz = {0,0};
            double szazalek;
            for (int i = 0; i < muveletek.Length; i++)
            {
                szazalek = (double)statisztika[i, 1] / (double)statisztika[i, 0] * 100;
                ossz[0] += statisztika[i, 0];
                ossz[1] += statisztika[i, 1];
                s[i + 1] += $"{statisztika[i, 0]} / {statisztika[i, 1]} ({szazalek}%)";
            }
            szazalek = (double)ossz[1] / (double)ossz[0] * 100;
            s[5] += $"{ossz[0]} / {ossz[1]} ({szazalek}%)";
            statLB.Items.Clear();
            foreach (var item in s)
            {
                statLB.Items.Add(item);
            }
            
        }

        private void muveletekTSCB_Click(object sender, EventArgs e)
        {
            //idekell
            muveletbeker();
            ujkerdes();
        }
    }
}
