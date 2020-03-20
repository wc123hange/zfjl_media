namespace HANGE.Media.UI
{
    partial class Form1
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
            this.txt_from = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.btn_select_from = new System.Windows.Forms.Button();
            this.btn_select_to = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_out = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txt_from
            // 
            this.txt_from.Enabled = false;
            this.txt_from.Location = new System.Drawing.Point(122, 25);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(708, 21);
            this.txt_from.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据输入路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据输出路径：";
            // 
            // txt_to
            // 
            this.txt_to.Enabled = false;
            this.txt_to.Location = new System.Drawing.Point(122, 75);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(708, 21);
            this.txt_to.TabIndex = 3;
            // 
            // btn_select_from
            // 
            this.btn_select_from.Location = new System.Drawing.Point(846, 23);
            this.btn_select_from.Name = "btn_select_from";
            this.btn_select_from.Size = new System.Drawing.Size(75, 23);
            this.btn_select_from.TabIndex = 4;
            this.btn_select_from.Text = "选择文件夹";
            this.btn_select_from.UseVisualStyleBackColor = true;
            this.btn_select_from.Click += new System.EventHandler(this.Btn_select_from_Click);
            // 
            // btn_select_to
            // 
            this.btn_select_to.Location = new System.Drawing.Point(846, 75);
            this.btn_select_to.Name = "btn_select_to";
            this.btn_select_to.Size = new System.Drawing.Size(75, 23);
            this.btn_select_to.TabIndex = 5;
            this.btn_select_to.Text = "选择文件夹";
            this.btn_select_to.UseVisualStyleBackColor = true;
            this.btn_select_to.Click += new System.EventHandler(this.Btn_select_to_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(122, 123);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "开始执行";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(280, 123);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(75, 23);
            this.btn_end.TabIndex = 7;
            this.btn_end.Text = "结束执行";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.Btn_end_Click);
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(409, 125);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(117, 21);
            this.txt_status.TabIndex = 8;
            this.txt_status.Text = "初始化";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // txt_out
            // 
            this.txt_out.Location = new System.Drawing.Point(12, 207);
            this.txt_out.Multiline = true;
            this.txt_out.Name = "txt_out";
            this.txt_out.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_out.Size = new System.Drawing.Size(1071, 380);
            this.txt_out.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "移动文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1008, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "测试log";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(639, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 21);
            this.textBox1.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "生成测试数据";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(149, 163);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(934, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 599);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_out);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_select_to);
            this.Controls.Add(this.btn_select_from);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_from);
            this.Name = "Form1";
            this.Text = "执法记录数据采集";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.Button btn_select_from;
        private System.Windows.Forms.Button btn_select_to;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_out;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

