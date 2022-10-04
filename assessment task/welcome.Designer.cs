namespace assessment_task
{
    partial class welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.easyButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hardbutton = new System.Windows.Forms.Button();
            this.highScoreDisplay1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.highScoreDisplay2 = new System.Windows.Forms.Label();
            this.highScoreDisplay3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.Color.Transparent;
            this.easyButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.easyButton.ForeColor = System.Drawing.Color.Indigo;
            this.easyButton.Location = new System.Drawing.Point(434, 598);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(100, 50);
            this.easyButton.TabIndex = 2;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(365, 368);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 38);
            this.textBox1.TabIndex = 4;
            // 
            // hardbutton
            // 
            this.hardbutton.BackColor = System.Drawing.Color.Transparent;
            this.hardbutton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hardbutton.ForeColor = System.Drawing.Color.Indigo;
            this.hardbutton.Location = new System.Drawing.Point(736, 598);
            this.hardbutton.Name = "hardbutton";
            this.hardbutton.Size = new System.Drawing.Size(100, 50);
            this.hardbutton.TabIndex = 6;
            this.hardbutton.Text = "Hard";
            this.hardbutton.UseVisualStyleBackColor = false;
            this.hardbutton.Click += new System.EventHandler(this.hardbutton_Click);
            // 
            // highScoreDisplay1
            // 
            this.highScoreDisplay1.AutoSize = true;
            this.highScoreDisplay1.BackColor = System.Drawing.Color.RoyalBlue;
            this.highScoreDisplay1.Font = new System.Drawing.Font("Ink Free", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.highScoreDisplay1.ForeColor = System.Drawing.Color.White;
            this.highScoreDisplay1.Location = new System.Drawing.Point(1063, 384);
            this.highScoreDisplay1.Name = "highScoreDisplay1";
            this.highScoreDisplay1.Size = new System.Drawing.Size(195, 37);
            this.highScoreDisplay1.TabIndex = 10;
            this.highScoreDisplay1.Text = " high score 1  ";
            this.highScoreDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 13;
            // 
            // highScoreDisplay2
            // 
            this.highScoreDisplay2.AutoSize = true;
            this.highScoreDisplay2.BackColor = System.Drawing.Color.RoyalBlue;
            this.highScoreDisplay2.Font = new System.Drawing.Font("Ink Free", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.highScoreDisplay2.ForeColor = System.Drawing.Color.White;
            this.highScoreDisplay2.Location = new System.Drawing.Point(1063, 422);
            this.highScoreDisplay2.Name = "highScoreDisplay2";
            this.highScoreDisplay2.Size = new System.Drawing.Size(194, 37);
            this.highScoreDisplay2.TabIndex = 15;
            this.highScoreDisplay2.Text = " high score 2 ";
            // 
            // highScoreDisplay3
            // 
            this.highScoreDisplay3.AutoSize = true;
            this.highScoreDisplay3.BackColor = System.Drawing.Color.RoyalBlue;
            this.highScoreDisplay3.Font = new System.Drawing.Font("Ink Free", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.highScoreDisplay3.ForeColor = System.Drawing.Color.White;
            this.highScoreDisplay3.Location = new System.Drawing.Point(1063, 460);
            this.highScoreDisplay3.Name = "highScoreDisplay3";
            this.highScoreDisplay3.Size = new System.Drawing.Size(194, 37);
            this.highScoreDisplay3.TabIndex = 16;
            this.highScoreDisplay3.Text = " high score 3 ";
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::assessment_task.Properties.Resources.twinkle_twinkle;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.highScoreDisplay3);
            this.Controls.Add(this.highScoreDisplay2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.highScoreDisplay1);
            this.Controls.Add(this.hardbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.easyButton);
            this.Name = "welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button easyButton;
        private TextBox textBox1;
        private Button hardbutton;
        private Label highScoreDisplay1;
        private Label label7;
        private Label label8;
        private Label highScoreDisplay2;
        private Label highScoreDisplay3;
    }
}