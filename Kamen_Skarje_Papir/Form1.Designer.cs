namespace Kamen_Skarje_Papir
{
    partial class KamenSkarjePapir
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player1_score = new System.Windows.Forms.Label();
            this.player2_score = new System.Windows.Forms.Label();
            this.player2_highscore = new System.Windows.Forms.Label();
            this.player1_highscore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2 :";
            // 
            // player1_score
            // 
            this.player1_score.AutoSize = true;
            this.player1_score.Location = new System.Drawing.Point(86, 9);
            this.player1_score.Name = "player1_score";
            this.player1_score.Size = new System.Drawing.Size(16, 17);
            this.player1_score.TabIndex = 2;
            this.player1_score.Text = "0";
            // 
            // player2_score
            // 
            this.player2_score.AutoSize = true;
            this.player2_score.Location = new System.Drawing.Point(309, 9);
            this.player2_score.Name = "player2_score";
            this.player2_score.Size = new System.Drawing.Size(16, 17);
            this.player2_score.TabIndex = 3;
            this.player2_score.Text = "0";
            // 
            // player2_highscore
            // 
            this.player2_highscore.AutoSize = true;
            this.player2_highscore.Location = new System.Drawing.Point(366, 263);
            this.player2_highscore.Name = "player2_highscore";
            this.player2_highscore.Size = new System.Drawing.Size(16, 17);
            this.player2_highscore.TabIndex = 7;
            this.player2_highscore.Text = "0";
            // 
            // player1_highscore
            // 
            this.player1_highscore.AutoSize = true;
            this.player1_highscore.Location = new System.Drawing.Point(154, 263);
            this.player1_highscore.Name = "player1_highscore";
            this.player1_highscore.Size = new System.Drawing.Size(16, 17);
            this.player1_highscore.TabIndex = 6;
            this.player1_highscore.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Player 1 Highscore :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Player 2 Highscore :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(227, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.Lime;
            this.PlayBtn.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.Location = new System.Drawing.Point(12, 205);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(275, 55);
            this.PlayBtn.TabIndex = 11;
            this.PlayBtn.Text = "play";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.Red;
            this.ResetBtn.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Location = new System.Drawing.Point(293, 205);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(139, 55);
            this.ResetBtn.TabIndex = 12;
            this.ResetBtn.Text = "reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // KamenSkarjePapir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 287);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.player2_highscore);
            this.Controls.Add(this.player1_highscore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.player2_score);
            this.Controls.Add(this.player1_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KamenSkarjePapir";
            this.Text = "KamenSkarjePapir";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label player1_score;
        private System.Windows.Forms.Label player2_score;
        private System.Windows.Forms.Label player2_highscore;
        private System.Windows.Forms.Label player1_highscore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button ResetBtn;
    }
}

