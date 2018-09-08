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
            this.msStockTotal = new System.Windows.Forms.TextBox();
            this.msInHand = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.msCmbMgStocksItem = new System.Windows.Forms.ComboBox();
            this.msCmbMgStocksItemCat = new System.Windows.Forms.ComboBox();
            this.msDiscount = new System.Windows.Forms.TextBox();
            this.msSellingPrice = new System.Windows.Forms.TextBox();
            this.msCompanyPrice = new System.Windows.Forms.TextBox();
            this.msBarCode = new System.Windows.Forms.TextBox();
            this.tpcProducts = new System.Windows.Forms.TabPage();
            this.iItemName = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.isWeight = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.iItemCategory = new System.Windows.Forms.ComboBox();
            this.iIsWeight = new System.Windows.Forms.ComboBox();
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
            this.tpcStocks.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpcStocks.Location = new System.Drawing.Point(0, 0);
            this.tpcStocks.Name = "tpcStocks";
            this.tpcStocks.SelectedIndex = 0;
            this.tpcStocks.Size = new System.Drawing.Size(1048, 630);
            this.tpcStocks.TabIndex = 0;
            // 
            // tpcStock
            // 
            this.tpcStock.BackColor = System.Drawing.Color.Transparent;
            this.tpcStock.Controls.Add(this.label12);
            this.tpcStock.Controls.Add(this.label11);
            this.tpcStock.Controls.Add(this.cmbStocksItem);
            this.tpcStock.Controls.Add(this.cmbStoksItemCat);
            this.tpcStock.Controls.Add(this.dgvStocks);
            this.tpcStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpcStock.Location = new System.Drawing.Point(4, 41);
            this.tpcStock.Name = "tpcStock";
            this.tpcStock.Padding = new System.Windows.Forms.Padding(3);
            this.tpcStock.Size = new System.Drawing.Size(1040, 585);
            this.tpcStock.TabIndex = 0;
            this.tpcStock.Text = "Stocks";
            this.tpcStock.Click += new System.EventHandler(this.tpcStock_Click);
            this.tpcStock.Enter += new System.EventHandler(this.tpcStock_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 21);
            this.label12.TabIndex = 3;
            this.label12.Text = "Items";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "Items Category";
            // 
            // cmbStocksItem
            // 
            this.cmbStocksItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStocksItem.FormattingEnabled = true;
            this.cmbStocksItem.Items.AddRange(new object[] {
            "-SELECT-"});
            this.cmbStocksItem.Location = new System.Drawing.Point(149, 59);
            this.cmbStocksItem.Name = "cmbStocksItem";
            this.cmbStocksItem.Size = new System.Drawing.Size(246, 29);
            this.cmbStocksItem.TabIndex = 2;
            this.cmbStocksItem.SelectedIndexChanged += new System.EventHandler(this.cmbStocksItem_SelectedIndexChanged);
            // 
            // cmbStoksItemCat
            // 
            this.cmbStoksItemCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStoksItemCat.FormattingEnabled = true;
            this.cmbStoksItemCat.Location = new System.Drawing.Point(149, 21);
            this.cmbStoksItemCat.Name = "cmbStoksItemCat";
            this.cmbStoksItemCat.Size = new System.Drawing.Size(246, 29);
            this.cmbStoksItemCat.TabIndex = 2;
            this.cmbStoksItemCat.SelectedIndexChanged += new System.EventHandler(this.cmbItemCategory_SelectedIndexChanged);
            // 
            // dgvStocks
            // 
            this.dgvStocks.AllowUserToAddRows = false;
            this.dgvStocks.AllowUserToDeleteRows = false;
            this.dgvStocks.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStocks.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvStocks.Location = new System.Drawing.Point(30, 108);
            this.dgvStocks.Name = "dgvStocks";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStocks.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvStocks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStocks.Size = new System.Drawing.Size(951, 471);
            this.dgvStocks.TabIndex = 1;
            // 
            // tpcManageStock
            // 
            this.tpcManageStock.BackColor = System.Drawing.Color.Transparent;
            this.tpcManageStock.Controls.Add(this.msStockTotal);
            this.tpcManageStock.Controls.Add(this.msInHand);
            this.tpcManageStock.Controls.Add(this.label14);
            this.tpcManageStock.Controls.Add(this.label13);
            this.tpcManageStock.Controls.Add(this.button4);
            this.tpcManageStock.Controls.Add(this.button3);
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
            this.tpcManageStock.Controls.Add(this.msCmbMgStocksItem);
            this.tpcManageStock.Controls.Add(this.msCmbMgStocksItemCat);
            this.tpcManageStock.Controls.Add(this.msDiscount);
            this.tpcManageStock.Controls.Add(this.msSellingPrice);
            this.tpcManageStock.Controls.Add(this.msCompanyPrice);
            this.tpcManageStock.Controls.Add(this.msBarCode);
            this.tpcManageStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpcManageStock.Location = new System.Drawing.Point(4, 41);
            this.tpcManageStock.Name = "tpcManageStock";
            this.tpcManageStock.Padding = new System.Windows.Forms.Padding(3);
            this.tpcManageStock.Size = new System.Drawing.Size(1040, 585);
            this.tpcManageStock.TabIndex = 1;
            this.tpcManageStock.Text = "Manage Stocks";
            this.tpcManageStock.Click += new System.EventHandler(this.tpcManageStock_Click);
            this.tpcManageStock.Enter += new System.EventHandler(this.tpcManageStock_Enter_1);
            // 
            // msStockTotal
            // 
            this.msStockTotal.Enabled = false;
            this.msStockTotal.Location = new System.Drawing.Point(496, 235);
            this.msStockTotal.Name = "msStockTotal";
            this.msStockTotal.Size = new System.Drawing.Size(72, 29);
            this.msStockTotal.TabIndex = 16;
            this.msStockTotal.Text = "0";
            this.msStockTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // msInHand
            // 
            this.msInHand.Enabled = false;
            this.msInHand.Location = new System.Drawing.Point(370, 236);
            this.msInHand.Name = "msInHand";
            this.msInHand.Size = new System.Drawing.Size(72, 29);
            this.msInHand.TabIndex = 15;
            this.msInHand.Text = "0";
            this.msInHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.msInHand.TextChanged += new System.EventHandler(this.msInHand_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(448, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 21);
            this.label14.TabIndex = 14;
            this.label14.Text = "Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(300, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 21);
            this.label13.TabIndex = 13;
            this.label13.Text = "In Hand";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 70);
            this.button4.TabIndex = 12;
            this.button4.Text = "Delete Stock";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(384, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 70);
            this.button3.TabIndex = 11;
            this.button3.Text = "Update Stock";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // msClear
            // 
            this.msClear.Location = new System.Drawing.Point(159, 331);
            this.msClear.Name = "msClear";
            this.msClear.Size = new System.Drawing.Size(90, 70);
            this.msClear.TabIndex = 10;
            this.msClear.Text = "Clear";
            this.msClear.UseVisualStyleBackColor = true;
            this.msClear.Click += new System.EventHandler(this.msClear_Click);
            // 
            // msAddToStock
            // 
            this.msAddToStock.Location = new System.Drawing.Point(34, 331);
            this.msAddToStock.Name = "msAddToStock";
            this.msAddToStock.Size = new System.Drawing.Size(119, 70);
            this.msAddToStock.TabIndex = 9;
            this.msAddToStock.Text = "Add to Stock";
            this.msAddToStock.UseVisualStyleBackColor = true;
            this.msAddToStock.Click += new System.EventHandler(this.msAddToStock_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Expiry Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quanitity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Discount %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Selling Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Company Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bar Code";
            // 
            // msExpiryDate
            // 
            this.msExpiryDate.CustomFormat = "yyyy/MM/dd";
            this.msExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.msExpiryDate.Location = new System.Drawing.Point(176, 271);
            this.msExpiryDate.Name = "msExpiryDate";
            this.msExpiryDate.Size = new System.Drawing.Size(118, 29);
            this.msExpiryDate.TabIndex = 8;
            // 
            // msQuantity
            // 
            this.msQuantity.Location = new System.Drawing.Point(176, 236);
            this.msQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.msQuantity.Name = "msQuantity";
            this.msQuantity.Size = new System.Drawing.Size(118, 29);
            this.msQuantity.TabIndex = 7;
            this.msQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.msQuantity.ValueChanged += new System.EventHandler(this.txtStocks_ValueChanged);
            // 
            // msCmbMgStocksItem
            // 
            this.msCmbMgStocksItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.msCmbMgStocksItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.msCmbMgStocksItem.FormattingEnabled = true;
            this.msCmbMgStocksItem.Location = new System.Drawing.Point(176, 96);
            this.msCmbMgStocksItem.Name = "msCmbMgStocksItem";
            this.msCmbMgStocksItem.Size = new System.Drawing.Size(281, 29);
            this.msCmbMgStocksItem.TabIndex = 3;
            // 
            // msCmbMgStocksItemCat
            // 
            this.msCmbMgStocksItemCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.msCmbMgStocksItemCat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.msCmbMgStocksItemCat.FormattingEnabled = true;
            this.msCmbMgStocksItemCat.Items.AddRange(new object[] {
            "-SELECT-"});
            this.msCmbMgStocksItemCat.Location = new System.Drawing.Point(176, 61);
            this.msCmbMgStocksItemCat.Name = "msCmbMgStocksItemCat";
            this.msCmbMgStocksItemCat.Size = new System.Drawing.Size(281, 29);
            this.msCmbMgStocksItemCat.TabIndex = 2;
            this.msCmbMgStocksItemCat.SelectedIndexChanged += new System.EventHandler(this.cmbMgStocksItemCat_SelectedIndexChanged);
            // 
            // msDiscount
            // 
            this.msDiscount.Location = new System.Drawing.Point(176, 201);
            this.msDiscount.Name = "msDiscount";
            this.msDiscount.Size = new System.Drawing.Size(118, 29);
            this.msDiscount.TabIndex = 6;
            this.msDiscount.Text = "0";
            this.msDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.msDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // msSellingPrice
            // 
            this.msSellingPrice.Location = new System.Drawing.Point(176, 166);
            this.msSellingPrice.Name = "msSellingPrice";
            this.msSellingPrice.Size = new System.Drawing.Size(118, 29);
            this.msSellingPrice.TabIndex = 5;
            this.msSellingPrice.Text = "0.00";
            this.msSellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.msSellingPrice.TextChanged += new System.EventHandler(this.msSellingPrice_TextChanged);
            this.msSellingPrice.Enter += new System.EventHandler(this.msSellingPrice_Enter);
            // 
            // msCompanyPrice
            // 
            this.msCompanyPrice.Location = new System.Drawing.Point(176, 131);
            this.msCompanyPrice.Name = "msCompanyPrice";
            this.msCompanyPrice.Size = new System.Drawing.Size(118, 29);
            this.msCompanyPrice.TabIndex = 4;
            this.msCompanyPrice.Text = "0.00";
            this.msCompanyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.msCompanyPrice.TextChanged += new System.EventHandler(this.msCompanyPrice_TextChanged);
            this.msCompanyPrice.Enter += new System.EventHandler(this.msCompanyPrice_Enter);
            // 
            // msBarCode
            // 
            this.msBarCode.Location = new System.Drawing.Point(176, 26);
            this.msBarCode.Name = "msBarCode";
            this.msBarCode.Size = new System.Drawing.Size(281, 29);
            this.msBarCode.TabIndex = 1;
            this.msBarCode.TextChanged += new System.EventHandler(this.msBarCode_TextChanged);
            // 
            // tpcProducts
            // 
            this.tpcProducts.BackColor = System.Drawing.Color.Transparent;
            this.tpcProducts.Controls.Add(this.iItemName);
            this.tpcProducts.Controls.Add(this.button2);
            this.tpcProducts.Controls.Add(this.button1);
            this.tpcProducts.Controls.Add(this.isWeight);
            this.tpcProducts.Controls.Add(this.label10);
            this.tpcProducts.Controls.Add(this.label9);
            this.tpcProducts.Controls.Add(this.iItemCategory);
            this.tpcProducts.Controls.Add(this.iIsWeight);
            this.tpcProducts.Location = new System.Drawing.Point(4, 41);
            this.tpcProducts.Name = "tpcProducts";
            this.tpcProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tpcProducts.Size = new System.Drawing.Size(1040, 585);
            this.tpcProducts.TabIndex = 2;
            this.tpcProducts.Text = "Items";
            this.tpcProducts.Click += new System.EventHandler(this.tpcProducts_Click);
            this.tpcProducts.Enter += new System.EventHandler(this.tpcProducts_Enter);
            // 
            // iItemName
            // 
            this.iItemName.FormattingEnabled = true;
            this.iItemName.Location = new System.Drawing.Point(191, 9);
            this.iItemName.Name = "iItemName";
            this.iItemName.Size = new System.Drawing.Size(121, 40);
            this.iItemName.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(297, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(191, 184);
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
            this.isWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isWeight.Location = new System.Drawing.Point(20, 88);
            this.isWeight.Name = "isWeight";
            this.isWeight.Size = new System.Drawing.Size(74, 21);
            this.isWeight.TabIndex = 9;
            this.isWeight.Text = "is Weight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Item Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Item Name";
            // 
            // iItemCategory
            // 
            this.iItemCategory.FormattingEnabled = true;
            this.iItemCategory.Location = new System.Drawing.Point(191, 69);
            this.iItemCategory.Name = "iItemCategory";
            this.iItemCategory.Size = new System.Drawing.Size(180, 40);
            this.iItemCategory.TabIndex = 7;
            // 
            // iIsWeight
            // 
            this.iIsWeight.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.iIsWeight.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.iIsWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iIsWeight.FormattingEnabled = true;
            this.iIsWeight.Items.AddRange(new object[] {
            "True",
            "False"});
            this.iIsWeight.Location = new System.Drawing.Point(191, 135);
            this.iIsWeight.Name = "iIsWeight";
            this.iIsWeight.Size = new System.Drawing.Size(180, 29);
            this.iIsWeight.TabIndex = 8;
            // 
            // tpcManageProducts
            // 
            this.tpcManageProducts.Location = new System.Drawing.Point(4, 41);
            this.tpcManageProducts.Name = "tpcManageProducts";
            this.tpcManageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tpcManageProducts.Size = new System.Drawing.Size(1040, 585);
            this.tpcManageProducts.TabIndex = 3;
            this.tpcManageProducts.Text = "Manage Items";
            this.tpcManageProducts.UseVisualStyleBackColor = true;
            // 
            // StockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1060, 673);
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
        private System.Windows.Forms.ComboBox msCmbMgStocksItemCat;
        private System.Windows.Forms.TextBox msBarCode;
        private System.Windows.Forms.NumericUpDown msQuantity;
        private System.Windows.Forms.ComboBox msCmbMgStocksItem;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox iItemName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox msStockTotal;
        private System.Windows.Forms.TextBox msInHand;
    }
}