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
using System.Collections.Generic;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;




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


        private StateHandler myState = new StateHandler();
        private DateTime startTime = DateTime.Now;


        SoundPlayer startupsong = new SoundPlayer("Resources/done.wav");
        SoundPlayer completesong = new SoundPlayer("Resources/start.wav");
        SoundPlayer patsoft = new SoundPlayer("Resources/patsoft.wav");
        SoundPlayer patwarnings = new SoundPlayer("Resources/patwarning.wav");
        bool soundenabled = true;
        public bool nocancel = false;
        public string manifestpath = "Cache/Manifest.txt";
        public string ziplinkspath = "Cache/ZipsManifest.txt";
        public bool LatestPathExists = (System.IO.File.Exists("Cache/Knowts.txt"));
        public string VersionURL = "https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/SplashVersion.png";
        public string KnowtsOnline = "https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/Knowts.txt";
        public string BuildOnline = "https://raw.githubusercontent.com/Simsaladoo/Winds-of-Almerra-Launcher/master/Launcher/Resources/Build.txt";
        public bool cacheisdone = false;
        public bool gameisunzipped = false;
        public string zippath = "Cache/zips/WoA_2301_0085.7z";
        public string gamepath = "Cache/Knowts.txt";
        public string engineinipath = "Game/WoA_2301/Config/DefaultEngine.ini";
        public string latestlink = String.Empty;
        public string latestbuild = String.Empty;
        public string onlinelatesthtml = String.Empty;
        public string editdirectory = @"E:/UE4/Projects";
        public string gdirectory = "Game/";
        public string gdirectoryALT = @"E:/UE4/builds/Package";
        public string cdirectory = "Cache/zips";
        public string edir = String.Empty;
        public string[] edirs = new string[] { "" };
        public string gdir = "Game/";
        public string[] gdirs = new string[] { "" };
        public int currentziplink = 1;
        public string startPath = "Cache/";
        public string zipPath = "Cache/";
        public string extractPath = "Game/";
        public string buttonuse = String.Empty;
        List<string> myButtonCollection = new List<string>();
        List<string> myAltButtonCollection = new List<string>();
        public int buttonnum = 0;
        public string VersionText = "WoA_xxxx_xxxx";
        public string ChosenBuildDefaultEngineConfig = String.Empty;
        public int TotalZips = 0;
        public int DoneZipsToSkip = 0;
        public long CacheSize = 000;
        public bool DropisDown = false;
        public bool DropareDown = false;
        public bool hasEditor = false;
        public string latestEditor = String.Empty;
        public string latestGame = String.Empty;
        public string[] AllBuilds;
        public string latestDefaultEngine = String.Empty;


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
            this.Shown += new System.EventHandler(this.AfterLoadingAsync);    // this is wher we fire BeginPlay
            Console.WriteLine("/****************************************************************/");
            Console.WriteLine("/*********************** Initialization *************************/");
            Console.WriteLine("/****************************************************************/");


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


            //  ___________            __             _________       __                    //
            //  \_   _____/___   _____/  |_  ______  /   _____/ _____/  |_ __ ________      //
            //   |    __)/  _ \ /    \   __\/  ___/  \_____  \_/ __ \   __\  |  \____ \     //
            //   |     \(  <_> )   |  \  |  \___ \   /        \  ___/|  | |  |  /  |_> >    //
            //   \___  / \____/|___|  /__| /____  > /_______  /\___  >__| |____/|   __/     //
            //       \/             \/          \/          \/     \/           |__|        //
            //                                                                              //

            // sizing of the new custom fonts
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


            play.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            CloseButton.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
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
            button5.Parent = font;
            button4.Parent = font;
            button2.Parent = font;
            font.BackgroundImage = Properties.Resources.font;
        }


        //                                                                                              //
        //              _________               __                   .___                               //
        //             /   _____/__.__. _______/  |_  ____   _____   |   | ____  ____   ____            //
        //             \_____  <   |  |/  ___/\   __\/ __ \ /     \  |   |/ ___\/  _ \ /    \           //
        //             /        \___  |\___ \  |  | \  ___/|  Y Y  \ |   \  \__(  <_> )   |  \          //
        //            /_______  / ____/____  > |__|  \___  >__|_|  / |___|\___  >____/|___|  /          //
        //                    \/\/         \/            \/      \/           \/           \/           //
        //                                                                                              //


        private void notifyIcon1_LoadCompleted(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
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


        private async void AfterLoadingAsync(object sender, EventArgs e)
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


            bool VolumeOn = (bool)Properties.Settings.Default["VolumeOn"];
            this.FormBorderStyle = FormBorderStyle.None;
            if (WindowState == FormWindowState.Minimized)
            {
                ShowIcon = false;
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

            await LookForGames();
            await LookForEditors();

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
            if (soundenabled == true)
            {
                System.Media.SoundPlayer sp = (patsoft);
                sp.Play();
            };
            // WE have teh file! start the gaame and minimize the launcher
            this.WindowState = FormWindowState.Minimized;
            Console.WriteLine("Latest Chosen Build: " + Properties.Settings.Default.ChosenBuild.ToString());
            // ensure we have the right executable
            System.Diagnostics.Process.Start(Properties.Settings.Default.ChosenBuild);                                    // play the game
        }


        //                                                                                                             //
        //              ___________    .___.__  __                 __________        __    __                          //
        //              \_   _____/  __| _/|__|/  |_  ___________  \______   \__ ___/  |__/  |_  ____   ____           //
        //               |    __)_  / __ | |  \   __\/  _ \_  __ \  |    |  _/  |  \   __\   __\/  _ \ /    \          //
        //               |        \/ /_/ | |  ||  | (  <_> )  | \/  |    |   \  |  /|  |  |  | (  <_> )   |  \         //
        //              /_______  /\____ | |__||__|  \____/|__|     |______  /____/ |__|  |__|  \____/|___|  /         //
        //                      \/      \/                                 \/                              \/          //
        //                                                                                                             //
        //                                                                                                             //
        /*******************************
            open selected editor button pressed
        /********************************/
        private void button1_Click(object sender, EventArgs e)
        {
            // button1.Enabled = false;
            Console.WriteLine("Opening Editor: " + latestEditor);
            this.WindowState = FormWindowState.Minimized;
            System.Diagnostics.Process.Start(latestEditor);
            // get which editor we have selected as our "previous engine" and use it's method to start
        }





        // update size of cache text in options for cleaning

        async Task CheckCacheSize()
        {
            await Task.Delay(1000);
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

        // get directory of all zips size

        static long GetDirectorySize(string p)
        {


            Directory.CreateDirectory(Path.Combine("Game/"));

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

            Console.WriteLine("Closing Launcher...");
            notifyIcon1.Visible = false;
            Application.Exit();
            


        }


        // Minimize button clicked

        private void button11_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Minimizing...");
            this.WindowState = FormWindowState.Minimized;
        }


        // speaker icon for sound effect on/off
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


        private void button3_Click(object sender, EventArgs e)
        {
            // ??
        }



        private void ResolutionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // res
        }



        //      ___________    .___.__  __                 ________                          .___                           //
        //      \_   _____/  __| _/|__|/  |_  ___________  \______ \_______  ____ ______   __| _/______  _  ______          //
        //       |    __)_  / __ | |  \   __\/  _ \_  __ \  |    |  \_  __ \/  _ \\____ \ / __ |/  _ \ \/ \/ /    \         //
        //       |        \/ /_/ | |  ||  | (  <_> )  | \/  |    `   \  | \(  <_> )  |_> > /_/ (  <_> )     /   |  \        //
        //      /_______  /\____ | |__||__|  \____/|__|    /_______  /__|   \____/|   __/\____ |\____/ \/\_/|___|  /        //
        //              \/      \/                                 \/             |__|        \/                 \/         //


        private void button5_Click(object sender, EventArgs e)
        {
            // dropdown
            string labelup = ("^");
            string labeldown = ("-");
            if (!DropareDown)
            {
                Console.WriteLine(DropareDown);     // open
                DropareDown = true;
                DDpanel2.Visible = true;
                button5.Text = labeldown;
            }
            else if (DropareDown)
            {
                Console.WriteLine(DropareDown);     // close
                DropareDown = false;
                DDpanel2.Visible = false;
                button5.Text = labelup;
            }
        }




        // Dropdown button for editor selector

        private void button4_Click(object sender, EventArgs e)
        {
            // dropdown
            string labelup = ("^");
            string labeldown = ("-");

            if (!DropisDown)
            {
                // open
                Console.WriteLine(DropisDown);
                DropisDown = true;
                DDpanel1.Visible = true;
                button4.Text = labeldown;
            }



            else if (DropisDown)
            {
                // close
                Console.WriteLine(DropisDown);
                DropisDown = false;
                DDpanel1.Visible = false;
                button4.Text = labelup;
            }
        }






        //                                                                                                                                              //
        //    _________                           ___________    .___.__  __                 __________        __    __                                 //
        //   /   _____/__________ __  _  ______   \_   _____/  __| _/|__|/  |_  ___________  \______   \__ ___/  |__/  |_  ____   ____   ______         //
        //   \_____  \\____ \__  \\ \/ \/ /    \   |    __)_  / __ | |  \   __\/  _ \_  __ \  |    |  _/  |  \   __\   __\/  _ \ /    \ /  ___/         //
        //   /        \  |_> > __ \\     /   |  \  |        \/ /_/ | |  ||  | (  <_> )  | \/  |    |   \  |  /|  |  |  | (  <_> )   |  \\___ \          //
        //  /_______  /   __(____  /\/\_/|___|  / /_______  /\____ | |__||__|  \____/|__|     |______  /____/ |__|  |__|  \____/|___|  /____  >         //
        //          \/|__|       \/           \/          \/      \/                                 \/                              \/     \/          //
        //                                                                                                                                              //




        private void CreateEditorButton(int a, string p, string s)
        {

            Button newButton = new Button();       // make el buttono

            int o = a * 40;
            o = o - 40;// calc a row

            newButton.ForeColor = Color.White;
            newButton.Font = myFont12;
            newButton.Text = p.ToString();
            newButton.Location = new Point(0, o);
            newButton.Size = new Size(198, 40);
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.FlatAppearance.BorderSize = 0;
            newButton.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            newButton.BackColor = Color.Transparent;

            newButton.Click += (sender, e) => ClickedEditorButtons(s, p);
            DDpanel1.Controls.Add(newButton);
            //Console.WriteLine("Created Editor button: " + p + " for " + s);
        }




        private void CreateGameButton(int a, string p, string s)
        {

            Button newButton2 = new Button();

            int o = a * 40;
            o = o - 40;

            newButton2.ForeColor = Color.White;
            newButton2.Font = myFont12;
            newButton2.Text = p.ToString();
            newButton2.Location = new Point(0, o);
            newButton2.Size = new Size(198, 40);
            newButton2.FlatStyle = FlatStyle.Flat;
            newButton2.FlatAppearance.BorderSize = 0;
            newButton2.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            newButton2.BackColor = Color.Transparent;

            newButton2.Click += (sender, e) => ClickedGameButtons(s, p);
            DDpanel2.Controls.Add(newButton2);
            //Console.WriteLine("Created Game button: " + p + " for " + s);
        }










        private void ClickedEditorButtons(string p, string s)
        {
            // select editor in slot

            //get a nicer looking name for button by splitting and trimming...
            var dataspt = s.Substring(s.LastIndexOf('_') + 1);
            string data = dataspt.ToString();
            int index = dataspt.IndexOf('.');
            string sub;
            sub = dataspt.Substring(0, index);
            // sub is nice looking name

            Console.WriteLine("Selected Editor: " + p);
            Properties.Settings.Default.ChosenEditor = p;
            button1.Text = sub;
            latestEditor = Path.GetFullPath(p);
            DDpanel1.Visible = false;
            DropisDown = false;
            button4.Text = ("^");
            // is 'assign' editor
        }


        private void ClickedGameButtons(string p, string s)
        {
            // select game in slot

            //get a nicer looking name for button by splitting and trimming...
            var dataspt = s.Substring(s.LastIndexOf('_') + 1);
            string data = dataspt.ToString();
            int index = dataspt.IndexOf('.');
            string sub;
            sub = dataspt.Substring(0, index);
            // sub is nice looking name

            Console.WriteLine("Selected : " + p);
            Properties.Settings.Default.ChosenBuild = p;
            play.Text = sub;
            latestGame = Path.GetFullPath(p);
            DDpanel2.Visible = false;
            DropareDown = false;
            button5.Text = ("^");
            // is 'assign' game
        }






        

        



        // Search for packaged Games

        async Task LookForGames()
        {
            int i = 0;
            await Task.Delay(500);
            progressBar0.Value = 25;
            string gletsdothis = gdir;
            string gabsolute = String.Empty;
            UpdateLauncherVersionAsync("Looking for packaged games...");
            Console.WriteLine("Looking for packaged games...");

            string[] gdirs = Directory.GetFiles(extractPath, "*Tailwind_1501.exe*", SearchOption.AllDirectories);           // first pass looks thru Launcher's /Game/ folder for packaged games


            foreach (string gdir in gdirs)
            {
                // Console.WriteLine(dir);
                if (gdir != null)
                {
                    int count = edir.Count(a => a == '\\');

                    if (count < 5)
                    {
                        i++;
                        gletsdothis = gdir;
                        gabsolute = Path.GetFullPath(gletsdothis);
                        Console.WriteLine(gabsolute + ", Found game executable at index " + i);
                        string gthispath = Path.GetFileName(gabsolute);

                        gameisunzipped = true;

                        CreateGameButton(i, gthispath, gabsolute); // pass arguments to event that creates the button
                        myAltButtonCollection.Add(gabsolute);
                        // found path added to array for buttons
                    }

                    AllBuilds = gdirs;
                    Console.WriteLine(gabsolute + ", Set as latest game executable ");
                    gletsdothis = gdir;
                    // absolute = Path.GetFullPath(letsdothis);
                }
            }
            //gdir = gabsolute;
            //latestGame = gabsolute;
            Properties.Settings.Default.ChosenBuild = gabsolute;
            await Task.Delay(500);


            // we didnt find anything in the /Game/ folder -- now look in our local area for builds
            if (gdir == String.Empty)
            {

                if (Directory.Exists(gdirectoryALT))
                {

                    Console.WriteLine("gdir string is empty -- No packaged games found...");
                    UpdateLauncherVersionAsync("Looking for built games...");
                    Console.WriteLine("Now looking for built games in alt directory: " + gdirectoryALT);
                    await Task.Delay(500);


                    gdirs = Directory.GetFiles(gdirectoryALT, "*Tailwind_1501.exe*", SearchOption.AllDirectories);
                    foreach (string gdir in gdirs)
                    {
                        if (gdir != null)
                        {
                            int count = gdir.Count(a => a == '\\');
                            if (count < 5)
                            {
                                i++;
                                // this is teh one                      
                                gameisunzipped = true;
                                gletsdothis = gdir;
                                gabsolute = Path.GetFullPath(gletsdothis);
                                Console.WriteLine(gabsolute + ", Found built game executable ");
                                string gthispath = Path.GetFileName(gabsolute);

                                CreateGameButton(i, gthispath, gabsolute); // pass arguments to event that creates the button
                                myAltButtonCollection.Add(gabsolute);
                                // found path added to array for buttons
                            }


                        }
                    }
                }

                AllBuilds = gdirs;
                Console.WriteLine("Total built games found: " + myAltButtonCollection.Count);
                gdir = gabsolute;
                latestGame = gabsolute;
                // latestbuild = gabsolute;
                Console.WriteLine("Game Build path result: " + Properties.Settings.Default.ChosenBuild);

            }

            
            await TurnGameButtonToLast();
        }






        // Search for Editors

        async Task LookForEditors()
        {
            int i = 0;
            await Task.Delay(500);
            progressBar0.Value = 50;
            Console.WriteLine("Looking for Editor Drives...");
            string eletsdothis = edir;
            string eabsolute = String.Empty;
            string drive = Path.GetPathRoot(editdirectory);
            UpdateLauncherVersionAsync("Looking for Editor Drives...");
            if (!Directory.Exists(drive))                                                 // client launcher
            {
                Console.WriteLine("No "+ drive + " found, using client path");
                await RemoveEditorButton();
            }

            else if (Directory.Exists(drive))                                                      // Sim's Lab machine only route
            {
                string[] edirs = Directory.GetFiles(editdirectory, "*.uproject*", SearchOption.AllDirectories);
                foreach (string edir in edirs)
                {
                    // Console.WriteLine(edir);
                    if (edir != null)
                    {
                        int count = edir.Count(a => a == '\\');

                        if (count < 5)
                        {
                            i++;
                            eletsdothis = edir;
                            eabsolute = Path.GetFullPath(eletsdothis);
                            Console.WriteLine(eabsolute + ", found uproject at index: " + i);
                            string thispath = Path.GetFileName(eabsolute);
                            hasEditor = true;

                            CreateEditorButton(i, thispath, eabsolute); // pass arguments to event that creates the button
                            myButtonCollection.Add(eabsolute);
                            // found path added to array for buttons
                        }
                    }
                }
                Console.WriteLine("Total Editor projects found: " + myButtonCollection.Count);
                edir = eabsolute;
                latestEditor = eabsolute;

                Properties.Settings.Default.ChosenEditor = edirs[0];

                Console.WriteLine("Editor path result: " + Properties.Settings.Default.ChosenEditor);

                await TurnEditorButtonToLast();
            }
            


        }







        // update game button to label of current setting where we store the value -- display current game build in label
        async Task TurnGameButtonToLast()
        {
            
            await Task.Delay(500);
            //get a nicer looking name by splitting and trimming...

            string prepresub = Path.GetFileName(Path.GetDirectoryName(Properties.Settings.Default.ChosenBuild));
            string gsub = prepresub.Substring(prepresub.IndexOf('_') + 1); ;
            Console.WriteLine("Setting Game Button to Last: " + gsub);
            play.Text = gsub;         
            play.Enabled = true;
            button5.Enabled = true;
            await FindPackageConfigs();
            await Popupdisshit(gsub, "Setting Game Button to Last: ");
        }





        // update editor button to label of current setting where we store the value -- display current Editor engine in label
        async Task TurnEditorButtonToLast()
        {

            await Task.Delay(500);
            progressBar0.Value = 100;

            //check if we even have one first!

            //get a nicer looking name by splitting and trimming...
            string presub = Path.GetFileName(Path.GetDirectoryName(Properties.Settings.Default.ChosenEditor));
            string esub = presub.Substring(presub.IndexOf('_') + 1); ;
            Console.WriteLine("Setting Editor Button to chosen: " + esub);
            button1.Text = esub;          
            button1.Enabled = true;
            button4.Enabled = true;

            await Popupdisshit(esub, "Current Engine: ");


        }



        async Task RemoveEditorButton()
        {
            await Task.Delay(500);
            progressBar0.Value = 100;

            // no editor drive paths found so just remove the button

            Console.WriteLine("Setting Editor Button to off");
            button1.Text = "Off";
            button1.Enabled = false;
            button4.Enabled = false;

            button1.Visible = false;
            button4.Visible = false;


        }


        private async void AllowConfigEditsNow()
        {
            await Task.Delay(500);
            // use ChosenBuildDefaultEngineConfig as DefaultEngine.ini







        }



        private async void UpdateLauncherVersionAsync(string s)
        {
            // update launcher's game version or say otherwise
            VersionLabel.Text = s;
            await ReturnVersionLabelToNormal();
        }






        // update debug / build info text on lower right 
        async Task ReturnVersionLabelToNormal()
        {
            //
            await Task.Delay(5000);
            string sub = Path.GetFileName(Path.GetDirectoryName(Properties.Settings.Default.ChosenBuild));
            VersionLabel.Text = sub;
            
        }





        // Custom popup window that shows something

        async Task Popupdisshit(string p, string r)
        {
            // fill in other info?
            await Task.Delay(500);

            PopupNotifier popup = new PopupNotifier();
            popup.BodyColor = Color.FromArgb(0,0,0,0);
            popup.HeaderColor = Color.FromArgb(0, 0, 0, 0);
            popup.GradientPower = 000;
            popup.BorderColor = Color.FromArgb(0, 0, 0, 0); ;
            popup.TitleColor = Color.White;
            popup.ContentColor = Color.White;
            popup.ShowGrip = false;
            popup.Image = Properties.Resources.fReverseRottenLeaf;
            popup.TitleText = "Sim's Lab: Winds of Almerra";
            popup.ContentText = r + ": " + p;
            popup.Popup(); //show
            

        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Show the form when the user double clicks on the notify icon.

            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
            // Set the WindowState to normal if the form is minimized.
            else if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            // Activate the form.
            this.Activate();
        }




        // from our chosen build--find sub paths to relevant config files we need to edit in settings menu
        async Task FindPackageConfigs()
        {
            //
            await Task.Delay(1500);
            string currentthing = Properties.Settings.Default.ChosenBuild.ToString();
            string dagame = Path.GetFileName(Path.GetDirectoryName(Properties.Settings.Default.ChosenBuild));   // name of folder above tailwinds.exe
            string searchoption = currentthing;
            FileInfo fi = new FileInfo(searchoption);
            Console.WriteLine("Locating settings files for: " + searchoption);
            DirectoryInfo dir = fi.Directory;

            if (dir.Exists)
            {
                Console.WriteLine("Searching directory...");
                FileInfo[] files = dir.GetFiles("DefaultEngine*", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    latestDefaultEngine = file.ToString();
                    ChosenBuildDefaultEngineConfig = latestDefaultEngine;
                    AllowConfigEditsNow();
                }
            }



            if (!dir.Exists)
            {
                Console.WriteLine(currentthing + "ERROR! DefaultEngine.ini directory not found in game build");
            }




        }










        

    }
}
