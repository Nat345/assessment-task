﻿namespace assessment_task
{
    partial class endGame
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
            this.scorelabel = new System.Windows.Forms.Label();
            this.timetakenlabeldisplay = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.againButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Font = new System.Drawing.Font("Ink Free", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scorelabel.Location = new System.Drawing.Point(645, 331);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(78, 34);
            this.scorelabel.TabIndex = 0;
            this.scorelabel.Text = "label1";
            // 
            // timetakenlabeldisplay
            // 
            this.timetakenlabeldisplay.AutoSize = true;
            this.timetakenlabeldisplay.Font = new System.Drawing.Font("Ink Free", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timetakenlabeldisplay.Location = new System.Drawing.Point(645, 437);
            this.timetakenlabeldisplay.Name = "timetakenlabeldisplay";
            this.timetakenlabeldisplay.Size = new System.Drawing.Size(78, 34);
            this.timetakenlabeldisplay.TabIndex = 1;
            this.timetakenlabeldisplay.Text = "label1";
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Ink Free", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnButton.Location = new System.Drawing.Point(805, 587);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(133, 76);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "Home";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // againButton
            // 
            this.againButton.Font = new System.Drawing.Font("Ink Free", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.againButton.Location = new System.Drawing.Point(441, 587);
            this.againButton.Name = "againButton";
            this.againButton.Size = new System.Drawing.Size(144, 76);
            this.againButton.TabIndex = 3;
            this.againButton.Text = "Play Again";
            this.againButton.UseVisualStyleBackColor = true;
            this.againButton.Click += new System.EventHandler(this.againButton_Click);
            // 
            // endGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::assessment_task.Properties.Resources.endgamebg;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.againButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.timetakenlabeldisplay);
            this.Controls.Add(this.scorelabel);
            this.Name = "endGame";
            this.Text = "endGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label scorelabel;
        private Label timetakenlabeldisplay;
        private Button returnButton;
        private Button againButton;
    }
}