using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Text;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Xml;
using System.Linq;

namespace Launcher
{
    public partial class main : Form   //MetroFramework.Forms.MetroForm
    {
        public Button _Play { get { return play; } }
        public Button _button1 { get { return play; } }
        public Button _button2 { get { return play; } }

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



        //internal RichTextBox NotesBox1;

        



















        /*******************************
            this is ou main function
        /********************************/
        public main()
        {
            InitializeComponent();
            myState.changeButtonState(LauncherState.Idle, this);
            this.Shown += new System.EventHandler(this.AfterLoading);
            Console.WriteLine("main loaded");

            if (WindowState == FormWindowState.Minimized)
            {
                ShowIcon = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
                Console.WriteLine("Window State Minimized?");
            }
        }




        private void notifyIcon1_LoadCompleted(object sender, EventArgs e)

        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
            Console.WriteLine("Showing Icon In Taskbar");
        }






        /*******************************
            formater to get the bytes suffix
        /********************************/
        private static string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }
            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }

        /*******************************
            called when the window is created
        /********************************/
        private void AfterLoading(object sender, EventArgs e)
        {
            Console.WriteLine("Post Load Completed");
        }










        /******************************************* THE PLAY BUTTON ************************************/



        /*******************************
            play latest build button pressed
        /********************************/

        private void play_Click(object sender, EventArgs e)
        {
            if (myState.getLauncherState() == LauncherState.Idle)
            {
                /*      play our last build  */

                string valueString = "Closing...";
                Console.WriteLine(valueString);

                //System.Diagnostics.Process.Start( @"H:\UE4\builds\Archive\WoA_0049\Tailwind_1501.exe");
                Application.Exit();

            }
        }






        /*******************************
            start engine button pressed
        /********************************/



        private void button1_Click(object sender, EventArgs e)
        {
            
         /*     startup the engine    */

         

         string valueString = "Engine Starting";
         Console.WriteLine(valueString);


         System.Diagnostics.Process.Start(@"H:\UE4\Projects\WoA_1902\WoA_1902.uproject");

         Application.Exit();
            
        }







        /*******************************
            close button pressed
        /********************************/



        private void button2_Click(object sender, EventArgs e)
        {

            


         string valueString = "Launcher Closing";
         Console.WriteLine(valueString);

         Application.Exit();

        }











        /*******************************
            Set transparency  -- this is basically like a css section for da shit
        /********************************/
        private void main_Load(object sender, EventArgs e)
        {
            string valueString = "Main Loaded";
            Console.WriteLine(valueString);

            play.BackColor = Color.Transparent;
            
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            play.Parent = font;
            ToolsPanel.Visible = false;
            ToMainButton.Visible = false;


      
        }





        /*******************************
            handle the moving window
        /********************************/
        int mouseX, mouseY = 0;
        bool mouseDown;


        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X;
                mouseY = MousePosition.Y;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }



        /* The text box */


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string valueString = "Text Changed";
            Console.WriteLine(valueString);
        }







        /* Startup Load event */


        private void font_LoadCompleted(object sender, EventArgs e)
        {
            string valueString = "font Load Complete";
            Console.WriteLine(valueString);
        }

        private void notifyIcon1_LoadCompleted(object sender, MouseEventArgs e)
        {
            string valueString = "NotifyIcon Loaded";
            Console.WriteLine(valueString);

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {
            string valueString = "TopPanel, painted?";
            Console.WriteLine(valueString);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string valueString = "lable1 Click";
            Console.WriteLine(valueString);
        }






        /* Navigation buttons */ 




        private void ToPanelButton_Click(object sender, EventArgs e)
        {
            string valueString = "ToPanelButton clicked";
            Console.WriteLine(valueString);
            ToolsPanel.Visible = true;
            ToMainButton.Visible = true;
            ToPanelButton.Visible = false;
        }

        private void ToMainButton_Click(object sender, EventArgs e)
        {
            string valueString = "ToMainButton clicked";
            Console.WriteLine(valueString);
            ToolsPanel.Visible = false;
            ToMainButton.Visible = false;
            ToPanelButton.Visible = true;
        }





























        /* Action buttons in TOols frame */



        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing 12s...");
            richTextBox1.AppendText(Environment.NewLine + "Writing 12s clicked...");
            int x, y;
            DataTable dta = new DataTable();


            //Fake image used as initial variable, this gets set through the loop
            Bitmap testimage = new Bitmap(@"D:\test.png");







            string path = @"D:\Test";
            string searchPattern = "t*";
            DirectoryInfo di = new DirectoryInfo(path);
            DirectoryInfo[] directories = di.GetDirectories(searchPattern, SearchOption.TopDirectoryOnly);
            FileInfo[] files = di.GetFiles(searchPattern, SearchOption.TopDirectoryOnly);
            Console.WriteLine("Directories that begin with the letter \"t\" in {0}", path);
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






            foreach (FileInfo file in files)
            {
                richTextBox1.AppendText(Environment.NewLine + "Found file" + file + "... processing");

                try
                {
                    richTextBox1.AppendText(Environment.NewLine + "Found file" + file + "... processing");
                    try
                    {
                        dta.Clear();
                    }
                    catch (DataException)
                    {

                    }
                    // Loop through the images pixels -- for every pixel in width, look up every pixel in height
                    // left to right, by columns going down??? 
                    // x is actually the column, y is the row

                    for (x = 0; x < testimage.Width; x++)
                    {
                        for (y = 0; y < testimage.Height; y++)
                        {

                            // row start
                            if (y == 0)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
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
                                Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
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
                                Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
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
                                Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
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
                                Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
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
                                Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
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
                                Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
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
                                Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
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
                                Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
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
                                Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
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
                                Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
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
                                Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
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
                catch (ArgumentException)
                {
                    Console.WriteLine("Something bad happened -- file array loop");
                }



              
                //Add new rows with fake data
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


                // Below is how we take the data into csv format and output

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
                        sb.Append(row[i].ToString() + ",");
                    }

                    sb.AppendLine();
                }

                //name csv from image
                File.WriteAllText(@"D:\Test\Converted\" + file + ".csv", sb.ToString());
                richTextBox1.AppendText(Environment.NewLine + file + " Written...");
                richTextBox1.AppendText(Environment.NewLine + "... Finished Writing All CSVs!");
            }
        }































        // Test button to check output... 


        private void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Pixel Test Corners");

            // Create a Bitmap object from an image file.
            Bitmap myBitmap = new Bitmap(@"D:\test.jpg");



            // Test top corners
            Color pixelColor1 = myBitmap.GetPixel(0, 0);
            string pixelColorStringValue1 = pixelColor1.B.ToString("D3");
            Console.WriteLine("0,0" + pixelColorStringValue1);
            richTextBox1.AppendText(Environment.NewLine + "Pixel (0, 0) = " + pixelColorStringValue1);

            Color pixelColor3 = myBitmap.GetPixel(11, 0);
            string pixelColorStringValue3 = pixelColor3.B.ToString("D3");
            Console.WriteLine("11,0" + pixelColorStringValue3);
            richTextBox1.AppendText(Environment.NewLine + "Pixel (11, 0) = " + pixelColorStringValue3);


            // Test bottom corners
            Color pixelColor2 = myBitmap.GetPixel(0, 11);
            string pixelColorStringValue2 = pixelColor2.B.ToString("D3");
            Console.WriteLine("0,11" + pixelColorStringValue2);
            richTextBox1.AppendText(Environment.NewLine + "Pixel (0, 11) = " + pixelColorStringValue2);

            Color pixelColor4 = myBitmap.GetPixel(11, 11);
            string pixelColorStringValue4 = pixelColor4.B.ToString("D3");
            Console.WriteLine("11,11" + pixelColorStringValue4);
            richTextBox1.AppendText(Environment.NewLine + "Pixel (11, 11) = " + pixelColorStringValue4);

        }





        /* Unused buttons below */

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Write 64s clicked");
            richTextBox1.AppendText(Environment.NewLine + "Writing 64s clicked...");
        }
        

        private void button10_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Nothing");
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Write 128s clicked");
        }

        /* clicking on background image */

        private void font_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Background Clicked");
        }

        

    }
}




