namespace DylanDeSouzaWk15ExB
{
    partial class Form1
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
            this.lbl_principle_amount = new System.Windows.Forms.Label();
            this.lbl_interest_rate = new System.Windows.Forms.Label();
            this.lbl_years = new System.Windows.Forms.Label();
            this.lbl_interest = new System.Windows.Forms.Label();
            this.txt_principal_amount = new System.Windows.Forms.TextBox();
            this.txt_interest_rate = new System.Windows.Forms.TextBox();
            this.txt_years = new System.Windows.Forms.TextBox();
            this.txt_interest = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.txt_compounded = new System.Windows.Forms.TextBox();
            this.lbl_compounded = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_principle_amount
            // 
            this.lbl_principle_amount.AutoSize = true;
            this.lbl_principle_amount.Location = new System.Drawing.Point(177, 90);
            this.lbl_principle_amount.Name = "lbl_principle_amount";
            this.lbl_principle_amount.Size = new System.Drawing.Size(86, 13);
            this.lbl_principle_amount.TabIndex = 1;
            this.lbl_principle_amount.Text = "Principal Amount";
            // 
            // lbl_interest_rate
            // 
            this.lbl_interest_rate.AutoSize = true;
            this.lbl_interest_rate.Location = new System.Drawing.Point(177, 116);
            this.lbl_interest_rate.Name = "lbl_interest_rate";
            this.lbl_interest_rate.Size = new System.Drawing.Size(103, 13);
            this.lbl_interest_rate.TabIndex = 2;
            this.lbl_interest_rate.Text = "Annual interest Rate";
            // 
            // lbl_years
            // 
            this.lbl_years.AutoSize = true;
            this.lbl_years.Location = new System.Drawing.Point(177, 142);
            this.lbl_years.Name = "lbl_years";
            this.lbl_years.Size = new System.Drawing.Size(34, 13);
            this.lbl_years.TabIndex = 3;
            this.lbl_years.Text = "Years";
            // 
            // lbl_interest
            // 
            this.lbl_interest.AutoSize = true;
            this.lbl_interest.Location = new System.Drawing.Point(177, 168);
            this.lbl_interest.Name = "lbl_interest";
            this.lbl_interest.Size = new System.Drawing.Size(45, 13);
            this.lbl_interest.TabIndex = 4;
            this.lbl_interest.Text = "Interest ";
            this.lbl_interest.Visible = false;
            // 
            // txt_principal_amount
            // 
            this.txt_principal_amount.Location = new System.Drawing.Point(286, 83);
            this.txt_principal_amount.Name = "txt_principal_amount";
            this.txt_principal_amount.Size = new System.Drawing.Size(100, 20);
            this.txt_principal_amount.TabIndex = 6;
            // 
            // txt_interest_rate
            // 
            this.txt_interest_rate.Location = new System.Drawing.Point(286, 109);
            this.txt_interest_rate.Name = "txt_interest_rate";
            this.txt_interest_rate.Size = new System.Drawing.Size(100, 20);
            this.txt_interest_rate.TabIndex = 7;
            // 
            // txt_years
            // 
            this.txt_years.Location = new System.Drawing.Point(286, 135);
            this.txt_years.Name = "txt_years";
            this.txt_years.Size = new System.Drawing.Size(100, 20);
            this.txt_years.TabIndex = 8;
            // 
            // txt_interest
            // 
            this.txt_interest.Location = new System.Drawing.Point(286, 161);
            this.txt_interest.Name = "txt_interest";
            this.txt_interest.Size = new System.Drawing.Size(100, 20);
            this.txt_interest.TabIndex = 9;
            this.txt_interest.TabStop = false;
            this.txt_interest.Visible = false;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(286, 187);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 10;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // txt_compounded
            // 
            this.txt_compounded.Location = new System.Drawing.Point(286, 57);
            this.txt_compounded.Name = "txt_compounded";
            this.txt_compounded.Size = new System.Drawing.Size(100, 20);
            this.txt_compounded.TabIndex = 11;
            // 
            // lbl_compounded
            // 
            this.lbl_compounded.AutoSize = true;
            this.lbl_compounded.Location = new System.Drawing.Point(177, 64);
            this.lbl_compounded.Name = "lbl_compounded";
            this.lbl_compounded.Size = new System.Drawing.Size(70, 13);
            this.lbl_compounded.TabIndex = 12;
            this.lbl_compounded.Text = "Compounded";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_compounded);
            this.Controls.Add(this.txt_compounded);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.txt_interest);
            this.Controls.Add(this.txt_years);
            this.Controls.Add(this.txt_interest_rate);
            this.Controls.Add(this.txt_principal_amount);
            this.Controls.Add(this.lbl_interest);
            this.Controls.Add(this.lbl_years);
            this.Controls.Add(this.lbl_interest_rate);
            this.Controls.Add(this.lbl_principle_amount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_principle_amount;
        private System.Windows.Forms.Label lbl_interest_rate;
        private System.Windows.Forms.Label lbl_years;
        private System.Windows.Forms.Label lbl_interest;
        private System.Windows.Forms.TextBox txt_principal_amount;
        private System.Windows.Forms.TextBox txt_interest_rate;
        private System.Windows.Forms.TextBox txt_years;
        private System.Windows.Forms.TextBox txt_interest;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox txt_compounded;
        private System.Windows.Forms.Label lbl_compounded;
    }
}

