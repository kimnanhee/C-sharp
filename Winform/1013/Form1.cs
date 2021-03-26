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
        List<PictureBox> ball_list;
        public Form1()
        {
            InitializeComponent();
            make_arr(10); // 10개 배열 만들기
            timer1.Start();

            make_ball();
            ball_list = new List<PictureBox>(); // 공을 담을 리스트 생성
            // 왜 리스트? 동적이기 때문에
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) 
        {
            ball_list.Add(make_ball()); // 클릭 이벤트가 들어오면 공을 하나 생성해서 리스트에 추가한다
            // pictureBox1.Left = e.X; // 클릭한 위치로 이동
            // pictureBox1.Top = e.Y;
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
            Random r = new Random();
            for (int i=0; i<10; i++) // 10개 움직이기
            {
                pictureBox2[i].Top += r.Next(5, 20); // 랜덤값 더하기
                if (pictureBox2[i].Top > 700) pictureBox2[i].Top = -20; // 아래까지 내려왔으면 다시 위로
            }

            for(int i=0; i<ball_list.Count(); i++)
            {
                for(int j=0; j<10; j++) // 공과 사과의 충돌 검사
                {
                    if (pictureBox2[j].Top <= ball_list[i].Top && ball_list[i].Top <= pictureBox2[j].Top + pictureBox2[j].Height) // 사과와 공이 겹쳤을 때
                        if (pictureBox2[j].Left <= ball_list[i].Left && ball_list[i].Left <= pictureBox2[j].Left + pictureBox2[j].Width)
                        {
                            pictureBox2[j].Top = -50;
                            ball_list[i].Top = -10;
                        }
                }
                ball_list[i].Top -= 20;
                if (ball_list[i].Top < -50) ball_list.RemoveAt(i); // 위로 다 올라갔으면 리스트에서 삭제
            }
        }
    }
}
