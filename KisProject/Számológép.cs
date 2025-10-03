using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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


            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    
                    int size = Math.Min(btn.Width, btn.Height);
                    btn.Width = size;
                    btn.Height = size;

                 
                    GraphicsPath path = new GraphicsPath();
                    path.AddEllipse(0, 0, size, size);
                    btn.Region = new Region(path);

                    
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    
                    btn.Margin = new Padding(5);
                }
            }

        }


        private void Number1_Click(object sender, EventArgs e)
        {
            if (GlobalVar.onScreen == "Syntax Error")
            {
                GlobalVar.onScreen = "";
                GlobalVar.onScreen += "1";
                Screen.Text = GlobalVar.onScreen;
            }
            else
            {
                GlobalVar.onScreen += "1";
                Screen.Text = GlobalVar.onScreen;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GlobalVar.result = 0;
            GlobalVar.onScreen = "";
            Screen.Text = GlobalVar.onScreen;

        }

        private void btnSimpleClear_Click(object sender, EventArgs e)
        {
            if (GlobalVar.onScreen == "Syntax Error" || GlobalVar.onScreen == "")
            {
                GlobalVar.onScreen = "";
                Screen.Text = GlobalVar.onScreen;
            }
            else
            {
                GlobalVar.onScreen = GlobalVar.onScreen.Substring(0, GlobalVar.onScreen.Length - 1);
                Screen.Text = GlobalVar.onScreen;
            }



        }

        private void btnModulo_Click(object sender, EventArgs e)
        {


        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (GlobalVar.onScreen == "Syntax Error" || GlobalVar.onScreen == "")
            {
                GlobalVar.onScreen = "";
                Screen.Text = GlobalVar.onScreen;
            }
            else
            {
                GlobalVar.onScreen += "/";
                Screen.Text = GlobalVar.onScreen;
            }
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            if (GlobalVar.onScreen == "Syntax Error")
            {
                GlobalVar.onScreen = "";
                GlobalVar.onScreen += "7";
                Screen.Text = GlobalVar.onScreen;
            }
            else
            {
                GlobalVar.onScreen += "7";
                Screen.Text = GlobalVar.onScreen;
            }

        }

        private void Number8_Click(object sender, EventArgs e)
        {
            if (GlobalVar.onScreen == "Syntax Error")
            {
                GlobalVar.onScreen = "";
                GlobalVar.onScreen += "8";
                Screen.Text = GlobalVar.onScreen;
            }
            else
            {
                GlobalVar.onScreen += "8";
                Screen.Text = GlobalVar.onScreen;
            }
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            if (GlobalVar.onScreen == "Syntax Error")
            {
                GlobalVar.onScreen = "";
                GlobalVar.onScreen += "9";
                Screen.Text = GlobalVar.onScreen;
            }
            else
            {
                GlobalVar.onScreen += "9";
                Screen.Text = GlobalVar.onScreen;
            }

        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (GlobalVar.onScreen == "Syntax Error" || GlobalVar.onScreen == "")
            {
                GlobalVar.onScreen = "";
                Screen.Text = GlobalVar.onScreen;
            }
            else
            {
                GlobalVar.onScreen += "*";
                Screen.Text = GlobalVar.onScreen;
            }
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            if (GlobalVar.onScreen == "Syntax Error")
            {
                GlobalVar.onScreen = "";
                GlobalVar.onScreen += "4";
                Screen.Text = GlobalVar.onScreen;
            }
            else
            {
                GlobalVar.onScreen += "4";
                Screen.Text = GlobalVar.onScreen;
            }
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            if (GlobalVar.onScreen == "Syntax Error")
            {
                GlobalVar.onScreen = "";
                GlobalVar.onScreen += "5";
                Screen.Text = GlobalVar.onScreen;
            }
            else
            {
                GlobalVar.onScreen += "5";
                Screen.Text = GlobalVar.onScreen;
            }

        }

        private void Number6_Click(object sender, EventArgs e)
        {
            if (GlobalVar.onScreen == "Syntax Error")
            {
                GlobalVar.onScreen = "";
                GlobalVar.onScreen += "6";
                Screen.Text = GlobalVar.onScreen;
            }
            else
            {
                GlobalVar.onScreen += "6";
                Screen.Text = GlobalVar.onScreen;
            }


        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (GlobalVar.onScreen == "Syntax Error" || GlobalVar.onScreen == "")
            {
                GlobalVar.onScreen = "";
                Screen.Text = GlobalVar.onScreen;
            }
            else
            {
                GlobalVar.onScreen += "-";
                Screen.Text = GlobalVar.onScreen;
            }

        }

        private void Number2_Click(object sender, EventArgs e)
        {
            if (GlobalVar.onScreen == "Syntax Error")
            {
                GlobalVar.onScreen = "";
                GlobalVar.onScreen += "2";
                Screen.Text = GlobalVar.onScreen;
            }
            else
            {
                GlobalVar.onScreen += "2";
                Screen.Text = GlobalVar.onScreen;
            }
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            if (GlobalVar.onScreen == "Syntax Error")
            {
                GlobalVar.onScreen = "";
                GlobalVar.onScreen += "3";
                Screen.Text = GlobalVar.onScreen;
            }
            else
            {
                GlobalVar.onScreen += "3";
                Screen.Text = GlobalVar.onScreen;
            }



        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (GlobalVar.onScreen == "Syntax Error" || GlobalVar.onScreen == "")
            {
                GlobalVar.onScreen = "";
                Screen.Text = GlobalVar.onScreen;
            }
            else
            {
                GlobalVar.onScreen += "+";
                Screen.Text = GlobalVar.onScreen;
            }
        }


        private void Number0_Click(object sender, EventArgs e)
        {
            if (GlobalVar.onScreen == "Syntax Error")
            {
                GlobalVar.onScreen = "";
                GlobalVar.onScreen += "0";
                Screen.Text = GlobalVar.onScreen;
            }
            else
            {
                GlobalVar.onScreen += "0";
                Screen.Text = GlobalVar.onScreen;
            }

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (GlobalVar.onScreen == "Syntax Error" || GlobalVar.onScreen == "")
            {
                GlobalVar.onScreen = "";
                Screen.Text = GlobalVar.onScreen;
            }
            else
            {
                GlobalVar.onScreen += ".";
                Screen.Text = GlobalVar.onScreen;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = GlobalVar.onScreen;

                
                expression = expression.Replace(",", ".");

                DataTable dt = new DataTable();
                object result = dt.Compute(expression, null);

               
                double varResult = Convert.ToDouble(result, System.Globalization.CultureInfo.InvariantCulture);

                if (double.IsNaN(varResult) || double.IsInfinity(varResult))
                {
                    throw new Exception("Végtelen lett az eredmény");
                }

                
                GlobalVar.onScreen = varResult.ToString(System.Globalization.CultureInfo.InvariantCulture);
                Screen.Text = GlobalVar.onScreen;
            }
            catch (Exception ex)
            {
                GlobalVar.onScreen = "Syntax Error";
                Screen.Text = GlobalVar.onScreen;
            }
        }


        private void Screen_Click(object sender, EventArgs e)
        {

        }



        private void btnSingChangeKey_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GlobalVar.onScreen) || GlobalVar.onScreen == "Syntax Error")
                return;

            string input = GlobalVar.onScreen;

            char[] ops = new char[] { '+', '-', '*', '/' };

            int lastOpIndex = -1;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (Array.IndexOf(ops, input[i]) != -1)
                {
                    if (input[i] == '-')
                    {
                        if (i == 0)
                        {
                            continue;
                        }

                        if (Array.IndexOf(ops, input[i - 1]) != -1)
                        {
                            continue;
                        }
                    }

                    lastOpIndex = i;
                    break;
                }
            }

            string before = "";
            string lastNumber = input;

            if (lastOpIndex != -1)
            {
                before = input.Substring(0, lastOpIndex + 1);
                lastNumber = input.Substring(lastOpIndex + 1);
            }
            if (string.IsNullOrEmpty(lastNumber))
                return;

            if (lastNumber.StartsWith("-"))
            {
                lastNumber = lastNumber.Substring(1);
            }
            else
            {
                lastNumber = "-" + lastNumber;
            }

            GlobalVar.onScreen = before + lastNumber;
            Screen.Text = GlobalVar.onScreen;
        }


        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GlobalVar.onScreen) || GlobalVar.onScreen == "Syntax Error")
                return;

            string input = GlobalVar.onScreen;

            char[] ops = new char[] { '+', '-', '*', '/' };

            int lastOpIndex = input.LastIndexOfAny(ops);

            string before = "";
            string lastNumber = input;

            if (lastOpIndex != -1)
            {
                before = input.Substring(0, lastOpIndex + 1);
                lastNumber = input.Substring(lastOpIndex + 1);
            }

            if (string.IsNullOrEmpty(lastNumber))
                return;


            if (double.TryParse(lastNumber, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double number))
            {
                double lastNumberPercent = number / 100.0;

                GlobalVar.onScreen = before + lastNumberPercent.ToString(System.Globalization.CultureInfo.InvariantCulture);
                Screen.Text = GlobalVar.onScreen;
            }

            else
            {
                GlobalVar.onScreen = "Syntax Error";
                Screen.Text = GlobalVar.onScreen;
            }
        }
    }
}
