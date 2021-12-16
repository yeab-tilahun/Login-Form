using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pwd = textBox3.Text;
            string cpwd = textBox4.Text;
            if (pwd.CompareTo(cpwd) == 0)
            {
                MessageBox.Show("The Password Match.");
                User a = new User(textBox1.Text, textBox6.Text, textBox5.Text, textBox2.Text, textBox3.Text, comboBox1.Text);
                a.saveUSer();

            }
            else
            {
                MessageBox.Show("The Password doesn't Match.");
                textBox3.Clear();
                textBox4.Clear();
            }
            button2.PerformClick();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            textBox6.Text = textBox6.Text.Substring(0, 1).ToUpper() + textBox6.Text.Substring(1).ToLower();
        
            }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           // textBox5.Text = textBox5.Text.Substring(0, 1).ToUpper() + textBox5.Text.Substring(1).ToLower();
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Please enter from the list.");
            comboBox1.Text = "";
            

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            User b = new User();
            b.deleteUser(id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            User a = new User(textBox1.Text, textBox6.Text, textBox5.Text, textBox2.Text, textBox3.Text, comboBox1.Text);
            a.updateUSer();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
        }
    
