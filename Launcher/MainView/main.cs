using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.ComponentModel;
using System.IO.Compression;


//                    .____                                    .__                                   //
//                    |    |    _____    __ __   ____    ____  |  |__    ____ _______                //
//                    |    |    \__  \  |  |  \ /    \ _/ ___\ |  |  \ _/ __ \\_  __ \               //
//                    |    |___  / __ \_|  |  /|   |  \\  \___ |   Y  \\  ___/ |  | \/               //
//                    |_______ \(____  /|____/ |___|  / \___  >|___|  / \___  >|__|                  //
//                            \/     \/             \/      \/      \/      \/                       //
//                                                                                                   //


namespace Launcher
{






    public partial class main : Form   //MetroFramework.Forms.MetroForm

    {
        public const int WM_NCLBUTTONDOWN = 0xA1;  // not sure
        public const int HT_CAPTION = 0x2;


        /***********************************************  Wave File shit ****************************************************/




        public Button _Play { get { return play; } }
        public Button _button1 { get { return play; } }
        public Button _button2 { get { return play; } }
        public Button _ToPanelButton { get { return play; } }
        public Button _button11 { get { return play; } }
        public Button _button12 { get { return play; } }
        public Button _CloseButton { get { return play; } }
        public Button _MinimizeButton { get { return play; } }
        public Button _button3 { get { return play; } }
        public Button _button4 { get { return play; } }
        public Button _button5 { get { return play; } }
        public Button _button6 { get { return play; } }
        public Button _button7 { get { return play; } }
        public Button _button8 { get { return play; } }
        public Button _button9 { get { return play; } }
        public Button _button10 { get { return play; } }
        public Button _ToMainButton { get { return play; } }
        public Button _button13 { get { return play; } }
        
        //                                                                                                                                  //
        //                                                                                                                                  //
        //            _________ __                 __                 ____   ____            .__      ___.   .__                            //
        //           /   _____//  |______ ________/  |_ __ ________   \   \ /   /____ _______|__|____ \_ |__ |  |   ____   ______           //
        //           \_____  \\   __\__  \\_  __ \   __\  |  \____ \   \   Y   /\__  \\_  __ \  \__  \ | __ \|  | _/ __ \ /  ___/           //
        //           /        \|  |  / __ \|  | \/|  | |  |  /  |_> >   \     /  / __ \|  | \/  |/ __ \| \_\ \  |_\  ___/ \___ \            //
        //          /_______  /|__| (____  /__|   |__| |____/|   __/     \___/  (____  /__|  |__(____  /___  /____/\___  >____  >           //
        //                  \/           \/                  |__|                    \/              \/    \/          \/     \/            //
        //                                                                                                                                  //
        //                                                                                                                                  //


        //                                                                                                                                  //
        //                                                                                                                                  //
        //            _________ __                 __                 ____   ____            .__      ___.   .__                            //
        //           /   _____//  |______ ________/  |_ __ ________   \   \ /   /____ _______|__|____ \_ |__ |  |   ____   ______           //
        //           \_____  \\   __\__  \\_  __ \   __\  |  \____ \   \   Y   /\__  \\_  __ \  \__  \ | __ \|  | _/ __ \ /  ___/           //
        //           /        \|  |  / __ \|  | \/|  | |  |  /  |_> >   \     /  / __ \|  | \/  |/ __ \| \_\ \  |_\  ___/ \___ \            //
        //          /_______  /|__| (____  /__|   |__| |____/|   __/     \___/  (____  /__|  |__(____  /___  /____/\___  >____  >           //
        //                  \/           \/                  |__|                    \/              \/    \/          \/     \/            //
        //                                                                                                                                  //
        //                                                                                                                                  //


        //                                                                                                                                  //
        //                                                                                                                                  //
        //            _________ __                 __                 ____   ____            .__      ___.   .__                            //
        //           /   _____//  |______ ________/  |_ __ ________   \   \ /   /____ _______|__|____ \_ |__ |  |   ____   ______           //
        //           \_____  \\   __\__  \\_  __ \   __\  |  \____ \   \   Y   /\__  \\_  __ \  \__  \ | __ \|  | _/ __ \ /  ___/           //
        //           /        \|  |  / __ \|  | \/|  | |  |  /  |_> >   \     /  / __ \|  | \/  |/ __ \| \_\ \  |_\  ___/ \___ \            //
        //          /_______  /|__| (____  /__|   |__| |____/|   __/     \___/  (____  /__|  |__(____  /___  /____/\___  >____  >           //
        //                  \/           \/                  |__|                    \/              \/    \/          \/     \/            //
        //                                                                                                                                  //
        //                                                                                                                                  //


        private StateHandler myState = new StateHandler();
        private DateTime startTime = DateTime.Now;
        SoundPlayer startupsong = new SoundPlayer("Resources/done.wav");
        SoundPlayer completesong = new SoundPlayer("Resources/start.wav");
        SoundPlayer patsoft = new SoundPlayer("Resources/patsoft.wav");
        SoundPlayer patwarnings = new SoundPlayer("Resources/patwarning.wav");
        bool soundenabled = true;
        string latestpath = "Game/Knowts.txt";
        string buildpath = "Game/Build.txt";
        public string manifestpath = "Game/Manifest.txt";
        public string ziplinkspath = "Game/ZipsManifest.txt";
        public bool LatestPathExists = (System.IO.File.Exists("Game/Knowts.txt"));
        public string KnowtsOnline = "https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/Knowts.txt";
        public string BuildOnline = "https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/Build.txt";
        public bool cacheisdone = false;
        public bool gameisunzipped = false;
        public string zippath = "Game/WoA_0055.zip";
        public string gamepath = "Game/Knowts.txt";
        public string latestlink = String.Empty;
        public string latestbuild = String.Empty;
        public string onlinelatesthtml = String.Empty;
        public string gdirectory = "Game/";
        public string cdirectory = "Game/cache/";
        public string dir = String.Empty;
        public string[] dirs = new string[] { "" };
        public int currentziplink = 0;
        public string startPath = "Game/";
        public string zipPath = "Game/cache/";
        public string extractPath = "Game/";
        public string VersionText = "Build" + " " + "WoA_1902_0058";


//                                                                                                                          //
//          _________                                   ___________                     __   .__                            //
//          \_   ___ \ __ _________  _________________  \__    ___/___________    ____ |  | _|__| ____    ____              //
//          /    \  \/|  |  \_  __ \/  ___/  _ \_  __ \   |    |  \_  __ \__  \ _/ ___\|  |/ /  |/    \  / ___\             //
//          \     \___|  |  /|  | \/\___ (  <_> )  | \/   |    |   |  | \// __ \\  \___|    <|  |   |  \/ /_/  >            //
//           \______  /____/ |__|  /____  >____/|__|      |____|   |__|  (____  /\___  >__|_ \__|___|  /\___  /             //
//                  \/                  \/                                    \/     \/     \/       \//_____/              //
//                                                                                                                          //
//                                                                                                                          //            



        //This is a replacement for Cursor.Position in WinForms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }


        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;

        }




//                                                                                                          //
//                                                                                                          //
//              .___       .__  __  .__       .__  .__                __  .__                               //
//              |   | ____ |__|/  |_|__|____  |  | |__|____________ _/  |_|__| ____   ____                  //
//              |   |/    \|  \   __\  \__  \ |  | |  \___   /\__  \\   __\  |/  _ \ /    \                 //
//              |   |   |  \  ||  | |  |/ __ \|  |_|  |/    /  / __ \|  | |  (  <_> )   |  \                //
//              |___|___|  /__||__| |__(____  /____/__/_____ \(____  /__| |__|\____/|___|  /                //
//                       \/                 \/              \/     \/                    \/                 //
//                                                                                                          //
//                                                                                                          //
        /*******************************
            this is our main startup function for the program
        /********************************/
        public main()
        {
            InitializeComponent();
            //myState.changeButtonState(LauncherState.Idle, this);
            this.Shown += new System.EventHandler(this.AfterLoading);    // this is wher we fire BeginPlay
            Console.WriteLine("Initialization");
            m_aeroEnabled = false;
            this.FormBorderStyle = FormBorderStyle.None;
            bool VolumeOn = (bool)Properties.Settings.Default["VolumeOn"];
            this.FormBorderStyle = FormBorderStyle.None;
            if (WindowState == FormWindowState.Minimized)
            {
                ShowIcon = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
                Console.WriteLine("Window State Minimized?");
            }
            if (VolumeOn == true)
            {
                soundenabled = true;
                System.Media.SoundPlayer sp = (startupsong);
                sp.Play();
                button2.BackgroundImage = Image.FromFile("Resources/speakerON.png");
            }
            else
            {
                soundenabled = false;
                button2.BackgroundImage = Image.FromFile("Resources/speakerOFF.png");
            }
            if (WindowState == FormWindowState.Minimized)
            {
                ShowIcon = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
                Console.WriteLine("Window State Minimized?");
            }
            if (VolumeOn == true)
            {
                soundenabled = true;
                System.Media.SoundPlayer sp = (startupsong);
                sp.Play();
                button2.BackgroundImage = Image.FromFile("Resources/speakerON.png");
            }
            else
            {
                soundenabled = false;
                button2.BackgroundImage = Image.FromFile("Resources/speakerOFF.png");
            }
        }
        private void notifyIcon1_LoadCompleted(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
            Console.WriteLine("Showing Icon In Taskbar");
        }







//                                                                                                          //
//                  __________               __            .____                     .___                   //
//                  \______   \____  _______/  |_          |    |    _________     __| _/                   //
//                   |     ___/  _ \/  ___/\   __\  ______ |    |   /  _ \__  \   / __ |                    //
//                   |    |  (  <_> )___ \  |  |   /_____/ |    |__(  <_> ) __ \_/ /_/ |                    //
//                   |____|   \____/____  > |__|           |_______ \____(____  /\____ |                    //
//                                      \/                         \/         \/      \/                    //
//                                                                                                          //


        private void AfterLoading(object sender, EventArgs e)
        {
            Console.WriteLine("Post Load Completed");
            // serlf check
            var sProcessName = ("Winds of Almerra");
            System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName(sProcessName);
            if (proc.Length > 1)
            {
                Console.WriteLine("Multiple instances detected");
                Application.Exit();
            }

            //create the folders for shit
            Directory.CreateDirectory(Path.Combine("Game"));
            Directory.CreateDirectory(Path.Combine("Game/cache"));
            string[] lines = {
                            "Almerra Launcher Readme",
                            "",
                            "wuh, dis rEaDmE SuX lul gIt guuD"
                            };

            //create the readme file for no real reason 
            string path = "Game/ReadMe.txt";
            var onlinelatesthtml = KnowtsOnline;
            if (!System.IO.File.Exists(path))
            {
                System.IO.File.Create(path);
                Console.WriteLine("ReadMe File Created");

            }
            else if (System.IO.File.Exists(path))
            {
                Console.WriteLine("ReadMe File Exists");
                File.WriteAllLines("Game/ReadMe.txt", lines);

            }
            // ... Say stuff within teh readme.





//*******************************/*******************************/*******************************/*******************************//
//              Startup items for the launcher as a program --                                                                   //
//                                                                                                                               //
//              here we'll add all the startup shit for downaloading new files and everything                                    //
//              if then else, all that shit -- but we'll also addin searches for engine.ini files for the options menu here      //
//                                                                                                                               //
//********************************/*******************************/*******************************/******************************//


//                                                                                                      //
//                   ____ ___            .___       __  .__                                             //
//                  |    |   \______   __| _/____ _/  |_|__| ____    ____                               //
//                  |    |   /\____ \ / __ |\__  \\   __\  |/    \  / ___\                              //
//                  |    |  / |  |_> > /_/ | / __ \|  | |  |   |  \/ /_/  >                             //
//                  |______/  |   __/\____ |(____  /__| |__|___|  /\___  /                              //
//                            |__|        \/     \/             \//_____/                               //
//                                                                                                      //
//                                                                                                      //
            
            // as long as we have a knowts.txt file locally this will alwusa be true

            if (LatestPathExists) 
            {
                //varibles for the reads
                string latestlink = System.IO.File.ReadAllText(latestpath);
                var client = new WebClient();
                var latestonlinelink = client.DownloadString(KnowtsOnline); // the contents of the file that is online isnt called here, just a link reference


                //read the string link from Knowts.txt online to check against local
                WebRequest request = WebRequest.Create(KnowtsOnline);
                WebResponse response = request.GetResponse();
                Stream data = response.GetResponseStream();
                using (StreamReader sr = new StreamReader(data))
                {
                    onlinelatesthtml = sr.ReadToEnd();
                }
                //as of right now the onlinelatesthtml should be filled with the last link on the github within resources/knowts.txt


                if (onlinelatesthtml == latestlink)
                {
                    Console.WriteLine("Knowts is up to date"); // now confirmed, we can read the latest link
                    if (cacheisdone)
                    {
                        Console.WriteLine("Do we have the zip for this");
                        play.Text = ("Unzip");
                        ToPanelButton.Enabled = false;
                    }
                    if (gameisunzipped)
                    {
                        Console.WriteLine("Game is unzipped, starting");
                        play.Text = ("Play Latest");
                        string[] dirs = Directory.GetFiles(gdirectory, "*Tailwind_1501.exe*", SearchOption.TopDirectoryOnly);
                        Console.WriteLine(gdirectory + ", The number of files starting with W is " + dirs.Length);
                        foreach (string dir in dirs)
                        {
                            string letsdothis = dir;
                            Console.WriteLine(dir);
                            if (dir != null)
                            {
                                gameisunzipped = true;
                            }
                        }
                    }

                    else
                    {
                        play.Text = ("Get Zips");
                        //ToPanelButton.Enabled = false;
                    }


                }
                
                else 
                {
                    play.Text = ("Missing");
                    Console.WriteLine("Knowts file not found"); // download new knowts file and re-read
                    ToPanelButton.Enabled = false;
                }



            }
            // this should only happen when no local Knowts.txt file exists
            else
            {
                play.Text = ("Update");
                Console.WriteLine("No Knowts exists...");
                var client = new WebClient();
                var latestonlinelink = client.DownloadString(KnowtsOnline);    // gets the newest link it needs from online
                onlinelatesthtml = KnowtsOnline;
                ToPanelButton.Enabled = false;
            }
               
            // response.Close();
            progressBar1.Visible = false;
            //End of startup loading
        }

        






//                                                                                                           //
//                __________.__                 __________        __    __                                   //
//                \______   \  | _____  ___.__. \______   \__ ___/  |__/  |_  ____   ____                    //
//                 |     ___/  | \__  \<   |  |  |    |  _/  |  \   __\   __\/  _ \ /    \                   //
//                 |    |   |  |__/ __ \\___  |  |    |   \  |  /|  |  |  | (  <_> )   |  \                  //
//                 |____|   |____(____  / ____|  |______  /____/ |__|  |__|  \____/|___|  /                  //
//                                    \/\/              \/                              \/                   //
//                                                                                                           //
//                                                                                                           //

        /*******************************
            play latest build button pressed
        /********************************/

        private void play_Click(object sender, EventArgs e)
        {

            /*      play our last build -- first make sure its even there, if not display the messgae box */
            var gdirectory = "Game/";
            var cdirectory = "Game/cache/";
            if (soundenabled == true)
            {
                System.Media.SoundPlayer sp = (patsoft);
                sp.Play();
            };

            // Teh default function of clicking the Play button -- first we see if there is already a game local to play
            // If NOT then go to catch which gives user a prompt to ignore or download latest
            if (LatestPathExists) // is valid base levelcheck
            {
                if (onlinelatesthtml == latestlink) // if we have the latest version link
                {
                    if(cacheisdone) // if we have downloaded all the files already
                    {
                        if (gameisunzipped) // if we are done unzipping all the files for the game
                        {
                            // WE have teh file! start the gaame and minimize the launcher
                            System.Diagnostics.Process.Start(dir);
                            this.WindowState = FormWindowState.Minimized;
                        }
                    }
                    else // cache not done, so download zips
                    {
                        // need check for which zip is last right here, then update the current ones name
                        string currentzipname = String.Empty;
                        Console.WriteLine("We have latest link.  No local zips, downloading new zip files...");
                        play.Text = "Wait";
                        play.Enabled = false;
                        progressBar1.Visible = true;
                        string[] zipnames = System.IO.File.ReadAllLines(manifestpath); // read all file names from the manifest of names (WoA_1902_0055.zip.001)
                        string[] ziplinks = System.IO.File.ReadAllLines(ziplinkspath); // read all lines of http links from the zipsmanifest for download (link pathing for each .zip.0xx)



///              ____ ___            .___       __           __________.__                              ///
///             |    |   \______   __| _/____ _/  |_  ____   \____    /|__|_____  ______                ///
///             |    |   /\____ \ / __ |\__  \\   __\/ __ \    /     / |  \____ \/  ___/                ///
///             |    |  / |  |_> > /_/ | / __ \|  | \  ___/   /     /_ |  |  |_> >___ \                 ///
///             |______/  |   __/\____ |(____  /__|  \___  > /_______ \|__|   __/____  >                ///
///                       |__|        \/     \/          \/          \/   |__|       \/                 ///
                                                                                                        


                        foreach (string zip in zipnames)
                        {

                            for (int i = 0; i < 67; ++i)
                            {
                                currentziplink = i;
                                int x = i;
                                if (System.IO.File.Exists(cdirectory + zip))
                                {
                                // alreday have this file
                                }

                                if (currentziplink == 0)
                                {
                                    //specific downloaders
                                    using (WebClient wc0 = new WebClient())
                                    {
                                        wc0.DownloadProgressChanged += wc0_DownloadProgressChanged;
                                        wc0.DownloadFileCompleted += new AsyncCompletedEventHandler(wc0_DownloadZipsCompleted);
                                        wc0.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc0 #" + x);
                                    }
                                }

                                if (currentziplink == 1)
                                {
                                    using (WebClient wc1 = new WebClient())
                                    {
                                        wc1.DownloadProgressChanged += wc1_DownloadProgressChanged;
                                        wc1.DownloadFileCompleted += new AsyncCompletedEventHandler(wc1_DownloadZipsCompleted);
                                        wc1.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc1 #" + x);
                                    }
                                }

                                if (currentziplink == 2)
                                {
                                    using (WebClient wc2 = new WebClient())
                                    {
                                        wc2.DownloadProgressChanged += wc2_DownloadProgressChanged;
                                        wc2.DownloadFileCompleted += new AsyncCompletedEventHandler(wc2_DownloadZipsCompleted);
                                        wc2.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc2 #" + x);
                                    }
                                }

                                if (currentziplink == 3)
                                {
                                    //specific downloaders
                                    using (WebClient wc3 = new WebClient())
                                    {
                                        wc3.DownloadProgressChanged += wc3_DownloadProgressChanged;
                                        wc3.DownloadFileCompleted += new AsyncCompletedEventHandler(wc3_DownloadZipsCompleted);
                                        wc3.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc3 #" + x);
                                    }
                                }

                                if (currentziplink == 4)
                                {
                                    //specific downloaders
                                    using (WebClient wc4 = new WebClient())
                                    {
                                        wc4.DownloadProgressChanged += wc4_DownloadProgressChanged;
                                        wc4.DownloadFileCompleted += new AsyncCompletedEventHandler(wc4_DownloadZipsCompleted);
                                        wc4.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc4 #" + x);
                                    }
                                }

                                if (currentziplink == 5)
                                {
                                    using (WebClient wc5 = new WebClient())
                                    {
                                        wc5.DownloadProgressChanged += wc5_DownloadProgressChanged;
                                        wc5.DownloadFileCompleted += new AsyncCompletedEventHandler(wc5_DownloadZipsCompleted);
                                        wc5.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc5 #" + x);
                                    }
                                }

                                if (currentziplink == 6)
                                {
                                    using (WebClient wc6 = new WebClient())
                                    {
                                        wc6.DownloadProgressChanged += wc6_DownloadProgressChanged;
                                        wc6.DownloadFileCompleted += new AsyncCompletedEventHandler(wc6_DownloadZipsCompleted);
                                        wc6.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc6 #" + x);
                                    }
                                }



                                if (currentziplink == 7)
                                {
                                    //specific downloaders
                                    using (WebClient wc7 = new WebClient())
                                    {
                                        wc7.DownloadProgressChanged += wc7_DownloadProgressChanged;
                                        wc7.DownloadFileCompleted += new AsyncCompletedEventHandler(wc7_DownloadZipsCompleted);
                                        wc7.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc7 #" + x);
                                    }
                                }



                                if (currentziplink == 8)
                                {
                                    //specific downloaders
                                    using (WebClient wc8 = new WebClient())
                                    {
                                        wc8.DownloadProgressChanged += wc8_DownloadProgressChanged;
                                        wc8.DownloadFileCompleted += new AsyncCompletedEventHandler(wc8_DownloadZipsCompleted);
                                        wc8.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc8 #" + x);
                                    }
                                }

                                if (currentziplink == 9)
                                {
                                    using (WebClient wc9 = new WebClient())
                                    {
                                        wc9.DownloadProgressChanged += wc9_DownloadProgressChanged;
                                        wc9.DownloadFileCompleted += new AsyncCompletedEventHandler(wc9_DownloadZipsCompleted);
                                        wc9.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc9 #" + x);
                                    }
                                }

                                if (currentziplink == 10)
                                {
                                    using (WebClient wc10 = new WebClient())
                                    {
                                        wc10.DownloadProgressChanged += wc10_DownloadProgressChanged;
                                        wc10.DownloadFileCompleted += new AsyncCompletedEventHandler(wc10_DownloadZipsCompleted);
                                        wc10.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc10 #" + x);
                                    }
                                }



                                if (currentziplink == 11)
                                {
                                    //specific downloaders
                                    using (WebClient wc11 = new WebClient())
                                    {
                                        wc11.DownloadProgressChanged += wc11_DownloadProgressChanged;
                                        wc11.DownloadFileCompleted += new AsyncCompletedEventHandler(wc11_DownloadZipsCompleted);
                                        wc11.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc11 #" + x);
                                    }
                                }


                                if (currentziplink == 12)
                                {
                                    //specific downloaders
                                    using (WebClient wc12 = new WebClient())
                                    {
                                        wc12.DownloadProgressChanged += wc12_DownloadProgressChanged;
                                        wc12.DownloadFileCompleted += new AsyncCompletedEventHandler(wc12_DownloadZipsCompleted);
                                        wc12.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc12 #" + x);
                                    }
                                }

                                if (currentziplink == 13)
                                {
                                    using (WebClient wc13 = new WebClient())
                                    {
                                        wc13.DownloadProgressChanged += wc13_DownloadProgressChanged;
                                        wc13.DownloadFileCompleted += new AsyncCompletedEventHandler(wc13_DownloadZipsCompleted);
                                        wc13.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc13 #" + x);
                                    }
                                }

                                if (currentziplink == 14)
                                {
                                    using (WebClient wc14 = new WebClient())
                                    {
                                        wc14.DownloadProgressChanged += wc14_DownloadProgressChanged;
                                        wc14.DownloadFileCompleted += new AsyncCompletedEventHandler(wc14_DownloadZipsCompleted);
                                        wc14.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc14 #" + x);
                                    }
                                }



                                if (currentziplink == 15)
                                {
                                    //specific downloaders
                                    using (WebClient wc15 = new WebClient())
                                    {
                                        wc15.DownloadProgressChanged += wc15_DownloadProgressChanged;
                                        wc15.DownloadFileCompleted += new AsyncCompletedEventHandler(wc15_DownloadZipsCompleted);
                                        wc15.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc15 #" + x);
                                    }
                                }




                                if (currentziplink == 16)
                                {
                                    //specific downloaders
                                    using (WebClient wc16 = new WebClient())
                                    {
                                        wc16.DownloadProgressChanged += wc16_DownloadProgressChanged;
                                        wc16.DownloadFileCompleted += new AsyncCompletedEventHandler(wc16_DownloadZipsCompleted);
                                        wc16.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc16 #" + x);
                                    }
                                }



                                if (currentziplink == 17)
                                {
                                    using (WebClient wc17 = new WebClient())
                                    {
                                        wc17.DownloadProgressChanged += wc17_DownloadProgressChanged;
                                        wc17.DownloadFileCompleted += new AsyncCompletedEventHandler(wc17_DownloadZipsCompleted);
                                        wc17.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc17 #" + x);
                                    }
                                }

                                if (currentziplink == 18)
                                {
                                    using (WebClient wc18 = new WebClient())
                                    {
                                        wc18.DownloadProgressChanged += wc18_DownloadProgressChanged;
                                        wc18.DownloadFileCompleted += new AsyncCompletedEventHandler(wc18_DownloadZipsCompleted);
                                        wc18.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc18 #" + x);
                                    }
                                }



                                if (currentziplink == 19)
                                {
                                    //specific downloaders
                                    using (WebClient wc19 = new WebClient())
                                    {
                                        wc19.DownloadProgressChanged += wc19_DownloadProgressChanged;
                                        wc19.DownloadFileCompleted += new AsyncCompletedEventHandler(wc19_DownloadZipsCompleted);
                                        wc19.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc19 #" + x);
                                    }
                                }




                                if (currentziplink == 20)
                                {
                                    //specific downloaders
                                    using (WebClient wc20 = new WebClient())
                                    {
                                        wc20.DownloadProgressChanged += wc20_DownloadProgressChanged;
                                        wc20.DownloadFileCompleted += new AsyncCompletedEventHandler(wc20_DownloadZipsCompleted);
                                        wc20.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc20 #" + x);
                                    }
                                }

                                if (currentziplink == 21)
                                {
                                    using (WebClient wc21 = new WebClient())
                                    {
                                        wc21.DownloadProgressChanged += wc21_DownloadProgressChanged;
                                        wc21.DownloadFileCompleted += new AsyncCompletedEventHandler(wc21_DownloadZipsCompleted);
                                        wc21.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc21 #" + x);
                                    }
                                }

                                if (currentziplink == 22)
                                {
                                    using (WebClient wc22 = new WebClient())
                                    {
                                        wc22.DownloadProgressChanged += wc22_DownloadProgressChanged;
                                        wc22.DownloadFileCompleted += new AsyncCompletedEventHandler(wc22_DownloadZipsCompleted);
                                        wc22.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc22 #" + x);
                                    }
                                }



                                if (currentziplink == 23)
                                {
                                    //specific downloaders
                                    using (WebClient wc23 = new WebClient())
                                    {
                                        wc23.DownloadProgressChanged += wc23_DownloadProgressChanged;
                                        wc23.DownloadFileCompleted += new AsyncCompletedEventHandler(wc23_DownloadZipsCompleted);
                                        wc23.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc23 #" + x);
                                    }
                                }



                                if (currentziplink == 24)
                                {
                                    //specific downloaders
                                    using (WebClient wc24 = new WebClient())
                                    {
                                        wc24.DownloadProgressChanged += wc24_DownloadProgressChanged;
                                        wc24.DownloadFileCompleted += new AsyncCompletedEventHandler(wc24_DownloadZipsCompleted);
                                        wc24.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc24 #" + x);
                                    }
                                }

                                if (currentziplink == 25)
                                {
                                    using (WebClient wc25 = new WebClient())
                                    {
                                        wc25.DownloadProgressChanged += wc25_DownloadProgressChanged;
                                        wc25.DownloadFileCompleted += new AsyncCompletedEventHandler(wc25_DownloadZipsCompleted);
                                        wc25.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc25 #" + x);
                                    }
                                }





                                if (currentziplink == 26)
                                {
                                    using (WebClient wc26 = new WebClient())
                                    {
                                        wc26.DownloadProgressChanged += wc26_DownloadProgressChanged;
                                        wc26.DownloadFileCompleted += new AsyncCompletedEventHandler(wc26_DownloadZipsCompleted);
                                        wc26.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc26 #" + x);
                                    }
                                }

                                if (currentziplink == 27)
                                {
                                    using (WebClient wc27 = new WebClient())
                                    {
                                        wc27.DownloadProgressChanged += wc27_DownloadProgressChanged;
                                        wc27.DownloadFileCompleted += new AsyncCompletedEventHandler(wc27_DownloadZipsCompleted);
                                        wc27.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc27 #" + x);
                                    }
                                }



                                if (currentziplink == 28)
                                {
                                    //specific downloaders
                                    using (WebClient wc28 = new WebClient())
                                    {
                                        wc28.DownloadProgressChanged += wc28_DownloadProgressChanged;
                                        wc28.DownloadFileCompleted += new AsyncCompletedEventHandler(wc28_DownloadZipsCompleted);
                                        wc28.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc28 #" + x);
                                    }
                                }




                                if (currentziplink == 29)
                                {
                                    //specific downloaders
                                    using (WebClient wc29 = new WebClient())
                                    {
                                        wc29.DownloadProgressChanged += wc29_DownloadProgressChanged;
                                        wc29.DownloadFileCompleted += new AsyncCompletedEventHandler(wc29_DownloadZipsCompleted);
                                        wc29.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc29 #" + x);
                                    }
                                }

                                if (currentziplink == 30)
                                {
                                    using (WebClient wc30 = new WebClient())
                                    {
                                        wc30.DownloadProgressChanged += wc30_DownloadProgressChanged;
                                        wc30.DownloadFileCompleted += new AsyncCompletedEventHandler(wc30_DownloadZipsCompleted);
                                        wc30.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc30 #" + x);
                                    }
                                }

                                if (currentziplink == 31)
                                {
                                    using (WebClient wc31 = new WebClient())
                                    {
                                        wc31.DownloadProgressChanged += wc31_DownloadProgressChanged;
                                        wc31.DownloadFileCompleted += new AsyncCompletedEventHandler(wc31_DownloadZipsCompleted);
                                        wc31.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc31 #" + x);
                                    }
                                }




                                if (currentziplink == 32)
                                {
                                    using (WebClient wc32 = new WebClient())
                                    {
                                        wc32.DownloadProgressChanged += wc32_DownloadProgressChanged;
                                        wc32.DownloadFileCompleted += new AsyncCompletedEventHandler(wc32_DownloadZipsCompleted);
                                        wc32.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc32 #" + x);
                                    }
                                }

                                if (currentziplink == 33)
                                {
                                    using (WebClient wc33 = new WebClient())
                                    {
                                        wc33.DownloadProgressChanged += wc33_DownloadProgressChanged;
                                        wc33.DownloadFileCompleted += new AsyncCompletedEventHandler(wc33_DownloadZipsCompleted);
                                        wc33.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc33 #" + x);
                                    }
                                }



                                if (currentziplink == 34)
                                {
                                    //specific downloaders
                                    using (WebClient wc34 = new WebClient())
                                    {
                                        wc34.DownloadProgressChanged += wc34_DownloadProgressChanged;
                                        wc34.DownloadFileCompleted += new AsyncCompletedEventHandler(wc34_DownloadZipsCompleted);
                                        wc34.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc34 #" + x);
                                    }
                                }




                                if (currentziplink == 35)
                                {
                                    //specific downloaders
                                    using (WebClient wc35 = new WebClient())
                                    {
                                        wc35.DownloadProgressChanged += wc35_DownloadProgressChanged;
                                        wc35.DownloadFileCompleted += new AsyncCompletedEventHandler(wc35_DownloadZipsCompleted);
                                        wc35.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc35 #" + x);
                                    }
                                }

                                if (currentziplink == 36)
                                {
                                    using (WebClient wc36 = new WebClient())
                                    {
                                        wc36.DownloadProgressChanged += wc36_DownloadProgressChanged;
                                        wc36.DownloadFileCompleted += new AsyncCompletedEventHandler(wc36_DownloadZipsCompleted);
                                        wc36.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc36 #" + x);
                                    }
                                }

                                if (currentziplink == 37)
                                {
                                    using (WebClient wc37 = new WebClient())
                                    {
                                        wc37.DownloadProgressChanged += wc37_DownloadProgressChanged;
                                        wc37.DownloadFileCompleted += new AsyncCompletedEventHandler(wc37_DownloadZipsCompleted);
                                        wc37.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc37 #" + x);
                                    }
                                }




                                if (currentziplink == 38)
                                {
                                    using (WebClient wc38 = new WebClient())
                                    {
                                        wc38.DownloadProgressChanged += wc38_DownloadProgressChanged;
                                        wc38.DownloadFileCompleted += new AsyncCompletedEventHandler(wc38_DownloadZipsCompleted);
                                        wc38.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc38 #" + x);
                                    }
                                }

                                if (currentziplink == 39)
                                {
                                    using (WebClient wc39 = new WebClient())
                                    {
                                        wc39.DownloadProgressChanged += wc39_DownloadProgressChanged;
                                        wc39.DownloadFileCompleted += new AsyncCompletedEventHandler(wc39_DownloadZipsCompleted);
                                        wc39.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc39 #" + x);
                                    }
                                }




                                if (currentziplink == 40)
                                {
                                    using (WebClient wc40 = new WebClient())
                                    {
                                        wc40.DownloadProgressChanged += wc40_DownloadProgressChanged;
                                        wc40.DownloadFileCompleted += new AsyncCompletedEventHandler(wc40_DownloadZipsCompleted);
                                        wc40.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc40 #" + x);
                                    }
                                }

                                if (currentziplink == 41)
                                {
                                    using (WebClient wc41 = new WebClient())
                                    {
                                        wc41.DownloadProgressChanged += wc41_DownloadProgressChanged;
                                        wc41.DownloadFileCompleted += new AsyncCompletedEventHandler(wc41_DownloadZipsCompleted);
                                        wc41.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc41 #" + x);
                                    }
                                }



                                if (currentziplink == 42)
                                {
                                    //specific downloaders
                                    using (WebClient wc42 = new WebClient())
                                    {
                                        wc42.DownloadProgressChanged += wc42_DownloadProgressChanged;
                                        wc42.DownloadFileCompleted += new AsyncCompletedEventHandler(wc42_DownloadZipsCompleted);
                                        wc42.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc42 #" + x);
                                    }
                                }




                                if (currentziplink == 43)
                                {
                                    //specific downloaders
                                    using (WebClient wc43 = new WebClient())
                                    {
                                        wc43.DownloadProgressChanged += wc43_DownloadProgressChanged;
                                        wc43.DownloadFileCompleted += new AsyncCompletedEventHandler(wc43_DownloadZipsCompleted);
                                        wc43.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc43 #" + x);
                                    }
                                }

                                if (currentziplink == 44)
                                {
                                    using (WebClient wc44 = new WebClient())
                                    {
                                        wc44.DownloadProgressChanged += wc44_DownloadProgressChanged;
                                        wc44.DownloadFileCompleted += new AsyncCompletedEventHandler(wc44_DownloadZipsCompleted);
                                        wc44.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc44 #" + x);
                                    }
                                }

                                if (currentziplink == 45)
                                {
                                    using (WebClient wc45 = new WebClient())
                                    {
                                        wc45.DownloadProgressChanged += wc45_DownloadProgressChanged;
                                        wc45.DownloadFileCompleted += new AsyncCompletedEventHandler(wc45_DownloadZipsCompleted);
                                        wc45.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc45 #" + x);
                                    }
                                }


                                if (currentziplink == 46)
                                {
                                    using (WebClient wc46 = new WebClient())
                                    {
                                        wc46.DownloadProgressChanged += wc46_DownloadProgressChanged;
                                        wc46.DownloadFileCompleted += new AsyncCompletedEventHandler(wc46_DownloadZipsCompleted);
                                        wc46.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc46 #" + x);
                                    }
                                }

                                if (currentziplink == 47)
                                {
                                    using (WebClient wc47 = new WebClient())
                                    {
                                        wc47.DownloadProgressChanged += wc47_DownloadProgressChanged;
                                        wc47.DownloadFileCompleted += new AsyncCompletedEventHandler(wc47_DownloadZipsCompleted);
                                        wc47.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc47 #" + x);
                                    }
                                }




                                if (currentziplink == 48)
                                {
                                    using (WebClient wc48 = new WebClient())
                                    {
                                        wc48.DownloadProgressChanged += wc48_DownloadProgressChanged;
                                        wc48.DownloadFileCompleted += new AsyncCompletedEventHandler(wc48_DownloadZipsCompleted);
                                        wc48.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc48 #" + x);
                                    }
                                }

                                if (currentziplink == 49)
                                {
                                    using (WebClient wc49 = new WebClient())
                                    {
                                        wc49.DownloadProgressChanged += wc49_DownloadProgressChanged;
                                        wc49.DownloadFileCompleted += new AsyncCompletedEventHandler(wc49_DownloadZipsCompleted);
                                        wc49.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc49 #" + x);
                                    }
                                }



                                if (currentziplink == 50)
                                {
                                    //specific downloaders
                                    using (WebClient wc50 = new WebClient())
                                    {
                                        wc50.DownloadProgressChanged += wc50_DownloadProgressChanged;
                                        wc50.DownloadFileCompleted += new AsyncCompletedEventHandler(wc50_DownloadZipsCompleted);
                                        wc50.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc50 #" + x);
                                    }
                                }




                                if (currentziplink == 51)
                                {
                                    //specific downloaders
                                    using (WebClient wc51 = new WebClient())
                                    {
                                        wc51.DownloadProgressChanged += wc51_DownloadProgressChanged;
                                        wc51.DownloadFileCompleted += new AsyncCompletedEventHandler(wc51_DownloadZipsCompleted);
                                        wc51.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc51 #" + x);
                                    }
                                }

                                if (currentziplink == 52)
                                {
                                    using (WebClient wc52 = new WebClient())
                                    {
                                        wc52.DownloadProgressChanged += wc52_DownloadProgressChanged;
                                        wc52.DownloadFileCompleted += new AsyncCompletedEventHandler(wc52_DownloadZipsCompleted);
                                        wc52.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc52 #" + x);
                                    }
                                }

                                if (currentziplink == 53)
                                {
                                    using (WebClient wc53 = new WebClient())
                                    {
                                        wc53.DownloadProgressChanged += wc53_DownloadProgressChanged;
                                        wc53.DownloadFileCompleted += new AsyncCompletedEventHandler(wc53_DownloadZipsCompleted);
                                        wc53.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc53 #" + x);
                                    }
                                }


                                if (currentziplink == 54)
                                {
                                    using (WebClient wc54 = new WebClient())
                                    {
                                        wc54.DownloadProgressChanged += wc54_DownloadProgressChanged;
                                        wc54.DownloadFileCompleted += new AsyncCompletedEventHandler(wc54_DownloadZipsCompleted);
                                        wc54.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc54 #" + x);
                                    }
                                }



                                if (currentziplink == 55)
                                {
                                    using (WebClient wc55 = new WebClient())
                                    {
                                        wc55.DownloadProgressChanged += wc55_DownloadProgressChanged;
                                        wc55.DownloadFileCompleted += new AsyncCompletedEventHandler(wc55_DownloadZipsCompleted);
                                        wc55.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc55 #" + x);
                                    }
                                }

                                if (currentziplink == 56)
                                {
                                    using (WebClient wc56 = new WebClient())
                                    {
                                        wc56.DownloadProgressChanged += wc56_DownloadProgressChanged;
                                        wc56.DownloadFileCompleted += new AsyncCompletedEventHandler(wc56_DownloadZipsCompleted);
                                        wc56.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc56 #" + x);
                                    }
                                }




                                if (currentziplink == 57)
                                {
                                    using (WebClient wc57 = new WebClient())
                                    {
                                        wc57.DownloadProgressChanged += wc57_DownloadProgressChanged;
                                        wc57.DownloadFileCompleted += new AsyncCompletedEventHandler(wc57_DownloadZipsCompleted);
                                        wc57.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc57 #" + x);
                                    }
                                }

                                if (currentziplink == 58)
                                {
                                    using (WebClient wc58 = new WebClient())
                                    {
                                        wc58.DownloadProgressChanged += wc58_DownloadProgressChanged;
                                        wc58.DownloadFileCompleted += new AsyncCompletedEventHandler(wc58_DownloadZipsCompleted);
                                        wc58.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc58 #" + x);
                                    }
                                }



                                if (currentziplink == 59)
                                {
                                    //specific downloaders
                                    using (WebClient wc59 = new WebClient())
                                    {
                                        wc59.DownloadProgressChanged += wc59_DownloadProgressChanged;
                                        wc59.DownloadFileCompleted += new AsyncCompletedEventHandler(wc59_DownloadZipsCompleted);
                                        wc59.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc59 #" + x);
                                    }
                                }




                                if (currentziplink == 60)
                                {
                                    //specific downloaders
                                    using (WebClient wc60 = new WebClient())
                                    {
                                        wc60.DownloadProgressChanged += wc60_DownloadProgressChanged;
                                        wc60.DownloadFileCompleted += new AsyncCompletedEventHandler(wc60_DownloadZipsCompleted);
                                        wc60.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc60 #" + x);
                                    }
                                }

                                if (currentziplink == 61)
                                {
                                    using (WebClient wc61 = new WebClient())
                                    {
                                        wc61.DownloadProgressChanged += wc61_DownloadProgressChanged;
                                        wc61.DownloadFileCompleted += new AsyncCompletedEventHandler(wc61_DownloadZipsCompleted);
                                        wc61.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc61 #" + x);
                                    }
                                }

                                if (currentziplink == 62)
                                {
                                    using (WebClient wc62 = new WebClient())
                                    {
                                        wc62.DownloadProgressChanged += wc62_DownloadProgressChanged;
                                        wc62.DownloadFileCompleted += new AsyncCompletedEventHandler(wc62_DownloadZipsCompleted);
                                        wc62.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc62 #" + x);
                                    }
                                }






                                if (currentziplink == 63)
                                {
                                    using (WebClient wc63 = new WebClient())
                                    {
                                        wc63.DownloadProgressChanged += wc63_DownloadProgressChanged;
                                        wc63.DownloadFileCompleted += new AsyncCompletedEventHandler(wc63_DownloadZipsCompleted);
                                        wc63.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc63 #" + x);
                                    }
                                }

                                if (currentziplink == 64)
                                {
                                    using (WebClient wc64 = new WebClient())
                                    {
                                        wc64.DownloadProgressChanged += wc64_DownloadProgressChanged;
                                        wc64.DownloadFileCompleted += new AsyncCompletedEventHandler(wc64_DownloadZipsCompleted);
                                        wc64.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc64 #" + x);
                                    }
                                }




                                if (currentziplink == 65)
                                {
                                    using (WebClient wc65 = new WebClient())
                                    {
                                        wc65.DownloadProgressChanged += wc65_DownloadProgressChanged;
                                        wc65.DownloadFileCompleted += new AsyncCompletedEventHandler(wc65_DownloadZipsCompleted);
                                        wc65.DownloadFileAsync(new System.Uri(ziplinks[x]), (cdirectory + zip));
                                        Console.WriteLine(zip + " set as wc65 #" + x);
                                    }
                                }







                                else
                                {
                                    // nothing

                                    Console.WriteLine("else: currentziplink not equal to anything..." + currentziplink + " ???");
                                }


                            }
                        }
                        Console.WriteLine("Done with zipnames loop");
                    }
                }

                else
                {
                    //not the latest version
                    //download some shit! 
                    Console.WriteLine("Knowts is not up to date so we download new knowts");
                    progressBar1.Visible = true;
                    play.Enabled = false;
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wctext1_DownloadProgressChanged;
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wctext1_DownloadKnowtsCompleted);
                        wc.DownloadFileAsync(new System.Uri("https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/Knowts.txt"), "Game/Knowts.txt");

                    }
                }
            }

            // No game build .exe was found, so we need to download the game, first look locally to see if we have the latest
            // text file containing the link to the latest version.  
            // download text file from github, read that text file and save link as a string, use string to download zip
            else // latest path does not exist, download the latest knowts
            {
                Console.WriteLine("No local exe so we need to download something");
                // First see if we have the txt file -- perhaps we have opened the launcher but not yet downloaded a build
                if (latestlink != "")
                {
                    Console.WriteLine(onlinelatesthtml + " == " + latestlink);
                    Console.WriteLine("Knowts is up to date so we have the latest local download link");
                    string[] dirs = Directory.GetFiles(cdirectory, "*WoA_1902*", SearchOption.TopDirectoryOnly);
                    Console.WriteLine(gdirectory + ", The number of zips starting with W is " + dirs.Length + ", listing their names here:");


                      foreach (string dir in dirs)
                      {
                          string letsdothis = dir;
                          Console.WriteLine(dir);
                          if (dir != null)
                          {
                              // 
                    
                          }
                          else
                          {
                              progressBar1.Visible = true;
                              using (WebClient wc = new WebClient())
                              {
                                  //download some shit! 
                                  wc.DownloadProgressChanged += wctext1_DownloadProgressChanged;
                                   // event called for downlading new knowts
                                  wc.DownloadFile(new System.Uri("https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/Knowts.txt"), "Game/Knowts.txt");
                                  play.Text = dir;
                    

                              }
                          }
                      } // end of loop










                } // end of if (onlinelatesthtml == latestlink)

                //Otherwise we have nothing, and we need to first download the Knowts.txt
                else // NOT latest (onlinelatesthtml =/= latestlink)
                {
                    // show a prompt
                    string message = "No Winds of Almerra builds were found in " + gdirectory + " , download latest?";
                    string caption = "Project not found!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        // Startup a web client to download the Knowts.txt file containing the link
                        progressBar1.Visible = true;
                        using (WebClient wctext1 = new System.Net.WebClient())
                        {
                            wctext1.DownloadProgressChanged += wctext1_DownloadProgressChanged;
                            wctext1.DownloadFileCompleted += new AsyncCompletedEventHandler(wctext1_DownloadKnowtsCompleted);
                            wctext1.DownloadFileAsync(new System.Uri("https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/Knowts.txt"), "Game/Knowts.txt");

                        }
                        using (WebClient wctext2 = new System.Net.WebClient())
                        {
                            wctext2.DownloadProgressChanged += wctext2_DownloadProgressChanged;
                            wctext2.DownloadFileCompleted += new AsyncCompletedEventHandler(wctext2_DownloadBuildCompleted);
                            wctext2.DownloadFileAsync(new System.Uri("https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/Build.txt"), "Game/Build.txt");

                        }

                        using (WebClient wctext3 = new System.Net.WebClient())
                        {
                            wctext3.DownloadProgressChanged += wctext3_DownloadProgressChanged;
                            wctext3.DownloadFileCompleted += new AsyncCompletedEventHandler(wctext3_DownloadManifestCompleted);
                            wctext3.DownloadFileAsync(new System.Uri("https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/Manifest.txt"), "Game/Manifest.txt");

                        }
                        using (WebClient wctext4 = new System.Net.WebClient())
                        {
                            wctext4.DownloadProgressChanged += wctext4_DownloadProgressChanged;
                            wctext4.DownloadFileCompleted += new AsyncCompletedEventHandler(wctext4_DownloadZipsManifestCompleted);
                            wctext4.DownloadFileAsync(new System.Uri("https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/ZipsManifest.txt"), "Game/ZipsManifest.txt");

                        }
                        ziplinkspath = "Game/ZipsManifest.txt";
                        manifestpath = "Game/Manifest.txt";

                    }

                    // If user selects 'NO' at prompt then nothing happens, closes prompt and goes back to launcher to wait

                    if (result == DialogResult.No)
                    {
                        Console.WriteLine("Ignoring error '" + caption + "'");
                    }
                }
            }
            //string latestlink = File.ReadAllText("Game/Knowts.txt");
            //Console.WriteLine(latestlink);
            //very end of play-click
        }



        //                                                                                                                  //
        //               ____ ___            .___       __           ___________                    __                      //
        //              |    |   \______   __| _/____ _/  |_  ____   \_   _____/__  __ ____   _____/  |_  ______            //
        //              |    |   /\____ \ / __ |\__  \\   __\/ __ \   |    __)_\  \/ // __ \ /    \   __\/  ___/            //
        //              |    |  / |  |_> > /_/ | / __ \|  | \  ___/   |        \\   /\  ___/|   |  \  |  \___ \             //
        //              |______/  |   __/\____ |(____  /__|  \___  > /_______  / \_/  \___  >___|  /__| /____  >            //
        //                        |__|        \/     \/          \/          \/           \/     \/          \/             //
        //                                                                                                                  //
        //                                                                                                                  //
        //                                                                                                                  //

        //first ones are for the txt files
        // Download completed Events for Knowts, Build, and the Manifests 


        //      ___________              __    ________                      .__                    .___                  //
        //      \__    ___/___ ___  ____/  |_  \______ \   ______  _  ______ |  |   _________     __| _/______            //
        //        |    |_/ __ \\  \/  /\   __\  |    |  \ /  _ \ \/ \/ /    \|  |  /  _ \__  \   / __ |/  ___/            //
        //        |    |\  ___/ >    <  |  |    |    `   (  <_> )     /   |  \  |_(  <_> ) __ \_/ /_/ |\___ \             //
        //        |____| \___  >__/\_ \ |__|   /_______  /\____/ \/\_/|___|  /____/\____(____  /\____ /____  >            //
        //                   \/      \/                \/                  \/                \/      \/    \/             //
        //                                                                                                                //


        void wctext1_DownloadKnowtsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            // shit
            progressBar1.Visible = false;
            LatestPathExists = (System.IO.File.Exists("Game/Build.txt"));
            //play.Text = "Get Zips";
            play.Enabled = true;
        }

        void wctext2_DownloadBuildCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            // shit
            progressBar1.Visible = false;
            LatestPathExists = (System.IO.File.Exists("Game/Build.txt"));
            //play.Text = "Get Zips";
            play.Enabled = true;
        }
        void wctext3_DownloadManifestCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            // shit
            progressBar1.Visible = false;
            LatestPathExists = (System.IO.File.Exists("Game/Manifest.txt"));
            //play.Text = "Get Zips";
            play.Enabled = true;
        }
        void wctext4_DownloadZipsManifestCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            // shit
            progressBar1.Visible = false;
            LatestPathExists = (System.IO.File.Exists("Game/ZipsManifest.txt"));
            play.Text = "Get Zips";
            play.Enabled = true;
        }





        //                                                                                                                         //
        //      _________                       .__          __             .___ ___________              __                       //
        //      \_   ___ \  ____   _____ ______ |  |   _____/  |_  ____   __| _/ \__    ___/___ ___  ____/  |_  ______             //
        //      /    \  \/ /  _ \ /     \\____ \|  | _/ __ \   __\/ __ \ / __ |    |    |_/ __ \\  \/  /\   __\/  ___/             //
        //      \     \___(  <_> )  Y Y  \  |_> >  |_\  ___/|  | \  ___// /_/ |    |    |\  ___/ >    <  |  |  \___ \              //
        //       \______  /\____/|__|_|  /   __/|____/\___  >__|  \___  >____ |    |____| \___  >__/\_ \ |__| /____  >             //
        //              \/             \/|__|             \/          \/     \/               \/      \/           \/              //
        //                                                                                                                         //



        // Download update events for the loading bars for Knowts, Build and the Manifests

        void wctext1_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            //play.Text = (currentziplink.ToString() + "%");

        }
        void wctext2_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
            //play.Text = (currentziplink.ToString() + "%");

        }
        void wctext3_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar3.Value = e.ProgressPercentage;
            //play.Text = (currentziplink.ToString() + "%");

        }
        void wctext4_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar4.Value = e.ProgressPercentage;
            play.Text = (currentziplink.ToString() + "%");

        }





        //      ________                      .__                    .___ __________.__         ___________                    __               //
        //      \______ \   ______  _  ______ |  |   _________     __| _/ \____    /|__|_____   \_   _____/__  __ ____   _____/  |_  ______     //
        //       |    |  \ /  _ \ \/ \/ /    \|  |  /  _ \__  \   / __ |    /     / |  \____ \   |    __)_\  \/ // __ \ /    \   __\/  ___/     //
        //       |    `   (  <_> )     /   |  \  |_(  <_> ) __ \_/ /_/ |   /     /_ |  |  |_> >  |        \\   /\  ___/|   |  \  |  \___ \      //
        //      /_______  /\____/ \/\_/|___|  /____/\____(____  /\____ |  /_______ \|__|   __/  /_______  / \_/  \___  >___|  /__| /____  >     //
        //              \/                  \/                \/      \/          \/   |__|             \/           \/     \/          \/      //
        //                                                                                                                                      //



        //// Event to track the progress
        //void wc1_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        //{
        //    progressBar1.Value = e.ProgressPercentage;
        //    play.Text = (currentziplink.ToString() + "%");
        //    Console.WriteLine("Unzippingd de " + currentziplink);
        //{

        void wc0_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar0.Value = e.ProgressPercentage;
        }


        void wc1_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        void wc2_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
        }
        void wc3_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar3.Value = e.ProgressPercentage;
        }
        void wc4_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar4.Value = e.ProgressPercentage;
        }
        void wc5_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar5.Value = e.ProgressPercentage;
        }
        void wc6_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar6.Value = e.ProgressPercentage;
        }

        void wc7_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar7.Value = e.ProgressPercentage;
        }
        void wc8_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar8.Value = e.ProgressPercentage;
        }
        void wc9_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar9.Value = e.ProgressPercentage;
        }
        void wc10_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc11_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc12_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc13_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc14_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

        }
        void wc15_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc16_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc17_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc18_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc19_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc20_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc21_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc22_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc23_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc24_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc25_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }

        void wc26_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc27_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc28_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }

        void wc29_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }

        void wc30_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc31_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc32_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc33_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc34_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc35_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc36_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }

        void wc37_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc38_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc39_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc40_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc41_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc42_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc43_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc44_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc45_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)

        {
        }
        void wc46_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc47_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc48_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc49_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc50_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc51_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc52_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc53_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc54_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc55_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc56_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc57_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc58_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc59_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc60_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc61_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc62_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc63_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc64_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }
        void wc65_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
        }




        //  _________                       .__          __             .___ __________.__         ___________                    __            //
        //  \_   ___ \  ____   _____ ______ |  |   _____/  |_  ____   __| _/ \____    /|__|_____   \_   _____/__  __ ____   _____/  |_  ______  //
        //  /    \  \/ /  _ \ /     \\____ \|  | _/ __ \   __\/ __ \ / __ |    /     / |  \____ \   |    __)_\  \/ // __ \ /    \   __\/  ___/  //
        //  \     \___(  <_> )  Y Y  \  |_> >  |_\  ___/|  | \  ___// /_/ |   /     /_ |  |  |_> >  |        \\   /\  ___/|   |  \  |  \___ \   //
        //   \______  /\____/|__|_|  /   __/|____/\___  >__|  \___  >____ |  /_______ \|__|   __/  /_______  / \_/  \___  >___|  /__| /____  >  //
        //          \/             \/|__|             \/          \/     \/          \/   |__|             \/           \/     \/          \/   //
        //                                                                                                                                      //

// zip file progress indicators

// void wc1_DownloadKnowtsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
// {
//     // shit
//     progressBar1.Visible = false;
//     LatestPathExists = (System.IO.File.Exists("Game/Knowts.txt"));
//     play.Text = "Get Zips";
//     play.Enabled = true;
// }


            



        void wc0_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

        }


        void wc1_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

        }
        void wc2_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

        }
        void wc3_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

        }
        void wc4_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

        }
        void wc5_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

        }
        void wc6_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

        }
        void wc7_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

        }
        void wc8_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

        }
        void wc9_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

        }

        void wc10_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc11_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc12_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc13_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc14_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc15_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc16_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc17_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc18_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc19_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc20_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc21_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc22_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc23_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc24_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc25_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc26_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc27_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc28_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc29_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc30_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc31_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc32_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc33_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc34_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc35_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc36_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc37_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc38_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc39_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc40_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc41_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc42_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc43_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc44_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc45_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc46_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc47_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc48_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc49_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc50_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc51_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc52_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc53_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc54_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc55_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc56_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc57_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc58_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc59_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc60_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc61_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc62_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc63_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc64_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }
        void wc65_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
        }




    





        //                                                                                                           //
        //                  .____                     .___ ___________              .__                              //
        //                  |    |    _________     __| _/ \_   _____/ ____    ____ |__| ____   ____                 //
        //                  |    |   /  _ \__  \   / __ |   |    __)_ /    \  / ___\|  |/    \_/ __ \                //
        //                  |    |__(  <_> ) __ \_/ /_/ |   |        \   |  \/ /_/  >  |   |  \  ___/                //
        //                  |_______ \____(____  /\____ |  /_______  /___|  /\___  /|__|___|  /\___  >               //
        //                          \/         \/      \/          \/     \//_____/         \/     \/                //
        //                                                                                                           //
        //                                                                                                           //


        private void button1_Click(object sender, EventArgs e)
        {

            /*     startup the engine    */
            var pdirectory = (@"H:\UE4\Projects\WoA_1902");
            var processExists = System.Diagnostics.Process.GetProcesses().Any(p => p.ProcessName.Contains("WoA_1902.exe"));
            if (soundenabled == true)
            {
                System.Media.SoundPlayer sp = (patsoft);
                sp.Play();
            };

            try
            {
                var sProcessName = ("UE4Editor");
                System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName(sProcessName);
                if (proc.Length > 0)
                {
                    MessageBox.Show(String.Format("{0} is already running!", sProcessName), sProcessName);
                }
                else
                {

                    // Only get files that begin with the letter "c."
                    string[] dirs = Directory.GetFiles(pdirectory, "*WoA_1902.uproject*", SearchOption.TopDirectoryOnly);
                    Console.WriteLine(pdirectory + ", The number of files starting with W is " + dirs.Length);
                    foreach (string dir in dirs)
                    {
                        string letsdothis = dir;
                        Console.WriteLine(dir);

                        if (dir != null)
                        {
                            System.Diagnostics.Process.Start(dir);
                            this.WindowState = FormWindowState.Minimized;
                        }
                    }

                    // end of start engine button

                }
            }
            catch
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "No Almerra project files were found in " + pdirectory + ", close application?";
                string caption = "Project not found!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                { Application.Exit(); }
                if (result == DialogResult.No)
                { Console.WriteLine("Ignoring error '" + caption + "'"); }
            }
            Console.WriteLine("Project already running");
        }





//                                                                                                                  //
//            _________ __          .__             _________       __    __  .__                                   //
//           /   _____//  |_ ___.__.|  |   ____    /   _____/ _____/  |__/  |_|__| ____    ____  ______             //
//           \_____  \\   __<   |  ||  | _/ __ \   \_____  \_/ __ \   __\   __\  |/    \  / ___\/  ___/             //
//           /        \|  |  \___  ||  |_\  ___/   /        \  ___/|  |  |  | |  |   |  \/ /_/  >___ \              //
//          /_______  /|__|  / ____||____/\___  > /_______  /\___  >__|  |__| |__|___|  /\___  /____  >             //
//                  \/       \/               \/          \/     \/                   \//_____/     \/              //
//                                                                                                                  //
//                                                                                                                  //

        
        private void main_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Main Window Loaded");


            play.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            CloseButton.BackColor = Color.Transparent;

            button2.BackColor = Color.Transparent;


            button9.BackColor = Color.Transparent;
            button10.BackColor = Color.Transparent;

            MinimizeButton.BackColor = Color.Transparent;

            button12.BackColor = Color.Transparent;
            
            VersionLabel.BackColor = System.Drawing.Color.Transparent;

            ToolsPanel.BackColor = Color.Transparent;
            ToMainButton.BackColor = Color.Transparent;
            ToPanelButton.BackColor = Color.Transparent;
            ToolsPanel.Visible = false;
            ToMainButton.Visible = false;

            OtherPanel.Visible = false;
            GeneralPanel.Visible = false;

            play.Parent = font;
            button1.Parent = font;
            CloseButton.Parent = font;
            MinimizeButton.Parent = font;
            ToolsPanel.Parent = font;
            ToMainButton.Parent = font;
            ToPanelButton.Parent = font;
            button12.Parent = font;
            button2.Parent = font;



        }





        /*******************************
            handle the moving window
        /********************************/

        private void font_Click(object sender, EventArgs e)
        {
            // DOes nothing, clicking on background image is ignored since mouseDown handles dragging the window
        }

        /* clicking on background image */

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void font_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }








        /* Startup Load events */

        private void font_LoadCompleted(object sender, EventArgs e)
        {
            
        }

        private void notifyIcon1_LoadCompleted(object sender, MouseEventArgs e)
        {

        }





        //           _______              .__              __  .__                                 //
        //           \      \ _____ ___  _|__| _________ _/  |_|__| ____   ____                    //
        //           /   |   \\__  \\  \/ /  |/ ___\__  \\   __\  |/  _ \ /    \                   //
        //          /    |    \/ __ \\   /|  / /_/  > __ \|  | |  (  <_> )   |  \                  //
        //          \____|__  (____  /\_/ |__\___  (____  /__| |__|\____/|___|  /                  //
        //                  \/     \/       /_____/     \/                    \/                   //


        /******************************************* NAVIGATION BUTTONS ************************************/
        /******************************************* Main Menu ************************************/



        //  Show only the Tools menu //
        private void ToPanelButton_Click(object sender, EventArgs e)
        {
            if (soundenabled == true)
            {
                System.Media.SoundPlayer sp = (patwarnings);
                sp.Play();
            };
            Console.WriteLine("ToPanelButton clicked");
            ToolsPanel.Visible = true;
            ToMainButton.Visible = true; // tools panel and button to get back
            ToPanelButton.Visible = false;
            webBrowser1.Visible = false;
            button12.Visible = true;


            OtherPanel.Visible = false;
            GeneralPanel.Visible = false;

            Point coordinates = Cursor.Position;
            Console.WriteLine("Coordinates are: " + coordinates);

        }

        //  Hide Everything--just show image background //
        private void ToMainButton_Click(object sender, EventArgs e)
        {
            if (soundenabled == true)
            {
                System.Media.SoundPlayer sp = (patwarnings);
                sp.Play();
            };
            Console.WriteLine("ToMainButton clicked");
            ToolsPanel.Visible = false;
            ToMainButton.Visible = false;
            ToPanelButton.Visible = true; // back to main only shows tools button
            webBrowser1.Visible = false;
            button12.Visible = true;

            OtherPanel.Visible = false;
            GeneralPanel.Visible = false;

        }

        //  Show only the news + main menu buttons //
        private void button12_Click(object sender, EventArgs e)
        {
            if (soundenabled == true)
            {
                System.Media.SoundPlayer sp = (patwarnings);
                sp.Play();
            };
            Console.WriteLine("Show News");
            ToolsPanel.Visible = false;
            webBrowser1.Visible = true; // back to main and news button
            ToMainButton.Visible = true;
            ToPanelButton.Visible = false;
            button12.Visible = false;

            OtherPanel.Visible = false;
            GeneralPanel.Visible = false;

        }


        /******************************************* NAVIGATION BUTTONS CONTINUED************************************/
        /******************************************* Tools menus ************************************/

        private void button10_Click(object sender, EventArgs e)                 // other panel for launcher shit
        {
            OtherPanel.Visible = true;

            GeneralPanel.Visible = false;
            if (soundenabled == true)
            {
                System.Media.SoundPlayer sp = (patwarnings);
                sp.Play();
            };

            Console.WriteLine("Fauna Data Tools");



        }

        private void button9_Click(object sender, EventArgs e)                                  // shows the General Tab Panel
        {
            GeneralPanel.Visible = true; // ENVPanel is now the Options Menu for swapping configs and golobal shit

            OtherPanel.Visible = false;

            if (soundenabled == true)
            {
                System.Media.SoundPlayer sp = (patwarnings);
                sp.Play();
            };

            Console.WriteLine("Options Data Tools");

        }
        
        

        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        /******************************************* NAVIGATION BUTTONS CONTINUED ************************************/
        /******************************************* Form menu ************************************/
        // Close 'X' Button clicked
        private void button2_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Closing Launcher");
            Application.Exit();
            Properties.Settings.Default.VolumeOn = true;
        }


        // Minimize button clicked

        private void button11_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Minimizing...");
            this.WindowState = FormWindowState.Minimized;
        }






        private void button2_Click_1(object sender, EventArgs e)
        {


            if (soundenabled == true)

            {
                soundenabled = false;
                Properties.Settings.Default.VolumeOn = false;
                button2.BackgroundImage = Image.FromFile("Resources/speakerOFF.png");
                Console.WriteLine("Snound is OFF");

                Properties.Settings.Default.Save();

            }

            else
            {
                Properties.Settings.Default.VolumeOn = true;
                soundenabled = true;
                button2.BackgroundImage = Image.FromFile("Resources/speakerON.png");
                Console.WriteLine("Snound is ON");

                Properties.Settings.Default.Save();
            }

        }



        private void label1_Click(object sender, EventArgs e)
        {
            // nothing
        }












        //Settings for main graphics presets. // will need to find and check config.ini


    }
}
