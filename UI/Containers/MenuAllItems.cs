using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResManaged3.App;
using ResManaged3.UI.Elements;

namespace ResManaged3.UI.Containers
{
    public partial class MenuAllItems : Form
    {
        public MenuAllItems()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

            MenuAllItemsApp.Populate(flowLayoutPanel1);
        }

        
    }
}
