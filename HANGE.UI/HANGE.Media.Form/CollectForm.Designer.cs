namespace HANGE.Media
{
    partial class CollectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialTabSelector1 = new EASkins.Controls.MaterialTabSelector();
            this.materialTabControl1 = new EASkins.Controls.MaterialTabControl();
            this.tab_backup = new System.Windows.Forms.TabPage();
            this.txt_box_bk = new EASkins.Ami_RichTextBox();
            this.tab_upload = new System.Windows.Forms.TabPage();
            this.txt_upload = new EASkins.Ami_RichTextBox();
            this.timer_bak = new System.Windows.Forms.Timer(this.components);
            this.timer_init = new System.Windows.Forms.Timer(this.components);
            this.timer_collect = new System.Windows.Forms.Timer(this.components);
            this.timer_collect_upload = new System.Windows.Forms.Timer(this.components);
            this.timer_upload = new System.Windows.Forms.Timer(this.components);
            this.timer_create_dicect = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tab_backup.SuspendLayout();
            this.tab_upload.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 51);
            this.materialTabSelector1.MouseState = EASkins.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(985, 74);
            this.materialTabSelector1.TabIndex = 18;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tab_backup);
            this.materialTabControl1.Controls.Add(this.tab_upload);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 131);
            this.materialTabControl1.MouseState = EASkins.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(985, 384);
            this.materialTabControl1.TabIndex = 19;
            // 
            // tab_backup
            // 
            this.tab_backup.BackColor = System.Drawing.Color.White;
            this.tab_backup.Controls.Add(this.txt_box_bk);
            this.tab_backup.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_backup.Location = new System.Drawing.Point(4, 22);
            this.tab_backup.Name = "tab_backup";
            this.tab_backup.Padding = new System.Windows.Forms.Padding(3);
            this.tab_backup.Size = new System.Drawing.Size(977, 358);
            this.tab_backup.TabIndex = 0;
            this.tab_backup.Text = "备份窗口";
            // 
            // txt_box_bk
            // 
            this.txt_box_bk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_box_bk.AutoWordSelection = false;
            this.txt_box_bk.BackColor = System.Drawing.Color.Transparent;
            this.txt_box_bk.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_box_bk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txt_box_bk.Location = new System.Drawing.Point(3, 3);
            this.txt_box_bk.Name = "txt_box_bk";
            this.txt_box_bk.ReadOnly = false;
            this.txt_box_bk.Size = new System.Drawing.Size(957, 346);
            this.txt_box_bk.TabIndex = 0;
            this.txt_box_bk.WordWrap = true;
            // 
            // tab_upload
            // 
            this.tab_upload.BackColor = System.Drawing.Color.White;
            this.tab_upload.Controls.Add(this.txt_upload);
            this.tab_upload.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_upload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tab_upload.Location = new System.Drawing.Point(4, 22);
            this.tab_upload.Name = "tab_upload";
            this.tab_upload.Padding = new System.Windows.Forms.Padding(3);
            this.tab_upload.Size = new System.Drawing.Size(977, 358);
            this.tab_upload.TabIndex = 1;
            this.tab_upload.Text = "上传窗口";
            // 
            // txt_upload
            // 
            this.txt_upload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_upload.AutoWordSelection = false;
            this.txt_upload.BackColor = System.Drawing.Color.Transparent;
            this.txt_upload.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_upload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txt_upload.Location = new System.Drawing.Point(4, 3);
            this.txt_upload.Name = "txt_upload";
            this.txt_upload.ReadOnly = false;
            this.txt_upload.Size = new System.Drawing.Size(969, 354);
            this.txt_upload.TabIndex = 1;
            this.txt_upload.WordWrap = true;
            // 
            // timer_bak
            // 
            this.timer_bak.Enabled = true;
            this.timer_bak.Interval = 2000;
            this.timer_bak.Tick += new System.EventHandler(this.timer_bak_Tick);
            // 
            // timer_init
            // 
            this.timer_init.Enabled = true;
            this.timer_init.Interval = 5000;
            this.timer_init.Tick += new System.EventHandler(this.timer_init_Tick);
            // 
            // timer_collect
            // 
            this.timer_collect.Enabled = true;
            this.timer_collect.Interval = 2000;
            this.timer_collect.Tick += new System.EventHandler(this.timer_collect_Tick);
            // 
            // timer_collect_upload
            // 
            this.timer_collect_upload.Enabled = true;
            this.timer_collect_upload.Interval = 2000;
            this.timer_collect_upload.Tick += new System.EventHandler(this.timer_collect_upload_Tick);
            // 
            // timer_upload
            // 
            this.timer_upload.Enabled = true;
            this.timer_upload.Interval = 2000;
            this.timer_upload.Tick += new System.EventHandler(this.timer_upload_Tick);
            // 
            // timer_create_dicect
            // 
            this.timer_create_dicect.Enabled = true;
            this.timer_create_dicect.Interval = 36000000;
            this.timer_create_dicect.Tick += new System.EventHandler(this.timer_create_dicect_Tick);
            // 
            // CollectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(985, 527);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "CollectForm";
            this.Load += new System.EventHandler(this.CollectForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tab_backup.ResumeLayout(false);
            this.tab_upload.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EASkins.Controls.MaterialTabSelector materialTabSelector1;
        private EASkins.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tab_backup;
        private System.Windows.Forms.TabPage tab_upload;
        private EASkins.Ami_RichTextBox txt_box_bk;
        private System.Windows.Forms.Timer timer_bak;
        private System.Windows.Forms.Timer timer_init;
        private System.Windows.Forms.Timer timer_collect;
        private EASkins.Ami_RichTextBox txt_upload;
        private System.Windows.Forms.Timer timer_collect_upload;
        private System.Windows.Forms.Timer timer_upload;
        private System.Windows.Forms.Timer timer_create_dicect;
    }
}