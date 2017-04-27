using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string Str_KeyStrokes = "";
        string button1count = "0";
        string button1Firstvisit = "yes";

        string button2count = "0";
        string button2Firstvisit = "yes";

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void multipress_Click(object sender, EventArgs e)
        {
          
            }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void WithinTimer()
        {
            
            timer1.Enabled = true;
            try
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
            }
            catch
            {
                
            }

            //Str_KeyStrokes += 

            //if (ListBox. > (WhichListbox.Items.Count - 1))
            //{ }



        }

        private void enter_Click(object sender, EventArgs e)
        {
            wordbuilder.AppendText(Environment.NewLine);
        }

        private void mode_Click(object sender, EventArgs e)
        {
            if (multipress.Text == "Multi-Press")
            { multipress.Text = "Prediction"; }
            else
            { multipress.Text = "Multi-Press";}
        }

        private void button19_Click(object sender, EventArgs e)
        {
            wordbuilder.Text += wordbuildertextbox.Text + " ";
            wordbuildertextbox.Text = "";
            timer1.Enabled = false;
            Str_KeyStrokes = "";


        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button1Firstvisit == "no")
            {

                button1count = "1";
            }
            if (button1count == "0")
                {
                    wordbuildertextbox.Text += Str_KeyStrokes + "p";
                    button1count = "1";
                }
                else if (button1count == "1")
                {
                    wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                    wordbuildertextbox.Text += Str_KeyStrokes + "q";
                    button1count = "2";
                }
                else if (button1count == "2")
                {
                    wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                    wordbuildertextbox.Text += Str_KeyStrokes + "r";
                    button1count = "3";
                }
                else if (button1count == "3")
                {
                    wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                    wordbuildertextbox.Text += Str_KeyStrokes + "s";
                    button1count = "4";

                }
                else if (button1count == "4")
                {
                    wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                    wordbuildertextbox.Text += Str_KeyStrokes + "1";
                    button1count = "5";

                }
                else if (button1count == "5")
                {
                    wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                    wordbuildertextbox.Text += Str_KeyStrokes + "P";
                    button1count = "6";

                }
                else if (button1count == "6")
                {
                    wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                    wordbuildertextbox.Text += Str_KeyStrokes + "Q";
                    button1count = "7";

                }
                else if (button1count == "7")
                {
                    wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                    wordbuildertextbox.Text += Str_KeyStrokes + "R";
                    button1count = "8";

                }
                else if (button1count == "8")
                {
                    wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                    wordbuildertextbox.Text += Str_KeyStrokes + "S";
                    button1count = "0";
                    button1Firstvisit = "no";

                }
            

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button2Firstvisit == "no")
            {

                button2count = "1";
            }
            if (button2count == "0")
            {
                wordbuildertextbox.Text += Str_KeyStrokes + "t";
                button2count = "1";
            }
            else if (button2count == "1")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "u";
                button2count = "2";
            }
            else if (button2count == "2")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "v";
                button2count = "3";
            }
            else if (button2count == "3")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "2";
                button2count = "4";

            }
            else if (button2count == "4")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "T";
                button2count = "5";

            }
            else if (button2count == "5")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "U";
                button2count = "6";

            }
            
            else if (button2count == "8")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "V";
                button2count = "0";
                button2Firstvisit = "no";

            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
        }
    }
}
