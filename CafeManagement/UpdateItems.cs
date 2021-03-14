using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class UpdateItems : UserControl
    {
        function fn = new function();
        String query;
        public UpdateItems()
        {
            InitializeComponent();
        }

        private void UpdateItems_Load(object sender, EventArgs e)
        {
            query = "select * from items";
            loadData(query);
        }

        public void loadData(String query)
        {
            DataSet dataSet = fn.getData(query);
            guna2DataGridView1.DataSource = dataSet.Tables[0];
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" +txtSearchItem.Text + "%'";
            loadData(query);

        }

        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String catagory = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtCatagory.Text = catagory;
            txtItemName.Text = name;
            txtPrice.Text = price.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "update items set name = '" + txtItemName.Text+ "', catagory = '" + txtCatagory.Text + "', price = " + txtPrice.Text + "where iid = "+id+"";
            fn.setData(query);
            loadData("select * from items");

            txtItemName.Clear();
            txtCatagory.Clear();
            txtPrice.Clear();
        }
    }
}
