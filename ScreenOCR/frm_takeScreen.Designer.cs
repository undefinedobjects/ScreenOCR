namespace ScreenOCR
{
    partial class frm_takeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_takeScreen));
            this.rtb_text = new System.Windows.Forms.RichTextBox();
            this.btn_textCopy = new System.Windows.Forms.Button();
            this.btn_image = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_text
            // 
            this.rtb_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_text.Location = new System.Drawing.Point(12, 12);
            this.rtb_text.Name = "rtb_text";
            this.rtb_text.Size = new System.Drawing.Size(489, 324);
            this.rtb_text.TabIndex = 2;
            this.rtb_text.Text = "";
            // 
            // btn_textCopy
            // 
            this.btn_textCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_textCopy.BackColor = System.Drawing.SystemColors.Control;
            this.btn_textCopy.Location = new System.Drawing.Point(387, 342);
            this.btn_textCopy.Name = "btn_textCopy";
            this.btn_textCopy.Size = new System.Drawing.Size(114, 32);
            this.btn_textCopy.TabIndex = 3;
            this.btn_textCopy.Text = "Copy";
            this.btn_textCopy.UseVisualStyleBackColor = false;
            this.btn_textCopy.Click += new System.EventHandler(this.btn_textCopy_Click);
            // 
            // btn_image
            // 
            this.btn_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_image.BackColor = System.Drawing.SystemColors.Control;
            this.btn_image.Location = new System.Drawing.Point(267, 342);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(114, 32);
            this.btn_image.TabIndex = 4;
            this.btn_image.Text = "Image";
            this.btn_image.UseVisualStyleBackColor = false;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // frm_takeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 379);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.btn_textCopy);
            this.Controls.Add(this.rtb_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frm_takeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.Load += new System.EventHandler(this.frm_takeScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtb_text;
        private System.Windows.Forms.Button btn_textCopy;
        private System.Windows.Forms.Button btn_image;
    }
}