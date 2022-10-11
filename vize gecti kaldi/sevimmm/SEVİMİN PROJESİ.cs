using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sevimmm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ortalama, vize, final,harf,durum;
            try
            {

                vize=Convert.ToDouble(numericUpDown1.Value);
                final=Convert.ToDouble(numericUpDown2.Value);
                

                ortalama=vize*0.4 + final*0.6;
                label3.Text=ortalama.ToString();
              
                if (ortalama>=0 && ortalama< 50)
                { label5.Text="FF"; }
                else if (ortalama>=50 &&ortalama < 60)
                { label5.Text= "DD"; }
                else if (ortalama >= 60 && ortalama < 70)
                { label5.Text="CC";  }
                else if (ortalama>= 70 &&  ortalama < 85)
                { label5.Text="BB";  }
                else if (ortalama >= 85 && ortalama <= 100)
                { label5.Text="AA"; }
               
                
                
                if (ortalama>=50)
                {
                    label4.Text = "GEÇTİNİZ";
                    label4.ForeColor = Color.Green;
                }
                else
                {

                    label4.Text = "KALDINIZ";
                    label4.ForeColor = Color.Red;
                }
               

                if ( textBox1.Text != "" && textBox2.Text != "")
                {
                    MessageBox.Show("lütfen geçerli değerlerl yazınız");
                }
                




            }

            catch (Exception ex)
            {




            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
