using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenOCR
{
    public partial class frm_screenOcr : Form
    {
        public frm_screenOcr()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            ControlBox = false;
            Text = String.Empty;
            Size = new Size(250, 200);
            StartPosition = FormStartPosition.CenterScreen;

            btn_screenShot.Location = new Point(ClientSize.Width / 2 - btn_screenShot.Size.Width / 2, ClientSize.Height / 2 - btn_screenShot.Size.Height / 2);
            btn_screenShot.Anchor = AnchorStyles.None;
            btn_screenShot.Cursor = Cursors.Hand;

            AcceptButton = btn_screenShot;

            KeyPreview = true;

            KeyboardHook hook = new KeyboardHook(true);
            hook.KeyDown += Hook_KeyDown;

            ni_screenOcr.ContextMenuStrip = new ContextMenuStrip();
            ni_screenOcr.ContextMenuStrip.Items.Add("Open", null, (object sender, EventArgs e) => Show());
            ni_screenOcr.ContextMenuStrip.Items.Add("Exit", null, (object sender, EventArgs e) => Application.Exit());
        }



        private void Hook_KeyDown(Keys key, bool Shift, bool Ctrl, bool Alt)
        {
            if (key == Keys.PrintScreen)
            {
                Show();
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        private void frm_screenOcr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Hide();
            }
        }

        private void btn_screenShot_Click(object sender, EventArgs e)
        {
            Hide();

            frm_takeScreen frm_open = new frm_takeScreen();

            Rectangle rect = new Rectangle(Location.X, Location.Y, Width, Height);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, Size, CopyPixelOperation.SourceCopy);
            frm_open.screenImage = bmp;

            frm_open.Show();
        }

        private void frm_screenOcr_Shown(object sender, EventArgs e)
        {
            Hide();
        }

        private void ni_screenOcr_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }
    }
}
