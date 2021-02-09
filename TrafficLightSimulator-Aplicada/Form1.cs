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
            if (cont11 >= 1 && cont11 <= 1)
            {
                this.trafficLight1.BackColor = Color.Yellow;
            }
            else if (cont11 >= 2 && cont1 >= 2)
            {
                this.trafficLight1.BackColor = Color.Green;
                if (car1.Visible == true)
                {
                    car1.Left += 30;
                }
                if (car2.Visible == true)
                {
                    car2.Left += 30;
                }
                if (car3.Visible == true)
                {
                    car3.Left += 30;
                }
            }
            else if (label1.Text == "0")
            {
                this.trafficLight1.BackColor = Color.Red;
                timer1.Stop();
                cont11 = 0;
                timer2.Start();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer5.Start();
            timer6.Start();
            timer7.Start();
            timer8.Start();

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
           if (car1.Left > 194)
            {
                car1.Left += 40;
            }
           if (car2.Left > 194)
            {
                car2.Left += 40;
            }
            if (car3.Left > 194)
            {
                car3.Left += 40;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "1")
            {
                car7.Visible = true;
                car8.Visible = false;
                car9.Visible = false;
                //seconds
                cont2 = 5;
                label2.Text = cont2.ToString();
            }
            else if (comboBox2.Text == "2")
            {
                car7.Visible = true;
                car8.Visible = true;
                car9.Visible = false;
                cont2 = 10;
                label2.Text = cont2.ToString();
            }
            else if (comboBox2.Text == "3")
            {
                car7.Visible = true;
                car8.Visible = true;
                car9.Visible = true;
                cont2 = 15;
                label2.Text = cont2.ToString();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            cont2 = cont2 - 1;
            cont11 = cont11 + 1;
            label2.Text = cont2.ToString();
            if (cont11 >= 0 && cont11 <= 1)
            {
                this.trafficLight2.BackColor = Color.Yellow;
            }
            else if (cont11 >= 2 && cont2 >= 2)
            {
                this.trafficLight2.BackColor = Color.Green;
                if (car7.Visible == true)
                {
                    car7.Top += 30;
                }
                if (car8.Visible == true)
                {
                    car8.Top += 30;
                }
                if (car9.Visible == true)
                {
                    car9.Top += 30;
                }
            }
            else if (label2.Text == "0")
            {
                this.trafficLight2.BackColor = Color.Red;
                timer2.Stop();
                cont11 = 0;
                timer3.Start();
            }

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            //185
            if (car7.Top >= 118)
            {
                car7.Top += 40;
            }
            if (car8.Top >= 118)
            {
                car8.Top += 40;
            }
            if (car9.Top >= 118)
            {
                car9.Top += 40;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "1")
            {
                car4.Visible = true;
                car5.Visible = false;
                car6.Visible = false;
                //seconds
                cont3 = 5;
                label3.Text = cont3.ToString();
            }
            else if (comboBox3.Text == "2")
            {
                car4.Visible = true;
                car5.Visible = true;
                car6.Visible = false;
                cont3 = 10;
                label3.Text = cont3.ToString();
            }
            else if (comboBox3.Text == "3")
            {
                car4.Visible = true;
                car5.Visible = true;
                car6.Visible = true;
                cont3 = 15;
                label3.Text = cont3.ToString();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "1")
            {
                car10.Visible = true;
                car11.Visible = false;
                car12.Visible = false;
                //seconds
                cont4 = 5;
                label4.Text = cont4.ToString();
            }
            else if (comboBox4.Text == "2")
            {
                car10.Visible = true;
                car11.Visible = true;
                car12.Visible = false;
                cont4 = 10;
                label4.Text = cont4.ToString();
            }
            else if (comboBox4.Text == "3")
            {
                car10.Visible = true;
                car11.Visible = true;
                car12.Visible = true;
                cont4 = 15;
                label4.Text = cont4.ToString();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            cont3 = cont3 - 1;
            cont11 = cont11 + 1;
            label3.Text = cont3.ToString();
            if (cont11 >= 0 && cont11 <= 1)
            {
                this.trafficLight3.BackColor = Color.Yellow;
            }
            else if (cont11 >= 2 && cont3 >= 2)
            {
                this.trafficLight3.BackColor = Color.Green;
                if (car4.Visible == true)
                {
                    car4.Left -= 30;
                }
                if (car5.Visible == true)
                {
                    car5.Left -= 30;
                }
                if (car6.Visible == true)
                {
                    car6.Left -= 30;
                }
            }
            else if (label3.Text == "0")
            {
                this.trafficLight3.BackColor = Color.Red;
                timer3.Stop();
                cont11 = 0;
                timer4.Start();
            }

        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (car4.Left <= 379)
            {
                car4.Left -= 40;
            }
            if (car5.Left <= 379)
            {
                car5.Left -= 40;
            }
            if (car6.Left <= 379)
            {
                car6.Left -= 40;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            cont4 = cont4 - 1;
            cont11 = cont11 + 1;
            label4.Text = cont4.ToString();
            if (cont11 >= 0 && cont11 <= 1)
            {
                this.trafficLight4.BackColor = Color.Yellow;
            }
            else if (cont11 >= 2 && cont4 >= 2)
            {
                this.trafficLight4.BackColor = Color.Green;
                if (car10.Visible == true)
                {
                    car10.Top -= 30;
                }
                if (car11.Visible == true)
                {
                    car11.Top -= 30;
                }
                if (car12.Visible == true)
                {
                    car12.Top -= 30;
                }
            }
            else if (label4.Text == "0")
            {
                this.trafficLight4.BackColor = Color.Red;
                timer4.Stop();
                cont11 = 0;
                //timer3.Start();
            }
        }

        private void timer8_Tick_1(object sender, EventArgs e)
        {
            if (car10.Top <= 236)
            {
                car10.Top -= 40;
            }
            if (car11.Top <= 236)
            {
                car11.Top -= 40;
            }
            if (car12.Top <= 236)
            {
                car12.Top -= 40;
            }
        }
    }
}
