namespace Restorant_Marica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            string a = " ";
            string b = " ";
            if (radioButton1.Checked)
            {
                a = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                a = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                b = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                b = radioButton4.Text;
            }
            if (num > 20)
            {
                MessageBox.Show("Nqma tolkova mesta");
                textBox1.Text = "";
            }
            else if (num < 0)
            {
                MessageBox.Show("Invalid amount");
                textBox1.Text = "";
            }
            else
            {

                MessageBox.Show("Вие избрахте маса за " + textBox1.Text + ", " + b + " ,Плащане с: " + a);

                Form2 form2 = new Form2();
                form2.Show();
            }
        }
    }
}
