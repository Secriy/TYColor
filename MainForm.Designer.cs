namespace TYColor
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox_color = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_rgb = new System.Windows.Forms.Label();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.palette = new System.Windows.Forms.Button();
            this.selector = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.pick_timer = new System.Windows.Forms.Timer(this.components);
            this.tip = new System.Windows.Forms.Label();
            this.tip_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_color
            // 
            this.pictureBox_color.BackColor = System.Drawing.Color.White;
            this.pictureBox_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_color.Location = new System.Drawing.Point(12, 27);
            this.pictureBox_color.Name = "pictureBox_color";
            this.pictureBox_color.Size = new System.Drawing.Size(85, 85);
            this.pictureBox_color.TabIndex = 3;
            this.pictureBox_color.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_rgb);
            this.groupBox1.Controls.Add(this.textBox_value);
            this.groupBox1.Location = new System.Drawing.Point(118, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "色值";
            // 
            // label_rgb
            // 
            this.label_rgb.AutoSize = true;
            this.label_rgb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_rgb.Location = new System.Drawing.Point(26, 31);
            this.label_rgb.Name = "label_rgb";
            this.label_rgb.Size = new System.Drawing.Size(32, 16);
            this.label_rgb.TabIndex = 4;
            this.label_rgb.Text = "RGB";
            // 
            // textBox_value
            // 
            this.textBox_value.Location = new System.Drawing.Point(75, 29);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(100, 21);
            this.textBox_value.TabIndex = 5;
            this.textBox_value.Click += new System.EventHandler(this.textBox_value_Click);
            this.textBox_value.TextChanged += new System.EventHandler(this.textBox_value_TextChanged);
            // 
            // palette
            // 
            this.palette.Location = new System.Drawing.Point(118, 12);
            this.palette.Name = "palette";
            this.palette.Size = new System.Drawing.Size(58, 24);
            this.palette.TabIndex = 5;
            this.palette.Text = "调色板";
            this.palette.UseVisualStyleBackColor = true;
            this.palette.Click += new System.EventHandler(this.Palette_button_Click);
            // 
            // selector
            // 
            this.selector.Location = new System.Drawing.Point(193, 12);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(58, 24);
            this.selector.TabIndex = 6;
            this.selector.Text = "拾色器";
            this.selector.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(268, 12);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(58, 24);
            this.about.TabIndex = 7;
            this.about.Text = "关于";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.About_button_Click);
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Location = new System.Drawing.Point(10, 9);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(89, 12);
            this.tip.TabIndex = 8;
            this.tip.Text = "已复制到剪贴板";
            this.tip.Visible = false;
            // 
            // tip_timer
            // 
            this.tip_timer.Interval = 1000;
            this.tip_timer.Tick += new System.EventHandler(this.tip_timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 127);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.about);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.palette);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox_color);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "两块钱取色器";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_color;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.Label label_rgb;
        private System.Windows.Forms.Button palette;
        private System.Windows.Forms.Button selector;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Timer pick_timer;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Timer tip_timer;
    }
}

