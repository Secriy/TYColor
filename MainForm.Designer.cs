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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Palette = new System.Windows.Forms.Button();
            this.Selector = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.TextBox);
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
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(75, 29);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(100, 21);
            this.TextBox.TabIndex = 5;
            this.TextBox.Click += new System.EventHandler(this.TextBox_Click);
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Palette
            // 
            this.Palette.Location = new System.Drawing.Point(118, 12);
            this.Palette.Name = "Palette";
            this.Palette.Size = new System.Drawing.Size(58, 24);
            this.Palette.TabIndex = 5;
            this.Palette.Text = "调色板";
            this.Palette.UseVisualStyleBackColor = true;
            this.Palette.Click += new System.EventHandler(this.Palette_button_Click);
            // 
            // Selector
            // 
            this.Selector.Location = new System.Drawing.Point(193, 12);
            this.Selector.Name = "Selector";
            this.Selector.Size = new System.Drawing.Size(58, 24);
            this.Selector.TabIndex = 6;
            this.Selector.Text = "拾色器";
            this.Selector.UseVisualStyleBackColor = true;
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(268, 12);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(58, 24);
            this.About.TabIndex = 7;
            this.About.Text = "关于";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_button_Click);
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
            this.tip_timer.Interval = 2000;
            this.tip_timer.Tick += new System.EventHandler(this.tip_timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 127);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Selector);
            this.Controls.Add(this.Palette);
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
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Palette;
        private System.Windows.Forms.Button Selector;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Label label_rgb;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Timer pick_timer;
        private System.Windows.Forms.Timer tip_timer;
    }
}

