namespace DAD.Classes
{
    partial class gameSetup
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
            this.label2 = new System.Windows.Forms.Label();
            this.ipv4Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.dmasterOption = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.adOption = new System.Windows.Forms.Button();
            this.detectBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(106, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Game Setup";
            // 
            // ipv4Txt
            // 
            this.ipv4Txt.BackColor = System.Drawing.Color.White;
            this.ipv4Txt.ForeColor = System.Drawing.Color.Black;
            this.ipv4Txt.Location = new System.Drawing.Point(112, 119);
            this.ipv4Txt.Name = "ipv4Txt";
            this.ipv4Txt.Size = new System.Drawing.Size(188, 26);
            this.ipv4Txt.TabIndex = 3;
            this.ipv4Txt.Leave += new System.EventHandler(this.ipv4Txt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(128, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP ADDRESS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "PORT";
            // 
            // portTxt
            // 
            this.portTxt.BackColor = System.Drawing.Color.White;
            this.portTxt.ForeColor = System.Drawing.Color.Black;
            this.portTxt.Location = new System.Drawing.Point(12, 119);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(74, 26);
            this.portTxt.TabIndex = 7;
            this.portTxt.TextChanged += new System.EventHandler(this.portTxt_TextChanged);
            // 
            // dmasterOption
            // 
            this.dmasterOption.ForeColor = System.Drawing.Color.Black;
            this.dmasterOption.Location = new System.Drawing.Point(12, 203);
            this.dmasterOption.Name = "dmasterOption";
            this.dmasterOption.Size = new System.Drawing.Size(262, 59);
            this.dmasterOption.TabIndex = 8;
            this.dmasterOption.Text = "Dungeon Master";
            this.dmasterOption.UseVisualStyleBackColor = true;
            this.dmasterOption.Click += new System.EventHandler(this.dmasterOption_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "WHO ARE YOU?";
            // 
            // adOption
            // 
            this.adOption.ForeColor = System.Drawing.Color.Black;
            this.adOption.Location = new System.Drawing.Point(12, 268);
            this.adOption.Name = "adOption";
            this.adOption.Size = new System.Drawing.Size(262, 59);
            this.adOption.TabIndex = 10;
            this.adOption.Text = "Adventurer";
            this.adOption.UseVisualStyleBackColor = true;
            this.adOption.Click += new System.EventHandler(this.adOption_Click);
            // 
            // detectBtn
            // 
            this.detectBtn.BackColor = System.Drawing.Color.Transparent;
            this.detectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectBtn.ForeColor = System.Drawing.Color.Black;
            this.detectBtn.Location = new System.Drawing.Point(306, 119);
            this.detectBtn.Name = "detectBtn";
            this.detectBtn.Size = new System.Drawing.Size(98, 32);
            this.detectBtn.TabIndex = 5;
            this.detectBtn.Text = "DETECT";
            this.detectBtn.UseVisualStyleBackColor = false;
            this.detectBtn.Click += new System.EventHandler(this.detectBtn_Click);
            // 
            // applyBtn
            // 
            this.applyBtn.BackColor = System.Drawing.Color.Green;
            this.applyBtn.ForeColor = System.Drawing.Color.Black;
            this.applyBtn.Location = new System.Drawing.Point(112, 369);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(146, 32);
            this.applyBtn.TabIndex = 11;
            this.applyBtn.Text = "APPLY";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // gameSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(416, 413);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.adOption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dmasterOption);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.detectBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipv4Txt);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Name = "gameSetup";
            this.Text = "Game Setup";
            this.Load += new System.EventHandler(this.gameSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipv4Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.Button dmasterOption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button adOption;
        private System.Windows.Forms.Button detectBtn;
        private System.Windows.Forms.Button applyBtn;
    }
}