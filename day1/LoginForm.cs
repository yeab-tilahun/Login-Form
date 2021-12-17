using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            MemoryStream ms = new MemoryStream();
            pictureBox1.BackgroundImage.Save(ms, pictureBox1.BackgroundImage.RawFormat);
            byte[] Photo = ms.ToArray();

            string pwd = textBox3.Text;
            string cpwd = textBox4.Text;
            if (pwd.CompareTo(cpwd) == 0)
            {
                MessageBox.Show("The Password Match.");
                User a = new User(textBox1.Text, textBox6.Text, textBox5.Text, textBox2.Text, textBox3.Text, comboBox1.Text,Photo);
                a.saveUSer();

            }
            else
            {
                MessageBox.Show("The Password doesn't Match.");
                textBox3.Clear();
                textBox4.Clear();
            }
            //cancel 
          //  button2.PerformClick();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*string query = "Select fname,mname,Username,password,Role from cslab where ID=@ID";
            string constr = "Server=YEABS;   database=cslab; integrated security=true; ";
            if (textBox1.Text != "")
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select fname,mname,Username,password,Role from cslab where ID=@ID", con);
                    cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                    SqlDataReader da = cmd.ExecuteReader();
                    while (da.Read())
                    {
                        textBox6.Text = da.GetValue(0).ToString();
                        textBox5.Text = da.GetValue(1).ToString();
                        textBox2.Text = da.GetValue(2).ToString();
                        textBox3.Text = da.GetValue(3).ToString();
                        comboBox1.Text = da.GetValue(4).ToString();
                    }
                    con.Close();
                }
            }*/
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
            MemoryStream ms = new MemoryStream();
            pictureBox1.BackgroundImage.Save(ms, pictureBox1.BackgroundImage.RawFormat);
            byte[] Photo = ms.ToArray();

            User a = new User(textBox1.Text, textBox6.Text, textBox5.Text, textBox2.Text, textBox3.Text, comboBox1.Text, Photo);
            a.updateUSer();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Choose photo (*.jpg; *.png; *.bmp;) | " + "*.jpg; *.jpeg; *.bmp;";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(op.FileName);  
            }
        }
    }
        }
    
