namespace O_s_and_X_s
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
            this.PlayAgain = new System.Windows.Forms.Button();
            this.TopLeft = new System.Windows.Forms.Button();
            this.TopCenter = new System.Windows.Forms.Button();
            this.TopRight = new System.Windows.Forms.Button();
            this.CenterLeft = new System.Windows.Forms.Button();
            this.CenterCenter = new System.Windows.Forms.Button();
            this.CenterRight = new System.Windows.Forms.Button();
            this.BottomLeft = new System.Windows.Forms.Button();
            this.BottomCenter = new System.Windows.Forms.Button();
            this.BottomRight = new System.Windows.Forms.Button();
            this.labelTurn = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelXScore = new System.Windows.Forms.Label();
            this.labelO = new System.Windows.Forms.Label();
            this.labelOScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayAgain
            // 
            this.PlayAgain.Location = new System.Drawing.Point(12, 12);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(75, 23);
            this.PlayAgain.TabIndex = 0;
            this.PlayAgain.Text = "Play Again";
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // TopLeft
            // 
            this.TopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLeft.Location = new System.Drawing.Point(12, 41);
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(60, 60);
            this.TopLeft.TabIndex = 1;
            this.TopLeft.Text = "X";
            this.TopLeft.UseVisualStyleBackColor = true;
            this.TopLeft.Click += new System.EventHandler(this.XOButtonClicked);
            // 
            // TopCenter
            // 
            this.TopCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopCenter.Location = new System.Drawing.Point(78, 41);
            this.TopCenter.Name = "TopCenter";
            this.TopCenter.Size = new System.Drawing.Size(60, 60);
            this.TopCenter.TabIndex = 2;
            this.TopCenter.Text = "X";
            this.TopCenter.UseVisualStyleBackColor = true;
            this.TopCenter.Click += new System.EventHandler(this.XOButtonClicked);
            // 
            // TopRight
            // 
            this.TopRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopRight.Location = new System.Drawing.Point(144, 41);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(60, 60);
            this.TopRight.TabIndex = 3;
            this.TopRight.Text = "X";
            this.TopRight.UseVisualStyleBackColor = true;
            this.TopRight.Click += new System.EventHandler(this.XOButtonClicked);
            // 
            // CenterLeft
            // 
            this.CenterLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CenterLeft.Location = new System.Drawing.Point(12, 107);
            this.CenterLeft.Name = "CenterLeft";
            this.CenterLeft.Size = new System.Drawing.Size(60, 60);
            this.CenterLeft.TabIndex = 6;
            this.CenterLeft.Text = "X";
            this.CenterLeft.UseVisualStyleBackColor = true;
            this.CenterLeft.Click += new System.EventHandler(this.XOButtonClicked);
            // 
            // CenterCenter
            // 
            this.CenterCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CenterCenter.Location = new System.Drawing.Point(78, 107);
            this.CenterCenter.Name = "CenterCenter";
            this.CenterCenter.Size = new System.Drawing.Size(60, 60);
            this.CenterCenter.TabIndex = 5;
            this.CenterCenter.Text = "X";
            this.CenterCenter.UseVisualStyleBackColor = true;
            this.CenterCenter.Click += new System.EventHandler(this.XOButtonClicked);
            // 
            // CenterRight
            // 
            this.CenterRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CenterRight.Location = new System.Drawing.Point(144, 107);
            this.CenterRight.Name = "CenterRight";
            this.CenterRight.Size = new System.Drawing.Size(60, 60);
            this.CenterRight.TabIndex = 4;
            this.CenterRight.Text = "X";
            this.CenterRight.UseVisualStyleBackColor = true;
            this.CenterRight.Click += new System.EventHandler(this.XOButtonClicked);
            // 
            // BottomLeft
            // 
            this.BottomLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLeft.Location = new System.Drawing.Point(12, 173);
            this.BottomLeft.Name = "BottomLeft";
            this.BottomLeft.Size = new System.Drawing.Size(60, 60);
            this.BottomLeft.TabIndex = 9;
            this.BottomLeft.Text = "X";
            this.BottomLeft.UseVisualStyleBackColor = true;
            this.BottomLeft.Click += new System.EventHandler(this.XOButtonClicked);
            // 
            // BottomCenter
            // 
            this.BottomCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomCenter.Location = new System.Drawing.Point(78, 173);
            this.BottomCenter.Name = "BottomCenter";
            this.BottomCenter.Size = new System.Drawing.Size(60, 60);
            this.BottomCenter.TabIndex = 8;
            this.BottomCenter.Text = "X";
            this.BottomCenter.UseVisualStyleBackColor = true;
            this.BottomCenter.Click += new System.EventHandler(this.XOButtonClicked);
            // 
            // BottomRight
            // 
            this.BottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomRight.Location = new System.Drawing.Point(144, 173);
            this.BottomRight.Name = "BottomRight";
            this.BottomRight.Size = new System.Drawing.Size(60, 60);
            this.BottomRight.TabIndex = 7;
            this.BottomRight.Text = "X";
            this.BottomRight.UseVisualStyleBackColor = true;
            this.BottomRight.Click += new System.EventHandler(this.XOButtonClicked);
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Location = new System.Drawing.Point(93, 17);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(48, 13);
            this.labelTurn.TabIndex = 10;
            this.labelTurn.Text = "Turn = X";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(12, 239);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(54, 13);
            this.labelX.TabIndex = 11;
            this.labelX.Text = "Score: X=";
            // 
            // labelXScore
            // 
            this.labelXScore.AutoSize = true;
            this.labelXScore.Location = new System.Drawing.Point(72, 239);
            this.labelXScore.Name = "labelXScore";
            this.labelXScore.Size = new System.Drawing.Size(13, 13);
            this.labelXScore.TabIndex = 12;
            this.labelXScore.Text = "0";
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Location = new System.Drawing.Point(91, 239);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(55, 13);
            this.labelO.TabIndex = 13;
            this.labelO.Text = "Score: O=";
            // 
            // labelOScore
            // 
            this.labelOScore.AutoSize = true;
            this.labelOScore.Location = new System.Drawing.Point(151, 239);
            this.labelOScore.Name = "labelOScore";
            this.labelOScore.Size = new System.Drawing.Size(13, 13);
            this.labelOScore.TabIndex = 14;
            this.labelOScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 268);
            this.Controls.Add(this.labelOScore);
            this.Controls.Add(this.labelO);
            this.Controls.Add(this.labelXScore);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelTurn);
            this.Controls.Add(this.BottomLeft);
            this.Controls.Add(this.BottomCenter);
            this.Controls.Add(this.BottomRight);
            this.Controls.Add(this.CenterLeft);
            this.Controls.Add(this.CenterCenter);
            this.Controls.Add(this.CenterRight);
            this.Controls.Add(this.TopRight);
            this.Controls.Add(this.TopCenter);
            this.Controls.Add(this.TopLeft);
            this.Controls.Add(this.PlayAgain);
            this.Name = "Form1";
            this.Text = "O\'s and X\'s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Button TopLeft;
        private System.Windows.Forms.Button TopCenter;
        private System.Windows.Forms.Button TopRight;
        private System.Windows.Forms.Button CenterLeft;
        private System.Windows.Forms.Button CenterCenter;
        private System.Windows.Forms.Button CenterRight;
        private System.Windows.Forms.Button BottomLeft;
        private System.Windows.Forms.Button BottomCenter;
        private System.Windows.Forms.Button BottomRight;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelXScore;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.Label labelOScore;
    }
}

