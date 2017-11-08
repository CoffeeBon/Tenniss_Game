namespace Tenniss_Game
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
            this.TopBar = new System.Windows.Forms.Button();
            this.BottomBar = new System.Windows.Forms.Button();
            this.LeftBar = new System.Windows.Forms.Button();
            this.RightBar = new System.Windows.Forms.Button();
            this.Ball = new System.Windows.Forms.RadioButton();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TopBar.Location = new System.Drawing.Point(359, 23);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(290, 30);
            this.TopBar.TabIndex = 0;
            this.TopBar.Text = "T";
            this.TopBar.UseVisualStyleBackColor = true;
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            // 
            // BottomBar
            // 
            this.BottomBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BottomBar.Location = new System.Drawing.Point(359, 531);
            this.BottomBar.Name = "BottomBar";
            this.BottomBar.Size = new System.Drawing.Size(290, 30);
            this.BottomBar.TabIndex = 1;
            this.BottomBar.Text = "B";
            this.BottomBar.UseVisualStyleBackColor = true;
            this.BottomBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            // 
            // LeftBar
            // 
            this.LeftBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LeftBar.Location = new System.Drawing.Point(12, 151);
            this.LeftBar.Name = "LeftBar";
            this.LeftBar.Size = new System.Drawing.Size(30, 290);
            this.LeftBar.TabIndex = 2;
            this.LeftBar.Text = "L";
            this.LeftBar.UseVisualStyleBackColor = true;
            this.LeftBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftBar_MouseMove);
            // 
            // RightBar
            // 
            this.RightBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RightBar.Location = new System.Drawing.Point(967, 151);
            this.RightBar.Name = "RightBar";
            this.RightBar.Size = new System.Drawing.Size(30, 290);
            this.RightBar.TabIndex = 3;
            this.RightBar.Text = "R";
            this.RightBar.UseVisualStyleBackColor = true;
            this.RightBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftBar_MouseMove);
            // 
            // Ball
            // 
            this.Ball.AutoSize = true;
            this.Ball.Checked = true;
            this.Ball.Location = new System.Drawing.Point(232, 140);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(29, 16);
            this.Ball.TabIndex = 4;
            this.Ball.TabStop = true;
            this.Ball.Text = "4";
            this.Ball.UseVisualStyleBackColor = true;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 3;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(473, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1009, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.RightBar);
            this.Controls.Add(this.LeftBar);
            this.Controls.Add(this.BottomBar);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TopBar;
        private System.Windows.Forms.Button BottomBar;
        private System.Windows.Forms.Button LeftBar;
        private System.Windows.Forms.Button RightBar;
        private System.Windows.Forms.RadioButton Ball;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label label1;
    }
}

