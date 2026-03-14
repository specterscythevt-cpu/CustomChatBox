namespace Custom_Chat_Box
{
    public partial class Settingsfrm : Form
    {
        string Checks = "";
        string savePath = Path.Combine(Application.StartupPath, "savedImage.png");
        string savePath2 = Path.Combine(Application.StartupPath, "savedImage2.png");
        private bool mousedown = false;
        private Point mouseOffset;
        string SaveSet = "No";
        public bool BackgroundImage = false;
        public Settingsfrm()
        {
            InitializeComponent();
            maskedTextBox1.Visible = false;
            label20.Visible = false;
            panel1.Visible = false;
            maskedTextBox2.Visible = false;
            label19.Visible = false;

        }

        private void OpenPngBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG Images (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;

                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(savePath, System.Drawing.Imaging.ImageFormat.Png);
                }
                using (var stream = new FileStream(savePath, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(stream);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Transition Type
            Properties.Settings.Default.TransitionType = comboBox1.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Transition Speed
            Properties.Settings.Default.TransitionSpeed = comboBox2.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void AddIgnoreUserBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(IgnoreUserTxtBx.Text))
            {
                string newUser = IgnoreUserTxtBx.Text.Trim();
                Properties.Settings.Default.IgnoredUsers += newUser + "|";
                Properties.Settings.Default.Save();
                IgnoreUserTxtBx.Clear();
            }

            string usersString = Properties.Settings.Default.IgnoredUsers ?? string.Empty;
            string[] usersArray = usersString.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            IgnoreUserDisplayTxt.Text = string.Empty;

            foreach (string user in usersArray)
            {
                IgnoreUserDisplayTxt.Text += user + " ";
            }

        }

        private void RemoveIgnoredUserBtn_Click(object sender, EventArgs e)
        {
            string userToRemove = IgnoreUserTxtBx.Text.Trim();

            string original = Properties.Settings.Default.IgnoredUsers ?? string.Empty;

            string[] usersArray = original.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> updatedUsers = new List<string>(usersArray);

            if (updatedUsers.Contains(userToRemove))
            {
                updatedUsers.Remove(userToRemove);
                Properties.Settings.Default.IgnoredUsers = string.Join("|", updatedUsers);
                Properties.Settings.Default.Save();
            }

            IgnoreUserTxtBx.Clear();

            IgnoreUserDisplayTxt.Text = string.Empty;
            foreach (string user in updatedUsers)
            {
                IgnoreUserDisplayTxt.Text += user + " ";
            }
        }

        private void ShowContentChkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (!ShowContentChkBx.Checked)
            {
                MessageContentLB.Visible = false;
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.CheckState("HideContent");
                }
            }
            else
            {
                MessageContentLB.Visible = true;
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.CheckState("ShowContent");
                }
            }
        }

        private void ShowUserChkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (!ShowUserChkBx.Checked)
            {
                UsernameLB.Visible = false;
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.CheckState("HideUser");
                }
            }
            else
            {
                UsernameLB.Visible = true;
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.CheckState("ShowUser");
                }
            }
        }

        private void SaveSettingsBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Saving will close the settings window, Are you sure you want to save?", "Save Settings", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SaveSet = "Yes";
                Properties.Settings.Default.OAuth = OAuthTxtBx.Text;
                Properties.Settings.Default.TwitchName = ChannelNameTxtBx.Text;
                Properties.Settings.Default.ChatNum = Convert.ToInt32(ChatNumBoxs.Text);
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.Save();
                    Properties.Settings.Default.UserSize = form1.label1.Size;
                    Properties.Settings.Default.ContentSize = form1.label2.Size;
                    form1.A = "";
                    form1.RedrawBounds();
                    form1.AddStacks();
                }
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                SaveSet = "No";
            }
        }


        private void MessageContentLB_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            mouseOffset = new Point(e.X, e.Y);
        }

        private void MessageContentLB_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                var newPosition = this.PointToClient(Cursor.Position);
                newPosition.Offset(-mouseOffset.X, -mouseOffset.Y);

                if (newPosition.X >= 536 && newPosition.X <= 735 && newPosition.Y >= 192 && newPosition.Y <= 319)
                {
                    MessageContentLB.Location = newPosition;
                    UpdateForm1LabelPosition2();
                }
            }
        }

        private void MessageContentLB_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }
        private int test;
        private int test2;
        private void UsernameLB_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            mouseOffset = new Point(e.X, e.Y);
            test = UsernameLB.Left;
            test2 = UsernameLB.Top;
        }

        private void UsernameLB_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                var newPosition = this.PointToClient(Cursor.Position);
                newPosition.Offset(-mouseOffset.X, -mouseOffset.Y);

                if (newPosition.X >= 536 && newPosition.X <= 735 && newPosition.Y >= 192 && newPosition.Y <= 319)
                {
                    UsernameLB.Location = newPosition;
                    UpdateForm1LabelPosition();
                }
            }
        }

        private void UsernameLB_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void UpdateForm1LabelPosition()
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                // Calculate the position relative to the PictureBox on Settingsfrm
                var relativePosition = new Point(
                    UsernameLB.Left - pictureBox1.Left,
                    UsernameLB.Top - pictureBox1.Top);

                // Scale for the larger PictureBox on Form1
                var scaledPosition = new Point(
                    (int)(relativePosition.X * 2.0),
                    (int)(relativePosition.Y * 2.0));

                form1.UpdateLabelPosition(scaledPosition);
            }
        }

        private void UpdateForm1LabelPosition2()
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                // Calculate the position relative to the PictureBox on Settingsfrm
                var relativePosition = new Point(
                    MessageContentLB.Left - pictureBox1.Left,
                    MessageContentLB.Top - pictureBox1.Top);

                // Scale for the larger PictureBox on Form1
                var scaledPosition = new Point(
                    (int)(relativePosition.X * 2.0),
                    (int)(relativePosition.Y * 2.0));

                form1.UpdateLabelPosition2(scaledPosition);
            }
        }

        private void ChatNumBoxs_TextChanged(object sender, EventArgs e)
        {
            if (ChatNumBoxs.Text != null)
            {
                try
                {
                    int chatNum = Convert.ToInt32(ChatNumBoxs.Text);
                    if (chatNum >= 0 && chatNum <= 99)
                    {
                        Properties.Settings.Default.ChatNum = chatNum;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number between 1 and 99.");
                        ChatNumBoxs.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number.");
                    ChatNumBoxs.Clear();
                }
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.CheckState("");
                }
            }
        }

        private void UserFontSizeTxtBx_TextChanged(object sender, EventArgs e)
        {


        }

        private void ContentFontSizeTxtBx_TextChanged(object sender, EventArgs e)
        {


        }

        private void MaxUserCharsTxtBx_TextChanged(object sender, EventArgs e)
        {
            //max user characters in a chat message
            if (MaxUserCharsTxtBx.Text != null)
            {
                try
                {
                    int maxChars = Convert.ToInt32(MaxUserCharsTxtBx.Text);
                    if (maxChars >= 1 && maxChars <= 100)
                    {
                        Properties.Settings.Default.MaxUserChars = maxChars;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number between 10 and 1000.");
                        MaxUserCharsTxtBx.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number.");
                    MaxUserCharsTxtBx.Clear();
                }
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.CheckState("UserChars");
                }
            }
        }

        private void MaxContentCharsTxtBx_TextChanged(object sender, EventArgs e)
        {
            //max characters in a chat message
            if (MaxContentCharsTxtBx.Text != null)
            {
                try
                {
                    int maxChars = Convert.ToInt32(MaxContentCharsTxtBx.Text);
                    if (maxChars >= 1 && maxChars <= 999)
                    {
                        Properties.Settings.Default.MaxContentChars = maxChars;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number between 10 and 1000.");
                        MaxContentCharsTxtBx.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number.");
                    MaxContentCharsTxtBx.Clear();
                }
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.CheckState("ContentChars");
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //chat move direction
        }

        private void ChatNumBoxs_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ChatNumBoxs.Clear();
        }

        private void UserFontSizeTxtBx_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void ContentFontSizeTxtBx_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void MaxUserCharsTxtBx_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MaxUserCharsTxtBx.Clear();
        }

        private void MaxContentCharsTxtBx_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MaxContentCharsTxtBx.Clear();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4_SelectedIndexChanged != null)
            {
                if (comboBox4.SelectedIndex == 0)
                {
                    Form1 form1 = (Form1)Application.OpenForms["Form1"];
                    if (form1 != null)
                    {
                        form1.CheckState("ChatBoxScale25");
                    }
                }
                else if (comboBox4.SelectedIndex == 1)
                {
                    Form1 form1 = (Form1)Application.OpenForms["Form1"];
                    if (form1 != null)
                    {
                        form1.CheckState("ChatBoxScale50");
                    }
                }
                else if (comboBox4.SelectedIndex == 2)
                {
                    Form1 form1 = (Form1)Application.OpenForms["Form1"];
                    if (form1 != null)
                    {
                        form1.CheckState("ChatBoxScale75");
                    }
                }
                else if (comboBox4.SelectedIndex == 3)
                {
                    Form1 form1 = (Form1)Application.OpenForms["Form1"];
                    if (form1 != null)
                    {
                        form1.CheckState("ChatBoxScale100");
                    }
                }
                else if (comboBox4.SelectedIndex == 4)
                {
                    Form1 form1 = (Form1)Application.OpenForms["Form1"];
                    if (form1 != null)
                    {
                        form1.CheckState("ChatBoxScale150");
                    }
                }
                else if (comboBox4.SelectedIndex == 5)
                {
                    Form1 form1 = (Form1)Application.OpenForms["Form1"];
                    if (form1 != null)
                    {
                        form1.CheckState("ChatBoxScale200");
                    }
                }
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //User Custom font size rejected
            MessageBox.Show("Please enter a valid number.");
            maskedTextBox2.Text = string.Empty;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //Content Custom font size rejected
            MessageBox.Show("Please enter a valid number.");
            maskedTextBox1.Text = string.Empty;
        }

        private void SaveCustomFontSize_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Visible == true)
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.CheckState("CustomContentFont");
                }
            }
            if (maskedTextBox2.Visible == true)
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.CheckState("CustomUserFont");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Username text fit//label19 // masked textbox2
            if (!checkBox1.Checked)
            {
                panel1.Visible = true;
                maskedTextBox2.Visible = true;
                label19.Visible = true;
            }
            else if (checkBox1.Checked)
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.CheckState("YesUsernameTextFit");
                }
                if (checkBox2.Checked)
                {
                    panel1.Visible = false;
                    maskedTextBox2.Visible = false;
                    label19.Visible = false;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //content text fit
            if (!checkBox2.Checked)
            {
                panel1.Visible = true;
                maskedTextBox1.Visible = true;
                label20.Visible = true;
            }
            else if (checkBox2.Checked)
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.CheckState("YesContentTextFit");
                }
                if (checkBox1.Checked)
                {
                    panel1.Visible = false;
                }
                maskedTextBox1.Visible = false;
                label20.Visible = false;
            }
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            //custom Username font change
            if (maskedTextBox2.Text != null)
            {
                try
                {
                    int fontSize = Convert.ToInt32(maskedTextBox2.Text);
                    if (fontSize >= 6 && fontSize <= 50)
                    {
                        Properties.Settings.Default.UserFontSize = fontSize;
                        Form1 form1 = (Form1)Application.OpenForms["Form1"];
                        if (form1 != null)
                        {
                            form1.CheckState("UserFont");
                        }
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number between 6 and 50.");
                        maskedTextBox2.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number.");
                    maskedTextBox2.Clear();
                }
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            //custom Content font change
            if (maskedTextBox1.Text != null)
            {
                try
                {
                    int fontSize = Convert.ToInt32(maskedTextBox1.Text);
                    if (fontSize >= 6 && fontSize <= 50)
                    {
                        Properties.Settings.Default.ContentFontSize = fontSize;
                        Form1 form1 = (Form1)Application.OpenForms["Form1"];
                        if (form1 != null)
                        {
                            form1.CheckState("ContentFont");
                        }
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number between 6 and 50.");
                        maskedTextBox1.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number.");
                    maskedTextBox1.Clear();
                }
            }
        }

        private void AddBGImageBtn_Click(object sender, EventArgs e)
        {
            BackgroundImage = true;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG Images (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;

                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(savePath2, System.Drawing.Imaging.ImageFormat.Png);
                }
                using (var stream = new FileStream(savePath2, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(stream);
                }
            }
        }

        private void RemoveBGImageBtn_Click(object sender, EventArgs e)
        {
            BackgroundImage = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

                int x = workingArea.Left;
                int y = workingArea.Top;

                form1.Location = new Point(x, y);
                Properties.Settings.Default.StartPosition = "TopLeft";
                Properties.Settings.Default.Save();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

                int x = workingArea.Right - form1.Width;
                int y = workingArea.Top;

                form1.Location = new Point(x, y);
                Properties.Settings.Default.StartPosition = "TopRight";
                Properties.Settings.Default.Save();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //bottom left
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

                int x = workingArea.Left;
                int y = workingArea.Bottom - form1.Height;

                form1.Location = new Point(x, y);
                Properties.Settings.Default.StartPosition = "BottomLeft";
                Properties.Settings.Default.Save();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //bottom right
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

                int x = workingArea.Right - form1.Width;
                int y = workingArea.Bottom - form1.Height;

                form1.Location = new Point(x, y);
                Properties.Settings.Default.StartPosition = "BottomRight";
                Properties.Settings.Default.Save();
            }
        }

        private void Settingsfrm_Load_1(object sender, EventArgs e)
        {
            OAuthTxtBx.Text = Properties.Settings.Default.OAuth;
            ChannelNameTxtBx.Text = Properties.Settings.Default.TwitchName;
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 2;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 3;
            UsernameLB.BringToFront();
            MessageContentLB.BringToFront();
            if (File.Exists(savePath))
            {
                using (var stream = new FileStream(savePath, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(stream);
                }
            }
            if (File.Exists(savePath2) && BackgroundImage == true)
            {
                using (var stream = new FileStream(savePath2, FileMode.Open, FileAccess.Read))
                {
                    pictureBox2.Image = Image.FromStream(stream);
                }
            }
            else { }
            if (SaveSet == "No")
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.RedrawBounds();
                    form1.A = "Paint";
                }
            }
            string usersString = Properties.Settings.Default.IgnoredUsers ?? string.Empty;
            string[] usersArray = usersString.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            IgnoreUserDisplayTxt.Text = string.Empty;

            foreach (string user in usersArray)
            {
                IgnoreUserDisplayTxt.Text += user + " ";
            }
        }

        private void UserWidthAddBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                form1.label1.Width += 1;
                form1.A = "Paint";
                form1.RedrawBounds();
            }
        }

        private void UserWidthMinusBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                form1.label1.Width -= 1;
                form1.A = "Paint";
                form1.RedrawBounds();
            }
        }

        private void UserHeightAddBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                form1.label1.Height += 1;
                form1.A = "Paint";
                form1.RedrawBounds();
            }
        }

        private void UserHeightMinusBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                form1.label1.Height -= 1;
                form1.A = "Paint";
                form1.RedrawBounds();
            }
        }

        private void ContentWidthAddBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                form1.label2.Width += 1;
                form1.A = "Paint";
                form1.RedrawBounds();
            }
        }

        private void ContentWidthMinusBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                form1.label2.Width -= 1;
                form1.A = "Paint";
                form1.RedrawBounds();
            }
        }

        private void ContentHeightAddBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                form1.label2.Height += 1;
                form1.A = "Paint";
                form1.RedrawBounds();
            }
        }

        private void ContentHeightMinusBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                form1.label2.Height -= 1;
                form1.A = "Paint";
                form1.RedrawBounds();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.TopMost = true;
                }
            }
            else
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.TopMost = false;
                }
            }
        }
    }
}