using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            make_arr(20);
            arr_random();
        }
        private void arr_random()
        {
            Random rand = new Random();
            for(int i=0; i < panel1.Length; i++)
            {
                int k = rand.Next(0, panel1.Length);
                string tmp = label1[i].Text;
                label1[i].Text = label1[k].Text;
                label1[k].Text = tmp;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            try 
            { 
                num = int.Parse(textBox1.Text); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("숫자를 입력하세요.");
            }
            for (int i = 0; i < panel1.Length; i++)
                panel1[i].Visible = false;

            make_arr(num);
            arr_random();
        }
    }
}
