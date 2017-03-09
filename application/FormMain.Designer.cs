﻿namespace SHColorPicker
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.FolderBD_SShot = new System.Windows.Forms.FolderBrowserDialog();
            this.txtColorCodeR = new System.Windows.Forms.TextBox();
            this.label_R = new System.Windows.Forms.Label();
            this.label_G = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.txtColorCodeB = new System.Windows.Forms.TextBox();
            this.txtColorCodeG = new System.Windows.Forms.TextBox();
            this.txtColorCodeFF = new System.Windows.Forms.TextBox();
            this.label_FF = new System.Windows.Forms.Label();
            this.btnPickup = new System.Windows.Forms.Button();
            this.imgResultColor = new System.Windows.Forms.PictureBox();
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtColorCodeRGB = new System.Windows.Forms.TextBox();
            this.label_RGB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgResultColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtColorCodeR
            // 
            this.txtColorCodeR.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtColorCodeR.Location = new System.Drawing.Point(160, 20);
            this.txtColorCodeR.Name = "txtColorCodeR";
            this.txtColorCodeR.Size = new System.Drawing.Size(44, 24);
            this.txtColorCodeR.TabIndex = 11;
            this.txtColorCodeR.TextChanged += new System.EventHandler(this.txtColorCodeR_TextChanged);
            this.txtColorCodeR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtColorCodeR_KeyDown);
            // 
            // label_R
            // 
            this.label_R.AutoSize = true;
            this.label_R.Location = new System.Drawing.Point(141, 23);
            this.label_R.Name = "label_R";
            this.label_R.Size = new System.Drawing.Size(17, 15);
            this.label_R.TabIndex = 12;
            this.label_R.Text = "R";
            // 
            // label_G
            // 
            this.label_G.AutoSize = true;
            this.label_G.Location = new System.Drawing.Point(140, 55);
            this.label_G.Name = "label_G";
            this.label_G.Size = new System.Drawing.Size(18, 15);
            this.label_G.TabIndex = 12;
            this.label_G.Text = "G";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(141, 85);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(17, 15);
            this.label_B.TabIndex = 12;
            this.label_B.Text = "B";
            // 
            // txtColorCodeB
            // 
            this.txtColorCodeB.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtColorCodeB.Location = new System.Drawing.Point(160, 82);
            this.txtColorCodeB.Name = "txtColorCodeB";
            this.txtColorCodeB.Size = new System.Drawing.Size(44, 24);
            this.txtColorCodeB.TabIndex = 13;
            this.txtColorCodeB.TextChanged += new System.EventHandler(this.txtColorCodeB_TextChanged);
            this.txtColorCodeB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtColorCodeB_KeyDown);
            // 
            // txtColorCodeG
            // 
            this.txtColorCodeG.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtColorCodeG.Location = new System.Drawing.Point(160, 52);
            this.txtColorCodeG.Name = "txtColorCodeG";
            this.txtColorCodeG.Size = new System.Drawing.Size(44, 24);
            this.txtColorCodeG.TabIndex = 12;
            this.txtColorCodeG.TextChanged += new System.EventHandler(this.txtColorCodeG_TextChanged);
            this.txtColorCodeG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtColorCodeG_KeyDown);
            // 
            // txtColorCodeFF
            // 
            this.txtColorCodeFF.BackColor = System.Drawing.Color.White;
            this.txtColorCodeFF.Location = new System.Drawing.Point(13, 142);
            this.txtColorCodeFF.Name = "txtColorCodeFF";
            this.txtColorCodeFF.ReadOnly = true;
            this.txtColorCodeFF.Size = new System.Drawing.Size(137, 24);
            this.txtColorCodeFF.TabIndex = 14;
            // 
            // label_FF
            // 
            this.label_FF.AutoSize = true;
            this.label_FF.Location = new System.Drawing.Point(11, 119);
            this.label_FF.Name = "label_FF";
            this.label_FF.Size = new System.Drawing.Size(41, 15);
            this.label_FF.TabIndex = 14;
            this.label_FF.Text = "#html";
            // 
            // btnPickup
            // 
            this.btnPickup.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPickup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPickup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(67)))), ((int)(((byte)(92)))));
            this.btnPickup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(67)))), ((int)(((byte)(92)))));
            this.btnPickup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickup.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPickup.ForeColor = System.Drawing.Color.White;
            this.btnPickup.Location = new System.Drawing.Point(108, 217);
            this.btnPickup.Name = "btnPickup";
            this.btnPickup.Size = new System.Drawing.Size(152, 87);
            this.btnPickup.TabIndex = 15;
            this.btnPickup.Text = "색상추출";
            this.btnPickup.UseVisualStyleBackColor = false;
            this.btnPickup.Click += new System.EventHandler(this.btnSpoidColor_Click);
            // 
            // imgResultColor
            // 
            this.imgResultColor.BackColor = System.Drawing.Color.White;
            this.imgResultColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgResultColor.Location = new System.Drawing.Point(13, 20);
            this.imgResultColor.Name = "imgResultColor";
            this.imgResultColor.Size = new System.Drawing.Size(117, 87);
            this.imgResultColor.TabIndex = 16;
            this.imgResultColor.TabStop = false;
            // 
            // imgPreview
            // 
            this.imgPreview.BackColor = System.Drawing.Color.White;
            this.imgPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPreview.Location = new System.Drawing.Point(12, 12);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(247, 194);
            this.imgPreview.TabIndex = 18;
            this.imgPreview.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "바로가기";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "종료";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtColorCodeRGB);
            this.groupBox1.Controls.Add(this.label_RGB);
            this.groupBox1.Controls.Add(this.imgResultColor);
            this.groupBox1.Controls.Add(this.txtColorCodeR);
            this.groupBox1.Controls.Add(this.txtColorCodeB);
            this.groupBox1.Controls.Add(this.txtColorCodeG);
            this.groupBox1.Controls.Add(this.label_R);
            this.groupBox1.Controls.Add(this.label_FF);
            this.groupBox1.Controls.Add(this.label_G);
            this.groupBox1.Controls.Add(this.txtColorCodeFF);
            this.groupBox1.Controls.Add(this.label_B);
            this.groupBox1.Font = new System.Drawing.Font("돋움", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.SlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(269, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 297);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "결과";
            // 
            // txtColorCodeRGB
            // 
            this.txtColorCodeRGB.Location = new System.Drawing.Point(13, 197);
            this.txtColorCodeRGB.Name = "txtColorCodeRGB";
            this.txtColorCodeRGB.Size = new System.Drawing.Size(137, 24);
            this.txtColorCodeRGB.TabIndex = 18;
            // 
            // label_RGB
            // 
            this.label_RGB.AutoSize = true;
            this.label_RGB.Location = new System.Drawing.Point(12, 178);
            this.label_RGB.Name = "label_RGB";
            this.label_RGB.Size = new System.Drawing.Size(70, 15);
            this.label_RGB.TabIndex = 17;
            this.label_RGB.Text = "RGB Html";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 87);
            this.button1.TabIndex = 20;
            this.button1.Text = "선택";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imgPreview);
            this.Controls.Add(this.btnPickup);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "SH Color Picker";
            this.Activated += new System.EventHandler(this.MainForm_activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.imgResultColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog FolderBD_SShot;
        private System.Windows.Forms.Label label_R;
        private System.Windows.Forms.Label label_G;
        private System.Windows.Forms.Label label_B;
        public System.Windows.Forms.TextBox txtColorCodeR;
        public System.Windows.Forms.TextBox txtColorCodeB;
        public System.Windows.Forms.TextBox txtColorCodeG;
        public System.Windows.Forms.TextBox txtColorCodeFF;
        private System.Windows.Forms.Label label_FF;
        private System.Windows.Forms.Button btnPickup;
        public System.Windows.Forms.PictureBox imgResultColor;
        public System.Windows.Forms.PictureBox imgPreview;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_RGB;
        private System.Windows.Forms.TextBox txtColorCodeRGB;
    }
}

