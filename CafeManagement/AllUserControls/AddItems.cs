using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.AllUserControls
{
    public partial class AddItems : UserControl
    {
        function fn = new function();
        String query;
        public AddItems()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into items (name,catagory,price) values ('" + txtItemName.Text + "','" + txtCatagory.Text + "'," + txtPrice.Text + ")";
            fn.setData(query);
            clearAll();
        }

        public void clearAll()
        {
            txtCatagory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void AddItems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
