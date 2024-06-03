namespace FinalProject
{
    partial class DepartmentForm
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
            this.dgDepartments = new System.Windows.Forms.DataGridView();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.lblContactPerson = new System.Windows.Forms.Label();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbEnterDept = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartments)).BeginInit();
            this.gbEnterDept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Department Form";
            // 
            // dgDepartments
            // 
            this.dgDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartments.Location = new System.Drawing.Point(25, 400);
            this.dgDepartments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgDepartments.Name = "dgDepartments";
            this.dgDepartments.Size = new System.Drawing.Size(434, 150);
            this.dgDepartments.TabIndex = 8;
            this.dgDepartments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDepartments_CellClick);
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(126, 66);
            this.lblDeptName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(99, 13);
            this.lblDeptName.TabIndex = 100;
            this.lblDeptName.Text = "Department Name: ";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(126, 196);
            this.lblPhoneNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(84, 13);
            this.lblPhoneNum.TabIndex = 100;
            this.lblPhoneNum.Text = "Phone Number: ";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(126, 131);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(54, 13);
            this.lblLocation.TabIndex = 100;
            this.lblLocation.Text = "Location: ";
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "Ogden Campus",
            "Davis Campus",
            "Virtual Campus",
            "Independent Online"});
            this.cmbLocation.Location = new System.Drawing.Point(227, 128);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(120, 21);
            this.cmbLocation.TabIndex = 3;
            // 
            // lblContactPerson
            // 
            this.lblContactPerson.AutoSize = true;
            this.lblContactPerson.Location = new System.Drawing.Point(126, 163);
            this.lblContactPerson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(86, 13);
            this.lblContactPerson.TabIndex = 100;
            this.lblContactPerson.Text = "Contact Person: ";
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(227, 63);
            this.txtDeptName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(120, 20);
            this.txtDeptName.TabIndex = 1;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(227, 161);
            this.txtContactPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(120, 20);
            this.txtContactPerson.TabIndex = 4;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(227, 193);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(120, 20);
            this.txtPhoneNum.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(154, 229);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(76, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(237, 229);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbEnterDept
            // 
            this.gbEnterDept.Controls.Add(this.lblAddress);
            this.gbEnterDept.Controls.Add(this.txtAddress);
            this.gbEnterDept.Controls.Add(this.btnReset);
            this.gbEnterDept.Controls.Add(this.lblDeptName);
            this.gbEnterDept.Controls.Add(this.btnSubmit);
            this.gbEnterDept.Controls.Add(this.lblPhoneNum);
            this.gbEnterDept.Controls.Add(this.txtPhoneNum);
            this.gbEnterDept.Controls.Add(this.lblLocation);
            this.gbEnterDept.Controls.Add(this.txtContactPerson);
            this.gbEnterDept.Controls.Add(this.cmbLocation);
            this.gbEnterDept.Controls.Add(this.txtDeptName);
            this.gbEnterDept.Controls.Add(this.lblContactPerson);
            this.gbEnterDept.Location = new System.Drawing.Point(9, 46);
            this.gbEnterDept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEnterDept.Name = "gbEnterDept";
            this.gbEnterDept.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEnterDept.Size = new System.Drawing.Size(472, 318);
            this.gbEnterDept.TabIndex = 1;
            this.gbEnterDept.TabStop = false;
            this.gbEnterDept.Text = "Enter Department Information";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(126, 98);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 100;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(227, 96);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(120, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // btnAddDept
            // 
            this.btnAddDept.Location = new System.Drawing.Point(198, 370);
            this.btnAddDept.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(93, 23);
            this.btnAddDept.TabIndex = 100;
            this.btnAddDept.Text = "Add Department";
            this.btnAddDept.UseVisualStyleBackColor = true;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(209, 23);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 100;
            this.lblSearch.Text = "Search:";
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
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 571);
            this.ControlBox = false;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnAddDept);
            this.Controls.Add(this.gbEnterDept);
            this.Controls.Add(this.dgDepartments);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DepartmentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Department Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartments)).EndInit();
            this.gbEnterDept.ResumeLayout(false);
            this.gbEnterDept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDepartments;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label lblContactPerson;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbEnterDept;
        private System.Windows.Forms.Button btnAddDept;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ErrorProvider ep;
    }
}