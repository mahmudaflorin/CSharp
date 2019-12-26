﻿using ResManaged3.App;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManaged3.Data
{
    class Order
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Edu\Programs\C#\Practice\ResManaged3\Data\ResM.mdf;Integrated Security=True";

        public static void InserOrdersDb(User user)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into orderTable values ( @userID, @bill, @status, @address, @mobile);", con);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@userID", user.UserName);
                cmd.Parameters.AddWithValue("@bill", (float)CheckOutApp.CalculateTotalPrice());
                cmd.Parameters.AddWithValue("@status", 0);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@mobile", user.Mobile);



                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("SELECT IDENT_CURRENT('orderTable')", con);




                int id = Convert.ToInt32(cmd2.ExecuteScalar());



                foreach(CartItemApp cartItemApp in CheckOutApp.itemApps)
                {
                    
                    SqlCommand cmd3 = new SqlCommand("Insert into orderExtension values ( @orderID, @itemCode, @quantity);", con);

                    cmd3.CommandType = CommandType.Text;

                    cmd3.Parameters.AddWithValue("@orderID", id);
                    cmd3.Parameters.AddWithValue("@itemCode", Convert.ToInt32(cartItemApp.ItemCode));
                    cmd3.Parameters.AddWithValue("@quantity", cartItemApp.Quantity);
                  



                    cmd3.ExecuteNonQuery();
                }
                con.Close();


                Console.WriteLine("inserted orders");
            }
        }

    }
}
