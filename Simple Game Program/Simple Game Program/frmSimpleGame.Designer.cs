namespace Simple_Game_Program
{
    partial class frmSimpleGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimpleGame));
            this.lblLivesLabel = new System.Windows.Forms.Label();
            this.lblScoreLabel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLife = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.imgPaddle = new System.Windows.Forms.PictureBox();
            this.imgBall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBall)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLivesLabel
            // 
            this.lblLivesLabel.AutoSize = true;
            this.lblLivesLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivesLabel.Location = new System.Drawing.Point(12, 9);
            this.lblLivesLabel.Name = "lblLivesLabel";
            this.lblLivesLabel.Size = new System.Drawing.Size(54, 25);
            this.lblLivesLabel.TabIndex = 0;
            this.lblLivesLabel.Text = "Lives";
            // 
            // lblScoreLabel
            // 
            this.lblScoreLabel.AutoSize = true;
            this.lblScoreLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreLabel.Location = new System.Drawing.Point(514, 9);
            this.lblScoreLabel.Name = "lblScoreLabel";
            this.lblScoreLabel.Size = new System.Drawing.Size(58, 25);
            this.lblScoreLabel.TabIndex = 1;
            this.lblScoreLabel.Text = "Score";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Maroon;
            this.lblName.Location = new System.Drawing.Point(211, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 57);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ricochet";
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLife.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLife.Location = new System.Drawing.Point(17, 39);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(24, 27);
            this.lblLife.TabIndex = 3;
            this.lblLife.Text = "3";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(548, 39);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(24, 27);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.White;
            this.lblGameOver.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(238, 336);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(0, 25);
            this.lblGameOver.TabIndex = 5;
            // 
            // imgPaddle
            // 
            this.imgPaddle.Image = ((System.Drawing.Image)(resources.GetObject("imgPaddle.Image")));
            this.imgPaddle.Location = new System.Drawing.Point(260, 320);
            this.imgPaddle.Name = "imgPaddle";
            this.imgPaddle.Size = new System.Drawing.Size(50, 10);
            this.imgPaddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgPaddle.TabIndex = 6;
            this.imgPaddle.TabStop = false;
            // 
            // imgBall
            // 
            this.imgBall.BackColor = System.Drawing.Color.White;
            this.imgBall.Image = ((System.Drawing.Image)(resources.GetObject("imgBall.Image")));
            this.imgBall.Location = new System.Drawing.Point(47, 37);
            this.imgBall.Name = "imgBall";
            this.imgBall.Size = new System.Drawing.Size(10, 12);
            this.imgBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgBall.TabIndex = 7;
            this.imgBall.TabStop = false;
            this.imgBall.Click += new System.EventHandler(this.imgBall_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSimpleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.imgBall);
            this.Controls.Add(this.imgPaddle);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblScoreLabel);
            this.Controls.Add(this.lblLivesLabel);
            this.Name = "frmSimpleGame";
            this.Text = "Simple Game";
            this.Load += new System.EventHandler(this.frmSimpleGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLivesLabel;
        private System.Windows.Forms.Label lblScoreLabel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox imgPaddle;
        private System.Windows.Forms.PictureBox imgBall;
        private System.Windows.Forms.Timer timer1;
    }
}

