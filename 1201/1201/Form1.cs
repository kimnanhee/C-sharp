using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1201
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string url = "https://openapi.naver.com/v1/papago/n2mt";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("X-Naver-Client-Id", "iHNS1RXkO7msOQBUmsEc"); // Client ID
                request.Headers.Add("X-Naver-Client-Secret", "TlOV_isbSB"); // Client Secret
                request.Method = "POST";
                string query = textBox1.Text; // textBox1의 text 저장
                byte[] byteDataParams = Encoding.UTF8.GetBytes("source=ko&target=en&text=" + query);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteDataParams.Length;
                Stream st = request.GetRequestStream();
                st.Write(byteDataParams, 0, byteDataParams.Length);
                st.Close();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                string text = reader.ReadToEnd();
                stream.Close();
                response.Close();
                reader.Close();

                textBox2.Text = text; // textBox2에 text 써주기
            }
            else textBox2.Text = "";
        }
    }
}
