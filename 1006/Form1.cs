using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            make_arr(10); // 10개 배열 만들기
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) // 클릭한 위치로 이동
        {
            pictureBox1.Left = e.X;
            pictureBox1.Top = e.Y;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) // 눌린 키 값에 따라 이동
        {
            if (e.KeyData == Keys.Left) pictureBox1.Left -= 10;
            else if (e.KeyData == Keys.Right) pictureBox1.Left += 10;
            else if (e.KeyData == Keys.Up) pictureBox1.Top -= 10;
            else if (e.KeyData == Keys.Down) pictureBox1.Top += 10;
        }

        private void timer1_Tick(object sender, EventArgs e) // 0.1초마다 실행
        {
            for(int i=0; i<10; i++) // 10개 움직이기
            {
                pictureBox2[i].Top += 10;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
