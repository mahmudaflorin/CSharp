using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ResManaged3.UI.Elements
{
    public partial class OrderPalette : UserControl
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Edu\Programs\C#\Practice\ResManaged3\Data\ResM.mdf;Integrated Security=True";

        public OrderPalette()
        {
            InitializeComponent();
        }

        public int OrderID
        {
            get
            {
                return Convert.ToInt32(lblOrderID.Text);
            }
            set
            {
                lblOrderID.Text = value.ToString();
            }
        }

        public double Bill
        {
            get
            {
                return Convert.ToDouble(lblBill.Text);
            }
            set
            {
                lblBill.Text = value.ToString();
            }
        }

        public string Items
        {
            get { return lblItems.Text; }
            set { lblItems.Text = value; }
        }

        public string AddPhn
        {
            get { return lblAddPhn.Text; }
            set { lblAddPhn.Text = value; }
        }
        private void PnlBottom2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            Update(1);
            this.Dispose();
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            Update(2);
            this.Dispose();
        }

        public void Update(int status)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update orderTable set status = @status where orderID = @orderID;", con);

                cmd.CommandType = CommandType.Text;


                //cmd.Parameters.AddWithValue("@BorrowerID", textBox1.Text);
                cmd.Parameters.AddWithValue("@status", 1);
                cmd.Parameters.AddWithValue("@orderID", OrderID);

               

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
    }
}
