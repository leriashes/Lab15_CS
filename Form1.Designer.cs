
namespace Lab15_CS
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.button_new_book = new System.Windows.Forms.Button();
			this.button_new_reader = new System.Windows.Forms.Button();
			this.button_take_book = new System.Windows.Forms.Button();
			this.button_game = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(222, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(777, 47);
			this.label1.TabIndex = 0;
			this.label1.Text = "Добро пожаловать в приложение Библиотека!";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_new_book
			// 
			this.button_new_book.Location = new System.Drawing.Point(178, 154);
			this.button_new_book.Name = "button_new_book";
			this.button_new_book.Size = new System.Drawing.Size(180, 40);
			this.button_new_book.TabIndex = 1;
			this.button_new_book.Text = "Новая книга";
			this.button_new_book.UseVisualStyleBackColor = true;
			this.button_new_book.Click += new System.EventHandler(this.Button_new_book_Click);
			// 
			// button_new_reader
			// 
			this.button_new_reader.Location = new System.Drawing.Point(396, 154);
			this.button_new_reader.Name = "button_new_reader";
			this.button_new_reader.Size = new System.Drawing.Size(180, 40);
			this.button_new_reader.TabIndex = 2;
			this.button_new_reader.Text = "Новый читатель";
			this.button_new_reader.UseVisualStyleBackColor = true;
			// 
			// button_take_book
			// 
			this.button_take_book.Location = new System.Drawing.Point(626, 154);
			this.button_take_book.Name = "button_take_book";
			this.button_take_book.Size = new System.Drawing.Size(180, 40);
			this.button_take_book.TabIndex = 3;
			this.button_take_book.Text = "Выдача/приём ";
			this.button_take_book.UseVisualStyleBackColor = true;
			// 
			// button_game
			// 
			this.button_game.Location = new System.Drawing.Point(842, 154);
			this.button_game.Name = "button_game";
			this.button_game.Size = new System.Drawing.Size(180, 40);
			this.button_game.TabIndex = 4;
			this.button_game.Text = "Игра";
			this.button_game.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1265, 292);
			this.Controls.Add(this.button_game);
			this.Controls.Add(this.button_take_book);
			this.Controls.Add(this.button_new_reader);
			this.Controls.Add(this.button_new_book);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Библиотека";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_new_book;
		private System.Windows.Forms.Button button_new_reader;
		private System.Windows.Forms.Button button_take_book;
		private System.Windows.Forms.Button button_game;
	}
}

