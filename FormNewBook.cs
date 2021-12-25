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
				string str = maskedTextBox1.Text.Substring(0, 2) + maskedTextBox1.Text.Substring(3, 2) + maskedTextBox1.Text.Substring(6, 4);
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

				author.Init(textBox3.Text, day, month, year, textBox4.Text);
			}

			if (radioButton2.Checked)
			{
				ForeignBook book = new(textBox2.Text);
			}
			else
			{
				Book book = new();
			}
		}
	}
}
