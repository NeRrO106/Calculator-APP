using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#pragma warning disable CS1717 //we save nr1 when we change option variable;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //calcul
        double nr1, nr2, result;
        string option;
        bool resulton = false;
        bool signchanged = false;

        //menu
        bool labelMenuOn = false;
        bool standardCalculator = true;
        bool scientificCalculator = false;
        bool currencyCalculator = false;
        bool secondmenu = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!labelMenuOn)
            {
                btnmenu.Visible = true;
                btnmenulabel.Visible = false;
                button1.Visible = false;
                listBox1.Visible = false;
                textBox1.Visible = false;
                btnstandard.Visible = false;
                btnsciens.Visible = false;
                btncurrency.Visible = false;
            }
            if (standardCalculator)
            {
                btn0s.Visible = false;
                btn1s.Visible = false;
                btn2s.Visible = false;
                btn3s.Visible = false;
                btn4s.Visible = false;
                btn5s.Visible = false;
                btn6s.Visible = false;
                btn7s.Visible = false;
                btn8s.Visible = false;
                btn9s.Visible = false;
                btnsigs.Visible = false;
                btnpoints.Visible = false;
                btnequals.Visible = false;
                btnpluss.Visible = false;
                btnmins.Visible = false;
                btnmults.Visible = false;
                btndivs.Visible = false;
                btnnfact.Visible = false;
                btnparen1.Visible = false;
                btnparen2.Visible = false;
                btnsqrt2.Visible = false;
                btnxy.Visible = false;
                btn10x.Visible = false;
                btnlog.Visible = false;
                btnln.Visible = false;
                btnrid2.Visible = false;
                btnfrac2.Visible = false;
                btnmodx.Visible = false;

                btndel2.Visible = false;
                btncl2.Visible = false;
                btnsecond.Visible = false;
                btne.Visible = false;
                btnpi.Visible = false;
                btncos.Visible = false;
                btnsin.Visible = false;

                btnex.Visible = false;
                btnlogyx.Visible = false;
                btn2x.Visible = false;
                btnrid3.Visible = false;
                btntan.Visible = false;
                btnatan.Visible = false;
                btnasin.Visible = false;
                btnacos.Visible = false;

                TxtCalc.Text = "Standard";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtCalc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "0";
            }
            else
            {
                TxtBox.Text = "0";
                resulton = false;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "1";
            }
            else
            {
                TxtBox.Text = "1";
                resulton = false;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "2";
            }
            else
            {
                TxtBox.Text = "2";
                resulton = false;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "3";
            }
            else
            {
                TxtBox.Text = "3";
                resulton = false;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "4";
            }
            else
            {
                TxtBox.Text = "4";
                resulton = false;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "5";
            }
            else
            {
                TxtBox.Text = "5";
                resulton = false;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "6";
            }
            else
            {
                TxtBox.Text = "6";
                resulton = false;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "7";
            }
            else
            {
                TxtBox.Text = "7";
                resulton = false;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "8";
            }
            else
            {
                TxtBox.Text = "8";
                resulton = false;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "9";
            }
            else
            {
                TxtBox.Text = "9";
                resulton = false;
            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if(nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "+";
            TxtBox.Text = "";
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "-";
            TxtBox.Text = "";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "*";
            TxtBox.Text = "";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "/";
            TxtBox.Text = "";
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            if(!TxtBox.Text.Contains(".")) TxtBox.Text = TxtBox.Text + ".";
        }

        private void btnfrc_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "frc";
            TxtBox.Text = "";
        }

        private void btnrid_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "rid";
            TxtBox.Text = "";
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "sqrt";
            TxtBox.Text = "";
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                TxtBox.Text = TxtBox.Text.Substring(0, TxtBox.Text.Length - 1);
            }
        }

        private void cleare_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                TxtBox.Text = "";
            }
        }

        private void btnproc_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text) / 100;
                TxtBox.Text = nr1 + "";
            }
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
                TxtBox.Text = "";
                if (nr1 > 0 || nr1 < 0)
                {
                    nr1 = nr1 * -1;
                }
                TxtBox.Text = nr1 + "";
                signchanged = true;
            }
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (!labelMenuOn)
            {
                labelMenuOn = true;

                btnmenu.Visible = false;
                btnmenulabel.Visible = true;
                button1.Visible = true;
                listBox1.Visible = true;
                textBox1.Visible = true;
                btnstandard.Visible = true;
                btnsciens.Visible = true;
                btncurrency.Visible = true;
            }
        }

        private void btnmenulabel_Click(object sender, EventArgs e)
        {
            if (labelMenuOn)
            {
                labelMenuOn = false;

                btnmenu.Visible = true;
                btnmenulabel.Visible = false;
                button1.Visible = false;
                listBox1.Visible = false;
                textBox1.Visible = false;
                btnstandard.Visible = false;
                btnsciens.Visible = false;
                btncurrency.Visible = false;
            }
        }

        private void btnstandard_Click(object sender, EventArgs e)
        {
            if (labelMenuOn)
            {
                standardCalculator = true;
                scientificCalculator = false;
                currencyCalculator = false;

                labelMenuOn = false;

                btnmenu.Visible = true;
                btnmenulabel.Visible = false;
                button1.Visible=false;
                listBox1.Visible = false;
                textBox1.Visible = false;
                btnstandard.Visible = false;
                btnsciens.Visible = false;
                btncurrency.Visible = false;

                //buttonsON
                btn0.Visible = true;
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;
                btn4.Visible = true;
                btn5.Visible = true;
                btn6.Visible = true;
                btn6.Visible = true;
                btn7.Visible = true;
                btn8.Visible = true;
                btn9.Visible = true;
                btnpoint.Visible = true;
                btnsqrt.Visible = true;
                btnproc.Visible = true;
                btnrid.Visible = true;
                btnfrc.Visible = true;
                btnsign.Visible = true;
                btnclr.Visible = true;
                cleare.Visible = true;
                btndlt.Visible = true;
                btndiv.Visible = true;
                btnmult.Visible = true;
                btnmin.Visible = true;
                btnplus.Visible = true;
                btnequal.Visible = true;

                //buttonsOFF
                btn0s.Visible = false;
                btn1s.Visible = false;
                btn2s.Visible = false;
                btn3s.Visible = false;
                btn4s.Visible = false;
                btn5s.Visible = false;
                btn6s.Visible = false;
                btn7s.Visible = false;
                btn8s.Visible = false;
                btn9s.Visible = false;
                btnsigs.Visible = false;
                btnpoints.Visible = false;
                btnequals.Visible = false;
                btnpluss.Visible = false;
                btnmins.Visible = false;
                btnmults.Visible = false;
                btndivs.Visible = false;

                btnnfact.Visible = false;
                btnparen1.Visible = false;
                btnparen2.Visible = false;
                btnsqrt2.Visible = false;
                btnxy.Visible = false;
                btn10x.Visible = false;
                btnlog.Visible = false;
                btnln.Visible = false;
                btnrid2.Visible = false;
                btnfrac2.Visible = false;
                btnmodx.Visible = false;

                btndel2.Visible = false;
                btncl2.Visible = false;
                btnsecond.Visible = false;
                btne.Visible = false;
                btnpi.Visible = false;
                btncos.Visible = false;
                btnsin.Visible = false;

                btnex.Visible = false;
                btnlogyx.Visible = false;
                btn2x.Visible = false;
                btnrid3.Visible = false;
                btntan.Visible = false;
                btnatan.Visible = false;
                btnasin.Visible = false;
                btnacos.Visible = false;

                TxtCalc.Text = "Standard";

            }
        }

        private void btnsciens_Click(object sender, EventArgs e)
        {
            if (labelMenuOn)
            {
                standardCalculator = false;
                scientificCalculator = true;
                currencyCalculator = false;

                labelMenuOn = false;

                btnmenu.Visible = true;
                btnmenulabel.Visible = false;
                button1.Visible = false;
                listBox1.Visible = false;
                textBox1.Visible = false;
                btnstandard.Visible = false;
                btnsciens.Visible = false;
                btncurrency.Visible = false;

                //buttonsON
                btn0s.Visible = true;
                btn1s.Visible = true;
                btn2s.Visible = true;
                btn3s.Visible = true;
                btn4s.Visible = true;
                btn5s.Visible = true;
                btn6s.Visible = true;
                btn7s.Visible = true;
                btn8s.Visible = true;
                btn9s.Visible = true;
                btnsigs.Visible = true;
                btnpoints.Visible = true;
                btnequals.Visible = true;
                btnpluss.Visible = true;
                btnmins.Visible = true;
                btnmults.Visible = true;
                btndivs.Visible = true;
                btnnfact.Visible = true;
                btnparen1.Visible = true;
                btnparen2.Visible = true;
                btnsqrt2.Visible = true;
                btnxy.Visible = true;
                btn10x.Visible = true;
                btnlog.Visible = true;
                btnln.Visible = true;
                btnrid2.Visible = true;
                btnfrac2.Visible = true;
                btnmodx.Visible = true;
                btndel2.Visible = true;
                btncl2.Visible = true;
                btnsecond.Visible = true;
                btne.Visible = true;
                btnpi.Visible = true;
                btncos.Visible = true;
                btnsin.Visible = true;

                //buttonsOFF
                btn0.Visible = false;
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
                btn4.Visible = false;
                btn5.Visible = false;
                btn6.Visible = false;
                btn6.Visible = false;
                btn7.Visible = false;
                btn8.Visible = false;
                btn9.Visible = false;
                btnpoint.Visible = false;
                btnsqrt.Visible = false;
                btnproc.Visible = false;
                btnrid.Visible = false;
                btnfrc.Visible = false;
                btnsign.Visible = false;
                btnclr.Visible = false;
                cleare.Visible = false;
                btndlt.Visible = false;
                btndiv.Visible = false;
                btnmult.Visible = false;
                btnmin.Visible = false;
                btnplus.Visible = false;
                btnequal.Visible = false;

                //btnmenu2
                btnex.Visible = false;
                btnlogyx.Visible = false;
                btn2x.Visible = false;
                btnrid3.Visible = false;
                btntan.Visible = false;
                btnatan.Visible = false;
                btnasin.Visible = false;
                btnacos.Visible = false;

                TxtCalc.Text = "Sciencific";
            }
        }

        private void btncurrency_Click(object sender, EventArgs e)
        {
            if (labelMenuOn)
            {
                standardCalculator = false;
                scientificCalculator = false;
                currencyCalculator = true;

                labelMenuOn = false;

                btnmenu.Visible = true;
                btnmenulabel.Visible = false;
                button1.Visible = false;
                listBox1.Visible = false;
                textBox1.Visible = false;
                btnstandard.Visible = false;
                btnsciens.Visible = false;
                btncurrency.Visible = false;
                TxtCalc.Text = "Currency";
            }
        }

        private void btn0s_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "0";
            }
            else
            {
                TxtBox.Text = "0";
                resulton = false;
            }
        }

        private void btn1s_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "1";
            }
            else
            {
                TxtBox.Text = "1";
                resulton = false;
            }
        }

        private void btn2s_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "2";
            }
            else
            {
                TxtBox.Text = "2";
                resulton = false;
            }
        }

        private void btn3s_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "3";
            }
            else
            {
                TxtBox.Text = "3";
                resulton = false;
            }
        }

        private void btn4s_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "4";
            }
            else
            {
                TxtBox.Text = "4";
                resulton = false;
            }
        }

        private void btn5s_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "5";
            }
            else
            {
                TxtBox.Text = "5";
                resulton = false;
            }
        }

        private void btn6s_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "6";
            }
            else
            {
                TxtBox.Text = "6";
                resulton = false;
            }
        }

        private void btn7s_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "7";
            }
            else
            {
                TxtBox.Text = "7";
                resulton = false;
            }
        }

        private void btn8s_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "8";
            }
            else
            {
                TxtBox.Text = "8";
                resulton = false;
            }
        }

        private void btn9s_Click(object sender, EventArgs e)
        {
            if (!resulton)
            {
                TxtBox.Text = TxtBox.Text + "9";
            }
            else
            {
                TxtBox.Text = "9";
                resulton = false;
            }
        }

        private void btnpoints_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains("."))
            {
                TxtBox.Text = TxtBox.Text + ".";
            }            
        }

        private void btnsigs_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
                TxtBox.Text = "";
                if (nr1 > 0 || nr1 < 0)
                {
                    nr1 = nr1 * -1;
                }
                TxtBox.Text = nr1 + "";
                signchanged = true;
            }
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case "+":
                    if (!String.IsNullOrEmpty(TxtBox.Text))
                    {
                        nr2 = double.Parse(TxtBox.Text);
                    }
                    else
                    {
                        nr2 = 0;
                    }
                    result = nr1 + nr2;
                    option = null;
                    resulton = true;
                    break;

                case "-":
                    if (!String.IsNullOrEmpty(TxtBox.Text))
                    {
                        nr2 = double.Parse(TxtBox.Text);
                    }
                    else
                    {
                        nr2 = 0;
                    }
                    result = nr1 - nr2;
                    option = null;
                    resulton = true;
                    break;

                case "*":
                    if (!String.IsNullOrEmpty(TxtBox.Text))
                    {
                        nr2 = double.Parse(TxtBox.Text);
                    }
                    else
                    {
                        nr2 = 1;
                    }
                    result = nr1 * nr2;
                    option = null;
                    resulton = true;
                    break;

                case "/":
                    if (!String.IsNullOrEmpty(TxtBox.Text))
                    {
                        nr2 = double.Parse(TxtBox.Text);
                    }
                    else
                    {
                        nr2 = 1;
                    }
                    result = nr1 / nr2;
                    option = null;
                    resulton = true;
                    break;

                case "frc":
                    nr2 = 1;
                    result = nr2 / nr1;
                    resulton = true;
                    break;

                case "rid":
                    nr2 = nr1;
                    result = nr1 * nr2;
                    resulton = true;
                    break;

                case "sqrt":
                    result = Math.Sqrt(nr1);
                    resulton = true;
                    break;

                case "n!":
                    result = 1;
                    for (int i = 1; i <= nr1; i++)
                    {
                        result = result * i;
                    }
                    resulton = true;
                    break;

                case "modx":
                    result = Math.Abs(nr1);
                    resulton = true;
                    break;

                case "cos":
                    result = Math.Cos(nr1);
                    resulton = true;
                    break;

                case "sin":
                    result = Math.Sin(nr1);
                    resulton = true;
                    break;

                case "10x":
                    if (nr1 > 0)
                    {
                        result = Math.Pow(10, nr1);
                    }
                    else
                    {
                        result = 1;
                    }
                    resulton = true;
                    break;

                case "xy":
                    if (!String.IsNullOrEmpty(TxtBox.Text)) nr2 = double.Parse(TxtBox.Text);
                    if (nr1 > 0 && nr2 > 0)
                    {
                        result = nr1;
                        for (int i = 1; i < nr2; i++)
                        {
                            result *= nr1;
                        }
                    }
                    else result = 0;
                    resulton = true;
                    break;

                case "log10":
                    result = Math.Log10(nr1);
                    resulton = true;
                    break;

                case "ln":
                    result = Math.Log(nr1);
                    resulton = true;
                    break;

                case "rid2":
                    result = Math.Pow(nr1, 3);
                    resulton = true;
                    break;

                case "ex":
                    result = Math.Pow(2.718281828459045, nr1);
                    resulton = true;
                    break;

                case "logyx":
                    if (!String.IsNullOrEmpty(TxtBox.Text)) nr2 = double.Parse(TxtBox.Text);
                    if (nr1 > 1 && nr2 > 0)
                    {
                        result = Math.Log(nr1, nr2);
                    }
                    else
                    {
                        result = 0;
                    }
                    resulton = true;
                    break;

                case "2x":
                    result = Math.Pow(2, nr1);
                    resulton = true;
                    break;

                case "asin":
                    result = Math.Asin(nr1);
                    resulton = true;
                    break;

                case "acos":
                    result = Math.Acos(nr1);
                    resulton = true;
                    break;

                case "tan":
                    result = Math.Tan(nr1);
                    resulton = true;
                    break;

                case "atan":
                    result = Math.Atan(nr1);
                    resulton = true;
                    break;
            }
            if (signchanged)
            {
                nr2 = 0;
                result = nr1 + nr2;
                signchanged = false;
            }
            TxtBox.Text = result + "";
        }

        private void btnpluss_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "+";
            TxtBox.Text = "";
        }

        private void btnmins_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "-";
            TxtBox.Text = "";
        }

        private void btnmults_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "*";
            TxtBox.Text = "";
        }

        private void btndivs_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "/";
            TxtBox.Text = "";
        }

        private void btndel2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                TxtBox.Text = TxtBox.Text.Substring(0, TxtBox.Text.Length - 1);
            }
        }

        private void btncl2_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "";
            nr1 = nr2 = 0;
            result = 0;
            resulton = false;
            option = null;
            signchanged = false;
        }

        private void btnnfact_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "n!";
            TxtBox.Text = "";
        }

        private void btnparen1_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains(")"))
                TxtBox.Text = TxtBox.Text + ")";
        }

        private void btnparen2_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains("("))
                TxtBox.Text = TxtBox.Text + "(";
        }

        private void btnsqrt2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "sqrt";
            TxtBox.Text = "";
        }

        private void btnrid2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "rid";
            TxtBox.Text = "";
        }

        private void btnfrac2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "frc";
            TxtBox.Text = "";
        }

        private void btnmodx_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "modx";
            TxtBox.Text = "";
        }

        private void btne_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "" + 2.718281828459045;
        }

        private void btnpi_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "" + 3.1415926535;
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "cos";
            TxtBox.Text = "";
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "sin";
            TxtBox.Text = "";
        }

        private void btnxy_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "xy";
            TxtBox.Text = "";
        }

        private void btn10x_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "10x";
            TxtBox.Text = "";
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "log10";
            TxtBox.Text = "";
        }

        private void btnln_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "ln";
            TxtBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {//btnrid3
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "rid2";
            TxtBox.Text = "";
        }

        private void btnex_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "ex";
            TxtBox.Text = "";
        }

        private void btnlogyx_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "logyx";
            TxtBox.Text = "";
        }

        private void btn2x_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "2x";
            TxtBox.Text = "";
        }

        private void btnasin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "asin";
            TxtBox.Text = "";
        }

        private void btnacos_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "acos";
            TxtBox.Text = "";
        }

        private void btnatan_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "atan";
            TxtBox.Text = "";
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                nr1 = double.Parse(TxtBox.Text);
            }
            else if (nr1 != 0)
            {
                nr1 = nr1;
            }
            else
            {
                nr1 = 0;
            }
            option = "tan";
            TxtBox.Text = "";
        }

        private void btnsecond_Click(object sender, EventArgs e)
        {
            if(!secondmenu)
            {
                btnex.Visible = true;
                btnlogyx.Visible = true;
                btn2x.Visible = true;
                btnrid3.Visible = true;
                btntan.Visible = true;
                btnatan.Visible = true;
                btnasin.Visible = true;
                btnacos.Visible = true;

                secondmenu = true;
            }
            else
            {
                btnex.Visible = false;
                btnlogyx.Visible = false;
                btn2x.Visible = false;
                btnrid3.Visible = false;
                btntan.Visible = false;
                btnatan.Visible = false;
                btnasin.Visible = false;
                btnacos.Visible = false;

                secondmenu = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (labelMenuOn)
            {
                labelMenuOn = false;

                btnmenu.Visible = true;
                btnmenulabel.Visible = false;
                button1.Visible = false;
                listBox1.Visible = false;
                textBox1.Visible = false;
                btnstandard.Visible = false;
                btnsciens.Visible = false;
                btncurrency.Visible = false;
            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case "+":
                    if (!String.IsNullOrEmpty(TxtBox.Text))
                    {
                        nr2 = double.Parse(TxtBox.Text);
                    }
                    else
                    {
                        nr2 = 0;
                    }
                    result = nr1 + nr2;
                    option = null;
                    resulton = true;
                    break;

                case "-":
                    if (!String.IsNullOrEmpty(TxtBox.Text))
                    {
                        nr2 = double.Parse(TxtBox.Text);
                    }
                    else
                    {
                        nr2 = 0;
                    }
                    result = nr1 - nr2;
                    option = null;
                    resulton = true;
                    break;

                case "*":
                    if (!String.IsNullOrEmpty(TxtBox.Text))
                    {
                        nr2 = double.Parse(TxtBox.Text);
                    }
                    else
                    {
                        nr2 = 1;
                    }
                    result = nr1 * nr2;
                    option = null;
                    resulton = true;
                    break;

                case "/":
                    if (!String.IsNullOrEmpty(TxtBox.Text))
                    {
                        nr2 = double.Parse(TxtBox.Text);
                    }
                    else
                    {
                        nr2 = 1;
                    }
                    result = nr1 / nr2;
                    option = null;
                    resulton = true;
                    break;

                //special operation
                case "frc":
                    nr2 = 1;
                    result = nr2 / nr1;
                    resulton = true;
                    break;

                case "rid":
                    nr2 = nr1;
                    result = nr1 * nr2;
                    resulton = true;
                    break;

                case "sqrt":
                    result = Math.Sqrt(nr1);
                    resulton = true;
                    break;
            }
            if (signchanged)
            {
                nr2 = 0;
                result = nr1 + nr2;
                signchanged = false;
            }
            TxtBox.Text =  result + "";
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "";
            nr1 = nr2 = 0;
            result = 0;
            resulton = false;
            option = null;
            signchanged = false;
        }
    }
}
