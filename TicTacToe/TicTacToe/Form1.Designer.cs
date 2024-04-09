namespace TicTacToe
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.box1 = new System.Windows.Forms.Button();
            this.box2 = new System.Windows.Forms.Button();
            this.box3 = new System.Windows.Forms.Button();
            this.box4 = new System.Windows.Forms.Button();
            this.box5 = new System.Windows.Forms.Button();
            this.box6 = new System.Windows.Forms.Button();
            this.box7 = new System.Windows.Forms.Button();
            this.box8 = new System.Windows.Forms.Button();
            this.box9 = new System.Windows.Forms.Button();
            this.Turn = new System.Windows.Forms.Label();
            this.Winner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box1.Location = new System.Drawing.Point(241, 80);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(100, 100);
            this.box1.TabIndex = 0;
            this.box1.UseVisualStyleBackColor = true;

            // 
            // box2
            // 
            this.box2.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box2.Location = new System.Drawing.Point(347, 80);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(100, 100);
            this.box2.TabIndex = 1;
            this.box2.UseVisualStyleBackColor = true;
            // 
            // box3
            // 
            this.box3.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box3.Location = new System.Drawing.Point(453, 80);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(100, 100);
            this.box3.TabIndex = 2;
            this.box3.UseVisualStyleBackColor = true;
            // 
            // box4
            // 
            this.box4.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box4.Location = new System.Drawing.Point(241, 186);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(100, 100);
            this.box4.TabIndex = 3;
            this.box4.UseVisualStyleBackColor = true;
            // 
            // box5
            // 
            this.box5.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box5.Location = new System.Drawing.Point(347, 186);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(100, 100);
            this.box5.TabIndex = 4;
            this.box5.UseVisualStyleBackColor = true;
            // 
            // box6
            // 
            this.box6.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box6.Location = new System.Drawing.Point(453, 186);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(100, 100);
            this.box6.TabIndex = 5;
            this.box6.UseVisualStyleBackColor = true;
            // 
            // box7
            // 
            this.box7.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box7.Location = new System.Drawing.Point(241, 292);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(100, 100);
            this.box7.TabIndex = 6;
            this.box7.UseVisualStyleBackColor = true;
            // 
            // box8
            // 
            this.box8.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box8.Location = new System.Drawing.Point(347, 292);
            this.box8.Name = "box8";
            this.box8.Size = new System.Drawing.Size(100, 100);
            this.box8.TabIndex = 7;
            this.box8.UseVisualStyleBackColor = true;
            // 
            // box9
            // 
            this.box9.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box9.Location = new System.Drawing.Point(453, 292);
            this.box9.Name = "box9";
            this.box9.Size = new System.Drawing.Size(100, 100);
            this.box9.TabIndex = 8;
            this.box9.UseVisualStyleBackColor = true;
            // 
            // Turn
            // 
            this.Turn.AutoSize = true;
            this.Turn.Font = new System.Drawing.Font("Jokerman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turn.Location = new System.Drawing.Point(341, 408);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(84, 33);
            this.Turn.TabIndex = 9;
            this.Turn.Text = "Turn: ";
            // 
            // Winner
            // 
            this.Winner.AutoSize = true;
            this.Winner.Font = new System.Drawing.Font("Jokerman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winner.Location = new System.Drawing.Point(312, 20);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(174, 33);
            this.Winner.TabIndex = 10;
            this.Winner.Text = "The winner is:";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Winner);
            this.Controls.Add(this.Turn);
            this.Controls.Add(this.box9);
            this.Controls.Add(this.box8);
            this.Controls.Add(this.box7);
            this.Controls.Add(this.box6);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button box1;
        private System.Windows.Forms.Button box2;
        private System.Windows.Forms.Button box3;
        private System.Windows.Forms.Button box4;
        private System.Windows.Forms.Button box5;
        private System.Windows.Forms.Button box6;
        private System.Windows.Forms.Button box7;
        private System.Windows.Forms.Button box8;
        private System.Windows.Forms.Button box9;
        private System.Windows.Forms.Label Turn;
        private System.Windows.Forms.Label Winner;
    }
}

