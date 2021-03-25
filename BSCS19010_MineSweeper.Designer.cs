namespace minesweeper
{
    partial class MineSweeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MineSweeper));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.Intermediate = new System.Windows.Forms.RadioButton();
            this.Beginner = new System.Windows.Forms.RadioButton();
            this.board = new System.Windows.Forms.FlowLayoutPanel();
            this.Start = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Hard);
            this.panel1.Controls.Add(this.Intermediate);
            this.panel1.Controls.Add(this.Beginner);
            this.panel1.Location = new System.Drawing.Point(29, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 32);
            this.panel1.TabIndex = 3;
            // 
            // Hard
            // 
            this.Hard.AutoSize = true;
            this.Hard.BackColor = System.Drawing.Color.Black;
            this.Hard.ForeColor = System.Drawing.Color.Red;
            this.Hard.Location = new System.Drawing.Point(756, 3);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(60, 21);
            this.Hard.TabIndex = 3;
            this.Hard.TabStop = true;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = false;
            // 
            // Intermediate
            // 
            this.Intermediate.AutoSize = true;
            this.Intermediate.ForeColor = System.Drawing.Color.Yellow;
            this.Intermediate.Location = new System.Drawing.Point(427, 3);
            this.Intermediate.Name = "Intermediate";
            this.Intermediate.Size = new System.Drawing.Size(107, 21);
            this.Intermediate.TabIndex = 3;
            this.Intermediate.TabStop = true;
            this.Intermediate.Text = "Intermediate";
            this.Intermediate.UseVisualStyleBackColor = true;
            // 
            // Beginner
            // 
            this.Beginner.AutoSize = true;
            this.Beginner.ForeColor = System.Drawing.Color.Lime;
            this.Beginner.Location = new System.Drawing.Point(79, 3);
            this.Beginner.Name = "Beginner";
            this.Beginner.Size = new System.Drawing.Size(86, 21);
            this.Beginner.TabIndex = 3;
            this.Beginner.TabStop = true;
            this.Beginner.Text = "Beginner";
            this.Beginner.UseVisualStyleBackColor = true;
            // 
            // board
            // 
            this.board.ForeColor = System.Drawing.Color.FloralWhite;
            this.board.Location = new System.Drawing.Point(12, 140);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(1141, 360);
            this.board.TabIndex = 2;
            // 
            // Start
            // 
            this.Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start.BackgroundImage")));
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Start.ForeColor = System.Drawing.Color.Cornsilk;
            this.Start.Location = new System.Drawing.Point(57, 6);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(60, 78);
            this.Start.TabIndex = 0;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Start);
            this.panel2.Location = new System.Drawing.Point(421, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 87);
            this.panel2.TabIndex = 0;
            // 
            // MineSweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1147, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.board);
            this.Controls.Add(this.panel2);
            this.Name = "MineSweeper";
            this.Text = "MineSweeper";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Hard;
        private System.Windows.Forms.RadioButton Intermediate;
        private System.Windows.Forms.RadioButton Beginner;
        private System.Windows.Forms.FlowLayoutPanel board;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Panel panel2;
    }
}

