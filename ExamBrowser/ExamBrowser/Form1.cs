using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ExamBrowser
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.panel1.Paint += panel1_Paint; // aktifkan custom paint
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 25;        // besar lengkungan
            int borderThickness = 2;      // tebal garis
            Color borderColor = Color.Gray;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = panel1.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            using (GraphicsPath path = GetRoundedPath(rect, borderRadius))
            using (Pen pen = new Pen(borderColor, borderThickness))
            {
                panel1.Region = new Region(path);  // bikin sudut panel rounded
                e.Graphics.DrawPath(pen, path);   // gambar border
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float r = radius;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();

            return path;
        }

        

        private void TBLogin_usn_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBLogin_pw_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            mapelLogin mapellogin = new mapelLogin();
            this.Hide();
            mapellogin.ShowDialog();
            this.Close();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
