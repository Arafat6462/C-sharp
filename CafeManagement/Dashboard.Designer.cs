
namespace CafeManagement
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLogOut = new System.Windows.Forms.LinkLabel();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnRemoveItems = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateItems = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddItems = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlaceOrder = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updateItems1 = new CafeManagement.UpdateItems();
            this.placeOrder1 = new CafeManagement.AllUserControls.PlaceOrder();
            this.addItems1 = new CafeManagement.AllUserControls.AddItems();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uC_Welcome1 = new CafeManagement.AllUserControls.UC_Welcome();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.removeItem1 = new CafeManagement.AllUserControls.RemoveItem();
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnRemoveItems);
            this.panel1.Controls.Add(this.btnUpdateItems);
            this.panel1.Controls.Add(this.btnAddItems);
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 700);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePicker1
            // 
            this.guna2Transition1.SetDecoration(this.dateTimePicker1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 601);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.btnLogOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.LinkColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(160, 631);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(82, 25);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.TabStop = true;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogOut_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.guna2Transition1.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.TextFormatNoPrefix = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.Animated = true;
            this.btnRemoveItems.AutoRoundedCorners = true;
            this.btnRemoveItems.BorderColor = System.Drawing.Color.White;
            this.btnRemoveItems.BorderRadius = 21;
            this.btnRemoveItems.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnRemoveItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRemoveItems.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRemoveItems.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnRemoveItems.CheckedState.Parent = this.btnRemoveItems;
            this.btnRemoveItems.CustomImages.Parent = this.btnRemoveItems;
            this.guna2Transition1.SetDecoration(this.btnRemoveItems, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRemoveItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnRemoveItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnRemoveItems.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItems.HoverState.Parent = this.btnRemoveItems;
            this.btnRemoveItems.Location = new System.Drawing.Point(131, 265);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.ShadowDecoration.Parent = this.btnRemoveItems;
            this.btnRemoveItems.Size = new System.Drawing.Size(180, 45);
            this.btnRemoveItems.TabIndex = 1;
            this.btnRemoveItems.Text = "Remove Items";
            this.btnRemoveItems.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // btnUpdateItems
            // 
            this.btnUpdateItems.Animated = true;
            this.btnUpdateItems.AutoRoundedCorners = true;
            this.btnUpdateItems.BorderColor = System.Drawing.Color.White;
            this.btnUpdateItems.BorderRadius = 21;
            this.btnUpdateItems.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnUpdateItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateItems.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdateItems.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdateItems.CheckedState.Parent = this.btnUpdateItems;
            this.btnUpdateItems.CustomImages.Parent = this.btnUpdateItems;
            this.guna2Transition1.SetDecoration(this.btnUpdateItems, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUpdateItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdateItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnUpdateItems.ForeColor = System.Drawing.Color.White;
            this.btnUpdateItems.HoverState.Parent = this.btnUpdateItems;
            this.btnUpdateItems.Location = new System.Drawing.Point(131, 197);
            this.btnUpdateItems.Name = "btnUpdateItems";
            this.btnUpdateItems.ShadowDecoration.Parent = this.btnUpdateItems;
            this.btnUpdateItems.Size = new System.Drawing.Size(180, 45);
            this.btnUpdateItems.TabIndex = 1;
            this.btnUpdateItems.Text = "Update Items";
            this.btnUpdateItems.Click += new System.EventHandler(this.btnUpdateItems_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.Animated = true;
            this.btnAddItems.AutoRoundedCorners = true;
            this.btnAddItems.BorderColor = System.Drawing.Color.White;
            this.btnAddItems.BorderRadius = 21;
            this.btnAddItems.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnAddItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddItems.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddItems.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddItems.CheckedState.Parent = this.btnAddItems;
            this.btnAddItems.CustomImages.Parent = this.btnAddItems;
            this.guna2Transition1.SetDecoration(this.btnAddItems, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAddItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAddItems.ForeColor = System.Drawing.Color.White;
            this.btnAddItems.HoverState.Parent = this.btnAddItems;
            this.btnAddItems.Location = new System.Drawing.Point(131, 129);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.ShadowDecoration.Parent = this.btnAddItems;
            this.btnAddItems.Size = new System.Drawing.Size(180, 45);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Animated = true;
            this.btnPlaceOrder.AutoRoundedCorners = true;
            this.btnPlaceOrder.BorderColor = System.Drawing.Color.White;
            this.btnPlaceOrder.BorderRadius = 21;
            this.btnPlaceOrder.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnPlaceOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPlaceOrder.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPlaceOrder.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnPlaceOrder.CheckedState.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.CustomImages.Parent = this.btnPlaceOrder;
            this.guna2Transition1.SetDecoration(this.btnPlaceOrder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPlaceOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.HoverState.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.Location = new System.Drawing.Point(131, 59);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.ShadowDecoration.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.Size = new System.Drawing.Size(180, 45);
            this.btnPlaceOrder.TabIndex = 1;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.removeItem1);
            this.panel2.Controls.Add(this.updateItems1);
            this.panel2.Controls.Add(this.placeOrder1);
            this.panel2.Controls.Add(this.addItems1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.uC_Welcome1);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(322, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 706);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // updateItems1
            // 
            this.guna2Transition1.SetDecoration(this.updateItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.updateItems1.Location = new System.Drawing.Point(11, -1);
            this.updateItems1.Name = "updateItems1";
            this.updateItems1.Size = new System.Drawing.Size(1093, 701);
            this.updateItems1.TabIndex = 4;
            this.updateItems1.Load += new System.EventHandler(this.updateItems1_Load);
            // 
            // placeOrder1
            // 
            this.guna2Transition1.SetDecoration(this.placeOrder1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.placeOrder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrder1.Location = new System.Drawing.Point(4, 4);
            this.placeOrder1.Margin = new System.Windows.Forms.Padding(4);
            this.placeOrder1.Name = "placeOrder1";
            this.placeOrder1.Size = new System.Drawing.Size(1093, 701);
            this.placeOrder1.TabIndex = 3;
            // 
            // addItems1
            // 
            this.guna2Transition1.SetDecoration(this.addItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.addItems1.Location = new System.Drawing.Point(11, 19);
            this.addItems1.Name = "addItems1";
            this.addItems1.Size = new System.Drawing.Size(1092, 668);
            this.addItems1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.guna2Transition1.SetDecoration(this.groupBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(471, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(18, 25);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // uC_Welcome1
            // 
            this.guna2Transition1.SetDecoration(this.uC_Welcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Welcome1.Location = new System.Drawing.Point(11, 19);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(923, 478);
            this.uC_Welcome1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation3;
            this.guna2Transition1.MaxAnimationTime = 3000;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // removeItem1
            // 
            this.guna2Transition1.SetDecoration(this.removeItem1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.removeItem1.Location = new System.Drawing.Point(3, 2);
            this.removeItem1.Name = "removeItem1";
            this.removeItem1.Size = new System.Drawing.Size(1093, 701);
            this.removeItem1.TabIndex = 5;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 30;
            this.guna2Elipse7.TargetControl = this.panel2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1437, 718);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnPlaceOrder;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Button btnRemoveItems;
        private Guna.UI2.WinForms.Guna2Button btnUpdateItems;
        private Guna.UI2.WinForms.Guna2Button btnAddItems;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.LinkLabel btnLogOut;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControls.UC_Welcome uC_Welcome1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControls.AddItems addItems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private AllUserControls.PlaceOrder placeOrder1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private UpdateItems updateItems1;
        private AllUserControls.RemoveItem removeItem1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
    }
}