using System.Windows.Forms;

namespace _1006
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_1006.Properties.Resources.토끼;
            this.pictureBox1.Location = new System.Drawing.Point(311, 503);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 700);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        void make_arr(int count) // 움직이는 사과 물체 만들기
        {
            // 
            // pictureBox2
            // 
            this.pictureBox2 = new System.Windows.Forms.PictureBox[count];
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            for (int i = 0; i < count; i++)
            {
                this.pictureBox2[i] = new System.Windows.Forms.PictureBox();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox2[i])).BeginInit();
                this.pictureBox2[i].Image = global::_1006.Properties.Resources.사과;
                this.pictureBox2[i].Location = new System.Drawing.Point(30+(60*i), 10); // 위치 설정
                this.pictureBox2[i].Name = "pictureBox2";
                this.pictureBox2[i].Size = new System.Drawing.Size(45, 50); // 크기 설정
                this.pictureBox2[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.pictureBox2[i].TabIndex = 2;
                this.pictureBox2[i].TabStop = false;
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox2[i])).EndInit();
                this.Controls.Add(this.pictureBox2[i]);
            }
        }

        PictureBox make_ball() // 쏘는 공 물체를 만들어서 반환
        {
            System.Windows.Forms.PictureBox pictureBox3;


            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = global::_1006.Properties.Resources.점;
            pictureBox3.Location = new System.Drawing.Point(pictureBox1.Left + 50, pictureBox1.Top);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(30, 30);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;


            Controls.Add(pictureBox3);
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();

            return pictureBox3;
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox[] pictureBox2;
    }
}

