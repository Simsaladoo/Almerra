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
        public string zippath = "Game/WoA_2301_0085.7z";
        public string gamepath = "Game/Knowts.txt";
        public string engineinipath = "Game/WoA_2301/Config/DefaultEngine.ini";
        public string latestlink = String.Empty;
        public string latestbuild = String.Empty;
        public string onlinelatesthtml = String.Empty;
        public string editdirectory = @"E:/UE4/Projects";
        public string gdirectory = "Cache/";
        public string cdirectory = "Cache/zips/";
        public string dir = String.Empty;
        public string[] dirs = new string[] { "" };
        public int currentziplink = 1;
        public string startPath = "Cache/";
        public string zipPath = "Cache/";
        public string extractPath = "Game/";
        public string VersionText = "WoA_2301_0085";
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

            Popupdisshit();
            UpdateLauncherVersion();

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

            StartGame();

        }















        

        private void button1_Click(object sender, EventArgs e)
        {

            // button1.Enabled = false;
            Console.WriteLine("Opening Editor...");
            StartEditor();


        }



        // update size of cache text in options for cleaning

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





        // get directory of all zips size

        static long GetDirectorySize(string p)
        {


            Directory.CreateDirectory(Path.Combine("Cache/"));

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



        private void StartEditor()
        {

            string letsdothis = dir;
            string absolute = String.Empty;
            Console.WriteLine("Looking for games...");
            string[] dirs = Directory.GetFiles(editdirectory, "*.uproject*", SearchOption.AllDirectories);
            Console.WriteLine(editdirectory + ", The number of files starting with W is " + dirs.Length);
            foreach (string dir in dirs)
            {
                // Console.WriteLine(dir);
                if (dir != null)
                {
                    gameisunzipped = true;
                    letsdothis = dir;
                    absolute = Path.GetFullPath(letsdothis);
                }


            }
            dir = absolute;
            Console.WriteLine("New path found: " + absolute);



            // WE have teh file! start the gaame and minimize the launcher
            this.WindowState = FormWindowState.Minimized;
            Console.WriteLine(dir);
            System.Diagnostics.Process.Start(dir);                                    // launch editor

        }


        private void StartGame()
        {
            // WE have teh file! start the gaame and minimize the launcher
            this.WindowState = FormWindowState.Minimized;
            Console.WriteLine(dir);
            System.Diagnostics.Process.Start(dir);                                    // play the game

        }


        private void LookForGames()
        {
            string letsdothis = dir;
            string absolute = String.Empty;
            Console.WriteLine("Looking for games...");
            string[] dirs = Directory.GetFiles(extractPath, "*Tailwind_1501.exe*", SearchOption.AllDirectories);
            Console.WriteLine(extractPath + ", The number of files starting with W is " + dirs.Length);
            foreach (string dir in dirs)
            {
                // Console.WriteLine(dir);
                if (dir != null)
                {
                    gameisunzipped = true;
                    letsdothis = dir;
                    absolute = Path.GetFullPath(letsdothis);
                }

                
            }
            dir = absolute;
            Console.WriteLine("New path found: " + absolute);
            LookForEditors();
        }





        private void LookForEditors()
        {
            string letsdothis = dir;
            string absolute = String.Empty;
            Console.WriteLine("Looking for games...");
            string[] dirs = Directory.GetFiles(editdirectory, "*.uproject*", SearchOption.TopDirectoryOnly);
            Console.WriteLine(editdirectory + ", The number of files starting with W is " + dirs.Length);
            foreach (string dir in dirs)
            {
                // Console.WriteLine(dir);
                if (dir != null)
                {
                    gameisunzipped = true;
                    letsdothis = dir;
                    absolute = Path.GetFullPath(letsdothis);
                }


            }
            dir = absolute;
            Console.WriteLine("New path found: " + absolute);
        }


        private void Popupdisshit()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.fReverseRottenLeaf;
            popup.TitleText = "Winds of Almerra";
            popup.ContentText = "Now running version " + latestbuild;
            popup.Popup(); //show

        }

        private void UpdateLauncherVersion()
        {
            VersionLabel.Text = VersionText;
        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Show the form when the user double clicks on the notify icon.

            // Set the WindowState to normal if the form is minimized.
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            // Activate the form.
            this.Activate();
        }




    }
}
