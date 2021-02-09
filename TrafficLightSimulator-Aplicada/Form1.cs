using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrafficLightSimulator_Aplicada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cont1 = 0;
        int cont2 = 0;
        int cont3 = 0;
        int cont4 = 0;
        int cont11 = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1")
            {
                car1.Visible = true;
                car2.Visible = false;
                car3.Visible = false;
                //seconds
                cont1 = 5;
                label1.Text = cont1.ToString();
            }
            else if (comboBox1.Text == "2")
            {
                car1.Visible = true;
                car2.Visible = true;
                car3.Visible = false;
                cont1 = 10;
                label1.Text = cont1.ToString();
            }
            else if (comboBox1.Text == "3")
            {
                car1.Visible = true;
                car2.Visible = true;
                car3.Visible = true;
                cont1 = 15;
                label1.Text = cont1.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cont1 = cont1 - 1;
            cont11 = cont11 + 1;
            label1.Text = cont1.ToString();
            if (cont11 >= 1 && cont11 <= 2)
            {
                this.trafficLight1.BackColor = Color.Yellow;
            }
            else if (cont11 > 2 && cont1 >= 2)
            {
                this.trafficLight1.BackColor = Color.Green;
            }
            else if (label1.Text == "0")
            {
                this.trafficLight1.BackColor = Color.Red;
            }
        }
    }
}
