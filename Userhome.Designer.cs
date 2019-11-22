namespace product_management
{
    partial class lbl_fullname
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.linklbl_eprofile = new System.Windows.Forms.LinkLabel();
            this.linklbl_viewph = new System.Windows.Forms.LinkLabel();
            this.linklbl_purchasepdt = new System.Windows.Forms.LinkLabel();
            this.linklbl_logout = new System.Windows.Forms.LinkLabel();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(66, 54);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(94, 18);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "WELCOME";
            // 
            // linklbl_eprofile
            // 
            this.linklbl_eprofile.AutoSize = true;
            this.linklbl_eprofile.Location = new System.Drawing.Point(53, 169);
            this.linklbl_eprofile.Name = "linklbl_eprofile";
            this.linklbl_eprofile.Size = new System.Drawing.Size(56, 13);
            this.linklbl_eprofile.TabIndex = 2;
            this.linklbl_eprofile.TabStop = true;
            this.linklbl_eprofile.Text = "Edit profile";
            this.linklbl_eprofile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_eprofile_LinkClicked);
            // 
            // linklbl_viewph
            // 
            this.linklbl_viewph.AutoSize = true;
            this.linklbl_viewph.Location = new System.Drawing.Point(320, 169);
            this.linklbl_viewph.Name = "linklbl_viewph";
            this.linklbl_viewph.Size = new System.Drawing.Size(110, 13);
            this.linklbl_viewph.TabIndex = 3;
            this.linklbl_viewph.TabStop = true;
            this.linklbl_viewph.Text = "View purchase history";
            // 
            // linklbl_purchasepdt
            // 
            this.linklbl_purchasepdt.AutoSize = true;
            this.linklbl_purchasepdt.Location = new System.Drawing.Point(178, 169);
            this.linklbl_purchasepdt.Name = "linklbl_purchasepdt";
            this.linklbl_purchasepdt.Size = new System.Drawing.Size(91, 13);
            this.linklbl_purchasepdt.TabIndex = 4;
            this.linklbl_purchasepdt.TabStop = true;
            this.linklbl_purchasepdt.Text = "Purchase product";
            this.linklbl_purchasepdt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_purchasepdt_LinkClicked);
            // 
            // linklbl_logout
            // 
            this.linklbl_logout.AutoSize = true;
            this.linklbl_logout.Location = new System.Drawing.Point(199, 257);
            this.linklbl_logout.Name = "linklbl_logout";
            this.linklbl_logout.Size = new System.Drawing.Size(40, 13);
            this.linklbl_logout.TabIndex = 5;
            this.linklbl_logout.TabStop = true;
            this.linklbl_logout.Text = "Logout";
            this.linklbl_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_logout_LinkClicked);
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.Location = new System.Drawing.Point(257, 54);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(0, 18);
            this.lbl_fname.TabIndex = 6;
            // 
            // lbl_fullname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.linklbl_logout);
            this.Controls.Add(this.linklbl_purchasepdt);
            this.Controls.Add(this.linklbl_viewph);
            this.Controls.Add(this.linklbl_eprofile);
            this.Controls.Add(this.lbl_welcome);
            this.Name = "lbl_fullname";
            this.Text = "Userhome";
            this.Load += new System.EventHandler(this.lbl_fullname_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.LinkLabel linklbl_eprofile;
        private System.Windows.Forms.LinkLabel linklbl_viewph;
        private System.Windows.Forms.LinkLabel linklbl_purchasepdt;
        private System.Windows.Forms.LinkLabel linklbl_logout;
        private System.Windows.Forms.Label lbl_fname;
    }
}