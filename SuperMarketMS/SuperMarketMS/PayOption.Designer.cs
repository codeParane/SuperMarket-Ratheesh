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
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.poTotalDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.poTotalDisPer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.poTotalDisCash = new System.Windows.Forms.TextBox();
            this.dgvFinalStocks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(418, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(272, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 101);
            this.button2.TabIndex = 0;
            this.button2.Text = "Loan";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(418, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 101);
            this.button3.TabIndex = 0;
            this.button3.Text = "Card";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtGross
            // 
            this.txtGross.Enabled = false;
            this.txtGross.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGross.Location = new System.Drawing.Point(384, 36);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(201, 29);
            this.txtGross.TabIndex = 1;
            // 
            // txtDis
            // 
            this.txtDis.Enabled = false;
            this.txtDis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDis.Location = new System.Drawing.Point(384, 71);
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(201, 29);
            this.txtDis.TabIndex = 1;
            this.txtDis.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFinal
            // 
            this.txtFinal.Enabled = false;
            this.txtFinal.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.ForeColor = System.Drawing.Color.Maroon;
            this.txtFinal.Location = new System.Drawing.Point(384, 106);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(201, 39);
            this.txtFinal.TabIndex = 1;
            // 
            // poTotalDiscount
            // 
            this.poTotalDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poTotalDiscount.Location = new System.Drawing.Point(218, 187);
            this.poTotalDiscount.Name = "poTotalDiscount";
            this.poTotalDiscount.Size = new System.Drawing.Size(140, 29);
            this.poTotalDiscount.TabIndex = 2;
            this.poTotalDiscount.Text = "0";
            this.poTotalDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.poTotalDiscount.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Bill Discount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Bill Discount";
            // 
            // poTotalDisPer
            // 
            this.poTotalDisPer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poTotalDisPer.Location = new System.Drawing.Point(218, 222);
            this.poTotalDisPer.Name = "poTotalDisPer";
            this.poTotalDisPer.Size = new System.Drawing.Size(140, 29);
            this.poTotalDisPer.TabIndex = 4;
            this.poTotalDisPer.Text = "0";
            this.poTotalDisPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Bill Discount";
            // 
            // poTotalDisCash
            // 
            this.poTotalDisCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poTotalDisCash.Location = new System.Drawing.Point(218, 257);
            this.poTotalDisCash.Name = "poTotalDisCash";
            this.poTotalDisCash.Size = new System.Drawing.Size(140, 29);
            this.poTotalDisCash.TabIndex = 6;
            this.poTotalDisCash.Text = "0";
            this.poTotalDisCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvFinalStocks
            // 
            this.dgvFinalStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinalStocks.Location = new System.Drawing.Point(64, 90);
            this.dgvFinalStocks.Name = "dgvFinalStocks";
            this.dgvFinalStocks.Size = new System.Drawing.Size(193, 55);
            this.dgvFinalStocks.TabIndex = 8;
            // 
            // PayOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 425);
            this.ControlBox = false;
            this.Controls.Add(this.dgvFinalStocks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.poTotalDisCash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.poTotalDisPer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poTotalDiscount);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtDis);
            this.Controls.Add(this.txtGross);
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
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox poTotalDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox poTotalDisPer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox poTotalDisCash;
        private System.Windows.Forms.DataGridView dgvFinalStocks;
    }
}