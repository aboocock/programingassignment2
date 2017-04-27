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

        string button3count = "0";
        string button3Firstvisit = "yes";

        string button4count = "0";
        string button4Firstvisit = "yes";

        string button5count = "0";
        string button5Firstvisit = "yes";

        string button6count = "0";
        string button6Firstvisit = "yes";

        string button7count = "0";
        string button7Firstvisit = "yes";

        string button8count = "0";
        string button8Firstvisit = "yes";

        string button9count = "0";
        string button9Firstvisit = "yes";


        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button7Firstvisit == "no")
            {

                button7count = "1";
            }
            if (button7count == "0")
            {
                wordbuildertextbox.Text += Str_KeyStrokes + "a";
                button7count = "1";
            }
            else if (button7count == "1")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "b";
                button7count = "2";
            }
            else if (button7count == "2")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "c";
                button7count = "3";
            }
            else if (button7count == "3")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "8";
                button7count = "4";
            }
            else if (button7count == "4")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "A";
                button7count = "5";
            }
            else if (button7count == "5")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "B";
                button7count = "6";
            }



            else if (button7count == "6")

            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "C";
                button7count = "0";
                button7Firstvisit = "no";
            }

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
            { multipress.Text = "Multi-Press"; }
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

        private void button16_Click(object sender, EventArgs e)
        {
            if (button3Firstvisit == "no")
            {

                button3count = "1";
            }
            if (button3count == "0")
            {
                wordbuildertextbox.Text += Str_KeyStrokes + "w";
                button3count = "1";
            }
            else if (button3count == "1")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "x";
                button3count = "2";
            }
            else if (button3count == "2")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "y";
                button3count = "3";
            }
            else if (button3count == "3")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "z";
                button3count = "4";

            }
            else if (button3count == "4")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "3";
                button3count = "5";

            }
            else if (button3count == "5")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "W";
                button3count = "6";

            }
            else if (button3count == "6")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "X";
                button3count = "7";
            }
            else if (button3count == "7")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "Y";
                button3count = "8";
            }
            else if (button3count == "8")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "Z";
                button3count = "0";
                button3Firstvisit = "no";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button4Firstvisit == "no")
            {

                button4count = "1";
            }
            if (button4count == "0")
            {
                wordbuildertextbox.Text += Str_KeyStrokes + "g";
                button4count = "1";
            }
            else if (button4count == "1")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "h";
                button4count = "2";
            }
            else if (button4count == "2")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "i";
                button4count = "3";
            }
            else if (button4count == "3")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "4";
                button4count = "4";

            }
            else if (button4count == "4")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "G";
                button4count = "5";

            }
            else if (button4count == "5")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "H";
                button4count = "6";

            }
            else if (button4count == "6")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "I";
                button4count = "0";
                button4Firstvisit = "no";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button5Firstvisit == "no")
            {

                button5count = "1";
            }
            if (button5count == "0")
            {
                wordbuildertextbox.Text += Str_KeyStrokes + "j";
                button5count = "1";
            }
            else if (button5count == "1")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "k";
                button5count = "2";
            }
            else if (button5count == "2")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "l";
                button5count = "3";
            }
            else if (button5count == "3")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "5";
                button5count = "4";

            }
            else if (button5count == "4")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "J";
                button5count = "5";

            }
            else if (button5count == "5")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "K";
                button5count = "6";

            }

            else if (button5count == "6")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "L";
                button5count = "0";
                button5Firstvisit = "no";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button6Firstvisit == "no")
            {

                button6count = "1";
            }
            if (button6count == "0")
            {
                wordbuildertextbox.Text += Str_KeyStrokes + "m";
                button6count = "1";
            }
            else if (button6count == "1")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "n";
                button6count = "2";
            }
            else if (button6count == "2")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "o";
                button6count = "3";
            }
            else if (button6count == "3")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "6";
                button6count = "4";

            }
            else if (button6count == "4")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "M";
                button6count = "5";

            }
            else if (button6count == "5")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "N";
                button6count = "6";

            }

            else if (button6count == "6")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "O";
                button6count = "0";
                button6Firstvisit = "no";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button7Firstvisit == "no")
            {

                button7count = "1";
            }
            if (button7count == "0")
            {
                wordbuildertextbox.Text += Str_KeyStrokes + ",";
                button7count = "1";
            }
            else if (button7count == "1")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + ".";
                button7count = "2";
            }
            else if (button7count == "2")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "''";
                button7count = "3";
            }
            else if (button7count == "3")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "7";
                button7count = "0";
                button7Firstvisit = "no";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button9Firstvisit == "no")
            {

                button9count = "1";
            }
            if (button9count == "0")
            {
                wordbuildertextbox.Text += Str_KeyStrokes + "d";
                button9count = "1";
            }
            else if (button9count == "1")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "e";
                button9count = "2";
            }
            else if (button9count == "2")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "f";
                button9count = "3";
            }
            else if (button9count == "3")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "9";
                button9count = "4";
            }
            else if (button9count == "4")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "D";
                button9count = "5";
            }
            else if (button9count == "5")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "E";
                button9count = "6";
            }
            else if (button9count == "6")
            {
                wordbuildertextbox.Text = wordbuildertextbox.Text.Remove(wordbuildertextbox.Text.Length - 1);
                wordbuildertextbox.Text += Str_KeyStrokes + "F"
                button9count = "0";
                button9Firstvisit = "no";
            }
        }
    }

