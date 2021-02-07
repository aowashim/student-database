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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblFname_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lblCgpa_Click(object sender, EventArgs e)
        {

        }

        private void txtCgpa_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHobby_Click(object sender, EventArgs e)
        {

        }

        private void txtHobby_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(UsefullStrings.GetString());
            con.Open();
            SqlCommand cmd1;

            if (btnAddCourse.Text == "ADD")
            {
                try
                {
                    cmd1 = new SqlCommand("insert into takes values('" + txtRollno.Text + "', '" + txtCcodeAc.Text + "')", con);
                    cmd1.ExecuteNonQuery();
                    txtCcodeAc.Text = "";
                    LoadAddCourse();
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
                    cmd1 = new SqlCommand("delete from takes where rollno='" + txtRollno.Text + "' and ccode='" + txtCcodeAc.Text + "'", con);
                    cmd1.ExecuteNonQuery();
                    LoadAddCourse();
                    AddCourseClr();
                    btnAddCourse.Text = "ADD";
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AddCourseClr();
        }

        private void AddCourseClr()
        {
            txtRollno.Text = "";
            txtCcodeAc.Text = "";

            if (btnAddCourse.Text != "ADD")
            {
                btnAddCourse.Text = "ADD";
            }
        }

        private void grdstudentCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                string rollno = grdstudentCourse.Rows[n].Cells["Roll no."].Value.ToString();
                string ccode = grdstudentCourse.Rows[n].Cells["Course code"].Value.ToString();

                txtRollno.Text = rollno;
                txtCcodeAc.Text = ccode;

                btnAddCourse.Text = "DELETE";
            }
        }

        private void LoadData()
        {
            LoadAddCourse();
            LoadCourseList();
            LoadDeptList();
        }

        private void LoadDeptList()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Sl. no.");
            dt.Columns.Add("Dept. name");
            dt.Columns.Add("Dept. no.");

            SqlConnection con = new SqlConnection(UsefullStrings.GetString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from department", con);
            SqlDataReader dr = cmd.ExecuteReader();
            int slno = 1;

            while (dr.Read())
            {
                DataRow drx = dt.NewRow();

                drx["Sl. no."] = slno++;
                drx["Dept. name"] = dr["dname"].ToString();
                drx["Dept. no."] = dr["dno"].ToString();

                dt.Rows.Add(drx);
            }

            grddeptList.DataSource = dt;
            con.Close();
        }

        private void LoadCourseList()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Sl. no.");
            dt.Columns.Add("Course name");
            dt.Columns.Add("Course code");
            dt.Columns.Add("Credit");
            dt.Columns.Add("Dept. no.");

            SqlConnection con = new SqlConnection(UsefullStrings.GetString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from course", con);
            SqlDataReader dr = cmd.ExecuteReader();
            int slno = 1;

            while (dr.Read())
            {
                DataRow drx = dt.NewRow();

                drx["Sl. no."] = slno++;
                drx["Course name"] = dr["cname"].ToString();
                drx["Course code"] = dr["ccode"].ToString();
                drx["Credit"] = dr["credit"].ToString();
                drx["Dept. no."] = dr["dno"].ToString();

                dt.Rows.Add(drx);
            }

            grdcourseList.DataSource = dt;
            con.Close();
        }

        private void LoadAddCourse()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Sl. no.");
            dt.Columns.Add("Roll no.");
            dt.Columns.Add("Course code");

            SqlConnection con = new SqlConnection(UsefullStrings.GetString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from takes", con);
            SqlDataReader dr = cmd.ExecuteReader();
            int slno = 1;

            while (dr.Read())
            {
                DataRow drx = dt.NewRow();

                drx["Sl. no."] = slno++;
                drx["Roll no."] = dr["rollno"].ToString();
                drx["Course code"] = dr["ccode"].ToString();

                dt.Rows.Add(drx);
            }

            grdstudentCourse.DataSource = dt;
            con.Close();
        }

        private void btnAddDlist_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(UsefullStrings.GetString());
            con.Open();
            SqlCommand cmd1;

            if (btnAddDlist.Text == "ADD")
            {
                try
                {
                    cmd1 = new SqlCommand("insert into department values('" + txtDname.Text + "', " + txtDnoDl.Text + ")", con);

                    cmd1.ExecuteNonQuery();
                    DeptListClr();
                    LoadDeptList();
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
                    cmd1 = new SqlCommand("update department set dname='" + txtDname.Text + "' where dno=" + txtDnoDl.Text + "", con);
                    cmd1.ExecuteNonQuery();
                    DeptListClr();
                    btnAddDlist.Text = "ADD";
                    LoadDeptList();
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
        }

        private void grdcourseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                txtCname.Text = grdcourseList.Rows[n].Cells["Course name"].Value.ToString();
                txtCcodeCL.Text = grdcourseList.Rows[n].Cells["Course code"].Value.ToString();
                txtCredit.Text = grdcourseList.Rows[n].Cells["Credit"].Value.ToString();
                txtDnoCl.Text = grdcourseList.Rows[n].Cells["Dept. no."].Value.ToString();
            }

            btnAddClist.Text = "UPDATE";
        }

        private void grddeptList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                txtDname.Text = grddeptList.Rows[n].Cells["Dept. name"].Value.ToString();
                txtDnoDl.Text = grddeptList.Rows[n].Cells["Dept. no."].Value.ToString();
            }

            btnAddDlist.Text = "UPDATE";
        }

        private void btnClistclr_Click(object sender, EventArgs e)
        {
            CourseListClr();
            btnAddClist.Text = "ADD";
        }

        private void CourseListClr()
        {
            txtCname.Text = "";
            txtCcodeCL.Text = "";
            txtCredit.Text = "";
            txtDnoCl.Text = "";
        }

        private void btnDlistclr_Click(object sender, EventArgs e)
        {
            DeptListClr();
            btnAddDlist.Text = "ADD";
        }

        private void DeptListClr()
        {
            txtDname.Text = "";
            txtDnoDl.Text = "";
        }

        private void grdcourseList_Click(object sender, EventArgs e)
        {

        }

        private void btnAddClist_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(UsefullStrings.GetString());
            con.Open();
            SqlCommand cmd1;

            if (btnAddClist.Text == "ADD")
            {
                try
                {
                    cmd1 = new SqlCommand("insert into course values('" + txtCname.Text + "', '" + txtCcodeCL.Text + "'," +
                        " " + txtCredit.Text + ", " + txtDnoCl.Text + ")", con);

                    cmd1.ExecuteNonQuery();
                    CourseListClr();
                    LoadCourseList();
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
                    cmd1 = new SqlCommand("update course set cname='" + txtCname.Text + "', credit=" + txtCredit.Text + "," +
                        "dno=" + txtDnoCl.Text + " where ccode='" + txtCcodeCL.Text + "'", con);
                    cmd1.ExecuteNonQuery();
                    //MessageBox.Show("updated");
                    CourseListClr();
                    btnAddClist.Text = "ADD";
                    LoadCourseList();
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
        }

        private void txtCcodeCL_TextChanged(object sender, EventArgs e)
        {
            if (btnAddClist.Text != "ADD")
            {
                btnAddClist.Text = "ADD";
            }
        }

        private void txtDnoDl_TextChanged(object sender, EventArgs e)
        {
            if (btnAddDlist.Text != "ADD")
            {
                btnAddDlist.Text = "ADD";
            }
        }

        private void txtCcodeAc_TextChanged(object sender, EventArgs e)
        {
            if (btnAddCourse.Text != "ADD")
            {
                btnAddCourse.Text = "ADD";
            }
        }
    }
}
