using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfo
{
    public partial class Form3 : Form
    {
        private string pass = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" || txtPassword.Text != "")
            {
                SqlConnection con = new SqlConnection(UsefullStrings.GetString());
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from auth where Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'", con);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Form1 f = new Form1();
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username/Password");
                    }

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Username/Password cannot be empty");
            }
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(UsefullStrings.GetString());
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into auth (Username, Password) values('" + txtUsername.Text + "', '" + txtPassword.Text + "')", con);
            if (txtUsername.Text != "" || txtPassword.Text != "")
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Registration successful\nUsername : {txtUsername.Text}\nPassword : {txtPassword.Text}");
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Username/Password cannot be empty");
            }
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
