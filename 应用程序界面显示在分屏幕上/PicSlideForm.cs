using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 应用程序界面显示在分屏幕上
{
    public partial class PicSlideForm : Form
    {
        FileInfo[] files=null;
        public PicSlideForm()
        {
            InitializeComponent();

            //string[] directory = Directory.GetDirectories(Application.StartupPath + "\\Images");
             DirectoryInfo root = new DirectoryInfo(Application.StartupPath + "\\Images");
            files = root.GetFiles();
            if (files.Length == 0)
            {
                MessageBox.Show("请在Images文件夹中放入图片");             
            }
            else
            {
                timer1.Enabled = true;
                timer1.Interval = 30 * 1000;
                this.pic_image.Image = new Bitmap(Application.StartupPath + "\\Images" + "\\" + files[0]);
            }
            try
            {
                Screen[] screens = Screen.AllScreens;//获取当前所有显示屏
                Screen screenCurrent = Screen.FromControl(this);
                Screen otherScreen = null;
                int count = screens.Count();
                foreach (var item in screens)
                {
                    if (item.DeviceName != screenCurrent.DeviceName)
                    {
                        otherScreen = item;

                    }
                }
                this.Location = new Point(otherScreen.Bounds.Left + (screenCurrent.Bounds.Width - this.Width) / 2, (otherScreen.Bounds.Height - this.Height) / 2);//将窗口显示在第二个显示屏
                this.WindowState = FormWindowState.Maximized;
                //foreach (Form frm in Application.OpenForms)
                //{
                //    if (frm is PicSlideForm)
                //    {
                //        frm.StartPosition = FormStartPosition.Manual;
                //        frm.Location = new Point(otherScreen.Bounds.Left + (screenCurrent.Bounds.Width - this.Width) / 2, (otherScreen.Bounds.Height - this.Height) / 2);//将窗口显示在第二个显示屏
                //        frm.WindowState = FormWindowState.Maximized;
                //    }
                //}
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (files != null && files.Length > 0)
                {
                    this.pic_image.Image = new Bitmap(Application.StartupPath + "\\Images" + "\\" + files[i]);
                }
                if (i < files.Length - 1)
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
            }
            catch (Exception)
            {
                if (i < files.Length - 1)
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
                return;
            }
            
           

        }
    }
}
