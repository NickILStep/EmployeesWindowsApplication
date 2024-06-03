using DataAccessLayer.OrganizationTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class Utility
    {
        public static Organization.DepartmentsDataTable GetDepartments()
        {
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter = new OrganizationTableAdapters.DepartmentsTableAdapter();
            deptAdapter.Fill(dtDeptTable);

            return dtDeptTable;
        }

        public static DataTable GetEmployees()
        {
            Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();
            empAdapter.Fill(dtEmpTable);

            return dtEmpTable;
        }

        public static void SaveDepartment(string deptName, string location, string contactPerson, string phoneNum, string address)
        {
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter = new OrganizationTableAdapters.DepartmentsTableAdapter();
            deptAdapter.Fill(dtDeptTable);

            Organization.DepartmentsRow newDeptRow = dtDeptTable.NewDepartmentsRow();
            newDeptRow.DeptName = deptName;
            newDeptRow.Location = location;
            newDeptRow.ContactPerson = contactPerson;
            newDeptRow.PhoneNum = phoneNum;
            newDeptRow.Address = address;

            dtDeptTable.AddDepartmentsRow(newDeptRow);
            deptAdapter.Update(dtDeptTable);
        }

        public static void SaveEmployee(string firstName, string lastName, string ssn, Nullable<int> deptID, Nullable<int> salary, Nullable<int> sales, Nullable<int> commission, string addressLine1, string addressLine2, string city, string state, string zip, string employeeType, DateTime birthdate, DateTime dateJoined, string maritalStatus)
        {
            Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();
            empAdapter.Fill(dtEmpTable);

            Organization.EmployeesRow newEmpRow = dtEmpTable.NewEmployeesRow();
            newEmpRow.First_Name = firstName;
            newEmpRow.Last_Name = lastName;
            newEmpRow.SSN = ssn;
            newEmpRow.DeptID = (int)deptID;
            newEmpRow.Salary = (int)salary;
            newEmpRow.Sales = (int)sales;
            newEmpRow.Commission = (int)commission;
            newEmpRow.AddressLine1 = addressLine1;
            newEmpRow.AddressLine2 = addressLine2;
            newEmpRow.City = city;
            newEmpRow.State = state;
            newEmpRow.Zip = zip;
            newEmpRow.EmployeeType = employeeType;
            newEmpRow.Birthdate = birthdate;
            newEmpRow.Date_Joined = dateJoined;
            newEmpRow.MaritalStatus = maritalStatus;

            dtEmpTable.AddEmployeesRow(newEmpRow);
            empAdapter.Update(dtEmpTable);
        }

        public static void DeleteEmployee(int empID)
        {
            Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();

            empAdapter.DeleteQuery(empID);
        }

        public static void UpdateEmployee(int empID, string firstName, string lastName, string ssn, Nullable<int> deptID, Nullable<int> salary, Nullable<int> sales, Nullable<int> commission, string addressLine1, string addressLine2, string city, string state, string zip, string employeeType, DateTime birthdate, DateTime dateJoined, string maritalStatus)
        {
            Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();

            empAdapter.UpdateQuery(firstName, lastName, ssn, deptID, salary, sales, commission, addressLine1, addressLine2, city, state, zip, employeeType, birthdate.ToString(), dateJoined.ToString(), maritalStatus, empID);
        }

        public static void DeleteDepartment(int deptID)
        {
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter = new OrganizationTableAdapters.DepartmentsTableAdapter();

            deptAdapter.DeleteQuery(deptID);
        }

        public static void UpdateDepartment(int deptID, string deptName, string address, string location, string contactPerson, string phoneNum)
        {
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter = new OrganizationTableAdapters.DepartmentsTableAdapter();

            deptAdapter.UpdateQuery(deptName, location, contactPerson, phoneNum, address, deptID);
        }

        public static string GetDepartmentName(int deptID)
        {
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter = new OrganizationTableAdapters.DepartmentsTableAdapter();
            deptAdapter.Fill(dtDeptTable);

            if(deptID == -1)
            {
                return string.Empty;
            }

            foreach (Organization.DepartmentsRow row in dtDeptTable.Rows)
            {
                if (int.Parse(row["DeptID"].ToString()) == deptID)
                {
                    return row["DeptName"].ToString();
                }
            }

            return "Department Not Found";
        }
    }
}
