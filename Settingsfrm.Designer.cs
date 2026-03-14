namespace Custom_Chat_Box
{
    partial class Settingsfrm
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
            label1 = new Label();
            ChatNumBoxs = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            OpenPngBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            UsernameLB = new Label();
            label5 = new Label();
            label6 = new Label();
            IgnoreUserDisplayTxt = new TextBox();
            IgnoreUserTxtBx = new TextBox();
            AddIgnoreUserBtn = new Button();
            ShowUserChkBx = new CheckBox();
            ShowContentChkBx = new CheckBox();
            SaveSettingsBtn = new Button();
            comboBox2 = new ComboBox();
            label7 = new Label();
            RemoveIgnoredUserBtn = new Button();
            MessageContentLB = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            MaxUserCharsTxtBx = new MaskedTextBox();
            MaxContentCharsTxtBx = new MaskedTextBox();
            label14 = new Label();
            pictureBox2 = new PictureBox();
            label15 = new Label();
            AddBGImageBtn = new Button();
            RemoveBGImageBtn = new Button();
            label16 = new Label();
            comboBox3 = new ComboBox();
            label17 = new Label();
            comboBox4 = new ComboBox();
            label18 = new Label();
            panel1 = new Panel();
            SaveCustomFontSize = new Button();
            label21 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            label20 = new Label();
            label19 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label8 = new Label();
            label9 = new Label();
            label22 = new Label();
            ChannelNameTxtBx = new TextBox();
            OAuthTxtBx = new TextBox();
            panel2 = new Panel();
            UserWidthMinusBtn = new Button();
            UserHeightMinusBtn = new Button();
            UserWidthAddBtn = new Button();
            UserHeightAddBtn = new Button();
            ContentWidthMinusBtn = new Button();
            ContentWidthAddBtn = new Button();
            ContentHeightMinusBtn = new Button();
            ContentHeightAddBtn = new Button();
            label24 = new Label();
            label25 = new Label();
            label23 = new Label();
            label10 = new Label();
            checkBox3 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 17);
            label1.TabIndex = 0;
            label1.Text = "Number of chat boxes";
            // 
            // ChatNumBoxs
            // 
            ChatNumBoxs.Location = new Point(157, 9);
            ChatNumBoxs.Mask = "00";
            ChatNumBoxs.Name = "ChatNumBoxs";
            ChatNumBoxs.Size = new Size(21, 25);
            ChatNumBoxs.TabIndex = 1;
            ChatNumBoxs.Text = "5";
            ChatNumBoxs.ValidatingType = typeof(int);
            ChatNumBoxs.MaskInputRejected += ChatNumBoxs_MaskInputRejected;
            ChatNumBoxs.TextChanged += ChatNumBoxs_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untfsdddfsitled;
            pictureBox1.Location = new Point(536, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(589, 172);
            label2.Name = "label2";
            label2.Size = new Size(161, 17);
            label2.TabIndex = 3;
            label2.Text = "Your Custom Chatbox png";
            // 
            // OpenPngBtn
            // 
            OpenPngBtn.Location = new Point(536, 411);
            OpenPngBtn.Name = "OpenPngBtn";
            OpenPngBtn.Size = new Size(266, 36);
            OpenPngBtn.TabIndex = 4;
            OpenPngBtn.Text = "Open File";
            OpenPngBtn.UseVisualStyleBackColor = true;
            OpenPngBtn.Click += OpenPngBtn_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(536, 346);
            label3.Name = "label3";
            label3.Size = new Size(266, 53);
            label3.TabIndex = 5;
            label3.Text = "After uploading a png Place the username in the center of where you want it, and the content in the top left.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 42);
            label4.Name = "label4";
            label4.Size = new Size(141, 17);
            label4.TabIndex = 6;
            label4.Text = "Transition to new chats";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Static", "Fade-in" });
            comboBox1.Location = new Point(159, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // UsernameLB
            // 
            UsernameLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameLB.Location = new Point(625, 210);
            UsernameLB.Name = "UsernameLB";
            UsernameLB.Size = new Size(87, 25);
            UsernameLB.TabIndex = 8;
            UsernameLB.Text = "Username";
            UsernameLB.TextAlign = ContentAlignment.MiddleCenter;
            UsernameLB.MouseDown += UsernameLB_MouseDown;
            UsernameLB.MouseMove += UsernameLB_MouseMove;
            UsernameLB.MouseUp += UsernameLB_MouseUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 77);
            label5.Name = "label5";
            label5.Size = new Size(134, 17);
            label5.TabIndex = 10;
            label5.Text = "Chat Transition speed";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 169);
            label6.Name = "label6";
            label6.Size = new Size(91, 17);
            label6.TabIndex = 12;
            label6.Text = "Ignored Users";
            // 
            // IgnoreUserDisplayTxt
            // 
            IgnoreUserDisplayTxt.Location = new Point(9, 189);
            IgnoreUserDisplayTxt.Multiline = true;
            IgnoreUserDisplayTxt.Name = "IgnoreUserDisplayTxt";
            IgnoreUserDisplayTxt.Size = new Size(152, 121);
            IgnoreUserDisplayTxt.TabIndex = 13;
            // 
            // IgnoreUserTxtBx
            // 
            IgnoreUserTxtBx.Location = new Point(9, 312);
            IgnoreUserTxtBx.Name = "IgnoreUserTxtBx";
            IgnoreUserTxtBx.Size = new Size(152, 25);
            IgnoreUserTxtBx.TabIndex = 14;
            // 
            // AddIgnoreUserBtn
            // 
            AddIgnoreUserBtn.Location = new Point(7, 341);
            AddIgnoreUserBtn.Name = "AddIgnoreUserBtn";
            AddIgnoreUserBtn.Size = new Size(74, 23);
            AddIgnoreUserBtn.TabIndex = 15;
            AddIgnoreUserBtn.Text = "Add";
            AddIgnoreUserBtn.UseVisualStyleBackColor = true;
            AddIgnoreUserBtn.Click += AddIgnoreUserBtn_Click;
            // 
            // ShowUserChkBx
            // 
            ShowUserChkBx.AutoSize = true;
            ShowUserChkBx.Checked = true;
            ShowUserChkBx.CheckState = CheckState.Checked;
            ShowUserChkBx.Location = new Point(12, 370);
            ShowUserChkBx.Name = "ShowUserChkBx";
            ShowUserChkBx.Size = new Size(127, 21);
            ShowUserChkBx.TabIndex = 16;
            ShowUserChkBx.Text = "Show Usernames";
            ShowUserChkBx.UseVisualStyleBackColor = true;
            ShowUserChkBx.CheckedChanged += ShowUserChkBx_CheckedChanged;
            // 
            // ShowContentChkBx
            // 
            ShowContentChkBx.AutoSize = true;
            ShowContentChkBx.Checked = true;
            ShowContentChkBx.CheckState = CheckState.Checked;
            ShowContentChkBx.Location = new Point(12, 397);
            ShowContentChkBx.Name = "ShowContentChkBx";
            ShowContentChkBx.Size = new Size(107, 21);
            ShowContentChkBx.TabIndex = 17;
            ShowContentChkBx.Text = "Show Content";
            ShowContentChkBx.UseVisualStyleBackColor = true;
            ShowContentChkBx.CheckedChanged += ShowContentChkBx_CheckedChanged;
            // 
            // SaveSettingsBtn
            // 
            SaveSettingsBtn.Location = new Point(9, 422);
            SaveSettingsBtn.Name = "SaveSettingsBtn";
            SaveSettingsBtn.Size = new Size(96, 25);
            SaveSettingsBtn.TabIndex = 18;
            SaveSettingsBtn.Text = "Save Settings";
            SaveSettingsBtn.UseVisualStyleBackColor = true;
            SaveSettingsBtn.Click += SaveSettingsBtn_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Very Slow", "Slow", "Medium", "Fast", "Very Fast", "ludicrous speed(plaid)" });
            comboBox2.Location = new Point(159, 72);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 25);
            comboBox2.TabIndex = 19;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 127);
            label7.Name = "label7";
            label7.Size = new Size(0, 17);
            label7.TabIndex = 20;
            // 
            // RemoveIgnoredUserBtn
            // 
            RemoveIgnoredUserBtn.Location = new Point(87, 341);
            RemoveIgnoredUserBtn.Name = "RemoveIgnoredUserBtn";
            RemoveIgnoredUserBtn.Size = new Size(74, 23);
            RemoveIgnoredUserBtn.TabIndex = 21;
            RemoveIgnoredUserBtn.Text = "Remove";
            RemoveIgnoredUserBtn.UseVisualStyleBackColor = true;
            RemoveIgnoredUserBtn.Click += RemoveIgnoredUserBtn_Click;
            // 
            // MessageContentLB
            // 
            MessageContentLB.AutoSize = true;
            MessageContentLB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MessageContentLB.Location = new Point(554, 263);
            MessageContentLB.Name = "MessageContentLB";
            MessageContentLB.Size = new Size(61, 20);
            MessageContentLB.TabIndex = 9;
            MessageContentLB.Text = "Content";
            MessageContentLB.MouseDown += MessageContentLB_MouseDown;
            MessageContentLB.MouseMove += MessageContentLB_MouseMove;
            MessageContentLB.MouseUp += MessageContentLB_MouseUp;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(193, 108);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 21);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "Username text fit";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(193, 135);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(112, 21);
            checkBox2.TabIndex = 28;
            checkBox2.Text = "Content text fit";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label11
            // 
            label11.Location = new Point(193, 159);
            label11.Name = "label11";
            label11.Size = new Size(126, 73);
            label11.TabIndex = 29;
            label11.Text = "If the text is too large/small to fit, it will adjust the font size to ensure it fits";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(167, 241);
            label12.Name = "label12";
            label12.Size = new Size(162, 17);
            label12.TabIndex = 30;
            label12.Text = "Max Username Characters";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(167, 269);
            label13.Name = "label13";
            label13.Size = new Size(148, 17);
            label13.TabIndex = 31;
            label13.Text = "Max Content Characters";
            // 
            // MaxUserCharsTxtBx
            // 
            MaxUserCharsTxtBx.Location = new Point(335, 241);
            MaxUserCharsTxtBx.Mask = "000";
            MaxUserCharsTxtBx.Name = "MaxUserCharsTxtBx";
            MaxUserCharsTxtBx.Size = new Size(28, 25);
            MaxUserCharsTxtBx.TabIndex = 32;
            MaxUserCharsTxtBx.Text = "025";
            MaxUserCharsTxtBx.ValidatingType = typeof(int);
            MaxUserCharsTxtBx.MaskInputRejected += MaxUserCharsTxtBx_MaskInputRejected;
            MaxUserCharsTxtBx.TextChanged += MaxUserCharsTxtBx_TextChanged;
            // 
            // MaxContentCharsTxtBx
            // 
            MaxContentCharsTxtBx.Location = new Point(335, 269);
            MaxContentCharsTxtBx.Mask = "000";
            MaxContentCharsTxtBx.Name = "MaxContentCharsTxtBx";
            MaxContentCharsTxtBx.Size = new Size(28, 25);
            MaxContentCharsTxtBx.TabIndex = 33;
            MaxContentCharsTxtBx.Text = "100";
            MaxContentCharsTxtBx.ValidatingType = typeof(int);
            MaxContentCharsTxtBx.MaskInputRejected += MaxContentCharsTxtBx_MaskInputRejected;
            MaxContentCharsTxtBx.TextChanged += MaxContentCharsTxtBx_TextChanged;
            // 
            // label14
            // 
            label14.Location = new Point(167, 292);
            label14.Name = "label14";
            label14.Size = new Size(196, 53);
            label14.TabIndex = 34;
            label14.Text = "this is a test to see how many characters 100 really is, i mean honestly its not that little, and it";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.launcher_foreground;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.Untfsdddfsitled;
            pictureBox2.Location = new Point(560, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(541, 0);
            label15.Name = "label15";
            label15.Size = new Size(170, 17);
            label15.TabIndex = 36;
            label15.Text = "Background Image example";
            // 
            // AddBGImageBtn
            // 
            AddBGImageBtn.Location = new Point(560, 112);
            AddBGImageBtn.Name = "AddBGImageBtn";
            AddBGImageBtn.Size = new Size(67, 23);
            AddBGImageBtn.TabIndex = 37;
            AddBGImageBtn.Text = "Add";
            AddBGImageBtn.UseVisualStyleBackColor = true;
            AddBGImageBtn.Click += AddBGImageBtn_Click;
            // 
            // RemoveBGImageBtn
            // 
            RemoveBGImageBtn.Location = new Point(627, 112);
            RemoveBGImageBtn.Name = "RemoveBGImageBtn";
            RemoveBGImageBtn.Size = new Size(66, 23);
            RemoveBGImageBtn.TabIndex = 38;
            RemoveBGImageBtn.Text = "Remove";
            RemoveBGImageBtn.UseVisualStyleBackColor = true;
            RemoveBGImageBtn.Click += RemoveBGImageBtn_Click;
            // 
            // label16
            // 
            label16.Location = new Point(709, 0);
            label16.Name = "label16";
            label16.Size = new Size(95, 144);
            label16.TabIndex = 39;
            label16.Text = "This is not needed, however you may add one for more options for how the chat-box looks";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Down-To-Up", "Up-To-Down", "Left-To-Right", "Right-To-Left" });
            comboBox3.Location = new Point(327, 352);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 25);
            comboBox3.TabIndex = 40;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(167, 354);
            label17.Name = "label17";
            label17.Size = new Size(154, 17);
            label17.TabIndex = 41;
            label17.Text = "Chat movement direction";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "30%", "50%", "75%", "100%", "150%", "200%" });
            comboBox4.Location = new Point(263, 383);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 25);
            comboBox4.TabIndex = 42;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(167, 386);
            label18.Name = "label18";
            label18.Size = new Size(90, 17);
            label18.TabIndex = 44;
            label18.Text = "Chatbox Scale";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(SaveCustomFontSize);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label19);
            panel1.Location = new Point(325, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 100);
            panel1.TabIndex = 45;
            panel1.Visible = false;
            // 
            // SaveCustomFontSize
            // 
            SaveCustomFontSize.Location = new Point(66, 72);
            SaveCustomFontSize.Name = "SaveCustomFontSize";
            SaveCustomFontSize.Size = new Size(75, 23);
            SaveCustomFontSize.TabIndex = 5;
            SaveCustomFontSize.Text = "Save";
            SaveCustomFontSize.UseVisualStyleBackColor = true;
            SaveCustomFontSize.Click += SaveCustomFontSize_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(32, 49);
            label21.Name = "label21";
            label21.Size = new Size(141, 17);
            label21.TabIndex = 4;
            label21.Text = "Example 05, 10, 15 ect.";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(161, 1);
            maskedTextBox2.Mask = "00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(20, 25);
            maskedTextBox2.TabIndex = 3;
            maskedTextBox2.Text = "00";
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            maskedTextBox2.TextChanged += maskedTextBox2_TextChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(147, 26);
            maskedTextBox1.Mask = "00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(20, 25);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.Text = "00";
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            maskedTextBox1.TextChanged += maskedTextBox1_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(3, 26);
            label20.Name = "label20";
            label20.Size = new Size(138, 17);
            label20.TabIndex = 1;
            label20.Text = "Enter Content Fontsize";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(3, 4);
            label19.Name = "label19";
            label19.Size = new Size(152, 17);
            label19.TabIndex = 0;
            label19.Text = "Enter Username Fontsize";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(button4, 1, 1);
            tableLayoutPanel1.Location = new Point(325, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(205, 100);
            tableLayoutPanel1.TabIndex = 46;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(96, 44);
            button1.TabIndex = 0;
            button1.Text = "Top Left";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(105, 3);
            button2.Name = "button2";
            button2.Size = new Size(97, 44);
            button2.TabIndex = 1;
            button2.Text = "Top Right";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(3, 53);
            button3.Name = "button3";
            button3.Size = new Size(96, 44);
            button3.TabIndex = 2;
            button3.Text = "Bottom Left";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(105, 53);
            button4.Name = "button4";
            button4.Size = new Size(97, 44);
            button4.TabIndex = 3;
            button4.Text = "Bottom Right";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(349, 9);
            label8.Name = "label8";
            label8.Size = new Size(157, 17);
            label8.TabIndex = 47;
            label8.Text = "Chatbox Window location";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 106);
            label9.Name = "label9";
            label9.Size = new Size(44, 17);
            label9.TabIndex = 48;
            label9.Text = "OAuth";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(13, 135);
            label22.Name = "label22";
            label22.Size = new Size(93, 17);
            label22.TabIndex = 49;
            label22.Text = "Channel Name";
            // 
            // ChannelNameTxtBx
            // 
            ChannelNameTxtBx.Location = new Point(112, 136);
            ChannelNameTxtBx.Name = "ChannelNameTxtBx";
            ChannelNameTxtBx.Size = new Size(75, 25);
            ChannelNameTxtBx.TabIndex = 50;
            // 
            // OAuthTxtBx
            // 
            OAuthTxtBx.Location = new Point(62, 105);
            OAuthTxtBx.Name = "OAuthTxtBx";
            OAuthTxtBx.Size = new Size(125, 25);
            OAuthTxtBx.TabIndex = 51;
            // 
            // panel2
            // 
            panel2.Controls.Add(UserWidthMinusBtn);
            panel2.Controls.Add(UserHeightMinusBtn);
            panel2.Controls.Add(UserWidthAddBtn);
            panel2.Controls.Add(UserHeightAddBtn);
            panel2.Controls.Add(ContentWidthMinusBtn);
            panel2.Controls.Add(ContentWidthAddBtn);
            panel2.Controls.Add(ContentHeightMinusBtn);
            panel2.Controls.Add(ContentHeightAddBtn);
            panel2.Controls.Add(label24);
            panel2.Controls.Add(label25);
            panel2.Controls.Add(label23);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(369, 241);
            panel2.Name = "panel2";
            panel2.Size = new Size(161, 112);
            panel2.TabIndex = 52;
            // 
            // UserWidthMinusBtn
            // 
            UserWidthMinusBtn.Location = new Point(138, 5);
            UserWidthMinusBtn.Name = "UserWidthMinusBtn";
            UserWidthMinusBtn.Size = new Size(21, 23);
            UserWidthMinusBtn.TabIndex = 54;
            UserWidthMinusBtn.Text = "-";
            UserWidthMinusBtn.UseVisualStyleBackColor = true;
            UserWidthMinusBtn.Click += UserWidthMinusBtn_Click;
            // 
            // UserHeightMinusBtn
            // 
            UserHeightMinusBtn.Location = new Point(135, 28);
            UserHeightMinusBtn.Name = "UserHeightMinusBtn";
            UserHeightMinusBtn.Size = new Size(21, 23);
            UserHeightMinusBtn.TabIndex = 9;
            UserHeightMinusBtn.Text = "-";
            UserHeightMinusBtn.UseVisualStyleBackColor = true;
            UserHeightMinusBtn.Click += UserHeightMinusBtn_Click;
            // 
            // UserWidthAddBtn
            // 
            UserWidthAddBtn.Location = new Point(111, 5);
            UserWidthAddBtn.Name = "UserWidthAddBtn";
            UserWidthAddBtn.Size = new Size(21, 23);
            UserWidthAddBtn.TabIndex = 53;
            UserWidthAddBtn.Text = "+";
            UserWidthAddBtn.UseVisualStyleBackColor = true;
            UserWidthAddBtn.Click += UserWidthAddBtn_Click;
            // 
            // UserHeightAddBtn
            // 
            UserHeightAddBtn.Location = new Point(108, 28);
            UserHeightAddBtn.Name = "UserHeightAddBtn";
            UserHeightAddBtn.Size = new Size(21, 23);
            UserHeightAddBtn.TabIndex = 8;
            UserHeightAddBtn.Text = "+";
            UserHeightAddBtn.UseVisualStyleBackColor = true;
            UserHeightAddBtn.Click += UserHeightAddBtn_Click;
            // 
            // ContentWidthMinusBtn
            // 
            ContentWidthMinusBtn.Location = new Point(124, 51);
            ContentWidthMinusBtn.Name = "ContentWidthMinusBtn";
            ContentWidthMinusBtn.Size = new Size(21, 23);
            ContentWidthMinusBtn.TabIndex = 7;
            ContentWidthMinusBtn.Text = "-";
            ContentWidthMinusBtn.UseVisualStyleBackColor = true;
            ContentWidthMinusBtn.Click += ContentWidthMinusBtn_Click;
            // 
            // ContentWidthAddBtn
            // 
            ContentWidthAddBtn.Location = new Point(97, 51);
            ContentWidthAddBtn.Name = "ContentWidthAddBtn";
            ContentWidthAddBtn.Size = new Size(21, 23);
            ContentWidthAddBtn.TabIndex = 6;
            ContentWidthAddBtn.Text = "+";
            ContentWidthAddBtn.UseVisualStyleBackColor = true;
            ContentWidthAddBtn.Click += ContentWidthAddBtn_Click;
            // 
            // ContentHeightMinusBtn
            // 
            ContentHeightMinusBtn.Location = new Point(128, 73);
            ContentHeightMinusBtn.Name = "ContentHeightMinusBtn";
            ContentHeightMinusBtn.Size = new Size(21, 23);
            ContentHeightMinusBtn.TabIndex = 5;
            ContentHeightMinusBtn.Text = "-";
            ContentHeightMinusBtn.UseVisualStyleBackColor = true;
            ContentHeightMinusBtn.Click += ContentHeightMinusBtn_Click;
            // 
            // ContentHeightAddBtn
            // 
            ContentHeightAddBtn.Location = new Point(101, 73);
            ContentHeightAddBtn.Name = "ContentHeightAddBtn";
            ContentHeightAddBtn.Size = new Size(21, 23);
            ContentHeightAddBtn.TabIndex = 4;
            ContentHeightAddBtn.Text = "+";
            ContentHeightAddBtn.UseVisualStyleBackColor = true;
            ContentHeightAddBtn.Click += ContentHeightAddBtn_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(1, 72);
            label24.Name = "label24";
            label24.Size = new Size(95, 17);
            label24.TabIndex = 3;
            label24.Text = "Content Height";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(1, 52);
            label25.Name = "label25";
            label25.Size = new Size(91, 17);
            label25.TabIndex = 2;
            label25.Text = "Content Width";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(1, 28);
            label23.Name = "label23";
            label23.Size = new Size(109, 17);
            label23.TabIndex = 1;
            label23.Text = "Username Height";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1, 8);
            label10.Name = "label10";
            label10.Size = new Size(105, 17);
            label10.TabIndex = 0;
            label10.Text = "Username Width";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(167, 414);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(130, 21);
            checkBox3.TabIndex = 53;
            checkBox3.Text = "TopMost Window";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // Settingsfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox3);
            Controls.Add(panel2);
            Controls.Add(OAuthTxtBx);
            Controls.Add(ChannelNameTxtBx);
            Controls.Add(label22);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(label18);
            Controls.Add(comboBox4);
            Controls.Add(label17);
            Controls.Add(comboBox3);
            Controls.Add(label16);
            Controls.Add(RemoveBGImageBtn);
            Controls.Add(AddBGImageBtn);
            Controls.Add(label15);
            Controls.Add(pictureBox2);
            Controls.Add(label14);
            Controls.Add(MaxContentCharsTxtBx);
            Controls.Add(MaxUserCharsTxtBx);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(RemoveIgnoredUserBtn);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(SaveSettingsBtn);
            Controls.Add(ShowContentChkBx);
            Controls.Add(ShowUserChkBx);
            Controls.Add(AddIgnoreUserBtn);
            Controls.Add(IgnoreUserTxtBx);
            Controls.Add(IgnoreUserDisplayTxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(MessageContentLB);
            Controls.Add(UsernameLB);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(OpenPngBtn);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(ChatNumBoxs);
            Controls.Add(label1);
            Name = "Settingsfrm";
            Text = "Settingsfrm";
            Load += Settingsfrm_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox ChatNumBoxs;
        private PictureBox pictureBox1;
        private Label label2;
        private Button OpenPngBtn;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Label UsernameLB;
        private Label label5;
        private Label label6;
        private TextBox IgnoreUserDisplayTxt;
        private TextBox IgnoreUserTxtBx;
        private Button AddIgnoreUserBtn;
        private CheckBox ShowUserChkBx;
        private CheckBox ShowContentChkBx;
        private Button SaveSettingsBtn;
        private ComboBox comboBox2;
        private Label label7;
        private Button RemoveIgnoredUserBtn;
        private Label MessageContentLB;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label11;
        private Label label12;
        private Label label13;
        private MaskedTextBox MaxUserCharsTxtBx;
        private MaskedTextBox MaxContentCharsTxtBx;
        private Label label14;
        private PictureBox pictureBox2;
        private Label label15;
        private Button AddBGImageBtn;
        private Button RemoveBGImageBtn;
        private Label label16;
        private ComboBox comboBox3;
        private Label label17;
        private ComboBox comboBox4;
        private Label label18;
        private Panel panel1;
        private Label label21;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label20;
        private Label label19;
        private Button SaveCustomFontSize;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label8;
        private Label label9;
        private Label label22;
        private TextBox ChannelNameTxtBx;
        private TextBox OAuthTxtBx;
        private Panel panel2;
        private Button UserWidthMinusBtn;
        private Button UserHeightMinusBtn;
        private Button UserWidthAddBtn;
        private Button UserHeightAddBtn;
        private Button ContentWidthMinusBtn;
        private Button ContentWidthAddBtn;
        private Button ContentHeightMinusBtn;
        private Button ContentHeightAddBtn;
        private Label label24;
        private Label label25;
        private Label label23;
        private Label label10;
        private CheckBox checkBox3;
    }
}