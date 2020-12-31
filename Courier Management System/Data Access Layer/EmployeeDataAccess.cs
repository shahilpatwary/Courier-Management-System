using Courier_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_System.Data_Access_Layer
{
    class EmployeeDataAccess
    {
        DataAccess dataAccess;
        public EmployeeDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public int AddEmployees(Employee employees)
        {
            string sql = "INSERT INTO Employee(Name,Joining_date,DOB,Salary,Contact,Address,Designation,Branch_id,Blood_Group,Qualification) VALUES('" + employees.Name + "','" + employees.Joining_date + "','" + employees.DOB + "','" + employees.Salary + "','" + employees.Contact + "','" + employees.Address + "','" + employees.Designation + "','" + employees.Branch_id + "','" + employees.Blood_Group + "','" + employees.Qualification + "')";
            return this.dataAccess.ExecuteQuery(sql);
        }

        public List<Employee> GellAllEmployessData()
        {
            string sql = "SELECT * FROM Employee";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Employee> employee = new List<Employee>();
            while (reader.Read())
            {
                Employee en = new Employee();
                en.Id = (int)reader["Id"];
                en.Name = reader["Name"].ToString();
                en.Joining_date = reader["Joining_date"].ToString();
                en.Salary = (float)reader["DOB"];
                en.Contact = reader["Contact"].ToString();
                en.Address = reader["Address"].ToString();
                en.Designation = (int)reader["Designation"];
                en.Branch_id = (int)reader["Branch_id"];
                en.Blood_Group = reader["Blood_Group"].ToString();
                en.Qualification = reader["Qualification"].ToString();
               
                employee.Add(en);

            }
            return employee;

        }

        public int DeleteEmployee(int id)
        {
            string sql = "DELETE FROM Employee WHERE Id=" + id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateEmployeeName(Employee en)
        {
            string sql = "UPDATE Employee SET Name='" + en.Name + "' WHERE Id=" + en.Id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateEmployeeSalary(Employee en)
        {
            string sql = "UPDATE Employee SET Salary ='" + en.Salary + "' WHERE Id=" + en.Id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateEmployeeContact(Employee en)
        {
            string sql = "UPDATE Employee SET Contact='" + en.Contact + "' WHERE Id=" + en.Id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateEmployeeAddress(Employee en)
        {
            string sql = "UPDATE Employee SET Address='" + en.Address + "' WHERE Id=" + en.Id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateEmployeeQualification(Employee en)
        {
            string sql = "UPDATE  Employee SET Qualification='" + en.Qualification + "' WHERE Id=" + en.Id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

    }
}
