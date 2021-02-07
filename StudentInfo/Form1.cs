using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfo
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

        private void OnForm1Load(object sender, EventArgs e)
        {
            //lblFname.Text = "Hello...";
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Sl. no.");
            dt.Columns.Add("First name");
            dt.Columns.Add("Last name");
            dt.Columns.Add("Roll no.");
            dt.Columns.Add("Email");
            dt.Columns.Add("Gender");
            dt.Columns.Add("DOB");
            dt.Columns.Add("Village");
            dt.Columns.Add("PIN");
            dt.Columns.Add("Hostel");
            dt.Columns.Add("Room no.");
            dt.Columns.Add("Dept. no.");
            dt.Columns.Add("Sem. no.");
            dt.Columns.Add("CGPA");
            dt.Columns.Add("Hobby");

            SqlConnection con = new SqlConnection(UsefullStrings.GetString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from student", con);
            SqlDataReader dr = cmd.ExecuteReader();

            int slno = 1;

            while (dr.Read())
            {
                DataRow drx = dt.NewRow();

                drx["Sl. no."] = slno++;
                drx["First name"] = dr["fname"].ToString();
                drx["Last name"] = dr["lname"].ToString();
                drx["Roll no."] = dr["rollno"].ToString();
                drx["Email"] = dr["email"].ToString();
                drx["Gender"] = dr["gender"].ToString();
                drx["DOB"] = dr["dob"].ToString();
                drx["Village"] = dr["vill"].ToString();
                drx["PIN"] = dr["pin"].ToString();
                drx["Hostel"] = dr["hname"].ToString();
                drx["Room no."] = dr["rmno"].ToString();
                drx["Dept. no."] = dr["dno"].ToString();
                drx["Sem. no."] = dr["semno"].ToString();
                drx["CGPA"] = dr["cgpa"].ToString();
                drx["Hobby"] = dr["hobby"].ToString();

                dt.Rows.Add(drx);
            }

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(UsefullStrings.GetString());
            con.Open();
            SqlCommand cmd1;

            if (btnAddStudent.Text == "ADD STUDENT")
            {
                try
                {
                    cmd1 = new SqlCommand("insert into student (fname, lname, rollno, email, gender, dob, hobby, vill, pin, hname, dno, semno, cgpa, rmno)" +
                        "values('" + txtFname.Text + "', '" + txtLname.Text + "', '" + txtRollno.Text + "', '" + txtEmail.Text + "', '" + txtGender.Text + "', '" + txtDob.Text + "','" + txtHobby.Text + "'," +
                        " '" + txtVill.Text + "', " + txtPin.Text + ", '" + txtHname.Text + "', " + txtDno.Text + ", " + txtSno.Text + ", " + txtCgpa.Text + ", " + txtRmno.Text + ")", con);

                    cmd1.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show($"{txtRollno.Text} added successfully");
                    ClearFields();
                }

                catch (Exception er)
                {
                    MessageBox.Show(UsefullStrings.ErrorString() + er.Message);
                }

                finally
                {
                    con.Close();
                }
            }

            else
            {
                try
                {
                    cmd1 = new SqlCommand("update student set fname='" + txtFname.Text + "', lname='" + txtLname.Text + "', email='" + txtEmail.Text + "'," +
                        "gender='" + txtGender.Text + "', dob='" + txtDob.Text + "', hobby='" + txtHobby.Text + "', vill='" + txtVill.Text + "', pin=" + txtPin.Text + "," +
                        "hname='" + txtHname.Text + "', dno=" + txtDno.Text + ", semno=" + txtSno.Text + ", cgpa=" + txtCgpa.Text + ", rmno=" + txtRmno.Text + " where rollno='" + txtRollno.Text + "'", con);

                    cmd1.ExecuteNonQuery();       
                    btnAddStudent.Text = "ADD STUDENT";
                    LoadData();
                    MessageBox.Show($"Information of {txtRollno.Text} updated successfully");
                    ClearFields();
                }

                catch (Exception er)
                {
                    MessageBox.Show(UsefullStrings.ErrorString() + er.Message);
                }

                finally
                {
                    con.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                string fname = dataGridView1.Rows[n].Cells["First name"].Value.ToString();
                string lname = dataGridView1.Rows[n].Cells["Last name"].Value.ToString();
                string rollno = dataGridView1.Rows[n].Cells["Roll no."].Value.ToString();
                string email = dataGridView1.Rows[n].Cells["Email"].Value.ToString();
                string gender = dataGridView1.Rows[n].Cells["Gender"].Value.ToString();
                string dob = dataGridView1.Rows[n].Cells["DOB"].Value.ToString();
                string vill = dataGridView1.Rows[n].Cells["Village"].Value.ToString();
                string pin = dataGridView1.Rows[n].Cells["PIN"].Value.ToString();
                string hname = dataGridView1.Rows[n].Cells["Hostel"].Value.ToString();
                string rmno = dataGridView1.Rows[n].Cells["Room no."].Value.ToString();
                string dno = dataGridView1.Rows[n].Cells["Dept. no."].Value.ToString();
                string semno = dataGridView1.Rows[n].Cells["Sem. no."].Value.ToString();
                string cgpa = dataGridView1.Rows[n].Cells["CGPA"].Value.ToString();
                string hobby = dataGridView1.Rows[n].Cells["Hobby"].Value.ToString();

                txtFname.Text = fname;
                txtLname.Text = lname;
                txtRollno.Text = rollno;
                txtEmail.Text = email;
                txtGender.Text = gender;
                txtDob.Text = dob;
                txtHobby.Text = hobby;
                txtVill.Text = vill;
                txtPin.Text = pin;
                txtHname.Text = hname;
                txtDno.Text = dno;
                txtSno.Text = semno;
                txtCgpa.Text = cgpa;
                txtRmno.Text = rmno;
            }

            btnAddStudent.Text = "UPDATE";

            /*dataGridView1.Rows[n].Cells["fname"].Value.ToString();
            dataGridView1.Rows[n].Cells["lname"].Value.ToString();
            dataGridView1.Rows[n].Cells["rollno"].Value.ToString();
            dataGridView1.Rows[n].Cells["email"].Value.ToString();
            dataGridView1.Rows[n].Cells["gender"].Value.ToString();
            dataGridView1.Rows[n].Cells["dob"].Value.ToString();
            dataGridView1.Rows[n].Cells["vill"].Value.ToString();
            dataGridView1.Rows[n].Cells["pin"].Value.ToString();
            dataGridView1.Rows[n].Cells["hname"].Value.ToString();
            dataGridView1.Rows[n].Cells["rmno"].Value.ToString();
            dataGridView1.Rows[n].Cells["dno"].Value.ToString();
            dataGridView1.Rows[n].Cells["semno"].Value.ToString();
            dataGridView1.Rows[n].Cells["cgpa"].Value.ToString();
            dataGridView1.Rows[n].Cells["hobby"].Value.ToString();*/

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();

            btnAddStudent.Text = "ADD STUDENT";
        }

        private void ClearFields()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtRollno.Text = "";
            txtEmail.Text = "";
            txtGender.Text = "";
            txtDob.Text = "";
            txtHobby.Text = "";
            txtVill.Text = "";
            txtPin.Text = "";
            txtHname.Text = "";
            txtDno.Text = "";
            txtSno.Text = "";
            txtCgpa.Text = "";
            txtRmno.Text = "";
        }

        private void lblPin_Click(object sender, EventArgs e)
        {

        }

        private void txtRollno_TextChanged(object sender, EventArgs e)
        {
            if (btnAddStudent.Text != "ADD STUDENT")
            {
                btnAddStudent.Text = "ADD STUDENT";
            }
        }

        private void btnForm2Open_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtDelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtSearch_Move(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter roll no..")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            if (txtDelete.Text == "Enter roll no..")
            {
                txtDelete.Text = "";
                txtDelete.ForeColor = Color.Black;
            }
        }

        private void brnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(UsefullStrings.GetString());
            con.Open();
            SqlCommand cmd1;

            try
            {
                cmd1 = new SqlCommand("select * from student where rollno='" + txtSearch.Text + "'", con);
                SqlDataReader dr = cmd1.ExecuteReader();
                dr.Read();

                txtFname.Text = dr["fname"].ToString();
                txtLname.Text = dr["lname"].ToString();
                txtRollno.Text = dr["rollno"].ToString();
                txtEmail.Text = dr["email"].ToString();
                txtGender.Text = dr["gender"].ToString();
                txtDob.Text = dr["dob"].ToString();
                txtHobby.Text = dr["hobby"].ToString();
                txtVill.Text = dr["vill"].ToString();
                txtPin.Text = dr["pin"].ToString();
                txtHname.Text = dr["hname"].ToString();
                txtDno.Text = dr["dno"].ToString();
                txtSno.Text = dr["semno"].ToString();
                txtCgpa.Text = dr["cgpa"].ToString();
                txtRmno.Text = dr["rmno"].ToString();

                string course = "Courses taken by "+txtRollno.Text+" :\n";
                int cnt = 1;
                dr.Close();
                cmd1 = new SqlCommand("select ccode from takes where rollno='" + txtRollno.Text + "'", con);
                dr = cmd1.ExecuteReader();
                
                while(dr.Read())
                {
                    course += (""+cnt+" : " + dr[0].ToString() + "\n");
                    cnt++;
                }

                course += "\nClick OK to see other details...";

                MessageBox.Show(course);

                btnAddStudent.Text = "UPDATE";
                txtSearch.Text = "Enter roll no..";
                txtSearch.ForeColor = Color.DarkGray;
            }

            catch (Exception)
            {
                MessageBox.Show("Please enter a valid roll number..");
                txtSearch.Text = "Enter roll no..";
                txtSearch.ForeColor = Color.DarkGray;
            }

            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(UsefullStrings.GetString());
            con.Open();
            SqlCommand cmd1;

            cmd1 = new SqlCommand("select rollno from student where rollno='" + txtDelete.Text + "'", con);
            SqlDataReader dr = cmd1.ExecuteReader();

            if (dr.Read())
            {
                dr.Close();
                cmd1 = new SqlCommand("delete from takes where rollno='" + txtDelete.Text + "'", con);
                cmd1.ExecuteNonQuery();
                cmd1 = new SqlCommand("delete from student where rollno='" + txtDelete.Text + "'", con);
                cmd1.ExecuteNonQuery();

                LoadData();
                MessageBox.Show($"{txtDelete.Text} has been deleted succesfully...");
                txtDelete.Text = "Enter roll no..";
                txtDelete.ForeColor = Color.DarkGray;
            }

            else
            {
                MessageBox.Show("Please enter a valid roll number..");
                txtDelete.Text = "Enter roll no..";
                txtDelete.ForeColor = Color.DarkGray;
            }

            con.Close();
        }
    }
}
