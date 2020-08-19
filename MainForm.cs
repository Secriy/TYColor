using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TYColor
{
	public partial class MainForm : Form
	{
		public MainForm() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			
		}

		// 十六进制输入
		private void textBox_value_TextChanged(object sender, EventArgs e) {
			Regex color_regex_sharp = new Regex(@"^#([0-9a-fA-F]{6}|[0-9a-fA-F]{3})$");
			Regex color_regex_nosharp = new Regex(@"^([0-9a-fA-F]{6}|[0-9a-fA-F]{3})$");
			if (color_regex_sharp.IsMatch(textBox_value.Text)) {
				pictureBox_color.BackColor = ColorTranslator.FromHtml(textBox_value.Text);
			}
			else if (color_regex_nosharp.IsMatch(textBox_value.Text)){
				pictureBox_color.BackColor = ColorTranslator.FromHtml("#"+textBox_value.Text);
			}
			else {
				pictureBox_color.BackColor = System.Drawing.Color.White;
			}
		}

		// 点击复制
		private void textBox_value_Click(object sender, EventArgs e)
        {
			if (textBox_value.Text != "")
            {
				Clipboard.SetDataObject(textBox_value.Text);
				tip.Visible = true;
				tip_timer.Start();
			}
		}

		// 延时关闭复制提示
		private void tip_timer_Tick(object sender, EventArgs e)
		{
			tip.Visible = false;
		}

		// 调色板
		private void Palette_button_Click(object sender, EventArgs e)
        {
			if(colorDialog.ShowDialog()== DialogResult.OK)
            {
				pictureBox_color.BackColor = colorDialog.Color;
                textBox_value.Text = colorDialog.Color.ToArgb().ToString("X8").Substring(2, 6);
			}
        }

		// 拾色器
		private void selector_Click(object sender, EventArgs e)
		{
		}

		// 关于
		private void About_button_Click(object sender, EventArgs e)
        {

        }

    }
}
