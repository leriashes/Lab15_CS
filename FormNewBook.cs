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
	public partial class FormNewBook : Form
	{
		public FormNewBook()
		{
			InitializeComponent();
		}

		private void RadioButton2_CheckedChanged(object sender, EventArgs e)
		{
			textBox2.Enabled = radioButton2.Checked;
		}

		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			textBox3.Enabled = textBox4.Enabled = maskedTextBox1.Enabled = checkBox1.Checked;
		}

		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			textBox6.Enabled = textBox7.Enabled = checkBox2.Checked;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Author author = new();
			if (checkBox1.Checked)
			{
				string str;
				if (maskedTextBox1.Text.Length != 10)
				{
					maskedTextBox1.Text = "01.01.1990";
				}

				str = maskedTextBox1.Text.Substring(0, 2) + maskedTextBox1.Text.Substring(3, 2) + maskedTextBox1.Text.Substring(6, 4);

				int[] date = new int[8];

				try
				{
					date[0] = int.Parse(str);
				}
				catch (FormatException)
				{
					date[0] = 0;
				}

				for (int i = 0; i < 7 && date[0] > 0; i++)
				{
					date[7 - i] = date[0] % 10;
					date[0] /= 10;
				}

				int year = 0;
				for (int i = 0; i < 4; i++)
				{
					year += date[i + 4] * (int)Math.Pow(10, 3 - i);
				}

				int month = date[2] * 10 + date[3];
				int day = date[0] * 10 + date[1];

				if (year < 1)
					year = 1900;
				if (month < 1 || month > 12)
					month = 1;
				if (day < 1 || day > 31)
					day = 1;

				if (textBox3.Text == "")
					textBox3.Text = "Иванов Иван Иванович";

				if (textBox4.Text == "")
					textBox4.Text = "Россия";

				author.Init(textBox3.Text, day, month, year, textBox4.Text);

				if (textBox3.Text == "")
					textBox3.Text = "Иванов Иван Иванович";

				if (textBox4.Text == "")
					textBox4.Text = "Россия";

				author.Init(textBox3.Text, day, month, year, textBox4.Text);
			}

			Publishing publishing = new();
			if (checkBox2.Checked)
			{
				if (textBox6.Text == "")
					textBox6.Text = "Издательство №1";

				if (textBox7.Text == "")
					textBox7.Text = "г. Москва";

				publishing.Init(textBox6.Text, textBox7.Text);
			}

			if (textBox1.Text == "")
				textBox1.Text = "Котофей";

			if (textBox5.Text == "")
				textBox5.Text = "Сказки";

			if (maskedTextBox2.Text == "")
				maskedTextBox2.Text = "50";

			int pages_number;
			try
			{
				pages_number = int.Parse(maskedTextBox2.Text);
			}
			catch (FormatException)
			{
				pages_number = 0;
			}

			if (maskedTextBox3.Text == "")
				maskedTextBox3.Text = "2021";

			int p_year;
			try
			{
				p_year = int.Parse(maskedTextBox3.Text);
			}
			catch (FormatException)
			{
				p_year = 0;
			}

			if (radioButton2.Checked)
			{
				
				if (textBox2.Text == "")
					textBox2.Text = "Английский";

				ForeignBook fbook = new(textBox1.Text, author, pages_number, textBox5.Text, publishing, p_year, textBox2.Text);
				Program.books.Add(fbook);
			}
			else
			{
				Book book = new(textBox1.Text, author, pages_number, textBox5.Text, publishing, p_year);
				Program.books.Add(book);
			}
		}
	}
}
