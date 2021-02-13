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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        } 
        
        public Dashboard( String user)
        {
            InitializeComponent();
            if(user == "Guest")
            {
                btnAddItems.Hide();
                btnUpdateItems.Hide();
                btnRemoveItems.Hide();
            }

            else if(user == "Admin")
            {
                btnAddItems.Show();
                btnUpdateItems.Show();
                btnRemoveItems.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            removeItem1.Visible = true;
            removeItem1.BringToFront();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            addItems1.Visible = true;
            addItems1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            addItems1.Visible = false;
            placeOrder1.Visible = false;
            updateItems1.Visible = false;
            removeItem1.Visible = false;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(placeOrder1);
            placeOrder1.Visible = true;
            placeOrder1.BringToFront();
        }

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {
            updateItems1.Visible = true;
            updateItems1.BringToFront();
        }

        private void updateItems1_Load(object sender, EventArgs e)
        {

        }
    }
}
