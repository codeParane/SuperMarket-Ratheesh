namespace SuperMarketMS
{
    partial class StockManagement
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
            this.tpcStocks = new System.Windows.Forms.TabControl();
            this.tpcStock = new System.Windows.Forms.TabPage();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.cmbItemCategory = new System.Windows.Forms.ComboBox();
            this.dgvStocks = new System.Windows.Forms.DataGridView();
            this.tpcManageStock = new System.Windows.Forms.TabPage();
            this.msClear = new System.Windows.Forms.Button();
            this.msAddToStock = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.msQuantity = new System.Windows.Forms.NumericUpDown();
            this.msItem = new System.Windows.Forms.ComboBox();
            this.msItemCategory = new System.Windows.Forms.ComboBox();
            this.msDiscount = new System.Windows.Forms.TextBox();
            this.msSellingPrice = new System.Windows.Forms.TextBox();
            this.msCompanyPrice = new System.Windows.Forms.TextBox();
            this.msBarCode = new System.Windows.Forms.TextBox();
            this.tpcProducts = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tpcManageProducts = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tpcStocks.SuspendLayout();
            this.tpcStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            this.tpcManageStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msQuantity)).BeginInit();
            this.tpcProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpcStocks
            // 
            this.tpcStocks.Controls.Add(this.tpcStock);
            this.tpcStocks.Controls.Add(this.tpcManageStock);
            this.tpcStocks.Controls.Add(this.tpcProducts);
            this.tpcStocks.Controls.Add(this.tpcManageProducts);
            this.tpcStocks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpcStocks.Location = new System.Drawing.Point(0, 0);
            this.tpcStocks.Name = "tpcStocks";
            this.tpcStocks.SelectedIndex = 0;
            this.tpcStocks.Size = new System.Drawing.Size(741, 471);
            this.tpcStocks.TabIndex = 0;
            // 
            // tpcStock
            // 
            this.tpcStock.Controls.Add(this.cmbItem);
            this.tpcStock.Controls.Add(this.cmbItemCategory);
            this.tpcStock.Controls.Add(this.dgvStocks);
            this.tpcStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpcStock.Location = new System.Drawing.Point(4, 26);
            this.tpcStock.Name = "tpcStock";
            this.tpcStock.Padding = new System.Windows.Forms.Padding(3);
            this.tpcStock.Size = new System.Drawing.Size(733, 441);
            this.tpcStock.TabIndex = 0;
            this.tpcStock.Text = "Stocks";
            this.tpcStock.UseVisualStyleBackColor = true;
            this.tpcStock.Click += new System.EventHandler(this.tpcStock_Click);
            this.tpcStock.Enter += new System.EventHandler(this.tpcStock_Enter);
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(166, 52);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(121, 29);
            this.cmbItem.TabIndex = 2;
            // 
            // cmbItemCategory
            // 
            this.cmbItemCategory.FormattingEnabled = true;
            this.cmbItemCategory.Location = new System.Drawing.Point(8, 52);
            this.cmbItemCategory.Name = "cmbItemCategory";
            this.cmbItemCategory.Size = new System.Drawing.Size(121, 29);
            this.cmbItemCategory.TabIndex = 2;
            // 
            // dgvStocks
            // 
            this.dgvStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStocks.Location = new System.Drawing.Point(8, 87);
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.Size = new System.Drawing.Size(707, 270);
            this.dgvStocks.TabIndex = 1;
            // 
            // tpcManageStock
            // 
            this.tpcManageStock.Controls.Add(this.msClear);
            this.tpcManageStock.Controls.Add(this.msAddToStock);
            this.tpcManageStock.Controls.Add(this.label5);
            this.tpcManageStock.Controls.Add(this.label4);
            this.tpcManageStock.Controls.Add(this.label3);
            this.tpcManageStock.Controls.Add(this.label2);
            this.tpcManageStock.Controls.Add(this.label8);
            this.tpcManageStock.Controls.Add(this.label7);
            this.tpcManageStock.Controls.Add(this.label6);
            this.tpcManageStock.Controls.Add(this.label1);
            this.tpcManageStock.Controls.Add(this.msExpiryDate);
            this.tpcManageStock.Controls.Add(this.msQuantity);
            this.tpcManageStock.Controls.Add(this.msItem);
            this.tpcManageStock.Controls.Add(this.msItemCategory);
            this.tpcManageStock.Controls.Add(this.msDiscount);
            this.tpcManageStock.Controls.Add(this.msSellingPrice);
            this.tpcManageStock.Controls.Add(this.msCompanyPrice);
            this.tpcManageStock.Controls.Add(this.msBarCode);
            this.tpcManageStock.Location = new System.Drawing.Point(4, 26);
            this.tpcManageStock.Name = "tpcManageStock";
            this.tpcManageStock.Padding = new System.Windows.Forms.Padding(3);
            this.tpcManageStock.Size = new System.Drawing.Size(733, 441);
            this.tpcManageStock.TabIndex = 1;
            this.tpcManageStock.Text = "Manage Stocks";
            this.tpcManageStock.UseVisualStyleBackColor = true;
            // 
            // msClear
            // 
            this.msClear.Location = new System.Drawing.Point(216, 290);
            this.msClear.Name = "msClear";
            this.msClear.Size = new System.Drawing.Size(74, 29);
            this.msClear.TabIndex = 10;
            this.msClear.Text = "Clear";
            this.msClear.UseVisualStyleBackColor = true;
            // 
            // msAddToStock
            // 
            this.msAddToStock.Location = new System.Drawing.Point(110, 290);
            this.msAddToStock.Name = "msAddToStock";
            this.msAddToStock.Size = new System.Drawing.Size(100, 29);
            this.msAddToStock.TabIndex = 9;
            this.msAddToStock.Text = "Add to Stock";
            this.msAddToStock.UseVisualStyleBackColor = true;
            this.msAddToStock.Click += new System.EventHandler(this.msAddToStock_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Expiry Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quanitity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Discount %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Selling Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Company Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bar Code";
            // 
            // msExpiryDate
            // 
            this.msExpiryDate.CustomFormat = "yyyy - MM - dd";
            this.msExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.msExpiryDate.Location = new System.Drawing.Point(110, 246);
            this.msExpiryDate.Name = "msExpiryDate";
            this.msExpiryDate.Size = new System.Drawing.Size(180, 25);
            this.msExpiryDate.TabIndex = 8;
            // 
            // msQuantity
            // 
            this.msQuantity.Location = new System.Drawing.Point(110, 215);
            this.msQuantity.Name = "msQuantity";
            this.msQuantity.Size = new System.Drawing.Size(100, 25);
            this.msQuantity.TabIndex = 7;
            this.msQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.msQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.msQuantity.ValueChanged += new System.EventHandler(this.txtStocks_ValueChanged);
            // 
            // msItem
            // 
            this.msItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.msItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.msItem.FormattingEnabled = true;
            this.msItem.Location = new System.Drawing.Point(110, 91);
            this.msItem.Name = "msItem";
            this.msItem.Size = new System.Drawing.Size(180, 25);
            this.msItem.TabIndex = 3;
            // 
            // msItemCategory
            // 
            this.msItemCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.msItemCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.msItemCategory.FormattingEnabled = true;
            this.msItemCategory.Location = new System.Drawing.Point(110, 60);
            this.msItemCategory.Name = "msItemCategory";
            this.msItemCategory.Size = new System.Drawing.Size(180, 25);
            this.msItemCategory.TabIndex = 2;
            // 
            // msDiscount
            // 
            this.msDiscount.Location = new System.Drawing.Point(110, 184);
            this.msDiscount.Name = "msDiscount";
            this.msDiscount.Size = new System.Drawing.Size(180, 25);
            this.msDiscount.TabIndex = 6;
            this.msDiscount.Text = "0";
            this.msDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.msDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // msSellingPrice
            // 
            this.msSellingPrice.Location = new System.Drawing.Point(110, 153);
            this.msSellingPrice.Name = "msSellingPrice";
            this.msSellingPrice.Size = new System.Drawing.Size(180, 25);
            this.msSellingPrice.TabIndex = 5;
            this.msSellingPrice.Text = "0.00";
            this.msSellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.msSellingPrice.TextChanged += new System.EventHandler(this.msSellingPrice_TextChanged);
            // 
            // msCompanyPrice
            // 
            this.msCompanyPrice.Location = new System.Drawing.Point(110, 122);
            this.msCompanyPrice.Name = "msCompanyPrice";
            this.msCompanyPrice.Size = new System.Drawing.Size(180, 25);
            this.msCompanyPrice.TabIndex = 4;
            this.msCompanyPrice.Text = "0.00";
            this.msCompanyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.msCompanyPrice.TextChanged += new System.EventHandler(this.msCompanyPrice_TextChanged);
            // 
            // msBarCode
            // 
            this.msBarCode.Location = new System.Drawing.Point(110, 29);
            this.msBarCode.Name = "msBarCode";
            this.msBarCode.Size = new System.Drawing.Size(180, 25);
            this.msBarCode.TabIndex = 1;
            // 
            // tpcProducts
            // 
            this.tpcProducts.Controls.Add(this.button2);
            this.tpcProducts.Controls.Add(this.button1);
            this.tpcProducts.Controls.Add(this.label11);
            this.tpcProducts.Controls.Add(this.label10);
            this.tpcProducts.Controls.Add(this.label9);
            this.tpcProducts.Controls.Add(this.comboBox1);
            this.tpcProducts.Controls.Add(this.comboBox2);
            this.tpcProducts.Controls.Add(this.textBox3);
            this.tpcProducts.Location = new System.Drawing.Point(4, 26);
            this.tpcProducts.Name = "tpcProducts";
            this.tpcProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tpcProducts.Size = new System.Drawing.Size(733, 441);
            this.tpcProducts.TabIndex = 2;
            this.tpcProducts.Text = "Items";
            this.tpcProducts.UseVisualStyleBackColor = true;
            this.tpcProducts.Click += new System.EventHandler(this.tpcProducts_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Item";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Item Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Item Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 25);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBox2.Location = new System.Drawing.Point(122, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 25);
            this.comboBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 25);
            this.textBox3.TabIndex = 6;
            // 
            // tpcManageProducts
            // 
            this.tpcManageProducts.Location = new System.Drawing.Point(4, 26);
            this.tpcManageProducts.Name = "tpcManageProducts";
            this.tpcManageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tpcManageProducts.Size = new System.Drawing.Size(733, 441);
            this.tpcManageProducts.TabIndex = 3;
            this.tpcManageProducts.Text = "Manage Items";
            this.tpcManageProducts.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add to Items";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 483);
            this.Controls.Add(this.tpcStocks);
            this.Name = "StockManagement";
            this.Text = "StockManagement";
            this.Load += new System.EventHandler(this.StockManagement_Load);
            this.tpcStocks.ResumeLayout(false);
            this.tpcStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            this.tpcManageStock.ResumeLayout(false);
            this.tpcManageStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msQuantity)).EndInit();
            this.tpcProducts.ResumeLayout(false);
            this.tpcProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpcStocks;
        private System.Windows.Forms.TabPage tpcStock;
        private System.Windows.Forms.TabPage tpcManageStock;
        private System.Windows.Forms.TabPage tpcProducts;
        private System.Windows.Forms.TabPage tpcManageProducts;
        private System.Windows.Forms.DataGridView dgvStocks;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.ComboBox cmbItemCategory;
        private System.Windows.Forms.ComboBox msItemCategory;
        private System.Windows.Forms.TextBox msBarCode;
        private System.Windows.Forms.NumericUpDown msQuantity;
        private System.Windows.Forms.ComboBox msItem;
        private System.Windows.Forms.DateTimePicker msExpiryDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button msClear;
        private System.Windows.Forms.Button msAddToStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox msSellingPrice;
        private System.Windows.Forms.TextBox msCompanyPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox msDiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}