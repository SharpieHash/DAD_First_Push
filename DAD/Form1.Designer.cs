﻿namespace DAD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gamesetupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dungeons and Dragons";
            // 
            // gamesetupBtn
            // 
            this.gamesetupBtn.BackColor = System.Drawing.Color.Transparent;
            this.gamesetupBtn.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesetupBtn.Location = new System.Drawing.Point(53, 76);
            this.gamesetupBtn.Name = "gamesetupBtn";
            this.gamesetupBtn.Size = new System.Drawing.Size(283, 79);
            this.gamesetupBtn.TabIndex = 2;
            this.gamesetupBtn.Text = "Game Setup";
            this.gamesetupBtn.UseVisualStyleBackColor = false;
            this.gamesetupBtn.Click += new System.EventHandler(this.gamesetupBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(416, 192);
            this.Controls.Add(this.gamesetupBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Name = "Form1";
            this.Text = "Dungeons and Dragons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gamesetupBtn;
    }
}

