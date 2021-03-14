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
    public partial class RemoveItem : UserControl
    {
        function fn = new function();
        String query;
        public RemoveItem()
        {
            InitializeComponent();
        }

        private void RemoveItem_Load(object sender, EventArgs e)
        {
            Dellable.Text = "How to Delete ..?";
            Dellable.ForeColor = Color.Blue;
            loadData();
        }

        public void loadData()
        {
            query = "select * from items";
            DataSet dataSet = fn.getData(query);
            guna2DataGridView1.DataSource = dataSet.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txtSearch.Text + "%'";
            DataSet dataSet = fn.getData(query);
            guna2DataGridView1.DataSource = dataSet.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete item..?","Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from items where iid = " + id + "";
                fn.setData(query);
                loadData();
            }
        }

        private void Dellable_Click(object sender, EventArgs e)
        {
            Dellable.ForeColor = Color.Red;
            Dellable.Text = "*Click on Row to Delete the Item.";
        }

        private void RemoveItem_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
