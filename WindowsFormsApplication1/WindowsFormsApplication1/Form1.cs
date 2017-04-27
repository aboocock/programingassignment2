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
    }
}
