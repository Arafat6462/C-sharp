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

        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
