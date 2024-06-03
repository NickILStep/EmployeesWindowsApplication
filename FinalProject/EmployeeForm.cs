using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class EmployeeForm : Form
    {
        int updateEmpID = -1;

        public EmployeeForm()
        {
            InitializeComponent();

            gbEnterEmp.Visible = false;

            dgEmployees.DataSource = Utility.GetEmployees();
            dgEmployees.Columns["EmpID"].Visible = false;
            dgEmployees.Columns["DeptID"].Visible = false;
            dgEmployees.Columns["Salary"].Visible = false;
            dgEmployees.Columns["Sales"].Visible = false;
            dgEmployees.Columns["Commission"].Visible = false;
            dgEmployees.Columns["AddressLine1"].Visible = false;
            dgEmployees.Columns["AddressLine2"].Visible = false;
            dgEmployees.Columns["City"].Visible = false;
            dgEmployees.Columns["State"].Visible = false;
            dgEmployees.Columns["Zip"].Visible = false;
            dgEmployees.Columns["EmployeeType"].Visible = false;
            dgEmployees.Columns["Birthdate"].Visible = false;
            dgEmployees.Columns["Date Joined"].Visible = false;
            dgEmployees.Columns["MaritalStatus"].Visible = false;

            DataGridViewTextBoxColumn deptNameColumn = new DataGridViewTextBoxColumn();
            deptNameColumn.HeaderText = "Department";
            deptNameColumn.Name = "Department";
            dgEmployees.Columns.Add(deptNameColumn);

            dgEmployees.DataBindingComplete += DgEmployees_DataBindingComplete;

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Update Rows";
            editColumn.Text = "Update";
            editColumn.Name = "editButton";
            editColumn.UseColumnTextForButtonValue = true;
            dgEmployees.Columns.Add(editColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Delete Rows";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "deleteButton";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgEmployees.Columns.Add(deleteColumn);

            Organization.DepartmentsDataTable dtDeptTable = Utility.GetDepartments();
            cmbDepartment.DataSource = dtDeptTable;
            cmbDepartment.DisplayMember = dtDeptTable.Columns[1].ColumnName;
            cmbDepartment.ValueMember = dtDeptTable.Columns[0].ColumnName;

            cmbDepartment.SelectedItem = null;
            cmbDepartment.Text = "Select Department";
            cmbEmpType.SelectedItem = null;
            cmbEmpType.Text = "Select Type";
            cmbMaritalStatus.SelectedItem = null;
            cmbMaritalStatus.Text = "Select Marital Status";
            cmbState.SelectedItem = null;
            cmbState.Text = "Select State";

            lblSalary.Visible = false;
            txtSalary.Visible = false;
            lblSales.Visible = false;
            txtSales.Visible = false;
            lblCommission.Visible = false;
            txtCommission.Visible = false;
        }

        private void DgEmployees_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           
            for(int i = 0; i < dgEmployees.Rows.Count-1; i++)
            {
                dgEmployees.Rows[i].Cells["Department"].Value = Utility.GetDepartmentName(int.Parse(dgEmployees.Rows[i].Cells["DeptID"].Value.ToString()));
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            ep.Clear();

            if (txtFirstName.Text == string.Empty)
            {
                ep.SetError(txtFirstName, "Enter a First Name");
                hasError = true;
            }

            if (txtLastName.Text == string.Empty)
            {
                ep.SetError(txtLastName, "Enter a Last Name");
                hasError = true;
            }

            string ssnRegex = @"^\d{3}-?\d{2}-?\d{4}$";
            if (txtSSN.Text != string.Empty && !Regex.IsMatch(txtSSN.Text, ssnRegex))
            {
                ep.SetError(txtSSN, "Invalid SSN");
                hasError = true;
            }

            string zipRegex = "^[0-9]{5}(?:-[0-9]{4})?$";
            if(txtZip.Text != string.Empty && !Regex.IsMatch(txtZip.Text, zipRegex))
            {
                ep.SetError(txtZip, "Invalid Zip Code");
                hasError = true;
            }

            if(dtpBirthDate.Value > DateTime.Now)
            {
                ep.SetError(dtpBirthDate, "Birth Date Cannot Be a Future Date");
            }

            if (!hasError)
            {
                if (updateEmpID < 0)
                {
                    Utility.SaveEmployee(
                        txtFirstName.Text,
                        txtLastName.Text,
                        txtSSN.Text,
                        cmbDepartment.SelectedValue == null ? -1 : int.Parse(cmbDepartment.SelectedValue.ToString()),
                        txtSalary.Text == string.Empty ? 0 : int.Parse(txtSalary.Text),
                        txtSales.Text == string.Empty ? 0 : int.Parse(txtSales.Text),
                        txtCommission.Text == string.Empty ? 0 : int.Parse(txtCommission.Text),
                        txtAddressLine1.Text,
                        txtAddressLine2.Text,
                        txtCity.Text,
                        cmbState.SelectedItem == null ? string.Empty : cmbState.SelectedItem.ToString(),
                        txtZip.Text,
                        cmbEmpType.SelectedItem == null ? string.Empty : cmbEmpType.SelectedItem.ToString(),
                        dtpBirthDate.Value,
                        dtpDateJoined.Value,
                        cmbMaritalStatus.SelectedItem == null ? string.Empty : cmbMaritalStatus.SelectedItem.ToString()
                    );
                }
                else
                {
                    Utility.UpdateEmployee(
                        updateEmpID,
                        txtFirstName.Text,
                        txtLastName.Text,
                        txtSSN.Text,
                        int.Parse(cmbDepartment.SelectedValue.ToString()),
                        txtSalary.Text == string.Empty ? 0 : int.Parse(txtSalary.Text),
                        txtSales.Text == string.Empty ? 0 : int.Parse(txtSales.Text),
                        txtCommission.Text == string.Empty ? 0 : int.Parse(txtCommission.Text),
                        txtAddressLine1.Text,
                        txtAddressLine2.Text,
                        txtCity.Text,
                        cmbState.SelectedItem == null ? string.Empty : cmbState.SelectedItem.ToString(),
                        txtZip.Text,
                        cmbEmpType.SelectedItem == null ? string.Empty : cmbEmpType.SelectedItem.ToString(),
                        DateTime.Parse(dtpBirthDate.Value.ToString()),
                        DateTime.Parse(dtpDateJoined.Value.ToString()),
                        cmbMaritalStatus.SelectedItem == null ? string.Empty : cmbMaritalStatus.SelectedItem.ToString()
                    );
                }
            }

            dgEmployees.DataSource = Utility.GetEmployees();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtSSN.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtSales.Text = string.Empty;
            txtCommission.Text = string.Empty;
            txtAddressLine1.Text = string.Empty;
            txtAddressLine2.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtZip.Text = string.Empty;
            dtpBirthDate.Value = DateTime.Now.Date;
            dtpDateJoined.Value = DateTime.Now.Date;

            cmbDepartment.SelectedItem = null;
            cmbDepartment.Text = "Select Department";
            cmbEmpType.SelectedItem = null;
            cmbEmpType.Text = "Select Type";
            cmbMaritalStatus.SelectedItem = null;
            cmbMaritalStatus.Text = "Select Marital Status";
            cmbState.SelectedItem = null;
            cmbState.Text = "Select State";

            updateEmpID = -1;

            dgEmployees.DataSource = Utility.GetEmployees();
        }

        private void dgEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e);

            if(sender is DataGridView && e.RowIndex >= 0)
            {
                // find empID
                DataGridView dg = (DataGridView)sender;

                var rowToBeOperatedOn = dg.Rows[e.RowIndex];
                var currentEmpId = int.Parse(rowToBeOperatedOn.Cells["EmpId"].Value.ToString());

                if (e.ColumnIndex == -1)
                {
                    // Populate the entire form                 
                    gbEnterEmp.Visible = true;
                    btnAddEmp.Text = "Hide Fields";

                    cmbDepartment.SelectedItem = null;
                    cmbDepartment.Text = "Select Department";
                    cmbEmpType.SelectedItem = null;
                    cmbEmpType.Text = "Select Type";
                    cmbMaritalStatus.SelectedItem = null;
                    cmbMaritalStatus.Text = "Select Marital Status";
                    cmbState.SelectedItem = null;
                    cmbState.Text = "Select State";

                    updateEmpID = int.Parse(rowToBeOperatedOn.Cells["EmpID"].Value.ToString());

                    if (updateEmpID >= 0)
                    {
                        txtFirstName.Text = rowToBeOperatedOn.Cells["First_Name"].Value.ToString();
                        txtLastName.Text = rowToBeOperatedOn.Cells["Last_Name"].Value.ToString();
                        txtSSN.Text = rowToBeOperatedOn.Cells["SSN"].Value.ToString();
                        cmbDepartment.SelectedValue = int.Parse(rowToBeOperatedOn.Cells["DeptID"].Value.ToString());
                        cmbEmpType.SelectedItem = rowToBeOperatedOn.Cells["EmployeeType"].Value.ToString();
                        cmbMaritalStatus.SelectedItem = rowToBeOperatedOn.Cells["MaritalStatus"].Value.ToString();
                        txtSalary.Text = rowToBeOperatedOn.Cells["Salary"].Value.ToString();
                        txtSales.Text = rowToBeOperatedOn.Cells["Sales"].Value.ToString();
                        txtCommission.Text = rowToBeOperatedOn.Cells["Commission"].Value.ToString();
                        txtAddressLine1.Text = rowToBeOperatedOn.Cells["AddressLine1"].Value.ToString();
                        txtAddressLine2.Text = rowToBeOperatedOn.Cells["AddressLine2"].Value.ToString();
                        txtCity.Text = rowToBeOperatedOn.Cells["City"].Value.ToString();
                        cmbState.SelectedItem = rowToBeOperatedOn.Cells["State"].Value.ToString();
                        txtZip.Text = rowToBeOperatedOn.Cells["Zip"].Value.ToString();
                        dtpBirthDate.Value = DateTime.Parse(rowToBeOperatedOn.Cells["Birthdate"].Value.ToString());
                        dtpDateJoined.Value = DateTime.Parse(rowToBeOperatedOn.Cells["Date Joined"].Value.ToString());
                    }
                }

                if (dg.SelectedCells.Count == 1)
                {
                    var x = dg.SelectedCells[0];
                    System.Diagnostics.Debug.WriteLine(x);

                    if(x is DataGridViewButtonCell)
                    {
                        DataGridViewButtonCell selectedButtonCell = (DataGridViewButtonCell)x;

                        if (selectedButtonCell.Value.ToString().ToUpper().Equals("DELETE"))
                        {
                            System.Diagnostics.Debug.WriteLine(currentEmpId);

                            Utility.DeleteEmployee(currentEmpId);
                            dgEmployees.DataSource = Utility.GetEmployees();
                        }
                        else if (selectedButtonCell.Value.ToString().ToUpper().Equals("UPDATE"))
                        {
                            System.Diagnostics.Debug.WriteLine(currentEmpId);

                            Utility.UpdateEmployee(currentEmpId,
                                rowToBeOperatedOn.Cells["First_Name"].Value.ToString(),
                                rowToBeOperatedOn.Cells["Last_Name"].Value.ToString(),
                                rowToBeOperatedOn.Cells["SSN"].Value.ToString(),
                                int.Parse(rowToBeOperatedOn.Cells["DeptID"].Value.ToString()),
                                int.Parse(rowToBeOperatedOn.Cells["Salary"].Value.ToString()),
                                int.Parse(rowToBeOperatedOn.Cells["Sales"].Value.ToString()),
                                int.Parse(rowToBeOperatedOn.Cells["Commission"].Value.ToString()),
                                rowToBeOperatedOn.Cells["AddressLine1"].Value.ToString(),
                                rowToBeOperatedOn.Cells["AddressLine2"].Value.ToString(),
                                rowToBeOperatedOn.Cells["City"].Value.ToString(),
                                rowToBeOperatedOn.Cells["State"].Value.ToString(),
                                rowToBeOperatedOn.Cells["Zip"].Value.ToString(),
                                rowToBeOperatedOn.Cells["EmployeeType"].Value.ToString(),
                                DateTime.Parse(rowToBeOperatedOn.Cells["Birthdate"].Value.ToString()),
                                DateTime.Parse(rowToBeOperatedOn.Cells["Date Joined"].Value.ToString()),
                                rowToBeOperatedOn.Cells["MaritalStatus"].Value.ToString()
                            );
                            dgEmployees.DataSource = Utility.GetEmployees();
                        }
                    }
                }
            }
        }

        private void cmbEmpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpType.SelectedItem == "Salary")
            {
                lblSales.Visible = false;
                txtSales.Visible = false;
                txtCommission.Visible = false;
                lblCommission.Visible = false;

                lblSalary.Visible = true;
                txtSalary.Visible = true;
            }
            else if (cmbEmpType.SelectedItem == "Commission")
            {
                lblSalary.Visible = false;
                txtSalary.Visible = false;

                lblSales.Visible = true;
                txtSales.Visible = true;
                lblCommission.Visible = true;
                txtCommission.Visible = true;
            }
            else if (cmbEmpType.SelectedItem == "Base + Commission")
            {
                lblSalary.Visible = true;
                txtSalary.Visible = true;
                lblSales.Visible = true;
                txtSales.Visible = true;
                lblCommission.Visible = true;
                txtCommission.Visible = true;
            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            gbEnterEmp.Visible = !gbEnterEmp.Visible;
            if(gbEnterEmp.Visible)
            {
                btnAddEmp.Text = "Hide Fields";
            }
            else
            {
                btnAddEmp.Text = "Add Employee";
            }
        }

        private void cmbDepartment_MouseClick(object sender, MouseEventArgs e)
        {
            Organization.DepartmentsDataTable dtDeptTable = Utility.GetDepartments();
            cmbDepartment.DataSource = dtDeptTable;
            cmbDepartment.DisplayMember = dtDeptTable.Columns[1].ColumnName;
            cmbDepartment.ValueMember = dtDeptTable.Columns[0].ColumnName;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dvSearchy = Utility.GetEmployees().DefaultView;
            dvSearchy.RowFilter = "Last_Name LIKE '%" + txtSearch.Text + "%'";
            dgEmployees.DataSource = dvSearchy;
        }
    }
}
