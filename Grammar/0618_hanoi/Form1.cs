using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0618_hanoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DelaySystem(int MS) // 지연 함수
        {
            DateTime dtAfter = DateTime.Now;
            TimeSpan dtDuration = new TimeSpan(0, 0, 0, 0, MS); 
            DateTime dtThis = dtAfter.Add(dtDuration); 
            while (dtThis >= dtAfter)
            {
                System.Windows.Forms.Application.DoEvents();
                dtAfter = DateTime.Now; 
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false; // 버튼 비활성화

            int disk_num = int.Parse(comboBox2.SelectedItem.ToString());
            int delay_time = int.Parse(comboBox1.SelectedItem.ToString());
            int[] arr = { disk_num, 0, 0 }; // 각 폴에 있는 디스크의 개수

            for (int i = 0; i < disk_num; i++)
            {
                label6[i].Location = new Point(200, 500 - ((disk_num -i -1) * 30));
            }

            string[] lines = File.ReadAllLines("../../../0430_hanoi_writefile/bin/Debug/log.txt"); // 하노이탑 이동 결과가 기록되어있는 파일

            for (int i = (int)Math.Pow(2, disk_num) - 1 - disk_num; i < (int)Math.Pow(2, disk_num + 1) - 1 - disk_num - 1; i++)
            {
                string[] value = lines[i].Split(' '); // (disk num) (pole num) (from) (to)

                arr[(int)value[2][0] - (int)'A']--;
                arr[(int)value[3][0] - (int)'A']++;

                textBox1.Text = (i - ((int)Math.Pow(2, disk_num) - 1 - disk_num) + 1).ToString() + "/" + (Math.Pow(2, disk_num) - 1).ToString() + "    " + value[1] + " " + value[2] + "==>" + value[3];
                textBox2.Text = arr[0].ToString();
                textBox3.Text = arr[1].ToString();
                textBox4.Text = arr[2].ToString();

                label6[int.Parse(value[1]) - 1].Location = new Point((value[3][0] - 'A') * 200 + 200, 500 - ((arr[(int)value[3][0] - 'A']-1) * 30));

                DelaySystem(delay_time); // 지연
            }
            button1.Enabled = true; // 버튼 활성화
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 100; i <= 2000; i += 100) comboBox1.Items.Add(i); // 지연 시간 아이템 추가하기
            for (int i = 1; i <= 12; i++) comboBox2.Items.Add(i); // 폴 개수 아이템 추가하기
        }
    }
}
