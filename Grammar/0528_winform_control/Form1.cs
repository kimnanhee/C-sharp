using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0528_winform_control
{
    public partial class Form1 : Form
    {
        Random random = new Random(37);

        public Form1()
        {
            InitializeComponent();

            listView1.Columns.Add("Name");
            listView1.Columns.Add("Depth");
        }

        void ChangeFont()
        {
            if (comboBox1.SelectedIndex < 0)
                return;

            FontStyle style = FontStyle.Regular;

            if (checkBox1.Checked)
                style |= FontStyle.Bold;

            if (checkBox2.Checked)
                style |= FontStyle.Italic;

            textBox1.Font = new Font((string)comboBox1.SelectedItem, 10, style);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // comboBox
        {
            ChangeFont();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) // Bold
        {
            ChangeFont();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) // Italic
        {
            ChangeFont();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var fonts = FontFamily.Families; // 폰트 목록 검색
            foreach (FontFamily font in fonts)
                comboBox1.Items.Add(font.Name);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value; // 트랙바의 스크롤 정도에 따라 프로그레스 바의 스크롤 변경
        }

        private void button1_Click(object sender, EventArgs e) // Modal
        {
            Form fom = new Form();
            fom.Text = "Modal Form";
            fom.Width = 300;
            fom.Height = 100;
            fom.BackColor = Color.Red;
            fom.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) // Modaless
        {
            Form fom = new Form();
            fom.Text = "Modeless Form";
            fom.Width = 300;
            fom.Height = 100;
            fom.BackColor = Color.Blue;
            fom.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) // MessageBox
        {
            MessageBox.Show(textBox1.Text, "MessageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        void TreeToList()
        {
            listView1.Items.Clear();
            foreach (TreeNode node in treeView1.Nodes)
                TreeToList(node);
        }
        void TreeToList(TreeNode Node)
        {
            listView1.Items.Add(
                new ListViewItem(
                    new string[] { Node.Text, 
                        Node.FullPath.Count(f => f == '\\').ToString() }));

            foreach (TreeNode node in Node.Nodes)
                TreeToList(node);
        }
        private void button4_Click(object sender, EventArgs e) // 루트추가
        {
            treeView1.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        private void button5_Click(object sender, EventArgs e) // 자식추가
        {
            if(treeView1.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.", "TreeView Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            treeView1.SelectedNode.Nodes.Add(random.Next().ToString());
            treeView1.SelectedNode.Expand();
            TreeToList();
        }
    }
}
