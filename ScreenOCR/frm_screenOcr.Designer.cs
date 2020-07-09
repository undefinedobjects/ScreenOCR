namespace ScreenOCR
{
    partial class frm_screenOcr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_screenOcr));
            this.btn_screenShot = new System.Windows.Forms.Button();
            this.ni_screenOcr = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btn_screenShot
            // 
            this.btn_screenShot.Location = new System.Drawing.Point(89, 103);
            this.btn_screenShot.Name = "btn_screenShot";
            this.btn_screenShot.Size = new System.Drawing.Size(163, 38);
            this.btn_screenShot.TabIndex = 0;
            this.btn_screenShot.Text = "Take";
            this.btn_screenShot.UseVisualStyleBackColor = true;
            this.btn_screenShot.Click += new System.EventHandler(this.btn_screenShot_Click);
            // 
            // ni_screenOcr
            // 
            this.ni_screenOcr.Icon = ((System.Drawing.Icon)(resources.GetObject("ni_screenOcr.Icon")));
            this.ni_screenOcr.Text = "ScreenOCR";
            this.ni_screenOcr.Visible = true;
            this.ni_screenOcr.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ni_screenOcr_MouseDoubleClick);
            // 
            // frm_screenOcr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 246);
            this.Controls.Add(this.btn_screenShot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frm_screenOcr";
            this.Opacity = 0.5D;
            this.Text = "ScreenOCR";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.frm_screenOcr_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_screenOcr_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_screenShot;
        private System.Windows.Forms.NotifyIcon ni_screenOcr;
    }
}

