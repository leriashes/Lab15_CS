
namespace Lab15_CS
{
	partial class FormTakeBook
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Pages_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Publishing = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Publ_Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Doc_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Reader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Borrow_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.Author,
            this.Genre,
            this.Pages_Number,
            this.Publishing,
            this.Publ_Year,
            this.Doc_Number,
            this.Reader,
            this.Borrow_Date});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 72;
			this.dataGridView1.RowTemplate.Height = 37;
			this.dataGridView1.Size = new System.Drawing.Size(1746, 500);
			this.dataGridView1.TabIndex = 0;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.MinimumWidth = 9;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// Title
			// 
			this.Title.HeaderText = "Название";
			this.Title.MinimumWidth = 9;
			this.Title.Name = "Title";
			this.Title.ReadOnly = true;
			// 
			// Author
			// 
			this.Author.HeaderText = "Автор";
			this.Author.MinimumWidth = 9;
			this.Author.Name = "Author";
			this.Author.ReadOnly = true;
			// 
			// Genre
			// 
			this.Genre.HeaderText = "Жанр";
			this.Genre.MinimumWidth = 9;
			this.Genre.Name = "Genre";
			this.Genre.ReadOnly = true;
			// 
			// Pages_Number
			// 
			this.Pages_Number.HeaderText = "Количество страниц";
			this.Pages_Number.MinimumWidth = 9;
			this.Pages_Number.Name = "Pages_Number";
			this.Pages_Number.ReadOnly = true;
			// 
			// Publishing
			// 
			this.Publishing.HeaderText = "Издательство";
			this.Publishing.MinimumWidth = 9;
			this.Publishing.Name = "Publishing";
			this.Publishing.ReadOnly = true;
			// 
			// Publ_Year
			// 
			this.Publ_Year.HeaderText = "Год выпуска";
			this.Publ_Year.MinimumWidth = 9;
			this.Publ_Year.Name = "Publ_Year";
			this.Publ_Year.ReadOnly = true;
			// 
			// Doc_Number
			// 
			this.Doc_Number.HeaderText = "Номер документа читателя";
			this.Doc_Number.MinimumWidth = 9;
			this.Doc_Number.Name = "Doc_Number";
			this.Doc_Number.ReadOnly = true;
			// 
			// Reader
			// 
			this.Reader.HeaderText = "Читатель";
			this.Reader.MinimumWidth = 9;
			this.Reader.Name = "Reader";
			this.Reader.ReadOnly = true;
			// 
			// Borrow_Date
			// 
			this.Borrow_Date.HeaderText = "Дата взятия";
			this.Borrow_Date.MinimumWidth = 9;
			this.Borrow_Date.Name = "Borrow_Date";
			this.Borrow_Date.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 526);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(277, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "Номер документа читателя";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(323, 523);
			this.maskedTextBox1.Mask = "0000 000000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(235, 35);
			this.maskedTextBox1.TabIndex = 2;
			this.maskedTextBox1.TextChanged += new System.EventHandler(this.MaskedTextBox1_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(602, 526);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(244, 30);
			this.label2.TabIndex = 3;
			this.label2.Text = "Фамилия Имя Отчество";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 585);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 30);
			this.label3.TabIndex = 4;
			this.label3.Text = "ID книги";
			// 
			// maskedTextBox2
			// 
			this.maskedTextBox2.Location = new System.Drawing.Point(123, 582);
			this.maskedTextBox2.Mask = "000000";
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new System.Drawing.Size(166, 35);
			this.maskedTextBox2.TabIndex = 5;
			this.maskedTextBox2.TextChanged += new System.EventHandler(this.MaskedTextBox2_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(323, 585);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(165, 30);
			this.label4.TabIndex = 6;
			this.label4.Text = "Название книги";
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(20, 657);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(269, 40);
			this.button1.TabIndex = 7;
			this.button1.Text = "Выдать книгу";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(336, 657);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(269, 40);
			this.button2.TabIndex = 8;
			this.button2.Text = "Принять книгу";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(653, 657);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(269, 40);
			this.button3.TabIndex = 9;
			this.button3.Text = "Обновить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// FormTakeBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1746, 736);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.maskedTextBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormTakeBook";
			this.Text = "Библиотека";
			this.Load += new System.EventHandler(this.FormTakeBook_Load);
			this.SizeChanged += new System.EventHandler(this.FormTakeBook_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Title;
		private System.Windows.Forms.DataGridViewTextBoxColumn Author;
		private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Pages_Number;
		private System.Windows.Forms.DataGridViewTextBoxColumn Publishing;
		private System.Windows.Forms.DataGridViewTextBoxColumn Publ_Year;
		private System.Windows.Forms.DataGridViewTextBoxColumn Doc_Number;
		private System.Windows.Forms.DataGridViewTextBoxColumn Reader;
		private System.Windows.Forms.DataGridViewTextBoxColumn Borrow_Date;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox maskedTextBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}