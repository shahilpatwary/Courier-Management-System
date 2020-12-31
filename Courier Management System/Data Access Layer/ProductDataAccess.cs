using Courier_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_System.Data_Access_Layer
{
    class ProductDataAccess
    {
        DataAccess dataAccess;
        public ProductDataAccess()
        {
            this.dataAccess = new DataAccess();
        }


        public int AddNewParcel(Product products)
        {
            string sql = "INSERT INTO Product(ProductType,Receiving_B_id,Sending_B_id,Delivery_charge,Receiving_Manager_id,UpdatedDate,Sending_Manager_id,ProductCategory,PaymentMethod,RecieverName,RecieverEmail,RecieverContact,RecieverAddress,Description,Product_State,Release_Date,Customer_Name,Customer_Mobile_No,Customer_Address) VALUES('"+products.ProductType+"','"+products.Receiving_Branch_id+"','"+products.Sending_Branch_id+"','"+products.Delivery_charge+"','"+products.Receiving_Manager_id+"','"+products.UpdateTime+"','"+products.Sending_Manager_id+"','"+products.ProductCategory+"','"+products.PaymentMethod+"','"+products.RecieverName+"','"+products.RecieverEmail+"','"+products.RecieverContact+"','"+products.RecieverAddress+"','"+products.Description+"','"+products.Product_State+"','"+products.Release_Date+"','"+products.Customer_Name+"','"+products.Customer_MobileNo+"','"+products.Customer_Address+"')";
            return this.dataAccess.ExecuteQuery(sql);

        }


        public List<Product> GellAllData()
        {
            string sql = "SELECT * FROM Product";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Product> pro = new List<Product>();
            while (reader.Read())
            {
                Product p = new Product();
                p.ProductType= (int)reader["ProductType"];
                p.Receiving_Branch_id = (int)reader["Receiving_B_id"];
                p.Sending_Branch_id = (int)reader["Sending_B_id"];
                p.Delivery_charge = (float)reader["Delivery_charge"];
                p.Receiving_Manager_id = (int)reader["Receiving_Manager_id"];
                p.UpdateTime = reader["UpdatedDate"].ToString();
                p.Sending_Manager_id = (int)reader["Sending_Manager_id"];
                p.ProductCategory = (int)reader["ProductCategory"];
                p.PaymentMethod = (int)reader["PaymentMethod"];
                p.RecieverName = reader["RecieverName"].ToString();
                p.RecieverEmail = reader["RecieverEmail"].ToString();
                p.RecieverContact = reader["RecieverContact"].ToString();
                p.RecieverAddress = reader["RecieverAddress"].ToString();
                p.Description = reader["Description"].ToString();
                p.Product_State = (int)reader["Product_State"];
                p.Release_Date = reader["Release_Date"].ToString();
                p.Customer_MobileNo = (int)reader["Customer_Mobile_No"];
                p.Customer_Name = reader["Customer_Name"].ToString();
                p.Customer_Address = reader["Customer_Address"].ToString();






                pro.Add(p);

            }
            return pro;

        }

    }
}
