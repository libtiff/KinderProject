using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KindergartenManagementSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblstudents = new System.Windows.Forms.Label();
            this.Paneltopcontrols = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnFinancial = new System.Windows.Forms.Button();
            this.btnClasses = new System.Windows.Forms.Button();
            this.btncredits = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelads = new System.Windows.Forms.Panel();
            this.lbltotalstudents = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltotalemployees = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltotalbususers = new System.Windows.Forms.Label();
            this.lbltotallunchusers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbltotalmanagers = new System.Windows.Forms.Label();
            this.lbltotalbusdrivers = new System.Windows.Forms.Label();
            this.lbltotalcleaners = new System.Windows.Forms.Label();
            this.lbltotalassistants = new System.Windows.Forms.Label();
            this.lbltotalteachers = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgboxvans = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbltotalclasses = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dB_KindergartenDataClasses1 = new KindergartenManagementSystem.DB_KindergartenDataClasses();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.Paneltopcontrols.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxvans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KindergartenDataClasses1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstudents
            // 
            this.lblstudents.AutoSize = true;
            this.lblstudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudents.ForeColor = System.Drawing.Color.Black;
            this.lblstudents.Location = new System.Drawing.Point(312, 179);
            this.lblstudents.Name = "lblstudents";
            this.lblstudents.Size = new System.Drawing.Size(125, 20);
            this.lblstudents.TabIndex = 24;
            this.lblstudents.Text = "  Total Students:";
            // 
            // Paneltopcontrols
            // 
            this.Paneltopcontrols.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Paneltopcontrols.Controls.Add(this.label1);
            this.Paneltopcontrols.Controls.Add(this.btnexit);
            this.Paneltopcontrols.Location = new System.Drawing.Point(199, -5);
            this.Paneltopcontrols.Name = "Paneltopcontrols";
            this.Paneltopcontrols.Size = new System.Drawing.Size(1259, 37);
            this.Paneltopcontrols.TabIndex = 20;
            this.Paneltopcontrols.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Paneltopcontrols_MouseDown);
            this.Paneltopcontrols.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Paneltopcontrols_MouseMove);
            this.Paneltopcontrols.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Paneltopcontrols_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kindergarten Management System | Project for Software Engineering 2019 | Cypriot " +
    "Programmers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Paneltopcontrols_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Paneltopcontrols_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Paneltopcontrols_MouseUp);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(1193, 4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(63, 39);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.btnPayments);
            this.panel1.Controls.Add(this.btnFinancial);
            this.panel1.Controls.Add(this.btnClasses);
            this.panel1.Controls.Add(this.btncredits);
            this.panel1.Controls.Add(this.btnEmployees);
            this.panel1.Controls.Add(this.btnStudents);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panelads);
            this.panel1.Location = new System.Drawing.Point(-4, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 637);
            this.panel1.TabIndex = 19;
            // 
            // btnPayments
            // 
            this.btnPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnPayments.Image = ((System.Drawing.Image)(resources.GetObject("btnPayments.Image")));
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPayments.Location = new System.Drawing.Point(11, 168);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(189, 62);
            this.btnPayments.TabIndex = 24;
            this.btnPayments.Text = "Monthly Payments";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPayments.UseMnemonic = false;
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnFinancial
            // 
            this.btnFinancial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFinancial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinancial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnFinancial.Image = ((System.Drawing.Image)(resources.GetObject("btnFinancial.Image")));
            this.btnFinancial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinancial.Location = new System.Drawing.Point(11, 372);
            this.btnFinancial.Name = "btnFinancial";
            this.btnFinancial.Size = new System.Drawing.Size(189, 62);
            this.btnFinancial.TabIndex = 23;
            this.btnFinancial.Text = "Financial";
            this.btnFinancial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinancial.UseMnemonic = false;
            this.btnFinancial.UseVisualStyleBackColor = true;
            this.btnFinancial.Click += new System.EventHandler(this.btnFinancial_Click);
            // 
            // btnClasses
            // 
            this.btnClasses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClasses.Image = ((System.Drawing.Image)(resources.GetObject("btnClasses.Image")));
            this.btnClasses.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClasses.Location = new System.Drawing.Point(11, 304);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Size = new System.Drawing.Size(189, 62);
            this.btnClasses.TabIndex = 22;
            this.btnClasses.Text = "Classes";
            this.btnClasses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClasses.UseMnemonic = false;
            this.btnClasses.UseVisualStyleBackColor = true;
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // btncredits
            // 
            this.btncredits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btncredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btncredits.Image = ((System.Drawing.Image)(resources.GetObject("btncredits.Image")));
            this.btncredits.Location = new System.Drawing.Point(11, 440);
            this.btncredits.Name = "btncredits";
            this.btncredits.Size = new System.Drawing.Size(189, 58);
            this.btncredits.TabIndex = 4;
            this.btncredits.Text = "About";
            this.btncredits.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncredits.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            this.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmployees.Location = new System.Drawing.Point(11, 236);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(189, 62);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployees.UseMnemonic = false;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnStudents.Image")));
            this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStudents.Location = new System.Drawing.Point(11, 101);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(189, 62);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.Text = "Students";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelads
            // 
            this.panelads.Location = new System.Drawing.Point(209, 570);
            this.panelads.Name = "panelads";
            this.panelads.Size = new System.Drawing.Size(1245, 55);
            this.panelads.TabIndex = 21;
            // 
            // lbltotalstudents
            // 
            this.lbltotalstudents.AutoSize = true;
            this.lbltotalstudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalstudents.ForeColor = System.Drawing.Color.Black;
            this.lbltotalstudents.Location = new System.Drawing.Point(443, 179);
            this.lbltotalstudents.Name = "lbltotalstudents";
            this.lbltotalstudents.Size = new System.Drawing.Size(18, 20);
            this.lbltotalstudents.TabIndex = 36;
            this.lbltotalstudents.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(654, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Total Employees:";
            // 
            // lbltotalemployees
            // 
            this.lbltotalemployees.AutoSize = true;
            this.lbltotalemployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalemployees.ForeColor = System.Drawing.Color.Black;
            this.lbltotalemployees.Location = new System.Drawing.Point(790, 179);
            this.lbltotalemployees.Name = "lbltotalemployees";
            this.lbltotalemployees.Size = new System.Drawing.Size(18, 20);
            this.lbltotalemployees.TabIndex = 40;
            this.lbltotalemployees.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(351, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Lunch Orders:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(351, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = " Use Bus:";
            // 
            // lbltotalbususers
            // 
            this.lbltotalbususers.AutoSize = true;
            this.lbltotalbususers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalbususers.ForeColor = System.Drawing.Color.Black;
            this.lbltotalbususers.Location = new System.Drawing.Point(475, 294);
            this.lbltotalbususers.Name = "lbltotalbususers";
            this.lbltotalbususers.Size = new System.Drawing.Size(18, 20);
            this.lbltotalbususers.TabIndex = 44;
            this.lbltotalbususers.Text = "0";
            // 
            // lbltotallunchusers
            // 
            this.lbltotallunchusers.AutoSize = true;
            this.lbltotallunchusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotallunchusers.ForeColor = System.Drawing.Color.Black;
            this.lbltotallunchusers.Location = new System.Drawing.Point(475, 229);
            this.lbltotallunchusers.Name = "lbltotallunchusers";
            this.lbltotallunchusers.Size = new System.Drawing.Size(18, 20);
            this.lbltotallunchusers.TabIndex = 45;
            this.lbltotallunchusers.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(602, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 31);
            this.label2.TabIndex = 47;
            this.label2.Text = "Employee Statistics";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(687, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(962, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 31);
            this.label7.TabIndex = 49;
            this.label7.Text = "Class Statistics";
            // 
            // lbltotalmanagers
            // 
            this.lbltotalmanagers.AutoSize = true;
            this.lbltotalmanagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalmanagers.ForeColor = System.Drawing.Color.Black;
            this.lbltotalmanagers.Location = new System.Drawing.Point(809, 453);
            this.lbltotalmanagers.Name = "lbltotalmanagers";
            this.lbltotalmanagers.Size = new System.Drawing.Size(18, 20);
            this.lbltotalmanagers.TabIndex = 59;
            this.lbltotalmanagers.Text = "0";
            // 
            // lbltotalbusdrivers
            // 
            this.lbltotalbusdrivers.AutoSize = true;
            this.lbltotalbusdrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalbusdrivers.ForeColor = System.Drawing.Color.Black;
            this.lbltotalbusdrivers.Location = new System.Drawing.Point(809, 397);
            this.lbltotalbusdrivers.Name = "lbltotalbusdrivers";
            this.lbltotalbusdrivers.Size = new System.Drawing.Size(18, 20);
            this.lbltotalbusdrivers.TabIndex = 58;
            this.lbltotalbusdrivers.Text = "0";
            // 
            // lbltotalcleaners
            // 
            this.lbltotalcleaners.AutoSize = true;
            this.lbltotalcleaners.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalcleaners.ForeColor = System.Drawing.Color.Black;
            this.lbltotalcleaners.Location = new System.Drawing.Point(809, 345);
            this.lbltotalcleaners.Name = "lbltotalcleaners";
            this.lbltotalcleaners.Size = new System.Drawing.Size(18, 20);
            this.lbltotalcleaners.TabIndex = 57;
            this.lbltotalcleaners.Text = "0";
            // 
            // lbltotalassistants
            // 
            this.lbltotalassistants.AutoSize = true;
            this.lbltotalassistants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalassistants.ForeColor = System.Drawing.Color.Black;
            this.lbltotalassistants.Location = new System.Drawing.Point(809, 293);
            this.lbltotalassistants.Name = "lbltotalassistants";
            this.lbltotalassistants.Size = new System.Drawing.Size(18, 20);
            this.lbltotalassistants.TabIndex = 56;
            this.lbltotalassistants.Text = "0";
            // 
            // lbltotalteachers
            // 
            this.lbltotalteachers.AutoSize = true;
            this.lbltotalteachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalteachers.ForeColor = System.Drawing.Color.Black;
            this.lbltotalteachers.Location = new System.Drawing.Point(809, 235);
            this.lbltotalteachers.Name = "lbltotalteachers";
            this.lbltotalteachers.Size = new System.Drawing.Size(18, 20);
            this.lbltotalteachers.TabIndex = 47;
            this.lbltotalteachers.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(671, 453);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 20);
            this.label15.TabIndex = 55;
            this.label15.Text = "Managers:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(671, 397);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 20);
            this.label14.TabIndex = 54;
            this.label14.Text = "Bus Drivers:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(668, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 53;
            this.label13.Text = "Cleaners:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(668, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 20);
            this.label12.TabIndex = 52;
            this.label12.Text = "Class Assistants:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(668, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Teachers:";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(608, 435);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(50, 47);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 51;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(608, 382);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(50, 47);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 50;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(608, 329);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(50, 47);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 49;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(608, 276);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 47);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 48;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(608, 223);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 47);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 47;
            this.pictureBox7.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(227, 334);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(319, 159);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Using";
            title1.Text = "Use Bus";
            this.chart1.Titles.Add(title1);
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader2.ForeColor = System.Drawing.Color.Black;
            this.lblHeader2.Location = new System.Drawing.Point(275, 122);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(226, 31);
            this.lblHeader2.TabIndex = 46;
            this.lblHeader2.Text = "Student Statistics";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(352, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // imgboxvans
            // 
            this.imgboxvans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgboxvans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgboxvans.Image = ((System.Drawing.Image)(resources.GetObject("imgboxvans.Image")));
            this.imgboxvans.Location = new System.Drawing.Point(284, 223);
            this.imgboxvans.Name = "imgboxvans";
            this.imgboxvans.Size = new System.Drawing.Size(50, 47);
            this.imgboxvans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgboxvans.TabIndex = 29;
            this.imgboxvans.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(284, 278);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1026, 57);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(75, 62);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 50;
            this.pictureBox6.TabStop = false;
            // 
            // lbltotalclasses
            // 
            this.lbltotalclasses.AutoSize = true;
            this.lbltotalclasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalclasses.ForeColor = System.Drawing.Color.Black;
            this.lbltotalclasses.Location = new System.Drawing.Point(1107, 179);
            this.lbltotalclasses.Name = "lbltotalclasses";
            this.lbltotalclasses.Size = new System.Drawing.Size(18, 20);
            this.lbltotalclasses.TabIndex = 51;
            this.lbltotalclasses.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(993, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "Total Classes:";
            // 
            // dB_KindergartenDataClasses1
            // 
            this.dB_KindergartenDataClasses1.DataSetName = "DB_KindergartenDataClasses";
            this.dB_KindergartenDataClasses1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(215, 38);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(342, 487);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 47;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(552, 37);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(342, 487);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 51;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(888, 37);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(342, 487);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 60;
            this.pictureBox13.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1446, 560);
            this.Controls.Add(this.lbltotalmanagers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltotalbusdrivers);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbltotalcleaners);
            this.Controls.Add(this.lbltotalemployees);
            this.Controls.Add(this.lbltotalassistants);
            this.Controls.Add(this.lbltotalteachers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblHeader2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbltotalbususers);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.imgboxvans);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.lblstudents);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lbltotalstudents);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltotallunchusers);
            this.Controls.Add(this.Paneltopcontrols);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lbltotalclasses);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paneltopcontrols.ResumeLayout(false);
            this.Paneltopcontrols.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxvans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KindergartenDataClasses1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        //RoundingEdges
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //RoundObjects rndobjects = new RoundObjects();
            //rndobjects();
            // Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Graphics v = e.Graphics;
            RoundObjects rndobjcts = new RoundObjects();
            rndobjcts.DrawRoundRect(v, Pens.Black, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
            //Without rounded corners
            //e.Graphics.DrawRectangle(Pens.Blue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            base.OnPaint(e);
        }

    private void label1_Click(object sender, System.EventArgs e)
        {
          
        }

        #endregion
        private System.Windows.Forms.PictureBox imgboxvans;
        private System.Windows.Forms.Label lblstudents;
        private System.Windows.Forms.Panel Paneltopcontrols;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncredits;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Panel panelads;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbltotalstudents;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltotalemployees;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltotalbususers;
        private System.Windows.Forms.Label lbltotallunchusers;
        private System.Windows.Forms.Button btnFinancial;
        private System.Windows.Forms.Button btnClasses;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbltotalclasses;
        private System.Windows.Forms.Label label11;
        private Button btnPayments;
        private Label lbltotalmanagers;
        private Label lbltotalbusdrivers;
        private Label lbltotalcleaners;
        private Label lbltotalassistants;
        private Label lbltotalteachers;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private DB_KindergartenDataClasses dB_KindergartenDataClasses1;
        private ImageList imageList1;
        private ImageList imageList2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
    }
}

