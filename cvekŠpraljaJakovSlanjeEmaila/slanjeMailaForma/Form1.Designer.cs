namespace slanjeMailaForma
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
            this.ccTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.RichTextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.reciverTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.reciverLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.smtpTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sslCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ccTextBox
            // 
            this.ccTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ccTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.ccTextBox.Location = new System.Drawing.Point(132, 62);
            this.ccTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ccTextBox.Name = "ccTextBox";
            this.ccTextBox.Size = new System.Drawing.Size(494, 20);
            this.ccTextBox.TabIndex = 0;
            // 
            // mailTextBox
            // 
            this.mailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTextBox.Location = new System.Drawing.Point(132, 174);
            this.mailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(494, 176);
            this.mailTextBox.TabIndex = 1;
            this.mailTextBox.Text = "";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.subjectTextBox.Location = new System.Drawing.Point(132, 114);
            this.subjectTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(494, 20);
            this.subjectTextBox.TabIndex = 2;
            // 
            // reciverTextBox
            // 
            this.reciverTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reciverTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.reciverTextBox.Location = new System.Drawing.Point(132, 14);
            this.reciverTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reciverTextBox.Name = "reciverTextBox";
            this.reciverTextBox.Size = new System.Drawing.Size(494, 20);
            this.reciverTextBox.TabIndex = 3;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(15, 114);
            this.subjectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(77, 21);
            this.subjectLabel.TabIndex = 5;
            this.subjectLabel.Text = "Predmet:";
            // 
            // reciverLabel
            // 
            this.reciverLabel.AutoSize = true;
            this.reciverLabel.Location = new System.Drawing.Point(15, 14);
            this.reciverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reciverLabel.Name = "reciverLabel";
            this.reciverLabel.Size = new System.Drawing.Size(55, 21);
            this.reciverLabel.TabIndex = 6;
            this.reciverLabel.Text = "Prima:";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(15, 174);
            this.mailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(63, 21);
            this.mailLabel.TabIndex = 7;
            this.mailLabel.Text = "Poruka:";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.White;
            this.sendButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.sendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.sendButton.ForeColor = System.Drawing.Color.Black;
            this.sendButton.Location = new System.Drawing.Point(400, 62);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(88, 28);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Pošalji";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.smtpTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.portTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sslCheckBox);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sendButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(132, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 151);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // smtpTextBox
            // 
            this.smtpTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smtpTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.smtpTextBox.Location = new System.Drawing.Point(205, 112);
            this.smtpTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.smtpTextBox.Name = "smtpTextBox";
            this.smtpTextBox.Size = new System.Drawing.Size(171, 20);
            this.smtpTextBox.TabIndex = 18;
            this.smtpTextBox.Text = "smtp.gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Smtp:";
            // 
            // portTextBox
            // 
            this.portTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.portTextBox.Location = new System.Drawing.Point(84, 112);
            this.portTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(60, 20);
            this.portTextBox.TabIndex = 16;
            this.portTextBox.Text = "587";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Port:";
            // 
            // sslCheckBox
            // 
            this.sslCheckBox.AutoSize = true;
            this.sslCheckBox.Location = new System.Drawing.Point(400, 28);
            this.sslCheckBox.Name = "sslCheckBox";
            this.sslCheckBox.Size = new System.Drawing.Size(51, 24);
            this.sslCheckBox.TabIndex = 14;
            this.sslCheckBox.Text = "SSL";
            this.sslCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.passwordTextBox.Location = new System.Drawing.Point(136, 66);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(240, 20);
            this.passwordTextBox.TabIndex = 13;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.usernameTextBox.Location = new System.Drawing.Point(136, 32);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(240, 20);
            this.usernameTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lozinka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Korisničko ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "CC:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(678, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.reciverLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.reciverTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.ccTextBox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ccTextBox;
        private System.Windows.Forms.RichTextBox mailTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox reciverTextBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label reciverLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox sslCheckBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox smtpTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label4;
    }
}

