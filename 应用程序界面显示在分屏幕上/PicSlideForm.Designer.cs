namespace 应用程序界面显示在分屏幕上
{
    partial class PicSlideForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicSlideForm));
            this.pic_image = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_image
            // 
            this.pic_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_image.Location = new System.Drawing.Point(0, 0);
            this.pic_image.Name = "pic_image";
            this.pic_image.Size = new System.Drawing.Size(619, 645);
            this.pic_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_image.TabIndex = 0;
            this.pic_image.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PicSlideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 645);
            this.Controls.Add(this.pic_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PicSlideForm";
            this.Text = "PicSlideForm";
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_image;
        private System.Windows.Forms.Timer timer1;
    }
}