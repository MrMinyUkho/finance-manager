namespace FinanceManager
{
    public partial class CreateEntrie
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
            this.createEntrie_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryText = new System.Windows.Forms.TextBox();
            this.noteText = new System.Windows.Forms.TextBox();
            this.moneyText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createEntrie_btn
            // 
            this.createEntrie_btn.Location = new System.Drawing.Point(119, 131);
            this.createEntrie_btn.Name = "createEntrie_btn";
            this.createEntrie_btn.Size = new System.Drawing.Size(96, 23);
            this.createEntrie_btn.TabIndex = 0;
            this.createEntrie_btn.Text = "Створити запис";
            this.createEntrie_btn.UseVisualStyleBackColor = true;
            this.createEntrie_btn.Click += new System.EventHandler(this.createEntrie_btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата та час";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Прибуток/Збиток";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Категорія";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Опис";
            // 
            // categoryText
            // 
            this.categoryText.Location = new System.Drawing.Point(130, 64);
            this.categoryText.Name = "categoryText";
            this.categoryText.Size = new System.Drawing.Size(191, 20);
            this.categoryText.TabIndex = 6;
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(130, 90);
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(191, 20);
            this.noteText.TabIndex = 7;
            // 
            // moneyText
            // 
            this.moneyText.Location = new System.Drawing.Point(130, 38);
            this.moneyText.Name = "moneyText";
            this.moneyText.Size = new System.Drawing.Size(191, 20);
            this.moneyText.TabIndex = 8;
            // 
            // CreateEntrie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 166);
            this.Controls.Add(this.moneyText);
            this.Controls.Add(this.noteText);
            this.Controls.Add(this.categoryText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.createEntrie_btn);
            this.Name = "CreateEntrie";
            this.Text = "CreateEntrie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createEntrie_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox categoryText;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.TextBox moneyText;
    }
}