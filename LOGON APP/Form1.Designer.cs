namespace LOGON_APP
{
    partial class ApplicationForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
            sidePanel1 = new Panel();
            logoutBtn = new Button();
            labelUserName = new Label();
            QnotesBtn = new Button();
            ContactBtn = new Button();
            AboutBtn = new Button();
            HomeBtn = new Button();
            SettingsBtn = new Button();
            sidePanel2 = new Panel();
            labelUser = new Label();
            label1 = new Label();
            DateLabel = new Label();
            ClockLabel = new Label();
            label4 = new Label();
            LogonApplabel = new Label();
            ExitBtn = new Button();
            MinimizeBtn = new Button();
            timerClock = new System.Windows.Forms.Timer(components);
            AnimlogoTimer = new System.Windows.Forms.Timer(components);
            PanelHome = new Panel();
            aboutPanel = new Panel();
            label2 = new Label();
            QrLabel = new Label();
            pictureBoxChart = new PictureBox();
            pictureBoxQR = new PictureBox();
            pictureBoxAboutDecor = new PictureBox();
            pictureBoxPhone = new PictureBox();
            weatherPanel = new Panel();
            cloudsLbl = new Label();
            windLbl = new Label();
            humidityLbl = new Label();
            feelsLbl = new Label();
            temperatureLbl = new Label();
            pictureBoxFeel = new PictureBox();
            pictureBoxClouds = new PictureBox();
            pictureBoxWind = new PictureBox();
            pictureBoxHumidity = new PictureBox();
            pictureBoxTemp = new PictureBox();
            labelClouds = new Label();
            labelWind = new Label();
            labelHumidity = new Label();
            labelFeels = new Label();
            labelDesc = new Label();
            labelTemp = new Label();
            labelCity = new Label();
            labelUnder = new Label();
            pictureBoxLaptop = new PictureBox();
            settingsIconPicture = new PictureBox();
            DefaultThemeButton = new Button();
            DarkThemeButton = new Button();
            LightThemeButton = new Button();
            LogoPictureBox = new PictureBox();
            contactPanel = new Panel();
            pictureBox4 = new PictureBox();
            phoneNumLbl = new Label();
            pictureBox3 = new PictureBox();
            underThree = new Label();
            mailLbl = new Label();
            pictureBox2 = new PictureBox();
            addresslbl = new Label();
            pictureBox1 = new PictureBox();
            underOne = new Label();
            underTwo = new Label();
            childContactPanel = new Panel();
            label3 = new Label();
            qNotesPanel = new Panel();
            labelNote = new Label();
            QuickNotesListBox = new ListBox();
            DeleteNoteBtn = new Button();
            AddNoteBtn = new Button();
            noteLbl = new Label();
            NoteRichTextBox = new RichTextBox();
            label5 = new Label();
            weatherTimer = new System.Windows.Forms.Timer(components);
            UpdateNoteBtn = new Button();
            sidePanel1.SuspendLayout();
            sidePanel2.SuspendLayout();
            PanelHome.SuspendLayout();
            aboutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAboutDecor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhone).BeginInit();
            weatherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFeel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClouds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWind).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHumidity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLaptop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settingsIconPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            contactPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            childContactPanel.SuspendLayout();
            qNotesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel1
            // 
            sidePanel1.BackColor = Color.FromArgb(24, 30, 54);
            sidePanel1.Controls.Add(logoutBtn);
            sidePanel1.Controls.Add(labelUserName);
            sidePanel1.Controls.Add(QnotesBtn);
            sidePanel1.Controls.Add(ContactBtn);
            sidePanel1.Controls.Add(AboutBtn);
            sidePanel1.Controls.Add(HomeBtn);
            sidePanel1.Controls.Add(SettingsBtn);
            sidePanel1.Controls.Add(sidePanel2);
            sidePanel1.Controls.Add(label4);
            sidePanel1.Dock = DockStyle.Left;
            sidePanel1.Location = new Point(0, 0);
            sidePanel1.Name = "sidePanel1";
            sidePanel1.Size = new Size(186, 577);
            sidePanel1.TabIndex = 0;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.FromArgb(24, 30, 54);
            logoutBtn.BackgroundImageLayout = ImageLayout.Center;
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = Color.Gold;
            logoutBtn.Image = Properties.Resources.logouticon;
            logoutBtn.Location = new Point(0, 530);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(186, 47);
            logoutBtn.TabIndex = 9;
            logoutBtn.Text = "Log out";
            logoutBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            logoutBtn.MouseEnter += logoutBtn_MouseEnter;
            logoutBtn.MouseLeave += logoutBtn_MouseLeave;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUserName.ForeColor = SystemColors.Control;
            labelUserName.Location = new Point(11, 152);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(52, 21);
            labelUserName.TabIndex = 7;
            labelUserName.Text = "label4";
            // 
            // QnotesBtn
            // 
            QnotesBtn.BackgroundImageLayout = ImageLayout.Center;
            QnotesBtn.Cursor = Cursors.Hand;
            QnotesBtn.FlatAppearance.BorderSize = 0;
            QnotesBtn.FlatStyle = FlatStyle.Flat;
            QnotesBtn.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QnotesBtn.ForeColor = Color.Gold;
            QnotesBtn.Image = Properties.Resources.quicknotes;
            QnotesBtn.Location = new Point(0, 401);
            QnotesBtn.Name = "QnotesBtn";
            QnotesBtn.Size = new Size(186, 55);
            QnotesBtn.TabIndex = 5;
            QnotesBtn.Text = "Qnotes";
            QnotesBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            QnotesBtn.UseVisualStyleBackColor = true;
            QnotesBtn.Click += QnotesBtn_Click;
            // 
            // ContactBtn
            // 
            ContactBtn.BackgroundImageLayout = ImageLayout.Center;
            ContactBtn.Cursor = Cursors.Hand;
            ContactBtn.FlatAppearance.BorderSize = 0;
            ContactBtn.FlatStyle = FlatStyle.Flat;
            ContactBtn.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContactBtn.ForeColor = Color.Gold;
            ContactBtn.Image = Properties.Resources.info;
            ContactBtn.Location = new Point(0, 331);
            ContactBtn.Name = "ContactBtn";
            ContactBtn.Size = new Size(186, 55);
            ContactBtn.TabIndex = 4;
            ContactBtn.Text = "Contact";
            ContactBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            ContactBtn.UseVisualStyleBackColor = true;
            ContactBtn.Click += ContactBtn_Click;
            // 
            // AboutBtn
            // 
            AboutBtn.BackgroundImageLayout = ImageLayout.Center;
            AboutBtn.Cursor = Cursors.Hand;
            AboutBtn.FlatAppearance.BorderSize = 0;
            AboutBtn.FlatStyle = FlatStyle.Flat;
            AboutBtn.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AboutBtn.ForeColor = Color.Gold;
            AboutBtn.Image = Properties.Resources.id_card;
            AboutBtn.Location = new Point(0, 262);
            AboutBtn.Name = "AboutBtn";
            AboutBtn.Size = new Size(186, 55);
            AboutBtn.TabIndex = 3;
            AboutBtn.Text = "About";
            AboutBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            AboutBtn.UseVisualStyleBackColor = true;
            AboutBtn.Click += AboutBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.BackgroundImageLayout = ImageLayout.Center;
            HomeBtn.Cursor = Cursors.Hand;
            HomeBtn.FlatAppearance.BorderSize = 0;
            HomeBtn.FlatStyle = FlatStyle.Flat;
            HomeBtn.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeBtn.ForeColor = Color.Gold;
            HomeBtn.Image = Properties.Resources.home;
            HomeBtn.Location = new Point(0, 196);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(186, 55);
            HomeBtn.TabIndex = 2;
            HomeBtn.Text = "Home";
            HomeBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // SettingsBtn
            // 
            SettingsBtn.BackgroundImageLayout = ImageLayout.Center;
            SettingsBtn.Cursor = Cursors.Hand;
            SettingsBtn.FlatAppearance.BorderSize = 0;
            SettingsBtn.FlatStyle = FlatStyle.Flat;
            SettingsBtn.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SettingsBtn.ForeColor = Color.Gold;
            SettingsBtn.Image = Properties.Resources.settings;
            SettingsBtn.Location = new Point(0, 468);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(186, 55);
            SettingsBtn.TabIndex = 1;
            SettingsBtn.Text = "Settings";
            SettingsBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            SettingsBtn.UseVisualStyleBackColor = true;
            SettingsBtn.Click += SettingsBtn_Click;
            // 
            // sidePanel2
            // 
            sidePanel2.Controls.Add(labelUser);
            sidePanel2.Controls.Add(label1);
            sidePanel2.Controls.Add(DateLabel);
            sidePanel2.Controls.Add(ClockLabel);
            sidePanel2.Dock = DockStyle.Top;
            sidePanel2.Location = new Point(0, 0);
            sidePanel2.Name = "sidePanel2";
            sidePanel2.Size = new Size(186, 144);
            sidePanel2.TabIndex = 0;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUser.ForeColor = SystemColors.Control;
            labelUser.Location = new Point(12, 105);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(0, 21);
            labelUser.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(243, 194, 40);
            label1.Location = new Point(-9, 112);
            label1.Name = "label1";
            label1.Size = new Size(384, 32);
            label1.TabIndex = 5;
            label1.Text = "_____________________________________";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateLabel.ForeColor = Color.White;
            DateLabel.Location = new Point(44, 78);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(0, 21);
            DateLabel.TabIndex = 1;
            // 
            // ClockLabel
            // 
            ClockLabel.AutoSize = true;
            ClockLabel.Font = new Font("Nirmala UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClockLabel.ForeColor = Color.White;
            ClockLabel.Location = new Point(41, 28);
            ClockLabel.Name = "ClockLabel";
            ClockLabel.Size = new Size(0, 32);
            ClockLabel.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(243, 194, 40);
            label4.Location = new Point(-102, 159);
            label4.Name = "label4";
            label4.Size = new Size(384, 32);
            label4.TabIndex = 8;
            label4.Text = "_____________________________________";
            // 
            // LogonApplabel
            // 
            LogonApplabel.AutoSize = true;
            LogonApplabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogonApplabel.ForeColor = Color.White;
            LogonApplabel.Location = new Point(192, 7);
            LogonApplabel.Name = "LogonApplabel";
            LogonApplabel.Size = new Size(108, 45);
            LogonApplabel.TabIndex = 2;
            LogonApplabel.Text = "Home";
            // 
            // ExitBtn
            // 
            ExitBtn.BackgroundImageLayout = ImageLayout.Zoom;
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 51, 73);
            ExitBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Microsoft Yi Baiti", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitBtn.ForeColor = Color.White;
            ExitBtn.Location = new Point(916, 0);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(35, 41);
            ExitBtn.TabIndex = 3;
            ExitBtn.TabStop = false;
            ExitBtn.Text = "X";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            ExitBtn.MouseEnter += ExitBtn_MouseEnter;
            ExitBtn.MouseLeave += ExitBtn_MouseLeave;
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            MinimizeBtn.FlatAppearance.BorderSize = 0;
            MinimizeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 51, 73);
            MinimizeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            MinimizeBtn.FlatStyle = FlatStyle.Flat;
            MinimizeBtn.Font = new Font("Microsoft Yi Baiti", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimizeBtn.ForeColor = Color.White;
            MinimizeBtn.Location = new Point(875, 0);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new Size(35, 41);
            MinimizeBtn.TabIndex = 4;
            MinimizeBtn.TabStop = false;
            MinimizeBtn.Text = "-";
            MinimizeBtn.UseVisualStyleBackColor = true;
            MinimizeBtn.Click += MinimizeBtn_Click;
            MinimizeBtn.MouseEnter += MinimizeBtn_MouseEnter;
            MinimizeBtn.MouseLeave += MinimizeBtn_MouseLeave;
            // 
            // timerClock
            // 
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // AnimlogoTimer
            // 
            AnimlogoTimer.Interval = 30;
            AnimlogoTimer.Tick += AnimlogoTimer_Tick;
            // 
            // PanelHome
            // 
            PanelHome.Controls.Add(aboutPanel);
            PanelHome.Controls.Add(pictureBoxAboutDecor);
            PanelHome.Controls.Add(pictureBoxPhone);
            PanelHome.Controls.Add(weatherPanel);
            PanelHome.Controls.Add(pictureBoxLaptop);
            PanelHome.Controls.Add(settingsIconPicture);
            PanelHome.Controls.Add(DefaultThemeButton);
            PanelHome.Controls.Add(DarkThemeButton);
            PanelHome.Controls.Add(LightThemeButton);
            PanelHome.Controls.Add(LogoPictureBox);
            PanelHome.Location = new Point(199, 57);
            PanelHome.Name = "PanelHome";
            PanelHome.Size = new Size(747, 508);
            PanelHome.TabIndex = 5;
            // 
            // aboutPanel
            // 
            aboutPanel.BackColor = Color.White;
            aboutPanel.Controls.Add(label2);
            aboutPanel.Controls.Add(QrLabel);
            aboutPanel.Controls.Add(pictureBoxChart);
            aboutPanel.Controls.Add(pictureBoxQR);
            aboutPanel.Location = new Point(46, 253);
            aboutPanel.Name = "aboutPanel";
            aboutPanel.Size = new Size(659, 214);
            aboutPanel.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(356, 174);
            label2.Name = "label2";
            label2.Size = new Size(181, 30);
            label2.TabIndex = 3;
            label2.Text = "Constant discount";
            // 
            // QrLabel
            // 
            QrLabel.AutoSize = true;
            QrLabel.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QrLabel.Location = new Point(115, 177);
            QrLabel.Name = "QrLabel";
            QrLabel.Size = new Size(99, 30);
            QrLabel.TabIndex = 2;
            QrLabel.Text = "Follow us";
            // 
            // pictureBoxChart
            // 
            pictureBoxChart.Image = Properties.Resources.chart;
            pictureBoxChart.Location = new Point(332, -18);
            pictureBoxChart.Name = "pictureBoxChart";
            pictureBoxChart.Size = new Size(238, 202);
            pictureBoxChart.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxChart.TabIndex = 1;
            pictureBoxChart.TabStop = false;
            // 
            // pictureBoxQR
            // 
            pictureBoxQR.Image = Properties.Resources.qrcode1;
            pictureBoxQR.Location = new Point(80, 7);
            pictureBoxQR.Name = "pictureBoxQR";
            pictureBoxQR.Size = new Size(177, 169);
            pictureBoxQR.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxQR.TabIndex = 0;
            pictureBoxQR.TabStop = false;
            // 
            // pictureBoxAboutDecor
            // 
            pictureBoxAboutDecor.Image = Properties.Resources.decor;
            pictureBoxAboutDecor.Location = new Point(681, 473);
            pictureBoxAboutDecor.Name = "pictureBoxAboutDecor";
            pictureBoxAboutDecor.Size = new Size(71, 38);
            pictureBoxAboutDecor.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAboutDecor.TabIndex = 10;
            pictureBoxAboutDecor.TabStop = false;
            // 
            // pictureBoxPhone
            // 
            pictureBoxPhone.Image = Properties.Resources.phoneLOGON;
            pictureBoxPhone.Location = new Point(495, 23);
            pictureBoxPhone.Name = "pictureBoxPhone";
            pictureBoxPhone.Size = new Size(159, 200);
            pictureBoxPhone.TabIndex = 9;
            pictureBoxPhone.TabStop = false;
            // 
            // weatherPanel
            // 
            weatherPanel.BackColor = Color.White;
            weatherPanel.Controls.Add(cloudsLbl);
            weatherPanel.Controls.Add(windLbl);
            weatherPanel.Controls.Add(humidityLbl);
            weatherPanel.Controls.Add(feelsLbl);
            weatherPanel.Controls.Add(temperatureLbl);
            weatherPanel.Controls.Add(pictureBoxFeel);
            weatherPanel.Controls.Add(pictureBoxClouds);
            weatherPanel.Controls.Add(pictureBoxWind);
            weatherPanel.Controls.Add(pictureBoxHumidity);
            weatherPanel.Controls.Add(pictureBoxTemp);
            weatherPanel.Controls.Add(labelClouds);
            weatherPanel.Controls.Add(labelWind);
            weatherPanel.Controls.Add(labelHumidity);
            weatherPanel.Controls.Add(labelFeels);
            weatherPanel.Controls.Add(labelDesc);
            weatherPanel.Controls.Add(labelTemp);
            weatherPanel.Controls.Add(labelCity);
            weatherPanel.Controls.Add(labelUnder);
            weatherPanel.Location = new Point(33, 355);
            weatherPanel.Name = "weatherPanel";
            weatherPanel.Size = new Size(672, 153);
            weatherPanel.TabIndex = 4;
            // 
            // cloudsLbl
            // 
            cloudsLbl.AutoSize = true;
            cloudsLbl.Font = new Font("Nirmala UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cloudsLbl.Location = new Point(566, 131);
            cloudsLbl.Name = "cloudsLbl";
            cloudsLbl.Size = new Size(43, 15);
            cloudsLbl.TabIndex = 28;
            cloudsLbl.Text = "Clouds";
            // 
            // windLbl
            // 
            windLbl.AutoSize = true;
            windLbl.Font = new Font("Nirmala UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            windLbl.Location = new Point(441, 131);
            windLbl.Name = "windLbl";
            windLbl.Size = new Size(69, 15);
            windLbl.TabIndex = 27;
            windLbl.Text = "Wind speed";
            // 
            // humidityLbl
            // 
            humidityLbl.AutoSize = true;
            humidityLbl.Font = new Font("Nirmala UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            humidityLbl.Location = new Point(312, 131);
            humidityLbl.Name = "humidityLbl";
            humidityLbl.Size = new Size(55, 15);
            humidityLbl.TabIndex = 26;
            humidityLbl.Text = "Humidity";
            // 
            // feelsLbl
            // 
            feelsLbl.AutoSize = true;
            feelsLbl.Font = new Font("Nirmala UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feelsLbl.Location = new Point(186, 131);
            feelsLbl.Name = "feelsLbl";
            feelsLbl.Size = new Size(54, 15);
            feelsLbl.TabIndex = 25;
            feelsLbl.Text = "Feels like";
            // 
            // temperatureLbl
            // 
            temperatureLbl.AutoSize = true;
            temperatureLbl.Font = new Font("Nirmala UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            temperatureLbl.Location = new Point(49, 131);
            temperatureLbl.Name = "temperatureLbl";
            temperatureLbl.Size = new Size(72, 15);
            temperatureLbl.TabIndex = 24;
            temperatureLbl.Text = "Temperature";
            // 
            // pictureBoxFeel
            // 
            pictureBoxFeel.Location = new Point(160, 73);
            pictureBoxFeel.Name = "pictureBoxFeel";
            pictureBoxFeel.Size = new Size(50, 47);
            pictureBoxFeel.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFeel.TabIndex = 23;
            pictureBoxFeel.TabStop = false;
            // 
            // pictureBoxClouds
            // 
            pictureBoxClouds.Location = new Point(541, 73);
            pictureBoxClouds.Name = "pictureBoxClouds";
            pictureBoxClouds.Size = new Size(50, 47);
            pictureBoxClouds.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClouds.TabIndex = 21;
            pictureBoxClouds.TabStop = false;
            // 
            // pictureBoxWind
            // 
            pictureBoxWind.Location = new Point(412, 73);
            pictureBoxWind.Name = "pictureBoxWind";
            pictureBoxWind.Size = new Size(50, 47);
            pictureBoxWind.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxWind.TabIndex = 20;
            pictureBoxWind.TabStop = false;
            // 
            // pictureBoxHumidity
            // 
            pictureBoxHumidity.Location = new Point(287, 73);
            pictureBoxHumidity.Name = "pictureBoxHumidity";
            pictureBoxHumidity.Size = new Size(50, 47);
            pictureBoxHumidity.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHumidity.TabIndex = 19;
            pictureBoxHumidity.TabStop = false;
            // 
            // pictureBoxTemp
            // 
            pictureBoxTemp.Location = new Point(36, 73);
            pictureBoxTemp.Name = "pictureBoxTemp";
            pictureBoxTemp.Size = new Size(50, 47);
            pictureBoxTemp.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTemp.TabIndex = 18;
            pictureBoxTemp.TabStop = false;
            // 
            // labelClouds
            // 
            labelClouds.AutoSize = true;
            labelClouds.Font = new Font("Nirmala UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelClouds.Location = new Point(599, 90);
            labelClouds.Name = "labelClouds";
            labelClouds.Size = new Size(42, 17);
            labelClouds.TabIndex = 17;
            labelClouds.Text = "label3";
            // 
            // labelWind
            // 
            labelWind.AutoSize = true;
            labelWind.Font = new Font("Nirmala UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWind.Location = new Point(471, 90);
            labelWind.Name = "labelWind";
            labelWind.Size = new Size(42, 17);
            labelWind.TabIndex = 16;
            labelWind.Text = "label3";
            // 
            // labelHumidity
            // 
            labelHumidity.AutoSize = true;
            labelHumidity.Font = new Font("Nirmala UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHumidity.Location = new Point(346, 89);
            labelHumidity.Name = "labelHumidity";
            labelHumidity.Size = new Size(42, 17);
            labelHumidity.TabIndex = 15;
            labelHumidity.Text = "label3";
            // 
            // labelFeels
            // 
            labelFeels.AutoSize = true;
            labelFeels.Font = new Font("Nirmala UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFeels.Location = new Point(217, 88);
            labelFeels.Name = "labelFeels";
            labelFeels.Size = new Size(42, 17);
            labelFeels.TabIndex = 14;
            labelFeels.Text = "label3";
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Font = new Font("Nirmala UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDesc.Location = new Point(475, 27);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(42, 17);
            labelDesc.TabIndex = 13;
            labelDesc.Text = "label3";
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.Font = new Font("Nirmala UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTemp.Location = new Point(92, 89);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(42, 17);
            labelTemp.TabIndex = 12;
            labelTemp.Text = "label3";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Nirmala UI Semilight", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCity.Location = new Point(15, 4);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(229, 50);
            labelCity.TabIndex = 11;
            labelCity.Text = "Lebane Town";
            // 
            // labelUnder
            // 
            labelUnder.AutoSize = true;
            labelUnder.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUnder.ForeColor = Color.FromArgb(243, 194, 40);
            labelUnder.Location = new Point(15, 29);
            labelUnder.Name = "labelUnder";
            labelUnder.Size = new Size(634, 32);
            labelUnder.TabIndex = 6;
            labelUnder.Text = "______________________________________________________________";
            // 
            // pictureBoxLaptop
            // 
            pictureBoxLaptop.Image = Properties.Resources.laptopLOGON;
            pictureBoxLaptop.Location = new Point(56, 12);
            pictureBoxLaptop.Name = "pictureBoxLaptop";
            pictureBoxLaptop.Size = new Size(344, 222);
            pictureBoxLaptop.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLaptop.TabIndex = 8;
            pictureBoxLaptop.TabStop = false;
            // 
            // settingsIconPicture
            // 
            settingsIconPicture.BackgroundImageLayout = ImageLayout.Stretch;
            settingsIconPicture.Image = Properties.Resources.settingsico;
            settingsIconPicture.Location = new Point(622, 398);
            settingsIconPicture.Name = "settingsIconPicture";
            settingsIconPicture.Size = new Size(96, 93);
            settingsIconPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            settingsIconPicture.TabIndex = 6;
            settingsIconPicture.TabStop = false;
            // 
            // DefaultThemeButton
            // 
            DefaultThemeButton.BackColor = Color.FromArgb(243, 194, 40);
            DefaultThemeButton.BackgroundImageLayout = ImageLayout.Center;
            DefaultThemeButton.Cursor = Cursors.Hand;
            DefaultThemeButton.FlatAppearance.BorderSize = 0;
            DefaultThemeButton.FlatStyle = FlatStyle.Flat;
            DefaultThemeButton.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DefaultThemeButton.ForeColor = Color.FromArgb(43, 51, 73);
            DefaultThemeButton.Location = new Point(280, 220);
            DefaultThemeButton.Name = "DefaultThemeButton";
            DefaultThemeButton.Size = new Size(186, 55);
            DefaultThemeButton.TabIndex = 5;
            DefaultThemeButton.Text = "Default theme";
            DefaultThemeButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            DefaultThemeButton.UseVisualStyleBackColor = false;
            DefaultThemeButton.Click += DefaultThemeButton_Click;
            // 
            // DarkThemeButton
            // 
            DarkThemeButton.BackColor = Color.FromArgb(243, 194, 40);
            DarkThemeButton.BackgroundImageLayout = ImageLayout.Center;
            DarkThemeButton.Cursor = Cursors.Hand;
            DarkThemeButton.FlatAppearance.BorderSize = 0;
            DarkThemeButton.FlatStyle = FlatStyle.Flat;
            DarkThemeButton.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DarkThemeButton.ForeColor = Color.FromArgb(43, 51, 73);
            DarkThemeButton.Location = new Point(509, 220);
            DarkThemeButton.Name = "DarkThemeButton";
            DarkThemeButton.Size = new Size(186, 55);
            DarkThemeButton.TabIndex = 4;
            DarkThemeButton.Text = "Dark theme";
            DarkThemeButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            DarkThemeButton.UseVisualStyleBackColor = false;
            DarkThemeButton.Click += DarkThemeButton_Click;
            // 
            // LightThemeButton
            // 
            LightThemeButton.BackColor = Color.FromArgb(243, 194, 40);
            LightThemeButton.BackgroundImageLayout = ImageLayout.Center;
            LightThemeButton.Cursor = Cursors.Hand;
            LightThemeButton.FlatAppearance.BorderSize = 0;
            LightThemeButton.FlatStyle = FlatStyle.Flat;
            LightThemeButton.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LightThemeButton.ForeColor = Color.FromArgb(43, 51, 73);
            LightThemeButton.Location = new Point(46, 220);
            LightThemeButton.Name = "LightThemeButton";
            LightThemeButton.Size = new Size(186, 55);
            LightThemeButton.TabIndex = 3;
            LightThemeButton.Text = "Light theme";
            LightThemeButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            LightThemeButton.UseVisualStyleBackColor = false;
            LightThemeButton.Click += LightThemeButton_Click;
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.BackgroundImage = Properties.Resources.logonlogo;
            LogoPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            LogoPictureBox.Location = new Point(193, -10);
            LogoPictureBox.MaximumSize = new Size(528, 389);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(350, 350);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoPictureBox.TabIndex = 2;
            LogoPictureBox.TabStop = false;
            // 
            // contactPanel
            // 
            contactPanel.BackColor = Color.FromArgb(46, 51, 73);
            contactPanel.Controls.Add(pictureBox4);
            contactPanel.Controls.Add(phoneNumLbl);
            contactPanel.Controls.Add(pictureBox3);
            contactPanel.Controls.Add(underThree);
            contactPanel.Controls.Add(mailLbl);
            contactPanel.Controls.Add(pictureBox2);
            contactPanel.Controls.Add(addresslbl);
            contactPanel.Controls.Add(pictureBox1);
            contactPanel.Controls.Add(underOne);
            contactPanel.Controls.Add(underTwo);
            contactPanel.Controls.Add(childContactPanel);
            contactPanel.Location = new Point(232, 55);
            contactPanel.Name = "contactPanel";
            contactPanel.Size = new Size(660, 444);
            contactPanel.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.contact_image;
            pictureBox4.Location = new Point(0, 154);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(136, 125);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // phoneNumLbl
            // 
            phoneNumLbl.AutoSize = true;
            phoneNumLbl.Font = new Font("Nirmala UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumLbl.ForeColor = SystemColors.ButtonHighlight;
            phoneNumLbl.Location = new Point(265, 286);
            phoneNumLbl.Name = "phoneNumLbl";
            phoneNumLbl.Size = new Size(117, 30);
            phoneNumLbl.TabIndex = 14;
            phoneNumLbl.Text = "@Logon_lb";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.phonenum;
            pictureBox3.Location = new Point(199, 277);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // underThree
            // 
            underThree.AutoSize = true;
            underThree.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            underThree.ForeColor = Color.FromArgb(243, 194, 40);
            underThree.Location = new Point(261, 293);
            underThree.Name = "underThree";
            underThree.Size = new Size(314, 32);
            underThree.TabIndex = 15;
            underThree.Text = "______________________________";
            // 
            // mailLbl
            // 
            mailLbl.AutoSize = true;
            mailLbl.Font = new Font("Nirmala UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mailLbl.ForeColor = SystemColors.ButtonHighlight;
            mailLbl.Location = new Point(265, 185);
            mailLbl.Name = "mailLbl";
            mailLbl.Size = new Size(204, 30);
            mailLbl.TabIndex = 11;
            mailLbl.Text = "logon.lb@gmail.com";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.mail;
            pictureBox2.Location = new Point(199, 176);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // addresslbl
            // 
            addresslbl.AutoSize = true;
            addresslbl.Font = new Font("Nirmala UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addresslbl.ForeColor = SystemColors.ButtonHighlight;
            addresslbl.Location = new Point(262, 77);
            addresslbl.Name = "addresslbl";
            addresslbl.Size = new Size(291, 30);
            addresslbl.TabIndex = 8;
            addresslbl.Text = "Cara Dusana BB 16230 Lebane";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.address1;
            pictureBox1.Location = new Point(198, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // underOne
            // 
            underOne.AutoSize = true;
            underOne.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            underOne.ForeColor = Color.FromArgb(243, 194, 40);
            underOne.Location = new Point(260, 86);
            underOne.Name = "underOne";
            underOne.Size = new Size(314, 32);
            underOne.TabIndex = 6;
            underOne.Text = "______________________________";
            // 
            // underTwo
            // 
            underTwo.AutoSize = true;
            underTwo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            underTwo.ForeColor = Color.FromArgb(243, 194, 40);
            underTwo.Location = new Point(261, 192);
            underTwo.Name = "underTwo";
            underTwo.Size = new Size(314, 32);
            underTwo.TabIndex = 12;
            underTwo.Text = "______________________________";
            // 
            // childContactPanel
            // 
            childContactPanel.BackColor = Color.DimGray;
            childContactPanel.Controls.Add(label3);
            childContactPanel.Location = new Point(125, 379);
            childContactPanel.Name = "childContactPanel";
            childContactPanel.Size = new Size(399, 55);
            childContactPanel.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DimGray;
            label3.Font = new Font("Nirmala UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(50, 7);
            label3.Name = "label3";
            label3.Size = new Size(288, 40);
            label3.TabIndex = 17;
            label3.Text = "We're waiting for you";
            // 
            // qNotesPanel
            // 
            qNotesPanel.Controls.Add(UpdateNoteBtn);
            qNotesPanel.Controls.Add(labelNote);
            qNotesPanel.Controls.Add(QuickNotesListBox);
            qNotesPanel.Controls.Add(DeleteNoteBtn);
            qNotesPanel.Controls.Add(AddNoteBtn);
            qNotesPanel.Controls.Add(noteLbl);
            qNotesPanel.Controls.Add(NoteRichTextBox);
            qNotesPanel.Controls.Add(label5);
            qNotesPanel.Location = new Point(221, 54);
            qNotesPanel.Name = "qNotesPanel";
            qNotesPanel.Size = new Size(708, 511);
            qNotesPanel.TabIndex = 6;
            // 
            // labelNote
            // 
            labelNote.BackColor = Color.FromArgb(243, 194, 40);
            labelNote.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNote.ForeColor = Color.FromArgb(243, 194, 40);
            labelNote.Location = new Point(30, 24);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(2, 375);
            labelNote.TabIndex = 35;
            labelNote.Text = "_____________________________________";
            // 
            // QuickNotesListBox
            // 
            QuickNotesListBox.BackColor = Color.FromArgb(46, 51, 73);
            QuickNotesListBox.BorderStyle = BorderStyle.None;
            QuickNotesListBox.Font = new Font("Nirmala UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuickNotesListBox.ForeColor = SystemColors.Window;
            QuickNotesListBox.FormattingEnabled = true;
            QuickNotesListBox.ItemHeight = 25;
            QuickNotesListBox.Location = new Point(38, 24);
            QuickNotesListBox.Name = "QuickNotesListBox";
            QuickNotesListBox.Size = new Size(633, 350);
            QuickNotesListBox.TabIndex = 31;
            // 
            // DeleteNoteBtn
            // 
            DeleteNoteBtn.BackColor = Color.FromArgb(243, 194, 40);
            DeleteNoteBtn.BackgroundImageLayout = ImageLayout.Center;
            DeleteNoteBtn.Cursor = Cursors.Hand;
            DeleteNoteBtn.FlatAppearance.BorderSize = 0;
            DeleteNoteBtn.FlatStyle = FlatStyle.Flat;
            DeleteNoteBtn.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteNoteBtn.ForeColor = Color.FromArgb(43, 51, 73);
            DeleteNoteBtn.Location = new Point(168, 456);
            DeleteNoteBtn.Name = "DeleteNoteBtn";
            DeleteNoteBtn.Size = new Size(122, 35);
            DeleteNoteBtn.TabIndex = 34;
            DeleteNoteBtn.Text = "Delete note";
            DeleteNoteBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            DeleteNoteBtn.UseVisualStyleBackColor = false;
            DeleteNoteBtn.Click += DeleteNoteBtn_Click;
            // 
            // AddNoteBtn
            // 
            AddNoteBtn.BackColor = Color.FromArgb(243, 194, 40);
            AddNoteBtn.BackgroundImageLayout = ImageLayout.Center;
            AddNoteBtn.Cursor = Cursors.Hand;
            AddNoteBtn.FlatAppearance.BorderSize = 0;
            AddNoteBtn.FlatStyle = FlatStyle.Flat;
            AddNoteBtn.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNoteBtn.ForeColor = Color.FromArgb(43, 51, 73);
            AddNoteBtn.Location = new Point(46, 456);
            AddNoteBtn.Name = "AddNoteBtn";
            AddNoteBtn.Size = new Size(108, 35);
            AddNoteBtn.TabIndex = 32;
            AddNoteBtn.Text = "Add note";
            AddNoteBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            AddNoteBtn.UseVisualStyleBackColor = false;
            AddNoteBtn.Click += AddNoteBtn_Click;
            // 
            // noteLbl
            // 
            noteLbl.AutoSize = true;
            noteLbl.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noteLbl.ForeColor = SystemColors.Control;
            noteLbl.Location = new Point(484, 435);
            noteLbl.Name = "noteLbl";
            noteLbl.Size = new Size(77, 20);
            noteLbl.TabIndex = 30;
            noteLbl.Text = "Enter note";
            // 
            // NoteRichTextBox
            // 
            NoteRichTextBox.BackColor = Color.FromArgb(24, 30, 54);
            NoteRichTextBox.BorderStyle = BorderStyle.None;
            NoteRichTextBox.Font = new Font("Nirmala UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoteRichTextBox.ForeColor = SystemColors.Window;
            NoteRichTextBox.ImeMode = ImeMode.NoControl;
            NoteRichTextBox.Location = new Point(484, 458);
            NoteRichTextBox.MaxLength = 68;
            NoteRichTextBox.Name = "NoteRichTextBox";
            NoteRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            NoteRichTextBox.Size = new Size(185, 35);
            NoteRichTextBox.TabIndex = 33;
            NoteRichTextBox.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(243, 194, 40);
            label5.Location = new Point(476, 470);
            label5.Name = "label5";
            label5.Size = new Size(204, 32);
            label5.TabIndex = 6;
            label5.Text = "___________________";
            // 
            // weatherTimer
            // 
            weatherTimer.Interval = 1800000;
            weatherTimer.Tick += weatherTimer_Tick;
            // 
            // UpdateNoteBtn
            // 
            UpdateNoteBtn.BackColor = Color.FromArgb(243, 194, 40);
            UpdateNoteBtn.BackgroundImageLayout = ImageLayout.Center;
            UpdateNoteBtn.Cursor = Cursors.Hand;
            UpdateNoteBtn.FlatAppearance.BorderSize = 0;
            UpdateNoteBtn.FlatStyle = FlatStyle.Flat;
            UpdateNoteBtn.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateNoteBtn.ForeColor = Color.FromArgb(43, 51, 73);
            UpdateNoteBtn.Location = new Point(304, 456);
            UpdateNoteBtn.Name = "UpdateNoteBtn";
            UpdateNoteBtn.Size = new Size(126, 35);
            UpdateNoteBtn.TabIndex = 36;
            UpdateNoteBtn.Text = "Update note";
            UpdateNoteBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            UpdateNoteBtn.UseVisualStyleBackColor = false;
            UpdateNoteBtn.Click += UpdateNoteBtn_Click;
            // 
            // ApplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(qNotesPanel);
            Controls.Add(contactPanel);
            Controls.Add(MinimizeBtn);
            Controls.Add(ExitBtn);
            Controls.Add(LogonApplabel);
            Controls.Add(sidePanel1);
            Controls.Add(PanelHome);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ApplicationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ApplicationForm";
            Load += Form1_Load;
            sidePanel1.ResumeLayout(false);
            sidePanel1.PerformLayout();
            sidePanel2.ResumeLayout(false);
            sidePanel2.PerformLayout();
            PanelHome.ResumeLayout(false);
            aboutPanel.ResumeLayout(false);
            aboutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAboutDecor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhone).EndInit();
            weatherPanel.ResumeLayout(false);
            weatherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFeel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClouds).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWind).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHumidity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLaptop).EndInit();
            ((System.ComponentModel.ISupportInitialize)settingsIconPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            contactPanel.ResumeLayout(false);
            contactPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            childContactPanel.ResumeLayout(false);
            childContactPanel.PerformLayout();
            qNotesPanel.ResumeLayout(false);
            qNotesPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidePanel1;
        private Panel sidePanel2;
        private Label LogonApplabel;
        private Button SettingsBtn;
        private Button ExitBtn;
        private Button MinimizeBtn;
        private System.Windows.Forms.Timer timerClock;
        private Label ClockLabel;
        private Label DateLabel;
        private Label label1;
        private System.Windows.Forms.Timer AnimlogoTimer;
        private Panel PanelHome;
        private PictureBox LogoPictureBox;
        private Button HomeBtn;
        private Button AboutBtn;
        private Button LightThemeButton;
        private Button DarkThemeButton;
        private Button DefaultThemeButton;
        private PictureBox settingsIconPicture;
        private Panel aboutPanel;
        private Label label2;
        private Label QrLabel;
        private PictureBox pictureBoxChart;
        private PictureBox pictureBoxQR;
        private PictureBox pictureBoxPhone;
        private PictureBox pictureBoxLaptop;
        private PictureBox pictureBoxAboutDecor;
        private Label labelDesc;
        private Label labelTemp;
        private Label labelCity;
        private System.Windows.Forms.Timer weatherTimer;
        private Panel weatherPanel;
        private Label labelUnder;
        private Label labelFeels;
        private Label labelHumidity;
        private Label labelWind;
        private Label labelClouds;
        private PictureBox pictureBoxClouds;
        private PictureBox pictureBoxWind;
        private PictureBox pictureBoxHumidity;
        private PictureBox pictureBoxTemp;
        private PictureBox pictureBoxFeel;
        private Label windLbl;
        private Label humidityLbl;
        private Label feelsLbl;
        private Label temperatureLbl;
        private Label cloudsLbl;
        private Button ContactBtn;
        private Panel contactPanel;
        private Label phoneNumLbl;
        private PictureBox pictureBox3;
        private Label underThree;
        private Label mailLbl;
        private PictureBox pictureBox2;
        private Label addresslbl;
        private PictureBox pictureBox1;
        private Label underOne;
        private Label underTwo;
        private PictureBox pictureBox4;
        private Label label3;
        private Panel childContactPanel;
        private Button QnotesBtn;
        private Panel qNotesPanel;
        private ListBox QuickNotesListBox;
        private Button DeleteNoteBtn;
        private Button AddNoteBtn;
        private Label noteLbl;
        private RichTextBox NoteRichTextBox;
        private Label label5;
        private Label labelNote;
        private Label labelUser;
        private Label labelUserName;
        private Label label4;
        private Button logoutBtn;
        private Button UpdateNoteBtn;
    }
}
