using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech;
using System.Speech.Recognition;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Net;
using System.Xml;
using System.Xml.Linq;
namespace Martha
{
    public partial class Form1 : Form
    {


        SpeechRecognitionEngine Speechreco = new SpeechRecognitionEngine();
        SpeechSynthesizer martha = new SpeechSynthesizer();
        DateTime dateTime = DateTime.UtcNow.Date;
        string[] files, paths;
        public static List<string> MsgList = new List<string>();
        public static List<string> MsgLink = new List<string>();
        public static String QEvent;
        int Emailnum = 0;
        string username;
        string password;
        public Form1()
        {
            Speechreco.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Speechreco_SpeechRecognized);
            LoadGrammer();
            Speechreco.SetInputToDefaultAudioDevice();
            Speechreco.RecognizeAsync(RecognizeMode.Multiple);
            InitializeComponent();
        }
        private void LoadGrammer()
        {

            Choices texts = new Choices();
            string[] lines = File.ReadAllLines(Environment.CurrentDirectory + "\\commands.txt");
            texts.Add(lines);
            Grammar Wordlist = new Grammar(new GrammarBuilder(texts));
            Speechreco.LoadGrammar(Wordlist);

        }

       
        private void Speechreco_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            string speech = e.Result.Text;
            try
            {
                switch (speech)
                {
                    ///basic commands
                    case "hello":
                    case "hello martha":
                    case "martha hello":
                        martha.Speak("hello sir");
                        break;
                    case "how are you":
                    case "martha how are you":
                    case "how are you martha":
                        martha.Speak("Iam fine sir");
                        break;
                    case "what is your name":
                        martha.Speak("my name is martha iam an ai");
                        break;
                    case "what is your gender":
                        martha.Speak("i dont have a gender but my voice seems to be male");
                        break;
                    case "are you there":
                    case "martha are you there":
                    case "are you there martha":
                        martha.Speak("yes sir always ready");
                        break;
                    case "exit":
                    case "sleep":
                    case "goodbye":
                    case "goodbye martha":
                    case "martha goodbye":
                    case "martha bye":
                        martha.Speak("good bye sir have a nice day");
                        Application.Exit();
                        break;

                    ///opening commands
                    case "open google":
                    case "martha open google":
                    case "open google martha":
                        martha.Speak("opening google");
                        martha.Speak("loading");
                        Process.Start("chrome.exe", "http://www.google.com");
                        break;
                    case "icognito":
                    case "martha turn icognito":
                    case "turn icognito":
                        SendKeys.Send("^+n");
                        break;
                    case "open youtube":
                    case "martha open youtube":
                    case "open youtube martha":
                        martha.Speak("opening youtube");
                        martha.Speak("loading sir");
                        Process.Start("chrome.exe", "http://www.youtube.com");
                        break;

                    case "open facebook":
                    case "martha open facebook":
                    case "open facebook martha":
                        martha.Speak("opening facebook");
                        martha.Speak("loading");
                        Process.Start("chrome.exe", "http://www.facebook.com");
                        break;
                    case "open instagram":
                    case "martha open instagram":
                    case "open instagram martha":
                        martha.Speak("opening instagram");
                        martha.Speak("loading sir");
                        Process.Start("chrome.exe", "http://www.instagram.com");
                        break;
                    case "open whatsapp":
                    case "martha open whatsapp":
                    case "open  whatsapp martha":
                        martha.Speak("opening whatsapp");
                        martha.Speak("loading");
                        Process.Start("chrome.exe", "http://www.whatsapp.com");
                        break;
                    case "open amzon":
                    case "martha open amazon":
                        martha.Speak("opening amazon");
                        martha.Speak("loading");
                        martha.Speak("happy shoppoing sir");
                        Process.Start("chrome.exe", "http://www.amazon.in");
                        break;
                    case "open flipkart":
                    case "martha open flipkart":
                        martha.Speak("opening flipkart");
                        martha.Speak("loading");
                        martha.Speak("happy shopping sir");
                        Process.Start("chrome.exe", "http://www.flipkart.com");
                        break;
                    case "open notepad":
                    case "martha open notepad":
                        martha.Speak("opening notepad");
                        Process.Start("notepad.exe");
                        break;
                    case "open wordpad":
                    case "martha open wordpad":
                        martha.Speak("opening wordpad");
                        Process.Start("wordpad.exe");
                        break;
                    case "open cmd":
                    case "martha open commandpromt":
                        martha.Speak("opening commandpromt");
                        Process.Start("cmd.exe");
                        break;


                    ///date and time
                    case "what time is it":
                    case "martha what is the time":
                        martha.Speak(DateTime.Now.ToString("h:mm:tt"));
                        break;
                    case "what is the date":
                    case "martha what is the date":
                        martha.Speak(DateTime.Now.ToString("MM/dd/yyyy"));
                        break;



                    ///battery status


                    ///cricket updates
                    case "get cricket updates":
                        martha.Speak("getting cricket updates");
                        Process.Start("chrome.exe", "http://www.cricbuzz.com");
                        break;

                    ///Media player commands
                    case "open playlist":
                        martha.Speak("opening playlist");
                        martha.Speak("sir please select songs from your drives");
                        Add_Music.PerformClick();
                        break;
                    case "play songs":
                        martha.Speak("playing songs");
                        PlayBtn.PerformClick();
                        break;
                    case "pause song":
                        martha.Speak("pausing the song");
                        PlayBtn.PerformClick();
                        break;
                    case "resume song":
                        martha.Speak("resuimg the song");
                        PlayBtn.PerformClick();
                        break;
                    case "stop song":
                        martha.Speak("stoping the song");
                        MediaStopBtn.PerformClick();
                        break;
                    case "play next song":
                        martha.Speak("playing next song");
                        NextBtn.PerformClick();
                        break;
                    case "play previous song":
                        martha.Speak("playing previous song");
                        PreviousBtn.PerformClick();
                        break;
                    case "forward song":
                        martha.Speak("forwarding the song");
                        FastForwardBtn.PerformClick();
                        break;
                    case "rewind song":
                        martha.Speak("rewinding the song");
                        FastRewindBtn.PerformClick();
                        break;
                    case "go fullscreen":
                        martha.Speak("going full screen");
                        Full_Screen.PerformClick();
                        break;

                    ///text reader
                    case "open text files":
                        OpenBtn.PerformClick();
                        break;
                    case "read":
                        ReadBtn.PerformClick();
                        break;
                    case "pause":
                        PauseBtn.PerformClick();
                        break;
                    case "resume":
                        PauseBtn.PerformClick();
                        break;
                    case "stop":
                        martha.SpeakAsyncCancelAll();
                        break;

                    ///Gmail Reader
                    case "get emails":
                    case "get all emails":
                    case "get all inbox emails":
                        GmailReaderBtn.PerformClick();
                        AllEmails();
                        break;
                    case "check for new emails":
                        username = textBox1.Text;
                        password = textBox2.Text;
                        QEvent = "Checkfornewemails";
                        martha.SpeakAsyncCancelAll();
                        Emailnum = 0;
                        CheckEmails();
                        break;
                    case "read email":
                        GmailReaderBtn.PerformClick();
                        martha.SpeakAsyncCancelAll();
                        try
                        {
                            martha.SpeakAsync(MsgList[Emailnum]);
                        }
                        catch
                        {
                            martha.SpeakAsync("there are no emails");
                        }
                        break;
                    case "next email":
                        GmailReaderBtn.PerformClick();
                        martha.SpeakAsyncCancelAll();
                        try
                        {
                            Emailnum += 1;
                            martha.SpeakAsync(MsgList[Emailnum]);
                        }
                        catch
                        {
                            Emailnum -= 1;
                            martha.SpeakAsync("there are no further emails");
                        }
                        break;
                    case "previous email":
                        GmailReaderBtn.PerformClick();
                        martha.SpeakAsyncCancelAll();
                        try
                        {
                            Emailnum -= 1;
                            martha.SpeakAsync(MsgList[Emailnum]);
                        }
                        catch
                        {
                            Emailnum += 1;
                            martha.SpeakAsync("there are no previous emails");
                        }
                        break;
                    case "stop reading gmails":
                        {
                            martha.SpeakAsyncCancelAll();
                            break;
                        }

                    ///pronounciation
                    case "pronounce":
                        {
                            PronounceBtn.PerformClick();
                            break;
                        }

                }
            }
            catch(Exception)
            {
                MessageBox.Show("MessageBox:martha is in pause state trun it to speaking state");
            }
        }      
        private void Form1_Load(object sender, EventArgs e)
        {
            Media_Player.uiMode = "none";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Media_Player.settings.volume == 100)
            {
                Media_Player.settings.volume = 0;
                Unmute_Volume.BackgroundImage = Properties.Resources.mute_speaker;
            }
            else
            {
                Media_Player.settings.volume = 100;
                Unmute_Volume.BackgroundImage = Properties.Resources.speaker;
            }

        }
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (Media_Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (PlayList.SelectedIndex > 0)
                {
                    Media_Player.Ctlcontrols.previous();
                    PlayList.SelectedIndex -= 1;
                    PlayList.Update();
                }
                else
                {
                    PlayList.SelectedIndex = 0;
                    PlayList.Update();
                }
            }

        }
        private void PlayBtn_Click(object sender, EventArgs e)
        {

            if (Media_Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                PlayBtn.BackgroundImage = Properties.Resources.pause;
                Media_Player.Ctlcontrols.pause();
            }
            else if (Media_Player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                PlayBtn.BackgroundImage = Properties.Resources.play_button;
                Media_Player.Ctlcontrols.play();
            }
            else if (PlayList.SelectedIndex > 0)
            {
                Media_Player.URL = paths[PlayList.SelectedIndex];
                Media_Player.Ctlcontrols.play();
            }
            else
            {
                try
                {
                    PlayList.SelectedIndex = 0;
                    Media_Player.Ctlcontrols.play();
                }
                catch(Exception)
                {
                    martha.Speak("sir playlist is empty cannot play songs please select songs to play");
                    MessageBox.Show("MessageBox: playlist is empty please select songs from  your drives");
                }
            }
        }
        private void MediaPauseBtn_Click(object sender, EventArgs e)
        {

        }

        private void MediaStopBtn_Click(object sender, EventArgs e)
        {
            Media_Player.Ctlcontrols.stop();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {

            if (Media_Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (PlayList.SelectedIndex < (PlayList.Items.Count - 1))
                {
                    Media_Player.Ctlcontrols.next();
                    PlayList.SelectedIndex += 1;
                    PlayList.Update();
                }
                else
                {
                    PlayList.SelectedIndex = 0;
                    PlayList.Update();
                }
            }

        }

        private void FastForwardBtn_Click(object sender, EventArgs e)
        {
            Media_Player.Ctlcontrols.fastForward();
        }

        private void FastRewindBtn_Click(object sender, EventArgs e)
        {
            Media_Player.Ctlcontrols.fastReverse();
        }

        private void Full_Screen_Click(object sender, EventArgs e)
        {

            if (Media_Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Media_Player.fullScreen = true;
            }
            else
            {
                Media_Player.fullScreen = false;
            }

        }
        private void PlayBack_Timer_Tick(object sender, EventArgs e)
        {

            PlayBack_Timer.Start();
            if (PlayList.SelectedIndex < files.Length - 1)
            {
                PlayList.SelectedIndex++;
                PlayBack_Timer.Enabled = false;
            }
            else
            {
                PlayList.SelectedIndex = 0;
                PlayBack_Timer.Enabled = false;
            }
            PlayBack_Timer.Stop();
        }

        private void PlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Media_Player.URL = paths[PlayList.SelectedIndex];
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Media_Player.settings.volume = trackBar1.Value;
        }
        private void Add_Music_Click(object sender, EventArgs e)
        {

            string username = System.Environment.UserName;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"c:\Users\" + username + "\\D:\\music";
            ofd.Filter = "(mp3,wav,mp4,mov,mpg,avi,3gp,flv)|*.mp3;*.wav;*.mp4;*.3gp;*.avi;*.mov;*.flv;*.wmv;*.mpg|all files|*.*";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    PlayList.Items.Add(files[i]);
                }
            }

        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            StopBtn.PerformClick();
            PlayBtn.Enabled = false;
            PauseBtn.Enabled = true;
            martha.SpeakAsync(Readtxt.Text);

        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            if(martha.State == SynthesizerState.Speaking)
            {
                martha.Pause();
                PauseBtn.Text = "resume";
            }
            else
            {
                if(martha.State == SynthesizerState.Paused)
                {
                    martha.Resume();
                    PauseBtn.Text = "pause";
                }
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            if(martha.State == SynthesizerState.Speaking)
            {
                martha.SpeakAsyncCancelAll();
                StopBtn.Text = "stop";
                ReadBtn.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (martha.State == SynthesizerState.Speaking)
            {
                martha.SpeakAsyncCancelAll();
            }
            Readtxt.Clear();
            martha.SpeakAsync(" sir please chose a text file form your derives");
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               try
               {
                   string strfilename = openFileDialog1.FileName;
                   string filetext = File.ReadAllText(strfilename);
                   Readtxt.Text = filetext;
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Error: could not read the file from disk:" + ex.Message);
               }
            }
        }
        public void AllEmails()
        {
            try
            {

                System.Net.WebClient objclient = new System.Net.WebClient();
                string response;
                string title;
                string summary;
                string tagline;
                //creating a new xml document
                XmlDocument doc = new XmlDocument();

                //logging in gmail server to get data
                objclient.Credentials = new System.Net.NetworkCredential(textBox1.Text, textBox2.Text);
                //reading data and converting to string
                response = Encoding.UTF8.GetString(
                    objclient.DownloadData(@"https://mail.google.com/mail/feed/atom"));

                response = response.Replace(
                    @"<feed version=""0.3"" xmlns=""http://purl.org/atom/ns#"">", @"<feed>");

                //loading into an XML so we can get information easily
                doc.LoadXml(response);
                //counting all emails
                string total_mails = doc.SelectSingleNode(@"/feed/fullcount").InnerText;
                total_emails.Text = total_mails;
                martha.SpeakAsync("total number of emails are" + total_mails + "in the mail box");
                //tag line
                tagline = doc.SelectSingleNode("/feed/tagline").InnerText;
                //Email_Tags_Lines.Text = tagline;
                martha.SpeakAsync("sir you have" + tagline);
                //reading the title and the summary for every email
               /* foreach (XmlNode node in doc.SelectNodes(@"/feed/entry"))
                {
                    //reading the email authorfrom atom feed
                    Email_Author.Text = node.SelectSingleNode("author").SelectSingleNode("name").InnerText;
                    martha.SpeakAsync("Email from" + Email_Author.Text.ToString());
                    // reading a title of email
                    title = node.SelectSingleNode("title").InnerText;
                    Message_title.Text = title;
                    martha.Speak("sir,mail is about" + title.ToString());
                    //getting email summary
                    summary = node.SelectSingleNode("summary").InnerText;
                    Message_Summary.Text = summary.ToString();
                    martha.Speak("and the summary is" + summary.ToString());
                }*/
            }
            catch (Exception ex)
            {
                martha.Speak("please login to your gmail account and turn less secure apps to get this done");
                MessageBox.Show("login to youir gmail account and turn on less secure apps" + ex.Message);
                System.Diagnostics.Process.Start("https://support.google.com/accounts/answer/6010255?h1=en");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            username = textBox1.Text;
            password = textBox2.Text;
        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
        private void PronounceBtn_Click(object sender, EventArgs e)
        {
            martha.SpeakAsync(textBox3.Text);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked )
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void gmailstopbutton_Click(object sender, EventArgs e)
        {
            if (martha.State == SynthesizerState.Speaking)
            {
                martha.SpeakAsyncCancelAll();
            }
        }

        public void CheckEmails()
        {
            string GmailAtomUrl = "https://mail.google.com/mail/feed/atom";
            XmlResolver xmlResolver = new XmlUrlResolver();
            xmlResolver.Credentials = new NetworkCredential(username,password);
            XmlTextReader xmlReader = new XmlTextReader(GmailAtomUrl);
            xmlReader.XmlResolver = xmlResolver;
            try
            {
                XNamespace ns = XNamespace.Get("http://purl.org/atom/ns#");
                XDocument xmlfeed = XDocument.Load(xmlReader);

                var emailItems = from item in xmlfeed.Descendants(ns + "entry")
                                 select new
                                 {
                                     Author = item.Element(ns + "author").Element(ns + "name").Value,
                                     Title = item.Element(ns + "title").Value,
                                     Link = item.Element(ns + "link").Attribute("href").Value,
                                     Summary = item.Element(ns + "summary").Value
                                 };
                Form1.MsgList.Clear();
                Form1.MsgLink.Clear();
                foreach (var item in emailItems)
                {
                    if (item.Title == String.Empty)
                    {
                        Form1.MsgList.Add("message from" + item.Author + ",there is no subject and the the summary reads, " + item.Summary);
                        Form1.MsgLink.Add(item.Link);
                    }
                    else
                    { 
                        Form1.MsgList.Add("message from" + item.Author + ",the subject is" + item.Title + "and summary reads" + item.Summary);
                        Form1.MsgLink.Add(item.Link);
                    }
                    
                }
                if (emailItems.Count() > 0)
                {
                    if (emailItems.Count() == 1)
                    {
                        martha.SpeakAsync("you have one new email");
                    }
                    else
                    {
                        martha.SpeakAsync(" you have " + emailItems.Count() + " new emails ");
                    }
                }
                else if (Form1.QEvent == "checkfornewemails" && emailItems.Count() == 0)
                {
                    martha.SpeakAsync("you have no emails");
                    Form1.QEvent = String.Empty;
                }
            }
            catch (Exception ex)
            {
                martha.SpeakAsync("you have submmited invalid login information");
                martha.SpeakAsync("please login to your gmail account and turn on permission to less secure apps" + ex.Message);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
           

        }

        private void newsplaybtn_Click(object sender, EventArgs e)
        { 
            
        }

        private void Newsstopbtn_Click(object sender, EventArgs e)
        {
            if(martha.State== SynthesizerState.Paused)
            {
                martha.Resume();
            }
            martha.SpeakAsyncCancelAll();
        }

        private void newspausebtn_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void getbingnewsbtn_Click_1(object sender, EventArgs e)
        {
            
        }

    }
}