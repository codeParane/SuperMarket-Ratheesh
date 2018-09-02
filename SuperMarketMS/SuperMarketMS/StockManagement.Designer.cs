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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tpcStocks = new System.Windows.Forms.TabControl();
            this.tpcStock = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbStocksItem = new System.Windows.Forms.ComboBox();
            this.cmbStoksItemCat = new System.Windows.Forms.ComboBox();
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
            this.cmbMgStocksItem = new System.Windows.Forms.ComboBox();
            this.cmbMgStocksItemCat = new System.Windows.Forms.ComboBox();
            this.msDiscount = new System.Windows.Forms.TextBox();
            this.msSellingPrice = new System.Windows.Forms.TextBox();
            this.msCompanyPrice = new System.Windows.Forms.TextBox();
            this.msBarCode = new System.Windows.Forms.TextBox();
            this.tpcProducts = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.isWeight = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.iItemCategory = new System.Windows.Forms.ComboBox();
            this.iIsWeight = new System.Windows.Forms.ComboBox();
            this.iItemName = new System.Windows.Forms.TextBox();
            this.tpcManageProducts = new System.Windows.Forms.TabPage();
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
            this.tpcStock.Controls.Add(this.label12);
            this.tpcStock.Controls.Add(this.label11);
            this.tpcStock.Controls.Add(this.cmbStocksItem);
            this.tpcStock.Controls.Add(this.cmbStoksItemCat);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Items";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Items Category";
            // 
            // cmbStocksItem
            // 
            this.cmbStocksItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStocksItem.FormattingEnabled = true;
            this.cmbStocksItem.Items.AddRange(new object[] {
            "-SELECT-"});
            this.cmbStocksItem.Location = new System.Drawing.Point(117, 41);
            this.cmbStocksItem.Name = "cmbStocksItem";
            this.cmbStocksItem.Size = new System.Drawing.Size(246, 25);
            this.cmbStocksItem.TabIndex = 2;
            this.cmbStocksItem.SelectedIndexChanged += new System.EventHandler(this.cmbStocksItem_SelectedIndexChanged);
            // 
            // cmbStoksItemCat
            // 
            this.cmbStoksItemCat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStoksItemCat.FormattingEnabled = true;
            this.cmbStoksItemCat.Location = new System.Drawing.Point(117, 6);
            this.cmbStoksItemCat.Name = "cmbStoksItemCat";
            this.cmbStoksItemCat.Size = new System.Drawing.Size(246, 25);
            this.cmbStoksItemCat.TabIndex = 2;
            this.cmbStoksItemCat.SelectedIndexChanged += new System.EventHandler(this.cmbItemCategory_SelectedIndexChanged);
            // 
            // dgvStocks
            // 
            this.dgvStocks.AllowUserToAddRows = false;
            this.dgvStocks.AllowUserToDeleteRows = false;
            this.dgvStocks.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(244)))));
            this.dgvStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStocks.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(216)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStocks.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvStocks.Location = new System.Drawing.Point(8, 76);
            this.dgvStocks.Name = "dgvStocks";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStocks.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvStocks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStocks.Size = new System.Drawing.Size(707, 344);
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
            this.tpcManageStock.Controls.Add(this.cmbMgStocksItem);
            this.tpcManageStock.Controls.Add(this.cmbMgStocksItemCat);
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
            this.tpcManageStock.Enter += new System.EventHandler(this.tpcManageStock_Enter_1);
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
            this.msExpiryDate.CustomFormat = "yyyy/MM/dd";
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
            // cmbMgStocksItem
            // 
            this.cmbMgStocksItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMgStocksItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMgStocksItem.FormattingEnabled = true;
            this.cmbMgStocksItem.Location = new System.Drawing.Point(110, 91);
            this.cmbMgStocksItem.Name = "cmbMgStocksItem";
            this.cmbMgStocksItem.Size = new System.Drawing.Size(180, 25);
            this.cmbMgStocksItem.TabIndex = 3;
            // 
            // cmbMgStocksItemCat
            // 
            this.cmbMgStocksItemCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMgStocksItemCat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMgStocksItemCat.FormattingEnabled = true;
            this.cmbMgStocksItemCat.Location = new System.Drawing.Point(110, 60);
            this.cmbMgStocksItemCat.Name = "cmbMgStocksItemCat";
            this.cmbMgStocksItemCat.Size = new System.Drawing.Size(180, 25);
            this.cmbMgStocksItemCat.TabIndex = 2;
            this.cmbMgStocksItemCat.SelectedIndexChanged += new System.EventHandler(this.cmbMgStocksItemCat_SelectedIndexChanged);
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
            this.tpcProducts.Controls.Add(this.isWeight);
            this.tpcProducts.Controls.Add(this.label10);
            this.tpcProducts.Controls.Add(this.label9);
            this.tpcProducts.Controls.Add(this.iItemCategory);
            this.tpcProducts.Controls.Add(this.iIsWeight);
            this.tpcProducts.Controls.Add(this.iItemName);
            this.tpcProducts.Location = new System.Drawing.Point(4, 26);
            this.tpcProducts.Name = "tpcProducts";
            this.tpcProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tpcProducts.Size = new System.Drawing.Size(733, 441);
            this.tpcProducts.TabIndex = 2;
            this.tpcProducts.Text = "Items";
            this.tpcProducts.UseVisualStyleBackColor = true;
            this.tpcProducts.Click += new System.EventHandler(this.tpcProducts_Click);
            this.tpcProducts.Enter += new System.EventHandler(this.tpcProducts_Enter);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // isWeight
            // 
            this.isWeight.AutoSize = true;
            this.isWeight.Location = new System.Drawing.Point(20, 88);
            this.isWeight.Name = "isWeight";
            this.isWeight.Size = new System.Drawing.Size(65, 17);
            this.isWeight.TabIndex = 9;
            this.isWeight.Text = "is Weight";
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
            // iItemCategory
            // 
            this.iItemCategory.FormattingEnabled = true;
            this.iItemCategory.Location = new System.Drawing.Point(122, 49);
            this.iItemCategory.Name = "iItemCategory";
            this.iItemCategory.Size = new System.Drawing.Size(180, 25);
            this.iItemCategory.TabIndex = 7;
            // 
            // iIsWeight
            // 
            this.iIsWeight.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.iIsWeight.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.iIsWeight.FormattingEnabled = true;
            this.iIsWeight.Items.AddRange(new object[] {
            "True",
            "False"});
            this.iIsWeight.Location = new System.Drawing.Point(122, 84);
            this.iIsWeight.Name = "iIsWeight";
            this.iIsWeight.Size = new System.Drawing.Size(180, 25);
            this.iIsWeight.TabIndex = 8;
            // 
            // iItemName
            // 
            this.iItemName.Location = new System.Drawing.Point(122, 18);
            this.iItemName.Name = "iItemName";
            this.iItemName.Size = new System.Drawing.Size(180, 25);
            this.iItemName.TabIndex = 6;
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
            // StockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(774, 483);
            this.Controls.Add(this.tpcStocks);
            this.Name = "StockManagement";
            this.Text = "StockManagement";
            this.Load += new System.EventHandler(this.StockManagement_Load);
            this.tpcStocks.ResumeLayout(false);
            this.tpcStock.ResumeLayout(false);
            this.tpcStock.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbStocksItem;
        private System.Windows.Forms.ComboBox cmbStoksItemCat;
        private System.Windows.Forms.ComboBox cmbMgStocksItemCat;
        private System.Windows.Forms.TextBox msBarCode;
        private System.Windows.Forms.NumericUpDown msQuantity;
        private System.Windows.Forms.ComboBox cmbMgStocksItem;
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
        private System.Windows.Forms.Label isWeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox iItemCategory;
        private System.Windows.Forms.ComboBox iIsWeight;
        private System.Windows.Forms.TextBox iItemName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}