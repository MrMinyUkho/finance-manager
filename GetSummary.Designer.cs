namespace FinanceManager
{
    partial class GetSummary
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
            this.periodCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Start_dTP = new System.Windows.Forms.DateTimePicker();
            this.End_dTP = new System.Windows.Forms.DateTimePicker();
            this.getSummary_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Debit_tb = new System.Windows.Forms.TextBox();
            this.Credit_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // periodCheck
            // 
            this.periodCheck.AutoSize = true;
            this.periodCheck.Location = new System.Drawing.Point(12, 77);
            this.periodCheck.Name = "periodCheck";
            this.periodCheck.Size = new System.Drawing.Size(86, 17);
            this.periodCheck.TabIndex = 0;
            this.periodCheck.Text = "За весь час";
            this.periodCheck.UseVisualStyleBackColor = true;
            this.periodCheck.CheckedChanged += new System.EventHandler(this.periodCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Отримати звіт ";
            // 
            // Start_dTP
            // 
            this.Start_dTP.CustomFormat = "dd.MM.yyyy HH:mm";
            this.Start_dTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Start_dTP.Location = new System.Drawing.Point(12, 37);
            this.Start_dTP.Name = "Start_dTP";
            this.Start_dTP.Size = new System.Drawing.Size(123, 20);
            this.Start_dTP.TabIndex = 3;
            // 
            // End_dTP
            // 
            this.End_dTP.CustomFormat = "dd.MM.yyyy HH:mm";
            this.End_dTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.End_dTP.Location = new System.Drawing.Point(141, 37);
            this.End_dTP.Name = "End_dTP";
            this.End_dTP.Size = new System.Drawing.Size(123, 20);
            this.End_dTP.TabIndex = 4;
            // 
            // getSummary_btn
            // 
            this.getSummary_btn.Location = new System.Drawing.Point(139, 71);
            this.getSummary_btn.Name = "getSummary_btn";
            this.getSummary_btn.Size = new System.Drawing.Size(125, 23);
            this.getSummary_btn.TabIndex = 6;
            this.getSummary_btn.Text = "Сформувати звіт";
            this.getSummary_btn.UseVisualStyleBackColor = true;
            this.getSummary_btn.Click += new System.EventHandler(this.getSummary_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Доходів за період: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Витрат за період: ";
            // 
            // Debit_tb
            // 
            this.Debit_tb.Location = new System.Drawing.Point(124, 119);
            this.Debit_tb.Name = "Debit_tb";
            this.Debit_tb.ReadOnly = true;
            this.Debit_tb.Size = new System.Drawing.Size(75, 20);
            this.Debit_tb.TabIndex = 11;
            // 
            // Credit_tb
            // 
            this.Credit_tb.Location = new System.Drawing.Point(124, 148);
            this.Credit_tb.Name = "Credit_tb";
            this.Credit_tb.ReadOnly = true;
            this.Credit_tb.Size = new System.Drawing.Size(75, 20);
            this.Credit_tb.TabIndex = 12;
            // 
            // GetSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 107);
            this.Controls.Add(this.Credit_tb);
            this.Controls.Add(this.Debit_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getSummary_btn);
            this.Controls.Add(this.End_dTP);
            this.Controls.Add(this.Start_dTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.periodCheck);
            this.Name = "GetSummary";
            this.Text = "GetSummary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox periodCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Start_dTP;
        private System.Windows.Forms.DateTimePicker End_dTP;
        private System.Windows.Forms.Button getSummary_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Debit_tb;
        private System.Windows.Forms.TextBox Credit_tb;
    }
}