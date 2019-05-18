namespace KindergartenManagementSystem
{
    partial class Payments
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
            this.dataGridallstuds = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnremovepay = new System.Windows.Forms.Button();
            this.btnpay = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbmonths = new System.Windows.Forms.ComboBox();
            this.dBMonthsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_KindergartenDataSet1 = new KindergartenManagementSystem.DB_KindergartenDataSet1();
            this.cmbyears = new System.Windows.Forms.ComboBox();
            this.dBYearsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_KindergartenDataSet = new KindergartenManagementSystem.DB_KindergartenDataSet();
            this.btnset = new System.Windows.Forms.Button();
            this.dB_KindergartenDataClasses = new KindergartenManagementSystem.DB_KindergartenDataClasses();
            this.dBKindergartenDataClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_YearsTableAdapter = new KindergartenManagementSystem.DB_KindergartenDataSetTableAdapters.DB_YearsTableAdapter();
            this.dB_MonthsTableAdapter = new KindergartenManagementSystem.DB_KindergartenDataSet1TableAdapters.DB_MonthsTableAdapter();
            this.dataGridunpaid = new System.Windows.Forms.DataGridView();
            this.dataGridpaid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridallstuds)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBMonthsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KindergartenDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBYearsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KindergartenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KindergartenDataClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBKindergartenDataClassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridunpaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpaid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridallstuds
            // 
            this.dataGridallstuds.AllowUserToAddRows = false;
            this.dataGridallstuds.AllowUserToDeleteRows = false;
            this.dataGridallstuds.AllowUserToResizeColumns = false;
            this.dataGridallstuds.AllowUserToResizeRows = false;
            this.dataGridallstuds.BackgroundColor = System.Drawing.Color.White;
            this.dataGridallstuds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridallstuds.Location = new System.Drawing.Point(103, 137);
            this.dataGridallstuds.MultiSelect = false;
            this.dataGridallstuds.Name = "dataGridallstuds";
            this.dataGridallstuds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridallstuds.Size = new System.Drawing.Size(446, 143);
            this.dataGridallstuds.TabIndex = 55;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.cmbmonths);
            this.panel5.Controls.Add(this.cmbyears);
            this.panel5.Controls.Add(this.btnset);
            this.panel5.Location = new System.Drawing.Point(-2, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(701, 123);
            this.panel5.TabIndex = 53;
            // 
            // btnremovepay
            // 
            this.btnremovepay.BackColor = System.Drawing.Color.DarkGray;
            this.btnremovepay.Location = new System.Drawing.Point(557, 210);
            this.btnremovepay.Name = "btnremovepay";
            this.btnremovepay.Size = new System.Drawing.Size(111, 51);
            this.btnremovepay.TabIndex = 57;
            this.btnremovepay.Text = "Remove Payment";
            this.btnremovepay.UseVisualStyleBackColor = false;
            // 
            // btnpay
            // 
            this.btnpay.BackColor = System.Drawing.Color.DarkGray;
            this.btnpay.Location = new System.Drawing.Point(555, 153);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(113, 51);
            this.btnpay.TabIndex = 56;
            this.btnpay.Text = "Apply Payment";
            this.btnpay.UseVisualStyleBackColor = false;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(246, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Month";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(246, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Year";
            // 
            // cmbmonths
            // 
            this.cmbmonths.DataSource = this.dBMonthsBindingSource;
            this.cmbmonths.DisplayMember = "MonthName";
            this.cmbmonths.FormattingEnabled = true;
            this.cmbmonths.Location = new System.Drawing.Point(325, 41);
            this.cmbmonths.Name = "cmbmonths";
            this.cmbmonths.Size = new System.Drawing.Size(138, 21);
            this.cmbmonths.TabIndex = 21;
            this.cmbmonths.ValueMember = "MonthName";
            // 
            // dBMonthsBindingSource
            // 
            this.dBMonthsBindingSource.DataMember = "DB_Months";
            this.dBMonthsBindingSource.DataSource = this.dB_KindergartenDataSet1;
            // 
            // dB_KindergartenDataSet1
            // 
            this.dB_KindergartenDataSet1.DataSetName = "DB_KindergartenDataSet1";
            this.dB_KindergartenDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbyears
            // 
            this.cmbyears.DataSource = this.dBYearsBindingSource;
            this.cmbyears.DisplayMember = "YearName";
            this.cmbyears.FormattingEnabled = true;
            this.cmbyears.Location = new System.Drawing.Point(325, 12);
            this.cmbyears.Name = "cmbyears";
            this.cmbyears.Size = new System.Drawing.Size(138, 21);
            this.cmbyears.TabIndex = 20;
            this.cmbyears.ValueMember = "YearName";
            // 
            // dBYearsBindingSource
            // 
            this.dBYearsBindingSource.DataMember = "DB_Years";
            this.dBYearsBindingSource.DataSource = this.dB_KindergartenDataSet;
            // 
            // dB_KindergartenDataSet
            // 
            this.dB_KindergartenDataSet.DataSetName = "DB_KindergartenDataSet";
            this.dB_KindergartenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnset
            // 
            this.btnset.BackColor = System.Drawing.Color.DarkGray;
            this.btnset.Location = new System.Drawing.Point(250, 80);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(213, 40);
            this.btnset.TabIndex = 19;
            this.btnset.Text = "Get Details";
            this.btnset.UseVisualStyleBackColor = false;
            this.btnset.Click += new System.EventHandler(this.btnset_Click);
            // 
            // dB_KindergartenDataClasses
            // 
            this.dB_KindergartenDataClasses.DataSetName = "DB_KindergartenDataClasses";
            this.dB_KindergartenDataClasses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBKindergartenDataClassesBindingSource
            // 
            this.dBKindergartenDataClassesBindingSource.DataSource = this.dB_KindergartenDataClasses;
            this.dBKindergartenDataClassesBindingSource.Position = 0;
            // 
            // dB_YearsTableAdapter
            // 
            this.dB_YearsTableAdapter.ClearBeforeFill = true;
            // 
            // dB_MonthsTableAdapter
            // 
            this.dB_MonthsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridunpaid
            // 
            this.dataGridunpaid.AllowUserToAddRows = false;
            this.dataGridunpaid.AllowUserToDeleteRows = false;
            this.dataGridunpaid.AllowUserToResizeColumns = false;
            this.dataGridunpaid.AllowUserToResizeRows = false;
            this.dataGridunpaid.BackgroundColor = System.Drawing.Color.White;
            this.dataGridunpaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridunpaid.Location = new System.Drawing.Point(355, 320);
            this.dataGridunpaid.MultiSelect = false;
            this.dataGridunpaid.Name = "dataGridunpaid";
            this.dataGridunpaid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridunpaid.Size = new System.Drawing.Size(344, 266);
            this.dataGridunpaid.TabIndex = 58;
            // 
            // dataGridpaid
            // 
            this.dataGridpaid.AllowUserToAddRows = false;
            this.dataGridpaid.AllowUserToDeleteRows = false;
            this.dataGridpaid.AllowUserToResizeColumns = false;
            this.dataGridpaid.AllowUserToResizeRows = false;
            this.dataGridpaid.BackgroundColor = System.Drawing.Color.White;
            this.dataGridpaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridpaid.Location = new System.Drawing.Point(-2, 320);
            this.dataGridpaid.MultiSelect = false;
            this.dataGridpaid.Name = "dataGridpaid";
            this.dataGridpaid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridpaid.Size = new System.Drawing.Size(351, 266);
            this.dataGridpaid.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(101, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Paid Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(453, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Unpaid Students";
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 584);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridpaid);
            this.Controls.Add(this.dataGridunpaid);
            this.Controls.Add(this.btnremovepay);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dataGridallstuds);
            this.Controls.Add(this.btnpay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridallstuds)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBMonthsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KindergartenDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBYearsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KindergartenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KindergartenDataClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBKindergartenDataClassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridunpaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridallstuds;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbmonths;
        private System.Windows.Forms.ComboBox cmbyears;
        private System.Windows.Forms.Button btnset;
        private System.Windows.Forms.BindingSource dBKindergartenDataClassesBindingSource;
        private DB_KindergartenDataClasses dB_KindergartenDataClasses;
        private DB_KindergartenDataSet dB_KindergartenDataSet;
        private System.Windows.Forms.BindingSource dBYearsBindingSource;
        private DB_KindergartenDataSetTableAdapters.DB_YearsTableAdapter dB_YearsTableAdapter;
        private DB_KindergartenDataSet1 dB_KindergartenDataSet1;
        private System.Windows.Forms.BindingSource dBMonthsBindingSource;
        private DB_KindergartenDataSet1TableAdapters.DB_MonthsTableAdapter dB_MonthsTableAdapter;
        private System.Windows.Forms.Button btnremovepay;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.DataGridView dataGridunpaid;
        private System.Windows.Forms.DataGridView dataGridpaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}