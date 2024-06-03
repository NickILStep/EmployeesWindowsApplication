namespace FinalProject
{
    partial class EmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgEmployees = new System.Windows.Forms.DataGridView();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.lblEmpType = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.cmbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbEmpType = new System.Windows.Forms.ComboBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDateJoined = new System.Windows.Forms.DateTimePicker();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.gbEnterEmp = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.gbEnterEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Employee Form";
            // 
            // dgEmployees
            // 
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployees.Location = new System.Drawing.Point(25, 400);
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.RowHeadersWidth = 51;
            this.dgEmployees.Size = new System.Drawing.Size(434, 150);
            this.dgEmployees.TabIndex = 19;
            this.dgEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployees_CellClick);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(18, 29);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblFirstName.TabIndex = 100;
            this.lblFirstName.Text = "First Name: ";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(248, 94);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 100;
            this.lblCity.Text = "City: ";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(248, 159);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(53, 13);
            this.lblZip.TabIndex = 100;
            this.lblZip.Text = "ZipCode: ";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(248, 126);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 13);
            this.lblState.TabIndex = 100;
            this.lblState.Text = "State: ";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(18, 289);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(68, 13);
            this.lblCommission.TabIndex = 100;
            this.lblCommission.Text = "Commission: ";
            // 
            // lblEmpType
            // 
            this.lblEmpType.AutoSize = true;
            this.lblEmpType.Location = new System.Drawing.Point(18, 159);
            this.lblEmpType.Name = "lblEmpType";
            this.lblEmpType.Size = new System.Drawing.Size(86, 13);
            this.lblEmpType.TabIndex = 100;
            this.lblEmpType.Text = "Employee Type: ";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(248, 224);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(70, 13);
            this.lblStartDate.TabIndex = 100;
            this.lblStartDate.Text = "Date Joined: ";
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(18, 193);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(77, 13);
            this.lblMaritalStatus.TabIndex = 100;
            this.lblMaritalStatus.Text = "Marital Status: ";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(248, 63);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(83, 13);
            this.lblAddressLine2.TabIndex = 100;
            this.lblAddressLine2.Text = "Address Line 2: ";
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(18, 94);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(35, 13);
            this.lblSSN.TabIndex = 100;
            this.lblSSN.Text = "SSN: ";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(248, 29);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(83, 13);
            this.lblAddressLine1.TabIndex = 100;
            this.lblAddressLine1.Text = "Address Line 1: ";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(18, 256);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(39, 13);
            this.lblSales.TabIndex = 100;
            this.lblSales.Text = "Sales: ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(18, 63);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 100;
            this.lblLastName.Text = "Last Name: ";
            // 
            // cmbMaritalStatus
            // 
            this.cmbMaritalStatus.FormattingEnabled = true;
            this.cmbMaritalStatus.Items.AddRange(new object[] {
            "Single",
            "In Relationship",
            "Engaged",
            "Married",
            "Divorced"});
            this.cmbMaritalStatus.Location = new System.Drawing.Point(105, 193);
            this.cmbMaritalStatus.Name = "cmbMaritalStatus";
            this.cmbMaritalStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbMaritalStatus.TabIndex = 6;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(18, 126);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(68, 13);
            this.lblDept.TabIndex = 100;
            this.lblDept.Text = "Department: ";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(18, 224);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(39, 13);
            this.lblSalary.TabIndex = 100;
            this.lblSalary.Text = "Salary:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(248, 193);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(60, 13);
            this.lblBirthDate.TabIndex = 100;
            this.lblBirthDate.Text = "Birth Date: ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(105, 29);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(105, 63);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(121, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(105, 289);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(121, 20);
            this.txtCommission.TabIndex = 9;
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(105, 256);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(121, 20);
            this.txtSales.TabIndex = 8;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(105, 224);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(121, 20);
            this.txtSalary.TabIndex = 7;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(338, 29);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(121, 20);
            this.txtAddressLine1.TabIndex = 10;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(105, 94);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(121, 20);
            this.txtSSN.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(338, 94);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(121, 20);
            this.txtCity.TabIndex = 12;
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(338, 63);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(121, 20);
            this.txtAddressLine2.TabIndex = 11;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(105, 126);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartment.TabIndex = 4;
            this.cmbDepartment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbDepartment_MouseClick);
            // 
            // cmbEmpType
            // 
            this.cmbEmpType.FormattingEnabled = true;
            this.cmbEmpType.Items.AddRange(new object[] {
            "Salary",
            "Commission",
            "Base + Commission"});
            this.cmbEmpType.Location = new System.Drawing.Point(105, 159);
            this.cmbEmpType.Name = "cmbEmpType";
            this.cmbEmpType.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpType.TabIndex = 5;
            this.cmbEmpType.SelectedIndexChanged += new System.EventHandler(this.cmbEmpType_SelectedIndexChanged);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(338, 159);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(121, 20);
            this.txtZip.TabIndex = 14;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(275, 267);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(356, 267);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.ItemHeight = 13;
            this.cmbState.Items.AddRange(new object[] {
            "Alabama (AL)",
            "Alaska (AK)",
            "Arizona (AZ)",
            "Arkansas (AR)",
            "California (CA)",
            "Colorado (CO)",
            "Connecticut (CT)",
            "Delaware (DE)",
            "District of Columbia (DC)",
            "Florida (FL)",
            "Georgia (GA)",
            "Hawaii (HI)",
            "Idaho (ID)",
            "Illinois (IL)",
            "Indiana (IN)",
            "Iowa (IA)",
            "Kansas (KS)",
            "Kentucky (KY)",
            "Louisiana (LA)",
            "Maine (ME)",
            "Maryland (MD)",
            "Massachusetts (MA)",
            "Michigan (MI)",
            "Minnesota (MN)",
            "Mississippi (MS)",
            "Missouri (MO)",
            "Montana (MT)",
            "Nebraska (NE)",
            "Nevada (NV)",
            "New Hampshire (NH)",
            "New Jersey (NJ)",
            "New Mexico (NM)",
            "New York (NY)",
            "North Carolina (NC)",
            "North Dakota (ND)",
            "Ohio (OH)",
            "Oklahoma (OK)",
            "Oregon (OR)",
            "Pennsylvania (PA)",
            "Rhode Island (RI)",
            "South Carolina (SC)",
            "South Dakota (SD)",
            "Tennessee (TN)",
            "Texas (TX)",
            "Utah (UT)",
            "Vermont (VT)",
            "Virginia (VA)",
            "Washington (WA)",
            "West Virginia (WV)",
            "Wisconsin (WI)",
            "Wyoming (WY)",
            "American Samoa (AS)",
            "Guam (GU)",
            "Northern Mariana Islands (MP)",
            "Puerto Rico (PR)",
            "Virgin Islands (VI)"});
            this.cmbState.Location = new System.Drawing.Point(338, 126);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(121, 21);
            this.cmbState.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(254, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(214, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(209, 23);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 100;
            this.lblSearch.Text = "Search:";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(338, 193);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(121, 20);
            this.dtpBirthDate.TabIndex = 15;
            // 
            // dtpDateJoined
            // 
            this.dtpDateJoined.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateJoined.Location = new System.Drawing.Point(338, 225);
            this.dtpDateJoined.Name = "dtpDateJoined";
            this.dtpDateJoined.Size = new System.Drawing.Size(121, 20);
            this.dtpDateJoined.TabIndex = 16;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(198, 370);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(93, 23);
            this.btnAddEmp.TabIndex = 100;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // gbEnterEmp
            // 
            this.gbEnterEmp.Controls.Add(this.lblCommission);
            this.gbEnterEmp.Controls.Add(this.lblFirstName);
            this.gbEnterEmp.Controls.Add(this.dtpDateJoined);
            this.gbEnterEmp.Controls.Add(this.lblCity);
            this.gbEnterEmp.Controls.Add(this.dtpBirthDate);
            this.gbEnterEmp.Controls.Add(this.lblZip);
            this.gbEnterEmp.Controls.Add(this.lblState);
            this.gbEnterEmp.Controls.Add(this.lblEmpType);
            this.gbEnterEmp.Controls.Add(this.lblStartDate);
            this.gbEnterEmp.Controls.Add(this.cmbState);
            this.gbEnterEmp.Controls.Add(this.lblMaritalStatus);
            this.gbEnterEmp.Controls.Add(this.btnReset);
            this.gbEnterEmp.Controls.Add(this.lblAddressLine2);
            this.gbEnterEmp.Controls.Add(this.btnSubmit);
            this.gbEnterEmp.Controls.Add(this.lblSSN);
            this.gbEnterEmp.Controls.Add(this.txtZip);
            this.gbEnterEmp.Controls.Add(this.lblAddressLine1);
            this.gbEnterEmp.Controls.Add(this.cmbEmpType);
            this.gbEnterEmp.Controls.Add(this.lblSales);
            this.gbEnterEmp.Controls.Add(this.cmbDepartment);
            this.gbEnterEmp.Controls.Add(this.lblLastName);
            this.gbEnterEmp.Controls.Add(this.txtAddressLine2);
            this.gbEnterEmp.Controls.Add(this.cmbMaritalStatus);
            this.gbEnterEmp.Controls.Add(this.txtCity);
            this.gbEnterEmp.Controls.Add(this.lblDept);
            this.gbEnterEmp.Controls.Add(this.txtSSN);
            this.gbEnterEmp.Controls.Add(this.lblSalary);
            this.gbEnterEmp.Controls.Add(this.txtAddressLine1);
            this.gbEnterEmp.Controls.Add(this.lblBirthDate);
            this.gbEnterEmp.Controls.Add(this.txtSalary);
            this.gbEnterEmp.Controls.Add(this.txtFirstName);
            this.gbEnterEmp.Controls.Add(this.txtSales);
            this.gbEnterEmp.Controls.Add(this.txtLastName);
            this.gbEnterEmp.Controls.Add(this.txtCommission);
            this.gbEnterEmp.Location = new System.Drawing.Point(9, 46);
            this.gbEnterEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEnterEmp.Name = "gbEnterEmp";
            this.gbEnterEmp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEnterEmp.Size = new System.Drawing.Size(472, 318);
            this.gbEnterEmp.TabIndex = 1;
            this.gbEnterEmp.TabStop = false;
            this.gbEnterEmp.Text = "Enter Employee Information";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 571);
            this.ControlBox = false;
            this.Controls.Add(this.gbEnterEmp);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgEmployees);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Employee Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.gbEnterEmp.ResumeLayout(false);
            this.gbEnterEmp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgEmployees;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.Label lblEmpType;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ComboBox cmbMaritalStatus;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbEmpType;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.DateTimePicker dtpDateJoined;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.GroupBox gbEnterEmp;
    }
}