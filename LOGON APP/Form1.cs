using System.Data.SqlClient;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using Microsoft.VisualBasic;

namespace LOGON_APP
{
    public partial class ApplicationForm : Form
    {
        // Animation
        #region AnimationFields
        private bool growing = true;
        private int step = 2;
        // Max size of PictureBox
        private int maxSize = 350;
        // Min size of PictureBox
        private int minSize = 310;
        #endregion

        private short noteNum = 0;
        // use button instance for set active button
        Button activeButton = null;

        // List for notes
        private List<Note> notes = new List<Note>();
        private int currentUserId = 0; 

        // Group of controls
        #region Controls
        Control[] home;
        Control[] settings;
        Control[] about;
        Control[] contact;
        Control[] qNotes;
        #endregion

        // Colors
        #region Colors
        Color currentBackColor = Color.FromArgb(46, 51, 73);
        Color currentForeColor = Color.White;
        Color hoverBackColor = Color.FromArgb(70, 75, 100); // default hover color
        #endregion

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottonRect,
            int nWidthEllipse, int nHeightEllipse
        );

        public ApplicationForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            labelNote.Visible = false;
            // PictureBox
            #region pictureBoxes
            pictureBox1.AutoSize = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.AutoSize = false;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.AutoSize = false;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.AutoSize = false;
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            settingsIconPicture.AutoSize = false;
            settingsIconPicture.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPictureBox.AutoSize = false;
            LogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPictureBox.Width = 350;
            LogoPictureBox.Height = 350;
            pictureBoxAboutDecor.AutoSize = false;
            pictureBoxAboutDecor.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxChart.AutoSize = false;
            pictureBoxChart.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClouds.AutoSize = false;
            pictureBoxClouds.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFeel.AutoSize = false;
            pictureBoxFeel.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHumidity.AutoSize = false;
            pictureBoxHumidity.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLaptop.AutoSize = false;
            pictureBoxLaptop.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhone.AutoSize = false;
            pictureBoxPhone.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxQR.AutoSize = false;
            pictureBoxQR.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTemp.AutoSize = false;
            pictureBoxTemp.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxWind.AutoSize = false;
            pictureBoxWind.SizeMode = PictureBoxSizeMode.Zoom;
            #endregion
            // timer conf
            timerClock.Start();
            AnimlogoTimer.Start();
            this.FormBorderStyle = FormBorderStyle.None;
            // Regions for rect
            #region rect-regions
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            aboutPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, aboutPanel.Width, aboutPanel.Height, 50, 50));
            weatherPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, weatherPanel.Width, weatherPanel.Height, 70, 70));
            childContactPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, childContactPanel.Width, childContactPanel.Height, 70, 70));
            #endregion
            // button conf
            MinimizeBtn.UseVisualStyleBackColor = false;
            ExitBtn.UseVisualStyleBackColor = false;
            // controls
            #region controls-app
            home = new Control[] { LogonApplabel, LogoPictureBox, weatherPanel };
            settings = new Control[] { LogonApplabel, LightThemeButton, DarkThemeButton, DefaultThemeButton, settingsIconPicture };
            about = new Control[] { LogonApplabel, aboutPanel, pictureBoxChart, pictureBoxQR, pictureBoxLaptop, pictureBoxPhone, pictureBoxAboutDecor };
            contact = new Control[] { LogonApplabel, contactPanel };
            qNotes = new Control[] { LogonApplabel, qNotesPanel };
            #endregion
            // methods
            showControls(home);
            SetActiveButton(HomeBtn);
        }

        // Event for Form1 when form loads (opens)
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var ctrl in settings)
                ctrl.Visible = false;
            LogonApplabel.Visible = true;
            LoadWeatherLebane();
            getNotesFromUser();
            renumerateListBox();
            labelNote.Visible = QuickNotesListBox.Items.Count > 0;
        }

        // Get weather images
        #region WeatherImages
        private Image GetTempImage(double temp)
        {
            string path = temp <= 0
                ? @"assets/weather/low-temp.png"
                : temp >= 15
                    ? @"assets/weather/high-temp.png"
                    : @"assets/weather/mid-temp.png";
            return Image.FromFile(path);
        }
        private Image GetHumidityImage(double humidity)
        {
            string path = humidity > 50
                ? @"assets/weather/humidity-high.png"
                : @"assets/weather/humidity-low.png";
            return Image.FromFile(path);
        }
        private Image GetWindImage(double windSpeed)
        {
            string path = windSpeed > 5
                ? @"assets/weather/high-wind.png"
                : @"assets/weather/low-wind.png";
            return Image.FromFile(path);
        }
        private Image GetCloudsImage(double clouds)
        {
            string path = clouds > 50
                ? @"assets/weather/clouds.png"
                : @"assets/weather/cloud.png";
            return Image.FromFile(path);
        }
        private Image GetFeelImage(double feelTemp)
        {
            string path = feelTemp <= 0
                ? @"assets/weather/cold-feel.png"
                : feelTemp >= 15
                    ? @"assets/weather/hot-feel.png"
                    : @"assets/weather/mid-feel.png";
            return Image.FromFile(path);
        }
        #endregion

        // Methods region
        #region Methods
        // Method for show all controls from all groups -> return none
        private void showControls(Control[] controlsToShow)
        {
            Control[][] allGroups = { home, settings, about, contact, qNotes };
            foreach (var group in allGroups)
                foreach (var ctrl in group)
                    ctrl.Visible = false;
            foreach (var ctrl in controlsToShow)
                ctrl.Visible = true;
        }

        // Method for set active button for set color -> return none
        private void SetActiveButton(Button clickedButton)
        {
            if (activeButton != null)
                activeButton.BackColor = GetButtonBackColor(activeButton);
            activeButton = clickedButton;
            activeButton.BackColor = currentBackColor;
        }

        // Method for get button backcolor what depends on app theme -> return Color instance
        private Color GetButtonBackColor(Button btn)
        {
            // Light theme
            if (currentBackColor == Color.White)
                return btn == ExitBtn || btn == MinimizeBtn ? Color.White : Color.Black;
            // Default theme
            if (currentBackColor == Color.FromArgb(46, 51, 73))
                return btn == ExitBtn || btn == MinimizeBtn ? currentBackColor : Color.FromArgb(24, 30, 54);
            // Dark theme
            if (currentBackColor == Color.FromArgb(8, 8, 8))
                return btn == ExitBtn || btn == MinimizeBtn ? currentBackColor : Color.FromArgb(24, 24, 24);
            return currentBackColor;
        }

        // Method for load weather with API from Lebane town using openWeather 
        private async void LoadWeatherLebane()
        {
            try
            {
                System.Net.ServicePointManager.SecurityProtocol =
                System.Net.SecurityProtocolType.Tls12;
                string apiKey = Environment.GetEnvironmentVariable("MY_API_KEY", EnvironmentVariableTarget.User); // API key
                if (string.IsNullOrEmpty(apiKey))
                    throw new ArgumentException("API key not found");
                else
                {
                    string url = $"https://api.openweathermap.org/data/2.5/weather?q=Lebane,RS&units=metric&lang=en&appid={apiKey}";
                    // Use Http client for get data from weather API
                    using (HttpClient client = new HttpClient())
                    {
                        string json = await client.GetStringAsync(url);
                        WeatherResponse data = JsonSerializer.Deserialize<WeatherResponse>(json);
                        // Labels
                        labelCity.Text = "Lebane Town";
                        // temperature
                        pictureBoxTemp.Image = GetTempImage(data.main.temp);
                        labelTemp.Text = $"{data.main.temp} °C";
                        // Description
                        labelDesc.Text = "Description: " + data.weather[0].description;
                        // Feels
                        pictureBoxFeel.Image = GetFeelImage(data.main.feels_like);
                        labelFeels.Text = $"{data.main.feels_like} °C";
                        // Humidity
                        pictureBoxHumidity.Image = GetHumidityImage(data.main.humidity);
                        labelHumidity.Text = $"{data.main.humidity}%";
                        // Wind
                        pictureBoxWind.Image = GetWindImage(data.wind.speed);
                        labelWind.Text = $"{data.wind.speed} m/s";
                        // Clouds
                        pictureBoxClouds.Image = GetCloudsImage(data.clouds.all);
                        labelClouds.Text = $"{data.clouds.all}%";
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch
            {
                labelCity.Text = "City: Lebane";
                labelTemp.Text = $"- °C";
                labelDesc.Text = "Check internet connection!";
            }
        }

        // Method for renumerate items -> notes in listBox
        private void renumerateListBox()
        {
            for (int i = 0; i < QuickNotesListBox.Items.Count; i++)
            {
                string note = QuickNotesListBox.Items[i].ToString();
                // Delete old number (before first dot)
                int dotIndex = note.IndexOf("."); // index of first dot in list item
                if (dotIndex != -1) // if first dot exists
                    // delete first dot and trim note
                    note = note.Substring(dotIndex + 1).Trim();
                QuickNotesListBox.Items[i] = $"{i + 1}.   {note}";
            }
        }

        #endregion

        // Exit button
        #region Exit-button
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to exit app?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            ExitBtn.BackColor = hoverBackColor;
            ExitBtn.ForeColor = Color.FromArgb(243, 194, 40); // žuta
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            ExitBtn.BackColor = currentBackColor;
            ExitBtn.ForeColor = currentForeColor;
        }
        #endregion

        // Minimize button
        #region Minimize-button
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinimizeBtn_MouseEnter(object sender, EventArgs e)
        {
            MinimizeBtn.BackColor = hoverBackColor;
            MinimizeBtn.ForeColor = Color.FromArgb(243, 194, 40); // žuta
        }

        private void MinimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            MinimizeBtn.BackColor = currentBackColor;
            MinimizeBtn.ForeColor = currentForeColor;
        }
        #endregion

        // timers
        #region timer-anim
        // Timer for date and clock
        private void timerClock_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            DateLabel.Text = DateTime.Now.ToShortDateString();
        }
        // Timer for animate logo
        private void AnimlogoTimer_Tick(object sender, EventArgs e)
        {
            int x = LogoPictureBox.Size.Width;
            int y = LogoPictureBox.Size.Height;

            if (growing)
            {
                x += step; y += step;
                if (x >= maxSize) growing = false;
            }
            else
            {
                x -= step; y -= step;
                if (x <= minSize) growing = true;
            }
            LogoPictureBox.Size = new Size(x, y);
            this.Invalidate();
        }
        // Timer for refresh weather
        private void weatherTimer_Tick(object sender, EventArgs e)
        {
            // Every 30 minutes -> call LoadWeatherLebane() async method
            LoadWeatherLebane();
        }
        #endregion 

        // Buttons for themes light/dark/default
        #region settings-themes
        // Light theme
        private void LightThemeButton_Click(object sender, EventArgs e)
        {
            // Current colors
            currentBackColor = Color.White;
            currentForeColor = Color.Black;
            hoverBackColor = Color.White; // hover color
            this.BackColor = currentBackColor;
            // Side panel
            sidePanel1.BackColor = Color.Black;
            sidePanel2.BackColor = Color.Black;
            // Main label for display tab
            LogonApplabel.ForeColor = Color.Black;
            // Clock and date label
            ClockLabel.ForeColor = Color.White;
            DateLabel.ForeColor = Color.White;
            // Side-buttons
            HomeBtn.BackColor = Color.Black;
            AboutBtn.BackColor = Color.Black;
            SettingsBtn.BackColor = Color.Black;
            ContactBtn.BackColor = Color.Black;
            QnotesBtn.BackColor = Color.Black;
            logoutBtn.BackColor = Color.Black;
            // Exit and minimize buttons
            ExitBtn.BackColor = currentBackColor;
            ExitBtn.ForeColor = currentForeColor;
            MinimizeBtn.BackColor = currentBackColor;
            MinimizeBtn.ForeColor = currentForeColor;
            // About tab
            aboutPanel.BackColor = Color.WhiteSmoke;
            // Home tab
            weatherPanel.BackColor = Color.FromArgb(240, 204, 74);
            labelUnder.ForeColor = Color.White;
            weatherPanel.ForeColor = Color.Black;
            // Contact tab
            contactPanel.BackColor = currentBackColor;
            addresslbl.ForeColor = currentForeColor;
            mailLbl.ForeColor = currentForeColor;
            phoneNumLbl.ForeColor = currentForeColor;
            childContactPanel.BackColor = Color.Black;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            // Qnotes tab
            qNotesPanel.BackColor = currentBackColor;
            QuickNotesListBox.BackColor = currentBackColor;
            QuickNotesListBox.ForeColor = currentForeColor;
            NoteRichTextBox.BackColor = Color.Black;
            NoteRichTextBox.ForeColor = Color.White;
            noteLbl.ForeColor = currentForeColor;
            if (activeButton != null)
                activeButton.BackColor = currentBackColor;
        }
        // Default theme
        private void DefaultThemeButton_Click(object sender, EventArgs e)
        {
            // Current colors
            currentBackColor = Color.FromArgb(46, 51, 73);
            currentForeColor = Color.White;
            hoverBackColor = currentBackColor; // hover color
            this.BackColor = currentBackColor;
            // Side panel
            sidePanel1.BackColor = Color.FromArgb(24, 30, 54);
            sidePanel2.BackColor = Color.FromArgb(24, 30, 54);
            // Main label for display tab
            LogonApplabel.ForeColor = Color.White;
            // Clock and date label
            ClockLabel.ForeColor = Color.White;
            DateLabel.ForeColor = Color.White;
            // Side-buttons
            HomeBtn.BackColor = Color.FromArgb(24, 30, 54);
            AboutBtn.BackColor = Color.FromArgb(24, 30, 54);
            SettingsBtn.BackColor = Color.FromArgb(46, 51, 73);
            ContactBtn.BackColor = Color.FromArgb(24, 30, 54);
            QnotesBtn.BackColor = Color.FromArgb(24, 30, 54);
            logoutBtn.BackColor = Color.FromArgb(24, 30, 54);
            // Exit and minimize buttons
            ExitBtn.BackColor = currentBackColor;
            ExitBtn.ForeColor = currentForeColor;
            MinimizeBtn.BackColor = currentBackColor;
            MinimizeBtn.ForeColor = currentForeColor;
            // About tab
            aboutPanel.BackColor = Color.White;
            // Home tab
            weatherPanel.BackColor = Color.White;
            labelUnder.ForeColor = Color.FromArgb(240, 204, 74);
            weatherPanel.ForeColor = Color.Black;
            // Contact tab
            contactPanel.BackColor = currentBackColor;
            addresslbl.ForeColor = currentForeColor;
            mailLbl.ForeColor = currentForeColor;
            phoneNumLbl.ForeColor = currentForeColor;
            childContactPanel.BackColor = Color.DimGray;
            label3.BackColor = Color.DimGray;
            // Qnotes tab
            qNotesPanel.BackColor = currentBackColor;
            QuickNotesListBox.BackColor = currentBackColor;
            QuickNotesListBox.ForeColor = currentForeColor;
            NoteRichTextBox.BackColor = Color.FromArgb(24, 30, 54);
            NoteRichTextBox.ForeColor = Color.White;
            noteLbl.ForeColor = currentForeColor;
        }
        // Dark theme
        private void DarkThemeButton_Click(object sender, EventArgs e)
        {
            currentBackColor = Color.FromArgb(8, 8, 8);
            currentForeColor = Color.DarkGray;
            hoverBackColor = Color.Black; // hover color
            this.BackColor = currentBackColor;
            sidePanel1.BackColor = Color.FromArgb(24, 24, 24);
            sidePanel2.BackColor = Color.FromArgb(24, 24, 24);
            LogonApplabel.ForeColor = Color.Gray;
            ClockLabel.ForeColor = Color.FromArgb(243, 194, 40);
            DateLabel.ForeColor = Color.Gray;
            // side btns
            HomeBtn.BackColor = Color.FromArgb(24, 24, 24);
            AboutBtn.BackColor = Color.FromArgb(24, 24, 24);
            SettingsBtn.BackColor = Color.FromArgb(8, 8, 8);
            ContactBtn.BackColor = Color.FromArgb(24, 24, 24);
            QnotesBtn.BackColor = Color.FromArgb(24, 24, 24);
            logoutBtn.BackColor = Color.FromArgb(24, 24, 24);
            // panels and other buttons
            ExitBtn.BackColor = currentBackColor;
            ExitBtn.ForeColor = currentForeColor;
            MinimizeBtn.BackColor = currentBackColor;
            MinimizeBtn.ForeColor = currentForeColor;
            aboutPanel.BackColor = Color.White;
            weatherPanel.BackColor = Color.Gray;
            labelUnder.ForeColor = Color.FromArgb(240, 204, 74);
            weatherPanel.ForeColor = Color.White;
            contactPanel.BackColor = currentBackColor;
            addresslbl.ForeColor = currentForeColor;
            mailLbl.ForeColor = currentForeColor;
            phoneNumLbl.ForeColor = currentForeColor;
            childContactPanel.BackColor = Color.White;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Black;
            // Qnotes tab
            qNotesPanel.BackColor = currentBackColor;
            QuickNotesListBox.BackColor = currentBackColor;
            QuickNotesListBox.ForeColor = currentForeColor;
            NoteRichTextBox.BackColor = Color.FromArgb(24, 24, 24);
            NoteRichTextBox.ForeColor = Color.White;
            noteLbl.ForeColor = currentForeColor;
            if (activeButton != null)
                activeButton.BackColor = currentBackColor;
        }
        #endregion

        // SideBar buttons
        #region side-btns
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            AnimlogoTimer.Start();
            LogonApplabel.Text = "Home";
            showControls(home);
        }
        private void AboutBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            AnimlogoTimer.Stop();
            LogonApplabel.Text = "About";
            showControls(about);
        }
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            AnimlogoTimer.Stop();
            LogonApplabel.Text = "Settings";
            showControls(settings);
        }
        private void ContactBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            AnimlogoTimer.Stop();
            LogonApplabel.Text = "Contact";
            showControls(contact);
        }
        private void QnotesBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            AnimlogoTimer.Stop();
            LogonApplabel.Text = "Quick notes";
            showControls(qNotes);
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }
        // Events for logout (UI)
        private void logoutBtn_MouseEnter(object sender, EventArgs e) => logoutBtn.BackColor = Color.FromArgb(176, 37, 37);
        private void logoutBtn_MouseLeave(object sender, EventArgs e) => logoutBtn.BackColor = GetButtonBackColor(logoutBtn);
        #endregion

        // Manage notes (delete/add/get)
        #region NoteManage
        public void SetUser(int userId, string username)
        {
            currentUserId = userId;
            labelUserName.Text = username;
            getNotesFromUser();
        }
        // CRUD  
        private void getNotesFromUser()
        {
            notes.Clear(); // Clear a list of notes
            using (SqlConnection conn = new SqlConnection(Connection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetNotesByUser", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", currentUserId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // for every row, add new note with another content and id
                        notes.Add(new Note
                        {
                            Id = reader.GetInt32(0),
                            Content = reader.GetString(1)
                        });
                    }
                }
            }
            // ListBox
            QuickNotesListBox.Items.Clear();
            foreach (var note in notes)
                QuickNotesListBox.Items.Add(note.ToString());
        }
        private void AddNoteBtn_Click(object sender, EventArgs e)
        {
            if (NoteRichTextBox.Text.Length == 0 || string.IsNullOrWhiteSpace(NoteRichTextBox.Text))
            {
                MessageBox.Show(
                    "Note cannot be empty!",
                    "information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            using (SqlConnection conn = new SqlConnection(Connection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddNote", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NoteContent", NoteRichTextBox.Text);
                cmd.Parameters.AddWithValue("@UserId", currentUserId);
                cmd.ExecuteNonQuery();
            }
            // empty textbox for enter note
            NoteRichTextBox.Text = string.Empty;
            getNotesFromUser();
            renumerateListBox();
            if (QuickNotesListBox.Items.Count > 0)
                labelNote.Visible = true;
        }
        private void UpdateNoteBtn_Click(object sender, EventArgs e)
        {
            int indexNote = QuickNotesListBox.SelectedIndex;
            if (indexNote == -1)
            {
                MessageBox.Show(
                    "Select a note first!",
                    "Warning",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                );
                return;
            }
            Note selectedNote = notes[indexNote];
            string newContent = Interaction.InputBox(
                "Edit your note:",
                "Edit Note",
                selectedNote.Content
            );
            if (string.IsNullOrEmpty(newContent)) return;
            //UPDATE
            using (SqlConnection conn = new SqlConnection(Connection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateNote", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NoteId", selectedNote.Id);
                cmd.Parameters.AddWithValue("@UserId", currentUserId);
                cmd.Parameters.AddWithValue("@Content", newContent);
                cmd.ExecuteNonQuery();
            }
            getNotesFromUser();
            renumerateListBox();
        }
        private void DeleteNoteBtn_Click(object sender, EventArgs e)
        {
            int index = QuickNotesListBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Select a note first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Note selectedNote = notes[index];
            using (SqlConnection conn = new SqlConnection(Connection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DeleteNote", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", currentUserId);
                cmd.Parameters.AddWithValue("@NoteId", selectedNote.Id);
                cmd.ExecuteNonQuery();
            }
            getNotesFromUser();
            renumerateListBox();
            if (QuickNotesListBox.Items.Count == 0)
                labelNote.Visible = false;
        }
        // procedura
        #endregion  
    }
}