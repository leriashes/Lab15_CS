using System;
using System.Collections;
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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Program.books = new();
			Program.readers = new();
		}

		private void Button_new_book_Click(object sender, EventArgs e)
		{
			FormNewBook formNewBook = new();
			formNewBook.ShowDialog();
		}

		private void Button_new_reader_Click(object sender, EventArgs e)
		{
			FormNewReader formNewReader = new();
			formNewReader.ShowDialog();
		}
	}
}
