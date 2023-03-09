using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		enum Direction
		{
			Left, Right, None
		}
		int speed = 5;
		int score = 0;
		Random random = new Random();
		Direction direction = Direction.None;
		private void timeraction_Tick(object sender, EventArgs e)
		{
			score++;
			lblscore.Text = "Score: " + score;
			if (score > 1000)
			{
				speed = 7;
			}
			if (score>1500)
			{
				speed = 8;
			}
			if(score>1700)
			{
				speed = 9;
			}
			L1.Top += speed;
			L2.Top += speed;
			L3.Top += speed;
			L4.Top += speed;
			L5.Top += speed;
			L6.Top += speed;

			if (L1.Top > pnlgame.Height)
			{
				L1.Top = -L1.Height;
			}

			if (L2.Top > pnlgame.Height)
			{
				L2.Top = -L2.Height;
			}

			if (L3.Top > pnlgame.Height)
			{
				L3.Top = -L3.Height;
			}

			if (L4.Top > pnlgame.Height)
			{
				L4.Top = -L4.Height;
			}

			if (L5.Top > pnlgame.Height)
			{
				L5.Top = -L5.Height;
			}

			if (L6.Top > pnlgame.Height)
			{
				L6.Top = -L6.Height;
			}

			if (direction == Direction.Left && player.Left > 5)
			{
				player.Left -= speed;
			}

			if (direction == Direction.Right && player.Right < pnlgame.Width - 10)
			{
				player.Left += speed;
			}

			if (car1.Visible)
			{
				car1.Top += speed;
			}

			//car1
			if (car1.Top > pnlgame.Height)
			{
				car1.Visible = false;
				car1.Top = -car1.Height;
				car1.Left = random.Next((pnlgame.Width - car1.Width) / 2);
				car1.Visible = true;
			}

			//car2
			if (car2.Visible)
			{
				car2.Top += speed;
			}

			if (car2.Top > pnlgame.Height)
			{
				car2.Visible = false;
				car2.Top = -car1.Height;
				car2.Left = random.Next(pnlgame.Width / 2, pnlgame.Width - car2.Width);
				car2.Visible = true;
			}
			if (player.Bounds.IntersectsWith(car1.Bounds) || player.Bounds.IntersectsWith(car2.Bounds))
			{
				lblgameover.Visible = true;
				timeraction.Enabled = false;
				SoundPlayer soundPlayer = new SoundPlayer("www.wav");
				soundPlayer.Play();
			}

			if (score==20)
			{
				SoundPlayer simpleSound = new SoundPlayer("car-honk-1.wav");
				simpleSound.Play();
			}


		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Left)
			{
				direction = Direction.Left;
			}

			else if (e.KeyData == Keys.Right)
			{
				direction = Direction.Right;
			}

			else
			{
				direction = Direction.None;
			}

			if(lblgameover.Visible)
			{
				if (e.KeyData == Keys.Space)
				{
					lblgameover.Visible = false;
					player.Left = pnlgame.Width / 2 - 40;
					car1.Left = 0;
					car2.Left = pnlgame.Width - car2.Width;
					speed = 5;
					score = 0;
					timeraction.Enabled = true;
				}
				else
				{
					timeraction.Enabled = false;
				}
			}
			

		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			direction = Direction.None;
			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
