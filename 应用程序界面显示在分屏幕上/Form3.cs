using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 应用程序界面显示在分屏幕上
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                MessageBox.Show("开始做任务");
                Thread.Sleep(3000);
                MessageBox.Show(" 任务结束");
            });
            MessageBox.Show("准备做另外的事情");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Task> tasks = new List<Task>();
            tasks.Add(Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("开始做一任务");
            }));
            tasks.Add(Task.Run(() =>
            {
                Thread.Sleep(5000);
                MessageBox.Show("开始做二任务");
            }));
            Task.WhenAll(tasks).ContinueWith(t =>
            {
                MessageBox.Show("准备做另外的事情");
            });

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            await Task.Run(() =>
            {
                while (true)
                {
                    progressBar1.Invoke(new Action(() =>
                    {
                        this.progressBar1.Value = random.Next(50, 100);
                    }));
                }
            });
        }
    }
}
