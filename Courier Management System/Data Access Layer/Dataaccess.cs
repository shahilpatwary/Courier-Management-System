﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_System.Data_Access_Layer
{
    class Dataaccess : IDisposable
    {
        SqlConnection connection;
        SqlCommand command;

        public Dataaccess()
        {
            this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CourierManagementSystem"].ConnectionString);
            this.connection.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            SqlDataReader reader = this.command.ExecuteReader();

            return reader;
        }

        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            int result = this.command.ExecuteNonQuery();
            this.connection.Close();
            return result;
        }



        public void Dispose()
        {
            this.connection.Close();
        }
    }
}
