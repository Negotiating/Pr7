using System;
using System.Linq;
using System.Windows.Forms;

namespace PR7_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		string contains(string str)
		{
			char[] splitChars = { ' ', '.', ',', '?', '!', ':', ';' };
			string[] array = str.Split(splitChars);
			string rez = "";
			int count = 0;
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array.Length; j++)
				{
					if (array[i] == array[j]) count++;
				}
				if (count == 1) rez += array[i] + " ";
				count = 0;
			}
			return rez;
		}
		private void text2_box_TextChanged(object sender, EventArgs e)
		{
			string str = "";
			try
			{
				str = Convert.ToString(text2_box.Text);
				if (str == "") result2_box.Text = "Введена пустая строка!!!";
				else
				{
					result2_box.Text = contains(str);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			Console.ReadLine();
		}

		private void text_box_TextChanged(object sender, EventArgs e)
		{
			string str = Convert.ToString(text_box.Text);
			try
			{
				if (str == "")
				{
					result_box.Text = "Введена пустая строка!!!";
				}
				else
				{
					if (!str.Contains(':'))
					{
						result_box.Text = "Не сожержится символ ':'";
					}
					else
						result_box.Text = str.Substring(str.LastIndexOf(':') + 1);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}
	}
}
