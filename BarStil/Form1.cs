using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarStil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Kapatma Tuşu
        private void exitButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Küçültme Tuşu

        private void minButton_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        #endregion

        #region Tuş Fonksiyonları
        bool clicked = false;
        Point lastPos;
        private void bar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void bar_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
            lastPos = Cursor.Position;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            lastPos = Cursor.Position;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clicked)
            {
                int deltaX = Cursor.Position.X - lastPos.X;
                int deltaY = Cursor.Position.Y - lastPos.Y;
                this.Location = new Point(Location.X + deltaX, Location.Y + deltaY);
                lastPos = Cursor.Position;
            }
        }
        #endregion

    }
}
