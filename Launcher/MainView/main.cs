using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Diagnostics;
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
        public bool nocancel = false;
        string latestpath = "Cache/Knowts.txt";
        string buildpath = "Cache/Build.txt";
        public string manifestpath = "Cache/Manifest.txt";
        public string ziplinkspath = "Cache/ZipsManifest.txt";
        public bool LatestPathExists = (System.IO.File.Exists("Cache/Knowts.txt"));
        public string VersionURL = "https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/SplashVersion.png";
        public string KnowtsOnline = "https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/Knowts.txt";
        public string BuildOnline = "https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/Build.txt";
        public bool cacheisdone = false;
        public bool gameisunzipped = false;
        public string zippath = "Game/WoA_0067.zip";
        public string gamepath = "Game/Knowts.txt";
        public string engineinipath = "Game/WoA_1902/Config/DefaultEngine.ini";
        public string latestlink = String.Empty;
        public string latestbuild = String.Empty;
        public string onlinelatesthtml = String.Empty;
        public string gdirectory = "Cache/";
        public string cdirectory = "Cache/zips/";
        public string dir = String.Empty;
        public string[] dirs = new string[] { "" };
        public int currentziplink = 1;
        public string startPath = "Cache/";
        public string zipPath = "Cache/";
        public string extractPath = "Game/";
        public string VersionText = "Build" + " " + "WoA_1902_0000";
        public int TotalZips = 0;
        public int DoneZipsToSkip = 0;
        public long CacheSize = 000;


        //necessary font shit
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private PrivateFontCollection fonts = new PrivateFontCollection();
        private PrivateFontCollection fonts2 = new PrivateFontCollection();
        System.Drawing.Font myFontK12;
        System.Drawing.Font myFontK10;
        System.Drawing.Font myFont10;
        System.Drawing.Font myFont12;   // these are the various setups for the font like size, color, etc
        System.Drawing.Font myFont22;
        System.Drawing.Font myFont16;

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

            // No border around main window
            this.FormBorderStyle = FormBorderStyle.None;



            








            // embedded font shit
            byte[] fontData = Properties.Resources.MorrisRomanAlternate_Black;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.MorrisRomanAlternate_Black.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.MorrisRomanAlternate_Black.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);


            // embedded font shit 2
            byte[] fontData2 = Properties.Resources.KellyAnnGothic;
            IntPtr fontPtr2 = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData2.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData2, 0, fontPtr2, fontData2.Length);
            uint dummy2 = 1;
            fonts2.AddMemoryFont(fontPtr2, Properties.Resources.KellyAnnGothic.Length);
            AddFontMemResourceEx(fontPtr2, (uint)Properties.Resources.KellyAnnGothic.Length, IntPtr.Zero, ref dummy2);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr2);



            // sizing of the new custom font
            myFont10 = new System.Drawing.Font(fonts.Families[0], 10.0F);
            myFont12 = new System.Drawing.Font(fonts.Families[0], 12.0F);
            myFont16 = new System.Drawing.Font(fonts.Families[0], 16.0F);
            myFont22 = new System.Drawing.Font(fonts.Families[0], 22.0F);
            myFontK10 = new System.Drawing.Font(fonts2.Families[0], 12.0F);
            myFontK12 = new System.Drawing.Font(fonts2.Families[0], 20.0F);




            // big buttons Kelly Ann Gothic size 20
            play.Font = myFontK12;
            button1.Font = myFontK12;
            button12.Font = myFontK12;
            ToMainButton.Font = myFontK12;
            ToPanelButton.Font = myFontK12;
            button9.Font = myFontK12;
            button10.Font = myFontK12;
            button3.Font = myFontK12;
            CacheSizeLabel.Font = myFontK12;
            label1.Font = myFontK12;
            
            GamePageTitle.Font = myFontK12;


            // other labels Kelly Ann Gothic
            //label4.Font = myFont16;

            // misc Morris Roman ALt
            ResolutionBox.Font = myFont16;
            checkBox1_Fullscreen.Font = myFont16;
            checkBox2_Vsync.Font = myFont16;

            comboBox1_Detail.Font = myFont16;
            comboBox2_AA.Font = myFont16;
            comboBox3_Shadows.Font = myFont16;
            //comboBox4.Font = myFont16;
            Game_AALabel.Font = myFont16;
            Game_ResolutionLabel.Font = myFont16;
            Game_NoteLabel.Font = myFont10;
            Game_ShadowLabel.Font = myFont16;
            Game_DetailLabel.Font = myFont16;

            Pick_A_Label.Font = myFont16;
            Game_HeaderLabel.Font = myFont16;
            label2.Font = myFont16;


            //transparent version label
            var pos = this.PointToScreen(VersionLabel.Location);
            pos = font.PointToClient(pos);
            VersionLabel.Parent = font;
            VersionLabel.Location = pos;
            VersionLabel.BackColor = Color.Transparent;
            VersionLabel.Font = myFont12;





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
            Directory.CreateDirectory(Path.Combine("Cache"));
            Directory.CreateDirectory(Path.Combine("Cache/zips"));
            string[] lines = {
                            "Almerra Launcher Readme",
                            "",
                            "wuh, dis rEaDmE SuX lul gIt guuD"
                            };

            //create the readme file for no real reason 
            string path = "Cache/ReadMe.txt";
            var onlinelatesthtml = KnowtsOnline;
            if (!System.IO.File.Exists(path))
            {
                System.IO.File.Create(path);
                Console.WriteLine("ReadMe File Created");

            }
            else if (System.IO.File.Exists(path))
            {
                Console.WriteLine("ReadMe File Exists");
                File.WriteAllLines("Cache/ReadMe.txt", lines);

            }


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


            // launcher version from github

            UpdateLauncherVersion();

            // ... Say stuff within teh readme.




            void Main(string[] args)
            {
                string zipPath = "Cache/Zips/WoA_1902_0069.zip.000";
                string extractPath = "Game/";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
            }








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
                using (WebClient versionclient = new WebClient())
                {
                    versionclient.DownloadFileCompleted += new AsyncCompletedEventHandler(versionclient_DownloadZipsCompleted);
                    versionclient.DownloadFileAsync(new Uri(BuildOnline), "Cache/Build.txt");          // always update the version text from url

                }

                

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
                    Console.WriteLine("Knowts and Manifest are up to date"); // now confirmed, we can read the latest link
                    using (var reader = File.OpenText(manifestpath))
                    {
                        while (reader.ReadLine() != null)
                        {
                            TotalZips++;
                        }
                    }
                    CheckForZips();                    


                }
                
                else 
                {
                    play.Text = ("No Knowts");
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
            progressBar0.Visible = false;
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
            //var gdirectory = "Game/";
            //var cdirectory = "Cache/";
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
                            System.Diagnostics.Process.Start(dir);                                    // play the game
                            this.WindowState = FormWindowState.Minimized;
                        }



                        else 
                        {
                            string zipPath = "Cache/zips";
                            string extractPath = "Game/";
                            
                            try
                            {
                                // unzip that shit with the bat
                                // we dont need to specify anything for 7zip since its combined -- just need to add our relative paths for zip location as a defined path

                                string absolute = Path.GetFullPath(zipPath);
                                



                            }

                            catch (DirectoryNotFoundException dirEx)
                            {
                                Console.WriteLine("Directory not found: " + dirEx.Message);
                            }
                        }






                    }
                    else // cache not done, so download zips
                    {

                        ///              ____ ___            .___       __           __________.__                              ///
                        ///             |    |   \______   __| _/____ _/  |_  ____   \____    /|__|_____  ______                ///
                        ///             |    |   /\____ \ / __ |\__  \\   __\/ __ \    /     / |  \____ \/  ___/                ///
                        ///             |    |  / |  |_> > /_/ | / __ \|  | \  ___/   /     /_ |  |  |_> >___ \                 ///
                        ///             |______/  |   __/\____ |(____  /__|  \___  > /_______ \|__|   __/____  >                ///
                        ///                       |__|        \/     \/          \/          \/   |__|       \/                 ///


                        Console.WriteLine("Play Button found cache not completed, firing download looper...");
                        ExpDownloadLooper();
                    }
                }

                else
                {
                    //not the latest version
                    //download some shit! 
                    Console.WriteLine("Knowts is not up to date so we download new knowts");
                    progressBar0.Visible = true;
                    play.Enabled = false;
                    using (WebClient wc0 = new WebClient())
                    {
                        wc0.DownloadProgressChanged += wctext1_DownloadProgressChanged;
                        wc0.DownloadFileCompleted += new AsyncCompletedEventHandler(wctext1_DownloadKnowtsCompleted);
                        wc0.DownloadFileAsync(new System.Uri("https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/Knowts.txt"), "Cache/Knowts.txt");

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
                              progressBar0.Visible = true;
                              using (WebClient wc = new WebClient())
                              {
                                  //download some shit! 
                                  wc.DownloadProgressChanged += wctext1_DownloadProgressChanged;
                                   // event called for downlading new knowts
                                  wc.DownloadFile(new System.Uri("https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/Knowts.txt"), "Cache/Knowts.txt");
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
                        progressBar0.Visible = true;
                        using (WebClient wctext1 = new System.Net.WebClient())
                        {
                            wctext1.DownloadFileCompleted += new AsyncCompletedEventHandler(wctext1_DownloadKnowtsCompleted);
                            wctext1.DownloadFileAsync(new System.Uri("https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/Knowts.txt"), "Cache/Knowts.txt");

                        }
                        using (WebClient wctext2 = new System.Net.WebClient())
                        {
                            wctext2.DownloadFileCompleted += new AsyncCompletedEventHandler(wctext2_DownloadBuildCompleted);
                            wctext2.DownloadFileAsync(new System.Uri("https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/Build.txt"), "Cache/Build.txt");

                        }

                        using (WebClient wctext3 = new System.Net.WebClient())
                        {
                            wctext3.DownloadFileCompleted += new AsyncCompletedEventHandler(wctext3_DownloadManifestCompleted);
                            wctext3.DownloadFileAsync(new System.Uri("https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/Manifest.txt"), "Cache/Manifest.txt");

                        }
                        using (WebClient wctext4 = new System.Net.WebClient())
                        {
                            wctext4.DownloadProgressChanged += wc0_DownloadProgressChanged;
                            wctext4.DownloadFileCompleted += new AsyncCompletedEventHandler(wctext4_DownloadZipsManifestCompleted);
                            wctext4.DownloadFileAsync(new System.Uri("https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/ZipsManifest.txt"), "Cache/ZipsManifest.txt");

                        }
                        //ziplinkspath = "Game/ZipsManifest.txt";
                        //manifestpath = "Game/Manifest.txt";

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


        void versionclient_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

            string text = System.IO.File.ReadAllText("Cache/Build.txt");
            VersionLabel.Text = text;
           
            Console.WriteLine("Client Version updated...");
        }




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
            progressBar0.Visible = false;
            LatestPathExists = (System.IO.File.Exists("Cache/Build.txt"));
            //play.Text = "Get Zips";
            play.Enabled = true;
        }

        void wctext2_DownloadBuildCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            // shit
            progressBar0.Visible = false;
            LatestPathExists = (System.IO.File.Exists("Cache/Build.txt"));
            //play.Text = "Get Zips";
            play.Enabled = true;
        }
        void wctext3_DownloadManifestCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            // shit
            progressBar0.Visible = false;
            LatestPathExists = (System.IO.File.Exists("Cache/Manifest.txt"));
            //play.Text = "Get Zips";
            play.Enabled = true;
        }
        void wctext4_DownloadZipsManifestCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            // shit
            progressBar0.Visible = false;
            LatestPathExists = (System.IO.File.Exists("Cache/ZipsManifest.txt"));
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
            progressBar0.Value = e.ProgressPercentage;
            play.Text = (currentziplink.ToString() + "/1");

        }
        void wctext2_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar0.Value = e.ProgressPercentage;
            play.Text = (currentziplink.ToString() + "/1");

        }
        void wctext3_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar0.Value = e.ProgressPercentage;
            play.Text = (currentziplink.ToString() + "/1");

        }
        void wctext4_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar0.Value = e.ProgressPercentage;
            play.Text = (currentziplink.ToString() + "/1");

        }





        //      ________                      .__                    .___ __________.__         ___________                    __               //
        //      \______ \   ______  _  ______ |  |   _________     __| _/ \____    /|__|_____   \_   _____/__  __ ____   _____/  |_  ______     //
        //       |    |  \ /  _ \ \/ \/ /    \|  |  /  _ \__  \   / __ |    /     / |  \____ \   |    __)_\  \/ // __ \ /    \   __\/  ___/     //
        //       |    `   (  <_> )     /   |  \  |_(  <_> ) __ \_/ /_/ |   /     /_ |  |  |_> >  |        \\   /\  ___/|   |  \  |  \___ \      //
        //      /_______  /\____/ \/\_/|___|  /____/\____(____  /\____ |  /_______ \|__|   __/  /_______  / \_/  \___  >___|  /__| /____  >     //
        //              \/                  \/                \/      \/          \/   |__|             \/           \/     \/          \/      //
        //                                                                                                                                      //


        void wc0_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {


            float fprogress = (float)currentziplink / (float)TotalZips;
            fprogress = fprogress * 100.0f;
            int showprogress = (int)fprogress;

            //Console.WriteLine("Download Progress Changed: " + fprogress + " * 100 = " + showprogress);

            //progressBar0.Value = e.ProgressPercentage;           --  this only somewhat works for each file
            progressBar0.Value = showprogress;
            if (nocancel == true)
            {
                play.Text = ("Download");
                play.Enabled = true;
                progressBar0.Visible = false;
                button1.Visible = false;

            }

            else
            {
                play.Text = (showprogress + "%");
               
                // keeps going
            }

        }





        //  _________                       .__          __             .___ __________.__         ___________                    __            //
        //  \_   ___ \  ____   _____ ______ |  |   _____/  |_  ____   __| _/ \____    /|__|_____   \_   _____/__  __ ____   _____/  |_  ______  //
        //  /    \  \/ /  _ \ /     \\____ \|  | _/ __ \   __\/ __ \ / __ |    /     / |  \____ \   |    __)_\  \/ // __ \ /    \   __\/  ___/  //
        //  \     \___(  <_> )  Y Y  \  |_> >  |_\  ___/|  | \  ___// /_/ |   /     /_ |  |  |_> >  |        \\   /\  ___/|   |  \  |  \___ \   //
        //   \______  /\____/|__|_|  /   __/|____/\___  >__|  \___  >____ |  /_______ \|__|   __/  /_______  / \_/  \___  >___|  /__| /____  >  //
        //          \/             \/|__|             \/          \/     \/          \/   |__|             \/           \/     \/          \/   //
        //                                                                                                                                      //

        // zip file progress indicators


        void wc0_DownloadZipsCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            button3.Enabled = true;
            if (currentziplink > 1)
            {

                CheckCacheSize();
            }

            Console.WriteLine("Finished downloading zip link #" + currentziplink + " , continuing...");
            int adder = 1;
            adder = (currentziplink + 1);
            currentziplink = adder;
            

            if (currentziplink <= TotalZips)
            {
                if (nocancel == false)
                {
                    //download next in loop
                    this.ExpDownloadLooper();
                    Console.WriteLine("ExpDownladLoop continuing...");
                }

                else
                {
                    // stop the loop
                    Console.WriteLine("ExpDownladLoop stopped...");
                    button1.Enabled = true;
                    button1.Visible = false;
                    
                }

            }

            else
            {
                // done?
                Console.WriteLine("Download Complete, ExpDownladLoop stopped.");
                play.Enabled = true;
                progressBar0.Visible = false;
                cacheisdone = true;
                play.Text = "Unzip";
            }
            
        }

        
        //              ________                      .__                    .___ .____                                                     //
        //              \______ \   ______  _  ______ |  |   _________     __| _/ |    |    ____   ____ ______   ___________                //
        //               |    |  \ /  _ \ \/ \/ /    \|  |  /  _ \__  \   / __ |  |    |   /  _ \ /  _ \\____ \_/ __ \_  __ \               //
        //               |    `   (  <_> )     /   |  \  |_(  <_> ) __ \_/ /_/ |  |    |__(  <_> |  <_> )  |_> >  ___/|  | \/               //
        //              /_______  /\____/ \/\_/|___|  /____/\____(____  /\____ |  |_______ \____/ \____/|   __/ \___  >__|                  //
        //                      \/                  \/                \/      \/          \/            |__|        \/                      //
        //                                                                                                                                  //
        public void SkipDoneZips ()
        {
            currentziplink = currentziplink + DoneZipsToSkip;
        }



         public void ExpDownloadLooper()

        {
            Console.WriteLine("Downloading # " + currentziplink );

            int linetoread = currentziplink - 1;
            int linetoskip = currentziplink - 1;


            // need check for which zip is last right here, then update the current ones name



            //string newtextlabel = linetoread + "/" + TotalZips;
            //play.Text = (newtextlabel);
            play.Enabled = false;
            progressBar0.Visible = true;
            string[] zipnames = System.IO.File.ReadAllLines(manifestpath); // read all file names from the manifest of names (WoA_1902_xxxx.zip.001)
            string[] ziplinks = System.IO.File.ReadAllLines(ziplinkspath); // read all lines of http links from the zipsmanifest for download (link pathing for each .zip.0xx)

            string downloadlink = File.ReadLines(ziplinkspath).Skip(linetoread).Take(1).First(); // get specific line # relevant to that download link
            string filename = File.ReadLines(manifestpath).Skip(linetoskip).Take(1).First(); // specific download link name

            button1.Visible = true;
            nocancel = false;


            using (WebClient wc1 = new WebClient())
            {

                if (downloadlink != "")
                {
                    wc1.DownloadProgressChanged += wc0_DownloadProgressChanged; // using same update method on the progress bar
                    wc1.DownloadFileAsync(new System.Uri(downloadlink), (cdirectory + filename));
                    
                    Console.WriteLine(downloadlink + " set as wc1 with manifest " + filename + " on line " + linetoread);
                }

                wc1.DownloadFileCompleted += new AsyncCompletedEventHandler(wc0_DownloadZipsCompleted);
            }
            


        }







        //                  Cancel              //
        //                  Cancel              //
        //                  Cancel              //
        //                  Cancel              //
        //                  Cancel     ?        //
        //                  Cancel              //
        //                  Cancel              //
        //                  Cancel              //
        //                  Cancel              //


        private void button1_Click(object sender, EventArgs e)
        {
            nocancel = true;

            button1.Enabled = false;

        }


        //                  see if we have any zips              //
        //                  see if we have any zips              //
        //                  see if we have any zips              //
        //                  see if we have any zips              //
        //                  see if we have any zips     ?        //
        //                  see if we have any zips              //
        //                  see if we have any zips              //
        //                  see if we have any zips              //
        //                  see if we have any zips              //



        public void CheckForZips()
        {

            CheckCacheSize();            // convert total cache size
           
            Console.WriteLine("Checking for Zips");
            string[] zipnames = System.IO.File.ReadAllLines(manifestpath);   // all the file names
            string[] zipfilesdone = System.IO.Directory.GetFiles(cdirectory);


            foreach (string dir in zipfilesdone)
            {
                Console.WriteLine("Checking zip " + dir);       // for every file it goes up by one
                DoneZipsToSkip = DoneZipsToSkip + 1;
            }

            Console.WriteLine("Done looking for Zips... We can skip " + DoneZipsToSkip + " out of " + TotalZips);    // now we add that as an offset for where to restart downloading
            currentziplink = currentziplink + DoneZipsToSkip;                     // currentziplink permanently changed here


            if (DoneZipsToSkip == TotalZips)
            {

                Console.WriteLine("currentziplink == TotalZips");

                if (DoneZipsToSkip == TotalZips)
                {

                    cacheisdone = true;
                    Console.WriteLine("Max Zips");

                }
                
            }


            if (currentziplink < 2)
            {
                // we dont have a single one, disable the cache button in options
                button3.Enabled = false;
            }



            if (cacheisdone == true)    
            {
                Console.WriteLine("We have all the zips");
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





        public void CheckCacheSize()
        {

            CacheSize = GetDirectorySize(cdirectory);
            CacheSize = CacheSize / 1024 / 1024;       //  <-- gives you MB   (another "/ 1024" would be GB)
            long cachesizedecimal = 0;
            string showsomeshit = "okay";

            if (CacheSize > 1000)
            {

                cachesizedecimal = CacheSize - 999;
                CacheSize = CacheSize / 1024;
                CacheSizeLabel.Text = (CacheSize + "." + cachesizedecimal + " GB");
                showsomeshit = (CacheSize + "." + cachesizedecimal + " GB");
            }

            else
            {
                CacheSizeLabel.Text = (CacheSize + "." + cachesizedecimal + " MB");
                showsomeshit = (CacheSize + "." + cachesizedecimal + " MB");
            }

            Console.WriteLine("Total Cache Size is " + showsomeshit);
        }







        static long GetDirectorySize(string p)
        {


            Directory.CreateDirectory(Path.Combine("Cache/zips"));

            // Get array of all file names.
            string[] a = Directory.GetFiles(p, "*.*");

            
            // Calculate total bytes of all files in a loop.
            long b = 0;
            foreach (string name in a)
            {
                
                // Use FileInfo to get length of each file.
                FileInfo info = new FileInfo(name);
                b += info.Length;
            }
            
            // Return total size
            return b;
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
            button3.BackColor = Color.Transparent;


            button9.BackColor = Color.Transparent;
            button10.BackColor = Color.Transparent;

            MinimizeButton.BackColor = Color.Transparent;

            button12.BackColor = Color.Transparent;
            
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

            font.BackgroundImage = Properties.Resources.font;

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
            Console.WriteLine("font loaded");
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

            font.BackgroundImage = Properties.Resources.fontbLUR;

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

            font.BackgroundImage = Properties.Resources.font;

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

            font.BackgroundImage = Properties.Resources.font;

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

        private void button3_Click(object sender, EventArgs e)
        {
            // deleting all zips...


            try
            {
                System.IO.DirectoryInfo Directory = new System.IO.DirectoryInfo(cdirectory);

                System.IO.Directory.Delete(cdirectory, true);

                CacheSizeLabel.Text = ("0.0 MB");

                button3.Enabled = false;

            }

            catch
            {

                Stopwatch sw = new Stopwatch(); // sw cotructor
                sw.Start(); // starts the stopwatch
                for (int i = 0; ; i++)
                {
                    if (i % 100000 == 0) // if in 100000th iteration (could be any other large number
                                         // depending on how often you want the time to be checked) 
                    {
                        sw.Stop(); // stop the time measurement
                        if (sw.ElapsedMilliseconds > 5000) // check if desired period of time has elapsed
                        {
                             // if more than 5000 milliseconds have passed, stop looping and return
                                   // to the existing code
                            Console.WriteLine("Stopwatch stopped");
                            break;

                        }
                        else
                        {
                            sw.Start(); // if less than 5000 milliseconds have elapsed, continue looping
                                        // and resume time measurement
                        }
                    }
                }

            }


        }

        private void ResolutionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            // Show the form when the user double clicks on the notify icon.

            // Set the WindowState to normal if the form is minimized.
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            // Activate the form.
            this.Activate();
        }





        private void menuItem1_Click(object Sender, EventArgs e)
        {
            // Close the form, which closes the application.
            this.Close();
        }




        private void UpdateLauncherVersion()
        {
            using (WebClient versionclient = new WebClient())
            {
                versionclient.DownloadFileCompleted += new AsyncCompletedEventHandler(versionclient_DownloadZipsCompleted);
                versionclient.DownloadFileAsync(new Uri(BuildOnline), "Cache/Build.txt");          // always update the version text from url

            }
        }





        // https://stackoverflow.com/questions/2081827/c-sharp-get-system-network-usage
        // https://stackoverflow.com/questions/2324626/extract-a-zip-file-programmatically-by-dotnetzip-library


        //Settings for main graphics presets. // will need to find and check config.ini


    }
}
