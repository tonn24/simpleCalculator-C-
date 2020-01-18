using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toomsalu_KTA_19E_kalkulaator
{
    public partial class TT_Form1 : Form
    {
        public TT_Form1()
        {
            InitializeComponent();
        }

        private void TT_button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                double arv1 = double.Parse(textBox1.Text);
                double arv2 = double.Parse(textBox2.Text);
                double vastus = 0;
                if (radioButton1.Checked == true)
                {
                    vastus = arv1 + arv2;
                    textBox3.Text = arv1 + " + " + arv2 + " = " + vastus;
                }
                else if (radioButton2.Checked == true)
                {
                    vastus = arv1 - arv2;
                    textBox3.Text = arv1 + " - " + arv2 + " = " + vastus;
                }
                else if (radioButton3.Checked == true)
                {
                    vastus = arv1 * arv2;
                    textBox3.Text = arv1 + " * " + arv2 + " = " + vastus;
                }
                else if (radioButton4.Checked == true)
                {
                    if(arv1 == 0 || arv2 == 0)
                    {
                        textBox3.Text = "Jagamine nulliga keelatud!";
                    } else
                    {
                        vastus = arv1 / arv2;
                        textBox3.Text = arv1 + " / " + arv2 + " = " + vastus;
                    }
                    
                }
                else if (!radioButton1.Checked || !radioButton2.Checked || !radioButton3.Checked || !radioButton4.Checked)
                {
                    textBox3.Text = "Palun valige tehe, mida soovite teostada!";
                }
                
            } catch
            {
                if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
                {
                    textBox3.Text = "Sisesta number mõlemasse lahtrisse!";
                }
                    
            }
            
        }

        private void TT_textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox1.Text.Contains(".") == true : true))
                e.Handled = true;
        } 

        private void TT_textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox2.Text.Contains(".") == true : true))
                e.Handled = true;
        }

    }
}
