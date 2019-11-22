namespace product_management
{
    partial class Admin_home
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
            this.linklbl_addcategory = new System.Windows.Forms.LinkLabel();
            this.linklbl_viewcustomer = new System.Windows.Forms.LinkLabel();
            this.linklbl_addproduct = new System.Windows.Forms.LinkLabel();
            this.linklbl_viewph = new System.Windows.Forms.LinkLabel();
            this.linklbl_logout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linklbl_addcategory
            // 
            this.linklbl_addcategory.AutoSize = true;
            this.linklbl_addcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_addcategory.Location = new System.Drawing.Point(133, 75);
            this.linklbl_addcategory.Name = "linklbl_addcategory";
            this.linklbl_addcategory.Size = new System.Drawing.Size(91, 16);
            this.linklbl_addcategory.TabIndex = 0;
            this.linklbl_addcategory.TabStop = true;
            this.linklbl_addcategory.Text = "Add Category";
            this.linklbl_addcategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_addcategory_LinkClicked);
            // 
            // linklbl_viewcustomer
            // 
            this.linklbl_viewcustomer.AutoSize = true;
            this.linklbl_viewcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_viewcustomer.Location = new System.Drawing.Point(133, 195);
            this.linklbl_viewcustomer.Name = "linklbl_viewcustomer";
            this.linklbl_viewcustomer.Size = new System.Drawing.Size(97, 16);
            this.linklbl_viewcustomer.TabIndex = 1;
            this.linklbl_viewcustomer.TabStop = true;
            this.linklbl_viewcustomer.Text = "View Customer";
            this.linklbl_viewcustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_viewcustomer_LinkClicked);
            // 
            // linklbl_addproduct
            // 
            this.linklbl_addproduct.AutoSize = true;
            this.linklbl_addproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_addproduct.Location = new System.Drawing.Point(133, 134);
            this.linklbl_addproduct.Name = "linklbl_addproduct";
            this.linklbl_addproduct.Size = new System.Drawing.Size(82, 16);
            this.linklbl_addproduct.TabIndex = 2;
            this.linklbl_addproduct.TabStop = true;
            this.linklbl_addproduct.Text = "Add Product";
            this.linklbl_addproduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_addproduct_LinkClicked);
            // 
            // linklbl_viewph
            // 
            this.linklbl_viewph.AutoSize = true;
            this.linklbl_viewph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_viewph.Location = new System.Drawing.Point(105, 260);
            this.linklbl_viewph.Name = "linklbl_viewph";
            this.linklbl_viewph.Size = new System.Drawing.Size(142, 16);
            this.linklbl_viewph.TabIndex = 3;
            this.linklbl_viewph.TabStop = true;
            this.linklbl_viewph.Text = "View Purchase History";
            this.linklbl_viewph.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_viewph_LinkClicked);
            // 
            // linklbl_logout
            // 
            this.linklbl_logout.AutoSize = true;
            this.linklbl_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_logout.Location = new System.Drawing.Point(151, 325);
            this.linklbl_logout.Name = "linklbl_logout";
            this.linklbl_logout.Size = new System.Drawing.Size(49, 16);
            this.linklbl_logout.TabIndex = 4;
            this.linklbl_logout.TabStop = true;
            this.linklbl_logout.Text = "Logout";
            this.linklbl_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_logout_LinkClicked);
            // 
            // Admin_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.linklbl_logout);
            this.Controls.Add(this.linklbl_viewph);
            this.Controls.Add(this.linklbl_addproduct);
            this.Controls.Add(this.linklbl_viewcustomer);
            this.Controls.Add(this.linklbl_addcategory);
            this.Name = "Admin_home";
            this.Text = "Admin_home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_home_FormClosing);
            this.Load += new System.EventHandler(this.Admin_home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklbl_addcategory;
        private System.Windows.Forms.LinkLabel linklbl_viewcustomer;
        private System.Windows.Forms.LinkLabel linklbl_addproduct;
        private System.Windows.Forms.LinkLabel linklbl_viewph;
        private System.Windows.Forms.LinkLabel linklbl_logout;
    }
}