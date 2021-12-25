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
	public partial class FormNewReader : Form
	{
		public FormNewReader()
		{
			InitializeComponent();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			if (textBox3.Text == "")
				textBox3.Text = "Иванов Иван Иванович";

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

			Date rdate = new(day, month, year);

			if (maskedTextBox2.Text == "     ")
				maskedTextBox2.Text = "0110 123456";

			bool f = false;
			int ir = 0, d = 1;
			do
			{
				foreach (Reader r in Program.readers)
				{
					if (r.Doc_Number == maskedTextBox2.Text)
					{
						f = true;
						maskedTextBox2.Text = maskedTextBox2.Text.Substring(0, maskedTextBox2.Text.Length - d) + ir;

						ir++;
						d = 0;
						for (int j = ir; j > 0; j /= 10)
							d++;
					}
					else
						f = false;
				}
			} while (f);

			if (maskedTextBox3.Text == "")
				maskedTextBox3.Text = "1";

			if (maskedTextBox4.Text == "")
				maskedTextBox4.Text = "1";

			if (textBox4.Text == "")
				textBox4.Text = "г. Москва";

			if (textBox2.Text == "")
				textBox2.Text = "Ленинский проспект";

			Address address = new(textBox4.Text, textBox2.Text, int.Parse(maskedTextBox3.Text), int.Parse(maskedTextBox4.Text));

			Reader reader = new(textBox3.Text, rdate, address, maskedTextBox2.Text);
			Program.readers.Add(reader);
		}

		private void FormNewReader_Load(object sender, EventArgs e)
		{

		}
	}
}
