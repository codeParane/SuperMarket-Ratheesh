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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.poTotalBill = new System.Windows.Forms.TextBox();
            this.poTotalDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.poTotalDisPer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.poTotalDisCash = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(62, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cash";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(218, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 101);
            this.button2.TabIndex = 0;
            this.button2.Text = "Loan";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(384, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 101);
            this.button3.TabIndex = 0;
            this.button3.Text = "Card";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(323, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 29);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(323, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 29);
            this.textBox2.TabIndex = 1;
            // 
            // poTotalBill
            // 
            this.poTotalBill.Enabled = false;
            this.poTotalBill.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poTotalBill.ForeColor = System.Drawing.Color.Maroon;
            this.poTotalBill.Location = new System.Drawing.Point(323, 106);
            this.poTotalBill.Name = "poTotalBill";
            this.poTotalBill.Size = new System.Drawing.Size(201, 39);
            this.poTotalBill.TabIndex = 1;
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
            // PayOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 425);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.poTotalDisCash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.poTotalDisPer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poTotalDiscount);
            this.Controls.Add(this.poTotalBill);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "PayOption";
            this.Text = "PayOption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox poTotalBill;
        private System.Windows.Forms.TextBox poTotalDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox poTotalDisPer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox poTotalDisCash;
    }
}