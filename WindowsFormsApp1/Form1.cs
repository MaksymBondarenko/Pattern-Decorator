using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Components;
using WindowsFormsApp1.Conditions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Bevarage bevarage = new Espresso();
        Bevarage bevarage1 = new Americano();
        Bevarage bevarage2 = new Capuccino();
        Bevarage bevarage3 = new Latte();
        int buf = 0;
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;

            if (comboBox1.SelectedIndex == 0)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                textBox1.Text = $"{bevarage.getDescription()}";
                textBox2.Text = $"{bevarage.cost()}";
                buf = 1;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                textBox1.Text = $"{bevarage1.getDescription()}";
                textBox2.Text = $"{bevarage1.cost()}";
                buf = 2;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                textBox1.Text = $"{bevarage2.getDescription()}";
                textBox2.Text = $"{bevarage2.cost()}";
                buf = 3;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                textBox1.Text = $"{bevarage3.getDescription()}";
                textBox2.Text = $"{bevarage3.cost()}";
                buf = 4;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            textBox3.Text = "0,31";
            switch (buf)
            {
                case 1:
                    if (checkBox1.Checked)
                    {
                       
                        bevarage = new Mocha(bevarage);
                        textBox1.Text = $"{bevarage.getDescription()}";
                        textBox2.Text = $"{bevarage.cost()}";
                    }
                    else
                    {
                        bevarage = new Espresso();
                        textBox1.Text = $"{bevarage.getDescription()}";
                        textBox2.Text = $"{bevarage.cost()}";
                        textBox3.Text = "0";
                    }
                    break;

                case 2:
                    if (checkBox1.Checked)
                    {
                        bevarage1 = new Mocha(bevarage1);
                        textBox1.Text = $"{bevarage1.getDescription()}";
                        textBox2.Text = $"{bevarage1.cost()}";
                    }
                    else
                    {
                        bevarage1 = new Americano();
                        textBox1.Text = $"{bevarage1.getDescription()}";
                        textBox2.Text = $"{bevarage1.cost()}";
                        textBox3.Text = "0";
                    }
                    break;

                case 3:
                    if (checkBox1.Checked)
                    {
                        bevarage2 = new Mocha(bevarage2);
                        textBox1.Text = $"{bevarage2.getDescription()}";
                        textBox2.Text = $"{bevarage2.cost()}";
                    }
                    else
                    {
                        bevarage2 = new Capuccino();
                        textBox1.Text = $"{bevarage2.getDescription()}";
                        textBox2.Text = $"{bevarage2.cost()}";
                        textBox3.Text = "0";
                    }
                    break;
                case 4:
                    if (checkBox1.Checked)
                    {
                        bevarage3 = new Mocha(bevarage3);
                        textBox1.Text = $"{bevarage3.getDescription()}";
                        textBox2.Text = $"{bevarage3.cost()}";
                    }
                    else
                    {
                        bevarage3 = new Latte();
                        textBox1.Text = $"{bevarage3.getDescription()}";
                        textBox2.Text = $"{bevarage3.cost()}";
                        textBox3.Text = "0";
                    }
                    break;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;
            textBox4.Text = "0,35";
            switch (buf)
            {
                case 1:
                    if (checkBox2.Checked)
                    {
                        bevarage = new Soy(bevarage);
                        textBox1.Text = $"{bevarage.getDescription()}";
                        textBox2.Text = $"{bevarage.cost()}";
                    }
                    else
                    {
                        bevarage = new Espresso();
                        bevarage = new Mocha(bevarage);
                        textBox1.Text = $"{bevarage.getDescription()}";
                        textBox2.Text = $"{bevarage.cost()}";
                        textBox4.Text = "0";
                    }
                    break;

                case 2:
                    if (checkBox2.Checked)
                    {
                        bevarage1 = new Soy(bevarage1);
                        textBox1.Text = $"{bevarage1.getDescription()}";
                        textBox2.Text = $"{bevarage1.cost()}";
                    }
                    else
                    {
                        bevarage1 = new Americano();
                        bevarage1 = new Mocha(bevarage1);
                        textBox1.Text = $"{bevarage1.getDescription()}";
                        textBox2.Text = $"{bevarage1.cost()}";
                        textBox4.Text = "0";
                    }
                    break;

                case 3:
                    if (checkBox2.Checked)
                    {
                        bevarage2 = new Soy(bevarage2);
                        textBox1.Text = $"{bevarage2.getDescription()}";
                        textBox2.Text = $"{bevarage2.cost()}";
                    }
                    else
                    {
                        bevarage2 = new Capuccino();
                        bevarage2 = new Mocha(bevarage2);
                        textBox1.Text = $"{bevarage2.getDescription()}";
                        textBox2.Text = $"{bevarage2.cost()}";
                        textBox4.Text = "0";
                    }
                    break;

                case 4:
                    if (checkBox2.Checked)
                    {
                        bevarage3 = new Soy(bevarage3);
                        textBox1.Text = $"{bevarage3.getDescription()}";
                        textBox2.Text = $"{bevarage3.cost()}";
                    }
                    else
                    {
                        bevarage3 = new Latte();
                        bevarage3 = new Mocha(bevarage3);
                        textBox1.Text = $"{bevarage3.getDescription()}";
                        textBox2.Text = $"{bevarage3.cost()}";
                        textBox4.Text = "0";
                    }
                    break;

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox4.Enabled = true;
            textBox5.Text = "0,40";
            switch (buf)
            {
                case 1:
                    if (checkBox3.Checked)
                    {
                        bevarage = new Milk(bevarage);
                        textBox1.Text = $"{bevarage.getDescription()}";
                        textBox2.Text = $"{bevarage.cost()}";
                    }
                    else
                    {
                        bevarage = new Espresso();
                        bevarage = new Mocha(bevarage);
                        bevarage = new Soy(bevarage);
                        textBox1.Text = $"{bevarage.getDescription()}";
                        textBox2.Text = $"{bevarage.cost()}";
                        textBox5.Text = "0";
                    }
                    break;

                case 2:
                    if (checkBox3.Checked)
                    {
                        bevarage1 = new Milk(bevarage1);
                        textBox1.Text = $"{bevarage1.getDescription()}";
                        textBox2.Text = $"{bevarage1.cost()}";
                    }
                    else
                    {
                        bevarage1 = new Americano();
                        bevarage1 = new Mocha(bevarage1);
                        bevarage1 = new Soy(bevarage1);
                        textBox1.Text = $"{bevarage1.getDescription()}";
                        textBox2.Text = $"{bevarage1.cost()}";
                        textBox5.Text = "0";
                    }
                    break;

                case 3:
                    if (checkBox3.Checked)
                    {
                        bevarage2 = new Milk(bevarage2);
                        textBox1.Text = $"{bevarage2.getDescription()}";
                        textBox2.Text = $"{bevarage2.cost()}";
                    }
                    else
                    {
                        bevarage2 = new Capuccino();
                        bevarage2 = new Mocha(bevarage2);
                        bevarage2 = new Soy(bevarage2);
                        textBox1.Text = $"{bevarage2.getDescription()}";
                        textBox2.Text = $"{bevarage2.cost()}";
                        textBox5.Text = "0";
                    }
                    break;

                case 4:
                    if (checkBox3.Checked)
                    {
                        bevarage3 = new Milk(bevarage3);
                        textBox1.Text = $"{bevarage3.getDescription()}";
                        textBox2.Text = $"{bevarage3.cost()}";
                    }
                    else
                    {
                        bevarage3 = new Latte();
                        bevarage3 = new Mocha(bevarage3);
                        bevarage3 = new Soy(bevarage3);
                        textBox1.Text = $"{bevarage3.getDescription()}";
                        textBox2.Text = $"{bevarage3.cost()}";
                        textBox5.Text = "0";
                    }
                    break;

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox5.Enabled = true;
            textBox6.Text = "0,55";
            switch (buf)
            {
                case 1:
                    if (checkBox4.Checked)
                    {
                        bevarage = new Whip(bevarage);
                        textBox1.Text = $"{bevarage.getDescription()}";
                        textBox2.Text = $"{bevarage.cost()}";
                    }
                    else
                    {
                        bevarage = new Espresso();
                        bevarage = new Mocha(bevarage);
                        bevarage = new Soy(bevarage);
                        bevarage = new Milk(bevarage);
                        textBox1.Text = $"{bevarage.getDescription()}";
                        textBox2.Text = $"{bevarage.cost()}";
                        textBox6.Text = "0";
                    }
                    break;

                case 2:
                    if (checkBox3.Checked)
                    {
                        bevarage1 = new Whip(bevarage1);
                        textBox1.Text = $"{bevarage1.getDescription()}";
                        textBox2.Text = $"{bevarage1.cost()}";
                    }
                    else
                    {
                        bevarage1 = new Americano();
                        bevarage1 = new Mocha(bevarage1);
                        bevarage1 = new Soy(bevarage1);
                        bevarage1 = new Milk(bevarage1);
                        textBox1.Text = $"{bevarage1.getDescription()}";
                        textBox2.Text = $"{bevarage1.cost()}";
                        textBox6.Text = "0";
                    }
                    break;

                case 3:
                    if (checkBox3.Checked)
                    {
                        bevarage2 = new Whip(bevarage2);
                        textBox1.Text = $"{bevarage2.getDescription()}";
                        textBox2.Text = $"{bevarage2.cost()}";
                    }
                    else
                    {
                        bevarage2 = new Capuccino();
                        bevarage2 = new Mocha(bevarage2);
                        bevarage2 = new Soy(bevarage2);
                        bevarage2 = new Milk(bevarage2);
                        textBox1.Text = $"{bevarage2.getDescription()}";
                        textBox2.Text = $"{bevarage2.cost()}";
                        textBox6.Text = "0";
                    }
                    break;

                case 4:
                    if (checkBox3.Checked)
                    {
                        bevarage3 = new Whip(bevarage3);
                        textBox1.Text = $"{bevarage3.getDescription()}";
                        textBox2.Text = $"{bevarage3.cost()}";
                    }
                    else
                    {
                        bevarage3 = new Latte();
                        bevarage3 = new Mocha(bevarage3);
                        bevarage3 = new Soy(bevarage3);
                        bevarage3 = new Milk(bevarage3);
                        textBox1.Text = $"{bevarage3.getDescription()}";
                        textBox2.Text = $"{bevarage3.cost()}";
                        textBox6.Text = "0";
                    }
                    break;
            }



        }

    }
}