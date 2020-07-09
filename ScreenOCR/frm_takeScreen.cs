using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;

namespace ScreenOCR
{
    public partial class frm_takeScreen : Form
    {
        public Image screenImage;
        public frm_takeScreen()
        {
            InitializeComponent();
        }

        private void btn_textCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb_text.Text);
        }

        private void btn_imageCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(screenImage);
        }

        private void frm_takeScreen_Load(object sender, EventArgs e)
        {
            AutoOcr Ocr = new AutoOcr();
            rtb_text.Text = Ocr.Read(screenImage).Text;
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            Form frm_open = new Form();

            frm_open.BackgroundImage = screenImage;
            frm_open.BackgroundImageLayout = ImageLayout.Stretch;
            frm_open.StartPosition = FormStartPosition.CenterScreen;

            frm_open.Show();
        }
    }
}
