using ResManaged3.UI.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManaged3.UI.Containers
{
    public partial class PendingOrders : Form
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Edu\Programs\C#\Practice\ResManaged3\Data\ResM.mdf;Integrated Security=True";

        public PendingOrders()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;


            PopulatePanel();
        }
        public void PopulatePanel()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from orderTable where status = 0", con);

                cmd.CommandType = CommandType.Text;


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    OrderPalette orderPalette = new OrderPalette();
                    orderPalette.OrderID = Convert.ToInt32(reader[0]);
                    orderPalette.Bill = (double)reader[2];
                    orderPalette.AddPhn = reader[4].ToString()+", "+reader[5].ToString();
                    orderPalette.Items = GetItemInfo(orderPalette.OrderID);

                    orderPalette.Dock = DockStyle.Top;

                    panel1.Controls.Add(orderPalette);

                }

                reader.Close();
                con.Close();

            }


        }
        public string GetItemInfo(int id)
        {
            string str = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from orderExtension where orderID = @orderID", con);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@orderID", id);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //str = reader[1].ToString() 
                    int itemID = (int)reader[1];
                    string inem = GetItemName(itemID);
                    str = str + inem + "  [ QTY:" + reader[2].ToString() + " ]  ";
                }

                reader.Close();
                con.Close();

            }
            return str;
        }

        public string GetItemName(int id)
        {
            string str = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from itemTable where itemcode = @itemcode", con);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@itemcode", id);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    str = reader[2].ToString();
                }

                reader.Close();
                con.Close();

            }
            return str;
        }

    }
}
