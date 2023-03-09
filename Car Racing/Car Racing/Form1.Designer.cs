namespace Car_Racing
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pnlgame = new System.Windows.Forms.Panel();
			this.lblgameover = new System.Windows.Forms.Label();
			this.player = new System.Windows.Forms.PictureBox();
			this.car1 = new System.Windows.Forms.PictureBox();
			this.car2 = new System.Windows.Forms.PictureBox();
			this.L6 = new System.Windows.Forms.PictureBox();
			this.L5 = new System.Windows.Forms.PictureBox();
			this.L4 = new System.Windows.Forms.PictureBox();
			this.L3 = new System.Windows.Forms.PictureBox();
			this.L2 = new System.Windows.Forms.PictureBox();
			this.L1 = new System.Windows.Forms.PictureBox();
			this.lblscore = new System.Windows.Forms.Label();
			this.timeraction = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pnlgame.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.L6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.L5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.L4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.L3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.L2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.L1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlgame
			// 
			this.pnlgame.BackColor = System.Drawing.Color.Black;
			this.pnlgame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlgame.Controls.Add(this.lblgameover);
			this.pnlgame.Controls.Add(this.player);
			this.pnlgame.Controls.Add(this.car1);
			this.pnlgame.Controls.Add(this.car2);
			this.pnlgame.Controls.Add(this.L6);
			this.pnlgame.Controls.Add(this.L5);
			this.pnlgame.Controls.Add(this.L4);
			this.pnlgame.Controls.Add(this.L3);
			this.pnlgame.Controls.Add(this.L2);
			this.pnlgame.Controls.Add(this.L1);
			this.pnlgame.Location = new System.Drawing.Point(13, 60);
			this.pnlgame.Name = "pnlgame";
			this.pnlgame.Size = new System.Drawing.Size(439, 469);
			this.pnlgame.TabIndex = 0;
			// 
			// lblgameover
			// 
			this.lblgameover.BackColor = System.Drawing.Color.Gray;
			this.lblgameover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblgameover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lblgameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblgameover.ForeColor = System.Drawing.Color.Snow;
			this.lblgameover.Location = new System.Drawing.Point(100, 184);
			this.lblgameover.Name = "lblgameover";
			this.lblgameover.Size = new System.Drawing.Size(245, 74);
			this.lblgameover.TabIndex = 9;
			this.lblgameover.Text = "GAME OVER";
			this.lblgameover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblgameover.Visible = false;
			// 
			// player
			// 
			this.player.BackColor = System.Drawing.Color.Transparent;
			this.player.Image = global::Car_Racing.Properties.Resources.car4;
			this.player.Location = new System.Drawing.Point(202, 376);
			this.player.Name = "player";
			this.player.Size = new System.Drawing.Size(45, 80);
			this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.player.TabIndex = 6;
			this.player.TabStop = false;
			// 
			// car1
			// 
			this.car1.BackColor = System.Drawing.Color.Transparent;
			this.car1.Image = global::Car_Racing.Properties.Resources.car1;
			this.car1.Location = new System.Drawing.Point(12, 156);
			this.car1.Name = "car1";
			this.car1.Size = new System.Drawing.Size(45, 80);
			this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.car1.TabIndex = 8;
			this.car1.TabStop = false;
			// 
			// car2
			// 
			this.car2.BackColor = System.Drawing.Color.Transparent;
			this.car2.Image = global::Car_Racing.Properties.Resources.car0;
			this.car2.Location = new System.Drawing.Point(285, 53);
			this.car2.Name = "car2";
			this.car2.Size = new System.Drawing.Size(45, 80);
			this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.car2.TabIndex = 7;
			this.car2.TabStop = false;
			// 
			// L6
			// 
			this.L6.BackColor = System.Drawing.Color.White;
			this.L6.Location = new System.Drawing.Point(359, 265);
			this.L6.Name = "L6";
			this.L6.Size = new System.Drawing.Size(13, 147);
			this.L6.TabIndex = 5;
			this.L6.TabStop = false;
			// 
			// L5
			// 
			this.L5.BackColor = System.Drawing.Color.White;
			this.L5.Location = new System.Drawing.Point(359, 35);
			this.L5.Name = "L5";
			this.L5.Size = new System.Drawing.Size(13, 143);
			this.L5.TabIndex = 4;
			this.L5.TabStop = false;
			// 
			// L4
			// 
			this.L4.BackColor = System.Drawing.Color.White;
			this.L4.Location = new System.Drawing.Point(218, 265);
			this.L4.Name = "L4";
			this.L4.Size = new System.Drawing.Size(13, 147);
			this.L4.TabIndex = 3;
			this.L4.TabStop = false;
			// 
			// L3
			// 
			this.L3.BackColor = System.Drawing.Color.White;
			this.L3.Location = new System.Drawing.Point(218, 35);
			this.L3.Name = "L3";
			this.L3.Size = new System.Drawing.Size(13, 143);
			this.L3.TabIndex = 2;
			this.L3.TabStop = false;
			// 
			// L2
			// 
			this.L2.BackColor = System.Drawing.Color.White;
			this.L2.Location = new System.Drawing.Point(63, 265);
			this.L2.Name = "L2";
			this.L2.Size = new System.Drawing.Size(13, 147);
			this.L2.TabIndex = 1;
			this.L2.TabStop = false;
			// 
			// L1
			// 
			this.L1.BackColor = System.Drawing.Color.White;
			this.L1.Location = new System.Drawing.Point(63, 35);
			this.L1.Name = "L1";
			this.L1.Size = new System.Drawing.Size(13, 143);
			this.L1.TabIndex = 0;
			this.L1.TabStop = false;
			// 
			// lblscore
			// 
			this.lblscore.AutoSize = true;
			this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblscore.Location = new System.Drawing.Point(174, 18);
			this.lblscore.Name = "lblscore";
			this.lblscore.Size = new System.Drawing.Size(117, 29);
			this.lblscore.TabIndex = 1;
			this.lblscore.Text = "SCORE:0";
			// 
			// timeraction
			// 
			this.timeraction.Enabled = true;
			this.timeraction.Interval = 1;
			this.timeraction.Tick += new System.EventHandler(this.timeraction_Tick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = global::Car_Racing.Properties.Resources.pngtree_vector_shutdown_icon_png_image_1023349;
			this.pictureBox1.Location = new System.Drawing.Point(407, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(44, 43);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkCyan;
			this.ClientSize = new System.Drawing.Size(463, 541);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblscore);
			this.Controls.Add(this.pnlgame);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CAR GAME ";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			this.pnlgame.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.L6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.L5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.L4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.L3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.L2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.L1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlgame;
		private System.Windows.Forms.PictureBox L6;
		private System.Windows.Forms.PictureBox L5;
		private System.Windows.Forms.PictureBox L4;
		private System.Windows.Forms.PictureBox L3;
		private System.Windows.Forms.PictureBox L2;
		private System.Windows.Forms.PictureBox L1;
		private System.Windows.Forms.Label lblscore;
		private System.Windows.Forms.Timer timeraction;
		private System.Windows.Forms.PictureBox player;
		private System.Windows.Forms.PictureBox car1;
		private System.Windows.Forms.PictureBox car2;
		private System.Windows.Forms.Label lblgameover;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

