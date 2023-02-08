using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 应用程序界面显示在分屏幕上
{
    public partial class Form1 : Form
    {
        Screen[] ss = Screen.AllScreens;

        public Form1()
        {
            InitializeComponent();
            CenterToParent();

        }
        public event EventHandler<DataReceivedEventArgs> OnDataReceived;
        private void button1_Click(object sender, EventArgs e)
        {
            string CurrentScreenName = Screen.FromControl(this).DeviceName;
            MessageBox.Show(CurrentScreenName);
            Screen[] ss = Screen.AllScreens;
            MessageBox.Show(ss[0].DeviceName + ss[1].DeviceName);
            //获取程序显示的名称
            // string CurrentScreenName = Screen.FromControl(this).DeviceName;
            // MessageBox.Show(CurrentScreenName);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Screen CurrentScreen = Screen.FromControl(this);
        }





        //protected override void OnShown(EventArgs e)
        //{
        //    //Screen[] sc = Screen.AllScreens;
        //    //if (sc.Count() == 2)
        //    //{
        //    //    //我的显示器sc[0]是第二块屏幕，
        //      // this.Left = sc[0].Bounds.Left + (sc[1].Bounds.Width - this.Width) / 2;
        //     //     this.Top = (sc[0].Bounds.Height - this.Height) / 2;
        //    //}
        //    base.OnShown(e);
        //}
        /// <summary>
        /// 显示在指定的屏幕上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
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
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is PicSlideForm)
                    {
                        frm.StartPosition = FormStartPosition.Manual;
                        frm.Location = new Point(otherScreen.Bounds.Left + (screenCurrent.Bounds.Width - this.Width) / 2, (otherScreen.Bounds.Height - this.Height) / 2);//将窗口显示在第二个显示屏
                        frm.WindowState = FormWindowState.Maximized;
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "选择图片";
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "*.jpg,*.png,*.jpeg,*.bmp)|*.bmp;*.jpg;*.png;*.jpeg;*.gif;";
                openFileDialog.FileName = string.Empty;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;//文件路径
                    if (string.IsNullOrEmpty(path))
                    {
                        return;
                    }
                    string name = System.IO.Path.GetFileName(path);//获取文件名称名称
                    this.pictureBox1.Image = new Bitmap(path);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //if (this.pictureBox1.Image != null)
                //{
                  PicSlideForm frm = new PicSlideForm();
                    //frm.BackgroundImage = this.pictureBox1.Image;
                    //frm.BackgroundImageLayout = ImageLayout.Stretch;
                    //foreach (var item in frm.Controls)
                    //{
                    //    PictureBox pic = item as PictureBox;
                    //    pic.Image = this.pictureBox1.Image;
                    //}
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Show();
                //}
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
