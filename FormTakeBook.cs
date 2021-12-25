using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab15_CS
{
	public partial class FormTakeBook : Form
	{
		public FormTakeBook()
		{
			InitializeComponent();
		}

		private void FormTakeBook_Load(object sender, EventArgs e)
		{
			int i = 0;
			foreach (Book book in Program.books)
			{
				dataGridView1.Rows.Add();

				dataGridView1.Rows[i].Cells[0].Value = book.ID;
				dataGridView1.Rows[i].Cells[1].Value = book.Title;
				dataGridView1.Rows[i].Cells[2].Value = book.AboutAuthor;
				dataGridView1.Rows[i].Cells[3].Value = book.Genre;
				dataGridView1.Rows[i].Cells[4].Value = book.Pages_number;
				dataGridView1.Rows[i].Cells[5].Value = book.Publishing;
				dataGridView1.Rows[i].Cells[6].Value = book.Publication_year;
				if (book.Reader != null)
				{
					dataGridView1.Rows[i].Cells[7].Value = book.Reader.Doc_Number;
					dataGridView1.Rows[i].Cells[8].Value = book.Reader.Name;
					dataGridView1.Rows[i].Cells[9].Value = book.Borrow_date;
				}
				else
					dataGridView1.Rows[i].Cells[7].Value = dataGridView1.Rows[i].Cells[8].Value = dataGridView1.Rows[i].Cells[9].Value = "";
				i++;
			}
		}

		private void FormTakeBook_SizeChanged(object sender, EventArgs e)
		{
			dataGridView1.Size = new Size(dataGridView1.Size.Width, Height - 300);
		}

		private void MaskedTextBox1_TextChanged(object sender, EventArgs e)
		{
			label2.Text = "Читатель не найден";
			foreach (Reader reader in Program.readers)
			{
				if (reader.Doc_Number == maskedTextBox1.Text)
				{
					label2.Text = reader.Name;
					break;
				}
			}

			button1.Enabled = button2.Enabled = false;

			if (label2.Text != "Читатель не найден" && label2.Text != "Фамилия Имя Отчество")
			{
				if (label4.Text != "Название книги" && label4.Text != "Книга не найдена")
				{
					foreach (Book book in Program.books)
					{
						if (book.ID.ToString() == maskedTextBox2.Text)
						{
							if (book.Reader != null && book.Reader.Doc_Number == maskedTextBox1.Text)
							{
								button2.Enabled = true;
								break;
							}
							else if (book.Reader == null)
							{
								button2.Enabled = true;
								break;
							}
						}
					}
				}	
			}
		}

		private void MaskedTextBox2_TextChanged(object sender, EventArgs e)
		{
			label4.Text = "Книга не найдена";
			foreach (Book book in Program.books)
			{
				if (book.ID.ToString() == maskedTextBox2.Text)
				{
					label4.Text = book.Title;
					break;
				}
			}

			button1.Enabled = button2.Enabled = false;

			if (label2.Text != "Читатель не найден" && label2.Text != "Фамилия Имя Отчество")
			{
				if (label4.Text != "Название книги" && label4.Text != "Книга не найдена")
				{
					foreach (Book book in Program.books)
					{
						if (book.ID.ToString() == maskedTextBox2.Text)
						{
							if (book.Reader != null && book.Reader.Doc_Number == maskedTextBox1.Text)
							{
								button2.Enabled = true;
								break;
							}
							else if (book.Reader == null)
							{
								button1.Enabled = true;
								break;
							}
						}
					}
				}
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			foreach (Book book in Program.books)
			{
				if (book.ID.ToString() == maskedTextBox2.Text)
				{
					foreach (Reader reader in Program.readers)
					{
						if (reader.Doc_Number == maskedTextBox1.Text)
						{
							book.Reader = reader;
							break;
						}
					}
				}
			}

			Button3_Click(sender, e);
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			FormTakeBook_Load(sender, e);
			label2.Text = "Фамилия Имя Отчество";
			label4.Text = "Название книги";
			maskedTextBox1.Text = maskedTextBox2.Text = "";
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			foreach (Book book in Program.books)
			{
				if (book.ID.ToString() == maskedTextBox2.Text)
				{
					if (book.Reader.Doc_Number == maskedTextBox1.Text)
					{
						book.Reader = null;
						break;
					}
				}
			}

			Button3_Click(sender, e);
		}
	}
}
