namespace DAD
{
    partial class dungeonMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dungeonMaster));
            this.panel1 = new System.Windows.Forms.Panel();
            this.locationFourBtn = new System.Windows.Forms.Button();
            this.locationTwoBtn = new System.Windows.Forms.Button();
            this.locationThreeBtn = new System.Windows.Forms.Button();
            this.locationOneBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.locationFourBtn);
            this.panel1.Controls.Add(this.locationTwoBtn);
            this.panel1.Controls.Add(this.locationThreeBtn);
            this.panel1.Controls.Add(this.locationOneBtn);
            this.panel1.Location = new System.Drawing.Point(12, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 306);
            this.panel1.TabIndex = 0;
            // 
            // locationFourBtn
            // 
            this.locationFourBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("locationFourBtn.BackgroundImage")));
            this.locationFourBtn.Location = new System.Drawing.Point(275, 167);
            this.locationFourBtn.Name = "locationFourBtn";
            this.locationFourBtn.Size = new System.Drawing.Size(240, 125);
            this.locationFourBtn.TabIndex = 3;
            this.locationFourBtn.Text = "button4";
            this.locationFourBtn.UseVisualStyleBackColor = true;
            this.locationFourBtn.Click += new System.EventHandler(this.locationFourBtn_Click);
            // 
            // locationTwoBtn
            // 
            this.locationTwoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("locationTwoBtn.BackgroundImage")));
            this.locationTwoBtn.Location = new System.Drawing.Point(275, 14);
            this.locationTwoBtn.Name = "locationTwoBtn";
            this.locationTwoBtn.Size = new System.Drawing.Size(240, 125);
            this.locationTwoBtn.TabIndex = 2;
            this.locationTwoBtn.Text = "button3";
            this.locationTwoBtn.UseVisualStyleBackColor = true;
            this.locationTwoBtn.Click += new System.EventHandler(this.locationTwoBtn_Click);
            // 
            // locationThreeBtn
            // 
            this.locationThreeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("locationThreeBtn.BackgroundImage")));
            this.locationThreeBtn.Location = new System.Drawing.Point(14, 167);
            this.locationThreeBtn.Name = "locationThreeBtn";
            this.locationThreeBtn.Size = new System.Drawing.Size(240, 125);
            this.locationThreeBtn.TabIndex = 1;
            this.locationThreeBtn.Text = "button2";
            this.locationThreeBtn.UseVisualStyleBackColor = true;
            this.locationThreeBtn.Click += new System.EventHandler(this.locationThreeBtn_Click);
            // 
            // locationOneBtn
            // 
            this.locationOneBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("locationOneBtn.BackgroundImage")));
            this.locationOneBtn.Location = new System.Drawing.Point(14, 14);
            this.locationOneBtn.Name = "locationOneBtn";
            this.locationOneBtn.Size = new System.Drawing.Size(240, 125);
            this.locationOneBtn.TabIndex = 0;
            this.locationOneBtn.UseVisualStyleBackColor = true;
            this.locationOneBtn.Click += new System.EventHandler(this.locationOneBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(571, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 306);
            this.panel2.TabIndex = 1;
            // 
            // dungeonMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1318, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "dungeonMaster";
            this.Text = "Dungeon Master";
            this.Load += new System.EventHandler(this.dungeonMaster_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button locationFourBtn;
        private System.Windows.Forms.Button locationTwoBtn;
        private System.Windows.Forms.Button locationThreeBtn;
        private System.Windows.Forms.Button locationOneBtn;
        private System.Windows.Forms.Panel panel2;
    }
}