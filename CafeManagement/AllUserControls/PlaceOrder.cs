using DGVPrinterHelper;
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
    public partial class PlaceOrder : UserControl
    {

        function fn = new function();
        String query;
        public PlaceOrder()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String catagory = ComboCatagory.Text;
            query = "select name from items where catagory = '" + catagory + "'";
            showItemList(query);

        }

        private void txtSeatch_TextChanged(object sender, EventArgs e)
        {
            String catagory = ComboCatagory.Text;
            query = "select name from items where catagory = '" + catagory + "' and name like '"+txtSearch.Text+"%'";
            showItemList(query);
        }

        private void showItemList(String query)
        {

            listBox1.Items.Clear();
            DataSet dataSet = fn.getData(query);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantity.ResetText();
            txtTotal.Clear();

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;
            query = "Select price from items where name = '" + text + "'";
            DataSet dataSet = fn.getData(query);


            try
            {
                txtprice.Text = dataSet.Tables[0].Rows[0][0].ToString();
            }
            catch {}
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 quant = Int64.Parse(txtQuantity.Value.ToString());
            Int64 price = Int64.Parse(txtprice.Text);
            txtTotal.Text = (quant * price).ToString();
        }

        protected int n, total = 0;

        int amount;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                total -= amount;
                labelTotalAmount.Text = "BDT. " + total;
            }
            catch
            {

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount : " + labelTotalAmount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);

            total = 0;
            guna2DataGridView1.Rows.Clear();
            labelTotalAmount.Text = "BDT. " + total;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                guna2DataGridView1.Rows[n].Cells[1].Value = txtprice.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = txtQuantity.Text;
                guna2DataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total = total + int.Parse(txtTotal.Text);
                labelTotalAmount.Text = "BDT. " + total;

            }
            else
            {
                MessageBox.Show("Minimum Quantity Need To Be 1", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
