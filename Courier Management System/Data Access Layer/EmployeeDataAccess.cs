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
            string sql = "INSERT INTO Employee(Name,Joining_date,DOB,Salary,Contact,Address,Designation,Branch_id,Blood_Group,Qualification,User_Id) VALUES('" + employees.Name + "','" + employees.Joining_date + "','" + employees.DOB + "','" + employees.Salary + "','" + employees.Contact + "','" + employees.Address + "','" + employees.Designation + "','" + employees.Branch_id + "','" + employees.Blood_Group + "','" + employees.Qualification + "','" + employees.User_id + "')";
            return this.dataAccess.ExecuteQuery(sql);
        }

        public List<Employee> GellAllEmployessData()
        {
            string sql = "SELECT * FROM Employee";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Employee> events = new List<Employee>();
            while (reader.Read())
            {
                Employee en = new Employee();
                en.Name = reader["Name"].ToString();
                en.Joining_date = reader["Joining_date"].ToString();
                en.Salary = (float)reader["DOB"]
               


                events.Add(en);

            }
            return events;

        }

    }
}
