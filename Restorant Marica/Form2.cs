using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restorant_Marica
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double smetka = 0;
            List<string> list = new List<string>();
            if (checkBox1.Checked && int.Parse(textBox1.Text) > 0)
            {
                smetka += 11.50 * int.Parse(textBox1.Text);
                list.Add(textBox1.Text + " " + checkBox1.Text);
            }
            else
            if (checkBox2.Checked && int.Parse(textBox2.Text) > 0)
            {
                smetka += 10.50 * int.Parse(checkBox2.Text);
                list.Add(textBox2.Text + " " + textBox2);
            }
            else
            if (checkBox3.Checked && int.Parse(textBox3.Text) > 0)
            {
                smetka += 12.80 * int.Parse(checkBox3.Text);
                list.Add(checkBox3.Text + " " + textBox3);
            }
            else
            if (checkBox4.Checked && int.Parse(textBox4.Text) > 0)
            {
                smetka += 16.20 * int.Parse(checkBox4.Text);
                list.Add(checkBox4.Text + " " + textBox4);
            }
            else
            if (checkBox5.Checked && int.Parse(checkBox5.Text) > 0)
            {
                smetka += 17.90 * int.Parse(checkBox5.Text);
                list.Add(checkBox5.Text + " " + textBox5);
            }
            else
            if (checkBox6.Checked && int.Parse(checkBox6.Text) > 0)
            {
                smetka += 4.00 * int.Parse(checkBox6.Text);
                list.Add(checkBox6.Text + " " + textBox6);
            }
            else
            if (checkBox7.Checked && int.Parse(checkBox7.Text) > 0)
            {
                smetka += 3.50 * int.Parse(checkBox7.Text);
                list.Add(checkBox7.Text + " " + textBox7);

            }
            else
            if (checkBox8.Checked && int.Parse(checkBox8.Text) > 0)
            {
                smetka += 5.00 * int.Parse(checkBox8.Text);
                list.Add(checkBox8.Text + " " + textBox8);

            }
            else
            if (checkBox9.Checked && int.Parse(checkBox9.Text) > 0)
            {
                smetka += 0.80 * int.Parse(checkBox7.Text);
                list.Add(checkBox9.Text + " " + textBox9);

            }
            else
            if (checkBox10.Checked && int.Parse(checkBox10.Text) > 0)
            {
                smetka += 1.40 * int.Parse(checkBox10.Text);
                list.Add(checkBox10.Text + " " + textBox10);

            }
            else
            if (checkBox11.Checked && int.Parse(checkBox11.Text) > 0)
            {
                smetka += 2.20 * int.Parse(checkBox11.Text);
                list.Add(checkBox11.Text + " " + textBox11);

            }
            else
            if (checkBox12.Checked && int.Parse(checkBox12.Text) > 0)
            {
                smetka += 5.80 * int.Parse(checkBox12.Text);
                list.Add(checkBox12.Text + " " + textBox12);

            }
            else
            if (checkBox13.Checked && int.Parse(checkBox13.Text) > 0)
            {
                smetka += 7.00 * int.Parse(checkBox13.Text);
                list.Add(checkBox13.Text + " " + textBox13);

            }
            else
            if (checkBox14.Checked && int.Parse(checkBox14.Text) > 0)
            {
                smetka += 5.60 * int.Parse(checkBox14.Text);
                list.Add(checkBox14.Text + " " + textBox14);

            }
            else
            if (checkBox15.Checked && int.Parse(checkBox15.Text) > 0)
            {
                smetka += 6.50 * int.Parse(checkBox15.Text);
                list.Add(checkBox15.Text + " " + textBox15);

            }
            else
                MessageBox.Show($"{string.Join(Environment.NewLine, list)}\n Вашата сметка е: " + smetka + " лв.");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
