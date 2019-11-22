namespace product_management
{
    partial class Add_product
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
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_quality = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_productname = new System.Windows.Forms.Label();
            this.combobox_category = new System.Windows.Forms.ComboBox();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.txt_quality = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.linklbl_productgotohome = new System.Windows.Forms.LinkLabel();
            this.productmanageDataSet = new product_management.productmanageDataSet();
            this.tbleaddcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tble_addcategoryTableAdapter = new product_management.productmanageDataSetTableAdapters.tble_addcategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productmanageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleaddcategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(92, 49);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(55, 15);
            this.lbl_category.TabIndex = 0;
            this.lbl_category.Text = "Category";
            // 
            // lbl_quality
            // 
            this.lbl_quality.AutoSize = true;
            this.lbl_quality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quality.Location = new System.Drawing.Point(92, 234);
            this.lbl_quality.Name = "lbl_quality";
            this.lbl_quality.Size = new System.Drawing.Size(44, 15);
            this.lbl_quality.TabIndex = 2;
            this.lbl_quality.Text = "Quality";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(112, 172);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(35, 15);
            this.lbl_price.TabIndex = 3;
            this.lbl_price.Text = "Price";
            // 
            // lbl_productname
            // 
            this.lbl_productname.AutoSize = true;
            this.lbl_productname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productname.Location = new System.Drawing.Point(61, 113);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(86, 15);
            this.lbl_productname.TabIndex = 4;
            this.lbl_productname.Text = "Product Name";
            // 
            // combobox_category
            // 
            this.combobox_category.DataSource = this.tbleaddcategoryBindingSource;
            this.combobox_category.DisplayMember = "category";
            this.combobox_category.FormattingEnabled = true;
            this.combobox_category.Location = new System.Drawing.Point(178, 48);
            this.combobox_category.Name = "combobox_category";
            this.combobox_category.Size = new System.Drawing.Size(199, 21);
            this.combobox_category.TabIndex = 5;
            this.combobox_category.ValueMember = "category";
            // 
            // txt_productname
            // 
            this.txt_productname.Location = new System.Drawing.Point(178, 112);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(199, 20);
            this.txt_productname.TabIndex = 6;
            // 
            // txt_quality
            // 
            this.txt_quality.Location = new System.Drawing.Point(178, 233);
            this.txt_quality.Name = "txt_quality";
            this.txt_quality.Size = new System.Drawing.Size(199, 20);
            this.txt_quality.TabIndex = 7;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(178, 172);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(199, 20);
            this.txt_price.TabIndex = 8;
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.Location = new System.Drawing.Point(167, 315);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(75, 23);
            this.btn_addproduct.TabIndex = 9;
            this.btn_addproduct.Text = "ADD";
            this.btn_addproduct.UseVisualStyleBackColor = true;
            this.btn_addproduct.Click += new System.EventHandler(this.btn_addproduct_Click);
            // 
            // linklbl_productgotohome
            // 
            this.linklbl_productgotohome.AutoSize = true;
            this.linklbl_productgotohome.Location = new System.Drawing.Point(335, 9);
            this.linklbl_productgotohome.Name = "linklbl_productgotohome";
            this.linklbl_productgotohome.Size = new System.Drawing.Size(64, 13);
            this.linklbl_productgotohome.TabIndex = 10;
            this.linklbl_productgotohome.TabStop = true;
            this.linklbl_productgotohome.Text = "Go to Home";
            this.linklbl_productgotohome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_productgotohome_LinkClicked);
            // 
            // productmanageDataSet
            // 
            this.productmanageDataSet.DataSetName = "productmanageDataSet";
            this.productmanageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbleaddcategoryBindingSource
            // 
            this.tbleaddcategoryBindingSource.DataMember = "tble_addcategory";
            this.tbleaddcategoryBindingSource.DataSource = this.productmanageDataSet;
            // 
            // tble_addcategoryTableAdapter
            // 
            this.tble_addcategoryTableAdapter.ClearBeforeFill = true;
            // 
            // Add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 424);
            this.Controls.Add(this.linklbl_productgotohome);
            this.Controls.Add(this.btn_addproduct);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_quality);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.combobox_category);
            this.Controls.Add(this.lbl_productname);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_quality);
            this.Controls.Add(this.lbl_category);
            this.Name = "Add_product";
            this.Text = "Add_product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_product_FormClosing);
            this.Load += new System.EventHandler(this.Add_product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productmanageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleaddcategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_quality;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_productname;
        private System.Windows.Forms.ComboBox combobox_category;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.TextBox txt_quality;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_addproduct;
        private System.Windows.Forms.LinkLabel linklbl_productgotohome;
        private productmanageDataSet productmanageDataSet;
        private System.Windows.Forms.BindingSource tbleaddcategoryBindingSource;
        private productmanageDataSetTableAdapters.tble_addcategoryTableAdapter tble_addcategoryTableAdapter;
    }
}