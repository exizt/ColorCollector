namespace SHColorPicker
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
            if(disposing && (PreviewBitmap != null))
            {
                PreviewBitmap.Dispose();
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
            this.TextBox_RGB_R = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.TextBox_RGB_B = new System.Windows.Forms.TextBox();
            this.TextBox_RGB_G = new System.Windows.Forms.TextBox();
            this.TextBox_RGBHex = new System.Windows.Forms.TextBox();
            this.labelFF = new System.Windows.Forms.Label();
            this.Btn_CallPicker = new System.Windows.Forms.Button();
            this.PictureBox_Color = new System.Windows.Forms.PictureBox();
            this.PictureBox_Scope = new System.Windows.Forms.PictureBox();
            this.NotifyIcon_Main = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStrip_Quick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.colordialog1 = new System.Windows.Forms.ColorDialog();
            this.GroupBox_ResultSet = new System.Windows.Forms.GroupBox();
            this.TextBox_RGBString = new System.Windows.Forms.TextBox();
            this.labelRGB = new System.Windows.Forms.Label();
            this.Btn_CallPalette = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Scope)).BeginInit();
            this.ContextMenuStrip_Quick.SuspendLayout();
            this.GroupBox_ResultSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_RGB_R
            // 
            this.TextBox_RGB_R.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBox_RGB_R.Location = new System.Drawing.Point(160, 20);
            this.TextBox_RGB_R.MaxLength = 3;
            this.TextBox_RGB_R.Name = "TextBox_RGB_R";
            this.TextBox_RGB_R.Size = new System.Drawing.Size(44, 24);
            this.TextBox_RGB_R.TabIndex = 11;
            this.TextBox_RGB_R.TextChanged += new System.EventHandler(this.txtColorCode_TextChanged);
            this.TextBox_RGB_R.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_RGBCode_KeyUp);
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(141, 23);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(17, 15);
            this.labelR.TabIndex = 12;
            this.labelR.Text = "R";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(140, 55);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(18, 15);
            this.labelG.TabIndex = 12;
            this.labelG.Text = "G";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(141, 85);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(17, 15);
            this.labelB.TabIndex = 12;
            this.labelB.Text = "B";
            // 
            // TextBox_RGB_B
            // 
            this.TextBox_RGB_B.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBox_RGB_B.Location = new System.Drawing.Point(160, 82);
            this.TextBox_RGB_B.MaxLength = 3;
            this.TextBox_RGB_B.Name = "TextBox_RGB_B";
            this.TextBox_RGB_B.Size = new System.Drawing.Size(44, 24);
            this.TextBox_RGB_B.TabIndex = 13;
            this.TextBox_RGB_B.TextChanged += new System.EventHandler(this.txtColorCode_TextChanged);
            this.TextBox_RGB_B.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_RGBCode_KeyUp);
            // 
            // TextBox_RGB_G
            // 
            this.TextBox_RGB_G.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBox_RGB_G.Location = new System.Drawing.Point(160, 52);
            this.TextBox_RGB_G.MaxLength = 3;
            this.TextBox_RGB_G.Name = "TextBox_RGB_G";
            this.TextBox_RGB_G.Size = new System.Drawing.Size(44, 24);
            this.TextBox_RGB_G.TabIndex = 12;
            this.TextBox_RGB_G.TextChanged += new System.EventHandler(this.txtColorCode_TextChanged);
            this.TextBox_RGB_G.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_RGBCode_KeyUp);
            // 
            // TextBox_RGBHex
            // 
            this.TextBox_RGBHex.BackColor = System.Drawing.Color.White;
            this.TextBox_RGBHex.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBox_RGBHex.Location = new System.Drawing.Point(13, 142);
            this.TextBox_RGBHex.MaxLength = 7;
            this.TextBox_RGBHex.Name = "TextBox_RGBHex";
            this.TextBox_RGBHex.Size = new System.Drawing.Size(190, 24);
            this.TextBox_RGBHex.TabIndex = 14;
            this.TextBox_RGBHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColorCodeFF_KeyPress);
            this.TextBox_RGBHex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtColorCodeFF_KeyUp);
            // 
            // labelFF
            // 
            this.labelFF.AutoSize = true;
            this.labelFF.Location = new System.Drawing.Point(11, 119);
            this.labelFF.Name = "labelFF";
            this.labelFF.Size = new System.Drawing.Size(41, 15);
            this.labelFF.TabIndex = 14;
            this.labelFF.Text = "#html";
            // 
            // Btn_CallPicker
            // 
            this.Btn_CallPicker.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_CallPicker.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_CallPicker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(67)))), ((int)(((byte)(92)))));
            this.Btn_CallPicker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(67)))), ((int)(((byte)(92)))));
            this.Btn_CallPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CallPicker.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_CallPicker.ForeColor = System.Drawing.Color.White;
            this.Btn_CallPicker.Location = new System.Drawing.Point(12, 217);
            this.Btn_CallPicker.Name = "Btn_CallPicker";
            this.Btn_CallPicker.Size = new System.Drawing.Size(248, 36);
            this.Btn_CallPicker.TabIndex = 15;
            this.Btn_CallPicker.Text = "색상추출";
            this.Btn_CallPicker.UseVisualStyleBackColor = false;
            this.Btn_CallPicker.Click += new System.EventHandler(this.Btn_CallPicker_Click);
            // 
            // PictureBox_Color
            // 
            this.PictureBox_Color.BackColor = System.Drawing.Color.White;
            this.PictureBox_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_Color.Location = new System.Drawing.Point(13, 20);
            this.PictureBox_Color.Name = "PictureBox_Color";
            this.PictureBox_Color.Size = new System.Drawing.Size(117, 87);
            this.PictureBox_Color.TabIndex = 16;
            this.PictureBox_Color.TabStop = false;
            // 
            // PictureBox_Scope
            // 
            this.PictureBox_Scope.BackColor = System.Drawing.Color.White;
            this.PictureBox_Scope.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_Scope.Location = new System.Drawing.Point(12, 12);
            this.PictureBox_Scope.Name = "PictureBox_Scope";
            this.PictureBox_Scope.Size = new System.Drawing.Size(247, 194);
            this.PictureBox_Scope.TabIndex = 18;
            this.PictureBox_Scope.TabStop = false;
            // 
            // NotifyIcon_Main
            // 
            this.NotifyIcon_Main.ContextMenuStrip = this.ContextMenuStrip_Quick;
            this.NotifyIcon_Main.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon_Main.Icon")));
            this.NotifyIcon_Main.Text = "바로가기";
            this.NotifyIcon_Main.Visible = true;
            this.NotifyIcon_Main.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseClick);
            this.NotifyIcon_Main.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // ContextMenuStrip_Quick
            // 
            this.ContextMenuStrip_Quick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Quit});
            this.ContextMenuStrip_Quick.Name = "contextMenuStrip1";
            this.ContextMenuStrip_Quick.Size = new System.Drawing.Size(99, 26);
            // 
            // ToolStripMenuItem_Quit
            // 
            this.ToolStripMenuItem_Quit.Name = "ToolStripMenuItem_Quit";
            this.ToolStripMenuItem_Quit.Size = new System.Drawing.Size(98, 22);
            this.ToolStripMenuItem_Quit.Text = "종료";
            this.ToolStripMenuItem_Quit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // GroupBox_ResultSet
            // 
            this.GroupBox_ResultSet.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox_ResultSet.Controls.Add(this.TextBox_RGBString);
            this.GroupBox_ResultSet.Controls.Add(this.labelRGB);
            this.GroupBox_ResultSet.Controls.Add(this.PictureBox_Color);
            this.GroupBox_ResultSet.Controls.Add(this.TextBox_RGB_R);
            this.GroupBox_ResultSet.Controls.Add(this.TextBox_RGB_B);
            this.GroupBox_ResultSet.Controls.Add(this.TextBox_RGB_G);
            this.GroupBox_ResultSet.Controls.Add(this.labelR);
            this.GroupBox_ResultSet.Controls.Add(this.labelFF);
            this.GroupBox_ResultSet.Controls.Add(this.labelG);
            this.GroupBox_ResultSet.Controls.Add(this.TextBox_RGBHex);
            this.GroupBox_ResultSet.Controls.Add(this.labelB);
            this.GroupBox_ResultSet.Font = new System.Drawing.Font("돋움", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GroupBox_ResultSet.ForeColor = System.Drawing.Color.SlateBlue;
            this.GroupBox_ResultSet.Location = new System.Drawing.Point(269, 7);
            this.GroupBox_ResultSet.Name = "GroupBox_ResultSet";
            this.GroupBox_ResultSet.Size = new System.Drawing.Size(221, 246);
            this.GroupBox_ResultSet.TabIndex = 19;
            this.GroupBox_ResultSet.TabStop = false;
            this.GroupBox_ResultSet.Text = "Info";
            // 
            // TextBox_RGBString
            // 
            this.TextBox_RGBString.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBox_RGBString.Location = new System.Drawing.Point(13, 202);
            this.TextBox_RGBString.MaxLength = 20;
            this.TextBox_RGBString.Name = "TextBox_RGBString";
            this.TextBox_RGBString.Size = new System.Drawing.Size(191, 24);
            this.TextBox_RGBString.TabIndex = 18;
            this.TextBox_RGBString.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtColorCodeRGB_KeyUp);
            // 
            // labelRGB
            // 
            this.labelRGB.AutoSize = true;
            this.labelRGB.Location = new System.Drawing.Point(12, 183);
            this.labelRGB.Name = "labelRGB";
            this.labelRGB.Size = new System.Drawing.Size(73, 15);
            this.labelRGB.TabIndex = 17;
            this.labelRGB.Text = "Web RGB";
            // 
            // Btn_CallPalette
            // 
            this.Btn_CallPalette.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_CallPalette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CallPalette.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_CallPalette.ForeColor = System.Drawing.Color.White;
            this.Btn_CallPalette.Location = new System.Drawing.Point(12, 217);
            this.Btn_CallPalette.Name = "Btn_CallPalette";
            this.Btn_CallPalette.Size = new System.Drawing.Size(89, 87);
            this.Btn_CallPalette.TabIndex = 20;
            this.Btn_CallPalette.Text = "선택";
            this.Btn_CallPalette.UseVisualStyleBackColor = false;
            this.Btn_CallPalette.Click += new System.EventHandler(this.btnColorPaletteDialog_Click);
            // 
            // FormMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 320);
            this.Controls.Add(this.Btn_CallPalette);
            this.Controls.Add(this.GroupBox_ResultSet);
            this.Controls.Add(this.PictureBox_Scope);
            this.Controls.Add(this.Btn_CallPicker);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::SHColorPicker.Properties.Resources.MainIcon;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "SHColor";
            this.Activated += new System.EventHandler(this.MainForm_activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Scope)).EndInit();
            this.ContextMenuStrip_Quick.ResumeLayout(false);
            this.GroupBox_ResultSet.ResumeLayout(false);
            this.GroupBox_ResultSet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelFF;
        private System.Windows.Forms.Label labelRGB;
        public System.Windows.Forms.TextBox TextBox_RGB_R;
        public System.Windows.Forms.TextBox TextBox_RGB_B;
        public System.Windows.Forms.TextBox TextBox_RGB_G;
        public System.Windows.Forms.TextBox TextBox_RGBHex;
        private System.Windows.Forms.TextBox TextBox_RGBString;
        private System.Windows.Forms.Button Btn_CallPicker;
        private System.Windows.Forms.Button Btn_CallPalette;
        private System.Windows.Forms.GroupBox GroupBox_ResultSet;
        public System.Windows.Forms.PictureBox PictureBox_Color;
        public System.Windows.Forms.PictureBox PictureBox_Scope;
        private System.Windows.Forms.ColorDialog colordialog1;
        private System.Windows.Forms.NotifyIcon NotifyIcon_Main;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Quick;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Quit;
    }
}

