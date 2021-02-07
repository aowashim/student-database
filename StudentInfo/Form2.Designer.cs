
namespace StudentInfo
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddClr = new System.Windows.Forms.Button();
            this.txtDnoDl = new System.Windows.Forms.TextBox();
            this.lblDno = new System.Windows.Forms.Label();
            this.txtDname = new System.Windows.Forms.TextBox();
            this.txtDnoCl = new System.Windows.Forms.TextBox();
            this.lblDnoClist = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.txtCcodeCL = new System.Windows.Forms.TextBox();
            this.lblCcodeClist = new System.Windows.Forms.Label();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.lblCname = new System.Windows.Forms.Label();
            this.txtCcodeAc = new System.Windows.Forms.TextBox();
            this.lblCcodeAdd = new System.Windows.Forms.Label();
            this.txtRollno = new System.Windows.Forms.TextBox();
            this.lblRollnof2 = new System.Windows.Forms.Label();
            this.lblDname = new System.Windows.Forms.Label();
            this.btnClistclr = new System.Windows.Forms.Button();
            this.btnAddClist = new System.Windows.Forms.Button();
            this.btnDlistclr = new System.Windows.Forms.Button();
            this.btnAddDlist = new System.Windows.Forms.Button();
            this.grdstudentCourse = new System.Windows.Forms.DataGridView();
            this.grdcourseList = new System.Windows.Forms.DataGridView();
            this.grddeptList = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDeptList = new System.Windows.Forms.Label();
            this.lblCourseList = new System.Windows.Forms.Label();
            this.lblCourseTaken = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdstudentCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdcourseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grddeptList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddClr
            // 
            this.btnAddClr.BackColor = System.Drawing.Color.Maroon;
            this.btnAddClr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddClr.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClr.ForeColor = System.Drawing.Color.White;
            this.btnAddClr.Location = new System.Drawing.Point(348, 279);
            this.btnAddClr.Name = "btnAddClr";
            this.btnAddClr.Size = new System.Drawing.Size(125, 42);
            this.btnAddClr.TabIndex = 64;
            this.btnAddClr.Text = "CLEAR";
            this.btnAddClr.UseVisualStyleBackColor = false;
            this.btnAddClr.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDnoDl
            // 
            this.txtDnoDl.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDnoDl.Location = new System.Drawing.Point(1247, 198);
            this.txtDnoDl.Name = "txtDnoDl";
            this.txtDnoDl.Size = new System.Drawing.Size(281, 27);
            this.txtDnoDl.TabIndex = 59;
            this.txtDnoDl.TextChanged += new System.EventHandler(this.txtDnoDl_TextChanged);
            // 
            // lblDno
            // 
            this.lblDno.AutoSize = true;
            this.lblDno.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDno.Location = new System.Drawing.Point(1070, 197);
            this.lblDno.Name = "lblDno";
            this.lblDno.Size = new System.Drawing.Size(145, 28);
            this.lblDno.TabIndex = 58;
            this.lblDno.Text = "Dept. no.  :";
            // 
            // txtDname
            // 
            this.txtDname.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDname.Location = new System.Drawing.Point(1247, 140);
            this.txtDname.Name = "txtDname";
            this.txtDname.Size = new System.Drawing.Size(281, 27);
            this.txtDname.TabIndex = 57;
            // 
            // txtDnoCl
            // 
            this.txtDnoCl.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDnoCl.Location = new System.Drawing.Point(740, 261);
            this.txtDnoCl.Name = "txtDnoCl";
            this.txtDnoCl.Size = new System.Drawing.Size(281, 27);
            this.txtDnoCl.TabIndex = 43;
            // 
            // lblDnoClist
            // 
            this.lblDnoClist.AutoSize = true;
            this.lblDnoClist.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDnoClist.Location = new System.Drawing.Point(543, 259);
            this.lblDnoClist.Name = "lblDnoClist";
            this.lblDnoClist.Size = new System.Drawing.Size(137, 28);
            this.lblDnoClist.TabIndex = 42;
            this.lblDnoClist.Text = "Dept. no. :";
            // 
            // txtCredit
            // 
            this.txtCredit.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredit.Location = new System.Drawing.Point(740, 204);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(281, 27);
            this.txtCredit.TabIndex = 41;
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(543, 202);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(99, 28);
            this.lblCredit.TabIndex = 40;
            this.lblCredit.Text = "Credit :";
            // 
            // txtCcodeCL
            // 
            this.txtCcodeCL.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCcodeCL.Location = new System.Drawing.Point(740, 145);
            this.txtCcodeCL.Name = "txtCcodeCL";
            this.txtCcodeCL.Size = new System.Drawing.Size(281, 27);
            this.txtCcodeCL.TabIndex = 39;
            this.txtCcodeCL.TextChanged += new System.EventHandler(this.txtCcodeCL_TextChanged);
            // 
            // lblCcodeClist
            // 
            this.lblCcodeClist.AutoSize = true;
            this.lblCcodeClist.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCcodeClist.Location = new System.Drawing.Point(543, 143);
            this.lblCcodeClist.Name = "lblCcodeClist";
            this.lblCcodeClist.Size = new System.Drawing.Size(173, 28);
            this.lblCcodeClist.TabIndex = 38;
            this.lblCcodeClist.Text = "Course code :";
            // 
            // txtCname
            // 
            this.txtCname.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCname.Location = new System.Drawing.Point(740, 94);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(281, 27);
            this.txtCname.TabIndex = 37;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.Maroon;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCourse.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Location = new System.Drawing.Point(128, 279);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(147, 42);
            this.btnAddCourse.TabIndex = 36;
            this.btnAddCourse.Text = "ADD";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCname.Location = new System.Drawing.Point(543, 92);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(181, 28);
            this.lblCname.TabIndex = 35;
            this.lblCname.Text = "Course name :";
            this.lblCname.Click += new System.EventHandler(this.lblFname_Click);
            // 
            // txtCcodeAc
            // 
            this.txtCcodeAc.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCcodeAc.Location = new System.Drawing.Point(204, 194);
            this.txtCcodeAc.Name = "txtCcodeAc";
            this.txtCcodeAc.Size = new System.Drawing.Size(281, 27);
            this.txtCcodeAc.TabIndex = 68;
            this.txtCcodeAc.TextChanged += new System.EventHandler(this.txtCcodeAc_TextChanged);
            // 
            // lblCcodeAdd
            // 
            this.lblCcodeAdd.AutoSize = true;
            this.lblCcodeAdd.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCcodeAdd.Location = new System.Drawing.Point(7, 192);
            this.lblCcodeAdd.Name = "lblCcodeAdd";
            this.lblCcodeAdd.Size = new System.Drawing.Size(173, 28);
            this.lblCcodeAdd.TabIndex = 67;
            this.lblCcodeAdd.Text = "Course code :";
            // 
            // txtRollno
            // 
            this.txtRollno.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRollno.Location = new System.Drawing.Point(204, 143);
            this.txtRollno.Name = "txtRollno";
            this.txtRollno.Size = new System.Drawing.Size(281, 27);
            this.txtRollno.TabIndex = 66;
            // 
            // lblRollnof2
            // 
            this.lblRollnof2.AutoSize = true;
            this.lblRollnof2.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollnof2.Location = new System.Drawing.Point(7, 141);
            this.lblRollnof2.Name = "lblRollnof2";
            this.lblRollnof2.Size = new System.Drawing.Size(118, 28);
            this.lblRollnof2.TabIndex = 65;
            this.lblRollnof2.Text = "Roll no. :";
            // 
            // lblDname
            // 
            this.lblDname.AutoSize = true;
            this.lblDname.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDname.Location = new System.Drawing.Point(1070, 139);
            this.lblDname.Name = "lblDname";
            this.lblDname.Size = new System.Drawing.Size(162, 28);
            this.lblDname.TabIndex = 56;
            this.lblDname.Text = "Dept. name :";
            // 
            // btnClistclr
            // 
            this.btnClistclr.BackColor = System.Drawing.Color.Maroon;
            this.btnClistclr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClistclr.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClistclr.ForeColor = System.Drawing.Color.White;
            this.btnClistclr.Location = new System.Drawing.Point(884, 328);
            this.btnClistclr.Name = "btnClistclr";
            this.btnClistclr.Size = new System.Drawing.Size(125, 42);
            this.btnClistclr.TabIndex = 70;
            this.btnClistclr.Text = "CLEAR";
            this.btnClistclr.UseVisualStyleBackColor = false;
            this.btnClistclr.Click += new System.EventHandler(this.btnClistclr_Click);
            // 
            // btnAddClist
            // 
            this.btnAddClist.BackColor = System.Drawing.Color.Maroon;
            this.btnAddClist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddClist.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClist.ForeColor = System.Drawing.Color.White;
            this.btnAddClist.Location = new System.Drawing.Point(659, 328);
            this.btnAddClist.Name = "btnAddClist";
            this.btnAddClist.Size = new System.Drawing.Size(147, 42);
            this.btnAddClist.TabIndex = 69;
            this.btnAddClist.Text = "ADD";
            this.btnAddClist.UseVisualStyleBackColor = false;
            this.btnAddClist.Click += new System.EventHandler(this.btnAddClist_Click);
            // 
            // btnDlistclr
            // 
            this.btnDlistclr.BackColor = System.Drawing.Color.Maroon;
            this.btnDlistclr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDlistclr.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDlistclr.ForeColor = System.Drawing.Color.White;
            this.btnDlistclr.Location = new System.Drawing.Point(1391, 279);
            this.btnDlistclr.Name = "btnDlistclr";
            this.btnDlistclr.Size = new System.Drawing.Size(125, 42);
            this.btnDlistclr.TabIndex = 72;
            this.btnDlistclr.Text = "CLEAR";
            this.btnDlistclr.UseVisualStyleBackColor = false;
            this.btnDlistclr.Click += new System.EventHandler(this.btnDlistclr_Click);
            // 
            // btnAddDlist
            // 
            this.btnAddDlist.BackColor = System.Drawing.Color.Maroon;
            this.btnAddDlist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDlist.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDlist.ForeColor = System.Drawing.Color.White;
            this.btnAddDlist.Location = new System.Drawing.Point(1164, 279);
            this.btnAddDlist.Name = "btnAddDlist";
            this.btnAddDlist.Size = new System.Drawing.Size(147, 42);
            this.btnAddDlist.TabIndex = 71;
            this.btnAddDlist.Text = "ADD";
            this.btnAddDlist.UseVisualStyleBackColor = false;
            this.btnAddDlist.Click += new System.EventHandler(this.btnAddDlist_Click);
            // 
            // grdstudentCourse
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdstudentCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grdstudentCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdstudentCourse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdstudentCourse.Location = new System.Drawing.Point(50, 475);
            this.grdstudentCourse.Name = "grdstudentCourse";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdstudentCourse.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.grdstudentCourse.RowHeadersVisible = false;
            this.grdstudentCourse.RowHeadersWidth = 51;
            this.grdstudentCourse.RowTemplate.Height = 24;
            this.grdstudentCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdstudentCourse.Size = new System.Drawing.Size(396, 350);
            this.grdstudentCourse.TabIndex = 73;
            this.grdstudentCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdstudentCourse_CellContentClick);
            // 
            // grdcourseList
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdcourseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grdcourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdcourseList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdcourseList.Location = new System.Drawing.Point(549, 475);
            this.grdcourseList.Name = "grdcourseList";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdcourseList.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grdcourseList.RowHeadersVisible = false;
            this.grdcourseList.RowHeadersWidth = 51;
            this.grdcourseList.RowTemplate.Height = 24;
            this.grdcourseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdcourseList.Size = new System.Drawing.Size(481, 350);
            this.grdcourseList.TabIndex = 74;
            this.grdcourseList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdcourseList_CellClick);
            this.grdcourseList.Click += new System.EventHandler(this.grdcourseList_Click);
            // 
            // grddeptList
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grddeptList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.grddeptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddeptList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grddeptList.Location = new System.Drawing.Point(1107, 475);
            this.grddeptList.Name = "grddeptList";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grddeptList.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.grddeptList.RowHeadersVisible = false;
            this.grddeptList.RowHeadersWidth = 51;
            this.grddeptList.RowTemplate.Height = 24;
            this.grddeptList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grddeptList.Size = new System.Drawing.Size(396, 350);
            this.grddeptList.TabIndex = 75;
            this.grddeptList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddeptList_CellClick);
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
            this.lblTitle.TabIndex = 76;
            this.lblTitle.Text = "Database of SOE (B Tech) students";
            // 
            // lblDeptList
            // 
            this.lblDeptList.AutoSize = true;
            this.lblDeptList.BackColor = System.Drawing.Color.Transparent;
            this.lblDeptList.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptList.ForeColor = System.Drawing.Color.Crimson;
            this.lblDeptList.Location = new System.Drawing.Point(1111, 433);
            this.lblDeptList.Name = "lblDeptList";
            this.lblDeptList.Size = new System.Drawing.Size(231, 28);
            this.lblDeptList.TabIndex = 77;
            this.lblDeptList.Text = "Department List :";
            // 
            // lblCourseList
            // 
            this.lblCourseList.AutoSize = true;
            this.lblCourseList.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseList.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseList.ForeColor = System.Drawing.Color.Crimson;
            this.lblCourseList.Location = new System.Drawing.Point(555, 433);
            this.lblCourseList.Name = "lblCourseList";
            this.lblCourseList.Size = new System.Drawing.Size(172, 28);
            this.lblCourseList.TabIndex = 78;
            this.lblCourseList.Text = "Course List :";
            // 
            // lblCourseTaken
            // 
            this.lblCourseTaken.AutoSize = true;
            this.lblCourseTaken.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseTaken.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseTaken.ForeColor = System.Drawing.Color.Crimson;
            this.lblCourseTaken.Location = new System.Drawing.Point(45, 433);
            this.lblCourseTaken.Name = "lblCourseTaken";
            this.lblCourseTaken.Size = new System.Drawing.Size(365, 28);
            this.lblCourseTaken.TabIndex = 79;
            this.lblCourseTaken.Text = "Courses taken by students :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 846);
            this.Controls.Add(this.lblCourseTaken);
            this.Controls.Add(this.lblCourseList);
            this.Controls.Add(this.lblDeptList);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grddeptList);
            this.Controls.Add(this.grdcourseList);
            this.Controls.Add(this.grdstudentCourse);
            this.Controls.Add(this.btnDlistclr);
            this.Controls.Add(this.btnAddDlist);
            this.Controls.Add(this.btnClistclr);
            this.Controls.Add(this.btnAddClist);
            this.Controls.Add(this.txtCcodeAc);
            this.Controls.Add(this.lblCcodeAdd);
            this.Controls.Add(this.txtRollno);
            this.Controls.Add(this.lblRollnof2);
            this.Controls.Add(this.btnAddClr);
            this.Controls.Add(this.txtDnoDl);
            this.Controls.Add(this.lblDno);
            this.Controls.Add(this.txtDname);
            this.Controls.Add(this.lblDname);
            this.Controls.Add(this.txtDnoCl);
            this.Controls.Add(this.lblDnoClist);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.txtCcodeCL);
            this.Controls.Add(this.lblCcodeClist);
            this.Controls.Add(this.txtCname);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.lblCname);
            this.Name = "Form2";
            this.Text = "Course/Dept info";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdstudentCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdcourseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grddeptList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddClr;
        private System.Windows.Forms.TextBox txtDnoDl;
        private System.Windows.Forms.Label lblDno;
        private System.Windows.Forms.TextBox txtDname;
        private System.Windows.Forms.TextBox txtDnoCl;
        private System.Windows.Forms.Label lblDnoClist;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.TextBox txtCcodeCL;
        private System.Windows.Forms.Label lblCcodeClist;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label lblCname;
        private System.Windows.Forms.TextBox txtCcodeAc;
        private System.Windows.Forms.Label lblCcodeAdd;
        private System.Windows.Forms.TextBox txtRollno;
        private System.Windows.Forms.Label lblRollnof2;
        private System.Windows.Forms.Label lblDname;
        private System.Windows.Forms.Button btnClistclr;
        private System.Windows.Forms.Button btnAddClist;
        private System.Windows.Forms.Button btnDlistclr;
        private System.Windows.Forms.Button btnAddDlist;
        private System.Windows.Forms.DataGridView grdstudentCourse;
        private System.Windows.Forms.DataGridView grdcourseList;
        private System.Windows.Forms.DataGridView grddeptList;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDeptList;
        private System.Windows.Forms.Label lblCourseList;
        private System.Windows.Forms.Label lblCourseTaken;
    }
}