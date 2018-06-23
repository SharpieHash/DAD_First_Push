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
            this.panel1 = new System.Windows.Forms.Panel();
            this.locationFourBtn = new System.Windows.Forms.Button();
            this.locationTwoBtn = new System.Windows.Forms.Button();
            this.locationThreeBtn = new System.Windows.Forms.Button();
            this.locationOneBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.characterLobby = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mobInfo = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.modName = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.mapSize = new System.Windows.Forms.Button();
            this.mapDisplay = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.locationNameDispla = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapDisplay)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.locationFourBtn);
            this.panel1.Controls.Add(this.locationTwoBtn);
            this.panel1.Controls.Add(this.locationThreeBtn);
            this.panel1.Controls.Add(this.locationOneBtn);
            this.panel1.Location = new System.Drawing.Point(12, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 306);
            this.panel1.TabIndex = 0;
            // 
            // locationFourBtn
            // 
            this.locationFourBtn.Location = new System.Drawing.Point(275, 167);
            this.locationFourBtn.Name = "locationFourBtn";
            this.locationFourBtn.Size = new System.Drawing.Size(240, 125);
            this.locationFourBtn.TabIndex = 3;
            this.locationFourBtn.UseVisualStyleBackColor = true;
            this.locationFourBtn.Click += new System.EventHandler(this.locationFourBtn_Click);
            // 
            // locationTwoBtn
            // 
            this.locationTwoBtn.Location = new System.Drawing.Point(275, 14);
            this.locationTwoBtn.Name = "locationTwoBtn";
            this.locationTwoBtn.Size = new System.Drawing.Size(240, 125);
            this.locationTwoBtn.TabIndex = 2;
            this.locationTwoBtn.UseVisualStyleBackColor = true;
            this.locationTwoBtn.Click += new System.EventHandler(this.locationTwoBtn_Click);
            // 
            // locationThreeBtn
            // 
            this.locationThreeBtn.Location = new System.Drawing.Point(14, 167);
            this.locationThreeBtn.Name = "locationThreeBtn";
            this.locationThreeBtn.Size = new System.Drawing.Size(240, 125);
            this.locationThreeBtn.TabIndex = 1;
            this.locationThreeBtn.UseVisualStyleBackColor = true;
            this.locationThreeBtn.Click += new System.EventHandler(this.locationThreeBtn_Click);
            // 
            // locationOneBtn
            // 
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
            this.panel2.Location = new System.Drawing.Point(561, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 306);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.characterLobby);
            this.panel3.Location = new System.Drawing.Point(1129, 372);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 306);
            this.panel3.TabIndex = 2;
            // 
            // characterLobby
            // 
            this.characterLobby.BackColor = System.Drawing.Color.Gray;
            this.characterLobby.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.characterLobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLobby.ForeColor = System.Drawing.Color.Black;
            this.characterLobby.Location = new System.Drawing.Point(14, 24);
            this.characterLobby.Name = "characterLobby";
            this.characterLobby.Size = new System.Drawing.Size(268, 15);
            this.characterLobby.TabIndex = 2;
            this.characterLobby.Text = "Character Lobby";
            this.characterLobby.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.mobInfo);
            this.panel4.Location = new System.Drawing.Point(1129, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 274);
            this.panel4.TabIndex = 3;
            // 
            // mobInfo
            // 
            this.mobInfo.BackColor = System.Drawing.Color.Gray;
            this.mobInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mobInfo.Location = new System.Drawing.Point(4, 4);
            this.mobInfo.Name = "mobInfo";
            this.mobInfo.Size = new System.Drawing.Size(292, 267);
            this.mobInfo.TabIndex = 0;
            this.mobInfo.Text = "";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.modName);
            this.panel5.Location = new System.Drawing.Point(1129, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(299, 48);
            this.panel5.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(15, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 15);
            this.textBox1.TabIndex = 2;
            // 
            // modName
            // 
            this.modName.BackColor = System.Drawing.Color.Gray;
            this.modName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modName.ForeColor = System.Drawing.Color.Black;
            this.modName.Location = new System.Drawing.Point(14, 13);
            this.modName.Name = "modName";
            this.modName.Size = new System.Drawing.Size(268, 15);
            this.modName.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.mapSize);
            this.panel6.Controls.Add(this.mapDisplay);
            this.panel6.Location = new System.Drawing.Point(12, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1094, 274);
            this.panel6.TabIndex = 2;
            // 
            // mapSize
            // 
            this.mapSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapSize.Location = new System.Drawing.Point(3, 4);
            this.mapSize.Name = "mapSize";
            this.mapSize.Size = new System.Drawing.Size(29, 28);
            this.mapSize.TabIndex = 1;
            this.mapSize.Text = "+";
            this.mapSize.UseVisualStyleBackColor = true;
            this.mapSize.Click += new System.EventHandler(this.mapSize_Click);
            // 
            // mapDisplay
            // 
            this.mapDisplay.Location = new System.Drawing.Point(3, 3);
            this.mapDisplay.Name = "mapDisplay";
            this.mapDisplay.Size = new System.Drawing.Size(1088, 268);
            this.mapDisplay.TabIndex = 0;
            this.mapDisplay.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Controls.Add(this.locationNameDispla);
            this.panel7.Location = new System.Drawing.Point(12, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1094, 48);
            this.panel7.TabIndex = 5;
            // 
            // locationNameDispla
            // 
            this.locationNameDispla.BackColor = System.Drawing.Color.Gray;
            this.locationNameDispla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationNameDispla.ForeColor = System.Drawing.Color.Black;
            this.locationNameDispla.Location = new System.Drawing.Point(14, 13);
            this.locationNameDispla.Name = "locationNameDispla";
            this.locationNameDispla.Size = new System.Drawing.Size(1066, 15);
            this.locationNameDispla.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gray;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "---------Drop---------";
            // 
            // dungeonMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1440, 690);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "dungeonMaster";
            this.Text = "Dungeon Master";
            this.Load += new System.EventHandler(this.dungeonMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapDisplay)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button locationFourBtn;
        private System.Windows.Forms.Button locationTwoBtn;
        private System.Windows.Forms.Button locationThreeBtn;
        private System.Windows.Forms.Button locationOneBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button mapSize;
        private System.Windows.Forms.PictureBox mapDisplay;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox locationNameDispla;
        private System.Windows.Forms.RichTextBox mobInfo;
        private System.Windows.Forms.TextBox modName;
        private System.Windows.Forms.TextBox characterLobby;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}