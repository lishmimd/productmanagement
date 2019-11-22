namespace product_management
{
    partial class Viewcustomer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.linklbl_gotohome = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // linklbl_gotohome
            // 
            this.linklbl_gotohome.AutoSize = true;
            this.linklbl_gotohome.Location = new System.Drawing.Point(482, 13);
            this.linklbl_gotohome.Name = "linklbl_gotohome";
            this.linklbl_gotohome.Size = new System.Drawing.Size(64, 13);
            this.linklbl_gotohome.TabIndex = 1;
            this.linklbl_gotohome.TabStop = true;
            this.linklbl_gotohome.Text = "Go to Home";
            this.linklbl_gotohome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_gotohome_LinkClicked);
            // 
            // Viewcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 366);
            this.Controls.Add(this.linklbl_gotohome);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Viewcustomer";
            this.Text = "Viewcustomer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Viewcustomer_FormClosing);
            this.Load += new System.EventHandler(this.Viewcustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linklbl_gotohome;
    }
}