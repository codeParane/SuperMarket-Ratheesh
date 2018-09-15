namespace SuperMarketMS
{
    partial class PayOption
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.poBillDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.poBillDisPer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.poBillDisCash = new System.Windows.Forms.TextBox();
            this.dgvFinalStocks = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.poItemSavings = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.poGross = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.poBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.poTotalBill = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.poCash = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(431, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(431, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 59);
            this.button2.TabIndex = 0;
            this.button2.Text = "Loan";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(431, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 59);
            this.button3.TabIndex = 0;
            this.button3.Text = "Card";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // poBillDiscount
            // 
            this.poBillDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poBillDiscount.Location = new System.Drawing.Point(188, 217);
            this.poBillDiscount.Name = "poBillDiscount";
            this.poBillDiscount.Size = new System.Drawing.Size(140, 29);
            this.poBillDiscount.TabIndex = 2;
            this.poBillDiscount.Text = "0";
            this.poBillDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.poBillDiscount.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Bill Discount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "%";
            // 
            // poBillDisPer
            // 
            this.poBillDisPer.Enabled = false;
            this.poBillDisPer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poBillDisPer.Location = new System.Drawing.Point(144, 252);
            this.poBillDisPer.Name = "poBillDisPer";
            this.poBillDisPer.Size = new System.Drawing.Size(51, 29);
            this.poBillDisPer.TabIndex = 4;
            this.poBillDisPer.Text = "0";
            this.poBillDisPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rs";
            // 
            // poBillDisCash
            // 
            this.poBillDisCash.Enabled = false;
            this.poBillDisCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poBillDisCash.Location = new System.Drawing.Point(234, 252);
            this.poBillDisCash.Name = "poBillDisCash";
            this.poBillDisCash.Size = new System.Drawing.Size(94, 29);
            this.poBillDisCash.TabIndex = 6;
            this.poBillDisCash.Text = "0";
            this.poBillDisCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvFinalStocks
            // 
            this.dgvFinalStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinalStocks.Location = new System.Drawing.Point(188, 41);
            this.dgvFinalStocks.Name = "dgvFinalStocks";
            this.dgvFinalStocks.Size = new System.Drawing.Size(76, 55);
            this.dgvFinalStocks.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Item Savings";
            // 
            // poItemSavings
            // 
            this.poItemSavings.Enabled = false;
            this.poItemSavings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poItemSavings.Location = new System.Drawing.Point(188, 182);
            this.poItemSavings.Name = "poItemSavings";
            this.poItemSavings.Size = new System.Drawing.Size(140, 29);
            this.poItemSavings.TabIndex = 9;
            this.poItemSavings.Text = "0";
            this.poItemSavings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gross Bill";
            // 
            // poGross
            // 
            this.poGross.Enabled = false;
            this.poGross.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poGross.Location = new System.Drawing.Point(188, 147);
            this.poGross.Name = "poGross";
            this.poGross.Size = new System.Drawing.Size(140, 29);
            this.poGross.TabIndex = 11;
            this.poGross.Text = "0";
            this.poGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Balance";
            // 
            // poBalance
            // 
            this.poBalance.Enabled = false;
            this.poBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poBalance.Location = new System.Drawing.Point(492, 102);
            this.poBalance.Name = "poBalance";
            this.poBalance.Size = new System.Drawing.Size(140, 29);
            this.poBalance.TabIndex = 13;
            this.poBalance.Text = "0";
            this.poBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Bill";
            // 
            // poTotalBill
            // 
            this.poTotalBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poTotalBill.Location = new System.Drawing.Point(188, 287);
            this.poTotalBill.Name = "poTotalBill";
            this.poTotalBill.Size = new System.Drawing.Size(140, 29);
            this.poTotalBill.TabIndex = 15;
            this.poTotalBill.Text = "0";
            this.poTotalBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(423, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cash";
            // 
            // poCash
            // 
            this.poCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poCash.Location = new System.Drawing.Point(492, 67);
            this.poCash.Name = "poCash";
            this.poCash.Size = new System.Drawing.Size(140, 29);
            this.poCash.TabIndex = 17;
            this.poCash.Text = "0";
            this.poCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PayOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 487);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.poCash);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.poTotalBill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.poBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.poGross);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.poItemSavings);
            this.Controls.Add(this.dgvFinalStocks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.poBillDisCash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.poBillDisPer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poBillDiscount);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "PayOption";
            this.Text = "PayOption";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PayOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox poBillDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox poBillDisPer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox poBillDisCash;
        private System.Windows.Forms.DataGridView dgvFinalStocks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox poItemSavings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox poGross;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox poBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox poTotalBill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox poCash;
    }
}