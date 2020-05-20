namespace PR7_WF
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
			this.TabControl = new System.Windows.Forms.TabControl();
			this.Task1_page = new System.Windows.Forms.TabPage();
			this.Task1_panel = new System.Windows.Forms.Panel();
			this.result_box = new System.Windows.Forms.RichTextBox();
			this.result_label = new System.Windows.Forms.Label();
			this.text_box = new System.Windows.Forms.RichTextBox();
			this.text_label = new System.Windows.Forms.Label();
			this.Task2_page = new System.Windows.Forms.TabPage();
			this.Task2_panel = new System.Windows.Forms.Panel();
			this.result2_box = new System.Windows.Forms.RichTextBox();
			this.result2_label = new System.Windows.Forms.Label();
			this.text2_box = new System.Windows.Forms.RichTextBox();
			this.text2_label = new System.Windows.Forms.Label();
			this.TabControl.SuspendLayout();
			this.Task1_page.SuspendLayout();
			this.Task1_panel.SuspendLayout();
			this.Task2_page.SuspendLayout();
			this.Task2_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// TabControl
			// 
			this.TabControl.Controls.Add(this.Task1_page);
			this.TabControl.Controls.Add(this.Task2_page);
			this.TabControl.Location = new System.Drawing.Point(2, 2);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(357, 256);
			this.TabControl.TabIndex = 0;
			// 
			// Task1_page
			// 
			this.Task1_page.Controls.Add(this.Task1_panel);
			this.Task1_page.Location = new System.Drawing.Point(4, 25);
			this.Task1_page.Name = "Task1_page";
			this.Task1_page.Padding = new System.Windows.Forms.Padding(3);
			this.Task1_page.Size = new System.Drawing.Size(349, 227);
			this.Task1_page.TabIndex = 0;
			this.Task1_page.Text = "Задание 1";
			this.Task1_page.UseVisualStyleBackColor = true;
			// 
			// Task1_panel
			// 
			this.Task1_panel.Controls.Add(this.result_box);
			this.Task1_panel.Controls.Add(this.result_label);
			this.Task1_panel.Controls.Add(this.text_box);
			this.Task1_panel.Controls.Add(this.text_label);
			this.Task1_panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Task1_panel.Location = new System.Drawing.Point(3, 3);
			this.Task1_panel.Name = "Task1_panel";
			this.Task1_panel.Size = new System.Drawing.Size(343, 221);
			this.Task1_panel.TabIndex = 0;
			// 
			// result_box
			// 
			this.result_box.Location = new System.Drawing.Point(97, 121);
			this.result_box.Name = "result_box";
			this.result_box.Size = new System.Drawing.Size(227, 77);
			this.result_box.TabIndex = 3;
			this.result_box.Text = "";
			// 
			// result_label
			// 
			this.result_label.AutoSize = true;
			this.result_label.Location = new System.Drawing.Point(11, 121);
			this.result_label.Name = "result_label";
			this.result_label.Size = new System.Drawing.Size(80, 17);
			this.result_label.TabIndex = 2;
			this.result_label.Text = "Результат:";
			// 
			// text_box
			// 
			this.text_box.Location = new System.Drawing.Point(67, 16);
			this.text_box.Name = "text_box";
			this.text_box.Size = new System.Drawing.Size(257, 88);
			this.text_box.TabIndex = 1;
			this.text_box.Text = "";
			this.text_box.TextChanged += new System.EventHandler(this.text_box_TextChanged);
			// 
			// text_label
			// 
			this.text_label.AutoSize = true;
			this.text_label.Location = new System.Drawing.Point(11, 14);
			this.text_label.Name = "text_label";
			this.text_label.Size = new System.Drawing.Size(50, 17);
			this.text_label.TabIndex = 0;
			this.text_label.Text = "Текст:";
			// 
			// Task2_page
			// 
			this.Task2_page.Controls.Add(this.Task2_panel);
			this.Task2_page.Location = new System.Drawing.Point(4, 25);
			this.Task2_page.Name = "Task2_page";
			this.Task2_page.Padding = new System.Windows.Forms.Padding(3);
			this.Task2_page.Size = new System.Drawing.Size(349, 227);
			this.Task2_page.TabIndex = 1;
			this.Task2_page.Text = "Задание 2";
			this.Task2_page.UseVisualStyleBackColor = true;
			// 
			// Task2_panel
			// 
			this.Task2_panel.Controls.Add(this.result2_box);
			this.Task2_panel.Controls.Add(this.result2_label);
			this.Task2_panel.Controls.Add(this.text2_box);
			this.Task2_panel.Controls.Add(this.text2_label);
			this.Task2_panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Task2_panel.Location = new System.Drawing.Point(3, 3);
			this.Task2_panel.Name = "Task2_panel";
			this.Task2_panel.Size = new System.Drawing.Size(343, 221);
			this.Task2_panel.TabIndex = 0;
			// 
			// result2_box
			// 
			this.result2_box.Location = new System.Drawing.Point(101, 125);
			this.result2_box.Name = "result2_box";
			this.result2_box.Size = new System.Drawing.Size(227, 77);
			this.result2_box.TabIndex = 7;
			this.result2_box.Text = "";
			// 
			// result2_label
			// 
			this.result2_label.AutoSize = true;
			this.result2_label.Location = new System.Drawing.Point(15, 125);
			this.result2_label.Name = "result2_label";
			this.result2_label.Size = new System.Drawing.Size(80, 17);
			this.result2_label.TabIndex = 6;
			this.result2_label.Text = "Результат:";
			// 
			// text2_box
			// 
			this.text2_box.Location = new System.Drawing.Point(71, 20);
			this.text2_box.Name = "text2_box";
			this.text2_box.Size = new System.Drawing.Size(257, 88);
			this.text2_box.TabIndex = 5;
			this.text2_box.Text = "";
			this.text2_box.TextChanged += new System.EventHandler(this.text2_box_TextChanged);
			// 
			// text2_label
			// 
			this.text2_label.AutoSize = true;
			this.text2_label.Location = new System.Drawing.Point(15, 18);
			this.text2_label.Name = "text2_label";
			this.text2_label.Size = new System.Drawing.Size(50, 17);
			this.text2_label.TabIndex = 4;
			this.text2_label.Text = "Текст:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 265);
			this.Controls.Add(this.TabControl);
			this.Name = "Form1";
			this.Text = "Практика 7";
			this.TabControl.ResumeLayout(false);
			this.Task1_page.ResumeLayout(false);
			this.Task1_panel.ResumeLayout(false);
			this.Task1_panel.PerformLayout();
			this.Task2_page.ResumeLayout(false);
			this.Task2_panel.ResumeLayout(false);
			this.Task2_panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.TabPage Task1_page;
		private System.Windows.Forms.TabPage Task2_page;
		private System.Windows.Forms.Panel Task1_panel;
		private System.Windows.Forms.RichTextBox result_box;
		private System.Windows.Forms.Label result_label;
		private System.Windows.Forms.RichTextBox text_box;
		private System.Windows.Forms.Label text_label;
		private System.Windows.Forms.Panel Task2_panel;
		private System.Windows.Forms.RichTextBox result2_box;
		private System.Windows.Forms.Label result2_label;
		private System.Windows.Forms.RichTextBox text2_box;
		private System.Windows.Forms.Label text2_label;
	}
}

