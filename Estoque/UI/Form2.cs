using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class Form2 : Form
    {
        //Fields
        private int borderSize = 2;
        
        //Constructor 
        public Form2()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);// Border size
            this.BackColor = Color.FromArgb(35, 63, 102);// Border color
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        // Event methods
        private void Form2_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        // Private methods
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
                case FormWindowState.Minimized:
                    break;
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                default:
                    break;
            }
        }
    }
}
