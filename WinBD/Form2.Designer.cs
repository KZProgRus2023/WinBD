namespace WinBD
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.основные_фондыDataSet = new WinBD.Основные_фондыDataSet();
            this.основныефондыDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.иДDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.организацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресЭлектроннойПочтыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рабочийТелефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домашнийТелефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.мобильныйТелефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерФаксаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.областьКрайDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.индексDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаИлиРегионDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вебстраницаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заметкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вложенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SortTextBox = new System.Windows.Forms.TextBox();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.основные_средстваTableAdapter1 = new WinBD.Основные_фондыDataSetTableAdapters.Основные_средстваTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.основные_фондыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.основныефондыDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        \r\nFROM            (Контакты INNER JOIN\r\n                         [О" +
    "сновные средства] ON Контакты.ИД = [Основные средства].ИД)";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"|DataDirectory|\\Основные фонды.acc" +
    "db\"";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДDataGridViewTextBoxColumn,
            this.организацияDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.адресЭлектроннойПочтыDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.рабочийТелефонDataGridViewTextBoxColumn,
            this.домашнийТелефонDataGridViewTextBoxColumn,
            this.мобильныйТелефонDataGridViewTextBoxColumn,
            this.номерФаксаDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn,
            this.областьКрайDataGridViewTextBoxColumn,
            this.индексDataGridViewTextBoxColumn,
            this.странаИлиРегионDataGridViewTextBoxColumn,
            this.вебстраницаDataGridViewTextBoxColumn,
            this.заметкиDataGridViewTextBoxColumn,
            this.вложенияDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Контакты";
            this.dataGridView1.DataSource = this.основныефондыDataSetBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // основные_фондыDataSet
            // 
            this.основные_фондыDataSet.DataSetName = "Основные_фондыDataSet";
            this.основные_фондыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // основныефондыDataSetBindingSource
            // 
            this.основныефондыDataSetBindingSource.DataSource = this.основные_фондыDataSet;
            this.основныефондыDataSetBindingSource.Position = 0;
            // 
            // иДDataGridViewTextBoxColumn
            // 
            this.иДDataGridViewTextBoxColumn.DataPropertyName = "ИД";
            this.иДDataGridViewTextBoxColumn.HeaderText = "ИД";
            this.иДDataGridViewTextBoxColumn.Name = "иДDataGridViewTextBoxColumn";
            // 
            // организацияDataGridViewTextBoxColumn
            // 
            this.организацияDataGridViewTextBoxColumn.DataPropertyName = "Организация";
            this.организацияDataGridViewTextBoxColumn.HeaderText = "Организация";
            this.организацияDataGridViewTextBoxColumn.Name = "организацияDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // адресЭлектроннойПочтыDataGridViewTextBoxColumn
            // 
            this.адресЭлектроннойПочтыDataGridViewTextBoxColumn.DataPropertyName = "Адрес электронной почты";
            this.адресЭлектроннойПочтыDataGridViewTextBoxColumn.HeaderText = "Адрес электронной почты";
            this.адресЭлектроннойПочтыDataGridViewTextBoxColumn.Name = "адресЭлектроннойПочтыDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // рабочийТелефонDataGridViewTextBoxColumn
            // 
            this.рабочийТелефонDataGridViewTextBoxColumn.DataPropertyName = "Рабочий телефон";
            this.рабочийТелефонDataGridViewTextBoxColumn.HeaderText = "Рабочий телефон";
            this.рабочийТелефонDataGridViewTextBoxColumn.Name = "рабочийТелефонDataGridViewTextBoxColumn";
            // 
            // домашнийТелефонDataGridViewTextBoxColumn
            // 
            this.домашнийТелефонDataGridViewTextBoxColumn.DataPropertyName = "Домашний телефон";
            this.домашнийТелефонDataGridViewTextBoxColumn.HeaderText = "Домашний телефон";
            this.домашнийТелефонDataGridViewTextBoxColumn.Name = "домашнийТелефонDataGridViewTextBoxColumn";
            // 
            // мобильныйТелефонDataGridViewTextBoxColumn
            // 
            this.мобильныйТелефонDataGridViewTextBoxColumn.DataPropertyName = "Мобильный телефон";
            this.мобильныйТелефонDataGridViewTextBoxColumn.HeaderText = "Мобильный телефон";
            this.мобильныйТелефонDataGridViewTextBoxColumn.Name = "мобильныйТелефонDataGridViewTextBoxColumn";
            // 
            // номерФаксаDataGridViewTextBoxColumn
            // 
            this.номерФаксаDataGridViewTextBoxColumn.DataPropertyName = "Номер факса";
            this.номерФаксаDataGridViewTextBoxColumn.HeaderText = "Номер факса";
            this.номерФаксаDataGridViewTextBoxColumn.Name = "номерФаксаDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "Город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            // 
            // областьКрайDataGridViewTextBoxColumn
            // 
            this.областьКрайDataGridViewTextBoxColumn.DataPropertyName = "Область, край";
            this.областьКрайDataGridViewTextBoxColumn.HeaderText = "Область, край";
            this.областьКрайDataGridViewTextBoxColumn.Name = "областьКрайDataGridViewTextBoxColumn";
            // 
            // индексDataGridViewTextBoxColumn
            // 
            this.индексDataGridViewTextBoxColumn.DataPropertyName = "Индекс";
            this.индексDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.индексDataGridViewTextBoxColumn.Name = "индексDataGridViewTextBoxColumn";
            // 
            // странаИлиРегионDataGridViewTextBoxColumn
            // 
            this.странаИлиРегионDataGridViewTextBoxColumn.DataPropertyName = "Страна или регион";
            this.странаИлиРегионDataGridViewTextBoxColumn.HeaderText = "Страна или регион";
            this.странаИлиРегионDataGridViewTextBoxColumn.Name = "странаИлиРегионDataGridViewTextBoxColumn";
            // 
            // вебстраницаDataGridViewTextBoxColumn
            // 
            this.вебстраницаDataGridViewTextBoxColumn.DataPropertyName = "Веб-страница";
            this.вебстраницаDataGridViewTextBoxColumn.HeaderText = "Веб-страница";
            this.вебстраницаDataGridViewTextBoxColumn.Name = "вебстраницаDataGridViewTextBoxColumn";
            // 
            // заметкиDataGridViewTextBoxColumn
            // 
            this.заметкиDataGridViewTextBoxColumn.DataPropertyName = "Заметки";
            this.заметкиDataGridViewTextBoxColumn.HeaderText = "Заметки";
            this.заметкиDataGridViewTextBoxColumn.Name = "заметкиDataGridViewTextBoxColumn";
            // 
            // вложенияDataGridViewTextBoxColumn
            // 
            this.вложенияDataGridViewTextBoxColumn.DataPropertyName = "Вложения";
            this.вложенияDataGridViewTextBoxColumn.HeaderText = "Вложения";
            this.вложенияDataGridViewTextBoxColumn.Name = "вложенияDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сортировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фильтрация";
            // 
            // SortTextBox
            // 
            this.SortTextBox.Location = new System.Drawing.Point(100, 0);
            this.SortTextBox.Name = "SortTextBox";
            this.SortTextBox.Size = new System.Drawing.Size(100, 20);
            this.SortTextBox.TabIndex = 5;
            this.SortTextBox.Text = "Фамилия";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(100, 43);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilterTextBox.TabIndex = 6;
            this.FilterTextBox.Text = "Город=\'Пушкин\'";
            // 
            // основные_средстваTableAdapter1
            // 
            this.основные_средстваTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.SortTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.основные_фондыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.основныефондыDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource основныефондыDataSetBindingSource;
        private Основные_фондыDataSet основные_фондыDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn организацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресЭлектроннойПочтыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рабочийТелефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домашнийТелефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn мобильныйТелефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерФаксаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn областьКрайDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn индексDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаИлиРегионDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вебстраницаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заметкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вложенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SortTextBox;
        private System.Windows.Forms.TextBox FilterTextBox;
        private Основные_фондыDataSetTableAdapters.Основные_средстваTableAdapter основные_средстваTableAdapter1;
    }
}