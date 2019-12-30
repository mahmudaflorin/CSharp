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
    public partial class OrderPalette2 : UserControl
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Edu\Programs\C#\Practice\ResManaged3\Data\ResM.mdf;Integrated Security=True";

        public OrderPalette2()
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

        public List<Label> Items
        {
            ///get { return lblItems.Text; }
            set
            {
                //Label label = new Label();
                //label.Text = value;
                //lblItems.Text = value;
                foreach (Label label in value)
                {
                    flowLayoutPanel1.Controls.Add(label);
                }

            }
        }

        //public string UserName
        //{
        //    get { return lblUsername.Text; }
        //    set { lblUsername.Text = value; }
        //}

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
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@orderID", OrderID);



                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReject_Click_1(object sender, EventArgs e)
        {

        }
    }
}
