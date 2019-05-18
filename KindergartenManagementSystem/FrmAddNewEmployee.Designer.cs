namespace KindergartenManagementSystem
{
    partial class FrmAddNewEmployee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddNewEmployee));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblhomenum = new System.Windows.Forms.Label();
            this.txtboxhomenum = new System.Windows.Forms.TextBox();
            this.lblmobile = new System.Windows.Forms.Label();
            this.txtboxmobilenum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxsocialins = new System.Windows.Forms.TextBox();
            this.lblidnumber = new System.Windows.Forms.Label();
            this.txtboxid = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtboxfirstname = new System.Windows.Forms.TextBox();
            this.txtboxlastname = new System.Windows.Forms.TextBox();
            this.txtboxaddress = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbboxsex = new System.Windows.Forms.ComboBox();
            this.txtboxnationality = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbclass = new System.Windows.Forms.ComboBox();
            this.dBClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_KindergartenDataClasses = new KindergartenManagementSystem.DB_KindergartenDataClasses();
            this.txtboxsalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.dBKindergartenDataClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_ClassesTableAdapter = new KindergartenManagementSystem.DB_KindergartenDataClassesTableAdapters.DB_ClassesTableAdapter();
            this.lblerror = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBClassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KindergartenDataClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBKindergartenDataClassesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblhomenum);
            this.groupBox1.Controls.Add(this.txtboxhomenum);
            this.groupBox1.Controls.Add(this.lblmobile);
            this.groupBox1.Controls.Add(this.txtboxmobilenum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtboxsocialins);
            this.groupBox1.Controls.Add(this.lblidnumber);
            this.groupBox1.Controls.Add(this.txtboxid);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtboxfirstname);
            this.groupBox1.Controls.Add(this.txtboxlastname);
            this.groupBox1.Controls.Add(this.txtboxaddress);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbboxsex);
            this.groupBox1.Controls.Add(this.txtboxnationality);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 282);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // lblhomenum
            // 
            this.lblhomenum.AutoSize = true;
            this.lblhomenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhomenum.ForeColor = System.Drawing.Color.Black;
            this.lblhomenum.Location = new System.Drawing.Point(4, 255);
            this.lblhomenum.Name = "lblhomenum";
            this.lblhomenum.Size = new System.Drawing.Size(68, 16);
            this.lblhomenum.TabIndex = 67;
            this.lblhomenum.Text = "Home Tel";
            // 
            // txtboxhomenum
            // 
            this.txtboxhomenum.Location = new System.Drawing.Point(84, 254);
            this.txtboxhomenum.Name = "txtboxhomenum";
            this.txtboxhomenum.Size = new System.Drawing.Size(208, 20);
            this.txtboxhomenum.TabIndex = 9;
            // 
            // lblmobile
            // 
            this.lblmobile.AutoSize = true;
            this.lblmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmobile.ForeColor = System.Drawing.Color.Black;
            this.lblmobile.Location = new System.Drawing.Point(4, 229);
            this.lblmobile.Name = "lblmobile";
            this.lblmobile.Size = new System.Drawing.Size(69, 16);
            this.lblmobile.TabIndex = 65;
            this.lblmobile.Text = "MobileTel";
            // 
            // txtboxmobilenum
            // 
            this.txtboxmobilenum.Location = new System.Drawing.Point(84, 228);
            this.txtboxmobilenum.Name = "txtboxmobilenum";
            this.txtboxmobilenum.Size = new System.Drawing.Size(208, 20);
            this.txtboxmobilenum.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 63;
            this.label6.Text = "Social Ins";
            // 
            // txtboxsocialins
            // 
            this.txtboxsocialins.Location = new System.Drawing.Point(84, 203);
            this.txtboxsocialins.Name = "txtboxsocialins";
            this.txtboxsocialins.Size = new System.Drawing.Size(208, 20);
            this.txtboxsocialins.TabIndex = 7;
            // 
            // lblidnumber
            // 
            this.lblidnumber.AutoSize = true;
            this.lblidnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidnumber.ForeColor = System.Drawing.Color.Black;
            this.lblidnumber.Location = new System.Drawing.Point(4, 178);
            this.lblidnumber.Name = "lblidnumber";
            this.lblidnumber.Size = new System.Drawing.Size(72, 16);
            this.lblidnumber.TabIndex = 61;
            this.lblidnumber.Text = "ID Number";
            // 
            // txtboxid
            // 
            this.txtboxid.Location = new System.Drawing.Point(84, 177);
            this.txtboxid.Name = "txtboxid";
            this.txtboxid.Size = new System.Drawing.Size(208, 20);
            this.txtboxid.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // txtboxfirstname
            // 
            this.txtboxfirstname.Location = new System.Drawing.Point(84, 15);
            this.txtboxfirstname.Name = "txtboxfirstname";
            this.txtboxfirstname.Size = new System.Drawing.Size(208, 20);
            this.txtboxfirstname.TabIndex = 0;
            // 
            // txtboxlastname
            // 
            this.txtboxlastname.Location = new System.Drawing.Point(84, 41);
            this.txtboxlastname.Name = "txtboxlastname";
            this.txtboxlastname.Size = new System.Drawing.Size(208, 20);
            this.txtboxlastname.TabIndex = 1;
            // 
            // txtboxaddress
            // 
            this.txtboxaddress.Location = new System.Drawing.Point(84, 149);
            this.txtboxaddress.Name = "txtboxaddress";
            this.txtboxaddress.Size = new System.Drawing.Size(208, 20);
            this.txtboxaddress.TabIndex = 5;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Black;
            this.lblname.Location = new System.Drawing.Point(11, 19);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(67, 16);
            this.lblname.TabIndex = 47;
            this.lblname.Text = "Firstname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Lastname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Nationality";
            // 
            // cmbboxsex
            // 
            this.cmbboxsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxsex.FormattingEnabled = true;
            this.cmbboxsex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbboxsex.Location = new System.Drawing.Point(84, 67);
            this.cmbboxsex.Name = "cmbboxsex";
            this.cmbboxsex.Size = new System.Drawing.Size(208, 21);
            this.cmbboxsex.TabIndex = 2;
            // 
            // txtboxnationality
            // 
            this.txtboxnationality.Location = new System.Drawing.Point(84, 121);
            this.txtboxnationality.Name = "txtboxnationality";
            this.txtboxnationality.Size = new System.Drawing.Size(208, 20);
            this.txtboxnationality.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(41, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Sex";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbclass);
            this.groupBox2.Controls.Add(this.txtboxsalary);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(0, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 93);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Job Details";
            // 
            // cmbclass
            // 
            this.cmbclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbclass.FormattingEnabled = true;
            this.cmbclass.Items.AddRange(new object[] {
            "Teacher",
            "Assistant",
            "Manager",
            "Cleaner",
            "Bus Driver"});
            this.cmbclass.Location = new System.Drawing.Point(310, 63);
            this.cmbclass.Name = "cmbclass";
            this.cmbclass.Size = new System.Drawing.Size(142, 21);
            this.cmbclass.TabIndex = 11;
            // 
            // dBClassesBindingSource
            // 
            this.dBClassesBindingSource.DataMember = "DB_Classes";
            this.dBClassesBindingSource.DataSource = this.dB_KindergartenDataClasses;
            // 
            // dB_KindergartenDataClasses
            // 
            this.dB_KindergartenDataClasses.DataSetName = "DB_KindergartenDataClasses";
            this.dB_KindergartenDataClasses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtboxsalary
            // 
            this.txtboxsalary.Location = new System.Drawing.Point(310, 30);
            this.txtboxsalary.Name = "txtboxsalary";
            this.txtboxsalary.Size = new System.Drawing.Size(142, 20);
            this.txtboxsalary.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(190, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 69;
            this.label7.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(190, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 70;
            this.label8.Text = "Assigned Job";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(219, 417);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(184, 22);
            this.btnsave.TabIndex = 66;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dBKindergartenDataClassesBindingSource
            // 
            this.dBKindergartenDataClassesBindingSource.DataSource = this.dB_KindergartenDataClasses;
            this.dBKindergartenDataClassesBindingSource.Position = 0;
            // 
            // dB_ClassesTableAdapter
            // 
            this.dB_ClassesTableAdapter.ClearBeforeFill = true;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(216, 387);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 67;
            // 
            // FrmAddNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 443);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddNewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add or Edit Employee";
            this.Load += new System.EventHandler(this.FrmAddNewEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBClassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KindergartenDataClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBKindergartenDataClassesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblhomenum;
        private System.Windows.Forms.TextBox txtboxhomenum;
        private System.Windows.Forms.Label lblmobile;
        private System.Windows.Forms.TextBox txtboxmobilenum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxsocialins;
        private System.Windows.Forms.Label lblidnumber;
        private System.Windows.Forms.TextBox txtboxid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtboxfirstname;
        private System.Windows.Forms.TextBox txtboxlastname;
        private System.Windows.Forms.TextBox txtboxaddress;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbboxsex;
        private System.Windows.Forms.TextBox txtboxnationality;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtboxsalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox cmbclass;
        private System.Windows.Forms.BindingSource dBKindergartenDataClassesBindingSource;
        private DB_KindergartenDataClasses dB_KindergartenDataClasses;
        private System.Windows.Forms.BindingSource dBClassesBindingSource;
        private DB_KindergartenDataClassesTableAdapters.DB_ClassesTableAdapter dB_ClassesTableAdapter;
        private System.Windows.Forms.Label lblerror;
    }
}