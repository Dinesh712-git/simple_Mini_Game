namespace Game
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
            this.label3 = new System.Windows.Forms.Label();
            this.txboxUserName = new System.Windows.Forms.TextBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.btneasy = new System.Windows.Forms.RadioButton();
            this.btnmedium = new System.Windows.Forms.RadioButton();
            this.btnHard = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Level";
            // 
            // txboxUserName
            // 
            this.txboxUserName.BackColor = System.Drawing.SystemColors.Info;
            this.txboxUserName.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxUserName.Location = new System.Drawing.Point(282, 153);
            this.txboxUserName.Name = "txboxUserName";
            this.txboxUserName.Size = new System.Drawing.Size(224, 33);
            this.txboxUserName.TabIndex = 1;
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(409, 369);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(101, 35);
            this.btnstart.TabIndex = 6;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(196, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // linkHelp
            // 
            this.linkHelp.AutoSize = true;
            this.linkHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHelp.Location = new System.Drawing.Point(460, 9);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(50, 24);
            this.linkHelp.TabIndex = 8;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "Help";
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
            // 
            // btneasy
            // 
            this.btneasy.AutoSize = true;
            this.btneasy.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneasy.Location = new System.Drawing.Point(282, 236);
            this.btneasy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btneasy.Name = "btneasy";
            this.btneasy.Size = new System.Drawing.Size(70, 25);
            this.btneasy.TabIndex = 9;
            this.btneasy.TabStop = true;
            this.btneasy.Text = "Easy";
            this.btneasy.UseVisualStyleBackColor = true;
            // 
            // btnmedium
            // 
            this.btnmedium.AutoSize = true;
            this.btnmedium.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmedium.Location = new System.Drawing.Point(282, 277);
            this.btnmedium.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmedium.Name = "btnmedium";
            this.btnmedium.Size = new System.Drawing.Size(97, 25);
            this.btnmedium.TabIndex = 10;
            this.btnmedium.TabStop = true;
            this.btnmedium.Text = "Medium";
            this.btnmedium.UseVisualStyleBackColor = true;
            // 
            // btnHard
            // 
            this.btnHard.AutoSize = true;
            this.btnHard.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(282, 316);
            this.btnHard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(72, 25);
            this.btnHard.TabIndex = 11;
            this.btnHard.TabStop = true;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.Gallery_4;
            this.ClientSize = new System.Drawing.Size(551, 431);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnmedium);
            this.Controls.Add(this.btneasy);
            this.Controls.Add(this.linkHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.txboxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txboxUserName;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.RadioButton btneasy;
        private System.Windows.Forms.RadioButton btnmedium;
        private System.Windows.Forms.RadioButton btnHard;
    }
}

