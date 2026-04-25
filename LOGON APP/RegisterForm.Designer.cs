namespace LOGON_APP
{
    partial class RegisterForm
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            loginBtn = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            PasswordText = new TextBox();
            UserNameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ConfirmPasswordText = new TextBox();
            loginFormBtn = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 494);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logonlogo;
            pictureBox1.Location = new Point(93, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 310);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(715, 186);
            label4.Name = "label4";
            label4.Size = new Size(57, 13);
            label4.TabIndex = 20;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(715, 129);
            label3.Name = "label3";
            label3.Size = new Size(30, 13);
            label3.TabIndex = 19;
            label3.Text = "User";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.contact_image;
            pictureBox4.Location = new Point(1032, 425);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Gold;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.Location = new Point(746, 395);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(131, 56);
            loginBtn.TabIndex = 18;
            loginBtn.Text = "Register";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            loginBtn.MouseEnter += loginBtn_MouseEnter;
            loginBtn.MouseLeave += loginBtn_MouseLeave;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.settings;
            pictureBox3.Location = new Point(674, 230);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.home;
            pictureBox2.Location = new Point(674, 145);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // PasswordText
            // 
            PasswordText.BackColor = Color.FromArgb(46, 51, 80);
            PasswordText.BorderStyle = BorderStyle.FixedSingle;
            PasswordText.Font = new Font("Segoe UI", 9.75F);
            PasswordText.ForeColor = SystemColors.Menu;
            PasswordText.Location = new Point(715, 202);
            PasswordText.Name = "PasswordText";
            PasswordText.PasswordChar = '◉';
            PasswordText.Size = new Size(199, 25);
            PasswordText.TabIndex = 16;
            // 
            // UserNameTxt
            // 
            UserNameTxt.BackColor = Color.FromArgb(46, 51, 80);
            UserNameTxt.BorderStyle = BorderStyle.FixedSingle;
            UserNameTxt.Font = new Font("Segoe UI", 9.75F);
            UserNameTxt.ForeColor = SystemColors.Menu;
            UserNameTxt.Location = new Point(715, 145);
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.Size = new Size(199, 25);
            UserNameTxt.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(566, 24);
            label2.Name = "label2";
            label2.Size = new Size(138, 45);
            label2.TabIndex = 14;
            label2.Text = "Register";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(715, 245);
            label1.Name = "label1";
            label1.Size = new Size(102, 13);
            label1.TabIndex = 23;
            label1.Text = "Confirm password";
            // 
            // ConfirmPasswordText
            // 
            ConfirmPasswordText.BackColor = Color.FromArgb(46, 51, 80);
            ConfirmPasswordText.BorderStyle = BorderStyle.FixedSingle;
            ConfirmPasswordText.Font = new Font("Segoe UI", 9.75F);
            ConfirmPasswordText.ForeColor = SystemColors.Menu;
            ConfirmPasswordText.Location = new Point(715, 261);
            ConfirmPasswordText.Name = "ConfirmPasswordText";
            ConfirmPasswordText.PasswordChar = '◉';
            ConfirmPasswordText.Size = new Size(199, 25);
            ConfirmPasswordText.TabIndex = 21;
            // 
            // loginFormBtn
            // 
            loginFormBtn.FlatAppearance.BorderSize = 0;
            loginFormBtn.FlatStyle = FlatStyle.Flat;
            loginFormBtn.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginFormBtn.ForeColor = Color.Khaki;
            loginFormBtn.Location = new Point(823, 310);
            loginFormBtn.Name = "loginFormBtn";
            loginFormBtn.Size = new Size(98, 25);
            loginFormBtn.TabIndex = 25;
            loginFormBtn.Text = "Log in Now";
            loginFormBtn.UseVisualStyleBackColor = true;
            loginFormBtn.Click += loginFormBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(709, 316);
            label5.Name = "label5";
            label5.Size = new Size(108, 13);
            label5.TabIndex = 24;
            label5.Text = "U have an account?";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1119, 489);
            Controls.Add(loginFormBtn);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(ConfirmPasswordText);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(loginBtn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(PasswordText);
            Controls.Add(UserNameTxt);
            Controls.Add(label2);
            MaximizeBox = false;
            Name = "RegisterForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Section";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox4;
        private Button loginBtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox PasswordText;
        private TextBox UserNameTxt;
        private Label label2;
        private Label label1;
        private TextBox ConfirmPasswordText;
        private Button loginFormBtn;
        private Label label5;
    }
}