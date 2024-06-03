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
    public partial class DepartmentForm : Form
    {
        int updateDeptID = -1;

        public DepartmentForm()
        {
            InitializeComponent();

            gbEnterDept.Visible = false;

            dgDepartments.DataSource = Utility.GetDepartments();
            dgDepartments.Columns["DeptID"].Visible = false;
            dgDepartments.Columns["Address"].Visible = false;

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Update Rows";
            editColumn.Text = "Update";
            editColumn.Name = "editButton";
            editColumn.UseColumnTextForButtonValue = true;
            dgDepartments.Columns.Add(editColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Delete Rows";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "deleteButton";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgDepartments.Columns.Add(deleteColumn);

            cmbLocation.SelectedItem = null;
            cmbLocation.Text = "Select Location";
        }

        private void dgDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e);

            if (sender is DataGridView && e.RowIndex >= 0)
            {
                // find empID
                DataGridView dg = (DataGridView)sender;

                var rowToBeOperatedOn = dg.Rows[e.RowIndex];
                var currentDeptId = int.Parse(rowToBeOperatedOn.Cells["DeptId"].Value.ToString());

                if (e.ColumnIndex == -1)
                {
                    // Populate the entire form                 
                    gbEnterDept.Visible = true;
                    btnAddDept.Text = "Hide Fields";

                    cmbLocation.SelectedItem = null;
                    cmbLocation.Text = "Select Location";

                    updateDeptID = int.Parse(rowToBeOperatedOn.Cells["DeptID"].Value.ToString());

                    if (updateDeptID >= 0)
                    {
                        txtDeptName.Text = rowToBeOperatedOn.Cells["DeptName"].Value.ToString();
                        txtAddress.Text = rowToBeOperatedOn.Cells["Address"].Value.ToString();
                        cmbLocation.SelectedItem = rowToBeOperatedOn.Cells["Location"].Value.ToString();
                        txtContactPerson.Text = rowToBeOperatedOn.Cells["ContactPerson"].Value.ToString();
                        txtPhoneNum.Text = rowToBeOperatedOn.Cells["PhoneNum"].Value.ToString();
                    }
                }

                if (dg.SelectedCells.Count == 1)
                {
                    var x = dg.SelectedCells[0];
                    System.Diagnostics.Debug.WriteLine(x);

                    if (x is DataGridViewButtonCell)
                    {
                        DataGridViewButtonCell selectedButtonCell = (DataGridViewButtonCell)x;

                        if (selectedButtonCell.Value.ToString().ToUpper().Equals("DELETE"))
                        {
                            System.Diagnostics.Debug.WriteLine(currentDeptId);

                            Utility.DeleteDepartment(currentDeptId);
                            dgDepartments.DataSource = Utility.GetDepartments();
                        }
                        else if (selectedButtonCell.Value.ToString().ToUpper().Equals("UPDATE"))
                        {
                            System.Diagnostics.Debug.WriteLine(currentDeptId);

                            Utility.UpdateDepartment(currentDeptId,
                                rowToBeOperatedOn.Cells["DeptName"].Value.ToString(),
                                rowToBeOperatedOn.Cells["Address"].Value.ToString(),
                                rowToBeOperatedOn.Cells["Location"].Value.ToString(),
                                rowToBeOperatedOn.Cells["ContactPerson"].Value.ToString(),
                                rowToBeOperatedOn.Cells["PhoneNum"].Value.ToString()
                            );
                            dgDepartments.DataSource = Utility.GetDepartments();
                        }
                    }
                }
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            ep.Clear();

            if(txtDeptName.Text == string.Empty)
            {
                ep.SetError(txtDeptName, "Enter a Department Name");
                hasError = true;
            }

            string phoneRegex = @"^(\+\d{1,2}\s?)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$";
            if (txtPhoneNum.Text != string.Empty && !Regex.IsMatch(txtPhoneNum.Text, phoneRegex))
            {
                ep.SetError(txtPhoneNum, "Invalid Phone Number");
                hasError = true;
            }

            if (!hasError)
            {
                if (updateDeptID < 0)
                {
                    Utility.SaveDepartment(
                        txtDeptName.Text,
                        cmbLocation.SelectedItem == null ? string.Empty : cmbLocation.SelectedItem.ToString(),
                        txtContactPerson.Text,
                        txtPhoneNum.Text,
                        txtAddress.Text
                    );
                }
                else
                {
                    Utility.UpdateDepartment(
                        updateDeptID,
                        txtDeptName.Text,
                        txtAddress.Text,
                        cmbLocation.SelectedItem == null ? string.Empty : cmbLocation.SelectedItem.ToString(),
                        txtContactPerson.Text,
                        txtPhoneNum.Text
                    );
                }
            }

            dgDepartments.DataSource = Utility.GetDepartments();
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            gbEnterDept.Visible = !gbEnterDept.Visible;
            if(gbEnterDept.Visible)
            {
                btnAddDept.Text = "Hide Fields";
            }
            else
            {
                btnAddDept.Text = "Add Department";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dvSearchy = Utility.GetDepartments().DefaultView;
            dvSearchy.RowFilter = "DeptName LIKE '%" + txtSearch.Text + "%'";
            dgDepartments.DataSource = dvSearchy;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            txtDeptName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtContactPerson.Text = string.Empty;
            txtPhoneNum.Text = string.Empty;

            cmbLocation.SelectedItem = null;
            cmbLocation.Text = "Select Location";

            updateDeptID = -1;

            dgDepartments.DataSource = Utility.GetDepartments();
        }
    }
}
