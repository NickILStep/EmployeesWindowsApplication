using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        StartForm startForm;
        DepartmentForm departmentForm;
        EmployeeForm employeeForm;

        public MainForm()
        {
            InitializeComponent();

            startForm = new StartForm();
            startForm.MdiParent = this;
            startForm.ControlBox = false;
            startForm.MaximizeBox = false;
            startForm.MinimizeBox = false;
            startForm.ShowIcon = false;
            startForm.FormBorderStyle = FormBorderStyle.None;
            startForm.Dock = DockStyle.Fill;

            departmentForm = new DepartmentForm();
            departmentForm.MdiParent = this;
            departmentForm.ControlBox = false;
            departmentForm.MaximizeBox = false;
            departmentForm.MinimizeBox = false;
            departmentForm.ShowIcon = false;
            departmentForm.FormBorderStyle = FormBorderStyle.None;
            departmentForm.Dock = DockStyle.Fill;

            employeeForm = new EmployeeForm();
            employeeForm.MdiParent = this;
            employeeForm.ControlBox = false;
            employeeForm.MaximizeBox = false;
            employeeForm.MinimizeBox = false;
            employeeForm.ShowIcon = false;
            employeeForm.FormBorderStyle = FormBorderStyle.None;
            employeeForm.Dock = DockStyle.Fill;

            startForm.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            departmentForm.Show();
            employeeForm.Hide();
            startForm.Close();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeForm.Show();
            departmentForm.Hide();
            startForm.Close();
        }
    }
}
