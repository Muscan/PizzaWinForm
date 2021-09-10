using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PizzaWinForm.ControllerPizza;

namespace PizzaWinForm
{
    public partial class Form1 : Form
    {
        string noOptionWasSelected = "No option was selected! ";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(IsChecked3(checkBox1, checkBox2, checkBox3) == false)
            {
                MessageBox.Show(noOptionWasSelected);
            }
            else if
               (IsChecked3(checkBox4, checkBox5, checkBox6) == false)
            {
                MessageBox.Show(noOptionWasSelected);
            }
            else if
                (IsChecked6(checkBox7, checkBox8, checkBox9, checkBox10, checkBox11, checkBox12) == false)
            {
                MessageBox.Show(noOptionWasSelected);
            }
            else
            {
                double pret = 0;
                if (checkBox1.Checked == true)
                {
                    pret += 5.6;

                }
                if (checkBox2.Checked == true)
                {
                    pret += 13.22;
                }
                if (checkBox3.Checked == true)
                {
                    pret += 10.4;
                }
                if (checkBox4.Checked == true)
                {
                    pret += 1.6;
                }
                if (checkBox5.Checked == true)
                {
                    pret += 12.4;
                }
                if (checkBox6.Checked == true)
                {
                    pret += 5.5;
                }
                if (checkBox7.Checked == true)
                {
                    pret += 3;
                }
                if (checkBox8.Checked == true)
                {
                    pret += 2;
                }
                if (checkBox9.Checked == true)
                {
                    pret += 1;
                }
                if(checkBox10.Checked == true)
                {
                    pret += 4;
                }
                if (checkBox11.Checked == true)
                {
                    pret += 5;
                }
                if (checkBox12.Checked == true)
                {
                    pret += 10;
                }
                lblTotal.Visible = true;
                lblTotal.Text = pret.ToString();
            }
            

            
        }

        //first group box
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        //Choose the size
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
