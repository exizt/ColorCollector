namespace SHColorPicker
{
    partial class FormColorPickup
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
            this.timerPick = new System.Windows.Forms.Timer(this.components);
            this.PictureBox_Scope = new System.Windows.Forms.PictureBox();
            this.Pic_Pippet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Scope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Pippet)).BeginInit();
            this.SuspendLayout();
            // 
            // timerPick
            // 
            this.timerPick.Interval = 1;
            this.timerPick.Tick += new System.EventHandler(this.timerPick_Tick);
            // 
            // PictureBox_Scope
            // 
            this.PictureBox_Scope.BackColor = System.Drawing.Color.Turquoise;
            this.PictureBox_Scope.ErrorImage = null;
            this.PictureBox_Scope.ImageLocation = "0,0";
            this.PictureBox_Scope.InitialImage = null;
            this.PictureBox_Scope.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_Scope.Name = "PictureBox_Scope";
            this.PictureBox_Scope.Size = new System.Drawing.Size(300, 300);
            this.PictureBox_Scope.TabIndex = 0;
            this.PictureBox_Scope.TabStop = false;
            this.PictureBox_Scope.Click += new System.EventHandler(this.PictureBox_Scope_Click);
            // 
            // Pic_Pippet
            // 
            this.Pic_Pippet.BackColor = System.Drawing.Color.Turquoise;
            this.Pic_Pippet.Image = global::SHColorPicker.Properties.Resources.Image3;
            this.Pic_Pippet.Location = new System.Drawing.Point(150, 134);
            this.Pic_Pippet.Name = "Pic_Pippet";
            this.Pic_Pippet.Size = new System.Drawing.Size(16, 16);
            this.Pic_Pippet.TabIndex = 1;
            this.Pic_Pippet.TabStop = false;
            this.Pic_Pippet.WaitOnLoad = true;
            this.Pic_Pippet.Click += new System.EventHandler(this.picSpoid_Click);
            // 
            // FormColorPickup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.Pic_Pippet);
            this.Controls.Add(this.PictureBox_Scope);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormColorPickup";
            this.Text = "Color Pick Spoid";
            this.TransparencyKey = System.Drawing.Color.Turquoise;
            this.Load += new System.EventHandler(this.FormColorPickup_Load);
            this.Click += new System.EventHandler(this.Form_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Scope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Pippet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerPick;
        private System.Windows.Forms.PictureBox PictureBox_Scope;
        private System.Windows.Forms.PictureBox Pic_Pippet;
    }
}