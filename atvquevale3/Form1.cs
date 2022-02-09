using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atvquevale3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true){
                comboBox1.Items.Add("1. Python");
                comboBox1.Items.Add("2. Java");
                comboBox1.Items.Add("3. C#");
                comboBox1.Items.Add("4. JavaScript");
                comboBox1.Items.Add("5. PHP");
            }
            if (radioButton2.Checked == true)
            {
                comboBox1.Items.Add("1. Azure");
                comboBox1.Items.Add("2. AWS");
                comboBox1.Items.Add("3. Cisco");
                comboBox1.Items.Add("4. Dell");
                comboBox1.Items.Add("5. Asus");
            }
            if (radioButton3.Checked == true)
            {
                comboBox1.Items.Add("2020 - Parasita");
                comboBox1.Items.Add("2019 - Green Book: O Guia");
                comboBox1.Items.Add("2018 - A Forma da Água");
                comboBox1.Items.Add("2017 - Moonlight");
                comboBox1.Items.Add("2016 - Spotlight: Segredos Revelados");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1. Python")
            {
                pictureBox1.Image = Properties.Resources.download;

            }
            if (comboBox1.Text == "2. Java")
            {
                pictureBox1.Image = Properties.Resources._2014_03_11_veja_como_resolver_problemas_com_o_java_no_pc;

            }
            if (comboBox1.Text == "3. C#")
            {
                pictureBox1.Image = Properties.Resources.main_qimg_f17348e944f5c865183e351175835273;

            }
            if (comboBox1.Text == "4. JavaScript")
            {
                pictureBox1.Image = Properties.Resources.javascript;

            }
            if (comboBox1.Text == "5. PHP")
            {
                pictureBox1.Image = Properties.Resources.PHP_logo_svg;

            }
            if (comboBox1.Text == "1. Azure")
            {
                pictureBox1.Image = Properties.Resources.Logo_Azure_684x226;

            }
            if (comboBox1.Text == "2. AWS")
            {
                pictureBox1.Image = Properties.Resources._1200px_Amazon_Web_Services_Logo_svg;

            }
            if (comboBox1.Text == "3. Cisco")
            {
                pictureBox1.Image = Properties.Resources.cisco;

            }
            if (comboBox1.Text == "4. Dell")
            {
                pictureBox1.Image = Properties.Resources.dell;

            }
            if (comboBox1.Text == "5. Asus")
            {
                pictureBox1.Image = Properties.Resources.asus;

            }

            if (comboBox1.Text== "2020 - Parasita")
            {
                pictureBox1.Image = Properties.Resources._1_Ij9SX7GcMTD6lzbI0jfLFw;

            }
            if (comboBox1.Text == "2019 - Green Book: O Guia")
            {
                pictureBox1.Image = Properties.Resources.green_book;

            }
            if (comboBox1.Text == "2018 - A Forma da Água")
            {
                pictureBox1.Image = Properties.Resources._3044833;

            }
            if (comboBox1.Text == "2017 - Moonlight")
            {
                pictureBox1.Image = Properties.Resources.Moonlight__filme_;

            }
            if (comboBox1.Text == "2016 - Spotlight: Segredos Revelados")
            {
                pictureBox1.Image = Properties.Resources._181510;

            }
        }
    }
}
