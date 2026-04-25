namespace LOGON_APP
{
    partial class LoginForm
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            UserNameTxt = new TextBox();
            PasswordText = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            loginBtn = new Button();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            registerFormBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 494);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(104, 394);
            label1.Name = "label1";
            label1.Size = new Size(295, 45);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Logon";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logonlogo;
            pictureBox1.Location = new Point(89, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 310);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(566, 19);
            label2.Name = "label2";
            label2.Size = new Size(115, 45);
            label2.TabIndex = 2;
            label2.Text = "LOGIN";
            // 
            // UserNameTxt
            // 
            UserNameTxt.BackColor = Color.FromArgb(46, 51, 80);
            UserNameTxt.BorderStyle = BorderStyle.FixedSingle;
            UserNameTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameTxt.ForeColor = SystemColors.Menu;
            UserNameTxt.Location = new Point(715, 140);
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.Size = new Size(199, 25);
            UserNameTxt.TabIndex = 3;
            // 
            // PasswordText
            // 
            PasswordText.BackColor = Color.FromArgb(46, 51, 80);
            PasswordText.BorderStyle = BorderStyle.FixedSingle;
            PasswordText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordText.ForeColor = SystemColors.Menu;
            PasswordText.Location = new Point(715, 197);
            PasswordText.Name = "PasswordText";
            PasswordText.PasswordChar = '◉';
            PasswordText.Size = new Size(199, 25);
            PasswordText.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.home;
            pictureBox2.Location = new Point(674, 140);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.settings;
            pictureBox3.Location = new Point(674, 197);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Gold;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.Location = new Point(746, 390);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(131, 56);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            loginBtn.MouseEnter += loginBtn_MouseEnter;
            loginBtn.MouseLeave += loginBtn_MouseLeave;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.contact_image;
            pictureBox4.Location = new Point(1032, 420);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(715, 124);
            label3.Name = "label3";
            label3.Size = new Size(30, 13);
            label3.TabIndex = 7;
            label3.Text = "User";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(715, 181);
            label4.Name = "label4";
            label4.Size = new Size(57, 13);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(674, 275);
            label5.Name = "label5";
            label5.Size = new Size(136, 13);
            label5.TabIndex = 9;
            label5.Text = "U dont have an account?";
            // 
            // registerFormBtn
            // 
            registerFormBtn.FlatAppearance.BorderSize = 0;
            registerFormBtn.FlatStyle = FlatStyle.Flat;
            registerFormBtn.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerFormBtn.ForeColor = Color.Khaki;
            registerFormBtn.Location = new Point(816, 269);
            registerFormBtn.Name = "registerFormBtn";
            registerFormBtn.Size = new Size(98, 25);
            registerFormBtn.TabIndex = 10;
            registerFormBtn.Text = "Register Now";
            registerFormBtn.UseVisualStyleBackColor = true;
            registerFormBtn.Click += registerFormBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1113, 492);
            Controls.Add(registerFormBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(loginBtn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(PasswordText);
            Controls.Add(UserNameTxt);
            Controls.Add(label2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Section";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox UserNameTxt;
        private TextBox PasswordText;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button loginBtn;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button registerFormBtn;
    }
}