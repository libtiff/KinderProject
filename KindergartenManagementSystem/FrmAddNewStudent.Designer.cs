namespace KindergartenManagementSystem
{
    partial class FrmAddNewStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddNewStudent));
            this.txtboxfirstname = new System.Windows.Forms.TextBox();
            this.txtboxlastname = new System.Windows.Forms.TextBox();
            this.txtboxaddress = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxnationality = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbboxsex = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxmothername = new System.Windows.Forms.TextBox();
            this.txtboxfathername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtboxmothertelnum = new System.Windows.Forms.TextBox();
            this.txtboxfathertelnum = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtboxhometelnum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtboxtotalcost = new System.Windows.Forms.TextBox();
            this.chkboxlunch = new System.Windows.Forms.CheckBox();
            this.chkboxbus = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbboxclass = new System.Windows.Forms.ComboBox();
            this.dBClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBKindergartenDataClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_KindergartenDataClasses = new KindergartenManagementSystem.DB_KindergartenDataClasses();
            this.btnregister = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dB_ClassesTableAdapter = new KindergartenManagementSystem.DB_KindergartenDataClassesTableAdapters.DB_ClassesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBClassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBKindergartenDataClassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KindergartenDataClasses)).BeginInit();
            this.SuspendLayout();
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
            this.txtboxaddress.Location = new System.Drawing.Point(84, 67);
            this.txtboxaddress.Name = "txtboxaddress";
            this.txtboxaddress.Size = new System.Drawing.Size(208, 20);
            this.txtboxaddress.TabIndex = 2;
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
            this.label2.Location = new System.Drawing.Point(4, 151);
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
            this.label3.Location = new System.Drawing.Point(13, 68);
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
            this.label4.Location = new System.Drawing.Point(4, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Nationality";
            // 
            // txtboxnationality
            // 
            this.txtboxnationality.Location = new System.Drawing.Point(84, 93);
            this.txtboxnationality.Name = "txtboxnationality";
            this.txtboxnationality.Size = new System.Drawing.Size(208, 20);
            this.txtboxnationality.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(41, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Sex";
            // 
            // cmbboxsex
            // 
            this.cmbboxsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxsex.FormattingEnabled = true;
            this.cmbboxsex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbboxsex.Location = new System.Drawing.Point(84, 119);
            this.cmbboxsex.Name = "cmbboxsex";
            this.cmbboxsex.Size = new System.Drawing.Size(208, 21);
            this.cmbboxsex.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Mother Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(297, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Father Name";
            // 
            // txtboxmothername
            // 
            this.txtboxmothername.Location = new System.Drawing.Point(125, 29);
            this.txtboxmothername.Name = "txtboxmothername";
            this.txtboxmothername.Size = new System.Drawing.Size(162, 20);
            this.txtboxmothername.TabIndex = 6;
            // 
            // txtboxfathername
            // 
            this.txtboxfathername.Location = new System.Drawing.Point(412, 29);
            this.txtboxfathername.Name = "txtboxfathername";
            this.txtboxfathername.Size = new System.Drawing.Size(170, 20);
            this.txtboxfathername.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 16);
            this.label8.TabIndex = 59;
            this.label8.Text = "Mother Telephone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(297, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "Father Telephone";
            // 
            // txtboxmothertelnum
            // 
            this.txtboxmothertelnum.Location = new System.Drawing.Point(125, 64);
            this.txtboxmothertelnum.Name = "txtboxmothertelnum";
            this.txtboxmothertelnum.Size = new System.Drawing.Size(162, 20);
            this.txtboxmothertelnum.TabIndex = 7;
            // 
            // txtboxfathertelnum
            // 
            this.txtboxfathertelnum.Location = new System.Drawing.Point(412, 64);
            this.txtboxfathertelnum.Name = "txtboxfathertelnum";
            this.txtboxfathertelnum.Size = new System.Drawing.Size(170, 20);
            this.txtboxfathertelnum.TabIndex = 10;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(1, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 196);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtboxhometelnum);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtboxmothername);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtboxfathertelnum);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtboxmothertelnum);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtboxfathername);
            this.groupBox2.Location = new System.Drawing.Point(1, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 134);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parent Information";
            // 
            // txtboxhometelnum
            // 
            this.txtboxhometelnum.Location = new System.Drawing.Point(125, 96);
            this.txtboxhometelnum.Name = "txtboxhometelnum";
            this.txtboxhometelnum.Size = new System.Drawing.Size(162, 20);
            this.txtboxhometelnum.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 16);
            this.label10.TabIndex = 63;
            this.label10.Text = "Home Telephone";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblerror);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtboxtotalcost);
            this.groupBox3.Controls.Add(this.chkboxlunch);
            this.groupBox3.Controls.Add(this.chkboxbus);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cmbboxclass);
            this.groupBox3.Location = new System.Drawing.Point(1, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(592, 114);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fee Estimation";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(178, 117);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 16);
            this.lblerror.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(232, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 16);
            this.label12.TabIndex = 66;
            this.label12.Text = "Total Cost Estimation";
            // 
            // txtboxtotalcost
            // 
            this.txtboxtotalcost.Enabled = false;
            this.txtboxtotalcost.Location = new System.Drawing.Point(217, 88);
            this.txtboxtotalcost.Name = "txtboxtotalcost";
            this.txtboxtotalcost.Size = new System.Drawing.Size(149, 20);
            this.txtboxtotalcost.TabIndex = 65;
            // 
            // chkboxlunch
            // 
            this.chkboxlunch.AutoSize = true;
            this.chkboxlunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxlunch.Location = new System.Drawing.Point(394, 19);
            this.chkboxlunch.Name = "chkboxlunch";
            this.chkboxlunch.Size = new System.Drawing.Size(192, 20);
            this.chkboxlunch.TabIndex = 12;
            this.chkboxlunch.Text = "Sudent will use school lunch";
            this.chkboxlunch.UseVisualStyleBackColor = true;
            this.chkboxlunch.CheckedChanged += new System.EventHandler(this.chkboxlunch_CheckedChanged);
            // 
            // chkboxbus
            // 
            this.chkboxbus.AutoSize = true;
            this.chkboxbus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxbus.Location = new System.Drawing.Point(394, 45);
            this.chkboxbus.Name = "chkboxbus";
            this.chkboxbus.Size = new System.Drawing.Size(183, 20);
            this.chkboxbus.TabIndex = 13;
            this.chkboxbus.Text = "Sudent will use school bus";
            this.chkboxbus.UseVisualStyleBackColor = true;
            this.chkboxbus.CheckedChanged += new System.EventHandler(this.chkboxbus_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(2, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 16);
            this.label11.TabIndex = 55;
            this.label11.Text = "Class Registration";
            // 
            // cmbboxclass
            // 
            this.cmbboxclass.DataSource = this.dBClassesBindingSource;
            this.cmbboxclass.DisplayMember = "ClassName";
            this.cmbboxclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxclass.FormattingEnabled = true;
            this.cmbboxclass.Location = new System.Drawing.Point(125, 28);
            this.cmbboxclass.Name = "cmbboxclass";
            this.cmbboxclass.Size = new System.Drawing.Size(162, 21);
            this.cmbboxclass.TabIndex = 11;
            this.cmbboxclass.ValueMember = "ClassName";
            this.cmbboxclass.SelectedIndexChanged += new System.EventHandler(this.cmbboxclass_SelectedIndexChanged);
            // 
            // dBClassesBindingSource
            // 
            this.dBClassesBindingSource.DataMember = "DB_Classes";
            this.dBClassesBindingSource.DataSource = this.dBKindergartenDataClassesBindingSource;
            // 
            // dBKindergartenDataClassesBindingSource
            // 
            this.dBKindergartenDataClassesBindingSource.DataSource = this.dB_KindergartenDataClasses;
            this.dBKindergartenDataClassesBindingSource.Position = 0;
            // 
            // dB_KindergartenDataClasses
            // 
            this.dB_KindergartenDataClasses.DataSetName = "DB_KindergartenDataClasses";
            this.dB_KindergartenDataClasses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(182, 488);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(251, 23);
            this.btnregister.TabIndex = 14;
            this.btnregister.Text = "Save Record";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dB_ClassesTableAdapter
            // 
            this.dB_ClassesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 514);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddNewStudent";
            this.Text = "Add or Edit Student";
            this.Load += new System.EventHandler(this.FrmAddNewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBClassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBKindergartenDataClassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KindergartenDataClasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxfirstname;
        private System.Windows.Forms.TextBox txtboxlastname;
        private System.Windows.Forms.TextBox txtboxaddress;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxnationality;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbboxsex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxmothername;
        private System.Windows.Forms.TextBox txtboxfathername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtboxmothertelnum;
        private System.Windows.Forms.TextBox txtboxfathertelnum;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtboxtotalcost;
        private System.Windows.Forms.CheckBox chkboxlunch;
        private System.Windows.Forms.CheckBox chkboxbus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbboxclass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtboxhometelnum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DB_KindergartenDataClasses dB_KindergartenDataClasses;
        private DB_KindergartenDataClassesTableAdapters.DB_ClassesTableAdapter dB_ClassesTableAdapter;
        private System.Windows.Forms.BindingSource dBClassesBindingSource;
        private System.Windows.Forms.BindingSource dBKindergartenDataClassesBindingSource;
    }
}