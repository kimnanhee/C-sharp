namespace _1020
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(595, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        void make_arr(int count)
        {
            this.label1 = new System.Windows.Forms.Label[count];
            this.panel1 = new System.Windows.Forms.Panel[count];

            for (int i=0;i <count; i++)
            {
                this.label1[i] = new System.Windows.Forms.Label();
                this.panel1[i] = new System.Windows.Forms.Panel();
                // 
                // panel1
                // 
                this.panel1[i].BackColor = System.Drawing.Color.White;
                this.panel1[i].Location = new System.Drawing.Point(20 + (i % 5) * 100, 20 + (i / 5) * 80);
                this.panel1[i].Name = "panel1";
                this.panel1[i].Size = new System.Drawing.Size(80, 50);
                this.panel1[i].TabIndex = 0;
                this.Controls.Add(this.panel1[i]);

                // 
                // label1
                // 
                this.label1[i].AutoSize = true;
                this.label1[i].Location = new System.Drawing.Point(5, 5);
                this.label1[i].Name = "label1";
                this.label1[i].Size = new System.Drawing.Size(150, 100);
                this.label1[i].TabIndex = 0;
                this.label1[i].Text = "" + (i + 1);
                this.panel1[i].Controls.Add(this.label1[i]);
            }
        }
        private System.Windows.Forms.Label[] label1;
        private System.Windows.Forms.Panel[] panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

