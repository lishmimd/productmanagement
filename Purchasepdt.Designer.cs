namespace product_management
{
    partial class Purchasepdt
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
            this.btn_purchase = new System.Windows.Forms.Button();
            this.lbl_product = new System.Windows.Forms.Label();
            this.lbl_totalcost = new System.Windows.Forms.Label();
            this.lbl_quatity = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.cmb_product = new System.Windows.Forms.ComboBox();
            this.tbleaddproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productmanageDataSet1 = new product_management.productmanageDataSet1();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_totalcost = new System.Windows.Forms.TextBox();
            this.txt_quatity = new System.Windows.Forms.TextBox();
            this.lbl_rquatity = new System.Windows.Forms.Label();
            this.tble_addproductTableAdapter = new product_management.productmanageDataSet1TableAdapters.tble_addproductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbleaddproductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productmanageDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_purchase
            // 
            this.btn_purchase.Location = new System.Drawing.Point(155, 272);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(75, 23);
            this.btn_purchase.TabIndex = 0;
            this.btn_purchase.Text = "purchase";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Location = new System.Drawing.Point(98, 61);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(44, 13);
            this.lbl_product.TabIndex = 1;
            this.lbl_product.Text = "Product";
            // 
            // lbl_totalcost
            // 
            this.lbl_totalcost.AutoSize = true;
            this.lbl_totalcost.Location = new System.Drawing.Point(98, 199);
            this.lbl_totalcost.Name = "lbl_totalcost";
            this.lbl_totalcost.Size = new System.Drawing.Size(55, 13);
            this.lbl_totalcost.TabIndex = 2;
            this.lbl_totalcost.Text = "Total Cost";
            // 
            // lbl_quatity
            // 
            this.lbl_quatity.AutoSize = true;
            this.lbl_quatity.Location = new System.Drawing.Point(98, 150);
            this.lbl_quatity.Name = "lbl_quatity";
            this.lbl_quatity.Size = new System.Drawing.Size(40, 13);
            this.lbl_quatity.TabIndex = 3;
            this.lbl_quatity.Text = "Quatity";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(98, 103);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(31, 13);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price";
            // 
            // cmb_product
            // 
            this.cmb_product.DataSource = this.tbleaddproductBindingSource;
            this.cmb_product.DisplayMember = "pname";
            this.cmb_product.FormattingEnabled = true;
            this.cmb_product.Location = new System.Drawing.Point(176, 61);
            this.cmb_product.Name = "cmb_product";
            this.cmb_product.Size = new System.Drawing.Size(181, 21);
            this.cmb_product.TabIndex = 5;
            this.cmb_product.ValueMember = "pname";
            this.cmb_product.SelectedIndexChanged += new System.EventHandler(this.cmb_product_SelectedIndexChanged);
            // 
            // tbleaddproductBindingSource
            // 
            this.tbleaddproductBindingSource.DataMember = "tble_addproduct";
            this.tbleaddproductBindingSource.DataSource = this.productmanageDataSet1;
            // 
            // productmanageDataSet1
            // 
            this.productmanageDataSet1.DataSetName = "productmanageDataSet1";
            this.productmanageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(176, 103);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(181, 20);
            this.txt_price.TabIndex = 6;
            // 
            // txt_totalcost
            // 
            this.txt_totalcost.Location = new System.Drawing.Point(176, 196);
            this.txt_totalcost.Name = "txt_totalcost";
            this.txt_totalcost.Size = new System.Drawing.Size(181, 20);
            this.txt_totalcost.TabIndex = 7;
            // 
            // txt_quatity
            // 
            this.txt_quatity.Location = new System.Drawing.Point(176, 147);
            this.txt_quatity.Name = "txt_quatity";
            this.txt_quatity.Size = new System.Drawing.Size(181, 20);
            this.txt_quatity.TabIndex = 8;
            this.txt_quatity.TextChanged += new System.EventHandler(this.txt_quatity_TextChanged);
            // 
            // lbl_rquatity
            // 
            this.lbl_rquatity.AutoSize = true;
            this.lbl_rquatity.Location = new System.Drawing.Point(399, 150);
            this.lbl_rquatity.Name = "lbl_rquatity";
            this.lbl_rquatity.Size = new System.Drawing.Size(0, 13);
            this.lbl_rquatity.TabIndex = 9;
            // 
            // tble_addproductTableAdapter
            // 
            this.tble_addproductTableAdapter.ClearBeforeFill = true;
            // 
            // Purchasepdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 372);
            this.Controls.Add(this.lbl_rquatity);
            this.Controls.Add(this.txt_quatity);
            this.Controls.Add(this.txt_totalcost);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.cmb_product);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_quatity);
            this.Controls.Add(this.lbl_totalcost);
            this.Controls.Add(this.lbl_product);
            this.Controls.Add(this.btn_purchase);
            this.Name = "Purchasepdt";
            this.Text = "bu";
            this.Load += new System.EventHandler(this.Purchasepdt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbleaddproductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productmanageDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.Label lbl_totalcost;
        private System.Windows.Forms.Label lbl_quatity;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.ComboBox cmb_product;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_totalcost;
        private System.Windows.Forms.TextBox txt_quatity;
        private System.Windows.Forms.Label lbl_rquatity;
        private productmanageDataSet1 productmanageDataSet1;
        private System.Windows.Forms.BindingSource tbleaddproductBindingSource;
        private productmanageDataSet1TableAdapters.tble_addproductTableAdapter tble_addproductTableAdapter;
    }
}