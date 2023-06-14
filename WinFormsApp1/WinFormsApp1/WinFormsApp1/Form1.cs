using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string plec;
        public double bmiwynik;
        public double ppm;
        public double cpm;
        public double pal;
        public string opisbmi;
    
        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmi bmi1 = new bmi()
            {
                masabmi = double.Parse(waga.Text),
                wzrostbmi = double.Parse(wzrost.Text)
                

        };
            bmiwynik = (bmi1.masabmi / (Math.Pow(bmi1.wzrostbmi/100,2)));
            if(bmiwynik < 16)
            {
                opisbmi = "wygłodzenie";
            }
            else if(bmiwynik >= 16 && bmiwynik <= 16.99)
            {
                opisbmi = "wychudzenie";
            }
            else if (bmiwynik >= 17 && bmiwynik <= 24.99)
            {
                opisbmi = "prawidłowa";
            }
            else if (bmiwynik >= 25 && bmiwynik <= 29.99)
            {
                opisbmi = "nadwaga";
            }
            else if (bmiwynik >= 30 && bmiwynik <= 34.99)
            {
                opisbmi = "I stopień otyłości";
            }
            else if (bmiwynik >= 35 && bmiwynik <= 39.99)
            {
                opisbmi = "II stopień otyłości";
            }
            else if (bmiwynik > 40)
            {
                opisbmi = "otyłość skrajna";
            }

            if (kobieta.Checked)
            {
                ppm = ((10 * double.Parse(waga.Text)) + 6.25*(double.Parse(wzrost.Text) - (5*double.Parse(wiek.Text)+5)));
                if(aktywnosc.SelectedIndex == 0)
                {
                    pal = 1.2;
                }
                else if(aktywnosc.SelectedIndex == 1)
                {
                    pal = 1.3;
                }
                else if (aktywnosc.SelectedIndex == 2)
                {
                    pal = 1.5;
                }
                else if (aktywnosc.SelectedIndex == 3)
                {
                    pal = 1.6;
                }
                else if (aktywnosc.SelectedIndex == 4)
                {
                    pal = 1.9;
                }
                else if (aktywnosc.SelectedIndex == 5)
                {
                    pal = 2.2;
                }
                cpm = ppm * pal;
                MessageBox.Show("BMI wynosi: " + bmiwynik + " i jest to: " + opisbmi + " PPM wynosi: " + ppm + "CPM wynosi: " + cpm);

            }
            if (men.Checked)
            {
                ppm = ((10 * double.Parse(waga.Text)) + 6.25 * (double.Parse(wzrost.Text) - (5 * double.Parse(wiek.Text)+5)));
                if (aktywnosc.SelectedIndex == 0)
                {
                    pal = 1.2;
                }
                else if (aktywnosc.SelectedIndex == 1)
                {
                    pal = 1.3;
                }
                else if (aktywnosc.SelectedIndex == 2)
                {
                    pal = 1.6;
                }
                else if (aktywnosc.SelectedIndex == 3)
                {
                    pal = 1.7;
                }
                else if (aktywnosc.SelectedIndex == 4)
                {
                    pal = 2.1;
                }
                else if (aktywnosc.SelectedIndex == 5)
                {
                    pal = 2.4;
                }
                cpm = ppm * pal;
                MessageBox.Show("BMI wynosi: " + bmiwynik + " i jest to: " + opisbmi +  " PPM wynosi: " + ppm + "CPM wynosi: " + cpm);

            }
            
        }

    }
}
