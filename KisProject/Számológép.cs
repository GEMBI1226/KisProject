using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisProject
{
    public partial class Számológép : Form 
    {
        public Számológép()
        {
            InitializeComponent();
        }

        private void Számológép_Load(object sender, EventArgs e)
        {
            Screen.Text = GlobalVar.onScreen;

        }

        private void Number1_Click(object sender, EventArgs e)
        {
            GlobalVar.onScreen += "1";
            Screen.Text = GlobalVar.onScreen;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           GlobalVar.result = 0;
            Screen.Text = GlobalVar.onScreen;

        }

        private void btnSimpleClear_Click(object sender, EventArgs e)
        {
            GlobalVar.onScreen = GlobalVar.onScreen.Substring(0, GlobalVar.onScreen.Length -1) ;
            Screen.Text = GlobalVar.onScreen;


        }

        private void btnModulo_Click(object sender, EventArgs e)
        {


        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            GlobalVar.onScreen += "/";
            Screen.Text = GlobalVar.onScreen;


        }

        private void Number7_Click(object sender, EventArgs e)
        {
            GlobalVar.onScreen += "7";
            Screen.Text = GlobalVar.onScreen;


        }

        private void Number8_Click(object sender, EventArgs e)
        {
            GlobalVar.onScreen += "8";
            Screen.Text = GlobalVar.onScreen;


        }

        private void Number9_Click(object sender, EventArgs e)
        {
            GlobalVar.onScreen += "9";
            Screen.Text = GlobalVar.onScreen;


        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            GlobalVar.onScreen += "x";
            Screen.Text = GlobalVar.onScreen;


        }

        private void Number4_Click(object sender, EventArgs e)
        {
            GlobalVar.onScreen += "4";
            Screen.Text = GlobalVar.onScreen;


        }

        private void Number5_Click(object sender, EventArgs e)
        {
            GlobalVar.onScreen += "5";
            Screen.Text = GlobalVar.onScreen;


        }

        private void Number6_Click(object sender, EventArgs e)
        {
            GlobalVar.onScreen += "6";
            Screen.Text = GlobalVar.onScreen;


        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            GlobalVar.onScreen += "-";
            Screen.Text = GlobalVar.onScreen;


        }

        private void Number2_Click(object sender, EventArgs e)
        {
            GlobalVar.onScreen += "2";
            Screen.Text = GlobalVar.onScreen;


        }

        private void Number3_Click(object sender, EventArgs e)
        {
            GlobalVar.onScreen += "3";
            Screen.Text = GlobalVar.onScreen;


        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            GlobalVar.onScreen += "+";
            Screen.Text = GlobalVar.onScreen;


        }

        private void btnSingChangeKey_Click(object sender, EventArgs e)
        {
            // ez az a gomb ami ha beirunk egy számot - re váltja és fordítva
            if (GlobalVar.onScreen.StartsWith("-"))
            {
                GlobalVar.onScreen = GlobalVar.onScreen.Substring(1);
            }
            else
            {
                GlobalVar.onScreen = "-" + GlobalVar.onScreen;
            }
            Screen.Text = GlobalVar.onScreen;

        }

        private void Number0_Click(object sender, EventArgs e)
        {
            GlobalVar.onScreen += "0";
            Screen.Text = GlobalVar.onScreen;

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            Screen.Text = GlobalVar.result.ToString(); 
        }

        private void Screen_Click(object sender, EventArgs e)
        {

        }
    }
}
