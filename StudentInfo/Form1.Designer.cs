
namespace StudentInfo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFname = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.txtRollno = new System.Windows.Forms.TextBox();
            this.lblRollno = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtVill = new System.Windows.Forms.TextBox();
            this.lblVill = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtHname = new System.Windows.Forms.TextBox();
            this.lblHname = new System.Windows.Forms.Label();
            this.txtRmno = new System.Windows.Forms.TextBox();
            this.lblRmno = new System.Windows.Forms.Label();
            this.txtDno = new System.Windows.Forms.TextBox();
            this.lblDno = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.lblSno = new System.Windows.Forms.Label();
            this.txtCgpa = new System.Windows.Forms.TextBox();
            this.lblCgpa = new System.Windows.Forms.Label();
            this.txtHobby = new System.Windows.Forms.TextBox();
            this.lblHobby = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnForm2Open = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblStudentList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(39, 84);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(150, 28);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First name :";
            this.lblFname.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.Maroon;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddStudent.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(1092, 319);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(169, 42);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "ADD STUDENT";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.SystemColors.Window;
            this.txtFname.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(204, 86);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(281, 27);
            this.txtFname.TabIndex = 2;
            this.txtFname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(204, 137);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(281, 27);
            this.txtLname.TabIndex = 4;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(39, 135);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(146, 28);
            this.lblLname.TabIndex = 3;
            this.lblLname.Text = "Last name :";
            // 
            // txtRollno
            // 
            this.txtRollno.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRollno.Location = new System.Drawing.Point(204, 196);
            this.txtRollno.Name = "txtRollno";
            this.txtRollno.Size = new System.Drawing.Size(281, 27);
            this.txtRollno.TabIndex = 10;
            this.txtRollno.TextChanged += new System.EventHandler(this.txtRollno_TextChanged);
            // 
            // lblRollno
            // 
            this.lblRollno.AutoSize = true;
            this.lblRollno.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollno.Location = new System.Drawing.Point(39, 194);
            this.lblRollno.Name = "lblRollno";
            this.lblRollno.Size = new System.Drawing.Size(110, 28);
            this.lblRollno.TabIndex = 9;
            this.lblRollno.Text = "Roll no :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(204, 253);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 27);
            this.txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(39, 251);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(90, 28);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email :";
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(204, 307);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(281, 27);
            this.txtGender.TabIndex = 14;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(39, 305);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(111, 28);
            this.lblGender.TabIndex = 13;
            this.lblGender.Text = "Gender :";
            this.lblGender.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDob
            // 
            this.txtDob.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDob.Location = new System.Drawing.Point(711, 82);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(281, 27);
            this.txtDob.TabIndex = 16;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(555, 82);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(79, 28);
            this.lblDob.TabIndex = 15;
            this.lblDob.Text = "DOB :";
            this.lblDob.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // txtVill
            // 
            this.txtVill.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVill.Location = new System.Drawing.Point(711, 137);
            this.txtVill.Name = "txtVill";
            this.txtVill.Size = new System.Drawing.Size(281, 27);
            this.txtVill.TabIndex = 18;
            // 
            // lblVill
            // 
            this.lblVill.AutoSize = true;
            this.lblVill.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVill.Location = new System.Drawing.Point(555, 137);
            this.lblVill.Name = "lblVill";
            this.lblVill.Size = new System.Drawing.Size(106, 28);
            this.lblVill.TabIndex = 17;
            this.lblVill.Text = "Village :";
            // 
            // txtPin
            // 
            this.txtPin.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin.Location = new System.Drawing.Point(711, 196);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(281, 27);
            this.txtPin.TabIndex = 20;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(555, 196);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(66, 28);
            this.lblPin.TabIndex = 19;
            this.lblPin.Text = "PIN :";
            this.lblPin.Click += new System.EventHandler(this.lblPin_Click);
            // 
            // txtHname
            // 
            this.txtHname.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHname.Location = new System.Drawing.Point(711, 250);
            this.txtHname.Name = "txtHname";
            this.txtHname.Size = new System.Drawing.Size(281, 27);
            this.txtHname.TabIndex = 22;
            // 
            // lblHname
            // 
            this.lblHname.AutoSize = true;
            this.lblHname.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHname.Location = new System.Drawing.Point(555, 250);
            this.lblHname.Name = "lblHname";
            this.lblHname.Size = new System.Drawing.Size(102, 28);
            this.lblHname.TabIndex = 21;
            this.lblHname.Text = "Hostel :";
            // 
            // txtRmno
            // 
            this.txtRmno.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRmno.Location = new System.Drawing.Point(711, 307);
            this.txtRmno.Name = "txtRmno";
            this.txtRmno.Size = new System.Drawing.Size(281, 27);
            this.txtRmno.TabIndex = 24;
            // 
            // lblRmno
            // 
            this.lblRmno.AutoSize = true;
            this.lblRmno.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRmno.Location = new System.Drawing.Point(555, 307);
            this.lblRmno.Name = "lblRmno";
            this.lblRmno.Size = new System.Drawing.Size(133, 28);
            this.lblRmno.TabIndex = 23;
            this.lblRmno.Text = "Room no :";
            this.lblRmno.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDno
            // 
            this.txtDno.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDno.Location = new System.Drawing.Point(1219, 83);
            this.txtDno.Name = "txtDno";
            this.txtDno.Size = new System.Drawing.Size(281, 27);
            this.txtDno.TabIndex = 26;
            // 
            // lblDno
            // 
            this.lblDno.AutoSize = true;
            this.lblDno.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDno.Location = new System.Drawing.Point(1063, 83);
            this.lblDno.Name = "lblDno";
            this.lblDno.Size = new System.Drawing.Size(137, 28);
            this.lblDno.TabIndex = 25;
            this.lblDno.Text = "Dept. no. :";
            // 
            // txtSno
            // 
            this.txtSno.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSno.Location = new System.Drawing.Point(1219, 141);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(281, 27);
            this.txtSno.TabIndex = 28;
            // 
            // lblSno
            // 
            this.lblSno.AutoSize = true;
            this.lblSno.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSno.Location = new System.Drawing.Point(1063, 141);
            this.lblSno.Name = "lblSno";
            this.lblSno.Size = new System.Drawing.Size(138, 28);
            this.lblSno.TabIndex = 27;
            this.lblSno.Text = "Sem. no.  :";
            // 
            // txtCgpa
            // 
            this.txtCgpa.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCgpa.Location = new System.Drawing.Point(1219, 200);
            this.txtCgpa.Name = "txtCgpa";
            this.txtCgpa.Size = new System.Drawing.Size(281, 27);
            this.txtCgpa.TabIndex = 30;
            // 
            // lblCgpa
            // 
            this.lblCgpa.AutoSize = true;
            this.lblCgpa.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCgpa.Location = new System.Drawing.Point(1063, 200);
            this.lblCgpa.Name = "lblCgpa";
            this.lblCgpa.Size = new System.Drawing.Size(92, 28);
            this.lblCgpa.TabIndex = 29;
            this.lblCgpa.Text = "CGPA :";
            // 
            // txtHobby
            // 
            this.txtHobby.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHobby.Location = new System.Drawing.Point(1219, 254);
            this.txtHobby.Name = "txtHobby";
            this.txtHobby.Size = new System.Drawing.Size(281, 27);
            this.txtHobby.TabIndex = 32;
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHobby.Location = new System.Drawing.Point(1063, 254);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new System.Drawing.Size(104, 28);
            this.lblHobby.TabIndex = 31;
            this.lblHobby.Text = "Hobby :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitle.Location = new System.Drawing.Point(474, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(613, 45);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Database of SOE (B Tech) students";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1334, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 42);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(44, 511);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1456, 328);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnForm2Open
            // 
            this.btnForm2Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnForm2Open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnForm2Open.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm2Open.ForeColor = System.Drawing.Color.White;
            this.btnForm2Open.Location = new System.Drawing.Point(1028, 385);
            this.btnForm2Open.Name = "btnForm2Open";
            this.btnForm2Open.Size = new System.Drawing.Size(472, 50);
            this.btnForm2Open.TabIndex = 36;
            this.btnForm2Open.Text = "ADD COURSE / UPDATE DEPT / COURSE LIST";
            this.btnForm2Open.UseVisualStyleBackColor = false;
            this.btnForm2Open.Click += new System.EventHandler(this.btnForm2Open_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleDescription = "";
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSearch.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.Location = new System.Drawing.Point(49, 395);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 27);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.Text = "Enter roll no..";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtDelete
            // 
            this.txtDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDelete.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelete.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDelete.Location = new System.Drawing.Point(434, 395);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(200, 27);
            this.txtDelete.TabIndex = 38;
            this.txtDelete.Text = "Enter roll no..";
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            this.txtDelete.TextChanged += new System.EventHandler(this.txtDelete_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Maroon;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(266, 385);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 42);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(658, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 42);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentList.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentList.ForeColor = System.Drawing.Color.Crimson;
            this.lblStudentList.Location = new System.Drawing.Point(44, 469);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(266, 28);
            this.lblStudentList.TabIndex = 41;
            this.lblStudentList.Text = "List of all students :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1551, 846);
            this.Controls.Add(this.lblStudentList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnForm2Open);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtHobby);
            this.Controls.Add(this.lblHobby);
            this.Controls.Add(this.txtCgpa);
            this.Controls.Add(this.lblCgpa);
            this.Controls.Add(this.txtSno);
            this.Controls.Add(this.lblSno);
            this.Controls.Add(this.txtDno);
            this.Controls.Add(this.lblDno);
            this.Controls.Add(this.txtRmno);
            this.Controls.Add(this.lblRmno);
            this.Controls.Add(this.txtHname);
            this.Controls.Add(this.lblHname);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.txtVill);
            this.Controls.Add(this.lblVill);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtRollno);
            this.Controls.Add(this.lblRollno);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblFname);
            this.Name = "Form1";
            this.Text = "Student info";
            this.Load += new System.EventHandler(this.OnForm1Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.TextBox txtRollno;
        private System.Windows.Forms.Label lblRollno;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.TextBox txtVill;
        private System.Windows.Forms.Label lblVill;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtHname;
        private System.Windows.Forms.Label lblHname;
        private System.Windows.Forms.TextBox txtRmno;
        private System.Windows.Forms.Label lblRmno;
        private System.Windows.Forms.TextBox txtDno;
        private System.Windows.Forms.Label lblDno;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.Label lblSno;
        private System.Windows.Forms.TextBox txtCgpa;
        private System.Windows.Forms.Label lblCgpa;
        private System.Windows.Forms.TextBox txtHobby;
        private System.Windows.Forms.Label lblHobby;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnForm2Open;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStudentList;
    }
}

