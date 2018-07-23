using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using NAudio.Wave;
using System.Collections.Generic;


 
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
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;



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

        public static string intVar { get; set; }

        public static string X000Y000 { get; set; }
        public static string X000Y001 { get; set; }
        public static string X000Y002 { get; set; }
        public static string X000Y003 { get; set; }
        public static string X000Y004 { get; set; }
        public static string X000Y005 { get; set; }
        public static string X000Y006 { get; set; }
        public static string X000Y007 { get; set; }
        public static string X000Y008 { get; set; }
        public static string X000Y009 { get; set; }
        public static string X000Y010 { get; set; }
        public static string X000Y011 { get; set; }

        public static string X001Y000 { get; set; }
        public static string X001Y001 { get; set; }
        public static string X001Y002 { get; set; }
        public static string X001Y003 { get; set; }
        public static string X001Y004 { get; set; }
        public static string X001Y005 { get; set; }
        public static string X001Y006 { get; set; }
        public static string X001Y007 { get; set; }
        public static string X001Y008 { get; set; }
        public static string X001Y009 { get; set; }
        public static string X001Y010 { get; set; }
        public static string X001Y011 { get; set; }

        public static string X002Y000 { get; set; }
        public static string X002Y001 { get; set; }
        public static string X002Y002 { get; set; }
        public static string X002Y003 { get; set; }
        public static string X002Y004 { get; set; }
        public static string X002Y005 { get; set; }
        public static string X002Y006 { get; set; }
        public static string X002Y007 { get; set; }
        public static string X002Y008 { get; set; }
        public static string X002Y009 { get; set; }
        public static string X002Y010 { get; set; }
        public static string X002Y011 { get; set; }

        public static string X003Y000 { get; set; }
        public static string X003Y001 { get; set; }
        public static string X003Y002 { get; set; }
        public static string X003Y003 { get; set; }
        public static string X003Y004 { get; set; }
        public static string X003Y005 { get; set; }
        public static string X003Y006 { get; set; }
        public static string X003Y007 { get; set; }
        public static string X003Y008 { get; set; }
        public static string X003Y009 { get; set; }
        public static string X003Y010 { get; set; }
        public static string X003Y011 { get; set; }

        public static string X004Y000 { get; set; }
        public static string X004Y001 { get; set; }
        public static string X004Y002 { get; set; }
        public static string X004Y003 { get; set; }
        public static string X004Y004 { get; set; }
        public static string X004Y005 { get; set; }
        public static string X004Y006 { get; set; }
        public static string X004Y007 { get; set; }
        public static string X004Y008 { get; set; }
        public static string X004Y009 { get; set; }
        public static string X004Y010 { get; set; }
        public static string X004Y011 { get; set; }

        public static string X005Y000 { get; set; }
        public static string X005Y001 { get; set; }
        public static string X005Y002 { get; set; }
        public static string X005Y003 { get; set; }
        public static string X005Y004 { get; set; }
        public static string X005Y005 { get; set; }
        public static string X005Y006 { get; set; }
        public static string X005Y007 { get; set; }
        public static string X005Y008 { get; set; }
        public static string X005Y009 { get; set; }
        public static string X005Y010 { get; set; }
        public static string X005Y011 { get; set; }

        public static string X006Y000 { get; set; }
        public static string X006Y001 { get; set; }
        public static string X006Y002 { get; set; }
        public static string X006Y003 { get; set; }
        public static string X006Y004 { get; set; }
        public static string X006Y005 { get; set; }
        public static string X006Y006 { get; set; }
        public static string X006Y007 { get; set; }
        public static string X006Y008 { get; set; }
        public static string X006Y009 { get; set; }
        public static string X006Y010 { get; set; }
        public static string X006Y011 { get; set; }

        public static string X007Y000 { get; set; }
        public static string X007Y001 { get; set; }
        public static string X007Y002 { get; set; }
        public static string X007Y003 { get; set; }
        public static string X007Y004 { get; set; }
        public static string X007Y005 { get; set; }
        public static string X007Y006 { get; set; }
        public static string X007Y007 { get; set; }
        public static string X007Y008 { get; set; }
        public static string X007Y009 { get; set; }
        public static string X007Y010 { get; set; }
        public static string X007Y011 { get; set; }

        public static string X008Y000 { get; set; }
        public static string X008Y001 { get; set; }
        public static string X008Y002 { get; set; }
        public static string X008Y003 { get; set; }
        public static string X008Y004 { get; set; }
        public static string X008Y005 { get; set; }
        public static string X008Y006 { get; set; }
        public static string X008Y007 { get; set; }
        public static string X008Y008 { get; set; }
        public static string X008Y009 { get; set; }
        public static string X008Y010 { get; set; }
        public static string X008Y011 { get; set; }

        public static string X009Y000 { get; set; }
        public static string X009Y001 { get; set; }
        public static string X009Y002 { get; set; }
        public static string X009Y003 { get; set; }
        public static string X009Y004 { get; set; }
        public static string X009Y005 { get; set; }
        public static string X009Y006 { get; set; }
        public static string X009Y007 { get; set; }
        public static string X009Y008 { get; set; }
        public static string X009Y009 { get; set; }
        public static string X009Y010 { get; set; }
        public static string X009Y011 { get; set; }

        public static string X010Y000 { get; set; }
        public static string X010Y001 { get; set; }
        public static string X010Y002 { get; set; }
        public static string X010Y003 { get; set; }
        public static string X010Y004 { get; set; }
        public static string X010Y005 { get; set; }
        public static string X010Y006 { get; set; }
        public static string X010Y007 { get; set; }
        public static string X010Y008 { get; set; }
        public static string X010Y009 { get; set; }
        public static string X010Y010 { get; set; }
        public static string X010Y011 { get; set; }

        public static string X011Y000 { get; set; }
        public static string X011Y001 { get; set; }
        public static string X011Y002 { get; set; }
        public static string X011Y003 { get; set; }
        public static string X011Y004 { get; set; }
        public static string X011Y005 { get; set; }
        public static string X011Y006 { get; set; }
        public static string X011Y007 { get; set; }
        public static string X011Y008 { get; set; }
        public static string X011Y009 { get; set; }
        public static string X011Y010 { get; set; }
        public static string X011Y011 { get; set; }

        private StateHandler myState = new StateHandler();
        private DateTime startTime = DateTime.Now;
        SoundPlayer startupsong = new SoundPlayer("Resources/done.wav");
        SoundPlayer completesong = new SoundPlayer("Resources/start.wav");
        SoundPlayer patsoft = new SoundPlayer("Resources/patsoft.wav");
        SoundPlayer patwarnings = new SoundPlayer("Resources/patwarning.wav");
        bool soundenabled = true;

        /* Unused Settings for message box to close itself, n shit */
        //  private bool m_killHim;
        //  private bool m_threadAlive;
        //  private Thread m_killThread;
        //  private const uint GW_HWNDFIRST = 0;
        //  private const int WM_CLOSE = 0x0010;
        //  [DllImport("coredll.dll", EntryPoint = "FindWindowW", SetLastError = true)]
        //  private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

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









        /*******************************
            this is our main startup function for the program
        /********************************/
        public main()
        {
            InitializeComponent();
            //myState.changeButtonState(LauncherState.Idle, this);
            this.Shown += new System.EventHandler(this.AfterLoading);
            Console.WriteLine("main loaded");

            /////////////////////////                *Startup media                     *///////////////////////////
            //                                                                                                                          //
            //                                    _________  __                    __                                                   //
            //                                   /   _____/_/  |_ _____  _______ _/  |_  __ __ ______                                   //
            //                                   \_____  \ \   __\\__  \ \_  __ \\   __\|  |  \\____ \                                  //
            //                                   /        \ |  |   / __ \_|  | \/ |  |  |  |  /|  |_> >                                 //
            //                                  /_______  / |__|  (____  /|__|    |__|  |____/ |   __/                                  //
            //                                          \/             \/                      |__|                                     //
            //                                                                                                                          //

            
            if (WindowState == FormWindowState.Minimized)
            {
                ShowIcon = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
                Console.WriteLine("Window State Minimized?");
            }

            m_aeroEnabled = false;
            this.FormBorderStyle = FormBorderStyle.None;
            bool VolumeOn = (bool)Properties.Settings.Default["VolumeOn"];

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


     

            // var processExists = System.Diagnostics.Process.GetProcesses().Any(p => p.ProcessName.Contains("Tailwinds_1501.exe"));
            System.Diagnostics.Process[] pname = System.Diagnostics.Process.GetProcessesByName("WoALauncher.exe");
            if (pname.Length == 0)
                Console.WriteLine("No Other Consoles Running... starting up");

            else
                Console.WriteLine("Another process was found, closing...");


        }




        private void notifyIcon1_LoadCompleted(object sender, EventArgs e)

        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
            Console.WriteLine("Showing Icon In Taskbar");
        }



        /*******************************
            called AFTER the window is created
        /********************************/
        private void AfterLoading(object sender, EventArgs e)
        {
            Console.WriteLine("Post Load Completed");

        }









        /****************** Setup for Shadowing below window ***************************/


        







        /******************************************* THE PLAY GAME BUTTON ************************************/

        /*******************************
            play latest build button pressed
        /********************************/

        private void play_Click(object sender, EventArgs e)
        {

                    /*      play our last build -- first make sure its even there, if not display the messgae box */
            var gdirectory = (@"H:\UE4\Builds\Archive\WoA_0051\");
            if (soundenabled == true)
            {
                System.Media.SoundPlayer sp = (patsoft);
                sp.Play();
            };




            try
            {
                string[] dirs = Directory.GetFiles(gdirectory, "*Tailwind_1501.exe*", SearchOption.TopDirectoryOnly);
                Console.WriteLine(gdirectory + ", The number of files starting with W is " + dirs.Length);
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
            }



            catch
            {
                // it is already running 

                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "No Winds of Almerra builds were found in " + gdirectory + ", close application?";
                string caption = "Project not found!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                { Application.Exit(); }
                if (result == DialogResult.No)
                { Console.WriteLine("Ignoring error '" + caption + "'"); }

            }
     
        }




        /******************************************* THE LOAD ENGINE BUTTON ************************************/

        /*******************************
            start engine button pressed
        /********************************/

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
            




      






        /*******************************
            Set transparency  -- this is basically like a css section for button settings
        /********************************/
        private void main_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Main Window Loaded");
            play.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            CloseButton.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            button7.BackColor = Color.Transparent;
            button8.BackColor = Color.Transparent;
            button9.BackColor = Color.Transparent;
            button10.BackColor = Color.Transparent;
            MinimizeButton.BackColor = Color.Transparent;
            button12.BackColor = Color.Transparent;
            ToolsPanel.BackColor = Color.Transparent;
            ToMainButton.BackColor = Color.Transparent;
            ToPanelButton.BackColor = Color.Transparent;
            waveViewer1.Visible = false;
            ToolsPanel.Visible = false;
            ToMainButton.Visible = false;



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



        /* Any updates to richTextBox1 reenable focus so it'll scroll */
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();

        }





        /* Startup Load events */

        private void font_LoadCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Background image loaded");
        }

        private void notifyIcon1_LoadCompleted(object sender, MouseEventArgs e)
        {
            Console.WriteLine("NotifyIcon (The Taskbar Icon) Loaded");
        }
















        
        /******************************************* NAVIGATION BUTTONS ************************************/

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
            waveViewer1.Visible = false;

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
            waveViewer1.Visible = false;
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
            waveViewer1.Visible = false;
        }

   
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

























        /******************************************* TOOLS/ACTION BUTTONS ************************************/

        /* Action buttons in TOols frame */

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing 12s clicked...");
            richTextBox1.AppendText(Environment.NewLine + "Writing 12s clicked...");
            int x, y;
            DataTable dta = new DataTable();
            dta.Columns.Add(" ");
            dta.Columns.Add("Type1CellY000");
            dta.Columns.Add("Type1CellY001");
            dta.Columns.Add("Type1CellY002");
            dta.Columns.Add("Type1CellY003");
            dta.Columns.Add("Type1CellY004");
            dta.Columns.Add("Type1CellY005");
            dta.Columns.Add("Type1CellY006");
            dta.Columns.Add("Type1CellY007");
            dta.Columns.Add("Type1CellY008");
            dta.Columns.Add("Type1CellY009");
            dta.Columns.Add("Type1CellY010");
            dta.Columns.Add("Type1CellY011");
            string path = @"H:\UE4\Tailwind_R E B U I L D\Environment\World Machine 93e\PNGs\12\BMPs";
            //string altpath = @"D:\Test";
            string searchPattern = "A*";
            DirectoryInfo di = new DirectoryInfo(path);
            DirectoryInfo[] directories = di.GetDirectories(searchPattern, SearchOption.TopDirectoryOnly);
            FileInfo[] files = di.GetFiles(searchPattern, SearchOption.TopDirectoryOnly);

            Console.WriteLine("Searching for files that begin with the letter \"A\" in {0}", path);
            richTextBox1.AppendText(Environment.NewLine + "Searching for files that begin with the letter A in " + path);
            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();


            // loop through the directory for files and begin processing
            foreach (FileInfo file in files)
            {
                try
                {
                    Console.WriteLine("Found file " + file);
                    string readfilepath = (path + "/" + file);
                    Console.WriteLine("Current file to process: " + readfilepath);
                    Bitmap testimage = new Bitmap(readfilepath);
                    Console.WriteLine(file + " ... clearing previous data from variables... ");
                    //richTextBox1.AppendText(Environment.NewLine + file + " ... clearing previous data from variables... ");
                    try
                    {
                        dta.Clear();
                    }
                    catch (DataException)
                    {

                    }
                    Console.WriteLine(file + " ... processing ...");
                    // richTextBox1.AppendText(Environment.NewLine + file + " ... processing ...");
                    // richTextBox1.Focus();
                    // richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    // richTextBox1.ScrollToCaret();



                    /******************************************* IMAGE PROCESSING LOOP ************************************/

                    // x++ increment through all pixels
                    for (x = 0; x < testimage.Width; x++)
                    {
                        for (y = 0; y < testimage.Height; y++)
                        {
                            //This is where we setup ALL that data into a Row.  
                            // row start
                            if (y == 0)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { X000Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { X000Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { X000Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { X000Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { X000Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { X000Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { X000Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { X000Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { X000Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { X000Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { X000Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { X000Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 1)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { X001Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { X001Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { X001Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { X001Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { X001Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { X001Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { X001Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { X001Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { X001Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { X001Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { X001Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { X001Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 2)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { X002Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { X002Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { X002Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { X002Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { X002Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { X002Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { X002Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { X002Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { X002Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { X002Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { X002Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { X002Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 3)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { X003Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { X003Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { X003Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { X003Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { X003Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { X003Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { X003Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { X003Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { X003Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { X003Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { X003Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { X003Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 4)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { X004Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { X004Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { X004Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { X004Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { X004Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { X004Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { X004Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { X004Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { X004Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { X004Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { X004Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { X004Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 5)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { X005Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { X005Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { X005Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { X005Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { X005Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { X005Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { X005Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { X005Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { X005Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { X005Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { X005Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { X005Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 6)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { X006Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { X006Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { X006Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { X006Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { X006Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { X006Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { X006Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { X006Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { X006Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { X006Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { X006Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { X006Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 7)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { X007Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { X007Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { X007Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { X007Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { X007Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { X007Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { X007Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { X007Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { X007Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { X007Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { X007Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { X007Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 8)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { X008Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { X008Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { X008Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { X008Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { X008Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { X008Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { X008Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { X008Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { X008Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { X008Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { X008Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { X008Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 9)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { X009Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { X009Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { X009Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { X009Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { X009Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { X009Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { X009Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { X009Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { X009Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { X009Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { X009Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { X009Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 10)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { X010Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { X010Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { X010Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { X010Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { X010Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { X010Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { X010Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { X010Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { X010Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { X010Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { X010Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { X010Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 11)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { X011Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { X011Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { X011Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { X011Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { X011Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { X011Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { X011Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { X011Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { X011Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { X011Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { X011Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { X011Y011 = pixelColorStringValue; }
                            }

                        }

                    }
                }

                /******************************************* PROCESSING LOOP EXCEPTIONS ************************************/
                catch (ArgumentException)
                {

                    string message = "No applicable files were found, close application?";
                    string caption = "Tools Fail!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    { Application.Exit(); }
                    if (result == DialogResult.No)
                    { Console.WriteLine("Ignoring error '" + caption + "'"); }
                    richTextBox1.AppendText(Environment.NewLine + "not applicable");
                    richTextBox1.Focus();
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.ScrollToCaret();

                }

                Console.WriteLine(file + " Adding values to data table...");
                //richTextBox1.AppendText(Environment.NewLine + file + " Adding values to data table...");
                dta.Rows.Add("cellX000", X000Y000, X000Y001, X000Y002, X000Y003, X000Y004, X000Y005, X000Y006, X000Y007, X000Y008, X000Y009, X000Y010, X000Y011);
                dta.Rows.Add("cellX001", X001Y000, X001Y001, X001Y002, X001Y003, X001Y004, X001Y005, X001Y006, X001Y007, X001Y008, X001Y009, X001Y010, X001Y011);
                dta.Rows.Add("cellX002", X002Y000, X002Y001, X002Y002, X002Y003, X002Y004, X002Y005, X002Y006, X002Y007, X002Y008, X002Y009, X002Y010, X002Y011);
                dta.Rows.Add("cellX003", X003Y000, X003Y001, X003Y002, X003Y003, X003Y004, X003Y005, X003Y006, X003Y007, X003Y008, X003Y009, X003Y010, X003Y011);
                dta.Rows.Add("cellX004", X004Y000, X004Y001, X004Y002, X004Y003, X004Y004, X004Y005, X004Y006, X004Y007, X004Y008, X004Y009, X004Y010, X004Y011);
                dta.Rows.Add("cellX005", X005Y000, X005Y001, X005Y002, X005Y003, X005Y004, X005Y005, X005Y006, X005Y007, X005Y008, X005Y009, X005Y010, X005Y011);
                dta.Rows.Add("cellX006", X006Y000, X006Y001, X006Y002, X006Y003, X006Y004, X006Y005, X006Y006, X006Y007, X006Y008, X006Y009, X006Y010, X006Y011);
                dta.Rows.Add("cellX007", X007Y000, X007Y001, X007Y002, X007Y003, X007Y004, X007Y005, X007Y006, X007Y007, X007Y008, X007Y009, X007Y010, X007Y011);
                dta.Rows.Add("cellX008", X008Y000, X008Y001, X008Y002, X008Y003, X008Y004, X008Y005, X008Y006, X008Y007, X008Y008, X008Y009, X008Y010, X008Y011);
                dta.Rows.Add("cellX009", X009Y000, X009Y001, X009Y002, X009Y003, X009Y004, X009Y005, X009Y006, X009Y007, X009Y008, X009Y009, X009Y010, X009Y011);
                dta.Rows.Add("cellX010", X010Y000, X010Y001, X010Y002, X010Y003, X010Y004, X010Y005, X010Y006, X010Y007, X010Y008, X010Y009, X010Y010, X010Y011);
                dta.Rows.Add("cellX011", X011Y000, X011Y001, X011Y002, X011Y003, X011Y004, X011Y005, X011Y006, X011Y007, X011Y008, X011Y009, X011Y010, X011Y011);

                
                StringBuilder sb = new StringBuilder();

                foreach (DataColumn col in dta.Columns)
                {
                    // In order to make a csv, we need a string data table variable to pass the info into.
                    // Here we take the column names from above and add them all--places a comma after each (hence comma separated values)
                    sb.Append(col.ColumnName + ',');

                }

                sb.Remove(sb.Length - 1, 1);
                sb.AppendLine();


                foreach (DataRow row in dta.Rows)
                {
                    // First row is all headers (done above), now we add the rows all at once using comma separators.  
                    // Uses Append line after each.  Counts by number of columns to know when to go to next line.
                    for (int i = 0; i < dta.Columns.Count; i++)
                    {

                        if (i < 12) 
                        {
                            sb.Append(row[i].ToString() + ",");
                        }

                        else
                        {
                            sb.Append(row[i].ToString());
                        }
                        
                    }

                    sb.AppendLine();
                }



                /*  Write everything to csvs */

                try
                {
                    // name csv from images, this goes off for every file converted --commented out the richtextbox updater for performance
                    File.WriteAllText(path + file + ".csv", sb.ToString());
                    // richTextBox1.AppendText(Environment.NewLine + file + " Written...");
                    // richTextBox1.Focus();
                    // richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    // richTextBox1.ScrollToCaret();
                }
                catch
                {
                    // Initializes the variables to pass to the MessageBox.Show method.
                    string message = "No valid directory for CSVs in " + path + ", close application?";
                    string caption = "CSV folder found!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    { Application.Exit(); }
                    if (result == DialogResult.No)
                    { Console.WriteLine("Ignoring error '" + caption + "'"); }
                }



                
            }

            richTextBox1.AppendText(Environment.NewLine + "... Finished Writing All CSVs!");


            // Play a little tune when we're done processing
            System.Media.SoundPlayer sp = (completesong);
            sp.Play();

            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }


        






        /* Unused buttons below */

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Write 64s clicked");
            richTextBox1.AppendText(Environment.NewLine + "Writing 64s clicked...");
            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Nothing");
        }


        // future button event for 128s

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Write 128s clicked");
            richTextBox1.AppendText(Environment.NewLine + "Writing 128s clicked...");
            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }























        // Test button to check output... 

        private void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Audio Processing...");
            richTextBox1.AppendText(Environment.NewLine + "Audio Processing...");
            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();

            // adds the wave file to the popup viewer for waveforms
            waveViewer1.Visible = true;
            var filename = ("Resources/zulu.wav");

            //chart settings
            waveViewer1.Series.Add("wave");
            waveViewer1.Series["wave"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            waveViewer1.Series["wave"].ChartArea = "ChartArea1";

            //decode and format conversion
            NAudio.Wave.WaveChannel32 wave = new NAudio.Wave.WaveChannel32(new NAudio.Wave.WaveFileReader(filename));

            //in Wavs, there are 4 bytes in every floating point number -- we can use the bit converter to translate from float to byte
            byte[] buffer = new byte[16384];
            int read = 0;

            while (wave.Position < wave.Length)
            {
                read = wave.Read(buffer, 0, 16384);

                for (int i = 0; i < read / 4; i++)
                {
                    waveViewer1.Series["wave"].Points.Add(BitConverter.ToSingle(buffer, i * 4));
                }
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {


            if (soundenabled == true)

            {
                soundenabled = false;
                Properties.Settings.Default.VolumeOn = false;
                button2.BackgroundImage = Image.FromFile("Resources/speakerOFF.png");
                Console.WriteLine("Snound is OFF");
                richTextBox1.AppendText(Environment.NewLine + "Snound is OFF");
                richTextBox1.Focus();
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
                Properties.Settings.Default.Save();

            }

            else
            {
                Properties.Settings.Default.VolumeOn = true;
                soundenabled = true;
                button2.BackgroundImage = Image.FromFile("Resources/speakerON.png");
                Console.WriteLine("Snound is ON");
                richTextBox1.AppendText(Environment.NewLine + "Snound is ON");
                richTextBox1.Focus();
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
                Properties.Settings.Default.Save();
            }

        }
    }
}




