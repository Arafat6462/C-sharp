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
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }

        int num = 0;

         private void timer1_Tick(object sender, EventArgs e)
        {
            if(num == 0)
            {
                lableBanner.Location = new Point(50, 415);
                lableBanner.ForeColor = Color.Orange;
                num++;
            }
            
            else if(num == 1)
            {
                lableBanner.Location = new Point(250, 415);
                lableBanner.ForeColor = Color.Green;
                num++;
            }
            else if(num == 2)
            {
                lableBanner.Location = new Point(450, 415);
                lableBanner.ForeColor = Color.RoyalBlue;
                num = 0;
            }
        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
