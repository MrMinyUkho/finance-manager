using System.Windows.Forms;

namespace FinanceManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.logo = new System.Windows.Forms.Label();
            this.DebtsDGV = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debts_label = new System.Windows.Forms.Label();
            this.Credit_label = new System.Windows.Forms.Label();
            this.CreditsDGV = new System.Windows.Forms.DataGridView();
            this.Date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sort_label = new System.Windows.Forms.Label();
            this.SortCategoryAZ = new System.Windows.Forms.CheckBox();
            this.SortCategoryZA = new System.Windows.Forms.CheckBox();
            this.SortDateAZ = new System.Windows.Forms.CheckBox();
            this.SortDateZA = new System.Windows.Forms.CheckBox();
            this.SortMoneyAZ = new System.Windows.Forms.CheckBox();
            this.SortMoneyZA = new System.Windows.Forms.CheckBox();
            this.SortNoteAZ = new System.Windows.Forms.CheckBox();
            this.SortNoteZA = new System.Windows.Forms.CheckBox();
            this.createEntry_btn = new System.Windows.Forms.Button();
            this.deleteEntry_btn = new System.Windows.Forms.Button();
            this.saveData_btn = new System.Windows.Forms.Button();
            this.clearData_btn = new System.Windows.Forms.Button();
            this.Filter_label = new System.Windows.Forms.Label();
            this.selectFilterBox = new System.Windows.Forms.CheckedListBox();
            this.getSummary_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DebtsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo.Location = new System.Drawing.Point(12, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(180, 20);
            this.logo.TabIndex = 0;
            this.logo.Text = "Фінансовий менеджер";
            // 
            // DebtsDGV
            // 
            this.DebtsDGV.AllowUserToAddRows = false;
            this.DebtsDGV.AllowUserToDeleteRows = false;
            this.DebtsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DebtsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Money,
            this.Category,
            this.Note});
            this.DebtsDGV.Location = new System.Drawing.Point(16, 74);
            this.DebtsDGV.Name = "DebtsDGV";
            this.DebtsDGV.ReadOnly = true;
            this.DebtsDGV.RowHeadersVisible = false;
            this.DebtsDGV.Size = new System.Drawing.Size(367, 446);
            this.DebtsDGV.TabIndex = 1;
            this.DebtsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DebtsDGV_CellClick);
            this.DebtsDGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseDoubleClick);
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата та час";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Money
            // 
            this.Money.HeaderText = "Прибуток, грн";
            this.Money.Name = "Money";
            this.Money.ReadOnly = true;
            this.Money.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Category
            // 
            this.Category.HeaderText = "Категорія";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Note
            // 
            this.Note.HeaderText = "Опис";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Debts_label
            // 
            this.Debts_label.AutoSize = true;
            this.Debts_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Debts_label.Location = new System.Drawing.Point(13, 55);
            this.Debts_label.Name = "Debts_label";
            this.Debts_label.Size = new System.Drawing.Size(71, 16);
            this.Debts_label.TabIndex = 2;
            this.Debts_label.Text = "Прибутки";
            // 
            // Credit_label
            // 
            this.Credit_label.AutoSize = true;
            this.Credit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Credit_label.Location = new System.Drawing.Point(386, 55);
            this.Credit_label.Name = "Credit_label";
            this.Credit_label.Size = new System.Drawing.Size(62, 16);
            this.Credit_label.TabIndex = 4;
            this.Credit_label.Text = "Витрати";
            // 
            // CreditsDGV
            // 
            this.CreditsDGV.AllowUserToAddRows = false;
            this.CreditsDGV.AllowUserToDeleteRows = false;
            this.CreditsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CreditsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date1,
            this.Credit,
            this.Category1,
            this.Note1});
            this.CreditsDGV.Location = new System.Drawing.Point(389, 74);
            this.CreditsDGV.Name = "CreditsDGV";
            this.CreditsDGV.ReadOnly = true;
            this.CreditsDGV.RowHeadersVisible = false;
            this.CreditsDGV.Size = new System.Drawing.Size(367, 446);
            this.CreditsDGV.TabIndex = 3;
            this.CreditsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CreditsDGV_CellClick);
            this.CreditsDGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseDoubleClick);
            // 
            // Date1
            // 
            this.Date1.HeaderText = "Дата та час";
            this.Date1.Name = "Date1";
            this.Date1.ReadOnly = true;
            this.Date1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Витрата, грн";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Category1
            // 
            this.Category1.HeaderText = "Категорія";
            this.Category1.Name = "Category1";
            this.Category1.ReadOnly = true;
            this.Category1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Note1
            // 
            this.Note1.HeaderText = "Опис";
            this.Note1.Name = "Note1";
            this.Note1.ReadOnly = true;
            this.Note1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sort_label
            // 
            this.Sort_label.AutoSize = true;
            this.Sort_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort_label.Location = new System.Drawing.Point(766, 55);
            this.Sort_label.Name = "Sort_label";
            this.Sort_label.Size = new System.Drawing.Size(86, 16);
            this.Sort_label.TabIndex = 5;
            this.Sort_label.Text = "Сортування";
            // 
            // SortCategoryAZ
            // 
            this.SortCategoryAZ.AutoSize = true;
            this.SortCategoryAZ.Location = new System.Drawing.Point(769, 133);
            this.SortCategoryAZ.Name = "SortCategoryAZ";
            this.SortCategoryAZ.Size = new System.Drawing.Size(108, 17);
            this.SortCategoryAZ.TabIndex = 6;
            this.SortCategoryAZ.Text = "Категорія А -> Я";
            this.SortCategoryAZ.UseVisualStyleBackColor = true;
            this.SortCategoryAZ.Click += new System.EventHandler(this.changeSortSettings);
            // 
            // SortCategoryZA
            // 
            this.SortCategoryZA.AutoSize = true;
            this.SortCategoryZA.Location = new System.Drawing.Point(889, 133);
            this.SortCategoryZA.Name = "SortCategoryZA";
            this.SortCategoryZA.Size = new System.Drawing.Size(108, 17);
            this.SortCategoryZA.TabIndex = 7;
            this.SortCategoryZA.Text = "Категорія Я -> А";
            this.SortCategoryZA.UseVisualStyleBackColor = true;
            this.SortCategoryZA.Click += new System.EventHandler(this.changeSortSettings);
            // 
            // SortDateAZ
            // 
            this.SortDateAZ.AutoSize = true;
            this.SortDateAZ.Location = new System.Drawing.Point(769, 87);
            this.SortDateAZ.Name = "SortDateAZ";
            this.SortDateAZ.Size = new System.Drawing.Size(85, 17);
            this.SortDateAZ.TabIndex = 8;
            this.SortDateAZ.Text = "Дата А -> Я";
            this.SortDateAZ.UseVisualStyleBackColor = true;
            this.SortDateAZ.Click += new System.EventHandler(this.changeSortSettings);
            // 
            // SortDateZA
            // 
            this.SortDateZA.AutoSize = true;
            this.SortDateZA.Location = new System.Drawing.Point(889, 87);
            this.SortDateZA.Name = "SortDateZA";
            this.SortDateZA.Size = new System.Drawing.Size(85, 17);
            this.SortDateZA.TabIndex = 9;
            this.SortDateZA.Text = "Дата Я -> А";
            this.SortDateZA.UseVisualStyleBackColor = true;
            this.SortDateZA.Click += new System.EventHandler(this.changeSortSettings);
            // 
            // SortMoneyAZ
            // 
            this.SortMoneyAZ.AutoSize = true;
            this.SortMoneyAZ.Location = new System.Drawing.Point(769, 110);
            this.SortMoneyAZ.Name = "SortMoneyAZ";
            this.SortMoneyAZ.Size = new System.Drawing.Size(87, 17);
            this.SortMoneyAZ.TabIndex = 10;
            this.SortMoneyAZ.Text = "Гроші А -> Я";
            this.SortMoneyAZ.UseVisualStyleBackColor = true;
            this.SortMoneyAZ.Click += new System.EventHandler(this.changeSortSettings);
            // 
            // SortMoneyZA
            // 
            this.SortMoneyZA.AutoSize = true;
            this.SortMoneyZA.Location = new System.Drawing.Point(889, 110);
            this.SortMoneyZA.Name = "SortMoneyZA";
            this.SortMoneyZA.Size = new System.Drawing.Size(87, 17);
            this.SortMoneyZA.TabIndex = 11;
            this.SortMoneyZA.Text = "Гроші Я -> А";
            this.SortMoneyZA.UseVisualStyleBackColor = true;
            this.SortMoneyZA.Click += new System.EventHandler(this.changeSortSettings);
            // 
            // SortNoteAZ
            // 
            this.SortNoteAZ.AutoSize = true;
            this.SortNoteAZ.Location = new System.Drawing.Point(769, 156);
            this.SortNoteAZ.Name = "SortNoteAZ";
            this.SortNoteAZ.Size = new System.Drawing.Size(85, 17);
            this.SortNoteAZ.TabIndex = 12;
            this.SortNoteAZ.Text = "Опис А -> Я";
            this.SortNoteAZ.UseVisualStyleBackColor = true;
            this.SortNoteAZ.Click += new System.EventHandler(this.changeSortSettings);
            // 
            // SortNoteZA
            // 
            this.SortNoteZA.AutoSize = true;
            this.SortNoteZA.Location = new System.Drawing.Point(889, 156);
            this.SortNoteZA.Name = "SortNoteZA";
            this.SortNoteZA.Size = new System.Drawing.Size(85, 17);
            this.SortNoteZA.TabIndex = 13;
            this.SortNoteZA.Text = "Опис Я -> А";
            this.SortNoteZA.UseVisualStyleBackColor = true;
            this.SortNoteZA.Click += new System.EventHandler(this.changeSortSettings);
            // 
            // createEntry_btn
            // 
            this.createEntry_btn.Location = new System.Drawing.Point(769, 190);
            this.createEntry_btn.Name = "createEntry_btn";
            this.createEntry_btn.Size = new System.Drawing.Size(108, 23);
            this.createEntry_btn.TabIndex = 14;
            this.createEntry_btn.Text = "Новий запис";
            this.createEntry_btn.UseVisualStyleBackColor = true;
            this.createEntry_btn.Click += new System.EventHandler(this.createEntry_btn_Click);
            // 
            // deleteEntry_btn
            // 
            this.deleteEntry_btn.Location = new System.Drawing.Point(889, 190);
            this.deleteEntry_btn.Name = "deleteEntry_btn";
            this.deleteEntry_btn.Size = new System.Drawing.Size(108, 23);
            this.deleteEntry_btn.TabIndex = 15;
            this.deleteEntry_btn.Text = "Видалити запис";
            this.deleteEntry_btn.UseVisualStyleBackColor = true;
            this.deleteEntry_btn.Click += new System.EventHandler(this.deleteEntry_btn_Click);
            // 
            // saveData_btn
            // 
            this.saveData_btn.Location = new System.Drawing.Point(769, 219);
            this.saveData_btn.Name = "saveData_btn";
            this.saveData_btn.Size = new System.Drawing.Size(108, 23);
            this.saveData_btn.TabIndex = 16;
            this.saveData_btn.Text = "Зберігти зміни";
            this.saveData_btn.UseVisualStyleBackColor = true;
            this.saveData_btn.Click += new System.EventHandler(this.saveData_btn_Click);
            // 
            // clearData_btn
            // 
            this.clearData_btn.Location = new System.Drawing.Point(889, 219);
            this.clearData_btn.Name = "clearData_btn";
            this.clearData_btn.Size = new System.Drawing.Size(108, 23);
            this.clearData_btn.TabIndex = 17;
            this.clearData_btn.Text = "Очистити записи";
            this.clearData_btn.UseVisualStyleBackColor = true;
            this.clearData_btn.Click += new System.EventHandler(this.clearData_btn_Click);
            // 
            // Filter_label
            // 
            this.Filter_label.AutoSize = true;
            this.Filter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filter_label.Location = new System.Drawing.Point(766, 284);
            this.Filter_label.Name = "Filter_label";
            this.Filter_label.Size = new System.Drawing.Size(193, 16);
            this.Filter_label.TabIndex = 18;
            this.Filter_label.Text = "Фільтрування за категорією";
            // 
            // selectFilterBox
            // 
            this.selectFilterBox.FormattingEnabled = true;
            this.selectFilterBox.Location = new System.Drawing.Point(769, 306);
            this.selectFilterBox.Name = "selectFilterBox";
            this.selectFilterBox.Size = new System.Drawing.Size(228, 214);
            this.selectFilterBox.TabIndex = 20;
            this.selectFilterBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.selectFilterBox_ItemCheck);
            // 
            // getSummary_btn
            // 
            this.getSummary_btn.Location = new System.Drawing.Point(769, 248);
            this.getSummary_btn.Name = "getSummary_btn";
            this.getSummary_btn.Size = new System.Drawing.Size(228, 23);
            this.getSummary_btn.TabIndex = 21;
            this.getSummary_btn.Text = "Отримати звіт за період";
            this.getSummary_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.getSummary_btn);
            this.Controls.Add(this.selectFilterBox);
            this.Controls.Add(this.Filter_label);
            this.Controls.Add(this.clearData_btn);
            this.Controls.Add(this.saveData_btn);
            this.Controls.Add(this.deleteEntry_btn);
            this.Controls.Add(this.createEntry_btn);
            this.Controls.Add(this.SortNoteZA);
            this.Controls.Add(this.SortNoteAZ);
            this.Controls.Add(this.SortMoneyZA);
            this.Controls.Add(this.SortMoneyAZ);
            this.Controls.Add(this.SortDateZA);
            this.Controls.Add(this.SortDateAZ);
            this.Controls.Add(this.SortCategoryZA);
            this.Controls.Add(this.SortCategoryAZ);
            this.Controls.Add(this.Sort_label);
            this.Controls.Add(this.Credit_label);
            this.Controls.Add(this.CreditsDGV);
            this.Controls.Add(this.Debts_label);
            this.Controls.Add(this.DebtsDGV);
            this.Controls.Add(this.logo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DebtsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.DataGridView DebtsDGV;
        private System.Windows.Forms.Label Debts_label;
        private System.Windows.Forms.Label Credit_label;
        private System.Windows.Forms.DataGridView CreditsDGV;
        private System.Windows.Forms.Label Sort_label;
        private System.Windows.Forms.CheckBox SortCategoryAZ;
        private System.Windows.Forms.CheckBox SortCategoryZA;
        private System.Windows.Forms.CheckBox SortDateAZ;
        private System.Windows.Forms.CheckBox SortDateZA;
        private System.Windows.Forms.CheckBox SortMoneyAZ;
        private System.Windows.Forms.CheckBox SortMoneyZA;
        private System.Windows.Forms.CheckBox SortNoteAZ;
        private System.Windows.Forms.CheckBox SortNoteZA;
        private System.Windows.Forms.Button createEntry_btn;
        private System.Windows.Forms.Button deleteEntry_btn;
        private System.Windows.Forms.Button saveData_btn;
        private System.Windows.Forms.Button clearData_btn;
        private System.Windows.Forms.Label Filter_label;
        private System.Windows.Forms.CheckedListBox selectFilterBox;
        private System.Windows.Forms.Button getSummary_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note1;
    }
}

