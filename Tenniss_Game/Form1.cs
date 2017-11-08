using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenniss_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Form1의 Mouse Move
        /// </summary>
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //마우스의 무브 이벤트에 대한 좌표 찾기
            //e는 마우스 이동에 대한 파라미터를 넘겨주는것
            //과거 코딩 : this.Text = e.X.ToString() + "   " + e.Y.ToString();
            string locationX = e.X.ToString();
            string locationY = e.Y.ToString();
            this.Text = $"Mouse 좌표({ locationX},  { locationY})";

            //top, bottom button은 좌우 이동 / R, L button은 상하 이동
            TopBar.Left = e.X;
            BottomBar.Left = TopBar.Left;
            LeftBar.Top = e.Y;
            RightBar.Top = LeftBar.Top;
        }

        /// <summary>
        /// Top & Bottom Bar의 Mouse Move
        /// </summary>
        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            TopBar.Left = TopBar.Left + e.X;
            BottomBar.Left = TopBar.Left;
        }

        /// <summary>
        /// Left & Right Bar의 Mouse Move 
        /// </summary>
        private void LeftBar_MouseMove(object sender, MouseEventArgs e)
        {
            LeftBar.Top = LeftBar.Top + e.Y;
            RightBar.Top = LeftBar.Top;
        }

        /// <summary>
        /// Ball의 움직임 
        /// </summary>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //
            // 폼에 Ball의 좌표 표시
            //
            this.Text = $"Ball의 좌표({(this.Ball.Left).ToString()}, {(this.Ball.Top).ToString()})";
            //
            // Ball의 스피드 증가
            int nSpeed = 2;
            //
            // 공이 날아가는 방향
            #region Location of Ball in Form1
            //
            //1시 방향
            if (this.Ball.Text == "1")
            {
                this.Ball.Left += 1 * nSpeed;
                this.Ball.Top -= 2 * nSpeed;
            }
            //
            //2시 방향
            else if (this.Ball.Text == "2")
            {
                this.Ball.Left += 2 * nSpeed;
                this.Ball.Top -= 1 * nSpeed;
            }
            //
            //3시 방향
            else if (this.Ball.Text == "3")
            {
                this.Ball.Left += 3 * nSpeed;
                this.Ball.Top -= 0 * nSpeed;
            }
            //
            //4시 방향
            else if (this.Ball.Text == "4")
            {
                this.Ball.Left += 2 * nSpeed;
                this.Ball.Top += 1 * nSpeed;
            }
            //
            //5시 방향
            else if (this.Ball.Text == "5")
            {
                this.Ball.Left += 1 * nSpeed;
                this.Ball.Top += 2 * nSpeed;
            }
            //
            //6시 방향
            else if (this.Ball.Text == "6")
            {
                this.Ball.Left += 0 * nSpeed;
                this.Ball.Top += 3 * nSpeed;
            }
            //
            //7시 방향
            else if (this.Ball.Text == "7")
            {
                this.Ball.Left -= 1 * nSpeed;
                this.Ball.Top += 2 * nSpeed;
            }
            //
            //8시 방향
            else if (this.Ball.Text == "8")
            {
                this.Ball.Left -= 2 * nSpeed;
                this.Ball.Top += 1 * nSpeed;
            }
            //
            //9시 방향
            else if (this.Ball.Text == "9")
            {
                this.Ball.Left -= 3 * nSpeed;
                this.Ball.Top += 0 * nSpeed;
            }
            //
            //10시 방향
            else if (this.Ball.Text == "10")
            {
                this.Ball.Left -= 2 * nSpeed;
                this.Ball.Top -= 1 * nSpeed;
            }
            //
            //11시 방향
            else if (this.Ball.Text == "11")
            {
                this.Ball.Left -= 1 * nSpeed;
                this.Ball.Top -= 2 * nSpeed;
            }
            //
            //12시 방향
            else if (this.Ball.Text == "12")
            {
                this.Ball.Left -= 0 * nSpeed;
                this.Ball.Top -= 3 * nSpeed;
            }
            #endregion
            //
            // 공이 폼 밖으로 나갔을 때 Game Over
            //
            #region Out of form1 of Ball
            if ((this.Ball.Left < 0) ||
                    (this.Ball.Right > this.ClientRectangle.Width) ||
                    (this.Ball.Top < 0) ||
                    (this.Ball.Bottom > this.ClientRectangle.Height))
            {
                this.Timer1.Enabled = false;
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Game Over");
            }
            #endregion
            //
            //Top Bar에 부딪혔을때 공이 1인 상태면 5로 변환(튕김)
            //
            if (this.TopBar.Bounds.Contains(this.Ball.Left, this.Ball.Top) && (Ball.Text == "1"))
            { 
                Ball.Text = "5";
            }
        }
        //
        // 폼에 마우스를 클릭했을 때.
        //
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //
            //오른쪽 클릭 하면 시계방향, 왼쪽 클릭하면 반시계 방향
            //
            if (e.Button == MouseButtons.Right) 
            {
                this.Ball.Text = (Convert.ToInt16(this.Ball.Text) + 1).ToString();

                if (this.Ball.Text == "13")
                {
                    this.Ball.Text = "1";
                }
            }
            else  
            {
                this.Ball.Text = (Convert.ToInt16(this.Ball.Text) - 1).ToString();
                if (this.Ball.Text == "0")
                {
                    this.Ball.Text = "12";
                }
            }
        }
    }
}

