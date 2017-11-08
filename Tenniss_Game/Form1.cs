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

        private void TopButton_MouseMove(object sender, MouseEventArgs e)
        {
            TopBar.Left = TopBar.Left + e.X;
            BottomBar.Left = TopBar.Left;
        }

        //private void BotButton_MouseMove(object sender, MouseEventArgs e)
        //{
        //    TopButton.Left = TopButton.Left + e.X;
        //    BotButton.Left = TopButton.Left;
        //}

        private void LeftButton_MouseMove(object sender, MouseEventArgs e)
        {
            LeftBar.Top = LeftBar.Top + e.Y;
            RightBar.Top = LeftBar.Top;
        }

        //private void RightButton_MouseMove(object sender, MouseEventArgs e)
        //{
        //    LeftButton.Top = LeftButton.Top + e.Y;
        //    RightButton.Top = LeftButton.Top;
        //}

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Text = $"Ball의 좌표({(this.Ball.Left).ToString()}, {(this.Ball.Top).ToString()})";

            if (this.Ball.Text == "1")
            {
                this.Ball.Left += 1;
                this.Ball.Top -= 2;
            }
            else if (this.Ball.Text == "2")
            {
                this.Ball.Left += 2;
                this.Ball.Top -= 1;
            }
            else if (this.Ball.Text == "3")
            {
                this.Ball.Left += 3;
                this.Ball.Top -= 0;
            }
            else if (this.Ball.Text == "4")
            {
                this.Ball.Left += 2;
                this.Ball.Top += 1;
            }
            else if (this.Ball.Text == "5")
            {
                this.Ball.Left += 1;
                this.Ball.Top += 2;
            }
            else if (this.Ball.Text == "6")
            {
                this.Ball.Left += 0;
                this.Ball.Top += 3;
            }
            else if (this.Ball.Text == "7")
            {
                this.Ball.Left -= 1;
                this.Ball.Top += 2;
            }
            else if (this.Ball.Text == "8")
            {
                this.Ball.Left -= 2;
                this.Ball.Top += 1;
            }
            else if (this.Ball.Text == "9")
            {
                this.Ball.Left -= 3;
                this.Ball.Top += 0;
            }
            else if (this.Ball.Text == "10")
            {
                this.Ball.Left -= 2;
                this.Ball.Top -= 1;
            }
            else if (this.Ball.Text == "11")
            {
                this.Ball.Left -= 1;
                this.Ball.Top -= 2;
            }
            else if (this.Ball.Text == "12")
            {
                this.Ball.Left -= 0;
                this.Ball.Top -= 3;
            }

            if ((this.Ball.Left < 0) || 
                (this.Ball.Right > this.ClientRectangle.Width) || 
                (this.Ball.Top < 0) || 
                (this.Ball.Bottom > this.ClientRectangle.Height))
            {
                this.Timer1.Enabled = false;
                MessageBox.Show("Game Over");
            }

            if (this.TopBar.Bounds.Contains(this.Ball.Left, this.Ball.Top) && (Ball.Text == "1"))
            { //Top Bar에 부딪혔을때 공이 1인 상태면 5로 변환(튕김)
                Ball.Text = "5";
            }

            //TopButton  테두리 안에 라디오 버튼 테두리가 있나?
            if ((this.BottomBar.Bounds.Contains(this.Ball.Left, this.Ball.Top) == true) ||
                (this.LeftBar.Bounds.Contains(this.Ball.Left, this.Ball.Top) == true) ||
                (this.RightBar.Bounds.Contains(this.Ball.Left, this.Ball.Top) == true))
            {
                this.Timer1.Enabled = false;
                MessageBox.Show("충돌감지");
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) //오른쪽 클릭 하면 시계방향
            {
                this.Ball.Text = (Convert.ToInt16(this.Ball.Text) + 1).ToString();

                if (this.Ball.Text == "13")
                {
                    this.Ball.Text = "1";
                }
            }
            else  //왼쪽 클릭 하면 반시계방향
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

