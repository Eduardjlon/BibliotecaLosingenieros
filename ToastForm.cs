using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaLosingenieros2
{
    public partial class ToastForm : Form
    {
        int toastX, toastY;
        public ToastForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ToastForm_Load(object sender, EventArgs e)
        {
            position();
        }
        private void position()
        {
            int screenwidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenhigth = Screen.PrimaryScreen.WorkingArea.Height;


            toastX = screenwidth - this.Width - 5;
            toastY = screenhigth - this.Height - 5;

            this.Location = new Point(toastX, toastY);
            // eso tingling 
        }

        private void ToastTimer_Tick_1(object sender, EventArgs e)
        {

            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if (toastY <= 800) ;
            ToastTimer.Stop();
            ToastHide.Start();
        }
        int y = 100;

        private void ToastHide_Tick_1(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                toastY += 10;
                this.Location = new Point(toastX, toastY = +10);
                if (toastY < 800)
                {
                    ToastHide.Stop();
                    y = 0;
                    this.Close();
                }
            }
        }
    }
}