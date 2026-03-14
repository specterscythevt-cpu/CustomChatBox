using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;

namespace Custom_Chat_Box
{
    public partial class Form1 : Form
    {
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private List<Label> usernameLabels = new List<Label>();
        private List<Label> messageLabels = new List<Label>();
        int MaxUserChars = 25;
        int MaxContentChars = 100;
        private Size originalSize;
        private Size originalSizeLb1;
        private Size originalSizeLb2;
        private Size originalSizePic1;
        private Point OriginalLocationLb1;
        private Point OriginalLocationLb2;
        bool AutoSizeFontContent = true;
        bool AutoSizeFontUser = true;
        float scaleFactor;
        bool firstlaunch = true;
        int originalLabelWidth;
        int originalLabelHeight;
        int originalLabel2Width;
        int originalLabel2Height;
        private TwitchClient twitchClient;
        bool Connected = false;
        private float initialFontSize2 = 18f;
        private float initialFontSize1 = 22f;
        int copyCount = 0;
        private int chatIndex = 0;
        int copyIndex = 0;
        string savePath = Path.Combine(Application.StartupPath, "savedImage.png");
        string savePath2 = Path.Combine(Application.StartupPath, "savedImage.png");
        public Form1()
        {
            InitializeComponent();
            label1.BringToFront();
            label2.BringToFront();
            if (File.Exists(savePath))
            {
                using (var stream = new FileStream(savePath, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(stream);
                }
            }
            else { }
            Settingsfrm form2 = (Settingsfrm)Application.OpenForms["Settingsfrm"];
            if (form2 != null)
            {
                if (File.Exists(savePath2) && form2.BackgroundImage == true)
                {
                    using (var stream = new FileStream(savePath2, FileMode.Open, FileAccess.Read))
                    {
                        pictureBox1.BackgroundImage = Image.FromStream(stream);
                    }
                }
            }
            else { }
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            originalSize = ClientSize;
            originalSizeLb1 = label1.Size;
            originalSizeLb2 = label2.Size;
            originalSizePic1 = pictureBox1.Size;
            OriginalLocationLb1 = label1.Location;
            OriginalLocationLb2 = label2.Location;
            originalLabelWidth = label1.Width;
            originalLabelHeight = label1.Height;
            originalLabel2Width = label2.Width;
            originalLabel2Height = label2.Height;
        }

        private void GetTwitchChats()
        {
            if (Properties.Settings.Default.OAuth != "Empty")
            {
                if (Connected == false && twitchClient == null)
                {
                    string ChName = Properties.Settings.Default.TwitchName;
                    string s = Properties.Settings.Default.OAuth;
                    var credentials = new ConnectionCredentials("Simple_bot", s);
                    twitchClient = new TwitchClient();
                    twitchClient.Initialize(credentials, ChName);

                    twitchClient.OnMessageReceived += OnMessageReceived;
                    twitchClient.Connect();
                    Connected = true;
                }
            }
        }

        private void OnMessageReceived(object? sender, OnMessageReceivedArgs e)
        {
            string username = e.ChatMessage.Username;
            string message = e.ChatMessage.Message;

            string[] ignoredUsers = Properties.Settings.Default.IgnoredUsers.Split('|');
            if (Array.Exists(ignoredUsers, user => user.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }

            copyCount++;

            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => AddChatMessage(username, message)));
                return;
            }
            else
            {
                AddChatMessage(username, message);
            }
        }

        public void UpdateLabelPosition(Point newPosition)
        {
            label1.Left = newPosition.X;
            label1.Top = newPosition.Y;
            OriginalLocationLb1 = newPosition;
        }
        public void UpdateLabelPosition2(Point newPosition)
        {
            label2.Left = newPosition.X;
            label2.Top = newPosition.Y;
            OriginalLocationLb2 = newPosition;
        }
        public void Save()
        {
            Properties.Settings.Default.UserXY = label1.Location;
            Properties.Settings.Default.ContentXY = label2.Location;
            label1.Invalidate();
            label2.Invalidate();
            Properties.Settings.Default.Save();
        }
        private void SizeChange()
        {
            this.ClientSize = new Size((int)(originalSize.Width * scaleFactor), (int)(originalSize.Height * scaleFactor));
            label1.Size = new Size((int)(originalSizeLb1.Width * scaleFactor), (int)(originalSizeLb1.Height * scaleFactor));
            label2.Size = new Size((int)(originalSizeLb2.Width * scaleFactor), (int)(originalSizeLb2.Height * scaleFactor));
            pictureBox1.Size = new Size((int)(originalSizePic1.Width * scaleFactor), (int)(originalSizePic1.Height * scaleFactor));
            label1.Location = new Point((int)(OriginalLocationLb1.X * scaleFactor), (int)(OriginalLocationLb1.Y * scaleFactor));
            label2.Location = new Point((int)(OriginalLocationLb2.X * scaleFactor), (int)(OriginalLocationLb2.Y * scaleFactor));
        }
        public void CheckState(string checktomake)
        {
            scaleFactor = 1.0f;

            if (checktomake == "UserFont")
            {
                label1.Font = new Font("Segoe UI", Properties.Settings.Default.UserFontSize);
                AutoSizeFontUser = false;
            }
            if (checktomake == "ContentFont")
            {
                label2.Font = new Font("Segoe UI", Properties.Settings.Default.ContentFontSize);
                AutoSizeFontContent = false;
            }
            if (checktomake == "UserChars")
            {
                MaxUserChars = Properties.Settings.Default.MaxUserChars;
            }
            if (checktomake == "ContentChars")
            {
                MaxContentChars = Properties.Settings.Default.MaxContentChars;
            }
            if (checktomake == "ChatBoxScale25")
            {
                scaleFactor = 0.30f;
                SizeChange();
            }
            if (checktomake == "ChatBoxScale50")
            {
                scaleFactor = 0.50f;
                SizeChange();
            }
            if (checktomake == "ChatBoxScale75")
            {
                scaleFactor = 0.75f;
                SizeChange();
            }
            if (checktomake == "ChatBoxScale100")
            {
                scaleFactor = 1.0f;
                SizeChange();
            }
            if (checktomake == "ChatBoxScale150")
            {
                scaleFactor = 1.50f;
                SizeChange();
            }
            if (checktomake == "ChatBoxScale200")
            {
                scaleFactor = 2.0f;
                SizeChange();
            }
            if (checktomake == "HideUser")
            {
                label1.Visible = false;
            }
            if (checktomake == "ShowUser")
            {
                label1.Visible = true;
            }
            if (checktomake == "HideContent")
            {
                label2.Visible = false;
            }
            if (checktomake == "ShowContent")
            {
                label2.Visible = true;
            }
            if (checktomake == "YesUsernameTextFit")
            {
                AutoSizeFontUser = true;
            }
            if (checktomake == "YesContentTextFit")
            {
                AutoSizeFontContent = true;
            }
        }
        private void label2_SizeChanged(object sender, EventArgs e)
        {
            if (AutoSizeFontContent == true)
            {
                float widthRatio = (float)label2.Width / originalLabel2Width;
                float heightRatio = (float)label2.Height / originalLabel2Height;

                float scaleFactor = Math.Min(widthRatio, heightRatio);

                float fontSize = initialFontSize2 * scaleFactor;

                fontSize = Math.Max(fontSize, 6f);

                label2.Font = new Font(label1.Font.FontFamily, fontSize);
            }
        }

        private void label1_SizeChanged(object sender, EventArgs e)
        {
            if (AutoSizeFontUser == true)
            {
                float widthRatio = (float)label1.Width / originalLabelWidth;
                float heightRatio = (float)label1.Height / originalLabelHeight;

                float scaleFactor = Math.Min(widthRatio, heightRatio);

                float fontSize = initialFontSize1 * scaleFactor;

                fontSize = Math.Max(fontSize, 5f);

                label1.Font = new Font(label1.Font.FontFamily, fontSize);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Settingsfrm settingsfrm = new Settingsfrm();
            settingsfrm.Show();
            if (firstlaunch == true)
            {
                GetTwitchChats();
            }
            this.StartPosition = FormStartPosition.Manual;
            if (Properties.Settings.Default.StartPosition == "BottomRight")
            {
                Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

                int x = workingArea.Right - this.Width;
                int y = workingArea.Bottom - this.Height;

                this.Location = new Point(x, y);
            }
            if (Properties.Settings.Default.StartPosition == "BottomLeft")
            {
                Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

                int x = workingArea.Left;
                int y = workingArea.Bottom - this.Height;

                this.Location = new Point(x, y);
            }
            if (Properties.Settings.Default.StartPosition == "TopRight")
            {
                Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

                int x = workingArea.Right - this.Width;
                int y = workingArea.Top;

                this.Location = new Point(x, y);

            }
            if (Properties.Settings.Default.StartPosition == "TopLeft")
            {
                Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

                int x = workingArea.Left;
                int y = workingArea.Top;

                this.Location = new Point(x, y);
            }
        }
        public string A = "";
        public void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AddChatMessage(string username, string message)
        {
            if (usernameLabels.Count == 0 || messageLabels.Count == 0) return;

            usernameLabels[chatIndex].Text = username;
            messageLabels[chatIndex].Text = message;

            chatIndex = (chatIndex + 1) % usernameLabels.Count;
        }

        public void AddStacks()
        {//getting the labels to be transparent and show the image of the Picturebox behind them. making it be the parent should have worked but it did not, it might be that because its meant to make a lot of the different items, it assings the label to the wrong picturebox parent, but thats just a theory
            //making it repeat its duplication more then just once. it only ever doubles itself and nothing more, it stops after one dupilcation.
            //while it does properly get the messages, it will display the first message in the starting controls, and that 100% works as it should, however it skips the 2nd message and displays the 3rd in the second duplication of the controls, as because it was stated that it only duplicates once right now
            int chatNum = Properties.Settings.Default.ChatNum;
            int verticalSpacing = pictureBox1.Height + 20;
            this.Height += verticalSpacing;
            usernameLabels.Add(label1);
            messageLabels.Add(label2);

            for (int i = 0; i < chatNum; i++)
            {
                int verticalOffset = i * verticalSpacing;

                PictureBox pb = new PictureBox
                {
                    Image = pictureBox1.Image,
                    Size = pictureBox1.Size,
                    Location = new System.Drawing.Point(pictureBox1.Left, pictureBox1.Top + verticalOffset),
                    SizeMode = PictureBoxSizeMode.Zoom
                };

                Label userLabel = new Label
                {
                    Size = label1.Size,
                    Location = new System.Drawing.Point(label1.Left, label1.Top + verticalOffset),
                    BackColor = Color.Transparent,
                    Parent = pb,
                    Font = label1.Font,
                    AutoSize = false
                };
                Controls.Add(userLabel);
                usernameLabels.Add(userLabel);

                Label msgLabel = new Label
                {
                    Size = label2.Size,
                    Location = new System.Drawing.Point(label2.Left, label2.Top + verticalOffset),
                    BackColor = Color.Transparent,
                    Parent = pb,
                    Font = label2.Font,
                    AutoSize = false
                };
                Controls.Add(msgLabel);
                messageLabels.Add(msgLabel);
                Controls.Add(pb);
                pictureBoxes.Add(pb);
            }
        }
        public void RedrawBounds()
        {
            this.Invalidate();
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            if (A == "Paint")
            {
                e.Graphics.DrawRectangle(Pens.Blue, 0, 0, label1.Width - 1, label1.Height - 1);
            }
        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            if (A == "Paint")
            {
                e.Graphics.DrawRectangle(Pens.Blue, 0, 0, label2.Width - 1, label2.Height - 1);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.OemQuestion)
            {
                Settingsfrm settingsfrm = new Settingsfrm();
                settingsfrm.Show();
            }
        }
    }
}