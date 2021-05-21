using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random rand;
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) // 왼쪽 클릭
            {
                Color oldColor = this.BackColor;
                this.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            }
            else if(e.Button==MouseButtons.Right) // 오른쪽 클릭
            {
                if(this.BackgroundImage != null)
                {
                    this.BackgroundImage = null;
                }
                else
                {
                    string fname = "sample.jpg";
                    if (System.IO.File.Exists(fname) == false)
                        Console.WriteLine("이미지 파일이 없습니다.");
                    else
                        this.BackgroundImage = Image.FromFile(fname);
                }
            }
        }
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            this.Opacity = this.Opacity + (e.Delta > 0 ? 0.1 : -0.1);
            if (this.Opacity <= 0.1) this.Opacity = 0.1;
            Console.WriteLine("Opacity : {0}", this.Opacity);
        }
    }
}
