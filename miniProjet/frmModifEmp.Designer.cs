namespace miniProjet
{
    partial class frmModifEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifEmp));
            this.cboId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersonalView = new System.Windows.Forms.Button();
            this.grpPersonal = new System.Windows.Forms.GroupBox();
            this.cboBloodGroup = new System.Windows.Forms.ComboBox();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.txtNatioanlity = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtPanno = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.txtEmpname = new System.Windows.Forms.TextBox();
            this.txtEmpid = new System.Windows.Forms.TextBox();
            this.lblReligion = new System.Windows.Forms.Label();
            this.btnPersonalSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.btnContactSubmit = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblZipCode1 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmpIdContct = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpQualification = new System.Windows.Forms.GroupBox();
            this.btnQualificationSubmit = new System.Windows.Forms.Button();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.txtIdQualication = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPassingYear = new System.Windows.Forms.Label();
            this.txtPassingYear = new System.Windows.Forms.TextBox();
            this.lblUniversity = new System.Windows.Forms.Label();
            this.txtUniversity = new System.Windows.Forms.TextBox();
            this.lblDegree = new System.Windows.Forms.Label();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.grpJobDetails = new System.Windows.Forms.GroupBox();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmpIdJob = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblAllocatedLeaves = new System.Windows.Forms.Label();
            this.txtLeaves = new System.Windows.Forms.TextBox();
            this.dtpJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.btnJobSubmit = new System.Windows.Forms.Button();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.grpPersonal.SuspendLayout();
            this.grpContact.SuspendLayout();
            this.grpQualification.SuspendLayout();
            this.grpJobDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboId
            // 
            this.cboId.BackColor = System.Drawing.Color.White;
            this.cboId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboId.FormattingEnabled = true;
            this.cboId.Location = new System.Drawing.Point(365, 33);
            this.cboId.Name = "cboId";
            this.cboId.Size = new System.Drawing.Size(111, 21);
            this.cboId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(194, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECTIONNER EMPLOYEE ID";
            // 
            // btnPersonalView
            // 
            this.btnPersonalView.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonalView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonalView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPersonalView.Location = new System.Drawing.Point(12, 93);
            this.btnPersonalView.Name = "btnPersonalView";
            this.btnPersonalView.Size = new System.Drawing.Size(99, 53);
            this.btnPersonalView.TabIndex = 2;
            this.btnPersonalView.Text = "DETAIL PERSONNEL";
            this.btnPersonalView.UseVisualStyleBackColor = false;
            this.btnPersonalView.Click += new System.EventHandler(this.btnPersonalView_Click1);
            // 
            // grpPersonal
            // 
            this.grpPersonal.BackColor = System.Drawing.Color.Transparent;
            this.grpPersonal.Controls.Add(this.cboBloodGroup);
            this.grpPersonal.Controls.Add(this.txtReligion);
            this.grpPersonal.Controls.Add(this.txtNatioanlity);
            this.grpPersonal.Controls.Add(this.dtpDOB);
            this.grpPersonal.Controls.Add(this.txtPanno);
            this.grpPersonal.Controls.Add(this.cboGender);
            this.grpPersonal.Controls.Add(this.txtEmpname);
            this.grpPersonal.Controls.Add(this.txtEmpid);
            this.grpPersonal.Controls.Add(this.lblReligion);
            this.grpPersonal.Controls.Add(this.btnPersonalSave);
            this.grpPersonal.Controls.Add(this.label8);
            this.grpPersonal.Controls.Add(this.label6);
            this.grpPersonal.Controls.Add(this.label5);
            this.grpPersonal.Controls.Add(this.label4);
            this.grpPersonal.Controls.Add(this.label3);
            this.grpPersonal.Controls.Add(this.label2);
            this.grpPersonal.Controls.Add(this.label7);
            this.grpPersonal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpPersonal.Location = new System.Drawing.Point(127, 73);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Size = new System.Drawing.Size(729, 360);
            this.grpPersonal.TabIndex = 4;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Details Personnel";
            this.grpPersonal.Visible = false;
            // 
            // cboBloodGroup
            // 
            this.cboBloodGroup.FormattingEnabled = true;
            this.cboBloodGroup.Items.AddRange(new object[] {
            "A+",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.cboBloodGroup.Location = new System.Drawing.Point(331, 273);
            this.cboBloodGroup.Name = "cboBloodGroup";
            this.cboBloodGroup.Size = new System.Drawing.Size(261, 21);
            this.cboBloodGroup.TabIndex = 6;
            // 
            // txtReligion
            // 
            this.txtReligion.Location = new System.Drawing.Point(331, 212);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(261, 20);
            this.txtReligion.TabIndex = 5;
            // 
            // txtNatioanlity
            // 
            this.txtNatioanlity.Location = new System.Drawing.Point(331, 134);
            this.txtNatioanlity.Name = "txtNatioanlity";
            this.txtNatioanlity.Size = new System.Drawing.Size(261, 20);
            this.txtNatioanlity.TabIndex = 4;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(331, 57);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(261, 20);
            this.dtpDOB.TabIndex = 3;
            // 
            // txtPanno
            // 
            this.txtPanno.Location = new System.Drawing.Point(19, 273);
            this.txtPanno.Name = "txtPanno";
            this.txtPanno.Size = new System.Drawing.Size(261, 20);
            this.txtPanno.TabIndex = 2;
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cboGender.Location = new System.Drawing.Point(19, 204);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(261, 21);
            this.cboGender.TabIndex = 1;
            // 
            // txtEmpname
            // 
            this.txtEmpname.Location = new System.Drawing.Point(19, 133);
            this.txtEmpname.Name = "txtEmpname";
            this.txtEmpname.Size = new System.Drawing.Size(261, 20);
            this.txtEmpname.TabIndex = 0;
            // 
            // txtEmpid
            // 
            this.txtEmpid.Location = new System.Drawing.Point(19, 57);
            this.txtEmpid.Name = "txtEmpid";
            this.txtEmpid.ReadOnly = true;
            this.txtEmpid.Size = new System.Drawing.Size(261, 20);
            this.txtEmpid.TabIndex = 47;
            this.txtEmpid.TabStop = false;
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReligion.Location = new System.Drawing.Point(328, 173);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(68, 17);
            this.lblReligion.TabIndex = 46;
            this.lblReligion.Text = "Religion";
            // 
            // btnPersonalSave
            // 
            this.btnPersonalSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPersonalSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonalSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPersonalSave.Location = new System.Drawing.Point(608, 311);
            this.btnPersonalSave.Name = "btnPersonalSave";
            this.btnPersonalSave.Size = new System.Drawing.Size(115, 43);
            this.btnPersonalSave.TabIndex = 10;
            this.btnPersonalSave.Text = "MODIFIER";
            this.btnPersonalSave.UseVisualStyleBackColor = true;
            this.btnPersonalSave.Click += new System.EventHandler(this.btnPersonalSave_Click1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(328, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Group Sanguin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(328, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nationalite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Complet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Employee ID";
            // 
            // grpContact
            // 
            this.grpContact.BackColor = System.Drawing.Color.Transparent;
            this.grpContact.Controls.Add(this.btnContactSubmit);
            this.grpContact.Controls.Add(this.txtEmail);
            this.grpContact.Controls.Add(this.label10);
            this.grpContact.Controls.Add(this.lblContactNo);
            this.grpContact.Controls.Add(this.txtContactNo);
            this.grpContact.Controls.Add(this.lblZipCode1);
            this.grpContact.Controls.Add(this.txtZipCode);
            this.grpContact.Controls.Add(this.lblState);
            this.grpContact.Controls.Add(this.txtState);
            this.grpContact.Controls.Add(this.label9);
            this.grpContact.Controls.Add(this.txtCity);
            this.grpContact.Controls.Add(this.lblAddress1);
            this.grpContact.Controls.Add(this.txtAddress);
            this.grpContact.Controls.Add(this.txtEmpIdContct);
            this.grpContact.Controls.Add(this.label11);
            this.grpContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpContact.Location = new System.Drawing.Point(127, 66);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(729, 368);
            this.grpContact.TabIndex = 50;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Details Contact";
            this.grpContact.Visible = false;
            // 
            // btnContactSubmit
            // 
            this.btnContactSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContactSubmit.Location = new System.Drawing.Point(626, 325);
            this.btnContactSubmit.Name = "btnContactSubmit";
            this.btnContactSubmit.Size = new System.Drawing.Size(97, 36);
            this.btnContactSubmit.TabIndex = 7;
            this.btnContactSubmit.Text = "MODIFIER";
            this.btnContactSubmit.UseVisualStyleBackColor = true;
            this.btnContactSubmit.Click += new System.EventHandler(this.btnContactSubmit_Click1);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(37, 296);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(34, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 73;
            this.label10.Text = "Email";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContactNo.Location = new System.Drawing.Point(328, 222);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(87, 17);
            this.lblContactNo.TabIndex = 72;
            this.lblContactNo.Text = "Contact No";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(331, 263);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(180, 20);
            this.txtContactNo.TabIndex = 5;
            // 
            // lblZipCode1
            // 
            this.lblZipCode1.AutoSize = true;
            this.lblZipCode1.BackColor = System.Drawing.Color.Transparent;
            this.lblZipCode1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblZipCode1.Location = new System.Drawing.Point(328, 143);
            this.lblZipCode1.Name = "lblZipCode1";
            this.lblZipCode1.Size = new System.Drawing.Size(102, 17);
            this.lblZipCode1.TabIndex = 70;
            this.lblZipCode1.Text = "Code Postale";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(331, 180);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(185, 20);
            this.txtZipCode.TabIndex = 4;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblState.Location = new System.Drawing.Point(34, 180);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(58, 17);
            this.lblState.TabIndex = 66;
            this.lblState.Text = "Region";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(37, 219);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(180, 20);
            this.txtState.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(34, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 64;
            this.label9.Text = "Ville";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(37, 141);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(180, 20);
            this.txtCity.TabIndex = 2;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddress1.Location = new System.Drawing.Point(331, 37);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(65, 17);
            this.lblAddress1.TabIndex = 62;
            this.lblAddress1.Text = "Adresse";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(331, 67);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(180, 43);
            this.txtAddress.TabIndex = 1;
            // 
            // txtEmpIdContct
            // 
            this.txtEmpIdContct.Location = new System.Drawing.Point(37, 67);
            this.txtEmpIdContct.Name = "txtEmpIdContct";
            this.txtEmpIdContct.ReadOnly = true;
            this.txtEmpIdContct.Size = new System.Drawing.Size(180, 20);
            this.txtEmpIdContct.TabIndex = 0;
            this.txtEmpIdContct.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(34, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Employee ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 53);
            this.button1.TabIndex = 51;
            this.button1.Text = "DETAIL CONTACT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click1);
            // 
            // grpQualification
            // 
            this.grpQualification.BackColor = System.Drawing.Color.Transparent;
            this.grpQualification.Controls.Add(this.btnQualificationSubmit);
            this.grpQualification.Controls.Add(this.lblPercentage);
            this.grpQualification.Controls.Add(this.txtPercentage);
            this.grpQualification.Controls.Add(this.txtIdQualication);
            this.grpQualification.Controls.Add(this.label12);
            this.grpQualification.Controls.Add(this.lblPassingYear);
            this.grpQualification.Controls.Add(this.txtPassingYear);
            this.grpQualification.Controls.Add(this.lblUniversity);
            this.grpQualification.Controls.Add(this.txtUniversity);
            this.grpQualification.Controls.Add(this.lblDegree);
            this.grpQualification.Controls.Add(this.txtDegree);
            this.grpQualification.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpQualification.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQualification.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpQualification.Location = new System.Drawing.Point(127, 65);
            this.grpQualification.Name = "grpQualification";
            this.grpQualification.Size = new System.Drawing.Size(729, 368);
            this.grpQualification.TabIndex = 82;
            this.grpQualification.TabStop = false;
            this.grpQualification.Text = "Details Qualification";
            this.grpQualification.Visible = false;
            // 
            // btnQualificationSubmit
            // 
            this.btnQualificationSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnQualificationSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQualificationSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQualificationSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQualificationSubmit.Location = new System.Drawing.Point(613, 324);
            this.btnQualificationSubmit.Name = "btnQualificationSubmit";
            this.btnQualificationSubmit.Size = new System.Drawing.Size(110, 37);
            this.btnQualificationSubmit.TabIndex = 5;
            this.btnQualificationSubmit.Text = "MODIFIER";
            this.btnQualificationSubmit.UseVisualStyleBackColor = false;
            this.btnQualificationSubmit.Click += new System.EventHandler(this.btnQualificationSubmit_Click1);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPercentage.Location = new System.Drawing.Point(34, 235);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(127, 17);
            this.lblPercentage.TabIndex = 58;
            this.lblPercentage.Text = "Marque Diplome";
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(37, 275);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(203, 23);
            this.txtPercentage.TabIndex = 4;
            // 
            // txtIdQualication
            // 
            this.txtIdQualication.Location = new System.Drawing.Point(37, 85);
            this.txtIdQualication.Name = "txtIdQualication";
            this.txtIdQualication.ReadOnly = true;
            this.txtIdQualication.Size = new System.Drawing.Size(203, 23);
            this.txtIdQualication.TabIndex = 0;
            this.txtIdQualication.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(37, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 48;
            this.label12.Text = "Employee ID";
            // 
            // lblPassingYear
            // 
            this.lblPassingYear.AutoSize = true;
            this.lblPassingYear.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassingYear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassingYear.Location = new System.Drawing.Point(282, 200);
            this.lblPassingYear.Name = "lblPassingYear";
            this.lblPassingYear.Size = new System.Drawing.Size(115, 17);
            this.lblPassingYear.TabIndex = 42;
            this.lblPassingYear.Text = "Annee Passage";
            // 
            // txtPassingYear
            // 
            this.txtPassingYear.Location = new System.Drawing.Point(282, 232);
            this.txtPassingYear.Name = "txtPassingYear";
            this.txtPassingYear.Size = new System.Drawing.Size(203, 23);
            this.txtPassingYear.TabIndex = 3;
            // 
            // lblUniversity
            // 
            this.lblUniversity.AutoSize = true;
            this.lblUniversity.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniversity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUniversity.Location = new System.Drawing.Point(34, 140);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size = new System.Drawing.Size(81, 17);
            this.lblUniversity.TabIndex = 40;
            this.lblUniversity.Text = "Universite";
            // 
            // txtUniversity
            // 
            this.txtUniversity.Location = new System.Drawing.Point(37, 177);
            this.txtUniversity.Name = "txtUniversity";
            this.txtUniversity.Size = new System.Drawing.Size(203, 23);
            this.txtUniversity.TabIndex = 2;
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDegree.Location = new System.Drawing.Point(282, 116);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(69, 17);
            this.lblDegree.TabIndex = 38;
            this.lblDegree.Text = "Diplome";
            // 
            // txtDegree
            // 
            this.txtDegree.Location = new System.Drawing.Point(282, 153);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(203, 23);
            this.txtDegree.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 53);
            this.button2.TabIndex = 83;
            this.button2.Text = "DETAIL QUALIFICATION";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click1);
            // 
            // grpJobDetails
            // 
            this.grpJobDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpJobDetails.Controls.Add(this.txtBasicSalary);
            this.grpJobDetails.Controls.Add(this.label13);
            this.grpJobDetails.Controls.Add(this.txtEmpIdJob);
            this.grpJobDetails.Controls.Add(this.label14);
            this.grpJobDetails.Controls.Add(this.lblAllocatedLeaves);
            this.grpJobDetails.Controls.Add(this.txtLeaves);
            this.grpJobDetails.Controls.Add(this.dtpJoiningDate);
            this.grpJobDetails.Controls.Add(this.btnJobSubmit);
            this.grpJobDetails.Controls.Add(this.lblDesignation);
            this.grpJobDetails.Controls.Add(this.txtDesignation);
            this.grpJobDetails.Controls.Add(this.lblDepartment);
            this.grpJobDetails.Controls.Add(this.txtDepartment);
            this.grpJobDetails.Controls.Add(this.lblJoiningDate);
            this.grpJobDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpJobDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpJobDetails.Location = new System.Drawing.Point(127, 66);
            this.grpJobDetails.Name = "grpJobDetails";
            this.grpJobDetails.Size = new System.Drawing.Size(729, 368);
            this.grpJobDetails.TabIndex = 84;
            this.grpJobDetails.TabStop = false;
            this.grpJobDetails.Text = "Details Travail";
            this.grpJobDetails.Visible = false;
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Location = new System.Drawing.Point(308, 263);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(203, 22);
            this.txtBasicSalary.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(305, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 73;
            this.label13.Text = "Salaire Base";
            // 
            // txtEmpIdJob
            // 
            this.txtEmpIdJob.Location = new System.Drawing.Point(22, 75);
            this.txtEmpIdJob.Name = "txtEmpIdJob";
            this.txtEmpIdJob.ReadOnly = true;
            this.txtEmpIdJob.Size = new System.Drawing.Size(205, 22);
            this.txtEmpIdJob.TabIndex = 0;
            this.txtEmpIdJob.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(19, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 17);
            this.label14.TabIndex = 71;
            this.label14.Text = "Employee ID";
            // 
            // lblAllocatedLeaves
            // 
            this.lblAllocatedLeaves.AutoSize = true;
            this.lblAllocatedLeaves.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllocatedLeaves.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAllocatedLeaves.Location = new System.Drawing.Point(305, 121);
            this.lblAllocatedLeaves.Name = "lblAllocatedLeaves";
            this.lblAllocatedLeaves.Size = new System.Drawing.Size(88, 17);
            this.lblAllocatedLeaves.TabIndex = 70;
            this.lblAllocatedLeaves.Text = "Jour Congé";
            // 
            // txtLeaves
            // 
            this.txtLeaves.Location = new System.Drawing.Point(308, 166);
            this.txtLeaves.Name = "txtLeaves";
            this.txtLeaves.Size = new System.Drawing.Size(203, 22);
            this.txtLeaves.TabIndex = 3;
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.CustomFormat = "dd/MM/yyyy";
            this.dtpJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoiningDate.Location = new System.Drawing.Point(19, 166);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.Size = new System.Drawing.Size(208, 22);
            this.dtpJoiningDate.TabIndex = 2;
            // 
            // btnJobSubmit
            // 
            this.btnJobSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJobSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobSubmit.Location = new System.Drawing.Point(633, 325);
            this.btnJobSubmit.Name = "btnJobSubmit";
            this.btnJobSubmit.Size = new System.Drawing.Size(90, 37);
            this.btnJobSubmit.TabIndex = 67;
            this.btnJobSubmit.Text = "MODIFIER";
            this.btnJobSubmit.UseVisualStyleBackColor = true;
            this.btnJobSubmit.Click += new System.EventHandler(this.btnJobSubmit_Click1);
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDesignation.Location = new System.Drawing.Point(305, 44);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(94, 17);
            this.lblDesignation.TabIndex = 66;
            this.lblDesignation.Text = "Designation";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(308, 75);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(203, 22);
            this.txtDesignation.TabIndex = 1;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartment.Location = new System.Drawing.Point(19, 222);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(101, 17);
            this.lblDepartment.TabIndex = 64;
            this.lblDepartment.Text = "Departement";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(19, 263);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(208, 22);
            this.txtDepartment.TabIndex = 4;
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.AutoSize = true;
            this.lblJoiningDate.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoiningDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblJoiningDate.Location = new System.Drawing.Point(16, 125);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(95, 17);
            this.lblJoiningDate.TabIndex = 62;
            this.lblJoiningDate.Text = "Date d\'entre";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(12, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 53);
            this.button3.TabIndex = 85;
            this.button3.Text = "DETAIL TRAVAIL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click1);
            // 
            // frmModifEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 435);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.grpJobDetails);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grpQualification);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.btnPersonalView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboId);
            this.Name = "frmModifEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifier Employee";
            this.Load += new System.EventHandler(this.frmModifEmp_Load);
            this.grpPersonal.ResumeLayout(false);
            this.grpPersonal.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            this.grpQualification.ResumeLayout(false);
            this.grpQualification.PerformLayout();
            this.grpJobDetails.ResumeLayout(false);
            this.grpJobDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

            #endregion
        private System.Windows.Forms.ComboBox cboId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPersonalView;
        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.ComboBox cboBloodGroup;
        private System.Windows.Forms.TextBox txtReligion;
        private System.Windows.Forms.TextBox txtNatioanlity;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtPanno;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtEmpname;
        private System.Windows.Forms.TextBox txtEmpid;
        private System.Windows.Forms.Label lblReligion;
        private System.Windows.Forms.Button btnPersonalSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.Button btnContactSubmit;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label lblZipCode1;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmpIdContct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpQualification;
        private System.Windows.Forms.Button btnQualificationSubmit;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.TextBox txtIdQualication;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPassingYear;
        private System.Windows.Forms.TextBox txtPassingYear;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.TextBox txtUniversity;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpJobDetails;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmpIdJob;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblAllocatedLeaves;
        private System.Windows.Forms.TextBox txtLeaves;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.Button btnJobSubmit;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.Button button3;

     
    }
}