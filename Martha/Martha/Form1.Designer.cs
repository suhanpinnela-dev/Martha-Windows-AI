namespace Martha
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gmailstopbutton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GmailReaderBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.total_emails = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.Readtxt = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MediaStopBtn = new System.Windows.Forms.Button();
            this.Full_Screen = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Add_Music = new System.Windows.Forms.Button();
            this.FastRewindBtn = new System.Windows.Forms.Button();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.MediaPauseBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.FastForwardBtn = new System.Windows.Forms.Button();
            this.Unmute_Volume = new System.Windows.Forms.Button();
            this.PlayList = new System.Windows.Forms.ListBox();
            this.Media_Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.Mute_Volume = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PronounceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PlayBack_Timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Media_Player)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(176, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 517);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.gmailstopbutton);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.GmailReaderBtn);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.total_emails);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Email Reader";
            // 
            // gmailstopbutton
            // 
            this.gmailstopbutton.Location = new System.Drawing.Point(271, 248);
            this.gmailstopbutton.Name = "gmailstopbutton";
            this.gmailstopbutton.Size = new System.Drawing.Size(75, 23);
            this.gmailstopbutton.TabIndex = 16;
            this.gmailstopbutton.Text = "Stop";
            this.gmailstopbutton.UseVisualStyleBackColor = true;
            this.gmailstopbutton.Click += new System.EventHandler(this.gmailstopbutton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(404, 209);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(171, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Username:";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // GmailReaderBtn
            // 
            this.GmailReaderBtn.Location = new System.Drawing.Point(174, 248);
            this.GmailReaderBtn.Name = "GmailReaderBtn";
            this.GmailReaderBtn.Size = new System.Drawing.Size(75, 23);
            this.GmailReaderBtn.TabIndex = 12;
            this.GmailReaderBtn.Text = "Start";
            this.GmailReaderBtn.UseVisualStyleBackColor = true;
            this.GmailReaderBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 10;
            // 
            // total_emails
            // 
            this.total_emails.AutoSize = true;
            this.total_emails.Location = new System.Drawing.Point(244, 110);
            this.total_emails.Name = "total_emails";
            this.total_emails.Size = new System.Drawing.Size(13, 13);
            this.total_emails.TabIndex = 9;
            this.total_emails.Text = "0";
            this.total_emails.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total Emails:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.OpenBtn);
            this.tabPage2.Controls.Add(this.StopBtn);
            this.tabPage2.Controls.Add(this.PauseBtn);
            this.tabPage2.Controls.Add(this.ReadBtn);
            this.tabPage2.Controls.Add(this.Readtxt);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(697, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Text Reader";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(262, 439);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 4;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(181, 439);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 3;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.Location = new System.Drawing.Point(100, 439);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(75, 23);
            this.PauseBtn.TabIndex = 2;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(19, 439);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(75, 23);
            this.ReadBtn.TabIndex = 1;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // Readtxt
            // 
            this.Readtxt.BackColor = System.Drawing.Color.Black;
            this.Readtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Readtxt.Location = new System.Drawing.Point(19, 20);
            this.Readtxt.Name = "Readtxt";
            this.Readtxt.Size = new System.Drawing.Size(663, 404);
            this.Readtxt.TabIndex = 0;
            this.Readtxt.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.MediaStopBtn);
            this.tabPage3.Controls.Add(this.Full_Screen);
            this.tabPage3.Controls.Add(this.trackBar1);
            this.tabPage3.Controls.Add(this.Add_Music);
            this.tabPage3.Controls.Add(this.FastRewindBtn);
            this.tabPage3.Controls.Add(this.PreviousBtn);
            this.tabPage3.Controls.Add(this.PlayBtn);
            this.tabPage3.Controls.Add(this.MediaPauseBtn);
            this.tabPage3.Controls.Add(this.NextBtn);
            this.tabPage3.Controls.Add(this.FastForwardBtn);
            this.tabPage3.Controls.Add(this.Unmute_Volume);
            this.tabPage3.Controls.Add(this.PlayList);
            this.tabPage3.Controls.Add(this.Media_Player);
            this.tabPage3.Controls.Add(this.Mute_Volume);
            this.tabPage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(697, 491);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Media Player";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // MediaStopBtn
            // 
            this.MediaStopBtn.BackgroundImage = global::Martha.Properties.Resources.stop;
            this.MediaStopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MediaStopBtn.FlatAppearance.BorderSize = 0;
            this.MediaStopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediaStopBtn.Location = new System.Drawing.Point(294, 331);
            this.MediaStopBtn.Name = "MediaStopBtn";
            this.MediaStopBtn.Size = new System.Drawing.Size(36, 32);
            this.MediaStopBtn.TabIndex = 16;
            this.MediaStopBtn.UseVisualStyleBackColor = true;
            this.MediaStopBtn.Click += new System.EventHandler(this.MediaStopBtn_Click);
            // 
            // Full_Screen
            // 
            this.Full_Screen.BackgroundImage = global::Martha.Properties.Resources.full_screen;
            this.Full_Screen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Full_Screen.FlatAppearance.BorderSize = 0;
            this.Full_Screen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Full_Screen.Location = new System.Drawing.Point(638, 333);
            this.Full_Screen.Name = "Full_Screen";
            this.Full_Screen.Size = new System.Drawing.Size(36, 32);
            this.Full_Screen.TabIndex = 15;
            this.Full_Screen.UseVisualStyleBackColor = true;
            this.Full_Screen.Click += new System.EventHandler(this.Full_Screen_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(494, 331);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Add_Music
            // 
            this.Add_Music.BackgroundImage = global::Martha.Properties.Resources.play_list_button;
            this.Add_Music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add_Music.FlatAppearance.BorderSize = 0;
            this.Add_Music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Music.Location = new System.Drawing.Point(116, 329);
            this.Add_Music.Name = "Add_Music";
            this.Add_Music.Size = new System.Drawing.Size(36, 32);
            this.Add_Music.TabIndex = 13;
            this.Add_Music.Text = ".";
            this.Add_Music.UseVisualStyleBackColor = true;
            this.Add_Music.Click += new System.EventHandler(this.Add_Music_Click);
            // 
            // FastRewindBtn
            // 
            this.FastRewindBtn.BackgroundImage = global::Martha.Properties.Resources.download;
            this.FastRewindBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FastRewindBtn.FlatAppearance.BorderSize = 0;
            this.FastRewindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FastRewindBtn.Location = new System.Drawing.Point(172, 330);
            this.FastRewindBtn.Name = "FastRewindBtn";
            this.FastRewindBtn.Size = new System.Drawing.Size(36, 32);
            this.FastRewindBtn.TabIndex = 12;
            this.FastRewindBtn.UseVisualStyleBackColor = true;
            this.FastRewindBtn.Click += new System.EventHandler(this.FastRewindBtn_Click);
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.BackgroundImage = global::Martha.Properties.Resources.previous;
            this.PreviousBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PreviousBtn.FlatAppearance.BorderSize = 0;
            this.PreviousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousBtn.Location = new System.Drawing.Point(214, 330);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(36, 32);
            this.PreviousBtn.TabIndex = 11;
            this.PreviousBtn.UseVisualStyleBackColor = true;
            this.PreviousBtn.Click += new System.EventHandler(this.button10_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackgroundImage = global::Martha.Properties.Resources.play_button1;
            this.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayBtn.FlatAppearance.BorderSize = 0;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Location = new System.Drawing.Point(256, 333);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(32, 32);
            this.PlayBtn.TabIndex = 10;
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // MediaPauseBtn
            // 
            this.MediaPauseBtn.BackgroundImage = global::Martha.Properties.Resources.pause;
            this.MediaPauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MediaPauseBtn.FlatAppearance.BorderSize = 0;
            this.MediaPauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediaPauseBtn.Location = new System.Drawing.Point(256, 332);
            this.MediaPauseBtn.Name = "MediaPauseBtn";
            this.MediaPauseBtn.Size = new System.Drawing.Size(37, 32);
            this.MediaPauseBtn.TabIndex = 9;
            this.MediaPauseBtn.UseVisualStyleBackColor = true;
            this.MediaPauseBtn.Click += new System.EventHandler(this.MediaPauseBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.BackgroundImage = global::Martha.Properties.Resources.next1;
            this.NextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NextBtn.FlatAppearance.BorderSize = 0;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.Location = new System.Drawing.Point(336, 332);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(31, 32);
            this.NextBtn.TabIndex = 8;
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // FastForwardBtn
            // 
            this.FastForwardBtn.BackgroundImage = global::Martha.Properties.Resources.fast_forward;
            this.FastForwardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FastForwardBtn.FlatAppearance.BorderSize = 0;
            this.FastForwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FastForwardBtn.Location = new System.Drawing.Point(373, 331);
            this.FastForwardBtn.Name = "FastForwardBtn";
            this.FastForwardBtn.Size = new System.Drawing.Size(29, 32);
            this.FastForwardBtn.TabIndex = 7;
            this.FastForwardBtn.UseVisualStyleBackColor = true;
            this.FastForwardBtn.Click += new System.EventHandler(this.FastForwardBtn_Click);
            // 
            // Unmute_Volume
            // 
            this.Unmute_Volume.BackgroundImage = global::Martha.Properties.Resources.speaker;
            this.Unmute_Volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Unmute_Volume.FlatAppearance.BorderSize = 0;
            this.Unmute_Volume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Unmute_Volume.Location = new System.Drawing.Point(430, 331);
            this.Unmute_Volume.Name = "Unmute_Volume";
            this.Unmute_Volume.Size = new System.Drawing.Size(31, 30);
            this.Unmute_Volume.TabIndex = 3;
            this.Unmute_Volume.UseVisualStyleBackColor = true;
            this.Unmute_Volume.Click += new System.EventHandler(this.button2_Click);
            // 
            // PlayList
            // 
            this.PlayList.BackColor = System.Drawing.Color.Black;
            this.PlayList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PlayList.FormattingEnabled = true;
            this.PlayList.Location = new System.Drawing.Point(0, 393);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(697, 95);
            this.PlayList.TabIndex = 2;
            this.PlayList.SelectedIndexChanged += new System.EventHandler(this.PlayList_SelectedIndexChanged);
            // 
            // Media_Player
            // 
            this.Media_Player.Enabled = true;
            this.Media_Player.Location = new System.Drawing.Point(0, 0);
            this.Media_Player.Name = "Media_Player";
            this.Media_Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media_Player.OcxState")));
            this.Media_Player.Size = new System.Drawing.Size(697, 325);
            this.Media_Player.TabIndex = 0;
            // 
            // Mute_Volume
            // 
            this.Mute_Volume.BackgroundImage = global::Martha.Properties.Resources.mute_speaker1;
            this.Mute_Volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Mute_Volume.FlatAppearance.BorderSize = 0;
            this.Mute_Volume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mute_Volume.Location = new System.Drawing.Point(430, 332);
            this.Mute_Volume.Name = "Mute_Volume";
            this.Mute_Volume.Size = new System.Drawing.Size(32, 27);
            this.Mute_Volume.TabIndex = 6;
            this.Mute_Volume.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.PronounceBtn);
            this.tabPage4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(697, 491);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pronouncer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Text Here:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 53);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(554, 124);
            this.textBox3.TabIndex = 3;
            // 
            // PronounceBtn
            // 
            this.PronounceBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PronounceBtn.Location = new System.Drawing.Point(284, 197);
            this.PronounceBtn.Name = "PronounceBtn";
            this.PronounceBtn.Size = new System.Drawing.Size(139, 23);
            this.PronounceBtn.TabIndex = 4;
            this.PronounceBtn.Text = "Pronounce";
            this.PronounceBtn.UseVisualStyleBackColor = true;
            this.PronounceBtn.Click += new System.EventHandler(this.PronounceBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(-2, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text Reader";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(-2, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email Reader";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(-2, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Media Player";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PlayBack_Timer
            // 
            this.PlayBack_Timer.Tick += new System.EventHandler(this.PlayBack_Timer_Tick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Martha.Properties.Resources.jarvis_png;
            this.button1.Location = new System.Drawing.Point(32, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 107);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(-2, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 29);
            this.label11.TabIndex = 5;
            this.label11.Text = "Pronouncer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(883, 522);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Media_Player)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox PlayList;
        private AxWMPLib.AxWindowsMediaPlayer Media_Player;
        private System.Windows.Forms.Timer PlayBack_Timer;
        private System.Windows.Forms.Button Unmute_Volume;
        private System.Windows.Forms.Button FastRewindBtn;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button MediaPauseBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button FastForwardBtn;
        private System.Windows.Forms.Button Mute_Volume;
        private System.Windows.Forms.Button Add_Music;
        private System.Windows.Forms.Button Full_Screen;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button MediaStopBtn;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.RichTextBox Readtxt;
        private System.Windows.Forms.Label total_emails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GmailReaderBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button PronounceBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button gmailstopbutton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
    }
}

