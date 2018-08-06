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
using NAudio.MediaFoundation;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Speech.Recognition;




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
        bool mastercancel = false;

         /* 12s */

        public static string intVar { get; set; }

        public static string aX000Y000 { get; set; }
        public static string aX000Y001 { get; set; }
        public static string aX000Y002 { get; set; }
        public static string aX000Y003 { get; set; }
        public static string aX000Y004 { get; set; }
        public static string aX000Y005 { get; set; }
        public static string aX000Y006 { get; set; }
        public static string aX000Y007 { get; set; }
        public static string aX000Y008 { get; set; }
        public static string aX000Y009 { get; set; }
        public static string aX000Y010 { get; set; }
        public static string aX000Y011 { get; set; }

        public static string aX001Y000 { get; set; }
        public static string aX001Y001 { get; set; }
        public static string aX001Y002 { get; set; }
        public static string aX001Y003 { get; set; }
        public static string aX001Y004 { get; set; }
        public static string aX001Y005 { get; set; }
        public static string aX001Y006 { get; set; }
        public static string aX001Y007 { get; set; }
        public static string aX001Y008 { get; set; }
        public static string aX001Y009 { get; set; }
        public static string aX001Y010 { get; set; }
        public static string aX001Y011 { get; set; }

        public static string aX002Y000 { get; set; }
        public static string aX002Y001 { get; set; }
        public static string aX002Y002 { get; set; }
        public static string aX002Y003 { get; set; }
        public static string aX002Y004 { get; set; }
        public static string aX002Y005 { get; set; }
        public static string aX002Y006 { get; set; }
        public static string aX002Y007 { get; set; }
        public static string aX002Y008 { get; set; }
        public static string aX002Y009 { get; set; }
        public static string aX002Y010 { get; set; }
        public static string aX002Y011 { get; set; }

        public static string aX003Y000 { get; set; }
        public static string aX003Y001 { get; set; }
        public static string aX003Y002 { get; set; }
        public static string aX003Y003 { get; set; }
        public static string aX003Y004 { get; set; }
        public static string aX003Y005 { get; set; }
        public static string aX003Y006 { get; set; }
        public static string aX003Y007 { get; set; }
        public static string aX003Y008 { get; set; }
        public static string aX003Y009 { get; set; }
        public static string aX003Y010 { get; set; }
        public static string aX003Y011 { get; set; }
                             
        public static string aX004Y000 { get; set; }
        public static string aX004Y001 { get; set; }
        public static string aX004Y002 { get; set; }
        public static string aX004Y003 { get; set; }
        public static string aX004Y004 { get; set; }
        public static string aX004Y005 { get; set; }
        public static string aX004Y006 { get; set; }
        public static string aX004Y007 { get; set; }
        public static string aX004Y008 { get; set; }
        public static string aX004Y009 { get; set; }
        public static string aX004Y010 { get; set; }
        public static string aX004Y011 { get; set; }
                             
        public static string aX005Y000 { get; set; }
        public static string aX005Y001 { get; set; }
        public static string aX005Y002 { get; set; }
        public static string aX005Y003 { get; set; }
        public static string aX005Y004 { get; set; }
        public static string aX005Y005 { get; set; }
        public static string aX005Y006 { get; set; }
        public static string aX005Y007 { get; set; }
        public static string aX005Y008 { get; set; }
        public static string aX005Y009 { get; set; }
        public static string aX005Y010 { get; set; }
        public static string aX005Y011 { get; set; }
                             
        public static string aX006Y000 { get; set; }
        public static string aX006Y001 { get; set; }
        public static string aX006Y002 { get; set; }
        public static string aX006Y003 { get; set; }
        public static string aX006Y004 { get; set; }
        public static string aX006Y005 { get; set; }
        public static string aX006Y006 { get; set; }
        public static string aX006Y007 { get; set; }
        public static string aX006Y008 { get; set; }
        public static string aX006Y009 { get; set; }
        public static string aX006Y010 { get; set; }
        public static string aX006Y011 { get; set; }
                             
        public static string aX007Y000 { get; set; }
        public static string aX007Y001 { get; set; }
        public static string aX007Y002 { get; set; }
        public static string aX007Y003 { get; set; }
        public static string aX007Y004 { get; set; }
        public static string aX007Y005 { get; set; }
        public static string aX007Y006 { get; set; }
        public static string aX007Y007 { get; set; }
        public static string aX007Y008 { get; set; }
        public static string aX007Y009 { get; set; }
        public static string aX007Y010 { get; set; }
        public static string aX007Y011 { get; set; }
                             
        public static string aX008Y000 { get; set; }
        public static string aX008Y001 { get; set; }
        public static string aX008Y002 { get; set; }
        public static string aX008Y003 { get; set; }
        public static string aX008Y004 { get; set; }
        public static string aX008Y005 { get; set; }
        public static string aX008Y006 { get; set; }
        public static string aX008Y007 { get; set; }
        public static string aX008Y008 { get; set; }
        public static string aX008Y009 { get; set; }
        public static string aX008Y010 { get; set; }
        public static string aX008Y011 { get; set; }
                             
        public static string aX009Y000 { get; set; }
        public static string aX009Y001 { get; set; }
        public static string aX009Y002 { get; set; }
        public static string aX009Y003 { get; set; }
        public static string aX009Y004 { get; set; }
        public static string aX009Y005 { get; set; }
        public static string aX009Y006 { get; set; }
        public static string aX009Y007 { get; set; }
        public static string aX009Y008 { get; set; }
        public static string aX009Y009 { get; set; }
        public static string aX009Y010 { get; set; }
        public static string aX009Y011 { get; set; }
                             
        public static string aX010Y000 { get; set; }
        public static string aX010Y001 { get; set; }
        public static string aX010Y002 { get; set; }
        public static string aX010Y003 { get; set; }
        public static string aX010Y004 { get; set; }
        public static string aX010Y005 { get; set; }
        public static string aX010Y006 { get; set; }
        public static string aX010Y007 { get; set; }
        public static string aX010Y008 { get; set; }
        public static string aX010Y009 { get; set; }
        public static string aX010Y010 { get; set; }
        public static string aX010Y011 { get; set; }
                             
        public static string aX011Y000 { get; set; }
        public static string aX011Y001 { get; set; }
        public static string aX011Y002 { get; set; }
        public static string aX011Y003 { get; set; }
        public static string aX011Y004 { get; set; }
        public static string aX011Y005 { get; set; }
        public static string aX011Y006 { get; set; }
        public static string aX011Y007 { get; set; }
        public static string aX011Y008 { get; set; }
        public static string aX011Y009 { get; set; }
        public static string aX011Y010 { get; set; }
        public static string aX011Y011 { get; set; }

        /* 64s */


        public static string bX000Y000 { get; set; }
        public static string bX000Y001 { get; set; }
        public static string bX000Y002 { get; set; }
        public static string bX000Y003 { get; set; }
        public static string bX000Y004 { get; set; }
        public static string bX000Y005 { get; set; }
        public static string bX000Y006 { get; set; }
        public static string bX000Y007 { get; set; }
        public static string bX000Y008 { get; set; }
        public static string bX000Y009 { get; set; }
        public static string bX000Y010 { get; set; }
        public static string bX000Y011 { get; set; }
        public static string bX000Y012 { get; set; }
        public static string bX000Y013 { get; set; }
        public static string bX000Y014 { get; set; }
        public static string bX000Y015 { get; set; }
        public static string bX000Y016 { get; set; }
        public static string bX000Y017 { get; set; }
        public static string bX000Y018 { get; set; }
        public static string bX000Y019 { get; set; }
        public static string bX000Y020 { get; set; }
        public static string bX000Y021 { get; set; }
        public static string bX000Y022 { get; set; }
        public static string bX000Y023 { get; set; }
        public static string bX000Y024 { get; set; }
        public static string bX000Y025 { get; set; }
        public static string bX000Y026 { get; set; }
        public static string bX000Y027 { get; set; }
        public static string bX000Y028 { get; set; }
        public static string bX000Y029 { get; set; }
        public static string bX000Y030 { get; set; }
        public static string bX000Y031 { get; set; }
        public static string bX000Y032 { get; set; }
        public static string bX000Y033 { get; set; }
        public static string bX000Y034 { get; set; }
        public static string bX000Y035 { get; set; }
        public static string bX000Y036 { get; set; }
        public static string bX000Y037 { get; set; }
        public static string bX000Y038 { get; set; }
        public static string bX000Y039 { get; set; }
        public static string bX000Y040 { get; set; }
        public static string bX000Y041 { get; set; }
        public static string bX000Y042 { get; set; }
        public static string bX000Y043 { get; set; }
        public static string bX000Y044 { get; set; }
        public static string bX000Y045 { get; set; }
        public static string bX000Y046 { get; set; }
        public static string bX000Y047 { get; set; }
        public static string bX000Y048 { get; set; }
        public static string bX000Y049 { get; set; }
        public static string bX000Y050 { get; set; }
        public static string bX000Y051 { get; set; }
        public static string bX000Y052 { get; set; }
        public static string bX000Y053 { get; set; }
        public static string bX000Y054 { get; set; }
        public static string bX000Y055 { get; set; }
        public static string bX000Y056 { get; set; }
        public static string bX000Y057 { get; set; }
        public static string bX000Y058 { get; set; }
        public static string bX000Y059 { get; set; }
        public static string bX000Y060 { get; set; }
        public static string bX000Y061 { get; set; }
        public static string bX000Y062 { get; set; }
        public static string bX000Y063 { get; set; }
        public static string bX001Y000 { get; set; }
        public static string bX001Y001 { get; set; }
        public static string bX001Y002 { get; set; }
        public static string bX001Y003 { get; set; }
        public static string bX001Y004 { get; set; }
        public static string bX001Y005 { get; set; }
        public static string bX001Y006 { get; set; }
        public static string bX001Y007 { get; set; }
        public static string bX001Y008 { get; set; }
        public static string bX001Y009 { get; set; }
        public static string bX001Y010 { get; set; }
        public static string bX001Y011 { get; set; }
        public static string bX001Y012 { get; set; }
        public static string bX001Y013 { get; set; }
        public static string bX001Y014 { get; set; }
        public static string bX001Y015 { get; set; }
        public static string bX001Y016 { get; set; }
        public static string bX001Y017 { get; set; }
        public static string bX001Y018 { get; set; }
        public static string bX001Y019 { get; set; }
        public static string bX001Y020 { get; set; }
        public static string bX001Y021 { get; set; }
        public static string bX001Y022 { get; set; }
        public static string bX001Y023 { get; set; }
        public static string bX001Y024 { get; set; }
        public static string bX001Y025 { get; set; }
        public static string bX001Y026 { get; set; }
        public static string bX001Y027 { get; set; }
        public static string bX001Y028 { get; set; }
        public static string bX001Y029 { get; set; }
        public static string bX001Y030 { get; set; }
        public static string bX001Y031 { get; set; }
        public static string bX001Y032 { get; set; }
        public static string bX001Y033 { get; set; }
        public static string bX001Y034 { get; set; }
        public static string bX001Y035 { get; set; }
        public static string bX001Y036 { get; set; }
        public static string bX001Y037 { get; set; }
        public static string bX001Y038 { get; set; }
        public static string bX001Y039 { get; set; }
        public static string bX001Y040 { get; set; }
        public static string bX001Y041 { get; set; }
        public static string bX001Y042 { get; set; }
        public static string bX001Y043 { get; set; }
        public static string bX001Y044 { get; set; }
        public static string bX001Y045 { get; set; }
        public static string bX001Y046 { get; set; }
        public static string bX001Y047 { get; set; }
        public static string bX001Y048 { get; set; }
        public static string bX001Y049 { get; set; }
        public static string bX001Y050 { get; set; }
        public static string bX001Y051 { get; set; }
        public static string bX001Y052 { get; set; }
        public static string bX001Y053 { get; set; }
        public static string bX001Y054 { get; set; }
        public static string bX001Y055 { get; set; }
        public static string bX001Y056 { get; set; }
        public static string bX001Y057 { get; set; }
        public static string bX001Y058 { get; set; }
        public static string bX001Y059 { get; set; }
        public static string bX001Y060 { get; set; }
        public static string bX001Y061 { get; set; }
        public static string bX001Y062 { get; set; }
        public static string bX001Y063 { get; set; }
        public static string bX002Y000 { get; set; }
        public static string bX002Y001 { get; set; }
        public static string bX002Y002 { get; set; }
        public static string bX002Y003 { get; set; }
        public static string bX002Y004 { get; set; }
        public static string bX002Y005 { get; set; }
        public static string bX002Y006 { get; set; }
        public static string bX002Y007 { get; set; }
        public static string bX002Y008 { get; set; }
        public static string bX002Y009 { get; set; }
        public static string bX002Y010 { get; set; }
        public static string bX002Y011 { get; set; }
        public static string bX002Y012 { get; set; }
        public static string bX002Y013 { get; set; }
        public static string bX002Y014 { get; set; }
        public static string bX002Y015 { get; set; }
        public static string bX002Y016 { get; set; }
        public static string bX002Y017 { get; set; }
        public static string bX002Y018 { get; set; }
        public static string bX002Y019 { get; set; }
        public static string bX002Y020 { get; set; }
        public static string bX002Y021 { get; set; }
        public static string bX002Y022 { get; set; }
        public static string bX002Y023 { get; set; }
        public static string bX002Y024 { get; set; }
        public static string bX002Y025 { get; set; }
        public static string bX002Y026 { get; set; }
        public static string bX002Y027 { get; set; }
        public static string bX002Y028 { get; set; }
        public static string bX002Y029 { get; set; }
        public static string bX002Y030 { get; set; }
        public static string bX002Y031 { get; set; }
        public static string bX002Y032 { get; set; }
        public static string bX002Y033 { get; set; }
        public static string bX002Y034 { get; set; }
        public static string bX002Y035 { get; set; }
        public static string bX002Y036 { get; set; }
        public static string bX002Y037 { get; set; }
        public static string bX002Y038 { get; set; }
        public static string bX002Y039 { get; set; }
        public static string bX002Y040 { get; set; }
        public static string bX002Y041 { get; set; }
        public static string bX002Y042 { get; set; }
        public static string bX002Y043 { get; set; }
        public static string bX002Y044 { get; set; }
        public static string bX002Y045 { get; set; }
        public static string bX002Y046 { get; set; }
        public static string bX002Y047 { get; set; }
        public static string bX002Y048 { get; set; }
        public static string bX002Y049 { get; set; }
        public static string bX002Y050 { get; set; }
        public static string bX002Y051 { get; set; }
        public static string bX002Y052 { get; set; }
        public static string bX002Y053 { get; set; }
        public static string bX002Y054 { get; set; }
        public static string bX002Y055 { get; set; }
        public static string bX002Y056 { get; set; }
        public static string bX002Y057 { get; set; }
        public static string bX002Y058 { get; set; }
        public static string bX002Y059 { get; set; }
        public static string bX002Y060 { get; set; }
        public static string bX002Y061 { get; set; }
        public static string bX002Y062 { get; set; }
        public static string bX002Y063 { get; set; }
        public static string bX003Y000 { get; set; }
        public static string bX003Y001 { get; set; }
        public static string bX003Y002 { get; set; }
        public static string bX003Y003 { get; set; }
        public static string bX003Y004 { get; set; }
        public static string bX003Y005 { get; set; }
        public static string bX003Y006 { get; set; }
        public static string bX003Y007 { get; set; }
        public static string bX003Y008 { get; set; }
        public static string bX003Y009 { get; set; }
        public static string bX003Y010 { get; set; }
        public static string bX003Y011 { get; set; }
        public static string bX003Y012 { get; set; }
        public static string bX003Y013 { get; set; }
        public static string bX003Y014 { get; set; }
        public static string bX003Y015 { get; set; }
        public static string bX003Y016 { get; set; }
        public static string bX003Y017 { get; set; }
        public static string bX003Y018 { get; set; }
        public static string bX003Y019 { get; set; }
        public static string bX003Y020 { get; set; }
        public static string bX003Y021 { get; set; }
        public static string bX003Y022 { get; set; }
        public static string bX003Y023 { get; set; }
        public static string bX003Y024 { get; set; }
        public static string bX003Y025 { get; set; }
        public static string bX003Y026 { get; set; }
        public static string bX003Y027 { get; set; }
        public static string bX003Y028 { get; set; }
        public static string bX003Y029 { get; set; }
        public static string bX003Y030 { get; set; }
        public static string bX003Y031 { get; set; }
        public static string bX003Y032 { get; set; }
        public static string bX003Y033 { get; set; }
        public static string bX003Y034 { get; set; }
        public static string bX003Y035 { get; set; }
        public static string bX003Y036 { get; set; }
        public static string bX003Y037 { get; set; }
        public static string bX003Y038 { get; set; }
        public static string bX003Y039 { get; set; }
        public static string bX003Y040 { get; set; }
        public static string bX003Y041 { get; set; }
        public static string bX003Y042 { get; set; }
        public static string bX003Y043 { get; set; }
        public static string bX003Y044 { get; set; }
        public static string bX003Y045 { get; set; }
        public static string bX003Y046 { get; set; }
        public static string bX003Y047 { get; set; }
        public static string bX003Y048 { get; set; }
        public static string bX003Y049 { get; set; }
        public static string bX003Y050 { get; set; }
        public static string bX003Y051 { get; set; }
        public static string bX003Y052 { get; set; }
        public static string bX003Y053 { get; set; }
        public static string bX003Y054 { get; set; }
        public static string bX003Y055 { get; set; }
        public static string bX003Y056 { get; set; }
        public static string bX003Y057 { get; set; }
        public static string bX003Y058 { get; set; }
        public static string bX003Y059 { get; set; }
        public static string bX003Y060 { get; set; }
        public static string bX003Y061 { get; set; }
        public static string bX003Y062 { get; set; }
        public static string bX003Y063 { get; set; }
        public static string bX004Y000 { get; set; }
        public static string bX004Y001 { get; set; }
        public static string bX004Y002 { get; set; }
        public static string bX004Y003 { get; set; }
        public static string bX004Y004 { get; set; }
        public static string bX004Y005 { get; set; }
        public static string bX004Y006 { get; set; }
        public static string bX004Y007 { get; set; }
        public static string bX004Y008 { get; set; }
        public static string bX004Y009 { get; set; }
        public static string bX004Y010 { get; set; }
        public static string bX004Y011 { get; set; }
        public static string bX004Y012 { get; set; }
        public static string bX004Y013 { get; set; }
        public static string bX004Y014 { get; set; }
        public static string bX004Y015 { get; set; }
        public static string bX004Y016 { get; set; }
        public static string bX004Y017 { get; set; }
        public static string bX004Y018 { get; set; }
        public static string bX004Y019 { get; set; }
        public static string bX004Y020 { get; set; }
        public static string bX004Y021 { get; set; }
        public static string bX004Y022 { get; set; }
        public static string bX004Y023 { get; set; }
        public static string bX004Y024 { get; set; }
        public static string bX004Y025 { get; set; }
        public static string bX004Y026 { get; set; }
        public static string bX004Y027 { get; set; }
        public static string bX004Y028 { get; set; }
        public static string bX004Y029 { get; set; }
        public static string bX004Y030 { get; set; }
        public static string bX004Y031 { get; set; }
        public static string bX004Y032 { get; set; }
        public static string bX004Y033 { get; set; }
        public static string bX004Y034 { get; set; }
        public static string bX004Y035 { get; set; }
        public static string bX004Y036 { get; set; }
        public static string bX004Y037 { get; set; }
        public static string bX004Y038 { get; set; }
        public static string bX004Y039 { get; set; }
        public static string bX004Y040 { get; set; }
        public static string bX004Y041 { get; set; }
        public static string bX004Y042 { get; set; }
        public static string bX004Y043 { get; set; }
        public static string bX004Y044 { get; set; }
        public static string bX004Y045 { get; set; }
        public static string bX004Y046 { get; set; }
        public static string bX004Y047 { get; set; }
        public static string bX004Y048 { get; set; }
        public static string bX004Y049 { get; set; }
        public static string bX004Y050 { get; set; }
        public static string bX004Y051 { get; set; }
        public static string bX004Y052 { get; set; }
        public static string bX004Y053 { get; set; }
        public static string bX004Y054 { get; set; }
        public static string bX004Y055 { get; set; }
        public static string bX004Y056 { get; set; }
        public static string bX004Y057 { get; set; }
        public static string bX004Y058 { get; set; }
        public static string bX004Y059 { get; set; }
        public static string bX004Y060 { get; set; }
        public static string bX004Y061 { get; set; }
        public static string bX004Y062 { get; set; }
        public static string bX004Y063 { get; set; }
        public static string bX005Y000 { get; set; }
        public static string bX005Y001 { get; set; }
        public static string bX005Y002 { get; set; }
        public static string bX005Y003 { get; set; }
        public static string bX005Y004 { get; set; }
        public static string bX005Y005 { get; set; }
        public static string bX005Y006 { get; set; }
        public static string bX005Y007 { get; set; }
        public static string bX005Y008 { get; set; }
        public static string bX005Y009 { get; set; }
        public static string bX005Y010 { get; set; }
        public static string bX005Y011 { get; set; }
        public static string bX005Y012 { get; set; }
        public static string bX005Y013 { get; set; }
        public static string bX005Y014 { get; set; }
        public static string bX005Y015 { get; set; }
        public static string bX005Y016 { get; set; }
        public static string bX005Y017 { get; set; }
        public static string bX005Y018 { get; set; }
        public static string bX005Y019 { get; set; }
        public static string bX005Y020 { get; set; }
        public static string bX005Y021 { get; set; }
        public static string bX005Y022 { get; set; }
        public static string bX005Y023 { get; set; }
        public static string bX005Y024 { get; set; }
        public static string bX005Y025 { get; set; }
        public static string bX005Y026 { get; set; }
        public static string bX005Y027 { get; set; }
        public static string bX005Y028 { get; set; }
        public static string bX005Y029 { get; set; }
        public static string bX005Y030 { get; set; }
        public static string bX005Y031 { get; set; }
        public static string bX005Y032 { get; set; }
        public static string bX005Y033 { get; set; }
        public static string bX005Y034 { get; set; }
        public static string bX005Y035 { get; set; }
        public static string bX005Y036 { get; set; }
        public static string bX005Y037 { get; set; }
        public static string bX005Y038 { get; set; }
        public static string bX005Y039 { get; set; }
        public static string bX005Y040 { get; set; }
        public static string bX005Y041 { get; set; }
        public static string bX005Y042 { get; set; }
        public static string bX005Y043 { get; set; }
        public static string bX005Y044 { get; set; }
        public static string bX005Y045 { get; set; }
        public static string bX005Y046 { get; set; }
        public static string bX005Y047 { get; set; }
        public static string bX005Y048 { get; set; }
        public static string bX005Y049 { get; set; }
        public static string bX005Y050 { get; set; }
        public static string bX005Y051 { get; set; }
        public static string bX005Y052 { get; set; }
        public static string bX005Y053 { get; set; }
        public static string bX005Y054 { get; set; }
        public static string bX005Y055 { get; set; }
        public static string bX005Y056 { get; set; }
        public static string bX005Y057 { get; set; }
        public static string bX005Y058 { get; set; }
        public static string bX005Y059 { get; set; }
        public static string bX005Y060 { get; set; }
        public static string bX005Y061 { get; set; }
        public static string bX005Y062 { get; set; }
        public static string bX005Y063 { get; set; }
        public static string bX006Y000 { get; set; }
        public static string bX006Y001 { get; set; }
        public static string bX006Y002 { get; set; }
        public static string bX006Y003 { get; set; }
        public static string bX006Y004 { get; set; }
        public static string bX006Y005 { get; set; }
        public static string bX006Y006 { get; set; }
        public static string bX006Y007 { get; set; }
        public static string bX006Y008 { get; set; }
        public static string bX006Y009 { get; set; }
        public static string bX006Y010 { get; set; }
        public static string bX006Y011 { get; set; }
        public static string bX006Y012 { get; set; }
        public static string bX006Y013 { get; set; }
        public static string bX006Y014 { get; set; }
        public static string bX006Y015 { get; set; }
        public static string bX006Y016 { get; set; }
        public static string bX006Y017 { get; set; }
        public static string bX006Y018 { get; set; }
        public static string bX006Y019 { get; set; }
        public static string bX006Y020 { get; set; }
        public static string bX006Y021 { get; set; }
        public static string bX006Y022 { get; set; }
        public static string bX006Y023 { get; set; }
        public static string bX006Y024 { get; set; }
        public static string bX006Y025 { get; set; }
        public static string bX006Y026 { get; set; }
        public static string bX006Y027 { get; set; }
        public static string bX006Y028 { get; set; }
        public static string bX006Y029 { get; set; }
        public static string bX006Y030 { get; set; }
        public static string bX006Y031 { get; set; }
        public static string bX006Y032 { get; set; }
        public static string bX006Y033 { get; set; }
        public static string bX006Y034 { get; set; }
        public static string bX006Y035 { get; set; }
        public static string bX006Y036 { get; set; }
        public static string bX006Y037 { get; set; }
        public static string bX006Y038 { get; set; }
        public static string bX006Y039 { get; set; }
        public static string bX006Y040 { get; set; }
        public static string bX006Y041 { get; set; }
        public static string bX006Y042 { get; set; }
        public static string bX006Y043 { get; set; }
        public static string bX006Y044 { get; set; }
        public static string bX006Y045 { get; set; }
        public static string bX006Y046 { get; set; }
        public static string bX006Y047 { get; set; }
        public static string bX006Y048 { get; set; }
        public static string bX006Y049 { get; set; }
        public static string bX006Y050 { get; set; }
        public static string bX006Y051 { get; set; }
        public static string bX006Y052 { get; set; }
        public static string bX006Y053 { get; set; }
        public static string bX006Y054 { get; set; }
        public static string bX006Y055 { get; set; }
        public static string bX006Y056 { get; set; }
        public static string bX006Y057 { get; set; }
        public static string bX006Y058 { get; set; }
        public static string bX006Y059 { get; set; }
        public static string bX006Y060 { get; set; }
        public static string bX006Y061 { get; set; }
        public static string bX006Y062 { get; set; }
        public static string bX006Y063 { get; set; }
        public static string bX007Y000 { get; set; }
        public static string bX007Y001 { get; set; }
        public static string bX007Y002 { get; set; }
        public static string bX007Y003 { get; set; }
        public static string bX007Y004 { get; set; }
        public static string bX007Y005 { get; set; }
        public static string bX007Y006 { get; set; }
        public static string bX007Y007 { get; set; }
        public static string bX007Y008 { get; set; }
        public static string bX007Y009 { get; set; }
        public static string bX007Y010 { get; set; }
        public static string bX007Y011 { get; set; }
        public static string bX007Y012 { get; set; }
        public static string bX007Y013 { get; set; }
        public static string bX007Y014 { get; set; }
        public static string bX007Y015 { get; set; }
        public static string bX007Y016 { get; set; }
        public static string bX007Y017 { get; set; }
        public static string bX007Y018 { get; set; }
        public static string bX007Y019 { get; set; }
        public static string bX007Y020 { get; set; }
        public static string bX007Y021 { get; set; }
        public static string bX007Y022 { get; set; }
        public static string bX007Y023 { get; set; }
        public static string bX007Y024 { get; set; }
        public static string bX007Y025 { get; set; }
        public static string bX007Y026 { get; set; }
        public static string bX007Y027 { get; set; }
        public static string bX007Y028 { get; set; }
        public static string bX007Y029 { get; set; }
        public static string bX007Y030 { get; set; }
        public static string bX007Y031 { get; set; }
        public static string bX007Y032 { get; set; }
        public static string bX007Y033 { get; set; }
        public static string bX007Y034 { get; set; }
        public static string bX007Y035 { get; set; }
        public static string bX007Y036 { get; set; }
        public static string bX007Y037 { get; set; }
        public static string bX007Y038 { get; set; }
        public static string bX007Y039 { get; set; }
        public static string bX007Y040 { get; set; }
        public static string bX007Y041 { get; set; }
        public static string bX007Y042 { get; set; }
        public static string bX007Y043 { get; set; }
        public static string bX007Y044 { get; set; }
        public static string bX007Y045 { get; set; }
        public static string bX007Y046 { get; set; }
        public static string bX007Y047 { get; set; }
        public static string bX007Y048 { get; set; }
        public static string bX007Y049 { get; set; }
        public static string bX007Y050 { get; set; }
        public static string bX007Y051 { get; set; }
        public static string bX007Y052 { get; set; }
        public static string bX007Y053 { get; set; }
        public static string bX007Y054 { get; set; }
        public static string bX007Y055 { get; set; }
        public static string bX007Y056 { get; set; }
        public static string bX007Y057 { get; set; }
        public static string bX007Y058 { get; set; }
        public static string bX007Y059 { get; set; }
        public static string bX007Y060 { get; set; }
        public static string bX007Y061 { get; set; }
        public static string bX007Y062 { get; set; }
        public static string bX007Y063 { get; set; }
        public static string bX008Y000 { get; set; }
        public static string bX008Y001 { get; set; }
        public static string bX008Y002 { get; set; }
        public static string bX008Y003 { get; set; }
        public static string bX008Y004 { get; set; }
        public static string bX008Y005 { get; set; }
        public static string bX008Y006 { get; set; }
        public static string bX008Y007 { get; set; }
        public static string bX008Y008 { get; set; }
        public static string bX008Y009 { get; set; }
        public static string bX008Y010 { get; set; }
        public static string bX008Y011 { get; set; }
        public static string bX008Y012 { get; set; }
        public static string bX008Y013 { get; set; }
        public static string bX008Y014 { get; set; }
        public static string bX008Y015 { get; set; }
        public static string bX008Y016 { get; set; }
        public static string bX008Y017 { get; set; }
        public static string bX008Y018 { get; set; }
        public static string bX008Y019 { get; set; }
        public static string bX008Y020 { get; set; }
        public static string bX008Y021 { get; set; }
        public static string bX008Y022 { get; set; }
        public static string bX008Y023 { get; set; }
        public static string bX008Y024 { get; set; }
        public static string bX008Y025 { get; set; }
        public static string bX008Y026 { get; set; }
        public static string bX008Y027 { get; set; }
        public static string bX008Y028 { get; set; }
        public static string bX008Y029 { get; set; }
        public static string bX008Y030 { get; set; }
        public static string bX008Y031 { get; set; }
        public static string bX008Y032 { get; set; }
        public static string bX008Y033 { get; set; }
        public static string bX008Y034 { get; set; }
        public static string bX008Y035 { get; set; }
        public static string bX008Y036 { get; set; }
        public static string bX008Y037 { get; set; }
        public static string bX008Y038 { get; set; }
        public static string bX008Y039 { get; set; }
        public static string bX008Y040 { get; set; }
        public static string bX008Y041 { get; set; }
        public static string bX008Y042 { get; set; }
        public static string bX008Y043 { get; set; }
        public static string bX008Y044 { get; set; }
        public static string bX008Y045 { get; set; }
        public static string bX008Y046 { get; set; }
        public static string bX008Y047 { get; set; }
        public static string bX008Y048 { get; set; }
        public static string bX008Y049 { get; set; }
        public static string bX008Y050 { get; set; }
        public static string bX008Y051 { get; set; }
        public static string bX008Y052 { get; set; }
        public static string bX008Y053 { get; set; }
        public static string bX008Y054 { get; set; }
        public static string bX008Y055 { get; set; }
        public static string bX008Y056 { get; set; }
        public static string bX008Y057 { get; set; }
        public static string bX008Y058 { get; set; }
        public static string bX008Y059 { get; set; }
        public static string bX008Y060 { get; set; }
        public static string bX008Y061 { get; set; }
        public static string bX008Y062 { get; set; }
        public static string bX008Y063 { get; set; }
        public static string bX009Y000 { get; set; }
        public static string bX009Y001 { get; set; }
        public static string bX009Y002 { get; set; }
        public static string bX009Y003 { get; set; }
        public static string bX009Y004 { get; set; }
        public static string bX009Y005 { get; set; }
        public static string bX009Y006 { get; set; }
        public static string bX009Y007 { get; set; }
        public static string bX009Y008 { get; set; }
        public static string bX009Y009 { get; set; }
        public static string bX009Y010 { get; set; }
        public static string bX009Y011 { get; set; }
        public static string bX009Y012 { get; set; }
        public static string bX009Y013 { get; set; }
        public static string bX009Y014 { get; set; }
        public static string bX009Y015 { get; set; }
        public static string bX009Y016 { get; set; }
        public static string bX009Y017 { get; set; }
        public static string bX009Y018 { get; set; }
        public static string bX009Y019 { get; set; }
        public static string bX009Y020 { get; set; }
        public static string bX009Y021 { get; set; }
        public static string bX009Y022 { get; set; }
        public static string bX009Y023 { get; set; }
        public static string bX009Y024 { get; set; }
        public static string bX009Y025 { get; set; }
        public static string bX009Y026 { get; set; }
        public static string bX009Y027 { get; set; }
        public static string bX009Y028 { get; set; }
        public static string bX009Y029 { get; set; }
        public static string bX009Y030 { get; set; }
        public static string bX009Y031 { get; set; }
        public static string bX009Y032 { get; set; }
        public static string bX009Y033 { get; set; }
        public static string bX009Y034 { get; set; }
        public static string bX009Y035 { get; set; }
        public static string bX009Y036 { get; set; }
        public static string bX009Y037 { get; set; }
        public static string bX009Y038 { get; set; }
        public static string bX009Y039 { get; set; }
        public static string bX009Y040 { get; set; }
        public static string bX009Y041 { get; set; }
        public static string bX009Y042 { get; set; }
        public static string bX009Y043 { get; set; }
        public static string bX009Y044 { get; set; }
        public static string bX009Y045 { get; set; }
        public static string bX009Y046 { get; set; }
        public static string bX009Y047 { get; set; }
        public static string bX009Y048 { get; set; }
        public static string bX009Y049 { get; set; }
        public static string bX009Y050 { get; set; }
        public static string bX009Y051 { get; set; }
        public static string bX009Y052 { get; set; }
        public static string bX009Y053 { get; set; }
        public static string bX009Y054 { get; set; }
        public static string bX009Y055 { get; set; }
        public static string bX009Y056 { get; set; }
        public static string bX009Y057 { get; set; }
        public static string bX009Y058 { get; set; }
        public static string bX009Y059 { get; set; }
        public static string bX009Y060 { get; set; }
        public static string bX009Y061 { get; set; }
        public static string bX009Y062 { get; set; }
        public static string bX009Y063 { get; set; }
        public static string bX010Y000 { get; set; }
        public static string bX010Y001 { get; set; }
        public static string bX010Y002 { get; set; }
        public static string bX010Y003 { get; set; }
        public static string bX010Y004 { get; set; }
        public static string bX010Y005 { get; set; }
        public static string bX010Y006 { get; set; }
        public static string bX010Y007 { get; set; }
        public static string bX010Y008 { get; set; }
        public static string bX010Y009 { get; set; }
        public static string bX010Y010 { get; set; }
        public static string bX010Y011 { get; set; }
        public static string bX010Y012 { get; set; }
        public static string bX010Y013 { get; set; }
        public static string bX010Y014 { get; set; }
        public static string bX010Y015 { get; set; }
        public static string bX010Y016 { get; set; }
        public static string bX010Y017 { get; set; }
        public static string bX010Y018 { get; set; }
        public static string bX010Y019 { get; set; }
        public static string bX010Y020 { get; set; }
        public static string bX010Y021 { get; set; }
        public static string bX010Y022 { get; set; }
        public static string bX010Y023 { get; set; }
        public static string bX010Y024 { get; set; }
        public static string bX010Y025 { get; set; }
        public static string bX010Y026 { get; set; }
        public static string bX010Y027 { get; set; }
        public static string bX010Y028 { get; set; }
        public static string bX010Y029 { get; set; }
        public static string bX010Y030 { get; set; }
        public static string bX010Y031 { get; set; }
        public static string bX010Y032 { get; set; }
        public static string bX010Y033 { get; set; }
        public static string bX010Y034 { get; set; }
        public static string bX010Y035 { get; set; }
        public static string bX010Y036 { get; set; }
        public static string bX010Y037 { get; set; }
        public static string bX010Y038 { get; set; }
        public static string bX010Y039 { get; set; }
        public static string bX010Y040 { get; set; }
        public static string bX010Y041 { get; set; }
        public static string bX010Y042 { get; set; }
        public static string bX010Y043 { get; set; }
        public static string bX010Y044 { get; set; }
        public static string bX010Y045 { get; set; }
        public static string bX010Y046 { get; set; }
        public static string bX010Y047 { get; set; }
        public static string bX010Y048 { get; set; }
        public static string bX010Y049 { get; set; }
        public static string bX010Y050 { get; set; }
        public static string bX010Y051 { get; set; }
        public static string bX010Y052 { get; set; }
        public static string bX010Y053 { get; set; }
        public static string bX010Y054 { get; set; }
        public static string bX010Y055 { get; set; }
        public static string bX010Y056 { get; set; }
        public static string bX010Y057 { get; set; }
        public static string bX010Y058 { get; set; }
        public static string bX010Y059 { get; set; }
        public static string bX010Y060 { get; set; }
        public static string bX010Y061 { get; set; }
        public static string bX010Y062 { get; set; }
        public static string bX010Y063 { get; set; }
        public static string bX011Y000 { get; set; }
        public static string bX011Y001 { get; set; }
        public static string bX011Y002 { get; set; }
        public static string bX011Y003 { get; set; }
        public static string bX011Y004 { get; set; }
        public static string bX011Y005 { get; set; }
        public static string bX011Y006 { get; set; }
        public static string bX011Y007 { get; set; }
        public static string bX011Y008 { get; set; }
        public static string bX011Y009 { get; set; }
        public static string bX011Y010 { get; set; }
        public static string bX011Y011 { get; set; }
        public static string bX011Y012 { get; set; }
        public static string bX011Y013 { get; set; }
        public static string bX011Y014 { get; set; }
        public static string bX011Y015 { get; set; }
        public static string bX011Y016 { get; set; }
        public static string bX011Y017 { get; set; }
        public static string bX011Y018 { get; set; }
        public static string bX011Y019 { get; set; }
        public static string bX011Y020 { get; set; }
        public static string bX011Y021 { get; set; }
        public static string bX011Y022 { get; set; }
        public static string bX011Y023 { get; set; }
        public static string bX011Y024 { get; set; }
        public static string bX011Y025 { get; set; }
        public static string bX011Y026 { get; set; }
        public static string bX011Y027 { get; set; }
        public static string bX011Y028 { get; set; }
        public static string bX011Y029 { get; set; }
        public static string bX011Y030 { get; set; }
        public static string bX011Y031 { get; set; }
        public static string bX011Y032 { get; set; }
        public static string bX011Y033 { get; set; }
        public static string bX011Y034 { get; set; }
        public static string bX011Y035 { get; set; }
        public static string bX011Y036 { get; set; }
        public static string bX011Y037 { get; set; }
        public static string bX011Y038 { get; set; }
        public static string bX011Y039 { get; set; }
        public static string bX011Y040 { get; set; }
        public static string bX011Y041 { get; set; }
        public static string bX011Y042 { get; set; }
        public static string bX011Y043 { get; set; }
        public static string bX011Y044 { get; set; }
        public static string bX011Y045 { get; set; }
        public static string bX011Y046 { get; set; }
        public static string bX011Y047 { get; set; }
        public static string bX011Y048 { get; set; }
        public static string bX011Y049 { get; set; }
        public static string bX011Y050 { get; set; }
        public static string bX011Y051 { get; set; }
        public static string bX011Y052 { get; set; }
        public static string bX011Y053 { get; set; }
        public static string bX011Y054 { get; set; }
        public static string bX011Y055 { get; set; }
        public static string bX011Y056 { get; set; }
        public static string bX011Y057 { get; set; }
        public static string bX011Y058 { get; set; }
        public static string bX011Y059 { get; set; }
        public static string bX011Y060 { get; set; }
        public static string bX011Y061 { get; set; }
        public static string bX011Y062 { get; set; }
        public static string bX011Y063 { get; set; }
        public static string bX012Y000 { get; set; }
        public static string bX012Y001 { get; set; }
        public static string bX012Y002 { get; set; }
        public static string bX012Y003 { get; set; }
        public static string bX012Y004 { get; set; }
        public static string bX012Y005 { get; set; }
        public static string bX012Y006 { get; set; }
        public static string bX012Y007 { get; set; }
        public static string bX012Y008 { get; set; }
        public static string bX012Y009 { get; set; }
        public static string bX012Y010 { get; set; }
        public static string bX012Y011 { get; set; }
        public static string bX012Y012 { get; set; }
        public static string bX012Y013 { get; set; }
        public static string bX012Y014 { get; set; }
        public static string bX012Y015 { get; set; }
        public static string bX012Y016 { get; set; }
        public static string bX012Y017 { get; set; }
        public static string bX012Y018 { get; set; }
        public static string bX012Y019 { get; set; }
        public static string bX012Y020 { get; set; }
        public static string bX012Y021 { get; set; }
        public static string bX012Y022 { get; set; }
        public static string bX012Y023 { get; set; }
        public static string bX012Y024 { get; set; }
        public static string bX012Y025 { get; set; }
        public static string bX012Y026 { get; set; }
        public static string bX012Y027 { get; set; }
        public static string bX012Y028 { get; set; }
        public static string bX012Y029 { get; set; }
        public static string bX012Y030 { get; set; }
        public static string bX012Y031 { get; set; }
        public static string bX012Y032 { get; set; }
        public static string bX012Y033 { get; set; }
        public static string bX012Y034 { get; set; }
        public static string bX012Y035 { get; set; }
        public static string bX012Y036 { get; set; }
        public static string bX012Y037 { get; set; }
        public static string bX012Y038 { get; set; }
        public static string bX012Y039 { get; set; }
        public static string bX012Y040 { get; set; }
        public static string bX012Y041 { get; set; }
        public static string bX012Y042 { get; set; }
        public static string bX012Y043 { get; set; }
        public static string bX012Y044 { get; set; }
        public static string bX012Y045 { get; set; }
        public static string bX012Y046 { get; set; }
        public static string bX012Y047 { get; set; }
        public static string bX012Y048 { get; set; }
        public static string bX012Y049 { get; set; }
        public static string bX012Y050 { get; set; }
        public static string bX012Y051 { get; set; }
        public static string bX012Y052 { get; set; }
        public static string bX012Y053 { get; set; }
        public static string bX012Y054 { get; set; }
        public static string bX012Y055 { get; set; }
        public static string bX012Y056 { get; set; }
        public static string bX012Y057 { get; set; }
        public static string bX012Y058 { get; set; }
        public static string bX012Y059 { get; set; }
        public static string bX012Y060 { get; set; }
        public static string bX012Y061 { get; set; }
        public static string bX012Y062 { get; set; }
        public static string bX012Y063 { get; set; }
        public static string bX013Y000 { get; set; }
        public static string bX013Y001 { get; set; }
        public static string bX013Y002 { get; set; }
        public static string bX013Y003 { get; set; }
        public static string bX013Y004 { get; set; }
        public static string bX013Y005 { get; set; }
        public static string bX013Y006 { get; set; }
        public static string bX013Y007 { get; set; }
        public static string bX013Y008 { get; set; }
        public static string bX013Y009 { get; set; }
        public static string bX013Y010 { get; set; }
        public static string bX013Y011 { get; set; }
        public static string bX013Y012 { get; set; }
        public static string bX013Y013 { get; set; }
        public static string bX013Y014 { get; set; }
        public static string bX013Y015 { get; set; }
        public static string bX013Y016 { get; set; }
        public static string bX013Y017 { get; set; }
        public static string bX013Y018 { get; set; }
        public static string bX013Y019 { get; set; }
        public static string bX013Y020 { get; set; }
        public static string bX013Y021 { get; set; }
        public static string bX013Y022 { get; set; }
        public static string bX013Y023 { get; set; }
        public static string bX013Y024 { get; set; }
        public static string bX013Y025 { get; set; }
        public static string bX013Y026 { get; set; }
        public static string bX013Y027 { get; set; }
        public static string bX013Y028 { get; set; }
        public static string bX013Y029 { get; set; }
        public static string bX013Y030 { get; set; }
        public static string bX013Y031 { get; set; }
        public static string bX013Y032 { get; set; }
        public static string bX013Y033 { get; set; }
        public static string bX013Y034 { get; set; }
        public static string bX013Y035 { get; set; }
        public static string bX013Y036 { get; set; }
        public static string bX013Y037 { get; set; }
        public static string bX013Y038 { get; set; }
        public static string bX013Y039 { get; set; }
        public static string bX013Y040 { get; set; }
        public static string bX013Y041 { get; set; }
        public static string bX013Y042 { get; set; }
        public static string bX013Y043 { get; set; }
        public static string bX013Y044 { get; set; }
        public static string bX013Y045 { get; set; }
        public static string bX013Y046 { get; set; }
        public static string bX013Y047 { get; set; }
        public static string bX013Y048 { get; set; }
        public static string bX013Y049 { get; set; }
        public static string bX013Y050 { get; set; }
        public static string bX013Y051 { get; set; }
        public static string bX013Y052 { get; set; }
        public static string bX013Y053 { get; set; }
        public static string bX013Y054 { get; set; }
        public static string bX013Y055 { get; set; }
        public static string bX013Y056 { get; set; }
        public static string bX013Y057 { get; set; }
        public static string bX013Y058 { get; set; }
        public static string bX013Y059 { get; set; }
        public static string bX013Y060 { get; set; }
        public static string bX013Y061 { get; set; }
        public static string bX013Y062 { get; set; }
        public static string bX013Y063 { get; set; }
        public static string bX014Y000 { get; set; }
        public static string bX014Y001 { get; set; }
        public static string bX014Y002 { get; set; }
        public static string bX014Y003 { get; set; }
        public static string bX014Y004 { get; set; }
        public static string bX014Y005 { get; set; }
        public static string bX014Y006 { get; set; }
        public static string bX014Y007 { get; set; }
        public static string bX014Y008 { get; set; }
        public static string bX014Y009 { get; set; }
        public static string bX014Y010 { get; set; }
        public static string bX014Y011 { get; set; }
        public static string bX014Y012 { get; set; }
        public static string bX014Y013 { get; set; }
        public static string bX014Y014 { get; set; }
        public static string bX014Y015 { get; set; }
        public static string bX014Y016 { get; set; }
        public static string bX014Y017 { get; set; }
        public static string bX014Y018 { get; set; }
        public static string bX014Y019 { get; set; }
        public static string bX014Y020 { get; set; }
        public static string bX014Y021 { get; set; }
        public static string bX014Y022 { get; set; }
        public static string bX014Y023 { get; set; }
        public static string bX014Y024 { get; set; }
        public static string bX014Y025 { get; set; }
        public static string bX014Y026 { get; set; }
        public static string bX014Y027 { get; set; }
        public static string bX014Y028 { get; set; }
        public static string bX014Y029 { get; set; }
        public static string bX014Y030 { get; set; }
        public static string bX014Y031 { get; set; }
        public static string bX014Y032 { get; set; }
        public static string bX014Y033 { get; set; }
        public static string bX014Y034 { get; set; }
        public static string bX014Y035 { get; set; }
        public static string bX014Y036 { get; set; }
        public static string bX014Y037 { get; set; }
        public static string bX014Y038 { get; set; }
        public static string bX014Y039 { get; set; }
        public static string bX014Y040 { get; set; }
        public static string bX014Y041 { get; set; }
        public static string bX014Y042 { get; set; }
        public static string bX014Y043 { get; set; }
        public static string bX014Y044 { get; set; }
        public static string bX014Y045 { get; set; }
        public static string bX014Y046 { get; set; }
        public static string bX014Y047 { get; set; }
        public static string bX014Y048 { get; set; }
        public static string bX014Y049 { get; set; }
        public static string bX014Y050 { get; set; }
        public static string bX014Y051 { get; set; }
        public static string bX014Y052 { get; set; }
        public static string bX014Y053 { get; set; }
        public static string bX014Y054 { get; set; }
        public static string bX014Y055 { get; set; }
        public static string bX014Y056 { get; set; }
        public static string bX014Y057 { get; set; }
        public static string bX014Y058 { get; set; }
        public static string bX014Y059 { get; set; }
        public static string bX014Y060 { get; set; }
        public static string bX014Y061 { get; set; }
        public static string bX014Y062 { get; set; }
        public static string bX014Y063 { get; set; }
        public static string bX015Y000 { get; set; }
        public static string bX015Y001 { get; set; }
        public static string bX015Y002 { get; set; }
        public static string bX015Y003 { get; set; }
        public static string bX015Y004 { get; set; }
        public static string bX015Y005 { get; set; }
        public static string bX015Y006 { get; set; }
        public static string bX015Y007 { get; set; }
        public static string bX015Y008 { get; set; }
        public static string bX015Y009 { get; set; }
        public static string bX015Y010 { get; set; }
        public static string bX015Y011 { get; set; }
        public static string bX015Y012 { get; set; }
        public static string bX015Y013 { get; set; }
        public static string bX015Y014 { get; set; }
        public static string bX015Y015 { get; set; }
        public static string bX015Y016 { get; set; }
        public static string bX015Y017 { get; set; }
        public static string bX015Y018 { get; set; }
        public static string bX015Y019 { get; set; }
        public static string bX015Y020 { get; set; }
        public static string bX015Y021 { get; set; }
        public static string bX015Y022 { get; set; }
        public static string bX015Y023 { get; set; }
        public static string bX015Y024 { get; set; }
        public static string bX015Y025 { get; set; }
        public static string bX015Y026 { get; set; }
        public static string bX015Y027 { get; set; }
        public static string bX015Y028 { get; set; }
        public static string bX015Y029 { get; set; }
        public static string bX015Y030 { get; set; }
        public static string bX015Y031 { get; set; }
        public static string bX015Y032 { get; set; }
        public static string bX015Y033 { get; set; }
        public static string bX015Y034 { get; set; }
        public static string bX015Y035 { get; set; }
        public static string bX015Y036 { get; set; }
        public static string bX015Y037 { get; set; }
        public static string bX015Y038 { get; set; }
        public static string bX015Y039 { get; set; }
        public static string bX015Y040 { get; set; }
        public static string bX015Y041 { get; set; }
        public static string bX015Y042 { get; set; }
        public static string bX015Y043 { get; set; }
        public static string bX015Y044 { get; set; }
        public static string bX015Y045 { get; set; }
        public static string bX015Y046 { get; set; }
        public static string bX015Y047 { get; set; }
        public static string bX015Y048 { get; set; }
        public static string bX015Y049 { get; set; }
        public static string bX015Y050 { get; set; }
        public static string bX015Y051 { get; set; }
        public static string bX015Y052 { get; set; }
        public static string bX015Y053 { get; set; }
        public static string bX015Y054 { get; set; }
        public static string bX015Y055 { get; set; }
        public static string bX015Y056 { get; set; }
        public static string bX015Y057 { get; set; }
        public static string bX015Y058 { get; set; }
        public static string bX015Y059 { get; set; }
        public static string bX015Y060 { get; set; }
        public static string bX015Y061 { get; set; }
        public static string bX015Y062 { get; set; }
        public static string bX015Y063 { get; set; }
        public static string bX016Y000 { get; set; }
        public static string bX016Y001 { get; set; }
        public static string bX016Y002 { get; set; }
        public static string bX016Y003 { get; set; }
        public static string bX016Y004 { get; set; }
        public static string bX016Y005 { get; set; }
        public static string bX016Y006 { get; set; }
        public static string bX016Y007 { get; set; }
        public static string bX016Y008 { get; set; }
        public static string bX016Y009 { get; set; }
        public static string bX016Y010 { get; set; }
        public static string bX016Y011 { get; set; }
        public static string bX016Y012 { get; set; }
        public static string bX016Y013 { get; set; }
        public static string bX016Y014 { get; set; }
        public static string bX016Y015 { get; set; }
        public static string bX016Y016 { get; set; }
        public static string bX016Y017 { get; set; }
        public static string bX016Y018 { get; set; }
        public static string bX016Y019 { get; set; }
        public static string bX016Y020 { get; set; }
        public static string bX016Y021 { get; set; }
        public static string bX016Y022 { get; set; }
        public static string bX016Y023 { get; set; }
        public static string bX016Y024 { get; set; }
        public static string bX016Y025 { get; set; }
        public static string bX016Y026 { get; set; }
        public static string bX016Y027 { get; set; }
        public static string bX016Y028 { get; set; }
        public static string bX016Y029 { get; set; }
        public static string bX016Y030 { get; set; }
        public static string bX016Y031 { get; set; }
        public static string bX016Y032 { get; set; }
        public static string bX016Y033 { get; set; }
        public static string bX016Y034 { get; set; }
        public static string bX016Y035 { get; set; }
        public static string bX016Y036 { get; set; }
        public static string bX016Y037 { get; set; }
        public static string bX016Y038 { get; set; }
        public static string bX016Y039 { get; set; }
        public static string bX016Y040 { get; set; }
        public static string bX016Y041 { get; set; }
        public static string bX016Y042 { get; set; }
        public static string bX016Y043 { get; set; }
        public static string bX016Y044 { get; set; }
        public static string bX016Y045 { get; set; }
        public static string bX016Y046 { get; set; }
        public static string bX016Y047 { get; set; }
        public static string bX016Y048 { get; set; }
        public static string bX016Y049 { get; set; }
        public static string bX016Y050 { get; set; }
        public static string bX016Y051 { get; set; }
        public static string bX016Y052 { get; set; }
        public static string bX016Y053 { get; set; }
        public static string bX016Y054 { get; set; }
        public static string bX016Y055 { get; set; }
        public static string bX016Y056 { get; set; }
        public static string bX016Y057 { get; set; }
        public static string bX016Y058 { get; set; }
        public static string bX016Y059 { get; set; }
        public static string bX016Y060 { get; set; }
        public static string bX016Y061 { get; set; }
        public static string bX016Y062 { get; set; }
        public static string bX016Y063 { get; set; }
        public static string bX017Y000 { get; set; }
        public static string bX017Y001 { get; set; }
        public static string bX017Y002 { get; set; }
        public static string bX017Y003 { get; set; }
        public static string bX017Y004 { get; set; }
        public static string bX017Y005 { get; set; }
        public static string bX017Y006 { get; set; }
        public static string bX017Y007 { get; set; }
        public static string bX017Y008 { get; set; }
        public static string bX017Y009 { get; set; }
        public static string bX017Y010 { get; set; }
        public static string bX017Y011 { get; set; }
        public static string bX017Y012 { get; set; }
        public static string bX017Y013 { get; set; }
        public static string bX017Y014 { get; set; }
        public static string bX017Y015 { get; set; }
        public static string bX017Y016 { get; set; }
        public static string bX017Y017 { get; set; }
        public static string bX017Y018 { get; set; }
        public static string bX017Y019 { get; set; }
        public static string bX017Y020 { get; set; }
        public static string bX017Y021 { get; set; }
        public static string bX017Y022 { get; set; }
        public static string bX017Y023 { get; set; }
        public static string bX017Y024 { get; set; }
        public static string bX017Y025 { get; set; }
        public static string bX017Y026 { get; set; }
        public static string bX017Y027 { get; set; }
        public static string bX017Y028 { get; set; }
        public static string bX017Y029 { get; set; }
        public static string bX017Y030 { get; set; }
        public static string bX017Y031 { get; set; }
        public static string bX017Y032 { get; set; }
        public static string bX017Y033 { get; set; }
        public static string bX017Y034 { get; set; }
        public static string bX017Y035 { get; set; }
        public static string bX017Y036 { get; set; }
        public static string bX017Y037 { get; set; }
        public static string bX017Y038 { get; set; }
        public static string bX017Y039 { get; set; }
        public static string bX017Y040 { get; set; }
        public static string bX017Y041 { get; set; }
        public static string bX017Y042 { get; set; }
        public static string bX017Y043 { get; set; }
        public static string bX017Y044 { get; set; }
        public static string bX017Y045 { get; set; }
        public static string bX017Y046 { get; set; }
        public static string bX017Y047 { get; set; }
        public static string bX017Y048 { get; set; }
        public static string bX017Y049 { get; set; }
        public static string bX017Y050 { get; set; }
        public static string bX017Y051 { get; set; }
        public static string bX017Y052 { get; set; }
        public static string bX017Y053 { get; set; }
        public static string bX017Y054 { get; set; }
        public static string bX017Y055 { get; set; }
        public static string bX017Y056 { get; set; }
        public static string bX017Y057 { get; set; }
        public static string bX017Y058 { get; set; }
        public static string bX017Y059 { get; set; }
        public static string bX017Y060 { get; set; }
        public static string bX017Y061 { get; set; }
        public static string bX017Y062 { get; set; }
        public static string bX017Y063 { get; set; }
        public static string bX018Y000 { get; set; }
        public static string bX018Y001 { get; set; }
        public static string bX018Y002 { get; set; }
        public static string bX018Y003 { get; set; }
        public static string bX018Y004 { get; set; }
        public static string bX018Y005 { get; set; }
        public static string bX018Y006 { get; set; }
        public static string bX018Y007 { get; set; }
        public static string bX018Y008 { get; set; }
        public static string bX018Y009 { get; set; }
        public static string bX018Y010 { get; set; }
        public static string bX018Y011 { get; set; }
        public static string bX018Y012 { get; set; }
        public static string bX018Y013 { get; set; }
        public static string bX018Y014 { get; set; }
        public static string bX018Y015 { get; set; }
        public static string bX018Y016 { get; set; }
        public static string bX018Y017 { get; set; }
        public static string bX018Y018 { get; set; }
        public static string bX018Y019 { get; set; }
        public static string bX018Y020 { get; set; }
        public static string bX018Y021 { get; set; }
        public static string bX018Y022 { get; set; }
        public static string bX018Y023 { get; set; }
        public static string bX018Y024 { get; set; }
        public static string bX018Y025 { get; set; }
        public static string bX018Y026 { get; set; }
        public static string bX018Y027 { get; set; }
        public static string bX018Y028 { get; set; }
        public static string bX018Y029 { get; set; }
        public static string bX018Y030 { get; set; }
        public static string bX018Y031 { get; set; }
        public static string bX018Y032 { get; set; }
        public static string bX018Y033 { get; set; }
        public static string bX018Y034 { get; set; }
        public static string bX018Y035 { get; set; }
        public static string bX018Y036 { get; set; }
        public static string bX018Y037 { get; set; }
        public static string bX018Y038 { get; set; }
        public static string bX018Y039 { get; set; }
        public static string bX018Y040 { get; set; }
        public static string bX018Y041 { get; set; }
        public static string bX018Y042 { get; set; }
        public static string bX018Y043 { get; set; }
        public static string bX018Y044 { get; set; }
        public static string bX018Y045 { get; set; }
        public static string bX018Y046 { get; set; }
        public static string bX018Y047 { get; set; }
        public static string bX018Y048 { get; set; }
        public static string bX018Y049 { get; set; }
        public static string bX018Y050 { get; set; }
        public static string bX018Y051 { get; set; }
        public static string bX018Y052 { get; set; }
        public static string bX018Y053 { get; set; }
        public static string bX018Y054 { get; set; }
        public static string bX018Y055 { get; set; }
        public static string bX018Y056 { get; set; }
        public static string bX018Y057 { get; set; }
        public static string bX018Y058 { get; set; }
        public static string bX018Y059 { get; set; }
        public static string bX018Y060 { get; set; }
        public static string bX018Y061 { get; set; }
        public static string bX018Y062 { get; set; }
        public static string bX018Y063 { get; set; }
        public static string bX019Y000 { get; set; }
        public static string bX019Y001 { get; set; }
        public static string bX019Y002 { get; set; }
        public static string bX019Y003 { get; set; }
        public static string bX019Y004 { get; set; }
        public static string bX019Y005 { get; set; }
        public static string bX019Y006 { get; set; }
        public static string bX019Y007 { get; set; }
        public static string bX019Y008 { get; set; }
        public static string bX019Y009 { get; set; }
        public static string bX019Y010 { get; set; }
        public static string bX019Y011 { get; set; }
        public static string bX019Y012 { get; set; }
        public static string bX019Y013 { get; set; }
        public static string bX019Y014 { get; set; }
        public static string bX019Y015 { get; set; }
        public static string bX019Y016 { get; set; }
        public static string bX019Y017 { get; set; }
        public static string bX019Y018 { get; set; }
        public static string bX019Y019 { get; set; }
        public static string bX019Y020 { get; set; }
        public static string bX019Y021 { get; set; }
        public static string bX019Y022 { get; set; }
        public static string bX019Y023 { get; set; }
        public static string bX019Y024 { get; set; }
        public static string bX019Y025 { get; set; }
        public static string bX019Y026 { get; set; }
        public static string bX019Y027 { get; set; }
        public static string bX019Y028 { get; set; }
        public static string bX019Y029 { get; set; }
        public static string bX019Y030 { get; set; }
        public static string bX019Y031 { get; set; }
        public static string bX019Y032 { get; set; }
        public static string bX019Y033 { get; set; }
        public static string bX019Y034 { get; set; }
        public static string bX019Y035 { get; set; }
        public static string bX019Y036 { get; set; }
        public static string bX019Y037 { get; set; }
        public static string bX019Y038 { get; set; }
        public static string bX019Y039 { get; set; }
        public static string bX019Y040 { get; set; }
        public static string bX019Y041 { get; set; }
        public static string bX019Y042 { get; set; }
        public static string bX019Y043 { get; set; }
        public static string bX019Y044 { get; set; }
        public static string bX019Y045 { get; set; }
        public static string bX019Y046 { get; set; }
        public static string bX019Y047 { get; set; }
        public static string bX019Y048 { get; set; }
        public static string bX019Y049 { get; set; }
        public static string bX019Y050 { get; set; }
        public static string bX019Y051 { get; set; }
        public static string bX019Y052 { get; set; }
        public static string bX019Y053 { get; set; }
        public static string bX019Y054 { get; set; }
        public static string bX019Y055 { get; set; }
        public static string bX019Y056 { get; set; }
        public static string bX019Y057 { get; set; }
        public static string bX019Y058 { get; set; }
        public static string bX019Y059 { get; set; }
        public static string bX019Y060 { get; set; }
        public static string bX019Y061 { get; set; }
        public static string bX019Y062 { get; set; }
        public static string bX019Y063 { get; set; }


        public static string bX020Y000 { get; set; }
        public static string bX020Y001 { get; set; }
        public static string bX020Y002 { get; set; }
        public static string bX020Y003 { get; set; }
        public static string bX020Y004 { get; set; }
        public static string bX020Y005 { get; set; }
        public static string bX020Y006 { get; set; }
        public static string bX020Y007 { get; set; }
        public static string bX020Y008 { get; set; }
        public static string bX020Y009 { get; set; }
        public static string bX020Y010 { get; set; }
        public static string bX020Y011 { get; set; }
        public static string bX020Y012 { get; set; }
        public static string bX020Y013 { get; set; }
        public static string bX020Y014 { get; set; }
        public static string bX020Y015 { get; set; }
        public static string bX020Y016 { get; set; }
        public static string bX020Y017 { get; set; }
        public static string bX020Y018 { get; set; }
        public static string bX020Y019 { get; set; }
        public static string bX020Y020 { get; set; }
        public static string bX020Y021 { get; set; }
        public static string bX020Y022 { get; set; }
        public static string bX020Y023 { get; set; }
        public static string bX020Y024 { get; set; }
        public static string bX020Y025 { get; set; }
        public static string bX020Y026 { get; set; }
        public static string bX020Y027 { get; set; }
        public static string bX020Y028 { get; set; }
        public static string bX020Y029 { get; set; }
        public static string bX020Y030 { get; set; }
        public static string bX020Y031 { get; set; }
        public static string bX020Y032 { get; set; }
        public static string bX020Y033 { get; set; }
        public static string bX020Y034 { get; set; }
        public static string bX020Y035 { get; set; }
        public static string bX020Y036 { get; set; }
        public static string bX020Y037 { get; set; }
        public static string bX020Y038 { get; set; }
        public static string bX020Y039 { get; set; }
        public static string bX020Y040 { get; set; }
        public static string bX020Y041 { get; set; }
        public static string bX020Y042 { get; set; }
        public static string bX020Y043 { get; set; }
        public static string bX020Y044 { get; set; }
        public static string bX020Y045 { get; set; }
        public static string bX020Y046 { get; set; }
        public static string bX020Y047 { get; set; }
        public static string bX020Y048 { get; set; }
        public static string bX020Y049 { get; set; }
        public static string bX020Y050 { get; set; }
        public static string bX020Y051 { get; set; }
        public static string bX020Y052 { get; set; }
        public static string bX020Y053 { get; set; }
        public static string bX020Y054 { get; set; }
        public static string bX020Y055 { get; set; }
        public static string bX020Y056 { get; set; }
        public static string bX020Y057 { get; set; }
        public static string bX020Y058 { get; set; }
        public static string bX020Y059 { get; set; }
        public static string bX020Y060 { get; set; }
        public static string bX020Y061 { get; set; }
        public static string bX020Y062 { get; set; }
        public static string bX020Y063 { get; set; }
        public static string bX021Y000 { get; set; }
        public static string bX021Y001 { get; set; }
        public static string bX021Y002 { get; set; }
        public static string bX021Y003 { get; set; }
        public static string bX021Y004 { get; set; }
        public static string bX021Y005 { get; set; }
        public static string bX021Y006 { get; set; }
        public static string bX021Y007 { get; set; }
        public static string bX021Y008 { get; set; }
        public static string bX021Y009 { get; set; }
        public static string bX021Y010 { get; set; }
        public static string bX021Y011 { get; set; }
        public static string bX021Y012 { get; set; }
        public static string bX021Y013 { get; set; }
        public static string bX021Y014 { get; set; }
        public static string bX021Y015 { get; set; }
        public static string bX021Y016 { get; set; }
        public static string bX021Y017 { get; set; }
        public static string bX021Y018 { get; set; }
        public static string bX021Y019 { get; set; }
        public static string bX021Y020 { get; set; }
        public static string bX021Y021 { get; set; }
        public static string bX021Y022 { get; set; }
        public static string bX021Y023 { get; set; }
        public static string bX021Y024 { get; set; }
        public static string bX021Y025 { get; set; }
        public static string bX021Y026 { get; set; }
        public static string bX021Y027 { get; set; }
        public static string bX021Y028 { get; set; }
        public static string bX021Y029 { get; set; }
        public static string bX021Y030 { get; set; }
        public static string bX021Y031 { get; set; }
        public static string bX021Y032 { get; set; }
        public static string bX021Y033 { get; set; }
        public static string bX021Y034 { get; set; }
        public static string bX021Y035 { get; set; }
        public static string bX021Y036 { get; set; }
        public static string bX021Y037 { get; set; }
        public static string bX021Y038 { get; set; }
        public static string bX021Y039 { get; set; }
        public static string bX021Y040 { get; set; }
        public static string bX021Y041 { get; set; }
        public static string bX021Y042 { get; set; }
        public static string bX021Y043 { get; set; }
        public static string bX021Y044 { get; set; }
        public static string bX021Y045 { get; set; }
        public static string bX021Y046 { get; set; }
        public static string bX021Y047 { get; set; }
        public static string bX021Y048 { get; set; }
        public static string bX021Y049 { get; set; }
        public static string bX021Y050 { get; set; }
        public static string bX021Y051 { get; set; }
        public static string bX021Y052 { get; set; }
        public static string bX021Y053 { get; set; }
        public static string bX021Y054 { get; set; }
        public static string bX021Y055 { get; set; }
        public static string bX021Y056 { get; set; }
        public static string bX021Y057 { get; set; }
        public static string bX021Y058 { get; set; }
        public static string bX021Y059 { get; set; }
        public static string bX021Y060 { get; set; }
        public static string bX021Y061 { get; set; }
        public static string bX021Y062 { get; set; }
        public static string bX021Y063 { get; set; }
        public static string bX022Y000 { get; set; }
        public static string bX022Y001 { get; set; }
        public static string bX022Y002 { get; set; }
        public static string bX022Y003 { get; set; }
        public static string bX022Y004 { get; set; }
        public static string bX022Y005 { get; set; }
        public static string bX022Y006 { get; set; }
        public static string bX022Y007 { get; set; }
        public static string bX022Y008 { get; set; }
        public static string bX022Y009 { get; set; }
        public static string bX022Y010 { get; set; }
        public static string bX022Y011 { get; set; }
        public static string bX022Y012 { get; set; }
        public static string bX022Y013 { get; set; }
        public static string bX022Y014 { get; set; }
        public static string bX022Y015 { get; set; }
        public static string bX022Y016 { get; set; }
        public static string bX022Y017 { get; set; }
        public static string bX022Y018 { get; set; }
        public static string bX022Y019 { get; set; }
        public static string bX022Y020 { get; set; }
        public static string bX022Y021 { get; set; }
        public static string bX022Y022 { get; set; }
        public static string bX022Y023 { get; set; }
        public static string bX022Y024 { get; set; }
        public static string bX022Y025 { get; set; }
        public static string bX022Y026 { get; set; }
        public static string bX022Y027 { get; set; }
        public static string bX022Y028 { get; set; }
        public static string bX022Y029 { get; set; }
        public static string bX022Y030 { get; set; }
        public static string bX022Y031 { get; set; }
        public static string bX022Y032 { get; set; }
        public static string bX022Y033 { get; set; }
        public static string bX022Y034 { get; set; }
        public static string bX022Y035 { get; set; }
        public static string bX022Y036 { get; set; }
        public static string bX022Y037 { get; set; }
        public static string bX022Y038 { get; set; }
        public static string bX022Y039 { get; set; }
        public static string bX022Y040 { get; set; }
        public static string bX022Y041 { get; set; }
        public static string bX022Y042 { get; set; }
        public static string bX022Y043 { get; set; }
        public static string bX022Y044 { get; set; }
        public static string bX022Y045 { get; set; }
        public static string bX022Y046 { get; set; }
        public static string bX022Y047 { get; set; }
        public static string bX022Y048 { get; set; }
        public static string bX022Y049 { get; set; }
        public static string bX022Y050 { get; set; }
        public static string bX022Y051 { get; set; }
        public static string bX022Y052 { get; set; }
        public static string bX022Y053 { get; set; }
        public static string bX022Y054 { get; set; }
        public static string bX022Y055 { get; set; }
        public static string bX022Y056 { get; set; }
        public static string bX022Y057 { get; set; }
        public static string bX022Y058 { get; set; }
        public static string bX022Y059 { get; set; }
        public static string bX022Y060 { get; set; }
        public static string bX022Y061 { get; set; }
        public static string bX022Y062 { get; set; }
        public static string bX022Y063 { get; set; }
        public static string bX023Y000 { get; set; }
        public static string bX023Y001 { get; set; }
        public static string bX023Y002 { get; set; }
        public static string bX023Y003 { get; set; }
        public static string bX023Y004 { get; set; }
        public static string bX023Y005 { get; set; }
        public static string bX023Y006 { get; set; }
        public static string bX023Y007 { get; set; }
        public static string bX023Y008 { get; set; }
        public static string bX023Y009 { get; set; }
        public static string bX023Y010 { get; set; }
        public static string bX023Y011 { get; set; }
        public static string bX023Y012 { get; set; }
        public static string bX023Y013 { get; set; }
        public static string bX023Y014 { get; set; }
        public static string bX023Y015 { get; set; }
        public static string bX023Y016 { get; set; }
        public static string bX023Y017 { get; set; }
        public static string bX023Y018 { get; set; }
        public static string bX023Y019 { get; set; }
        public static string bX023Y020 { get; set; }
        public static string bX023Y021 { get; set; }
        public static string bX023Y022 { get; set; }
        public static string bX023Y023 { get; set; }
        public static string bX023Y024 { get; set; }
        public static string bX023Y025 { get; set; }
        public static string bX023Y026 { get; set; }
        public static string bX023Y027 { get; set; }
        public static string bX023Y028 { get; set; }
        public static string bX023Y029 { get; set; }
        public static string bX023Y030 { get; set; }
        public static string bX023Y031 { get; set; }
        public static string bX023Y032 { get; set; }
        public static string bX023Y033 { get; set; }
        public static string bX023Y034 { get; set; }
        public static string bX023Y035 { get; set; }
        public static string bX023Y036 { get; set; }
        public static string bX023Y037 { get; set; }
        public static string bX023Y038 { get; set; }
        public static string bX023Y039 { get; set; }
        public static string bX023Y040 { get; set; }
        public static string bX023Y041 { get; set; }
        public static string bX023Y042 { get; set; }
        public static string bX023Y043 { get; set; }
        public static string bX023Y044 { get; set; }
        public static string bX023Y045 { get; set; }
        public static string bX023Y046 { get; set; }
        public static string bX023Y047 { get; set; }
        public static string bX023Y048 { get; set; }
        public static string bX023Y049 { get; set; }
        public static string bX023Y050 { get; set; }
        public static string bX023Y051 { get; set; }
        public static string bX023Y052 { get; set; }
        public static string bX023Y053 { get; set; }
        public static string bX023Y054 { get; set; }
        public static string bX023Y055 { get; set; }
        public static string bX023Y056 { get; set; }
        public static string bX023Y057 { get; set; }
        public static string bX023Y058 { get; set; }
        public static string bX023Y059 { get; set; }
        public static string bX023Y060 { get; set; }
        public static string bX023Y061 { get; set; }
        public static string bX023Y062 { get; set; }
        public static string bX023Y063 { get; set; }
        public static string bX024Y000 { get; set; }
        public static string bX024Y001 { get; set; }
        public static string bX024Y002 { get; set; }
        public static string bX024Y003 { get; set; }
        public static string bX024Y004 { get; set; }
        public static string bX024Y005 { get; set; }
        public static string bX024Y006 { get; set; }
        public static string bX024Y007 { get; set; }
        public static string bX024Y008 { get; set; }
        public static string bX024Y009 { get; set; }
        public static string bX024Y010 { get; set; }
        public static string bX024Y011 { get; set; }
        public static string bX024Y012 { get; set; }
        public static string bX024Y013 { get; set; }
        public static string bX024Y014 { get; set; }
        public static string bX024Y015 { get; set; }
        public static string bX024Y016 { get; set; }
        public static string bX024Y017 { get; set; }
        public static string bX024Y018 { get; set; }
        public static string bX024Y019 { get; set; }
        public static string bX024Y020 { get; set; }
        public static string bX024Y021 { get; set; }
        public static string bX024Y022 { get; set; }
        public static string bX024Y023 { get; set; }
        public static string bX024Y024 { get; set; }
        public static string bX024Y025 { get; set; }
        public static string bX024Y026 { get; set; }
        public static string bX024Y027 { get; set; }
        public static string bX024Y028 { get; set; }
        public static string bX024Y029 { get; set; }
        public static string bX024Y030 { get; set; }
        public static string bX024Y031 { get; set; }
        public static string bX024Y032 { get; set; }
        public static string bX024Y033 { get; set; }
        public static string bX024Y034 { get; set; }
        public static string bX024Y035 { get; set; }
        public static string bX024Y036 { get; set; }
        public static string bX024Y037 { get; set; }
        public static string bX024Y038 { get; set; }
        public static string bX024Y039 { get; set; }
        public static string bX024Y040 { get; set; }
        public static string bX024Y041 { get; set; }
        public static string bX024Y042 { get; set; }
        public static string bX024Y043 { get; set; }
        public static string bX024Y044 { get; set; }
        public static string bX024Y045 { get; set; }
        public static string bX024Y046 { get; set; }
        public static string bX024Y047 { get; set; }
        public static string bX024Y048 { get; set; }
        public static string bX024Y049 { get; set; }
        public static string bX024Y050 { get; set; }
        public static string bX024Y051 { get; set; }
        public static string bX024Y052 { get; set; }
        public static string bX024Y053 { get; set; }
        public static string bX024Y054 { get; set; }
        public static string bX024Y055 { get; set; }
        public static string bX024Y056 { get; set; }
        public static string bX024Y057 { get; set; }
        public static string bX024Y058 { get; set; }
        public static string bX024Y059 { get; set; }
        public static string bX024Y060 { get; set; }
        public static string bX024Y061 { get; set; }
        public static string bX024Y062 { get; set; }
        public static string bX024Y063 { get; set; }
        public static string bX025Y000 { get; set; }
        public static string bX025Y001 { get; set; }
        public static string bX025Y002 { get; set; }
        public static string bX025Y003 { get; set; }
        public static string bX025Y004 { get; set; }
        public static string bX025Y005 { get; set; }
        public static string bX025Y006 { get; set; }
        public static string bX025Y007 { get; set; }
        public static string bX025Y008 { get; set; }
        public static string bX025Y009 { get; set; }
        public static string bX025Y010 { get; set; }
        public static string bX025Y011 { get; set; }
        public static string bX025Y012 { get; set; }
        public static string bX025Y013 { get; set; }
        public static string bX025Y014 { get; set; }
        public static string bX025Y015 { get; set; }
        public static string bX025Y016 { get; set; }
        public static string bX025Y017 { get; set; }
        public static string bX025Y018 { get; set; }
        public static string bX025Y019 { get; set; }
        public static string bX025Y020 { get; set; }
        public static string bX025Y021 { get; set; }
        public static string bX025Y022 { get; set; }
        public static string bX025Y023 { get; set; }
        public static string bX025Y024 { get; set; }
        public static string bX025Y025 { get; set; }
        public static string bX025Y026 { get; set; }
        public static string bX025Y027 { get; set; }
        public static string bX025Y028 { get; set; }
        public static string bX025Y029 { get; set; }
        public static string bX025Y030 { get; set; }
        public static string bX025Y031 { get; set; }
        public static string bX025Y032 { get; set; }
        public static string bX025Y033 { get; set; }
        public static string bX025Y034 { get; set; }
        public static string bX025Y035 { get; set; }
        public static string bX025Y036 { get; set; }
        public static string bX025Y037 { get; set; }
        public static string bX025Y038 { get; set; }
        public static string bX025Y039 { get; set; }
        public static string bX025Y040 { get; set; }
        public static string bX025Y041 { get; set; }
        public static string bX025Y042 { get; set; }
        public static string bX025Y043 { get; set; }
        public static string bX025Y044 { get; set; }
        public static string bX025Y045 { get; set; }
        public static string bX025Y046 { get; set; }
        public static string bX025Y047 { get; set; }
        public static string bX025Y048 { get; set; }
        public static string bX025Y049 { get; set; }
        public static string bX025Y050 { get; set; }
        public static string bX025Y051 { get; set; }
        public static string bX025Y052 { get; set; }
        public static string bX025Y053 { get; set; }
        public static string bX025Y054 { get; set; }
        public static string bX025Y055 { get; set; }
        public static string bX025Y056 { get; set; }
        public static string bX025Y057 { get; set; }
        public static string bX025Y058 { get; set; }
        public static string bX025Y059 { get; set; }
        public static string bX025Y060 { get; set; }
        public static string bX025Y061 { get; set; }
        public static string bX025Y062 { get; set; }
        public static string bX025Y063 { get; set; }
        public static string bX026Y000 { get; set; }
        public static string bX026Y001 { get; set; }
        public static string bX026Y002 { get; set; }
        public static string bX026Y003 { get; set; }
        public static string bX026Y004 { get; set; }
        public static string bX026Y005 { get; set; }
        public static string bX026Y006 { get; set; }
        public static string bX026Y007 { get; set; }
        public static string bX026Y008 { get; set; }
        public static string bX026Y009 { get; set; }
        public static string bX026Y010 { get; set; }
        public static string bX026Y011 { get; set; }
        public static string bX026Y012 { get; set; }
        public static string bX026Y013 { get; set; }
        public static string bX026Y014 { get; set; }
        public static string bX026Y015 { get; set; }
        public static string bX026Y016 { get; set; }
        public static string bX026Y017 { get; set; }
        public static string bX026Y018 { get; set; }
        public static string bX026Y019 { get; set; }
        public static string bX026Y020 { get; set; }
        public static string bX026Y021 { get; set; }
        public static string bX026Y022 { get; set; }
        public static string bX026Y023 { get; set; }
        public static string bX026Y024 { get; set; }
        public static string bX026Y025 { get; set; }
        public static string bX026Y026 { get; set; }
        public static string bX026Y027 { get; set; }
        public static string bX026Y028 { get; set; }
        public static string bX026Y029 { get; set; }
        public static string bX026Y030 { get; set; }
        public static string bX026Y031 { get; set; }
        public static string bX026Y032 { get; set; }
        public static string bX026Y033 { get; set; }
        public static string bX026Y034 { get; set; }
        public static string bX026Y035 { get; set; }
        public static string bX026Y036 { get; set; }
        public static string bX026Y037 { get; set; }
        public static string bX026Y038 { get; set; }
        public static string bX026Y039 { get; set; }
        public static string bX026Y040 { get; set; }
        public static string bX026Y041 { get; set; }
        public static string bX026Y042 { get; set; }
        public static string bX026Y043 { get; set; }
        public static string bX026Y044 { get; set; }
        public static string bX026Y045 { get; set; }
        public static string bX026Y046 { get; set; }
        public static string bX026Y047 { get; set; }
        public static string bX026Y048 { get; set; }
        public static string bX026Y049 { get; set; }
        public static string bX026Y050 { get; set; }
        public static string bX026Y051 { get; set; }
        public static string bX026Y052 { get; set; }
        public static string bX026Y053 { get; set; }
        public static string bX026Y054 { get; set; }
        public static string bX026Y055 { get; set; }
        public static string bX026Y056 { get; set; }
        public static string bX026Y057 { get; set; }
        public static string bX026Y058 { get; set; }
        public static string bX026Y059 { get; set; }
        public static string bX026Y060 { get; set; }
        public static string bX026Y061 { get; set; }
        public static string bX026Y062 { get; set; }
        public static string bX026Y063 { get; set; }
        public static string bX027Y000 { get; set; }
        public static string bX027Y001 { get; set; }
        public static string bX027Y002 { get; set; }
        public static string bX027Y003 { get; set; }
        public static string bX027Y004 { get; set; }
        public static string bX027Y005 { get; set; }
        public static string bX027Y006 { get; set; }
        public static string bX027Y007 { get; set; }
        public static string bX027Y008 { get; set; }
        public static string bX027Y009 { get; set; }
        public static string bX027Y010 { get; set; }
        public static string bX027Y011 { get; set; }
        public static string bX027Y012 { get; set; }
        public static string bX027Y013 { get; set; }
        public static string bX027Y014 { get; set; }
        public static string bX027Y015 { get; set; }
        public static string bX027Y016 { get; set; }
        public static string bX027Y017 { get; set; }
        public static string bX027Y018 { get; set; }
        public static string bX027Y019 { get; set; }
        public static string bX027Y020 { get; set; }
        public static string bX027Y021 { get; set; }
        public static string bX027Y022 { get; set; }
        public static string bX027Y023 { get; set; }
        public static string bX027Y024 { get; set; }
        public static string bX027Y025 { get; set; }
        public static string bX027Y026 { get; set; }
        public static string bX027Y027 { get; set; }
        public static string bX027Y028 { get; set; }
        public static string bX027Y029 { get; set; }
        public static string bX027Y030 { get; set; }
        public static string bX027Y031 { get; set; }
        public static string bX027Y032 { get; set; }
        public static string bX027Y033 { get; set; }
        public static string bX027Y034 { get; set; }
        public static string bX027Y035 { get; set; }
        public static string bX027Y036 { get; set; }
        public static string bX027Y037 { get; set; }
        public static string bX027Y038 { get; set; }
        public static string bX027Y039 { get; set; }
        public static string bX027Y040 { get; set; }
        public static string bX027Y041 { get; set; }
        public static string bX027Y042 { get; set; }
        public static string bX027Y043 { get; set; }
        public static string bX027Y044 { get; set; }
        public static string bX027Y045 { get; set; }
        public static string bX027Y046 { get; set; }
        public static string bX027Y047 { get; set; }
        public static string bX027Y048 { get; set; }
        public static string bX027Y049 { get; set; }
        public static string bX027Y050 { get; set; }
        public static string bX027Y051 { get; set; }
        public static string bX027Y052 { get; set; }
        public static string bX027Y053 { get; set; }
        public static string bX027Y054 { get; set; }
        public static string bX027Y055 { get; set; }
        public static string bX027Y056 { get; set; }
        public static string bX027Y057 { get; set; }
        public static string bX027Y058 { get; set; }
        public static string bX027Y059 { get; set; }
        public static string bX027Y060 { get; set; }
        public static string bX027Y061 { get; set; }
        public static string bX027Y062 { get; set; }
        public static string bX027Y063 { get; set; }
        public static string bX028Y000 { get; set; }
        public static string bX028Y001 { get; set; }
        public static string bX028Y002 { get; set; }
        public static string bX028Y003 { get; set; }
        public static string bX028Y004 { get; set; }
        public static string bX028Y005 { get; set; }
        public static string bX028Y006 { get; set; }
        public static string bX028Y007 { get; set; }
        public static string bX028Y008 { get; set; }
        public static string bX028Y009 { get; set; }
        public static string bX028Y010 { get; set; }
        public static string bX028Y011 { get; set; }
        public static string bX028Y012 { get; set; }
        public static string bX028Y013 { get; set; }
        public static string bX028Y014 { get; set; }
        public static string bX028Y015 { get; set; }
        public static string bX028Y016 { get; set; }
        public static string bX028Y017 { get; set; }
        public static string bX028Y018 { get; set; }
        public static string bX028Y019 { get; set; }
        public static string bX028Y020 { get; set; }
        public static string bX028Y021 { get; set; }
        public static string bX028Y022 { get; set; }
        public static string bX028Y023 { get; set; }
        public static string bX028Y024 { get; set; }
        public static string bX028Y025 { get; set; }
        public static string bX028Y026 { get; set; }
        public static string bX028Y027 { get; set; }
        public static string bX028Y028 { get; set; }
        public static string bX028Y029 { get; set; }
        public static string bX028Y030 { get; set; }
        public static string bX028Y031 { get; set; }
        public static string bX028Y032 { get; set; }
        public static string bX028Y033 { get; set; }
        public static string bX028Y034 { get; set; }
        public static string bX028Y035 { get; set; }
        public static string bX028Y036 { get; set; }
        public static string bX028Y037 { get; set; }
        public static string bX028Y038 { get; set; }
        public static string bX028Y039 { get; set; }
        public static string bX028Y040 { get; set; }
        public static string bX028Y041 { get; set; }
        public static string bX028Y042 { get; set; }
        public static string bX028Y043 { get; set; }
        public static string bX028Y044 { get; set; }
        public static string bX028Y045 { get; set; }
        public static string bX028Y046 { get; set; }
        public static string bX028Y047 { get; set; }
        public static string bX028Y048 { get; set; }
        public static string bX028Y049 { get; set; }
        public static string bX028Y050 { get; set; }
        public static string bX028Y051 { get; set; }
        public static string bX028Y052 { get; set; }
        public static string bX028Y053 { get; set; }
        public static string bX028Y054 { get; set; }
        public static string bX028Y055 { get; set; }
        public static string bX028Y056 { get; set; }
        public static string bX028Y057 { get; set; }
        public static string bX028Y058 { get; set; }
        public static string bX028Y059 { get; set; }
        public static string bX028Y060 { get; set; }
        public static string bX028Y061 { get; set; }
        public static string bX028Y062 { get; set; }
        public static string bX028Y063 { get; set; }
        public static string bX029Y000 { get; set; }
        public static string bX029Y001 { get; set; }
        public static string bX029Y002 { get; set; }
        public static string bX029Y003 { get; set; }
        public static string bX029Y004 { get; set; }
        public static string bX029Y005 { get; set; }
        public static string bX029Y006 { get; set; }
        public static string bX029Y007 { get; set; }
        public static string bX029Y008 { get; set; }
        public static string bX029Y009 { get; set; }
        public static string bX029Y010 { get; set; }
        public static string bX029Y011 { get; set; }
        public static string bX029Y012 { get; set; }
        public static string bX029Y013 { get; set; }
        public static string bX029Y014 { get; set; }
        public static string bX029Y015 { get; set; }
        public static string bX029Y016 { get; set; }
        public static string bX029Y017 { get; set; }
        public static string bX029Y018 { get; set; }
        public static string bX029Y019 { get; set; }
        public static string bX029Y020 { get; set; }
        public static string bX029Y021 { get; set; }
        public static string bX029Y022 { get; set; }
        public static string bX029Y023 { get; set; }
        public static string bX029Y024 { get; set; }
        public static string bX029Y025 { get; set; }
        public static string bX029Y026 { get; set; }
        public static string bX029Y027 { get; set; }
        public static string bX029Y028 { get; set; }
        public static string bX029Y029 { get; set; }
        public static string bX029Y030 { get; set; }
        public static string bX029Y031 { get; set; }
        public static string bX029Y032 { get; set; }
        public static string bX029Y033 { get; set; }
        public static string bX029Y034 { get; set; }
        public static string bX029Y035 { get; set; }
        public static string bX029Y036 { get; set; }
        public static string bX029Y037 { get; set; }
        public static string bX029Y038 { get; set; }
        public static string bX029Y039 { get; set; }
        public static string bX029Y040 { get; set; }
        public static string bX029Y041 { get; set; }
        public static string bX029Y042 { get; set; }
        public static string bX029Y043 { get; set; }
        public static string bX029Y044 { get; set; }
        public static string bX029Y045 { get; set; }
        public static string bX029Y046 { get; set; }
        public static string bX029Y047 { get; set; }
        public static string bX029Y048 { get; set; }
        public static string bX029Y049 { get; set; }
        public static string bX029Y050 { get; set; }
        public static string bX029Y051 { get; set; }
        public static string bX029Y052 { get; set; }
        public static string bX029Y053 { get; set; }
        public static string bX029Y054 { get; set; }
        public static string bX029Y055 { get; set; }
        public static string bX029Y056 { get; set; }
        public static string bX029Y057 { get; set; }
        public static string bX029Y058 { get; set; }
        public static string bX029Y059 { get; set; }
        public static string bX029Y060 { get; set; }
        public static string bX029Y061 { get; set; }
        public static string bX029Y062 { get; set; }
        public static string bX029Y063 { get; set; }


        public static string bX030Y000 { get; set; }
        public static string bX030Y001 { get; set; }
        public static string bX030Y002 { get; set; }
        public static string bX030Y003 { get; set; }
        public static string bX030Y004 { get; set; }
        public static string bX030Y005 { get; set; }
        public static string bX030Y006 { get; set; }
        public static string bX030Y007 { get; set; }
        public static string bX030Y008 { get; set; }
        public static string bX030Y009 { get; set; }
        public static string bX030Y010 { get; set; }
        public static string bX030Y011 { get; set; }
        public static string bX030Y012 { get; set; }
        public static string bX030Y013 { get; set; }
        public static string bX030Y014 { get; set; }
        public static string bX030Y015 { get; set; }
        public static string bX030Y016 { get; set; }
        public static string bX030Y017 { get; set; }
        public static string bX030Y018 { get; set; }
        public static string bX030Y019 { get; set; }
        public static string bX030Y020 { get; set; }
        public static string bX030Y021 { get; set; }
        public static string bX030Y022 { get; set; }
        public static string bX030Y023 { get; set; }
        public static string bX030Y024 { get; set; }
        public static string bX030Y025 { get; set; }
        public static string bX030Y026 { get; set; }
        public static string bX030Y027 { get; set; }
        public static string bX030Y028 { get; set; }
        public static string bX030Y029 { get; set; }
        public static string bX030Y030 { get; set; }
        public static string bX030Y031 { get; set; }
        public static string bX030Y032 { get; set; }
        public static string bX030Y033 { get; set; }
        public static string bX030Y034 { get; set; }
        public static string bX030Y035 { get; set; }
        public static string bX030Y036 { get; set; }
        public static string bX030Y037 { get; set; }
        public static string bX030Y038 { get; set; }
        public static string bX030Y039 { get; set; }
        public static string bX030Y040 { get; set; }
        public static string bX030Y041 { get; set; }
        public static string bX030Y042 { get; set; }
        public static string bX030Y043 { get; set; }
        public static string bX030Y044 { get; set; }
        public static string bX030Y045 { get; set; }
        public static string bX030Y046 { get; set; }
        public static string bX030Y047 { get; set; }
        public static string bX030Y048 { get; set; }
        public static string bX030Y049 { get; set; }
        public static string bX030Y050 { get; set; }
        public static string bX030Y051 { get; set; }
        public static string bX030Y052 { get; set; }
        public static string bX030Y053 { get; set; }
        public static string bX030Y054 { get; set; }
        public static string bX030Y055 { get; set; }
        public static string bX030Y056 { get; set; }
        public static string bX030Y057 { get; set; }
        public static string bX030Y058 { get; set; }
        public static string bX030Y059 { get; set; }
        public static string bX030Y060 { get; set; }
        public static string bX030Y061 { get; set; }
        public static string bX030Y062 { get; set; }
        public static string bX030Y063 { get; set; }
        public static string bX031Y000 { get; set; }
        public static string bX031Y001 { get; set; }
        public static string bX031Y002 { get; set; }
        public static string bX031Y003 { get; set; }
        public static string bX031Y004 { get; set; }
        public static string bX031Y005 { get; set; }
        public static string bX031Y006 { get; set; }
        public static string bX031Y007 { get; set; }
        public static string bX031Y008 { get; set; }
        public static string bX031Y009 { get; set; }
        public static string bX031Y010 { get; set; }
        public static string bX031Y011 { get; set; }
        public static string bX031Y012 { get; set; }
        public static string bX031Y013 { get; set; }
        public static string bX031Y014 { get; set; }
        public static string bX031Y015 { get; set; }
        public static string bX031Y016 { get; set; }
        public static string bX031Y017 { get; set; }
        public static string bX031Y018 { get; set; }
        public static string bX031Y019 { get; set; }
        public static string bX031Y020 { get; set; }
        public static string bX031Y021 { get; set; }
        public static string bX031Y022 { get; set; }
        public static string bX031Y023 { get; set; }
        public static string bX031Y024 { get; set; }
        public static string bX031Y025 { get; set; }
        public static string bX031Y026 { get; set; }
        public static string bX031Y027 { get; set; }
        public static string bX031Y028 { get; set; }
        public static string bX031Y029 { get; set; }
        public static string bX031Y030 { get; set; }
        public static string bX031Y031 { get; set; }
        public static string bX031Y032 { get; set; }
        public static string bX031Y033 { get; set; }
        public static string bX031Y034 { get; set; }
        public static string bX031Y035 { get; set; }
        public static string bX031Y036 { get; set; }
        public static string bX031Y037 { get; set; }
        public static string bX031Y038 { get; set; }
        public static string bX031Y039 { get; set; }
        public static string bX031Y040 { get; set; }
        public static string bX031Y041 { get; set; }
        public static string bX031Y042 { get; set; }
        public static string bX031Y043 { get; set; }
        public static string bX031Y044 { get; set; }
        public static string bX031Y045 { get; set; }
        public static string bX031Y046 { get; set; }
        public static string bX031Y047 { get; set; }
        public static string bX031Y048 { get; set; }
        public static string bX031Y049 { get; set; }
        public static string bX031Y050 { get; set; }
        public static string bX031Y051 { get; set; }
        public static string bX031Y052 { get; set; }
        public static string bX031Y053 { get; set; }
        public static string bX031Y054 { get; set; }
        public static string bX031Y055 { get; set; }
        public static string bX031Y056 { get; set; }
        public static string bX031Y057 { get; set; }
        public static string bX031Y058 { get; set; }
        public static string bX031Y059 { get; set; }
        public static string bX031Y060 { get; set; }
        public static string bX031Y061 { get; set; }
        public static string bX031Y062 { get; set; }
        public static string bX031Y063 { get; set; }
        public static string bX032Y000 { get; set; }
        public static string bX032Y001 { get; set; }
        public static string bX032Y002 { get; set; }
        public static string bX032Y003 { get; set; }
        public static string bX032Y004 { get; set; }
        public static string bX032Y005 { get; set; }
        public static string bX032Y006 { get; set; }
        public static string bX032Y007 { get; set; }
        public static string bX032Y008 { get; set; }
        public static string bX032Y009 { get; set; }
        public static string bX032Y010 { get; set; }
        public static string bX032Y011 { get; set; }
        public static string bX032Y012 { get; set; }
        public static string bX032Y013 { get; set; }
        public static string bX032Y014 { get; set; }
        public static string bX032Y015 { get; set; }
        public static string bX032Y016 { get; set; }
        public static string bX032Y017 { get; set; }
        public static string bX032Y018 { get; set; }
        public static string bX032Y019 { get; set; }
        public static string bX032Y020 { get; set; }
        public static string bX032Y021 { get; set; }
        public static string bX032Y022 { get; set; }
        public static string bX032Y023 { get; set; }
        public static string bX032Y024 { get; set; }
        public static string bX032Y025 { get; set; }
        public static string bX032Y026 { get; set; }
        public static string bX032Y027 { get; set; }
        public static string bX032Y028 { get; set; }
        public static string bX032Y029 { get; set; }
        public static string bX032Y030 { get; set; }
        public static string bX032Y031 { get; set; }
        public static string bX032Y032 { get; set; }
        public static string bX032Y033 { get; set; }
        public static string bX032Y034 { get; set; }
        public static string bX032Y035 { get; set; }
        public static string bX032Y036 { get; set; }
        public static string bX032Y037 { get; set; }
        public static string bX032Y038 { get; set; }
        public static string bX032Y039 { get; set; }
        public static string bX032Y040 { get; set; }
        public static string bX032Y041 { get; set; }
        public static string bX032Y042 { get; set; }
        public static string bX032Y043 { get; set; }
        public static string bX032Y044 { get; set; }
        public static string bX032Y045 { get; set; }
        public static string bX032Y046 { get; set; }
        public static string bX032Y047 { get; set; }
        public static string bX032Y048 { get; set; }
        public static string bX032Y049 { get; set; }
        public static string bX032Y050 { get; set; }
        public static string bX032Y051 { get; set; }
        public static string bX032Y052 { get; set; }
        public static string bX032Y053 { get; set; }
        public static string bX032Y054 { get; set; }
        public static string bX032Y055 { get; set; }
        public static string bX032Y056 { get; set; }
        public static string bX032Y057 { get; set; }
        public static string bX032Y058 { get; set; }
        public static string bX032Y059 { get; set; }
        public static string bX032Y060 { get; set; }
        public static string bX032Y061 { get; set; }
        public static string bX032Y062 { get; set; }
        public static string bX032Y063 { get; set; }
        public static string bX033Y000 { get; set; }
        public static string bX033Y001 { get; set; }
        public static string bX033Y002 { get; set; }
        public static string bX033Y003 { get; set; }
        public static string bX033Y004 { get; set; }
        public static string bX033Y005 { get; set; }
        public static string bX033Y006 { get; set; }
        public static string bX033Y007 { get; set; }
        public static string bX033Y008 { get; set; }
        public static string bX033Y009 { get; set; }
        public static string bX033Y010 { get; set; }
        public static string bX033Y011 { get; set; }
        public static string bX033Y012 { get; set; }
        public static string bX033Y013 { get; set; }
        public static string bX033Y014 { get; set; }
        public static string bX033Y015 { get; set; }
        public static string bX033Y016 { get; set; }
        public static string bX033Y017 { get; set; }
        public static string bX033Y018 { get; set; }
        public static string bX033Y019 { get; set; }
        public static string bX033Y020 { get; set; }
        public static string bX033Y021 { get; set; }
        public static string bX033Y022 { get; set; }
        public static string bX033Y023 { get; set; }
        public static string bX033Y024 { get; set; }
        public static string bX033Y025 { get; set; }
        public static string bX033Y026 { get; set; }
        public static string bX033Y027 { get; set; }
        public static string bX033Y028 { get; set; }
        public static string bX033Y029 { get; set; }
        public static string bX033Y030 { get; set; }
        public static string bX033Y031 { get; set; }
        public static string bX033Y032 { get; set; }
        public static string bX033Y033 { get; set; }
        public static string bX033Y034 { get; set; }
        public static string bX033Y035 { get; set; }
        public static string bX033Y036 { get; set; }
        public static string bX033Y037 { get; set; }
        public static string bX033Y038 { get; set; }
        public static string bX033Y039 { get; set; }
        public static string bX033Y040 { get; set; }
        public static string bX033Y041 { get; set; }
        public static string bX033Y042 { get; set; }
        public static string bX033Y043 { get; set; }
        public static string bX033Y044 { get; set; }
        public static string bX033Y045 { get; set; }
        public static string bX033Y046 { get; set; }
        public static string bX033Y047 { get; set; }
        public static string bX033Y048 { get; set; }
        public static string bX033Y049 { get; set; }
        public static string bX033Y050 { get; set; }
        public static string bX033Y051 { get; set; }
        public static string bX033Y052 { get; set; }
        public static string bX033Y053 { get; set; }
        public static string bX033Y054 { get; set; }
        public static string bX033Y055 { get; set; }
        public static string bX033Y056 { get; set; }
        public static string bX033Y057 { get; set; }
        public static string bX033Y058 { get; set; }
        public static string bX033Y059 { get; set; }
        public static string bX033Y060 { get; set; }
        public static string bX033Y061 { get; set; }
        public static string bX033Y062 { get; set; }
        public static string bX033Y063 { get; set; }


        public static string bX034Y000 { get; set; }
        public static string bX034Y001 { get; set; }
        public static string bX034Y002 { get; set; }
        public static string bX034Y003 { get; set; }
        public static string bX034Y004 { get; set; }
        public static string bX034Y005 { get; set; }
        public static string bX034Y006 { get; set; }
        public static string bX034Y007 { get; set; }
        public static string bX034Y008 { get; set; }
        public static string bX034Y009 { get; set; }
        public static string bX034Y010 { get; set; }
        public static string bX034Y011 { get; set; }
        public static string bX034Y012 { get; set; }
        public static string bX034Y013 { get; set; }
        public static string bX034Y014 { get; set; }
        public static string bX034Y015 { get; set; }
        public static string bX034Y016 { get; set; }
        public static string bX034Y017 { get; set; }
        public static string bX034Y018 { get; set; }
        public static string bX034Y019 { get; set; }
        public static string bX034Y020 { get; set; }
        public static string bX034Y021 { get; set; }
        public static string bX034Y022 { get; set; }
        public static string bX034Y023 { get; set; }
        public static string bX034Y024 { get; set; }
        public static string bX034Y025 { get; set; }
        public static string bX034Y026 { get; set; }
        public static string bX034Y027 { get; set; }
        public static string bX034Y028 { get; set; }
        public static string bX034Y029 { get; set; }
        public static string bX034Y030 { get; set; }
        public static string bX034Y031 { get; set; }
        public static string bX034Y032 { get; set; }
        public static string bX034Y033 { get; set; }
        public static string bX034Y034 { get; set; }
        public static string bX034Y035 { get; set; }
        public static string bX034Y036 { get; set; }
        public static string bX034Y037 { get; set; }
        public static string bX034Y038 { get; set; }
        public static string bX034Y039 { get; set; }
        public static string bX034Y040 { get; set; }
        public static string bX034Y041 { get; set; }
        public static string bX034Y042 { get; set; }
        public static string bX034Y043 { get; set; }
        public static string bX034Y044 { get; set; }
        public static string bX034Y045 { get; set; }
        public static string bX034Y046 { get; set; }
        public static string bX034Y047 { get; set; }
        public static string bX034Y048 { get; set; }
        public static string bX034Y049 { get; set; }
        public static string bX034Y050 { get; set; }
        public static string bX034Y051 { get; set; }
        public static string bX034Y052 { get; set; }
        public static string bX034Y053 { get; set; }
        public static string bX034Y054 { get; set; }
        public static string bX034Y055 { get; set; }
        public static string bX034Y056 { get; set; }
        public static string bX034Y057 { get; set; }
        public static string bX034Y058 { get; set; }
        public static string bX034Y059 { get; set; }
        public static string bX034Y060 { get; set; }
        public static string bX034Y061 { get; set; }
        public static string bX034Y062 { get; set; }
        public static string bX034Y063 { get; set; }

        public static string bX035Y000 { get; set; }
        public static string bX035Y001 { get; set; }
        public static string bX035Y002 { get; set; }
        public static string bX035Y003 { get; set; }
        public static string bX035Y004 { get; set; }
        public static string bX035Y005 { get; set; }
        public static string bX035Y006 { get; set; }
        public static string bX035Y007 { get; set; }
        public static string bX035Y008 { get; set; }
        public static string bX035Y009 { get; set; }
        public static string bX035Y010 { get; set; }
        public static string bX035Y011 { get; set; }
        public static string bX035Y012 { get; set; }
        public static string bX035Y013 { get; set; }
        public static string bX035Y014 { get; set; }
        public static string bX035Y015 { get; set; }
        public static string bX035Y016 { get; set; }
        public static string bX035Y017 { get; set; }
        public static string bX035Y018 { get; set; }
        public static string bX035Y019 { get; set; }
        public static string bX035Y020 { get; set; }
        public static string bX035Y021 { get; set; }
        public static string bX035Y022 { get; set; }
        public static string bX035Y023 { get; set; }
        public static string bX035Y024 { get; set; }
        public static string bX035Y025 { get; set; }
        public static string bX035Y026 { get; set; }
        public static string bX035Y027 { get; set; }
        public static string bX035Y028 { get; set; }
        public static string bX035Y029 { get; set; }
        public static string bX035Y030 { get; set; }
        public static string bX035Y031 { get; set; }
        public static string bX035Y032 { get; set; }
        public static string bX035Y033 { get; set; }
        public static string bX035Y034 { get; set; }
        public static string bX035Y035 { get; set; }
        public static string bX035Y036 { get; set; }
        public static string bX035Y037 { get; set; }
        public static string bX035Y038 { get; set; }
        public static string bX035Y039 { get; set; }
        public static string bX035Y040 { get; set; }
        public static string bX035Y041 { get; set; }
        public static string bX035Y042 { get; set; }
        public static string bX035Y043 { get; set; }
        public static string bX035Y044 { get; set; }
        public static string bX035Y045 { get; set; }
        public static string bX035Y046 { get; set; }
        public static string bX035Y047 { get; set; }
        public static string bX035Y048 { get; set; }
        public static string bX035Y049 { get; set; }
        public static string bX035Y050 { get; set; }
        public static string bX035Y051 { get; set; }
        public static string bX035Y052 { get; set; }
        public static string bX035Y053 { get; set; }
        public static string bX035Y054 { get; set; }
        public static string bX035Y055 { get; set; }
        public static string bX035Y056 { get; set; }
        public static string bX035Y057 { get; set; }
        public static string bX035Y058 { get; set; }
        public static string bX035Y059 { get; set; }
        public static string bX035Y060 { get; set; }
        public static string bX035Y061 { get; set; }
        public static string bX035Y062 { get; set; }
        public static string bX035Y063 { get; set; }

        public static string bX036Y000 { get; set; }
        public static string bX036Y001 { get; set; }
        public static string bX036Y002 { get; set; }
        public static string bX036Y003 { get; set; }
        public static string bX036Y004 { get; set; }
        public static string bX036Y005 { get; set; }
        public static string bX036Y006 { get; set; }
        public static string bX036Y007 { get; set; }
        public static string bX036Y008 { get; set; }
        public static string bX036Y009 { get; set; }
        public static string bX036Y010 { get; set; }
        public static string bX036Y011 { get; set; }
        public static string bX036Y012 { get; set; }
        public static string bX036Y013 { get; set; }
        public static string bX036Y014 { get; set; }
        public static string bX036Y015 { get; set; }
        public static string bX036Y016 { get; set; }
        public static string bX036Y017 { get; set; }
        public static string bX036Y018 { get; set; }
        public static string bX036Y019 { get; set; }
        public static string bX036Y020 { get; set; }
        public static string bX036Y021 { get; set; }
        public static string bX036Y022 { get; set; }
        public static string bX036Y023 { get; set; }
        public static string bX036Y024 { get; set; }
        public static string bX036Y025 { get; set; }
        public static string bX036Y026 { get; set; }
        public static string bX036Y027 { get; set; }
        public static string bX036Y028 { get; set; }
        public static string bX036Y029 { get; set; }
        public static string bX036Y030 { get; set; }
        public static string bX036Y031 { get; set; }
        public static string bX036Y032 { get; set; }
        public static string bX036Y033 { get; set; }
        public static string bX036Y034 { get; set; }
        public static string bX036Y035 { get; set; }
        public static string bX036Y036 { get; set; }
        public static string bX036Y037 { get; set; }
        public static string bX036Y038 { get; set; }
        public static string bX036Y039 { get; set; }
        public static string bX036Y040 { get; set; }
        public static string bX036Y041 { get; set; }
        public static string bX036Y042 { get; set; }
        public static string bX036Y043 { get; set; }
        public static string bX036Y044 { get; set; }
        public static string bX036Y045 { get; set; }
        public static string bX036Y046 { get; set; }
        public static string bX036Y047 { get; set; }
        public static string bX036Y048 { get; set; }
        public static string bX036Y049 { get; set; }
        public static string bX036Y050 { get; set; }
        public static string bX036Y051 { get; set; }
        public static string bX036Y052 { get; set; }
        public static string bX036Y053 { get; set; }
        public static string bX036Y054 { get; set; }
        public static string bX036Y055 { get; set; }
        public static string bX036Y056 { get; set; }
        public static string bX036Y057 { get; set; }
        public static string bX036Y058 { get; set; }
        public static string bX036Y059 { get; set; }
        public static string bX036Y060 { get; set; }
        public static string bX036Y061 { get; set; }
        public static string bX036Y062 { get; set; }
        public static string bX036Y063 { get; set; }

        public static string bX037Y000 { get; set; }
        public static string bX037Y001 { get; set; }
        public static string bX037Y002 { get; set; }
        public static string bX037Y003 { get; set; }
        public static string bX037Y004 { get; set; }
        public static string bX037Y005 { get; set; }
        public static string bX037Y006 { get; set; }
        public static string bX037Y007 { get; set; }
        public static string bX037Y008 { get; set; }
        public static string bX037Y009 { get; set; }
        public static string bX037Y010 { get; set; }
        public static string bX037Y011 { get; set; }
        public static string bX037Y012 { get; set; }
        public static string bX037Y013 { get; set; }
        public static string bX037Y014 { get; set; }
        public static string bX037Y015 { get; set; }
        public static string bX037Y016 { get; set; }
        public static string bX037Y017 { get; set; }
        public static string bX037Y018 { get; set; }
        public static string bX037Y019 { get; set; }
        public static string bX037Y020 { get; set; }
        public static string bX037Y021 { get; set; }
        public static string bX037Y022 { get; set; }
        public static string bX037Y023 { get; set; }
        public static string bX037Y024 { get; set; }
        public static string bX037Y025 { get; set; }
        public static string bX037Y026 { get; set; }
        public static string bX037Y027 { get; set; }
        public static string bX037Y028 { get; set; }
        public static string bX037Y029 { get; set; }
        public static string bX037Y030 { get; set; }
        public static string bX037Y031 { get; set; }
        public static string bX037Y032 { get; set; }
        public static string bX037Y033 { get; set; }
        public static string bX037Y034 { get; set; }
        public static string bX037Y035 { get; set; }
        public static string bX037Y036 { get; set; }
        public static string bX037Y037 { get; set; }
        public static string bX037Y038 { get; set; }
        public static string bX037Y039 { get; set; }
        public static string bX037Y040 { get; set; }
        public static string bX037Y041 { get; set; }
        public static string bX037Y042 { get; set; }
        public static string bX037Y043 { get; set; }
        public static string bX037Y044 { get; set; }
        public static string bX037Y045 { get; set; }
        public static string bX037Y046 { get; set; }
        public static string bX037Y047 { get; set; }
        public static string bX037Y048 { get; set; }
        public static string bX037Y049 { get; set; }
        public static string bX037Y050 { get; set; }
        public static string bX037Y051 { get; set; }
        public static string bX037Y052 { get; set; }
        public static string bX037Y053 { get; set; }
        public static string bX037Y054 { get; set; }
        public static string bX037Y055 { get; set; }
        public static string bX037Y056 { get; set; }
        public static string bX037Y057 { get; set; }
        public static string bX037Y058 { get; set; }
        public static string bX037Y059 { get; set; }
        public static string bX037Y060 { get; set; }
        public static string bX037Y061 { get; set; }
        public static string bX037Y062 { get; set; }
        public static string bX037Y063 { get; set; }

        public static string bX038Y000 { get; set; }
        public static string bX038Y001 { get; set; }
        public static string bX038Y002 { get; set; }
        public static string bX038Y003 { get; set; }
        public static string bX038Y004 { get; set; }
        public static string bX038Y005 { get; set; }
        public static string bX038Y006 { get; set; }
        public static string bX038Y007 { get; set; }
        public static string bX038Y008 { get; set; }
        public static string bX038Y009 { get; set; }
        public static string bX038Y010 { get; set; }
        public static string bX038Y011 { get; set; }
        public static string bX038Y012 { get; set; }
        public static string bX038Y013 { get; set; }
        public static string bX038Y014 { get; set; }
        public static string bX038Y015 { get; set; }
        public static string bX038Y016 { get; set; }
        public static string bX038Y017 { get; set; }
        public static string bX038Y018 { get; set; }
        public static string bX038Y019 { get; set; }
        public static string bX038Y020 { get; set; }
        public static string bX038Y021 { get; set; }
        public static string bX038Y022 { get; set; }
        public static string bX038Y023 { get; set; }
        public static string bX038Y024 { get; set; }
        public static string bX038Y025 { get; set; }
        public static string bX038Y026 { get; set; }
        public static string bX038Y027 { get; set; }
        public static string bX038Y028 { get; set; }
        public static string bX038Y029 { get; set; }
        public static string bX038Y030 { get; set; }
        public static string bX038Y031 { get; set; }
        public static string bX038Y032 { get; set; }
        public static string bX038Y033 { get; set; }
        public static string bX038Y034 { get; set; }
        public static string bX038Y035 { get; set; }
        public static string bX038Y036 { get; set; }
        public static string bX038Y037 { get; set; }
        public static string bX038Y038 { get; set; }
        public static string bX038Y039 { get; set; }
        public static string bX038Y040 { get; set; }
        public static string bX038Y041 { get; set; }
        public static string bX038Y042 { get; set; }
        public static string bX038Y043 { get; set; }
        public static string bX038Y044 { get; set; }
        public static string bX038Y045 { get; set; }
        public static string bX038Y046 { get; set; }
        public static string bX038Y047 { get; set; }
        public static string bX038Y048 { get; set; }
        public static string bX038Y049 { get; set; }
        public static string bX038Y050 { get; set; }
        public static string bX038Y051 { get; set; }
        public static string bX038Y052 { get; set; }
        public static string bX038Y053 { get; set; }
        public static string bX038Y054 { get; set; }
        public static string bX038Y055 { get; set; }
        public static string bX038Y056 { get; set; }
        public static string bX038Y057 { get; set; }
        public static string bX038Y058 { get; set; }
        public static string bX038Y059 { get; set; }
        public static string bX038Y060 { get; set; }
        public static string bX038Y061 { get; set; }
        public static string bX038Y062 { get; set; }
        public static string bX038Y063 { get; set; }

        public static string bX039Y000 { get; set; }
        public static string bX039Y001 { get; set; }
        public static string bX039Y002 { get; set; }
        public static string bX039Y003 { get; set; }
        public static string bX039Y004 { get; set; }
        public static string bX039Y005 { get; set; }
        public static string bX039Y006 { get; set; }
        public static string bX039Y007 { get; set; }
        public static string bX039Y008 { get; set; }
        public static string bX039Y009 { get; set; }
        public static string bX039Y010 { get; set; }
        public static string bX039Y011 { get; set; }
        public static string bX039Y012 { get; set; }
        public static string bX039Y013 { get; set; }
        public static string bX039Y014 { get; set; }
        public static string bX039Y015 { get; set; }
        public static string bX039Y016 { get; set; }
        public static string bX039Y017 { get; set; }
        public static string bX039Y018 { get; set; }
        public static string bX039Y019 { get; set; }
        public static string bX039Y020 { get; set; }
        public static string bX039Y021 { get; set; }
        public static string bX039Y022 { get; set; }
        public static string bX039Y023 { get; set; }
        public static string bX039Y024 { get; set; }
        public static string bX039Y025 { get; set; }
        public static string bX039Y026 { get; set; }
        public static string bX039Y027 { get; set; }
        public static string bX039Y028 { get; set; }
        public static string bX039Y029 { get; set; }
        public static string bX039Y030 { get; set; }
        public static string bX039Y031 { get; set; }
        public static string bX039Y032 { get; set; }
        public static string bX039Y033 { get; set; }
        public static string bX039Y034 { get; set; }
        public static string bX039Y035 { get; set; }
        public static string bX039Y036 { get; set; }
        public static string bX039Y037 { get; set; }
        public static string bX039Y038 { get; set; }
        public static string bX039Y039 { get; set; }
        public static string bX039Y040 { get; set; }
        public static string bX039Y041 { get; set; }
        public static string bX039Y042 { get; set; }
        public static string bX039Y043 { get; set; }
        public static string bX039Y044 { get; set; }
        public static string bX039Y045 { get; set; }
        public static string bX039Y046 { get; set; }
        public static string bX039Y047 { get; set; }
        public static string bX039Y048 { get; set; }
        public static string bX039Y049 { get; set; }
        public static string bX039Y050 { get; set; }
        public static string bX039Y051 { get; set; }
        public static string bX039Y052 { get; set; }
        public static string bX039Y053 { get; set; }
        public static string bX039Y054 { get; set; }
        public static string bX039Y055 { get; set; }
        public static string bX039Y056 { get; set; }
        public static string bX039Y057 { get; set; }
        public static string bX039Y058 { get; set; }
        public static string bX039Y059 { get; set; }
        public static string bX039Y060 { get; set; }
        public static string bX039Y061 { get; set; }
        public static string bX039Y062 { get; set; }
        public static string bX039Y063 { get; set; }

        public static string bX040Y000 { get; set; }
        public static string bX040Y001 { get; set; }
        public static string bX040Y002 { get; set; }
        public static string bX040Y003 { get; set; }
        public static string bX040Y004 { get; set; }
        public static string bX040Y005 { get; set; }
        public static string bX040Y006 { get; set; }
        public static string bX040Y007 { get; set; }
        public static string bX040Y008 { get; set; }
        public static string bX040Y009 { get; set; }
        public static string bX040Y010 { get; set; }
        public static string bX040Y011 { get; set; }
        public static string bX040Y012 { get; set; }
        public static string bX040Y013 { get; set; }
        public static string bX040Y014 { get; set; }
        public static string bX040Y015 { get; set; }
        public static string bX040Y016 { get; set; }
        public static string bX040Y017 { get; set; }
        public static string bX040Y018 { get; set; }
        public static string bX040Y019 { get; set; }
        public static string bX040Y020 { get; set; }
        public static string bX040Y021 { get; set; }
        public static string bX040Y022 { get; set; }
        public static string bX040Y023 { get; set; }
        public static string bX040Y024 { get; set; }
        public static string bX040Y025 { get; set; }
        public static string bX040Y026 { get; set; }
        public static string bX040Y027 { get; set; }
        public static string bX040Y028 { get; set; }
        public static string bX040Y029 { get; set; }
        public static string bX040Y030 { get; set; }
        public static string bX040Y031 { get; set; }
        public static string bX040Y032 { get; set; }
        public static string bX040Y033 { get; set; }
        public static string bX040Y034 { get; set; }
        public static string bX040Y035 { get; set; }
        public static string bX040Y036 { get; set; }
        public static string bX040Y037 { get; set; }
        public static string bX040Y038 { get; set; }
        public static string bX040Y039 { get; set; }
        public static string bX040Y040 { get; set; }
        public static string bX040Y041 { get; set; }
        public static string bX040Y042 { get; set; }
        public static string bX040Y043 { get; set; }
        public static string bX040Y044 { get; set; }
        public static string bX040Y045 { get; set; }
        public static string bX040Y046 { get; set; }
        public static string bX040Y047 { get; set; }
        public static string bX040Y048 { get; set; }
        public static string bX040Y049 { get; set; }
        public static string bX040Y050 { get; set; }
        public static string bX040Y051 { get; set; }
        public static string bX040Y052 { get; set; }
        public static string bX040Y053 { get; set; }
        public static string bX040Y054 { get; set; }
        public static string bX040Y055 { get; set; }
        public static string bX040Y056 { get; set; }
        public static string bX040Y057 { get; set; }
        public static string bX040Y058 { get; set; }
        public static string bX040Y059 { get; set; }
        public static string bX040Y060 { get; set; }
        public static string bX040Y061 { get; set; }
        public static string bX040Y062 { get; set; }
        public static string bX040Y063 { get; set; }

        public static string bX041Y000 { get; set; }
        public static string bX041Y001 { get; set; }
        public static string bX041Y002 { get; set; }
        public static string bX041Y003 { get; set; }
        public static string bX041Y004 { get; set; }
        public static string bX041Y005 { get; set; }
        public static string bX041Y006 { get; set; }
        public static string bX041Y007 { get; set; }
        public static string bX041Y008 { get; set; }
        public static string bX041Y009 { get; set; }
        public static string bX041Y010 { get; set; }
        public static string bX041Y011 { get; set; }
        public static string bX041Y012 { get; set; }
        public static string bX041Y013 { get; set; }
        public static string bX041Y014 { get; set; }
        public static string bX041Y015 { get; set; }
        public static string bX041Y016 { get; set; }
        public static string bX041Y017 { get; set; }
        public static string bX041Y018 { get; set; }
        public static string bX041Y019 { get; set; }
        public static string bX041Y020 { get; set; }
        public static string bX041Y021 { get; set; }
        public static string bX041Y022 { get; set; }
        public static string bX041Y023 { get; set; }
        public static string bX041Y024 { get; set; }
        public static string bX041Y025 { get; set; }
        public static string bX041Y026 { get; set; }
        public static string bX041Y027 { get; set; }
        public static string bX041Y028 { get; set; }
        public static string bX041Y029 { get; set; }
        public static string bX041Y030 { get; set; }
        public static string bX041Y031 { get; set; }
        public static string bX041Y032 { get; set; }
        public static string bX041Y033 { get; set; }
        public static string bX041Y034 { get; set; }
        public static string bX041Y035 { get; set; }
        public static string bX041Y036 { get; set; }
        public static string bX041Y037 { get; set; }
        public static string bX041Y038 { get; set; }
        public static string bX041Y039 { get; set; }
        public static string bX041Y040 { get; set; }
        public static string bX041Y041 { get; set; }
        public static string bX041Y042 { get; set; }
        public static string bX041Y043 { get; set; }
        public static string bX041Y044 { get; set; }
        public static string bX041Y045 { get; set; }
        public static string bX041Y046 { get; set; }
        public static string bX041Y047 { get; set; }
        public static string bX041Y048 { get; set; }
        public static string bX041Y049 { get; set; }
        public static string bX041Y050 { get; set; }
        public static string bX041Y051 { get; set; }
        public static string bX041Y052 { get; set; }
        public static string bX041Y053 { get; set; }
        public static string bX041Y054 { get; set; }
        public static string bX041Y055 { get; set; }
        public static string bX041Y056 { get; set; }
        public static string bX041Y057 { get; set; }
        public static string bX041Y058 { get; set; }
        public static string bX041Y059 { get; set; }
        public static string bX041Y060 { get; set; }
        public static string bX041Y061 { get; set; }
        public static string bX041Y062 { get; set; }
        public static string bX041Y063 { get; set; }

        public static string bX042Y000 { get; set; }
        public static string bX042Y001 { get; set; }
        public static string bX042Y002 { get; set; }
        public static string bX042Y003 { get; set; }
        public static string bX042Y004 { get; set; }
        public static string bX042Y005 { get; set; }
        public static string bX042Y006 { get; set; }
        public static string bX042Y007 { get; set; }
        public static string bX042Y008 { get; set; }
        public static string bX042Y009 { get; set; }
        public static string bX042Y010 { get; set; }
        public static string bX042Y011 { get; set; }
        public static string bX042Y012 { get; set; }
        public static string bX042Y013 { get; set; }
        public static string bX042Y014 { get; set; }
        public static string bX042Y015 { get; set; }
        public static string bX042Y016 { get; set; }
        public static string bX042Y017 { get; set; }
        public static string bX042Y018 { get; set; }
        public static string bX042Y019 { get; set; }
        public static string bX042Y020 { get; set; }
        public static string bX042Y021 { get; set; }
        public static string bX042Y022 { get; set; }
        public static string bX042Y023 { get; set; }
        public static string bX042Y024 { get; set; }
        public static string bX042Y025 { get; set; }
        public static string bX042Y026 { get; set; }
        public static string bX042Y027 { get; set; }
        public static string bX042Y028 { get; set; }
        public static string bX042Y029 { get; set; }
        public static string bX042Y030 { get; set; }
        public static string bX042Y031 { get; set; }
        public static string bX042Y032 { get; set; }
        public static string bX042Y033 { get; set; }
        public static string bX042Y034 { get; set; }
        public static string bX042Y035 { get; set; }
        public static string bX042Y036 { get; set; }
        public static string bX042Y037 { get; set; }
        public static string bX042Y038 { get; set; }
        public static string bX042Y039 { get; set; }
        public static string bX042Y040 { get; set; }
        public static string bX042Y041 { get; set; }
        public static string bX042Y042 { get; set; }
        public static string bX042Y043 { get; set; }
        public static string bX042Y044 { get; set; }
        public static string bX042Y045 { get; set; }
        public static string bX042Y046 { get; set; }
        public static string bX042Y047 { get; set; }
        public static string bX042Y048 { get; set; }
        public static string bX042Y049 { get; set; }
        public static string bX042Y050 { get; set; }
        public static string bX042Y051 { get; set; }
        public static string bX042Y052 { get; set; }
        public static string bX042Y053 { get; set; }
        public static string bX042Y054 { get; set; }
        public static string bX042Y055 { get; set; }
        public static string bX042Y056 { get; set; }
        public static string bX042Y057 { get; set; }
        public static string bX042Y058 { get; set; }
        public static string bX042Y059 { get; set; }
        public static string bX042Y060 { get; set; }
        public static string bX042Y061 { get; set; }
        public static string bX042Y062 { get; set; }
        public static string bX042Y063 { get; set; }

        public static string bX043Y000 { get; set; }
        public static string bX043Y001 { get; set; }
        public static string bX043Y002 { get; set; }
        public static string bX043Y003 { get; set; }
        public static string bX043Y004 { get; set; }
        public static string bX043Y005 { get; set; }
        public static string bX043Y006 { get; set; }
        public static string bX043Y007 { get; set; }
        public static string bX043Y008 { get; set; }
        public static string bX043Y009 { get; set; }
        public static string bX043Y010 { get; set; }
        public static string bX043Y011 { get; set; }
        public static string bX043Y012 { get; set; }
        public static string bX043Y013 { get; set; }
        public static string bX043Y014 { get; set; }
        public static string bX043Y015 { get; set; }
        public static string bX043Y016 { get; set; }
        public static string bX043Y017 { get; set; }
        public static string bX043Y018 { get; set; }
        public static string bX043Y019 { get; set; }
        public static string bX043Y020 { get; set; }
        public static string bX043Y021 { get; set; }
        public static string bX043Y022 { get; set; }
        public static string bX043Y023 { get; set; }
        public static string bX043Y024 { get; set; }
        public static string bX043Y025 { get; set; }
        public static string bX043Y026 { get; set; }
        public static string bX043Y027 { get; set; }
        public static string bX043Y028 { get; set; }
        public static string bX043Y029 { get; set; }
        public static string bX043Y030 { get; set; }
        public static string bX043Y031 { get; set; }
        public static string bX043Y032 { get; set; }
        public static string bX043Y033 { get; set; }
        public static string bX043Y034 { get; set; }
        public static string bX043Y035 { get; set; }
        public static string bX043Y036 { get; set; }
        public static string bX043Y037 { get; set; }
        public static string bX043Y038 { get; set; }
        public static string bX043Y039 { get; set; }
        public static string bX043Y040 { get; set; }
        public static string bX043Y041 { get; set; }
        public static string bX043Y042 { get; set; }
        public static string bX043Y043 { get; set; }
        public static string bX043Y044 { get; set; }
        public static string bX043Y045 { get; set; }
        public static string bX043Y046 { get; set; }
        public static string bX043Y047 { get; set; }
        public static string bX043Y048 { get; set; }
        public static string bX043Y049 { get; set; }
        public static string bX043Y050 { get; set; }
        public static string bX043Y051 { get; set; }
        public static string bX043Y052 { get; set; }
        public static string bX043Y053 { get; set; }
        public static string bX043Y054 { get; set; }
        public static string bX043Y055 { get; set; }
        public static string bX043Y056 { get; set; }
        public static string bX043Y057 { get; set; }
        public static string bX043Y058 { get; set; }
        public static string bX043Y059 { get; set; }
        public static string bX043Y060 { get; set; }
        public static string bX043Y061 { get; set; }
        public static string bX043Y062 { get; set; }
        public static string bX043Y063 { get; set; }

        public static string bX044Y000 { get; set; }
        public static string bX044Y001 { get; set; }
        public static string bX044Y002 { get; set; }
        public static string bX044Y003 { get; set; }
        public static string bX044Y004 { get; set; }
        public static string bX044Y005 { get; set; }
        public static string bX044Y006 { get; set; }
        public static string bX044Y007 { get; set; }
        public static string bX044Y008 { get; set; }
        public static string bX044Y009 { get; set; }
        public static string bX044Y010 { get; set; }
        public static string bX044Y011 { get; set; }
        public static string bX044Y012 { get; set; }
        public static string bX044Y013 { get; set; }
        public static string bX044Y014 { get; set; }
        public static string bX044Y015 { get; set; }
        public static string bX044Y016 { get; set; }
        public static string bX044Y017 { get; set; }
        public static string bX044Y018 { get; set; }
        public static string bX044Y019 { get; set; }
        public static string bX044Y020 { get; set; }
        public static string bX044Y021 { get; set; }
        public static string bX044Y022 { get; set; }
        public static string bX044Y023 { get; set; }
        public static string bX044Y024 { get; set; }
        public static string bX044Y025 { get; set; }
        public static string bX044Y026 { get; set; }
        public static string bX044Y027 { get; set; }
        public static string bX044Y028 { get; set; }
        public static string bX044Y029 { get; set; }
        public static string bX044Y030 { get; set; }
        public static string bX044Y031 { get; set; }
        public static string bX044Y032 { get; set; }
        public static string bX044Y033 { get; set; }
        public static string bX044Y034 { get; set; }
        public static string bX044Y035 { get; set; }
        public static string bX044Y036 { get; set; }
        public static string bX044Y037 { get; set; }
        public static string bX044Y038 { get; set; }
        public static string bX044Y039 { get; set; }
        public static string bX044Y040 { get; set; }
        public static string bX044Y041 { get; set; }
        public static string bX044Y042 { get; set; }
        public static string bX044Y043 { get; set; }
        public static string bX044Y044 { get; set; }
        public static string bX044Y045 { get; set; }
        public static string bX044Y046 { get; set; }
        public static string bX044Y047 { get; set; }
        public static string bX044Y048 { get; set; }
        public static string bX044Y049 { get; set; }
        public static string bX044Y050 { get; set; }
        public static string bX044Y051 { get; set; }
        public static string bX044Y052 { get; set; }
        public static string bX044Y053 { get; set; }
        public static string bX044Y054 { get; set; }
        public static string bX044Y055 { get; set; }
        public static string bX044Y056 { get; set; }
        public static string bX044Y057 { get; set; }
        public static string bX044Y058 { get; set; }
        public static string bX044Y059 { get; set; }
        public static string bX044Y060 { get; set; }
        public static string bX044Y061 { get; set; }
        public static string bX044Y062 { get; set; }
        public static string bX044Y063 { get; set; }

        public static string bX045Y000 { get; set; }
        public static string bX045Y001 { get; set; }
        public static string bX045Y002 { get; set; }
        public static string bX045Y003 { get; set; }
        public static string bX045Y004 { get; set; }
        public static string bX045Y005 { get; set; }
        public static string bX045Y006 { get; set; }
        public static string bX045Y007 { get; set; }
        public static string bX045Y008 { get; set; }
        public static string bX045Y009 { get; set; }
        public static string bX045Y010 { get; set; }
        public static string bX045Y011 { get; set; }
        public static string bX045Y012 { get; set; }
        public static string bX045Y013 { get; set; }
        public static string bX045Y014 { get; set; }
        public static string bX045Y015 { get; set; }
        public static string bX045Y016 { get; set; }
        public static string bX045Y017 { get; set; }
        public static string bX045Y018 { get; set; }
        public static string bX045Y019 { get; set; }
        public static string bX045Y020 { get; set; }
        public static string bX045Y021 { get; set; }
        public static string bX045Y022 { get; set; }
        public static string bX045Y023 { get; set; }
        public static string bX045Y024 { get; set; }
        public static string bX045Y025 { get; set; }
        public static string bX045Y026 { get; set; }
        public static string bX045Y027 { get; set; }
        public static string bX045Y028 { get; set; }
        public static string bX045Y029 { get; set; }
        public static string bX045Y030 { get; set; }
        public static string bX045Y031 { get; set; }
        public static string bX045Y032 { get; set; }
        public static string bX045Y033 { get; set; }
        public static string bX045Y034 { get; set; }
        public static string bX045Y035 { get; set; }
        public static string bX045Y036 { get; set; }
        public static string bX045Y037 { get; set; }
        public static string bX045Y038 { get; set; }
        public static string bX045Y039 { get; set; }
        public static string bX045Y040 { get; set; }
        public static string bX045Y041 { get; set; }
        public static string bX045Y042 { get; set; }
        public static string bX045Y043 { get; set; }
        public static string bX045Y044 { get; set; }
        public static string bX045Y045 { get; set; }
        public static string bX045Y046 { get; set; }
        public static string bX045Y047 { get; set; }
        public static string bX045Y048 { get; set; }
        public static string bX045Y049 { get; set; }
        public static string bX045Y050 { get; set; }
        public static string bX045Y051 { get; set; }
        public static string bX045Y052 { get; set; }
        public static string bX045Y053 { get; set; }
        public static string bX045Y054 { get; set; }
        public static string bX045Y055 { get; set; }
        public static string bX045Y056 { get; set; }
        public static string bX045Y057 { get; set; }
        public static string bX045Y058 { get; set; }
        public static string bX045Y059 { get; set; }
        public static string bX045Y060 { get; set; }
        public static string bX045Y061 { get; set; }
        public static string bX045Y062 { get; set; }
        public static string bX045Y063 { get; set; }

        public static string bX046Y000 { get; set; }
        public static string bX046Y001 { get; set; }
        public static string bX046Y002 { get; set; }
        public static string bX046Y003 { get; set; }
        public static string bX046Y004 { get; set; }
        public static string bX046Y005 { get; set; }
        public static string bX046Y006 { get; set; }
        public static string bX046Y007 { get; set; }
        public static string bX046Y008 { get; set; }
        public static string bX046Y009 { get; set; }
        public static string bX046Y010 { get; set; }
        public static string bX046Y011 { get; set; }
        public static string bX046Y012 { get; set; }
        public static string bX046Y013 { get; set; }
        public static string bX046Y014 { get; set; }
        public static string bX046Y015 { get; set; }
        public static string bX046Y016 { get; set; }
        public static string bX046Y017 { get; set; }
        public static string bX046Y018 { get; set; }
        public static string bX046Y019 { get; set; }
        public static string bX046Y020 { get; set; }
        public static string bX046Y021 { get; set; }
        public static string bX046Y022 { get; set; }
        public static string bX046Y023 { get; set; }
        public static string bX046Y024 { get; set; }
        public static string bX046Y025 { get; set; }
        public static string bX046Y026 { get; set; }
        public static string bX046Y027 { get; set; }
        public static string bX046Y028 { get; set; }
        public static string bX046Y029 { get; set; }
        public static string bX046Y030 { get; set; }
        public static string bX046Y031 { get; set; }
        public static string bX046Y032 { get; set; }
        public static string bX046Y033 { get; set; }
        public static string bX046Y034 { get; set; }
        public static string bX046Y035 { get; set; }
        public static string bX046Y036 { get; set; }
        public static string bX046Y037 { get; set; }
        public static string bX046Y038 { get; set; }
        public static string bX046Y039 { get; set; }
        public static string bX046Y040 { get; set; }
        public static string bX046Y041 { get; set; }
        public static string bX046Y042 { get; set; }
        public static string bX046Y043 { get; set; }
        public static string bX046Y044 { get; set; }
        public static string bX046Y045 { get; set; }
        public static string bX046Y046 { get; set; }
        public static string bX046Y047 { get; set; }
        public static string bX046Y048 { get; set; }
        public static string bX046Y049 { get; set; }
        public static string bX046Y050 { get; set; }
        public static string bX046Y051 { get; set; }
        public static string bX046Y052 { get; set; }
        public static string bX046Y053 { get; set; }
        public static string bX046Y054 { get; set; }
        public static string bX046Y055 { get; set; }
        public static string bX046Y056 { get; set; }
        public static string bX046Y057 { get; set; }
        public static string bX046Y058 { get; set; }
        public static string bX046Y059 { get; set; }
        public static string bX046Y060 { get; set; }
        public static string bX046Y061 { get; set; }
        public static string bX046Y062 { get; set; }
        public static string bX046Y063 { get; set; }

        public static string bX047Y000 { get; set; }
        public static string bX047Y001 { get; set; }
        public static string bX047Y002 { get; set; }
        public static string bX047Y003 { get; set; }
        public static string bX047Y004 { get; set; }
        public static string bX047Y005 { get; set; }
        public static string bX047Y006 { get; set; }
        public static string bX047Y007 { get; set; }
        public static string bX047Y008 { get; set; }
        public static string bX047Y009 { get; set; }
        public static string bX047Y010 { get; set; }
        public static string bX047Y011 { get; set; }
        public static string bX047Y012 { get; set; }
        public static string bX047Y013 { get; set; }
        public static string bX047Y014 { get; set; }
        public static string bX047Y015 { get; set; }
        public static string bX047Y016 { get; set; }
        public static string bX047Y017 { get; set; }
        public static string bX047Y018 { get; set; }
        public static string bX047Y019 { get; set; }
        public static string bX047Y020 { get; set; }
        public static string bX047Y021 { get; set; }
        public static string bX047Y022 { get; set; }
        public static string bX047Y023 { get; set; }
        public static string bX047Y024 { get; set; }
        public static string bX047Y025 { get; set; }
        public static string bX047Y026 { get; set; }
        public static string bX047Y027 { get; set; }
        public static string bX047Y028 { get; set; }
        public static string bX047Y029 { get; set; }
        public static string bX047Y030 { get; set; }
        public static string bX047Y031 { get; set; }
        public static string bX047Y032 { get; set; }
        public static string bX047Y033 { get; set; }
        public static string bX047Y034 { get; set; }
        public static string bX047Y035 { get; set; }
        public static string bX047Y036 { get; set; }
        public static string bX047Y037 { get; set; }
        public static string bX047Y038 { get; set; }
        public static string bX047Y039 { get; set; }
        public static string bX047Y040 { get; set; }
        public static string bX047Y041 { get; set; }
        public static string bX047Y042 { get; set; }
        public static string bX047Y043 { get; set; }
        public static string bX047Y044 { get; set; }
        public static string bX047Y045 { get; set; }
        public static string bX047Y046 { get; set; }
        public static string bX047Y047 { get; set; }
        public static string bX047Y048 { get; set; }
        public static string bX047Y049 { get; set; }
        public static string bX047Y050 { get; set; }
        public static string bX047Y051 { get; set; }
        public static string bX047Y052 { get; set; }
        public static string bX047Y053 { get; set; }
        public static string bX047Y054 { get; set; }
        public static string bX047Y055 { get; set; }
        public static string bX047Y056 { get; set; }
        public static string bX047Y057 { get; set; }
        public static string bX047Y058 { get; set; }
        public static string bX047Y059 { get; set; }
        public static string bX047Y060 { get; set; }
        public static string bX047Y061 { get; set; }
        public static string bX047Y062 { get; set; }
        public static string bX047Y063 { get; set; }

        public static string bX048Y000 { get; set; }
        public static string bX048Y001 { get; set; }
        public static string bX048Y002 { get; set; }
        public static string bX048Y003 { get; set; }
        public static string bX048Y004 { get; set; }
        public static string bX048Y005 { get; set; }
        public static string bX048Y006 { get; set; }
        public static string bX048Y007 { get; set; }
        public static string bX048Y008 { get; set; }
        public static string bX048Y009 { get; set; }
        public static string bX048Y010 { get; set; }
        public static string bX048Y011 { get; set; }
        public static string bX048Y012 { get; set; }
        public static string bX048Y013 { get; set; }
        public static string bX048Y014 { get; set; }
        public static string bX048Y015 { get; set; }
        public static string bX048Y016 { get; set; }
        public static string bX048Y017 { get; set; }
        public static string bX048Y018 { get; set; }
        public static string bX048Y019 { get; set; }
        public static string bX048Y020 { get; set; }
        public static string bX048Y021 { get; set; }
        public static string bX048Y022 { get; set; }
        public static string bX048Y023 { get; set; }
        public static string bX048Y024 { get; set; }
        public static string bX048Y025 { get; set; }
        public static string bX048Y026 { get; set; }
        public static string bX048Y027 { get; set; }
        public static string bX048Y028 { get; set; }
        public static string bX048Y029 { get; set; }
        public static string bX048Y030 { get; set; }
        public static string bX048Y031 { get; set; }
        public static string bX048Y032 { get; set; }
        public static string bX048Y033 { get; set; }
        public static string bX048Y034 { get; set; }
        public static string bX048Y035 { get; set; }
        public static string bX048Y036 { get; set; }
        public static string bX048Y037 { get; set; }
        public static string bX048Y038 { get; set; }
        public static string bX048Y039 { get; set; }
        public static string bX048Y040 { get; set; }
        public static string bX048Y041 { get; set; }
        public static string bX048Y042 { get; set; }
        public static string bX048Y043 { get; set; }
        public static string bX048Y044 { get; set; }
        public static string bX048Y045 { get; set; }
        public static string bX048Y046 { get; set; }
        public static string bX048Y047 { get; set; }
        public static string bX048Y048 { get; set; }
        public static string bX048Y049 { get; set; }
        public static string bX048Y050 { get; set; }
        public static string bX048Y051 { get; set; }
        public static string bX048Y052 { get; set; }
        public static string bX048Y053 { get; set; }
        public static string bX048Y054 { get; set; }
        public static string bX048Y055 { get; set; }
        public static string bX048Y056 { get; set; }
        public static string bX048Y057 { get; set; }
        public static string bX048Y058 { get; set; }
        public static string bX048Y059 { get; set; }
        public static string bX048Y060 { get; set; }
        public static string bX048Y061 { get; set; }
        public static string bX048Y062 { get; set; }
        public static string bX048Y063 { get; set; }

        public static string bX049Y000 { get; set; }
        public static string bX049Y001 { get; set; }
        public static string bX049Y002 { get; set; }
        public static string bX049Y003 { get; set; }
        public static string bX049Y004 { get; set; }
        public static string bX049Y005 { get; set; }
        public static string bX049Y006 { get; set; }
        public static string bX049Y007 { get; set; }
        public static string bX049Y008 { get; set; }
        public static string bX049Y009 { get; set; }
        public static string bX049Y010 { get; set; }
        public static string bX049Y011 { get; set; }
        public static string bX049Y012 { get; set; }
        public static string bX049Y013 { get; set; }
        public static string bX049Y014 { get; set; }
        public static string bX049Y015 { get; set; }
        public static string bX049Y016 { get; set; }
        public static string bX049Y017 { get; set; }
        public static string bX049Y018 { get; set; }
        public static string bX049Y019 { get; set; }
        public static string bX049Y020 { get; set; }
        public static string bX049Y021 { get; set; }
        public static string bX049Y022 { get; set; }
        public static string bX049Y023 { get; set; }
        public static string bX049Y024 { get; set; }
        public static string bX049Y025 { get; set; }
        public static string bX049Y026 { get; set; }
        public static string bX049Y027 { get; set; }
        public static string bX049Y028 { get; set; }
        public static string bX049Y029 { get; set; }
        public static string bX049Y030 { get; set; }
        public static string bX049Y031 { get; set; }
        public static string bX049Y032 { get; set; }
        public static string bX049Y033 { get; set; }
        public static string bX049Y034 { get; set; }
        public static string bX049Y035 { get; set; }
        public static string bX049Y036 { get; set; }
        public static string bX049Y037 { get; set; }
        public static string bX049Y038 { get; set; }
        public static string bX049Y039 { get; set; }
        public static string bX049Y040 { get; set; }
        public static string bX049Y041 { get; set; }
        public static string bX049Y042 { get; set; }
        public static string bX049Y043 { get; set; }
        public static string bX049Y044 { get; set; }
        public static string bX049Y045 { get; set; }
        public static string bX049Y046 { get; set; }
        public static string bX049Y047 { get; set; }
        public static string bX049Y048 { get; set; }
        public static string bX049Y049 { get; set; }
        public static string bX049Y050 { get; set; }
        public static string bX049Y051 { get; set; }
        public static string bX049Y052 { get; set; }
        public static string bX049Y053 { get; set; }
        public static string bX049Y054 { get; set; }
        public static string bX049Y055 { get; set; }
        public static string bX049Y056 { get; set; }
        public static string bX049Y057 { get; set; }
        public static string bX049Y058 { get; set; }
        public static string bX049Y059 { get; set; }
        public static string bX049Y060 { get; set; }
        public static string bX049Y061 { get; set; }
        public static string bX049Y062 { get; set; }
        public static string bX049Y063 { get; set; }

        public static string bX050Y000 { get; set; }
        public static string bX050Y001 { get; set; }
        public static string bX050Y002 { get; set; }
        public static string bX050Y003 { get; set; }
        public static string bX050Y004 { get; set; }
        public static string bX050Y005 { get; set; }
        public static string bX050Y006 { get; set; }
        public static string bX050Y007 { get; set; }
        public static string bX050Y008 { get; set; }
        public static string bX050Y009 { get; set; }
        public static string bX050Y010 { get; set; }
        public static string bX050Y011 { get; set; }
        public static string bX050Y012 { get; set; }
        public static string bX050Y013 { get; set; }
        public static string bX050Y014 { get; set; }
        public static string bX050Y015 { get; set; }
        public static string bX050Y016 { get; set; }
        public static string bX050Y017 { get; set; }
        public static string bX050Y018 { get; set; }
        public static string bX050Y019 { get; set; }
        public static string bX050Y020 { get; set; }
        public static string bX050Y021 { get; set; }
        public static string bX050Y022 { get; set; }
        public static string bX050Y023 { get; set; }
        public static string bX050Y024 { get; set; }
        public static string bX050Y025 { get; set; }
        public static string bX050Y026 { get; set; }
        public static string bX050Y027 { get; set; }
        public static string bX050Y028 { get; set; }
        public static string bX050Y029 { get; set; }
        public static string bX050Y030 { get; set; }
        public static string bX050Y031 { get; set; }
        public static string bX050Y032 { get; set; }
        public static string bX050Y033 { get; set; }
        public static string bX050Y034 { get; set; }
        public static string bX050Y035 { get; set; }
        public static string bX050Y036 { get; set; }
        public static string bX050Y037 { get; set; }
        public static string bX050Y038 { get; set; }
        public static string bX050Y039 { get; set; }
        public static string bX050Y040 { get; set; }
        public static string bX050Y041 { get; set; }
        public static string bX050Y042 { get; set; }
        public static string bX050Y043 { get; set; }
        public static string bX050Y044 { get; set; }
        public static string bX050Y045 { get; set; }
        public static string bX050Y046 { get; set; }
        public static string bX050Y047 { get; set; }
        public static string bX050Y048 { get; set; }
        public static string bX050Y049 { get; set; }
        public static string bX050Y050 { get; set; }
        public static string bX050Y051 { get; set; }
        public static string bX050Y052 { get; set; }
        public static string bX050Y053 { get; set; }
        public static string bX050Y054 { get; set; }
        public static string bX050Y055 { get; set; }
        public static string bX050Y056 { get; set; }
        public static string bX050Y057 { get; set; }
        public static string bX050Y058 { get; set; }
        public static string bX050Y059 { get; set; }
        public static string bX050Y060 { get; set; }
        public static string bX050Y061 { get; set; }
        public static string bX050Y062 { get; set; }
        public static string bX050Y063 { get; set; }

        public static string bX051Y000 { get; set; }
        public static string bX051Y001 { get; set; }
        public static string bX051Y002 { get; set; }
        public static string bX051Y003 { get; set; }
        public static string bX051Y004 { get; set; }
        public static string bX051Y005 { get; set; }
        public static string bX051Y006 { get; set; }
        public static string bX051Y007 { get; set; }
        public static string bX051Y008 { get; set; }
        public static string bX051Y009 { get; set; }
        public static string bX051Y010 { get; set; }
        public static string bX051Y011 { get; set; }
        public static string bX051Y012 { get; set; }
        public static string bX051Y013 { get; set; }
        public static string bX051Y014 { get; set; }
        public static string bX051Y015 { get; set; }
        public static string bX051Y016 { get; set; }
        public static string bX051Y017 { get; set; }
        public static string bX051Y018 { get; set; }
        public static string bX051Y019 { get; set; }
        public static string bX051Y020 { get; set; }
        public static string bX051Y021 { get; set; }
        public static string bX051Y022 { get; set; }
        public static string bX051Y023 { get; set; }
        public static string bX051Y024 { get; set; }
        public static string bX051Y025 { get; set; }
        public static string bX051Y026 { get; set; }
        public static string bX051Y027 { get; set; }
        public static string bX051Y028 { get; set; }
        public static string bX051Y029 { get; set; }
        public static string bX051Y030 { get; set; }
        public static string bX051Y031 { get; set; }
        public static string bX051Y032 { get; set; }
        public static string bX051Y033 { get; set; }
        public static string bX051Y034 { get; set; }
        public static string bX051Y035 { get; set; }
        public static string bX051Y036 { get; set; }
        public static string bX051Y037 { get; set; }
        public static string bX051Y038 { get; set; }
        public static string bX051Y039 { get; set; }
        public static string bX051Y040 { get; set; }
        public static string bX051Y041 { get; set; }
        public static string bX051Y042 { get; set; }
        public static string bX051Y043 { get; set; }
        public static string bX051Y044 { get; set; }
        public static string bX051Y045 { get; set; }
        public static string bX051Y046 { get; set; }
        public static string bX051Y047 { get; set; }
        public static string bX051Y048 { get; set; }
        public static string bX051Y049 { get; set; }
        public static string bX051Y050 { get; set; }
        public static string bX051Y051 { get; set; }
        public static string bX051Y052 { get; set; }
        public static string bX051Y053 { get; set; }
        public static string bX051Y054 { get; set; }
        public static string bX051Y055 { get; set; }
        public static string bX051Y056 { get; set; }
        public static string bX051Y057 { get; set; }
        public static string bX051Y058 { get; set; }
        public static string bX051Y059 { get; set; }
        public static string bX051Y060 { get; set; }
        public static string bX051Y061 { get; set; }
        public static string bX051Y062 { get; set; }
        public static string bX051Y063 { get; set; }

        public static string bX052Y000 { get; set; }
        public static string bX052Y001 { get; set; }
        public static string bX052Y002 { get; set; }
        public static string bX052Y003 { get; set; }
        public static string bX052Y004 { get; set; }
        public static string bX052Y005 { get; set; }
        public static string bX052Y006 { get; set; }
        public static string bX052Y007 { get; set; }
        public static string bX052Y008 { get; set; }
        public static string bX052Y009 { get; set; }
        public static string bX052Y010 { get; set; }
        public static string bX052Y011 { get; set; }
        public static string bX052Y012 { get; set; }
        public static string bX052Y013 { get; set; }
        public static string bX052Y014 { get; set; }
        public static string bX052Y015 { get; set; }
        public static string bX052Y016 { get; set; }
        public static string bX052Y017 { get; set; }
        public static string bX052Y018 { get; set; }
        public static string bX052Y019 { get; set; }
        public static string bX052Y020 { get; set; }
        public static string bX052Y021 { get; set; }
        public static string bX052Y022 { get; set; }
        public static string bX052Y023 { get; set; }
        public static string bX052Y024 { get; set; }
        public static string bX052Y025 { get; set; }
        public static string bX052Y026 { get; set; }
        public static string bX052Y027 { get; set; }
        public static string bX052Y028 { get; set; }
        public static string bX052Y029 { get; set; }
        public static string bX052Y030 { get; set; }
        public static string bX052Y031 { get; set; }
        public static string bX052Y032 { get; set; }
        public static string bX052Y033 { get; set; }
        public static string bX052Y034 { get; set; }
        public static string bX052Y035 { get; set; }
        public static string bX052Y036 { get; set; }
        public static string bX052Y037 { get; set; }
        public static string bX052Y038 { get; set; }
        public static string bX052Y039 { get; set; }
        public static string bX052Y040 { get; set; }
        public static string bX052Y041 { get; set; }
        public static string bX052Y042 { get; set; }
        public static string bX052Y043 { get; set; }
        public static string bX052Y044 { get; set; }
        public static string bX052Y045 { get; set; }
        public static string bX052Y046 { get; set; }
        public static string bX052Y047 { get; set; }
        public static string bX052Y048 { get; set; }
        public static string bX052Y049 { get; set; }
        public static string bX052Y050 { get; set; }
        public static string bX052Y051 { get; set; }
        public static string bX052Y052 { get; set; }
        public static string bX052Y053 { get; set; }
        public static string bX052Y054 { get; set; }
        public static string bX052Y055 { get; set; }
        public static string bX052Y056 { get; set; }
        public static string bX052Y057 { get; set; }
        public static string bX052Y058 { get; set; }
        public static string bX052Y059 { get; set; }
        public static string bX052Y060 { get; set; }
        public static string bX052Y061 { get; set; }
        public static string bX052Y062 { get; set; }
        public static string bX052Y063 { get; set; }

        public static string bX053Y000 { get; set; }
        public static string bX053Y001 { get; set; }
        public static string bX053Y002 { get; set; }
        public static string bX053Y003 { get; set; }
        public static string bX053Y004 { get; set; }
        public static string bX053Y005 { get; set; }
        public static string bX053Y006 { get; set; }
        public static string bX053Y007 { get; set; }
        public static string bX053Y008 { get; set; }
        public static string bX053Y009 { get; set; }
        public static string bX053Y010 { get; set; }
        public static string bX053Y011 { get; set; }
        public static string bX053Y012 { get; set; }
        public static string bX053Y013 { get; set; }
        public static string bX053Y014 { get; set; }
        public static string bX053Y015 { get; set; }
        public static string bX053Y016 { get; set; }
        public static string bX053Y017 { get; set; }
        public static string bX053Y018 { get; set; }
        public static string bX053Y019 { get; set; }
        public static string bX053Y020 { get; set; }
        public static string bX053Y021 { get; set; }
        public static string bX053Y022 { get; set; }
        public static string bX053Y023 { get; set; }
        public static string bX053Y024 { get; set; }
        public static string bX053Y025 { get; set; }
        public static string bX053Y026 { get; set; }
        public static string bX053Y027 { get; set; }
        public static string bX053Y028 { get; set; }
        public static string bX053Y029 { get; set; }
        public static string bX053Y030 { get; set; }
        public static string bX053Y031 { get; set; }
        public static string bX053Y032 { get; set; }
        public static string bX053Y033 { get; set; }
        public static string bX053Y034 { get; set; }
        public static string bX053Y035 { get; set; }
        public static string bX053Y036 { get; set; }
        public static string bX053Y037 { get; set; }
        public static string bX053Y038 { get; set; }
        public static string bX053Y039 { get; set; }
        public static string bX053Y040 { get; set; }
        public static string bX053Y041 { get; set; }
        public static string bX053Y042 { get; set; }
        public static string bX053Y043 { get; set; }
        public static string bX053Y044 { get; set; }
        public static string bX053Y045 { get; set; }
        public static string bX053Y046 { get; set; }
        public static string bX053Y047 { get; set; }
        public static string bX053Y048 { get; set; }
        public static string bX053Y049 { get; set; }
        public static string bX053Y050 { get; set; }
        public static string bX053Y051 { get; set; }
        public static string bX053Y052 { get; set; }
        public static string bX053Y053 { get; set; }
        public static string bX053Y054 { get; set; }
        public static string bX053Y055 { get; set; }
        public static string bX053Y056 { get; set; }
        public static string bX053Y057 { get; set; }
        public static string bX053Y058 { get; set; }
        public static string bX053Y059 { get; set; }
        public static string bX053Y060 { get; set; }
        public static string bX053Y061 { get; set; }
        public static string bX053Y062 { get; set; }
        public static string bX053Y063 { get; set; }

        public static string bX054Y000 { get; set; }
        public static string bX054Y001 { get; set; }
        public static string bX054Y002 { get; set; }
        public static string bX054Y003 { get; set; }
        public static string bX054Y004 { get; set; }
        public static string bX054Y005 { get; set; }
        public static string bX054Y006 { get; set; }
        public static string bX054Y007 { get; set; }
        public static string bX054Y008 { get; set; }
        public static string bX054Y009 { get; set; }
        public static string bX054Y010 { get; set; }
        public static string bX054Y011 { get; set; }
        public static string bX054Y012 { get; set; }
        public static string bX054Y013 { get; set; }
        public static string bX054Y014 { get; set; }
        public static string bX054Y015 { get; set; }
        public static string bX054Y016 { get; set; }
        public static string bX054Y017 { get; set; }
        public static string bX054Y018 { get; set; }
        public static string bX054Y019 { get; set; }
        public static string bX054Y020 { get; set; }
        public static string bX054Y021 { get; set; }
        public static string bX054Y022 { get; set; }
        public static string bX054Y023 { get; set; }
        public static string bX054Y024 { get; set; }
        public static string bX054Y025 { get; set; }
        public static string bX054Y026 { get; set; }
        public static string bX054Y027 { get; set; }
        public static string bX054Y028 { get; set; }
        public static string bX054Y029 { get; set; }
        public static string bX054Y030 { get; set; }
        public static string bX054Y031 { get; set; }
        public static string bX054Y032 { get; set; }
        public static string bX054Y033 { get; set; }
        public static string bX054Y034 { get; set; }
        public static string bX054Y035 { get; set; }
        public static string bX054Y036 { get; set; }
        public static string bX054Y037 { get; set; }
        public static string bX054Y038 { get; set; }
        public static string bX054Y039 { get; set; }
        public static string bX054Y040 { get; set; }
        public static string bX054Y041 { get; set; }
        public static string bX054Y042 { get; set; }
        public static string bX054Y043 { get; set; }
        public static string bX054Y044 { get; set; }
        public static string bX054Y045 { get; set; }
        public static string bX054Y046 { get; set; }
        public static string bX054Y047 { get; set; }
        public static string bX054Y048 { get; set; }
        public static string bX054Y049 { get; set; }
        public static string bX054Y050 { get; set; }
        public static string bX054Y051 { get; set; }
        public static string bX054Y052 { get; set; }
        public static string bX054Y053 { get; set; }
        public static string bX054Y054 { get; set; }
        public static string bX054Y055 { get; set; }
        public static string bX054Y056 { get; set; }
        public static string bX054Y057 { get; set; }
        public static string bX054Y058 { get; set; }
        public static string bX054Y059 { get; set; }
        public static string bX054Y060 { get; set; }
        public static string bX054Y061 { get; set; }
        public static string bX054Y062 { get; set; }
        public static string bX054Y063 { get; set; }

        public static string bX055Y000 { get; set; }
        public static string bX055Y001 { get; set; }
        public static string bX055Y002 { get; set; }
        public static string bX055Y003 { get; set; }
        public static string bX055Y004 { get; set; }
        public static string bX055Y005 { get; set; }
        public static string bX055Y006 { get; set; }
        public static string bX055Y007 { get; set; }
        public static string bX055Y008 { get; set; }
        public static string bX055Y009 { get; set; }
        public static string bX055Y010 { get; set; }
        public static string bX055Y011 { get; set; }
        public static string bX055Y012 { get; set; }
        public static string bX055Y013 { get; set; }
        public static string bX055Y014 { get; set; }
        public static string bX055Y015 { get; set; }
        public static string bX055Y016 { get; set; }
        public static string bX055Y017 { get; set; }
        public static string bX055Y018 { get; set; }
        public static string bX055Y019 { get; set; }
        public static string bX055Y020 { get; set; }
        public static string bX055Y021 { get; set; }
        public static string bX055Y022 { get; set; }
        public static string bX055Y023 { get; set; }
        public static string bX055Y024 { get; set; }
        public static string bX055Y025 { get; set; }
        public static string bX055Y026 { get; set; }
        public static string bX055Y027 { get; set; }
        public static string bX055Y028 { get; set; }
        public static string bX055Y029 { get; set; }
        public static string bX055Y030 { get; set; }
        public static string bX055Y031 { get; set; }
        public static string bX055Y032 { get; set; }
        public static string bX055Y033 { get; set; }
        public static string bX055Y034 { get; set; }
        public static string bX055Y035 { get; set; }
        public static string bX055Y036 { get; set; }
        public static string bX055Y037 { get; set; }
        public static string bX055Y038 { get; set; }
        public static string bX055Y039 { get; set; }
        public static string bX055Y040 { get; set; }
        public static string bX055Y041 { get; set; }
        public static string bX055Y042 { get; set; }
        public static string bX055Y043 { get; set; }
        public static string bX055Y044 { get; set; }
        public static string bX055Y045 { get; set; }
        public static string bX055Y046 { get; set; }
        public static string bX055Y047 { get; set; }
        public static string bX055Y048 { get; set; }
        public static string bX055Y049 { get; set; }
        public static string bX055Y050 { get; set; }
        public static string bX055Y051 { get; set; }
        public static string bX055Y052 { get; set; }
        public static string bX055Y053 { get; set; }
        public static string bX055Y054 { get; set; }
        public static string bX055Y055 { get; set; }
        public static string bX055Y056 { get; set; }
        public static string bX055Y057 { get; set; }
        public static string bX055Y058 { get; set; }
        public static string bX055Y059 { get; set; }
        public static string bX055Y060 { get; set; }
        public static string bX055Y061 { get; set; }
        public static string bX055Y062 { get; set; }
        public static string bX055Y063 { get; set; }

        public static string bX056Y000 { get; set; }
        public static string bX056Y001 { get; set; }
        public static string bX056Y002 { get; set; }
        public static string bX056Y003 { get; set; }
        public static string bX056Y004 { get; set; }
        public static string bX056Y005 { get; set; }
        public static string bX056Y006 { get; set; }
        public static string bX056Y007 { get; set; }
        public static string bX056Y008 { get; set; }
        public static string bX056Y009 { get; set; }
        public static string bX056Y010 { get; set; }
        public static string bX056Y011 { get; set; }
        public static string bX056Y012 { get; set; }
        public static string bX056Y013 { get; set; }
        public static string bX056Y014 { get; set; }
        public static string bX056Y015 { get; set; }
        public static string bX056Y016 { get; set; }
        public static string bX056Y017 { get; set; }
        public static string bX056Y018 { get; set; }
        public static string bX056Y019 { get; set; }
        public static string bX056Y020 { get; set; }
        public static string bX056Y021 { get; set; }
        public static string bX056Y022 { get; set; }
        public static string bX056Y023 { get; set; }
        public static string bX056Y024 { get; set; }
        public static string bX056Y025 { get; set; }
        public static string bX056Y026 { get; set; }
        public static string bX056Y027 { get; set; }
        public static string bX056Y028 { get; set; }
        public static string bX056Y029 { get; set; }
        public static string bX056Y030 { get; set; }
        public static string bX056Y031 { get; set; }
        public static string bX056Y032 { get; set; }
        public static string bX056Y033 { get; set; }
        public static string bX056Y034 { get; set; }
        public static string bX056Y035 { get; set; }
        public static string bX056Y036 { get; set; }
        public static string bX056Y037 { get; set; }
        public static string bX056Y038 { get; set; }
        public static string bX056Y039 { get; set; }
        public static string bX056Y040 { get; set; }
        public static string bX056Y041 { get; set; }
        public static string bX056Y042 { get; set; }
        public static string bX056Y043 { get; set; }
        public static string bX056Y044 { get; set; }
        public static string bX056Y045 { get; set; }
        public static string bX056Y046 { get; set; }
        public static string bX056Y047 { get; set; }
        public static string bX056Y048 { get; set; }
        public static string bX056Y049 { get; set; }
        public static string bX056Y050 { get; set; }
        public static string bX056Y051 { get; set; }
        public static string bX056Y052 { get; set; }
        public static string bX056Y053 { get; set; }
        public static string bX056Y054 { get; set; }
        public static string bX056Y055 { get; set; }
        public static string bX056Y056 { get; set; }
        public static string bX056Y057 { get; set; }
        public static string bX056Y058 { get; set; }
        public static string bX056Y059 { get; set; }
        public static string bX056Y060 { get; set; }
        public static string bX056Y061 { get; set; }
        public static string bX056Y062 { get; set; }
        public static string bX056Y063 { get; set; }
        public static string bX057Y000 { get; set; }
        public static string bX057Y001 { get; set; }
        public static string bX057Y002 { get; set; }
        public static string bX057Y003 { get; set; }
        public static string bX057Y004 { get; set; }
        public static string bX057Y005 { get; set; }
        public static string bX057Y006 { get; set; }
        public static string bX057Y007 { get; set; }
        public static string bX057Y008 { get; set; }
        public static string bX057Y009 { get; set; }
        public static string bX057Y010 { get; set; }
        public static string bX057Y011 { get; set; }
        public static string bX057Y012 { get; set; }
        public static string bX057Y013 { get; set; }
        public static string bX057Y014 { get; set; }
        public static string bX057Y015 { get; set; }
        public static string bX057Y016 { get; set; }
        public static string bX057Y017 { get; set; }
        public static string bX057Y018 { get; set; }
        public static string bX057Y019 { get; set; }
        public static string bX057Y020 { get; set; }
        public static string bX057Y021 { get; set; }
        public static string bX057Y022 { get; set; }
        public static string bX057Y023 { get; set; }
        public static string bX057Y024 { get; set; }
        public static string bX057Y025 { get; set; }
        public static string bX057Y026 { get; set; }
        public static string bX057Y027 { get; set; }
        public static string bX057Y028 { get; set; }
        public static string bX057Y029 { get; set; }
        public static string bX057Y030 { get; set; }
        public static string bX057Y031 { get; set; }
        public static string bX057Y032 { get; set; }
        public static string bX057Y033 { get; set; }
        public static string bX057Y034 { get; set; }
        public static string bX057Y035 { get; set; }
        public static string bX057Y036 { get; set; }
        public static string bX057Y037 { get; set; }
        public static string bX057Y038 { get; set; }
        public static string bX057Y039 { get; set; }
        public static string bX057Y040 { get; set; }
        public static string bX057Y041 { get; set; }
        public static string bX057Y042 { get; set; }
        public static string bX057Y043 { get; set; }
        public static string bX057Y044 { get; set; }
        public static string bX057Y045 { get; set; }
        public static string bX057Y046 { get; set; }
        public static string bX057Y047 { get; set; }
        public static string bX057Y048 { get; set; }
        public static string bX057Y049 { get; set; }
        public static string bX057Y050 { get; set; }
        public static string bX057Y051 { get; set; }
        public static string bX057Y052 { get; set; }
        public static string bX057Y053 { get; set; }
        public static string bX057Y054 { get; set; }
        public static string bX057Y055 { get; set; }
        public static string bX057Y056 { get; set; }
        public static string bX057Y057 { get; set; }
        public static string bX057Y058 { get; set; }
        public static string bX057Y059 { get; set; }
        public static string bX057Y060 { get; set; }
        public static string bX057Y061 { get; set; }
        public static string bX057Y062 { get; set; }
        public static string bX057Y063 { get; set; }
        public static string bX058Y000 { get; set; }
        public static string bX058Y001 { get; set; }
        public static string bX058Y002 { get; set; }
        public static string bX058Y003 { get; set; }
        public static string bX058Y004 { get; set; }
        public static string bX058Y005 { get; set; }
        public static string bX058Y006 { get; set; }
        public static string bX058Y007 { get; set; }
        public static string bX058Y008 { get; set; }
        public static string bX058Y009 { get; set; }
        public static string bX058Y010 { get; set; }
        public static string bX058Y011 { get; set; }
        public static string bX058Y012 { get; set; }
        public static string bX058Y013 { get; set; }
        public static string bX058Y014 { get; set; }
        public static string bX058Y015 { get; set; }
        public static string bX058Y016 { get; set; }
        public static string bX058Y017 { get; set; }
        public static string bX058Y018 { get; set; }
        public static string bX058Y019 { get; set; }
        public static string bX058Y020 { get; set; }
        public static string bX058Y021 { get; set; }
        public static string bX058Y022 { get; set; }
        public static string bX058Y023 { get; set; }
        public static string bX058Y024 { get; set; }
        public static string bX058Y025 { get; set; }
        public static string bX058Y026 { get; set; }
        public static string bX058Y027 { get; set; }
        public static string bX058Y028 { get; set; }
        public static string bX058Y029 { get; set; }
        public static string bX058Y030 { get; set; }
        public static string bX058Y031 { get; set; }
        public static string bX058Y032 { get; set; }
        public static string bX058Y033 { get; set; }
        public static string bX058Y034 { get; set; }
        public static string bX058Y035 { get; set; }
        public static string bX058Y036 { get; set; }
        public static string bX058Y037 { get; set; }
        public static string bX058Y038 { get; set; }
        public static string bX058Y039 { get; set; }
        public static string bX058Y040 { get; set; }
        public static string bX058Y041 { get; set; }
        public static string bX058Y042 { get; set; }
        public static string bX058Y043 { get; set; }
        public static string bX058Y044 { get; set; }
        public static string bX058Y045 { get; set; }
        public static string bX058Y046 { get; set; }
        public static string bX058Y047 { get; set; }
        public static string bX058Y048 { get; set; }
        public static string bX058Y049 { get; set; }
        public static string bX058Y050 { get; set; }
        public static string bX058Y051 { get; set; }
        public static string bX058Y052 { get; set; }
        public static string bX058Y053 { get; set; }
        public static string bX058Y054 { get; set; }
        public static string bX058Y055 { get; set; }
        public static string bX058Y056 { get; set; }
        public static string bX058Y057 { get; set; }
        public static string bX058Y058 { get; set; }
        public static string bX058Y059 { get; set; }
        public static string bX058Y060 { get; set; }
        public static string bX058Y061 { get; set; }
        public static string bX058Y062 { get; set; }
        public static string bX058Y063 { get; set; }

        public static string bX059Y000 { get; set; }
        public static string bX059Y001 { get; set; }
        public static string bX059Y002 { get; set; }
        public static string bX059Y003 { get; set; }
        public static string bX059Y004 { get; set; }
        public static string bX059Y005 { get; set; }
        public static string bX059Y006 { get; set; }
        public static string bX059Y007 { get; set; }
        public static string bX059Y008 { get; set; }
        public static string bX059Y009 { get; set; }
        public static string bX059Y010 { get; set; }
        public static string bX059Y011 { get; set; }
        public static string bX059Y012 { get; set; }
        public static string bX059Y013 { get; set; }
        public static string bX059Y014 { get; set; }
        public static string bX059Y015 { get; set; }
        public static string bX059Y016 { get; set; }
        public static string bX059Y017 { get; set; }
        public static string bX059Y018 { get; set; }
        public static string bX059Y019 { get; set; }
        public static string bX059Y020 { get; set; }
        public static string bX059Y021 { get; set; }
        public static string bX059Y022 { get; set; }
        public static string bX059Y023 { get; set; }
        public static string bX059Y024 { get; set; }
        public static string bX059Y025 { get; set; }
        public static string bX059Y026 { get; set; }
        public static string bX059Y027 { get; set; }
        public static string bX059Y028 { get; set; }
        public static string bX059Y029 { get; set; }
        public static string bX059Y030 { get; set; }
        public static string bX059Y031 { get; set; }
        public static string bX059Y032 { get; set; }
        public static string bX059Y033 { get; set; }
        public static string bX059Y034 { get; set; }
        public static string bX059Y035 { get; set; }
        public static string bX059Y036 { get; set; }
        public static string bX059Y037 { get; set; }
        public static string bX059Y038 { get; set; }
        public static string bX059Y039 { get; set; }
        public static string bX059Y040 { get; set; }
        public static string bX059Y041 { get; set; }
        public static string bX059Y042 { get; set; }
        public static string bX059Y043 { get; set; }
        public static string bX059Y044 { get; set; }
        public static string bX059Y045 { get; set; }
        public static string bX059Y046 { get; set; }
        public static string bX059Y047 { get; set; }
        public static string bX059Y048 { get; set; }
        public static string bX059Y049 { get; set; }
        public static string bX059Y050 { get; set; }
        public static string bX059Y051 { get; set; }
        public static string bX059Y052 { get; set; }
        public static string bX059Y053 { get; set; }
        public static string bX059Y054 { get; set; }
        public static string bX059Y055 { get; set; }
        public static string bX059Y056 { get; set; }
        public static string bX059Y057 { get; set; }
        public static string bX059Y058 { get; set; }
        public static string bX059Y059 { get; set; }
        public static string bX059Y060 { get; set; }
        public static string bX059Y061 { get; set; }
        public static string bX059Y062 { get; set; }
        public static string bX059Y063 { get; set; }

        public static string bX060Y000 { get; set; }
        public static string bX060Y001 { get; set; }
        public static string bX060Y002 { get; set; }
        public static string bX060Y003 { get; set; }
        public static string bX060Y004 { get; set; }
        public static string bX060Y005 { get; set; }
        public static string bX060Y006 { get; set; }
        public static string bX060Y007 { get; set; }
        public static string bX060Y008 { get; set; }
        public static string bX060Y009 { get; set; }
        public static string bX060Y010 { get; set; }
        public static string bX060Y011 { get; set; }
        public static string bX060Y012 { get; set; }
        public static string bX060Y013 { get; set; }
        public static string bX060Y014 { get; set; }
        public static string bX060Y015 { get; set; }
        public static string bX060Y016 { get; set; }
        public static string bX060Y017 { get; set; }
        public static string bX060Y018 { get; set; }
        public static string bX060Y019 { get; set; }
        public static string bX060Y020 { get; set; }
        public static string bX060Y021 { get; set; }
        public static string bX060Y022 { get; set; }
        public static string bX060Y023 { get; set; }
        public static string bX060Y024 { get; set; }
        public static string bX060Y025 { get; set; }
        public static string bX060Y026 { get; set; }
        public static string bX060Y027 { get; set; }
        public static string bX060Y028 { get; set; }
        public static string bX060Y029 { get; set; }
        public static string bX060Y030 { get; set; }
        public static string bX060Y031 { get; set; }
        public static string bX060Y032 { get; set; }
        public static string bX060Y033 { get; set; }
        public static string bX060Y034 { get; set; }
        public static string bX060Y035 { get; set; }
        public static string bX060Y036 { get; set; }
        public static string bX060Y037 { get; set; }
        public static string bX060Y038 { get; set; }
        public static string bX060Y039 { get; set; }
        public static string bX060Y040 { get; set; }
        public static string bX060Y041 { get; set; }
        public static string bX060Y042 { get; set; }
        public static string bX060Y043 { get; set; }
        public static string bX060Y044 { get; set; }
        public static string bX060Y045 { get; set; }
        public static string bX060Y046 { get; set; }
        public static string bX060Y047 { get; set; }
        public static string bX060Y048 { get; set; }
        public static string bX060Y049 { get; set; }
        public static string bX060Y050 { get; set; }
        public static string bX060Y051 { get; set; }
        public static string bX060Y052 { get; set; }
        public static string bX060Y053 { get; set; }
        public static string bX060Y054 { get; set; }
        public static string bX060Y055 { get; set; }
        public static string bX060Y056 { get; set; }
        public static string bX060Y057 { get; set; }
        public static string bX060Y058 { get; set; }
        public static string bX060Y059 { get; set; }
        public static string bX060Y060 { get; set; }
        public static string bX060Y061 { get; set; }
        public static string bX060Y062 { get; set; }
        public static string bX060Y063 { get; set; }

        public static string bX061Y000 { get; set; }
        public static string bX061Y001 { get; set; }
        public static string bX061Y002 { get; set; }
        public static string bX061Y003 { get; set; }
        public static string bX061Y004 { get; set; }
        public static string bX061Y005 { get; set; }
        public static string bX061Y006 { get; set; }
        public static string bX061Y007 { get; set; }
        public static string bX061Y008 { get; set; }
        public static string bX061Y009 { get; set; }
        public static string bX061Y010 { get; set; }
        public static string bX061Y011 { get; set; }
        public static string bX061Y012 { get; set; }
        public static string bX061Y013 { get; set; }
        public static string bX061Y014 { get; set; }
        public static string bX061Y015 { get; set; }
        public static string bX061Y016 { get; set; }
        public static string bX061Y017 { get; set; }
        public static string bX061Y018 { get; set; }
        public static string bX061Y019 { get; set; }
        public static string bX061Y020 { get; set; }
        public static string bX061Y021 { get; set; }
        public static string bX061Y022 { get; set; }
        public static string bX061Y023 { get; set; }
        public static string bX061Y024 { get; set; }
        public static string bX061Y025 { get; set; }
        public static string bX061Y026 { get; set; }
        public static string bX061Y027 { get; set; }
        public static string bX061Y028 { get; set; }
        public static string bX061Y029 { get; set; }
        public static string bX061Y030 { get; set; }
        public static string bX061Y031 { get; set; }
        public static string bX061Y032 { get; set; }
        public static string bX061Y033 { get; set; }
        public static string bX061Y034 { get; set; }
        public static string bX061Y035 { get; set; }
        public static string bX061Y036 { get; set; }
        public static string bX061Y037 { get; set; }
        public static string bX061Y038 { get; set; }
        public static string bX061Y039 { get; set; }
        public static string bX061Y040 { get; set; }
        public static string bX061Y041 { get; set; }
        public static string bX061Y042 { get; set; }
        public static string bX061Y043 { get; set; }
        public static string bX061Y044 { get; set; }
        public static string bX061Y045 { get; set; }
        public static string bX061Y046 { get; set; }
        public static string bX061Y047 { get; set; }
        public static string bX061Y048 { get; set; }
        public static string bX061Y049 { get; set; }
        public static string bX061Y050 { get; set; }
        public static string bX061Y051 { get; set; }
        public static string bX061Y052 { get; set; }
        public static string bX061Y053 { get; set; }
        public static string bX061Y054 { get; set; }
        public static string bX061Y055 { get; set; }
        public static string bX061Y056 { get; set; }
        public static string bX061Y057 { get; set; }
        public static string bX061Y058 { get; set; }
        public static string bX061Y059 { get; set; }
        public static string bX061Y060 { get; set; }
        public static string bX061Y061 { get; set; }
        public static string bX061Y062 { get; set; }
        public static string bX061Y063 { get; set; }

        public static string bX062Y000 { get; set; }
        public static string bX062Y001 { get; set; }
        public static string bX062Y002 { get; set; }
        public static string bX062Y003 { get; set; }
        public static string bX062Y004 { get; set; }
        public static string bX062Y005 { get; set; }
        public static string bX062Y006 { get; set; }
        public static string bX062Y007 { get; set; }
        public static string bX062Y008 { get; set; }
        public static string bX062Y009 { get; set; }
        public static string bX062Y010 { get; set; }
        public static string bX062Y011 { get; set; }
        public static string bX062Y012 { get; set; }
        public static string bX062Y013 { get; set; }
        public static string bX062Y014 { get; set; }
        public static string bX062Y015 { get; set; }
        public static string bX062Y016 { get; set; }
        public static string bX062Y017 { get; set; }
        public static string bX062Y018 { get; set; }
        public static string bX062Y019 { get; set; }
        public static string bX062Y020 { get; set; }
        public static string bX062Y021 { get; set; }
        public static string bX062Y022 { get; set; }
        public static string bX062Y023 { get; set; }
        public static string bX062Y024 { get; set; }
        public static string bX062Y025 { get; set; }
        public static string bX062Y026 { get; set; }
        public static string bX062Y027 { get; set; }
        public static string bX062Y028 { get; set; }
        public static string bX062Y029 { get; set; }
        public static string bX062Y030 { get; set; }
        public static string bX062Y031 { get; set; }
        public static string bX062Y032 { get; set; }
        public static string bX062Y033 { get; set; }
        public static string bX062Y034 { get; set; }
        public static string bX062Y035 { get; set; }
        public static string bX062Y036 { get; set; }
        public static string bX062Y037 { get; set; }
        public static string bX062Y038 { get; set; }
        public static string bX062Y039 { get; set; }
        public static string bX062Y040 { get; set; }
        public static string bX062Y041 { get; set; }
        public static string bX062Y042 { get; set; }
        public static string bX062Y043 { get; set; }
        public static string bX062Y044 { get; set; }
        public static string bX062Y045 { get; set; }
        public static string bX062Y046 { get; set; }
        public static string bX062Y047 { get; set; }
        public static string bX062Y048 { get; set; }
        public static string bX062Y049 { get; set; }
        public static string bX062Y050 { get; set; }
        public static string bX062Y051 { get; set; }
        public static string bX062Y052 { get; set; }
        public static string bX062Y053 { get; set; }
        public static string bX062Y054 { get; set; }
        public static string bX062Y055 { get; set; }
        public static string bX062Y056 { get; set; }
        public static string bX062Y057 { get; set; }
        public static string bX062Y058 { get; set; }
        public static string bX062Y059 { get; set; }
        public static string bX062Y060 { get; set; }
        public static string bX062Y061 { get; set; }
        public static string bX062Y062 { get; set; }
        public static string bX062Y063 { get; set; }

        public static string bX063Y000 { get; set; }
        public static string bX063Y001 { get; set; }
        public static string bX063Y002 { get; set; }
        public static string bX063Y003 { get; set; }
        public static string bX063Y004 { get; set; }
        public static string bX063Y005 { get; set; }
        public static string bX063Y006 { get; set; }
        public static string bX063Y007 { get; set; }
        public static string bX063Y008 { get; set; }
        public static string bX063Y009 { get; set; }
        public static string bX063Y010 { get; set; }
        public static string bX063Y011 { get; set; }
        public static string bX063Y012 { get; set; }
        public static string bX063Y013 { get; set; }
        public static string bX063Y014 { get; set; }
        public static string bX063Y015 { get; set; }
        public static string bX063Y016 { get; set; }
        public static string bX063Y017 { get; set; }
        public static string bX063Y018 { get; set; }
        public static string bX063Y019 { get; set; }
        public static string bX063Y020 { get; set; }
        public static string bX063Y021 { get; set; }
        public static string bX063Y022 { get; set; }
        public static string bX063Y023 { get; set; }
        public static string bX063Y024 { get; set; }
        public static string bX063Y025 { get; set; }
        public static string bX063Y026 { get; set; }
        public static string bX063Y027 { get; set; }
        public static string bX063Y028 { get; set; }
        public static string bX063Y029 { get; set; }
        public static string bX063Y030 { get; set; }
        public static string bX063Y031 { get; set; }
        public static string bX063Y032 { get; set; }
        public static string bX063Y033 { get; set; }
        public static string bX063Y034 { get; set; }
        public static string bX063Y035 { get; set; }
        public static string bX063Y036 { get; set; }
        public static string bX063Y037 { get; set; }
        public static string bX063Y038 { get; set; }
        public static string bX063Y039 { get; set; }
        public static string bX063Y040 { get; set; }
        public static string bX063Y041 { get; set; }
        public static string bX063Y042 { get; set; }
        public static string bX063Y043 { get; set; }
        public static string bX063Y044 { get; set; }
        public static string bX063Y045 { get; set; }
        public static string bX063Y046 { get; set; }
        public static string bX063Y047 { get; set; }
        public static string bX063Y048 { get; set; }
        public static string bX063Y049 { get; set; }
        public static string bX063Y050 { get; set; }
        public static string bX063Y051 { get; set; }
        public static string bX063Y052 { get; set; }
        public static string bX063Y053 { get; set; }
        public static string bX063Y054 { get; set; }
        public static string bX063Y055 { get; set; }
        public static string bX063Y056 { get; set; }
        public static string bX063Y057 { get; set; }
        public static string bX063Y058 { get; set; }
        public static string bX063Y059 { get; set; }
        public static string bX063Y060 { get; set; }
        public static string bX063Y061 { get; set; }
        public static string bX063Y062 { get; set; }
        public static string bX063Y063 { get; set; }


        private StateHandler myState = new StateHandler();
        private DateTime startTime = DateTime.Now;
        SoundPlayer startupsong = new SoundPlayer("Resources/done.wav");
        SoundPlayer completesong = new SoundPlayer("Resources/start.wav");
        SoundPlayer patsoft = new SoundPlayer("Resources/patsoft.wav");
        SoundPlayer patwarnings = new SoundPlayer("Resources/patwarning.wav");
        bool soundenabled = true;
        bool isShowingViz = false;
        int loopnum = 10;

        /* Unused Settings for message box to close itself, n shit */
        //  private bool m_killHim;
        //  private bool m_threadAlive;
        //  private Thread m_killThread;
        //  private const uint GW_HWNDFIRST = 0;
        //  private const int WM_CLOSE = 0x0010;
        //  [DllImport("coredll.dll", EntryPoint = "FindWindowW", SetLastError = true)]
        //  private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

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

        // We need to use unmanaged code

        [DllImport("user32.dll")]

        // GetCursorPos() makes everything possible

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
            button11.BackColor = Color.Transparent;
            button12.BackColor = Color.Transparent;
            button13.BackColor = Color.Transparent;
            button14.BackColor = Color.Transparent;
            button15.BackColor = Color.Transparent;
            ToolsPanel.BackColor = Color.Transparent;
            ToMainButton.BackColor = Color.Transparent;
            ToPanelButton.BackColor = Color.Transparent;
            ToolsPanel.Visible = false;
            ToMainButton.Visible = false;
            ConverterPanel.Visible = false;
            AudioPanel.Visible = false;
            FaunaPanel.Visible = false;
            ENVPanel.Visible = false;



            //       __________        __    __                    _________ __          .__                           //
            //       \______   \__ ___/  |__/  |_  ____   ____    /   _____//  |_ ___.__.|  |   ___________            //
            //        |    |  _/  |  \   __\   __\/  _ \ /    \   \_____  \\   __<   |  ||  | _/ __ \_  __ \           //
            //        |    |   \  |  /|  |  |  | (  <_> )   |  \  /        \|  |  \___  ||  |_\  ___/|  | \/           //
            //        |______  /____/ |__|  |__|  \____/|___|  / /_______  /|__|  / ____||____/\___  >__|              //
            //               \/                              \/          \/       \/               \/                  //

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
            mastercancel = true;
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
                mastercancel = true;
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


            ConverterPanel.Visible = false;
            AudioPanel.Visible = false;
            FaunaPanel.Visible = false;
            ENVPanel.Visible = false;

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

            ConverterPanel.Visible = false;
            AudioPanel.Visible = false;
            FaunaPanel.Visible = false;
            ENVPanel.Visible = false;

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

            ConverterPanel.Visible = false;
            AudioPanel.Visible = false;
            FaunaPanel.Visible = false;
            ENVPanel.Visible = false;

        }


        /******************************************* NAVIGATION BUTTONS ************************************/
        /******************************************* Tools menus ************************************/

        private void button10_Click(object sender, EventArgs e)
        {
            FaunaPanel.Visible = true;
            ConverterPanel.Visible = false;
            AudioPanel.Visible = false;
            ENVPanel.Visible = false;
            if (soundenabled == true)
            {
                System.Media.SoundPlayer sp = (patwarnings);
                sp.Play();
            };
            Console.WriteLine("Fauna Data Tools");
            richTextBox1.AppendText(Environment.NewLine + "Fauna Data Tools");
            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();



        }

        private void button9_Click(object sender, EventArgs e)
        {
            ENVPanel.Visible = true;
            ConverterPanel.Visible = false;
            AudioPanel.Visible = false;
            FaunaPanel.Visible = false;

            if (soundenabled == true)
            {
                System.Media.SoundPlayer sp = (patwarnings);
                sp.Play();
            };
            Console.WriteLine("Environment Data Tools");
            richTextBox1.AppendText(Environment.NewLine + "Environment Data Tools");
            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            AudioPanel.Visible = true;
            FaunaPanel.Visible = false;
            ENVPanel.Visible = false;
            ConverterPanel.Visible = false;

            if (soundenabled == true)
            {
                System.Media.SoundPlayer sp = (patwarnings);
                sp.Play();
            };
            Console.WriteLine("Audio Data Tools");
            richTextBox1.AppendText(Environment.NewLine + "Audio Data Tools");
            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }


        private void button11_Click_1(object sender, EventArgs e)
        {
            ConverterPanel.Visible = true;
            AudioPanel.Visible = false;
            FaunaPanel.Visible = false;
            ENVPanel.Visible = false;

            if (soundenabled == true)
            {
                System.Media.SoundPlayer sp = (patwarnings);
                sp.Play();
            };
            Console.WriteLine("Audio Converter Tools");
            richTextBox1.AppendText(Environment.NewLine + "Audio Converter Tools");
            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }


        // Visualizer for audio testing of frequencies

        private void button7_Click(object sender, EventArgs e)
        {

            if (isShowingViz == true)
            {
                bool isShowingViz = false;


            }
            else
            {
                bool isShowingViz = true;

            }



        }


        /******************************************* NAVIGATION BUTTONS ************************************/
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

        // ___________                            __________                                                       
        // \_   _____/____   __ __  ____ _____    \______   \_______  ____   ____  ____   ______ _________________ 
        //  |    __) \__  \ |  |  \/    \\__  \    |     ___/\_  __ \/  _ \_/ ___\/ __ \ /  ___//  ___/  _ \_  __ \
        //  |     \   / __ \|  |  /   |  \/ __ \_  |    |     |  | \(  <_> )  \__\  ___/ \___ \ \___ (  <_> )  | \/
        //  \___  /  (____  /____/|___|  (____  /  |____|     |__|   \____/ \___  >___  >____  >____  >____/|__|   
        //      \/        \/           \/     \/                                \/    \/     \/     \/             




        /******************************************* Fauna Type 12s ************************************/




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
                                { aX000Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX000Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX000Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX000Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX000Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX000Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX000Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX000Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX000Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX000Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX000Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX000Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 1)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX001Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX001Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX001Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX001Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX001Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX001Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX001Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX001Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX001Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX001Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX001Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX001Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 2)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX002Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX002Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX002Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX002Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX002Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX002Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX002Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX002Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX002Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX002Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX002Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX002Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 3)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX003Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX003Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX003Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX003Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX003Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX003Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX003Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX003Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX003Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX003Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX003Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX003Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 4)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX004Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX004Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX004Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX004Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX004Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX004Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX004Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX004Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX004Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX004Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX004Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX004Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 5)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX005Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX005Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX005Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX005Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX005Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX005Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX005Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX005Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX005Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX005Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX005Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX005Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 6)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX006Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX006Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX006Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX006Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX006Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX006Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX006Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX006Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX006Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX006Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX006Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX006Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 7)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX007Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX007Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX007Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX007Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX007Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX007Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX007Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX007Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX007Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX007Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX007Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX007Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 8)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX008Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX008Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX008Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX008Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX008Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX008Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX008Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX008Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX008Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX008Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX008Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX008Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 9)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX009Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX009Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX009Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX009Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX009Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX009Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX009Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX009Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX009Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX009Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX009Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX009Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 10)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX010Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX010Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX010Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX010Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX010Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX010Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX010Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX010Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX010Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX010Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX010Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX010Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 11)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX011Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX011Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX011Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX011Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX011Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX011Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX011Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX011Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX011Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX011Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX011Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX011Y011 = pixelColorStringValue; }
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
                dta.Rows.Add("cellX000", aX000Y000, aX000Y001, aX000Y002, aX000Y003, aX000Y004, aX000Y005, aX000Y006, aX000Y007, aX000Y008, aX000Y009, aX000Y010, aX000Y011);
                dta.Rows.Add("cellX001", aX001Y000, aX001Y001, aX001Y002, aX001Y003, aX001Y004, aX001Y005, aX001Y006, aX001Y007, aX001Y008, aX001Y009, aX001Y010, aX001Y011);
                dta.Rows.Add("cellX002", aX002Y000, aX002Y001, aX002Y002, aX002Y003, aX002Y004, aX002Y005, aX002Y006, aX002Y007, aX002Y008, aX002Y009, aX002Y010, aX002Y011);
                dta.Rows.Add("cellX003", aX003Y000, aX003Y001, aX003Y002, aX003Y003, aX003Y004, aX003Y005, aX003Y006, aX003Y007, aX003Y008, aX003Y009, aX003Y010, aX003Y011);
                dta.Rows.Add("cellX004", aX004Y000, aX004Y001, aX004Y002, aX004Y003, aX004Y004, aX004Y005, aX004Y006, aX004Y007, aX004Y008, aX004Y009, aX004Y010, aX004Y011);
                dta.Rows.Add("cellX005", aX005Y000, aX005Y001, aX005Y002, aX005Y003, aX005Y004, aX005Y005, aX005Y006, aX005Y007, aX005Y008, aX005Y009, aX005Y010, aX005Y011);
                dta.Rows.Add("cellX006", aX006Y000, aX006Y001, aX006Y002, aX006Y003, aX006Y004, aX006Y005, aX006Y006, aX006Y007, aX006Y008, aX006Y009, aX006Y010, aX006Y011);
                dta.Rows.Add("cellX007", aX007Y000, aX007Y001, aX007Y002, aX007Y003, aX007Y004, aX007Y005, aX007Y006, aX007Y007, aX007Y008, aX007Y009, aX007Y010, aX007Y011);
                dta.Rows.Add("cellX008", aX008Y000, aX008Y001, aX008Y002, aX008Y003, aX008Y004, aX008Y005, aX008Y006, aX008Y007, aX008Y008, aX008Y009, aX008Y010, aX008Y011);
                dta.Rows.Add("cellX009", aX009Y000, aX009Y001, aX009Y002, aX009Y003, aX009Y004, aX009Y005, aX009Y006, aX009Y007, aX009Y008, aX009Y009, aX009Y010, aX009Y011);
                dta.Rows.Add("cellX010", aX010Y000, aX010Y001, aX010Y002, aX010Y003, aX010Y004, aX010Y005, aX010Y006, aX010Y007, aX010Y008, aX010Y009, aX010Y010, aX010Y011);
                dta.Rows.Add("cellX011", aX011Y000, aX011Y001, aX011Y002, aX011Y003, aX011Y004, aX011Y005, aX011Y006, aX011Y007, aX011Y008, aX011Y009, aX011Y010, aX011Y011);


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






        /******************************************* TOOLS/ACTION BUTTONS ************************************/

        /* Action buttons in TOols frame */

        // ___________                            __________                                                       
        // \_   _____/____   __ __  ____ _____    \______   \_______  ____   ____  ____   ______ _________________ 
        //  |    __) \__  \ |  |  \/    \\__  \    |     ___/\_  __ \/  _ \_/ ___\/ __ \ /  ___//  ___/  _ \_  __ \
        //  |     \   / __ \|  |  /   |  \/ __ \_  |    |     |  | \(  <_> )  \__\  ___/ \___ \ \___ (  <_> )  | \/
        //  \___  /  (____  /____/|___|  (____  /  |____|     |__|   \____/ \___  >___  >____  >____  >____/|__|   
        //      \/        \/           \/     \/                                \/    \/     \/     \/             



        /******************************************* Fauna Type 64s ************************************/


        private void button4_Click(object sender, EventArgs e)
        {


            Console.WriteLine("Writing 64s clicked...");
            richTextBox1.AppendText(Environment.NewLine + "Writing 64s clicked...");
            int x, y;
            DataTable dta = new DataTable();
            dta.Columns.Add(" ");
            dta.Columns.Add("Type2CellY000");
            dta.Columns.Add("Type2CellY001");
            dta.Columns.Add("Type2CellY002");
            dta.Columns.Add("Type2CellY003");
            dta.Columns.Add("Type2CellY004");
            dta.Columns.Add("Type2CellY005");
            dta.Columns.Add("Type2CellY006");
            dta.Columns.Add("Type2CellY007");
            dta.Columns.Add("Type2CellY008");
            dta.Columns.Add("Type2CellY009");
            dta.Columns.Add("Type2CellY010");
            dta.Columns.Add("Type2CellY011");
            dta.Columns.Add("Type2CellY012");
            dta.Columns.Add("Type2CellY013");
            dta.Columns.Add("Type2CellY014");
            dta.Columns.Add("Type2CellY015");
            dta.Columns.Add("Type2CellY016");
            dta.Columns.Add("Type2CellY017");
            dta.Columns.Add("Type2CellY018");
            dta.Columns.Add("Type2CellY019");
            dta.Columns.Add("Type2CellY020");
            dta.Columns.Add("Type2CellY021");
            dta.Columns.Add("Type2CellY022");
            dta.Columns.Add("Type2CellY023");
            dta.Columns.Add("Type2CellY024");
            dta.Columns.Add("Type2CellY025");
            dta.Columns.Add("Type2CellY026");
            dta.Columns.Add("Type2CellY027");
            dta.Columns.Add("Type2CellY028");
            dta.Columns.Add("Type2CellY029");
            dta.Columns.Add("Type2CellY030");
            dta.Columns.Add("Type2CellY031");
            dta.Columns.Add("Type2CellY032");
            dta.Columns.Add("Type2CellY033");
            dta.Columns.Add("Type2CellY034");
            dta.Columns.Add("Type2CellY035");
            dta.Columns.Add("Type2CellY036");
            dta.Columns.Add("Type2CellY037");
            dta.Columns.Add("Type2CellY038");
            dta.Columns.Add("Type2CellY039");
            dta.Columns.Add("Type2CellY040");
            dta.Columns.Add("Type2CellY041");
            dta.Columns.Add("Type2CellY042");
            dta.Columns.Add("Type2CellY043");
            dta.Columns.Add("Type2CellY044");
            dta.Columns.Add("Type2CellY045");
            dta.Columns.Add("Type2CellY046");
            dta.Columns.Add("Type2CellY047");
            dta.Columns.Add("Type2CellY048");
            dta.Columns.Add("Type2CellY049");
            dta.Columns.Add("Type2CellY050");
            dta.Columns.Add("Type2CellY051");
            dta.Columns.Add("Type2CellY052");
            dta.Columns.Add("Type2CellY053");
            dta.Columns.Add("Type2CellY054");
            dta.Columns.Add("Type2CellY055");
            dta.Columns.Add("Type2CellY056");
            dta.Columns.Add("Type2CellY057");
            dta.Columns.Add("Type2CellY058");
            dta.Columns.Add("Type2CellY059");
            dta.Columns.Add("Type2CellY060");
            dta.Columns.Add("Type2CellY061");
            dta.Columns.Add("Type2CellY062");
            dta.Columns.Add("Type2CellY063");

            // string path = @"D:\UE4\Tailwind_R E B U I L D\Environment\Fauna Data\Type2s\PNGs_Type2\BMPs";
            string path = @"H:\UE4\Tailwind_R E B U I L D\Environment\World Machine 93e\PNGs\64\BMPs";
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

                    try
                    {
                        dta.Clear();
                    }
                    catch (DataException)
                    {

                    }
                    Console.WriteLine(file + " ... processing ...");


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

                                if (x == 0) { bX000Y000 = pixelColorStringValue; }
                                if (x == 1) { bX000Y001 = pixelColorStringValue; }
                                if (x == 2) { bX000Y002 = pixelColorStringValue; }
                                if (x == 3) { bX000Y003 = pixelColorStringValue; }
                                if (x == 4) { bX000Y004 = pixelColorStringValue; }
                                if (x == 5) { bX000Y005 = pixelColorStringValue; }
                                if (x == 6) { bX000Y006 = pixelColorStringValue; }
                                if (x == 7) { bX000Y007 = pixelColorStringValue; }
                                if (x == 8) { bX000Y008 = pixelColorStringValue; }
                                if (x == 9) { bX000Y009 = pixelColorStringValue; }
                                if (x == 10) { bX000Y010 = pixelColorStringValue; }
                                if (x == 11) { bX000Y011 = pixelColorStringValue; }
                                if (x == 12) { bX000Y012 = pixelColorStringValue; }
                                if (x == 13) { bX000Y013 = pixelColorStringValue; }
                                if (x == 14) { bX000Y014 = pixelColorStringValue; }
                                if (x == 15) { bX000Y015 = pixelColorStringValue; }
                                if (x == 16) { bX000Y016 = pixelColorStringValue; }
                                if (x == 17) { bX000Y017 = pixelColorStringValue; }
                                if (x == 18) { bX000Y018 = pixelColorStringValue; }
                                if (x == 19) { bX000Y019 = pixelColorStringValue; }
                                if (x == 20) { bX000Y020 = pixelColorStringValue; }
                                if (x == 21) { bX000Y021 = pixelColorStringValue; }
                                if (x == 22) { bX000Y022 = pixelColorStringValue; }
                                if (x == 23) { bX000Y023 = pixelColorStringValue; }
                                if (x == 24) { bX000Y024 = pixelColorStringValue; }
                                if (x == 25) { bX000Y025 = pixelColorStringValue; }
                                if (x == 26) { bX000Y026 = pixelColorStringValue; }
                                if (x == 27) { bX000Y027 = pixelColorStringValue; }
                                if (x == 28) { bX000Y028 = pixelColorStringValue; }
                                if (x == 29) { bX000Y029 = pixelColorStringValue; }
                                if (x == 30) { bX000Y030 = pixelColorStringValue; }
                                if (x == 31) { bX000Y031 = pixelColorStringValue; }
                                if (x == 32) { bX000Y032 = pixelColorStringValue; }
                                if (x == 33) { bX000Y033 = pixelColorStringValue; }
                                if (x == 34) { bX000Y034 = pixelColorStringValue; }
                                if (x == 35) { bX000Y035 = pixelColorStringValue; }
                                if (x == 36) { bX000Y036 = pixelColorStringValue; }
                                if (x == 37) { bX000Y037 = pixelColorStringValue; }
                                if (x == 38) { bX000Y038 = pixelColorStringValue; }
                                if (x == 39) { bX000Y039 = pixelColorStringValue; }
                                if (x == 40) { bX000Y040 = pixelColorStringValue; }
                                if (x == 41) { bX000Y041 = pixelColorStringValue; }
                                if (x == 42) { bX000Y042 = pixelColorStringValue; }
                                if (x == 43) { bX000Y043 = pixelColorStringValue; }
                                if (x == 44) { bX000Y044 = pixelColorStringValue; }
                                if (x == 45) { bX000Y045 = pixelColorStringValue; }
                                if (x == 46) { bX000Y046 = pixelColorStringValue; }
                                if (x == 47) { bX000Y047 = pixelColorStringValue; }
                                if (x == 48) { bX000Y048 = pixelColorStringValue; }
                                if (x == 49) { bX000Y049 = pixelColorStringValue; }
                                if (x == 50) { bX000Y050 = pixelColorStringValue; }
                                if (x == 51) { bX000Y051 = pixelColorStringValue; }
                                if (x == 52) { bX000Y052 = pixelColorStringValue; }
                                if (x == 53) { bX000Y053 = pixelColorStringValue; }
                                if (x == 54) { bX000Y054 = pixelColorStringValue; }
                                if (x == 55) { bX000Y055 = pixelColorStringValue; }
                                if (x == 56) { bX000Y056 = pixelColorStringValue; }
                                if (x == 57) { bX000Y057 = pixelColorStringValue; }
                                if (x == 58) { bX000Y058 = pixelColorStringValue; }
                                if (x == 59) { bX000Y059 = pixelColorStringValue; }
                                if (x == 60) { bX000Y060 = pixelColorStringValue; }
                                if (x == 61) { bX000Y061 = pixelColorStringValue; }
                                if (x == 62) { bX000Y062 = pixelColorStringValue; }
                                if (x == 63) { bX000Y063 = pixelColorStringValue; }

                            }
                            if (y == 1)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX001Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX001Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX001Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX001Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX001Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX001Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX001Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX001Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX001Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX001Y009 = pixelColorStringValue; }
                                if (x == 10) { bX001Y010 = pixelColorStringValue; }
                                if (x == 11) { bX001Y011 = pixelColorStringValue; }
                                if (x == 12) { bX001Y012 = pixelColorStringValue; }
                                if (x == 13) { bX001Y013 = pixelColorStringValue; }
                                if (x == 14) { bX001Y014 = pixelColorStringValue; }
                                if (x == 15) { bX001Y015 = pixelColorStringValue; }
                                if (x == 16) { bX001Y016 = pixelColorStringValue; }
                                if (x == 17) { bX001Y017 = pixelColorStringValue; }
                                if (x == 18) { bX001Y018 = pixelColorStringValue; }
                                if (x == 19) { bX001Y019 = pixelColorStringValue; }
                                if (x == 20) { bX001Y020 = pixelColorStringValue; }
                                if (x == 21) { bX001Y021 = pixelColorStringValue; }
                                if (x == 22) { bX001Y022 = pixelColorStringValue; }
                                if (x == 23) { bX001Y023 = pixelColorStringValue; }
                                if (x == 24) { bX001Y024 = pixelColorStringValue; }
                                if (x == 25) { bX001Y025 = pixelColorStringValue; }
                                if (x == 26) { bX001Y026 = pixelColorStringValue; }
                                if (x == 27) { bX001Y027 = pixelColorStringValue; }
                                if (x == 28) { bX001Y028 = pixelColorStringValue; }
                                if (x == 29) { bX001Y029 = pixelColorStringValue; }
                                if (x == 30) { bX001Y030 = pixelColorStringValue; }
                                if (x == 31) { bX001Y031 = pixelColorStringValue; }
                                if (x == 32) { bX001Y032 = pixelColorStringValue; }
                                if (x == 33) { bX001Y033 = pixelColorStringValue; }
                                if (x == 34) { bX001Y034 = pixelColorStringValue; }
                                if (x == 35) { bX001Y035 = pixelColorStringValue; }
                                if (x == 36) { bX001Y036 = pixelColorStringValue; }
                                if (x == 37) { bX001Y037 = pixelColorStringValue; }
                                if (x == 38) { bX001Y038 = pixelColorStringValue; }
                                if (x == 39) { bX001Y039 = pixelColorStringValue; }
                                if (x == 40) { bX001Y040 = pixelColorStringValue; }
                                if (x == 41) { bX001Y041 = pixelColorStringValue; }
                                if (x == 42) { bX001Y042 = pixelColorStringValue; }
                                if (x == 43) { bX001Y043 = pixelColorStringValue; }
                                if (x == 44) { bX001Y044 = pixelColorStringValue; }
                                if (x == 45) { bX001Y045 = pixelColorStringValue; }
                                if (x == 46) { bX001Y046 = pixelColorStringValue; }
                                if (x == 47) { bX001Y047 = pixelColorStringValue; }
                                if (x == 48) { bX001Y048 = pixelColorStringValue; }
                                if (x == 49) { bX001Y049 = pixelColorStringValue; }
                                if (x == 50) { bX001Y050 = pixelColorStringValue; }
                                if (x == 51) { bX001Y051 = pixelColorStringValue; }
                                if (x == 52) { bX001Y052 = pixelColorStringValue; }
                                if (x == 53) { bX001Y053 = pixelColorStringValue; }
                                if (x == 54) { bX001Y054 = pixelColorStringValue; }
                                if (x == 55) { bX001Y055 = pixelColorStringValue; }
                                if (x == 56) { bX001Y056 = pixelColorStringValue; }
                                if (x == 57) { bX001Y057 = pixelColorStringValue; }
                                if (x == 58) { bX001Y058 = pixelColorStringValue; }
                                if (x == 59) { bX001Y059 = pixelColorStringValue; }
                                if (x == 60) { bX001Y060 = pixelColorStringValue; }
                                if (x == 61) { bX001Y061 = pixelColorStringValue; }
                                if (x == 62) { bX001Y062 = pixelColorStringValue; }
                                if (x == 63) { bX001Y063 = pixelColorStringValue; }

                            }


                            if (y == 2)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX002Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX002Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX002Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX002Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX002Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX002Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX002Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX002Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX002Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX002Y009 = pixelColorStringValue; }
                                if (x == 10) { bX002Y010 = pixelColorStringValue; }
                                if (x == 11) { bX002Y011 = pixelColorStringValue; }
                                if (x == 12) { bX002Y012 = pixelColorStringValue; }
                                if (x == 13) { bX002Y013 = pixelColorStringValue; }
                                if (x == 14) { bX002Y014 = pixelColorStringValue; }
                                if (x == 15) { bX002Y015 = pixelColorStringValue; }
                                if (x == 16) { bX002Y016 = pixelColorStringValue; }
                                if (x == 17) { bX002Y017 = pixelColorStringValue; }
                                if (x == 18) { bX002Y018 = pixelColorStringValue; }
                                if (x == 19) { bX002Y019 = pixelColorStringValue; }
                                if (x == 20) { bX002Y020 = pixelColorStringValue; }
                                if (x == 21) { bX002Y021 = pixelColorStringValue; }
                                if (x == 22) { bX002Y022 = pixelColorStringValue; }
                                if (x == 23) { bX002Y023 = pixelColorStringValue; }
                                if (x == 24) { bX002Y024 = pixelColorStringValue; }
                                if (x == 25) { bX002Y025 = pixelColorStringValue; }
                                if (x == 26) { bX002Y026 = pixelColorStringValue; }
                                if (x == 27) { bX002Y027 = pixelColorStringValue; }
                                if (x == 28) { bX002Y028 = pixelColorStringValue; }
                                if (x == 29) { bX002Y029 = pixelColorStringValue; }
                                if (x == 30) { bX002Y030 = pixelColorStringValue; }
                                if (x == 31) { bX002Y031 = pixelColorStringValue; }
                                if (x == 32) { bX002Y032 = pixelColorStringValue; }
                                if (x == 33) { bX002Y033 = pixelColorStringValue; }
                                if (x == 34) { bX002Y034 = pixelColorStringValue; }
                                if (x == 35) { bX002Y035 = pixelColorStringValue; }
                                if (x == 36) { bX002Y036 = pixelColorStringValue; }
                                if (x == 37) { bX002Y037 = pixelColorStringValue; }
                                if (x == 38) { bX002Y038 = pixelColorStringValue; }
                                if (x == 39) { bX002Y039 = pixelColorStringValue; }
                                if (x == 40) { bX002Y040 = pixelColorStringValue; }
                                if (x == 41) { bX002Y041 = pixelColorStringValue; }
                                if (x == 42) { bX002Y042 = pixelColorStringValue; }
                                if (x == 43) { bX002Y043 = pixelColorStringValue; }
                                if (x == 44) { bX002Y044 = pixelColorStringValue; }
                                if (x == 45) { bX002Y045 = pixelColorStringValue; }
                                if (x == 46) { bX002Y046 = pixelColorStringValue; }
                                if (x == 47) { bX002Y047 = pixelColorStringValue; }
                                if (x == 48) { bX002Y048 = pixelColorStringValue; }
                                if (x == 49) { bX002Y049 = pixelColorStringValue; }
                                if (x == 50) { bX002Y050 = pixelColorStringValue; }
                                if (x == 51) { bX002Y051 = pixelColorStringValue; }
                                if (x == 52) { bX002Y052 = pixelColorStringValue; }
                                if (x == 53) { bX002Y053 = pixelColorStringValue; }
                                if (x == 54) { bX002Y054 = pixelColorStringValue; }
                                if (x == 55) { bX002Y055 = pixelColorStringValue; }
                                if (x == 56) { bX002Y056 = pixelColorStringValue; }
                                if (x == 57) { bX002Y057 = pixelColorStringValue; }
                                if (x == 58) { bX002Y058 = pixelColorStringValue; }
                                if (x == 59) { bX002Y059 = pixelColorStringValue; }
                                if (x == 60) { bX002Y060 = pixelColorStringValue; }
                                if (x == 61) { bX002Y061 = pixelColorStringValue; }
                                if (x == 62) { bX002Y062 = pixelColorStringValue; }
                                if (x == 63) { bX002Y063 = pixelColorStringValue; }

                            }

                            if (y == 3)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX003Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX003Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX003Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX003Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX003Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX003Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX003Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX003Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX003Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX003Y009 = pixelColorStringValue; }
                                if (x == 10) { bX003Y010 = pixelColorStringValue; }
                                if (x == 11) { bX003Y011 = pixelColorStringValue; }
                                if (x == 12) { bX003Y012 = pixelColorStringValue; }
                                if (x == 13) { bX003Y013 = pixelColorStringValue; }
                                if (x == 14) { bX003Y014 = pixelColorStringValue; }
                                if (x == 15) { bX003Y015 = pixelColorStringValue; }
                                if (x == 16) { bX003Y016 = pixelColorStringValue; }
                                if (x == 17) { bX003Y017 = pixelColorStringValue; }
                                if (x == 18) { bX003Y018 = pixelColorStringValue; }
                                if (x == 19) { bX003Y019 = pixelColorStringValue; }
                                if (x == 20) { bX003Y020 = pixelColorStringValue; }
                                if (x == 21) { bX003Y021 = pixelColorStringValue; }
                                if (x == 22) { bX003Y022 = pixelColorStringValue; }
                                if (x == 23) { bX003Y023 = pixelColorStringValue; }
                                if (x == 24) { bX003Y024 = pixelColorStringValue; }
                                if (x == 25) { bX003Y025 = pixelColorStringValue; }
                                if (x == 26) { bX003Y026 = pixelColorStringValue; }
                                if (x == 27) { bX003Y027 = pixelColorStringValue; }
                                if (x == 28) { bX003Y028 = pixelColorStringValue; }
                                if (x == 29) { bX003Y029 = pixelColorStringValue; }
                                if (x == 30) { bX003Y030 = pixelColorStringValue; }
                                if (x == 31) { bX003Y031 = pixelColorStringValue; }
                                if (x == 32) { bX003Y032 = pixelColorStringValue; }
                                if (x == 33) { bX003Y033 = pixelColorStringValue; }
                                if (x == 34) { bX003Y034 = pixelColorStringValue; }
                                if (x == 35) { bX003Y035 = pixelColorStringValue; }
                                if (x == 36) { bX003Y036 = pixelColorStringValue; }
                                if (x == 37) { bX003Y037 = pixelColorStringValue; }
                                if (x == 38) { bX003Y038 = pixelColorStringValue; }
                                if (x == 39) { bX003Y039 = pixelColorStringValue; }
                                if (x == 40) { bX003Y040 = pixelColorStringValue; }
                                if (x == 41) { bX003Y041 = pixelColorStringValue; }
                                if (x == 42) { bX003Y042 = pixelColorStringValue; }
                                if (x == 43) { bX003Y043 = pixelColorStringValue; }
                                if (x == 44) { bX003Y044 = pixelColorStringValue; }
                                if (x == 45) { bX003Y045 = pixelColorStringValue; }
                                if (x == 46) { bX003Y046 = pixelColorStringValue; }
                                if (x == 47) { bX003Y047 = pixelColorStringValue; }
                                if (x == 48) { bX003Y048 = pixelColorStringValue; }
                                if (x == 49) { bX003Y049 = pixelColorStringValue; }
                                if (x == 50) { bX003Y050 = pixelColorStringValue; }
                                if (x == 51) { bX003Y051 = pixelColorStringValue; }
                                if (x == 52) { bX003Y052 = pixelColorStringValue; }
                                if (x == 53) { bX003Y053 = pixelColorStringValue; }
                                if (x == 54) { bX003Y054 = pixelColorStringValue; }
                                if (x == 55) { bX003Y055 = pixelColorStringValue; }
                                if (x == 56) { bX003Y056 = pixelColorStringValue; }
                                if (x == 57) { bX003Y057 = pixelColorStringValue; }
                                if (x == 58) { bX003Y058 = pixelColorStringValue; }
                                if (x == 59) { bX003Y059 = pixelColorStringValue; }
                                if (x == 60) { bX003Y060 = pixelColorStringValue; }
                                if (x == 61) { bX003Y061 = pixelColorStringValue; }
                                if (x == 62) { bX003Y062 = pixelColorStringValue; }
                                if (x == 63) { bX003Y063 = pixelColorStringValue; }

                            }

                            if (y == 4)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX004Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX004Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX004Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX004Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX004Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX004Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX004Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX004Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX004Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX004Y009 = pixelColorStringValue; }
                                if (x == 10) { bX004Y010 = pixelColorStringValue; }
                                if (x == 11) { bX004Y011 = pixelColorStringValue; }
                                if (x == 12) { bX004Y012 = pixelColorStringValue; }
                                if (x == 13) { bX004Y013 = pixelColorStringValue; }
                                if (x == 14) { bX004Y014 = pixelColorStringValue; }
                                if (x == 15) { bX004Y015 = pixelColorStringValue; }
                                if (x == 16) { bX004Y016 = pixelColorStringValue; }
                                if (x == 17) { bX004Y017 = pixelColorStringValue; }
                                if (x == 18) { bX004Y018 = pixelColorStringValue; }
                                if (x == 19) { bX004Y019 = pixelColorStringValue; }
                                if (x == 20) { bX004Y020 = pixelColorStringValue; }
                                if (x == 21) { bX004Y021 = pixelColorStringValue; }
                                if (x == 22) { bX004Y022 = pixelColorStringValue; }
                                if (x == 23) { bX004Y023 = pixelColorStringValue; }
                                if (x == 24) { bX004Y024 = pixelColorStringValue; }
                                if (x == 25) { bX004Y025 = pixelColorStringValue; }
                                if (x == 26) { bX004Y026 = pixelColorStringValue; }
                                if (x == 27) { bX004Y027 = pixelColorStringValue; }
                                if (x == 28) { bX004Y028 = pixelColorStringValue; }
                                if (x == 29) { bX004Y029 = pixelColorStringValue; }
                                if (x == 30) { bX004Y030 = pixelColorStringValue; }
                                if (x == 31) { bX004Y031 = pixelColorStringValue; }
                                if (x == 32) { bX004Y032 = pixelColorStringValue; }
                                if (x == 33) { bX004Y033 = pixelColorStringValue; }
                                if (x == 34) { bX004Y034 = pixelColorStringValue; }
                                if (x == 35) { bX004Y035 = pixelColorStringValue; }
                                if (x == 36) { bX004Y036 = pixelColorStringValue; }
                                if (x == 37) { bX004Y037 = pixelColorStringValue; }
                                if (x == 38) { bX004Y038 = pixelColorStringValue; }
                                if (x == 39) { bX004Y039 = pixelColorStringValue; }
                                if (x == 40) { bX004Y040 = pixelColorStringValue; }
                                if (x == 41) { bX004Y041 = pixelColorStringValue; }
                                if (x == 42) { bX004Y042 = pixelColorStringValue; }
                                if (x == 43) { bX004Y043 = pixelColorStringValue; }
                                if (x == 44) { bX004Y044 = pixelColorStringValue; }
                                if (x == 45) { bX004Y045 = pixelColorStringValue; }
                                if (x == 46) { bX004Y046 = pixelColorStringValue; }
                                if (x == 47) { bX004Y047 = pixelColorStringValue; }
                                if (x == 48) { bX004Y048 = pixelColorStringValue; }
                                if (x == 49) { bX004Y049 = pixelColorStringValue; }
                                if (x == 50) { bX004Y050 = pixelColorStringValue; }
                                if (x == 51) { bX004Y051 = pixelColorStringValue; }
                                if (x == 52) { bX004Y052 = pixelColorStringValue; }
                                if (x == 53) { bX004Y053 = pixelColorStringValue; }
                                if (x == 54) { bX004Y054 = pixelColorStringValue; }
                                if (x == 55) { bX004Y055 = pixelColorStringValue; }
                                if (x == 56) { bX004Y056 = pixelColorStringValue; }
                                if (x == 57) { bX004Y057 = pixelColorStringValue; }
                                if (x == 58) { bX004Y058 = pixelColorStringValue; }
                                if (x == 59) { bX004Y059 = pixelColorStringValue; }
                                if (x == 60) { bX004Y060 = pixelColorStringValue; }
                                if (x == 61) { bX004Y061 = pixelColorStringValue; }
                                if (x == 62) { bX004Y062 = pixelColorStringValue; }
                                if (x == 63) { bX004Y063 = pixelColorStringValue; }

                            }

                            if (y == 5)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX005Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX005Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX005Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX005Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX005Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX005Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX005Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX005Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX005Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX005Y009 = pixelColorStringValue; }
                                if (x == 10) { bX005Y010 = pixelColorStringValue; }
                                if (x == 11) { bX005Y011 = pixelColorStringValue; }
                                if (x == 12) { bX005Y012 = pixelColorStringValue; }
                                if (x == 13) { bX005Y013 = pixelColorStringValue; }
                                if (x == 14) { bX005Y014 = pixelColorStringValue; }
                                if (x == 15) { bX005Y015 = pixelColorStringValue; }
                                if (x == 16) { bX005Y016 = pixelColorStringValue; }
                                if (x == 17) { bX005Y017 = pixelColorStringValue; }
                                if (x == 18) { bX005Y018 = pixelColorStringValue; }
                                if (x == 19) { bX005Y019 = pixelColorStringValue; }
                                if (x == 20) { bX005Y020 = pixelColorStringValue; }
                                if (x == 21) { bX005Y021 = pixelColorStringValue; }
                                if (x == 22) { bX005Y022 = pixelColorStringValue; }
                                if (x == 23) { bX005Y023 = pixelColorStringValue; }
                                if (x == 24) { bX005Y024 = pixelColorStringValue; }
                                if (x == 25) { bX005Y025 = pixelColorStringValue; }
                                if (x == 26) { bX005Y026 = pixelColorStringValue; }
                                if (x == 27) { bX005Y027 = pixelColorStringValue; }
                                if (x == 28) { bX005Y028 = pixelColorStringValue; }
                                if (x == 29) { bX005Y029 = pixelColorStringValue; }
                                if (x == 30) { bX005Y030 = pixelColorStringValue; }
                                if (x == 31) { bX005Y031 = pixelColorStringValue; }
                                if (x == 32) { bX005Y032 = pixelColorStringValue; }
                                if (x == 33) { bX005Y033 = pixelColorStringValue; }
                                if (x == 34) { bX005Y034 = pixelColorStringValue; }
                                if (x == 35) { bX005Y035 = pixelColorStringValue; }
                                if (x == 36) { bX005Y036 = pixelColorStringValue; }
                                if (x == 37) { bX005Y037 = pixelColorStringValue; }
                                if (x == 38) { bX005Y038 = pixelColorStringValue; }
                                if (x == 39) { bX005Y039 = pixelColorStringValue; }
                                if (x == 40) { bX005Y040 = pixelColorStringValue; }
                                if (x == 41) { bX005Y041 = pixelColorStringValue; }
                                if (x == 42) { bX005Y042 = pixelColorStringValue; }
                                if (x == 43) { bX005Y043 = pixelColorStringValue; }
                                if (x == 44) { bX005Y044 = pixelColorStringValue; }
                                if (x == 45) { bX005Y045 = pixelColorStringValue; }
                                if (x == 46) { bX005Y046 = pixelColorStringValue; }
                                if (x == 47) { bX005Y047 = pixelColorStringValue; }
                                if (x == 48) { bX005Y048 = pixelColorStringValue; }
                                if (x == 49) { bX005Y049 = pixelColorStringValue; }
                                if (x == 50) { bX005Y050 = pixelColorStringValue; }
                                if (x == 51) { bX005Y051 = pixelColorStringValue; }
                                if (x == 52) { bX005Y052 = pixelColorStringValue; }
                                if (x == 53) { bX005Y053 = pixelColorStringValue; }
                                if (x == 54) { bX005Y054 = pixelColorStringValue; }
                                if (x == 55) { bX005Y055 = pixelColorStringValue; }
                                if (x == 56) { bX005Y056 = pixelColorStringValue; }
                                if (x == 57) { bX005Y057 = pixelColorStringValue; }
                                if (x == 58) { bX005Y058 = pixelColorStringValue; }
                                if (x == 59) { bX005Y059 = pixelColorStringValue; }
                                if (x == 60) { bX005Y060 = pixelColorStringValue; }
                                if (x == 61) { bX005Y061 = pixelColorStringValue; }
                                if (x == 62) { bX005Y062 = pixelColorStringValue; }
                                if (x == 63) { bX005Y063 = pixelColorStringValue; }

                            }

                            if (y == 6)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0) { bX006Y000 = pixelColorStringValue; }
                                if (x == 1) { bX006Y001 = pixelColorStringValue; }
                                if (x == 2) { bX006Y002 = pixelColorStringValue; }
                                if (x == 3) { bX006Y003 = pixelColorStringValue; }
                                if (x == 4) { bX006Y004 = pixelColorStringValue; }
                                if (x == 5) { bX006Y005 = pixelColorStringValue; }
                                if (x == 6) { bX006Y006 = pixelColorStringValue; }
                                if (x == 7) { bX006Y007 = pixelColorStringValue; }
                                if (x == 8) { bX006Y008 = pixelColorStringValue; }
                                if (x == 9) { bX006Y009 = pixelColorStringValue; }
                                if (x == 10) { bX006Y010 = pixelColorStringValue; }
                                if (x == 11) { bX006Y011 = pixelColorStringValue; }
                                if (x == 12) { bX006Y012 = pixelColorStringValue; }
                                if (x == 13) { bX006Y013 = pixelColorStringValue; }
                                if (x == 14) { bX006Y014 = pixelColorStringValue; }
                                if (x == 15) { bX006Y015 = pixelColorStringValue; }
                                if (x == 16) { bX006Y016 = pixelColorStringValue; }
                                if (x == 17) { bX006Y017 = pixelColorStringValue; }
                                if (x == 18) { bX006Y018 = pixelColorStringValue; }
                                if (x == 19) { bX006Y019 = pixelColorStringValue; }
                                if (x == 20) { bX006Y020 = pixelColorStringValue; }
                                if (x == 21) { bX006Y021 = pixelColorStringValue; }
                                if (x == 22) { bX006Y022 = pixelColorStringValue; }
                                if (x == 23) { bX006Y023 = pixelColorStringValue; }
                                if (x == 24) { bX006Y024 = pixelColorStringValue; }
                                if (x == 25) { bX006Y025 = pixelColorStringValue; }
                                if (x == 26) { bX006Y026 = pixelColorStringValue; }
                                if (x == 27) { bX006Y027 = pixelColorStringValue; }
                                if (x == 28) { bX006Y028 = pixelColorStringValue; }
                                if (x == 29) { bX006Y029 = pixelColorStringValue; }
                                if (x == 30) { bX006Y030 = pixelColorStringValue; }
                                if (x == 31) { bX006Y031 = pixelColorStringValue; }
                                if (x == 32) { bX006Y032 = pixelColorStringValue; }
                                if (x == 33) { bX006Y033 = pixelColorStringValue; }
                                if (x == 34) { bX006Y034 = pixelColorStringValue; }
                                if (x == 35) { bX006Y035 = pixelColorStringValue; }
                                if (x == 36) { bX006Y036 = pixelColorStringValue; }
                                if (x == 37) { bX006Y037 = pixelColorStringValue; }
                                if (x == 38) { bX006Y038 = pixelColorStringValue; }
                                if (x == 39) { bX006Y039 = pixelColorStringValue; }
                                if (x == 40) { bX006Y040 = pixelColorStringValue; }
                                if (x == 41) { bX006Y041 = pixelColorStringValue; }
                                if (x == 42) { bX006Y042 = pixelColorStringValue; }
                                if (x == 43) { bX006Y043 = pixelColorStringValue; }
                                if (x == 44) { bX006Y044 = pixelColorStringValue; }
                                if (x == 45) { bX006Y045 = pixelColorStringValue; }
                                if (x == 46) { bX006Y046 = pixelColorStringValue; }
                                if (x == 47) { bX006Y047 = pixelColorStringValue; }
                                if (x == 48) { bX006Y048 = pixelColorStringValue; }
                                if (x == 49) { bX006Y049 = pixelColorStringValue; }
                                if (x == 50) { bX006Y050 = pixelColorStringValue; }
                                if (x == 51) { bX006Y051 = pixelColorStringValue; }
                                if (x == 52) { bX006Y052 = pixelColorStringValue; }
                                if (x == 53) { bX006Y053 = pixelColorStringValue; }
                                if (x == 54) { bX006Y054 = pixelColorStringValue; }
                                if (x == 55) { bX006Y055 = pixelColorStringValue; }
                                if (x == 56) { bX006Y056 = pixelColorStringValue; }
                                if (x == 57) { bX006Y057 = pixelColorStringValue; }
                                if (x == 58) { bX006Y058 = pixelColorStringValue; }
                                if (x == 59) { bX006Y059 = pixelColorStringValue; }
                                if (x == 60) { bX006Y060 = pixelColorStringValue; }
                                if (x == 61) { bX006Y061 = pixelColorStringValue; }
                                if (x == 62) { bX006Y062 = pixelColorStringValue; }
                                if (x == 63) { bX006Y063 = pixelColorStringValue; }
                            }

                            if (y == 7)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);


                                if (x == 0) { bX007Y000 = pixelColorStringValue; }
                                if (x == 1) { bX007Y001 = pixelColorStringValue; }
                                if (x == 2) { bX007Y002 = pixelColorStringValue; }
                                if (x == 3) { bX007Y003 = pixelColorStringValue; }
                                if (x == 4) { bX007Y004 = pixelColorStringValue; }
                                if (x == 5) { bX007Y005 = pixelColorStringValue; }
                                if (x == 6) { bX007Y006 = pixelColorStringValue; }
                                if (x == 7) { bX007Y007 = pixelColorStringValue; }
                                if (x == 8) { bX007Y008 = pixelColorStringValue; }
                                if (x == 9) { bX007Y009 = pixelColorStringValue; }
                                if (x == 10) { bX007Y010 = pixelColorStringValue; }
                                if (x == 11) { bX007Y011 = pixelColorStringValue; }
                                if (x == 12) { bX007Y012 = pixelColorStringValue; }
                                if (x == 13) { bX007Y013 = pixelColorStringValue; }
                                if (x == 14) { bX007Y014 = pixelColorStringValue; }
                                if (x == 15) { bX007Y015 = pixelColorStringValue; }
                                if (x == 16) { bX007Y016 = pixelColorStringValue; }
                                if (x == 17) { bX007Y017 = pixelColorStringValue; }
                                if (x == 18) { bX007Y018 = pixelColorStringValue; }
                                if (x == 19) { bX007Y019 = pixelColorStringValue; }
                                if (x == 20) { bX007Y020 = pixelColorStringValue; }
                                if (x == 21) { bX007Y021 = pixelColorStringValue; }
                                if (x == 22) { bX007Y022 = pixelColorStringValue; }
                                if (x == 23) { bX007Y023 = pixelColorStringValue; }
                                if (x == 24) { bX007Y024 = pixelColorStringValue; }
                                if (x == 25) { bX007Y025 = pixelColorStringValue; }
                                if (x == 26) { bX007Y026 = pixelColorStringValue; }
                                if (x == 27) { bX007Y027 = pixelColorStringValue; }
                                if (x == 28) { bX007Y028 = pixelColorStringValue; }
                                if (x == 29) { bX007Y029 = pixelColorStringValue; }
                                if (x == 30) { bX007Y030 = pixelColorStringValue; }
                                if (x == 31) { bX007Y031 = pixelColorStringValue; }
                                if (x == 32) { bX007Y032 = pixelColorStringValue; }
                                if (x == 33) { bX007Y033 = pixelColorStringValue; }
                                if (x == 34) { bX007Y034 = pixelColorStringValue; }
                                if (x == 35) { bX007Y035 = pixelColorStringValue; }
                                if (x == 36) { bX007Y036 = pixelColorStringValue; }
                                if (x == 37) { bX007Y037 = pixelColorStringValue; }
                                if (x == 38) { bX007Y038 = pixelColorStringValue; }
                                if (x == 39) { bX007Y039 = pixelColorStringValue; }
                                if (x == 40) { bX007Y040 = pixelColorStringValue; }
                                if (x == 41) { bX007Y041 = pixelColorStringValue; }
                                if (x == 42) { bX007Y042 = pixelColorStringValue; }
                                if (x == 43) { bX007Y043 = pixelColorStringValue; }
                                if (x == 44) { bX007Y044 = pixelColorStringValue; }
                                if (x == 45) { bX007Y045 = pixelColorStringValue; }
                                if (x == 46) { bX007Y046 = pixelColorStringValue; }
                                if (x == 47) { bX007Y047 = pixelColorStringValue; }
                                if (x == 48) { bX007Y048 = pixelColorStringValue; }
                                if (x == 49) { bX007Y049 = pixelColorStringValue; }
                                if (x == 50) { bX007Y050 = pixelColorStringValue; }
                                if (x == 51) { bX007Y051 = pixelColorStringValue; }
                                if (x == 52) { bX007Y052 = pixelColorStringValue; }
                                if (x == 53) { bX007Y053 = pixelColorStringValue; }
                                if (x == 54) { bX007Y054 = pixelColorStringValue; }
                                if (x == 55) { bX007Y055 = pixelColorStringValue; }
                                if (x == 56) { bX007Y056 = pixelColorStringValue; }
                                if (x == 57) { bX007Y057 = pixelColorStringValue; }
                                if (x == 58) { bX007Y058 = pixelColorStringValue; }
                                if (x == 59) { bX007Y059 = pixelColorStringValue; }
                                if (x == 60) { bX007Y060 = pixelColorStringValue; }
                                if (x == 61) { bX007Y061 = pixelColorStringValue; }
                                if (x == 62) { bX007Y062 = pixelColorStringValue; }
                                if (x == 63) { bX007Y063 = pixelColorStringValue; }
                            }

                            if (y == 8)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);


                                if (x == 0) { bX008Y000 = pixelColorStringValue; }
                                if (x == 1) { bX008Y001 = pixelColorStringValue; }
                                if (x == 2) { bX008Y002 = pixelColorStringValue; }
                                if (x == 3) { bX008Y003 = pixelColorStringValue; }
                                if (x == 4) { bX008Y004 = pixelColorStringValue; }
                                if (x == 5) { bX008Y005 = pixelColorStringValue; }
                                if (x == 6) { bX008Y006 = pixelColorStringValue; }
                                if (x == 7) { bX008Y007 = pixelColorStringValue; }
                                if (x == 8) { bX008Y008 = pixelColorStringValue; }
                                if (x == 9) { bX008Y009 = pixelColorStringValue; }
                                if (x == 10) { bX008Y010 = pixelColorStringValue; }
                                if (x == 11) { bX008Y011 = pixelColorStringValue; }
                                if (x == 12) { bX008Y012 = pixelColorStringValue; }
                                if (x == 13) { bX008Y013 = pixelColorStringValue; }
                                if (x == 14) { bX008Y014 = pixelColorStringValue; }
                                if (x == 15) { bX008Y015 = pixelColorStringValue; }
                                if (x == 16) { bX008Y016 = pixelColorStringValue; }
                                if (x == 17) { bX008Y017 = pixelColorStringValue; }
                                if (x == 18) { bX008Y018 = pixelColorStringValue; }
                                if (x == 19) { bX008Y019 = pixelColorStringValue; }
                                if (x == 20) { bX008Y020 = pixelColorStringValue; }
                                if (x == 21) { bX008Y021 = pixelColorStringValue; }
                                if (x == 22) { bX008Y022 = pixelColorStringValue; }
                                if (x == 23) { bX008Y023 = pixelColorStringValue; }
                                if (x == 24) { bX008Y024 = pixelColorStringValue; }
                                if (x == 25) { bX008Y025 = pixelColorStringValue; }
                                if (x == 26) { bX008Y026 = pixelColorStringValue; }
                                if (x == 27) { bX008Y027 = pixelColorStringValue; }
                                if (x == 28) { bX008Y028 = pixelColorStringValue; }
                                if (x == 29) { bX008Y029 = pixelColorStringValue; }
                                if (x == 30) { bX008Y030 = pixelColorStringValue; }
                                if (x == 31) { bX008Y031 = pixelColorStringValue; }
                                if (x == 32) { bX008Y032 = pixelColorStringValue; }
                                if (x == 33) { bX008Y033 = pixelColorStringValue; }
                                if (x == 34) { bX008Y034 = pixelColorStringValue; }
                                if (x == 35) { bX008Y035 = pixelColorStringValue; }
                                if (x == 36) { bX008Y036 = pixelColorStringValue; }
                                if (x == 37) { bX008Y037 = pixelColorStringValue; }
                                if (x == 38) { bX008Y038 = pixelColorStringValue; }
                                if (x == 39) { bX008Y039 = pixelColorStringValue; }
                                if (x == 40) { bX008Y040 = pixelColorStringValue; }
                                if (x == 41) { bX008Y041 = pixelColorStringValue; }
                                if (x == 42) { bX008Y042 = pixelColorStringValue; }
                                if (x == 43) { bX008Y043 = pixelColorStringValue; }
                                if (x == 44) { bX008Y044 = pixelColorStringValue; }
                                if (x == 45) { bX008Y045 = pixelColorStringValue; }
                                if (x == 46) { bX008Y046 = pixelColorStringValue; }
                                if (x == 47) { bX008Y047 = pixelColorStringValue; }
                                if (x == 48) { bX008Y048 = pixelColorStringValue; }
                                if (x == 49) { bX008Y049 = pixelColorStringValue; }
                                if (x == 50) { bX008Y050 = pixelColorStringValue; }
                                if (x == 51) { bX008Y051 = pixelColorStringValue; }
                                if (x == 52) { bX008Y052 = pixelColorStringValue; }
                                if (x == 53) { bX008Y053 = pixelColorStringValue; }
                                if (x == 54) { bX008Y054 = pixelColorStringValue; }
                                if (x == 55) { bX008Y055 = pixelColorStringValue; }
                                if (x == 56) { bX008Y056 = pixelColorStringValue; }
                                if (x == 57) { bX008Y057 = pixelColorStringValue; }
                                if (x == 58) { bX008Y058 = pixelColorStringValue; }
                                if (x == 59) { bX008Y059 = pixelColorStringValue; }
                                if (x == 60) { bX008Y060 = pixelColorStringValue; }
                                if (x == 61) { bX008Y061 = pixelColorStringValue; }
                                if (x == 62) { bX008Y062 = pixelColorStringValue; }
                                if (x == 63) { bX008Y063 = pixelColorStringValue; }
                            }

                            if (y == 9)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);


                                if (x == 0) { bX009Y000 = pixelColorStringValue; }
                                if (x == 1) { bX009Y001 = pixelColorStringValue; }
                                if (x == 2) { bX009Y002 = pixelColorStringValue; }
                                if (x == 3) { bX009Y003 = pixelColorStringValue; }
                                if (x == 4) { bX009Y004 = pixelColorStringValue; }
                                if (x == 5) { bX009Y005 = pixelColorStringValue; }
                                if (x == 6) { bX009Y006 = pixelColorStringValue; }
                                if (x == 7) { bX009Y007 = pixelColorStringValue; }
                                if (x == 8) { bX009Y008 = pixelColorStringValue; }
                                if (x == 9) { bX009Y009 = pixelColorStringValue; }
                                if (x == 10) { bX009Y010 = pixelColorStringValue; }
                                if (x == 11) { bX009Y011 = pixelColorStringValue; }
                                if (x == 12) { bX009Y012 = pixelColorStringValue; }
                                if (x == 13) { bX009Y013 = pixelColorStringValue; }
                                if (x == 14) { bX009Y014 = pixelColorStringValue; }
                                if (x == 15) { bX009Y015 = pixelColorStringValue; }
                                if (x == 16) { bX009Y016 = pixelColorStringValue; }
                                if (x == 17) { bX009Y017 = pixelColorStringValue; }
                                if (x == 18) { bX009Y018 = pixelColorStringValue; }
                                if (x == 19) { bX009Y019 = pixelColorStringValue; }
                                if (x == 20) { bX009Y020 = pixelColorStringValue; }
                                if (x == 21) { bX009Y021 = pixelColorStringValue; }
                                if (x == 22) { bX009Y022 = pixelColorStringValue; }
                                if (x == 23) { bX009Y023 = pixelColorStringValue; }
                                if (x == 24) { bX009Y024 = pixelColorStringValue; }
                                if (x == 25) { bX009Y025 = pixelColorStringValue; }
                                if (x == 26) { bX009Y026 = pixelColorStringValue; }
                                if (x == 27) { bX009Y027 = pixelColorStringValue; }
                                if (x == 28) { bX009Y028 = pixelColorStringValue; }
                                if (x == 29) { bX009Y029 = pixelColorStringValue; }
                                if (x == 30) { bX009Y030 = pixelColorStringValue; }
                                if (x == 31) { bX009Y031 = pixelColorStringValue; }
                                if (x == 32) { bX009Y032 = pixelColorStringValue; }
                                if (x == 33) { bX009Y033 = pixelColorStringValue; }
                                if (x == 34) { bX009Y034 = pixelColorStringValue; }
                                if (x == 35) { bX009Y035 = pixelColorStringValue; }
                                if (x == 36) { bX009Y036 = pixelColorStringValue; }
                                if (x == 37) { bX009Y037 = pixelColorStringValue; }
                                if (x == 38) { bX009Y038 = pixelColorStringValue; }
                                if (x == 39) { bX009Y039 = pixelColorStringValue; }
                                if (x == 40) { bX009Y040 = pixelColorStringValue; }
                                if (x == 41) { bX009Y041 = pixelColorStringValue; }
                                if (x == 42) { bX009Y042 = pixelColorStringValue; }
                                if (x == 43) { bX009Y043 = pixelColorStringValue; }
                                if (x == 44) { bX009Y044 = pixelColorStringValue; }
                                if (x == 45) { bX009Y045 = pixelColorStringValue; }
                                if (x == 46) { bX009Y046 = pixelColorStringValue; }
                                if (x == 47) { bX009Y047 = pixelColorStringValue; }
                                if (x == 48) { bX009Y048 = pixelColorStringValue; }
                                if (x == 49) { bX009Y049 = pixelColorStringValue; }
                                if (x == 50) { bX009Y050 = pixelColorStringValue; }
                                if (x == 51) { bX009Y051 = pixelColorStringValue; }
                                if (x == 52) { bX009Y052 = pixelColorStringValue; }
                                if (x == 53) { bX009Y053 = pixelColorStringValue; }
                                if (x == 54) { bX009Y054 = pixelColorStringValue; }
                                if (x == 55) { bX009Y055 = pixelColorStringValue; }
                                if (x == 56) { bX009Y056 = pixelColorStringValue; }
                                if (x == 57) { bX009Y057 = pixelColorStringValue; }
                                if (x == 58) { bX009Y058 = pixelColorStringValue; }
                                if (x == 59) { bX009Y059 = pixelColorStringValue; }
                                if (x == 60) { bX009Y060 = pixelColorStringValue; }
                                if (x == 61) { bX009Y061 = pixelColorStringValue; }
                                if (x == 62) { bX009Y062 = pixelColorStringValue; }
                                if (x == 63) { bX009Y063 = pixelColorStringValue; }
                            }

                            if (y == 10)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);


                                if (x == 0) { bX010Y000 = pixelColorStringValue; }
                                if (x == 1) { bX010Y001 = pixelColorStringValue; }
                                if (x == 2) { bX010Y002 = pixelColorStringValue; }
                                if (x == 3) { bX010Y003 = pixelColorStringValue; }
                                if (x == 4) { bX010Y004 = pixelColorStringValue; }
                                if (x == 5) { bX010Y005 = pixelColorStringValue; }
                                if (x == 6) { bX010Y006 = pixelColorStringValue; }
                                if (x == 7) { bX010Y007 = pixelColorStringValue; }
                                if (x == 8) { bX010Y008 = pixelColorStringValue; }
                                if (x == 9) { bX010Y009 = pixelColorStringValue; }
                                if (x == 10) { bX010Y010 = pixelColorStringValue; }
                                if (x == 11) { bX010Y011 = pixelColorStringValue; }
                                if (x == 12) { bX010Y012 = pixelColorStringValue; }
                                if (x == 13) { bX010Y013 = pixelColorStringValue; }
                                if (x == 14) { bX010Y014 = pixelColorStringValue; }
                                if (x == 15) { bX010Y015 = pixelColorStringValue; }
                                if (x == 16) { bX010Y016 = pixelColorStringValue; }
                                if (x == 17) { bX010Y017 = pixelColorStringValue; }
                                if (x == 18) { bX010Y018 = pixelColorStringValue; }
                                if (x == 19) { bX010Y019 = pixelColorStringValue; }
                                if (x == 20) { bX010Y020 = pixelColorStringValue; }
                                if (x == 21) { bX010Y021 = pixelColorStringValue; }
                                if (x == 22) { bX010Y022 = pixelColorStringValue; }
                                if (x == 23) { bX010Y023 = pixelColorStringValue; }
                                if (x == 24) { bX010Y024 = pixelColorStringValue; }
                                if (x == 25) { bX010Y025 = pixelColorStringValue; }
                                if (x == 26) { bX010Y026 = pixelColorStringValue; }
                                if (x == 27) { bX010Y027 = pixelColorStringValue; }
                                if (x == 28) { bX010Y028 = pixelColorStringValue; }
                                if (x == 29) { bX010Y029 = pixelColorStringValue; }
                                if (x == 30) { bX010Y030 = pixelColorStringValue; }
                                if (x == 31) { bX010Y031 = pixelColorStringValue; }
                                if (x == 32) { bX010Y032 = pixelColorStringValue; }
                                if (x == 33) { bX010Y033 = pixelColorStringValue; }
                                if (x == 34) { bX010Y034 = pixelColorStringValue; }
                                if (x == 35) { bX010Y035 = pixelColorStringValue; }
                                if (x == 36) { bX010Y036 = pixelColorStringValue; }
                                if (x == 37) { bX010Y037 = pixelColorStringValue; }
                                if (x == 38) { bX010Y038 = pixelColorStringValue; }
                                if (x == 39) { bX010Y039 = pixelColorStringValue; }
                                if (x == 40) { bX010Y040 = pixelColorStringValue; }
                                if (x == 41) { bX010Y041 = pixelColorStringValue; }
                                if (x == 42) { bX010Y042 = pixelColorStringValue; }
                                if (x == 43) { bX010Y043 = pixelColorStringValue; }
                                if (x == 44) { bX010Y044 = pixelColorStringValue; }
                                if (x == 45) { bX010Y045 = pixelColorStringValue; }
                                if (x == 46) { bX010Y046 = pixelColorStringValue; }
                                if (x == 47) { bX010Y047 = pixelColorStringValue; }
                                if (x == 48) { bX010Y048 = pixelColorStringValue; }
                                if (x == 49) { bX010Y049 = pixelColorStringValue; }
                                if (x == 50) { bX010Y050 = pixelColorStringValue; }
                                if (x == 51) { bX010Y051 = pixelColorStringValue; }
                                if (x == 52) { bX010Y052 = pixelColorStringValue; }
                                if (x == 53) { bX010Y053 = pixelColorStringValue; }
                                if (x == 54) { bX010Y054 = pixelColorStringValue; }
                                if (x == 55) { bX010Y055 = pixelColorStringValue; }
                                if (x == 56) { bX010Y056 = pixelColorStringValue; }
                                if (x == 57) { bX010Y057 = pixelColorStringValue; }
                                if (x == 58) { bX010Y058 = pixelColorStringValue; }
                                if (x == 59) { bX010Y059 = pixelColorStringValue; }
                                if (x == 60) { bX010Y060 = pixelColorStringValue; }
                                if (x == 61) { bX010Y061 = pixelColorStringValue; }
                                if (x == 62) { bX010Y062 = pixelColorStringValue; }
                                if (x == 63) { bX010Y063 = pixelColorStringValue; }
                            }

                            if (y == 11)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);


                                if (x == 0) { bX011Y000 = pixelColorStringValue; }
                                if (x == 1) { bX011Y001 = pixelColorStringValue; }
                                if (x == 2) { bX011Y002 = pixelColorStringValue; }
                                if (x == 3) { bX011Y003 = pixelColorStringValue; }
                                if (x == 4) { bX011Y004 = pixelColorStringValue; }
                                if (x == 5) { bX011Y005 = pixelColorStringValue; }
                                if (x == 6) { bX011Y006 = pixelColorStringValue; }
                                if (x == 7) { bX011Y007 = pixelColorStringValue; }
                                if (x == 8) { bX011Y008 = pixelColorStringValue; }
                                if (x == 9) { bX011Y009 = pixelColorStringValue; }
                                if (x == 10) { bX011Y010 = pixelColorStringValue; }
                                if (x == 11) { bX011Y011 = pixelColorStringValue; }
                                if (x == 12) { bX011Y012 = pixelColorStringValue; }
                                if (x == 13) { bX011Y013 = pixelColorStringValue; }
                                if (x == 14) { bX011Y014 = pixelColorStringValue; }
                                if (x == 15) { bX011Y015 = pixelColorStringValue; }
                                if (x == 16) { bX011Y016 = pixelColorStringValue; }
                                if (x == 17) { bX011Y017 = pixelColorStringValue; }
                                if (x == 18) { bX011Y018 = pixelColorStringValue; }
                                if (x == 19) { bX011Y019 = pixelColorStringValue; }
                                if (x == 20) { bX011Y020 = pixelColorStringValue; }
                                if (x == 21) { bX011Y021 = pixelColorStringValue; }
                                if (x == 22) { bX011Y022 = pixelColorStringValue; }
                                if (x == 23) { bX011Y023 = pixelColorStringValue; }
                                if (x == 24) { bX011Y024 = pixelColorStringValue; }
                                if (x == 25) { bX011Y025 = pixelColorStringValue; }
                                if (x == 26) { bX011Y026 = pixelColorStringValue; }
                                if (x == 27) { bX011Y027 = pixelColorStringValue; }
                                if (x == 28) { bX011Y028 = pixelColorStringValue; }
                                if (x == 29) { bX011Y029 = pixelColorStringValue; }
                                if (x == 30) { bX011Y030 = pixelColorStringValue; }
                                if (x == 31) { bX011Y031 = pixelColorStringValue; }
                                if (x == 32) { bX011Y032 = pixelColorStringValue; }
                                if (x == 33) { bX011Y033 = pixelColorStringValue; }
                                if (x == 34) { bX011Y034 = pixelColorStringValue; }
                                if (x == 35) { bX011Y035 = pixelColorStringValue; }
                                if (x == 36) { bX011Y036 = pixelColorStringValue; }
                                if (x == 37) { bX011Y037 = pixelColorStringValue; }
                                if (x == 38) { bX011Y038 = pixelColorStringValue; }
                                if (x == 39) { bX011Y039 = pixelColorStringValue; }
                                if (x == 40) { bX011Y040 = pixelColorStringValue; }
                                if (x == 41) { bX011Y041 = pixelColorStringValue; }
                                if (x == 42) { bX011Y042 = pixelColorStringValue; }
                                if (x == 43) { bX011Y043 = pixelColorStringValue; }
                                if (x == 44) { bX011Y044 = pixelColorStringValue; }
                                if (x == 45) { bX011Y045 = pixelColorStringValue; }
                                if (x == 46) { bX011Y046 = pixelColorStringValue; }
                                if (x == 47) { bX011Y047 = pixelColorStringValue; }
                                if (x == 48) { bX011Y048 = pixelColorStringValue; }
                                if (x == 49) { bX011Y049 = pixelColorStringValue; }
                                if (x == 50) { bX011Y050 = pixelColorStringValue; }
                                if (x == 51) { bX011Y051 = pixelColorStringValue; }
                                if (x == 52) { bX011Y052 = pixelColorStringValue; }
                                if (x == 53) { bX011Y053 = pixelColorStringValue; }
                                if (x == 54) { bX011Y054 = pixelColorStringValue; }
                                if (x == 55) { bX011Y055 = pixelColorStringValue; }
                                if (x == 56) { bX011Y056 = pixelColorStringValue; }
                                if (x == 57) { bX011Y057 = pixelColorStringValue; }
                                if (x == 58) { bX011Y058 = pixelColorStringValue; }
                                if (x == 59) { bX011Y059 = pixelColorStringValue; }
                                if (x == 60) { bX011Y060 = pixelColorStringValue; }
                                if (x == 61) { bX011Y061 = pixelColorStringValue; }
                                if (x == 62) { bX011Y062 = pixelColorStringValue; }
                                if (x == 63) { bX011Y063 = pixelColorStringValue; }
                            }

                            if (y == 12)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);


                                if (x == 0) { bX012Y000 = pixelColorStringValue; }
                                if (x == 1) { bX012Y001 = pixelColorStringValue; }
                                if (x == 2) { bX012Y002 = pixelColorStringValue; }
                                if (x == 3) { bX012Y003 = pixelColorStringValue; }
                                if (x == 4) { bX012Y004 = pixelColorStringValue; }
                                if (x == 5) { bX012Y005 = pixelColorStringValue; }
                                if (x == 6) { bX012Y006 = pixelColorStringValue; }
                                if (x == 7) { bX012Y007 = pixelColorStringValue; }
                                if (x == 8) { bX012Y008 = pixelColorStringValue; }
                                if (x == 9) { bX012Y009 = pixelColorStringValue; }
                                if (x == 10) { bX012Y010 = pixelColorStringValue; }
                                if (x == 11) { bX012Y011 = pixelColorStringValue; }
                                if (x == 12) { bX012Y012 = pixelColorStringValue; }
                                if (x == 13) { bX012Y013 = pixelColorStringValue; }
                                if (x == 14) { bX012Y014 = pixelColorStringValue; }
                                if (x == 15) { bX012Y015 = pixelColorStringValue; }
                                if (x == 16) { bX012Y016 = pixelColorStringValue; }
                                if (x == 17) { bX012Y017 = pixelColorStringValue; }
                                if (x == 18) { bX012Y018 = pixelColorStringValue; }
                                if (x == 19) { bX012Y019 = pixelColorStringValue; }
                                if (x == 20) { bX012Y020 = pixelColorStringValue; }
                                if (x == 21) { bX012Y021 = pixelColorStringValue; }
                                if (x == 22) { bX012Y022 = pixelColorStringValue; }
                                if (x == 23) { bX012Y023 = pixelColorStringValue; }
                                if (x == 24) { bX012Y024 = pixelColorStringValue; }
                                if (x == 25) { bX012Y025 = pixelColorStringValue; }
                                if (x == 26) { bX012Y026 = pixelColorStringValue; }
                                if (x == 27) { bX012Y027 = pixelColorStringValue; }
                                if (x == 28) { bX012Y028 = pixelColorStringValue; }
                                if (x == 29) { bX012Y029 = pixelColorStringValue; }
                                if (x == 30) { bX012Y030 = pixelColorStringValue; }
                                if (x == 31) { bX012Y031 = pixelColorStringValue; }
                                if (x == 32) { bX012Y032 = pixelColorStringValue; }
                                if (x == 33) { bX012Y033 = pixelColorStringValue; }
                                if (x == 34) { bX012Y034 = pixelColorStringValue; }
                                if (x == 35) { bX012Y035 = pixelColorStringValue; }
                                if (x == 36) { bX012Y036 = pixelColorStringValue; }
                                if (x == 37) { bX012Y037 = pixelColorStringValue; }
                                if (x == 38) { bX012Y038 = pixelColorStringValue; }
                                if (x == 39) { bX012Y039 = pixelColorStringValue; }
                                if (x == 40) { bX012Y040 = pixelColorStringValue; }
                                if (x == 41) { bX012Y041 = pixelColorStringValue; }
                                if (x == 42) { bX012Y042 = pixelColorStringValue; }
                                if (x == 43) { bX012Y043 = pixelColorStringValue; }
                                if (x == 44) { bX012Y044 = pixelColorStringValue; }
                                if (x == 45) { bX012Y045 = pixelColorStringValue; }
                                if (x == 46) { bX012Y046 = pixelColorStringValue; }
                                if (x == 47) { bX012Y047 = pixelColorStringValue; }
                                if (x == 48) { bX012Y048 = pixelColorStringValue; }
                                if (x == 49) { bX012Y049 = pixelColorStringValue; }
                                if (x == 50) { bX012Y050 = pixelColorStringValue; }
                                if (x == 51) { bX012Y051 = pixelColorStringValue; }
                                if (x == 52) { bX012Y052 = pixelColorStringValue; }
                                if (x == 53) { bX012Y053 = pixelColorStringValue; }
                                if (x == 54) { bX012Y054 = pixelColorStringValue; }
                                if (x == 55) { bX012Y055 = pixelColorStringValue; }
                                if (x == 56) { bX012Y056 = pixelColorStringValue; }
                                if (x == 57) { bX012Y057 = pixelColorStringValue; }
                                if (x == 58) { bX012Y058 = pixelColorStringValue; }
                                if (x == 59) { bX012Y059 = pixelColorStringValue; }
                                if (x == 60) { bX012Y060 = pixelColorStringValue; }
                                if (x == 61) { bX012Y061 = pixelColorStringValue; }
                                if (x == 62) { bX012Y062 = pixelColorStringValue; }
                                if (x == 63) { bX012Y063 = pixelColorStringValue; }
                            }

                            if (y == 13)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);


                                if (x == 0) { bX013Y000 = pixelColorStringValue; }
                                if (x == 1) { bX013Y001 = pixelColorStringValue; }
                                if (x == 2) { bX013Y002 = pixelColorStringValue; }
                                if (x == 3) { bX013Y003 = pixelColorStringValue; }
                                if (x == 4) { bX013Y004 = pixelColorStringValue; }
                                if (x == 5) { bX013Y005 = pixelColorStringValue; }
                                if (x == 6) { bX013Y006 = pixelColorStringValue; }
                                if (x == 7) { bX013Y007 = pixelColorStringValue; }
                                if (x == 8) { bX013Y008 = pixelColorStringValue; }
                                if (x == 9) { bX013Y009 = pixelColorStringValue; }
                                if (x == 10) { bX013Y010 = pixelColorStringValue; }
                                if (x == 11) { bX013Y011 = pixelColorStringValue; }
                                if (x == 12) { bX013Y012 = pixelColorStringValue; }
                                if (x == 13) { bX013Y013 = pixelColorStringValue; }
                                if (x == 14) { bX013Y014 = pixelColorStringValue; }
                                if (x == 15) { bX013Y015 = pixelColorStringValue; }
                                if (x == 16) { bX013Y016 = pixelColorStringValue; }
                                if (x == 17) { bX013Y017 = pixelColorStringValue; }
                                if (x == 18) { bX013Y018 = pixelColorStringValue; }
                                if (x == 19) { bX013Y019 = pixelColorStringValue; }
                                if (x == 20) { bX013Y020 = pixelColorStringValue; }
                                if (x == 21) { bX013Y021 = pixelColorStringValue; }
                                if (x == 22) { bX013Y022 = pixelColorStringValue; }
                                if (x == 23) { bX013Y023 = pixelColorStringValue; }
                                if (x == 24) { bX013Y024 = pixelColorStringValue; }
                                if (x == 25) { bX013Y025 = pixelColorStringValue; }
                                if (x == 26) { bX013Y026 = pixelColorStringValue; }
                                if (x == 27) { bX013Y027 = pixelColorStringValue; }
                                if (x == 28) { bX013Y028 = pixelColorStringValue; }
                                if (x == 29) { bX013Y029 = pixelColorStringValue; }
                                if (x == 30) { bX013Y030 = pixelColorStringValue; }
                                if (x == 31) { bX013Y031 = pixelColorStringValue; }
                                if (x == 32) { bX013Y032 = pixelColorStringValue; }
                                if (x == 33) { bX013Y033 = pixelColorStringValue; }
                                if (x == 34) { bX013Y034 = pixelColorStringValue; }
                                if (x == 35) { bX013Y035 = pixelColorStringValue; }
                                if (x == 36) { bX013Y036 = pixelColorStringValue; }
                                if (x == 37) { bX013Y037 = pixelColorStringValue; }
                                if (x == 38) { bX013Y038 = pixelColorStringValue; }
                                if (x == 39) { bX013Y039 = pixelColorStringValue; }
                                if (x == 40) { bX013Y040 = pixelColorStringValue; }
                                if (x == 41) { bX013Y041 = pixelColorStringValue; }
                                if (x == 42) { bX013Y042 = pixelColorStringValue; }
                                if (x == 43) { bX013Y043 = pixelColorStringValue; }
                                if (x == 44) { bX013Y044 = pixelColorStringValue; }
                                if (x == 45) { bX013Y045 = pixelColorStringValue; }
                                if (x == 46) { bX013Y046 = pixelColorStringValue; }
                                if (x == 47) { bX013Y047 = pixelColorStringValue; }
                                if (x == 48) { bX013Y048 = pixelColorStringValue; }
                                if (x == 49) { bX013Y049 = pixelColorStringValue; }
                                if (x == 50) { bX013Y050 = pixelColorStringValue; }
                                if (x == 51) { bX013Y051 = pixelColorStringValue; }
                                if (x == 52) { bX013Y052 = pixelColorStringValue; }
                                if (x == 53) { bX013Y053 = pixelColorStringValue; }
                                if (x == 54) { bX013Y054 = pixelColorStringValue; }
                                if (x == 55) { bX013Y055 = pixelColorStringValue; }
                                if (x == 56) { bX013Y056 = pixelColorStringValue; }
                                if (x == 57) { bX013Y057 = pixelColorStringValue; }
                                if (x == 58) { bX013Y058 = pixelColorStringValue; }
                                if (x == 59) { bX013Y059 = pixelColorStringValue; }
                                if (x == 60) { bX013Y060 = pixelColorStringValue; }
                                if (x == 61) { bX013Y061 = pixelColorStringValue; }
                                if (x == 62) { bX013Y062 = pixelColorStringValue; }
                                if (x == 63) { bX013Y063 = pixelColorStringValue; }
                            }

                            if (y == 14)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);


                                if (x == 0) { bX014Y000 = pixelColorStringValue; }
                                if (x == 1) { bX014Y001 = pixelColorStringValue; }
                                if (x == 2) { bX014Y002 = pixelColorStringValue; }
                                if (x == 3) { bX014Y003 = pixelColorStringValue; }
                                if (x == 4) { bX014Y004 = pixelColorStringValue; }
                                if (x == 5) { bX014Y005 = pixelColorStringValue; }
                                if (x == 6) { bX014Y006 = pixelColorStringValue; }
                                if (x == 7) { bX014Y007 = pixelColorStringValue; }
                                if (x == 8) { bX014Y008 = pixelColorStringValue; }
                                if (x == 9) { bX014Y009 = pixelColorStringValue; }
                                if (x == 10) { bX014Y010 = pixelColorStringValue; }
                                if (x == 11) { bX014Y011 = pixelColorStringValue; }
                                if (x == 12) { bX014Y012 = pixelColorStringValue; }
                                if (x == 13) { bX014Y013 = pixelColorStringValue; }
                                if (x == 14) { bX014Y014 = pixelColorStringValue; }
                                if (x == 15) { bX014Y015 = pixelColorStringValue; }
                                if (x == 16) { bX014Y016 = pixelColorStringValue; }
                                if (x == 17) { bX014Y017 = pixelColorStringValue; }
                                if (x == 18) { bX014Y018 = pixelColorStringValue; }
                                if (x == 19) { bX014Y019 = pixelColorStringValue; }
                                if (x == 20) { bX014Y020 = pixelColorStringValue; }
                                if (x == 21) { bX014Y021 = pixelColorStringValue; }
                                if (x == 22) { bX014Y022 = pixelColorStringValue; }
                                if (x == 23) { bX014Y023 = pixelColorStringValue; }
                                if (x == 24) { bX014Y024 = pixelColorStringValue; }
                                if (x == 25) { bX014Y025 = pixelColorStringValue; }
                                if (x == 26) { bX014Y026 = pixelColorStringValue; }
                                if (x == 27) { bX014Y027 = pixelColorStringValue; }
                                if (x == 28) { bX014Y028 = pixelColorStringValue; }
                                if (x == 29) { bX014Y029 = pixelColorStringValue; }
                                if (x == 30) { bX014Y030 = pixelColorStringValue; }
                                if (x == 31) { bX014Y031 = pixelColorStringValue; }
                                if (x == 32) { bX014Y032 = pixelColorStringValue; }
                                if (x == 33) { bX014Y033 = pixelColorStringValue; }
                                if (x == 34) { bX014Y034 = pixelColorStringValue; }
                                if (x == 35) { bX014Y035 = pixelColorStringValue; }
                                if (x == 36) { bX014Y036 = pixelColorStringValue; }
                                if (x == 37) { bX014Y037 = pixelColorStringValue; }
                                if (x == 38) { bX014Y038 = pixelColorStringValue; }
                                if (x == 39) { bX014Y039 = pixelColorStringValue; }
                                if (x == 40) { bX014Y040 = pixelColorStringValue; }
                                if (x == 41) { bX014Y041 = pixelColorStringValue; }
                                if (x == 42) { bX014Y042 = pixelColorStringValue; }
                                if (x == 43) { bX014Y043 = pixelColorStringValue; }
                                if (x == 44) { bX014Y044 = pixelColorStringValue; }
                                if (x == 45) { bX014Y045 = pixelColorStringValue; }
                                if (x == 46) { bX014Y046 = pixelColorStringValue; }
                                if (x == 47) { bX014Y047 = pixelColorStringValue; }
                                if (x == 48) { bX014Y048 = pixelColorStringValue; }
                                if (x == 49) { bX014Y049 = pixelColorStringValue; }
                                if (x == 50) { bX014Y050 = pixelColorStringValue; }
                                if (x == 51) { bX014Y051 = pixelColorStringValue; }
                                if (x == 52) { bX014Y052 = pixelColorStringValue; }
                                if (x == 53) { bX014Y053 = pixelColorStringValue; }
                                if (x == 54) { bX014Y054 = pixelColorStringValue; }
                                if (x == 55) { bX014Y055 = pixelColorStringValue; }
                                if (x == 56) { bX014Y056 = pixelColorStringValue; }
                                if (x == 57) { bX014Y057 = pixelColorStringValue; }
                                if (x == 58) { bX014Y058 = pixelColorStringValue; }
                                if (x == 59) { bX014Y059 = pixelColorStringValue; }
                                if (x == 60) { bX014Y060 = pixelColorStringValue; }
                                if (x == 61) { bX014Y061 = pixelColorStringValue; }
                                if (x == 62) { bX014Y062 = pixelColorStringValue; }
                                if (x == 63) { bX014Y063 = pixelColorStringValue; }
                            }

                            if (y == 15)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);


                                if (x == 0) { bX015Y000 = pixelColorStringValue; }
                                if (x == 1) { bX015Y001 = pixelColorStringValue; }
                                if (x == 2) { bX015Y002 = pixelColorStringValue; }
                                if (x == 3) { bX015Y003 = pixelColorStringValue; }
                                if (x == 4) { bX015Y004 = pixelColorStringValue; }
                                if (x == 5) { bX015Y005 = pixelColorStringValue; }
                                if (x == 6) { bX015Y006 = pixelColorStringValue; }
                                if (x == 7) { bX015Y007 = pixelColorStringValue; }
                                if (x == 8) { bX015Y008 = pixelColorStringValue; }
                                if (x == 9) { bX015Y009 = pixelColorStringValue; }
                                if (x == 10) { bX015Y010 = pixelColorStringValue; }
                                if (x == 11) { bX015Y011 = pixelColorStringValue; }
                                if (x == 12) { bX015Y012 = pixelColorStringValue; }
                                if (x == 13) { bX015Y013 = pixelColorStringValue; }
                                if (x == 14) { bX015Y014 = pixelColorStringValue; }
                                if (x == 15) { bX015Y015 = pixelColorStringValue; }
                                if (x == 16) { bX015Y016 = pixelColorStringValue; }
                                if (x == 17) { bX015Y017 = pixelColorStringValue; }
                                if (x == 18) { bX015Y018 = pixelColorStringValue; }
                                if (x == 19) { bX015Y019 = pixelColorStringValue; }
                                if (x == 20) { bX015Y020 = pixelColorStringValue; }
                                if (x == 21) { bX015Y021 = pixelColorStringValue; }
                                if (x == 22) { bX015Y022 = pixelColorStringValue; }
                                if (x == 23) { bX015Y023 = pixelColorStringValue; }
                                if (x == 24) { bX015Y024 = pixelColorStringValue; }
                                if (x == 25) { bX015Y025 = pixelColorStringValue; }
                                if (x == 26) { bX015Y026 = pixelColorStringValue; }
                                if (x == 27) { bX015Y027 = pixelColorStringValue; }
                                if (x == 28) { bX015Y028 = pixelColorStringValue; }
                                if (x == 29) { bX015Y029 = pixelColorStringValue; }
                                if (x == 30) { bX015Y030 = pixelColorStringValue; }
                                if (x == 31) { bX015Y031 = pixelColorStringValue; }
                                if (x == 32) { bX015Y032 = pixelColorStringValue; }
                                if (x == 33) { bX015Y033 = pixelColorStringValue; }
                                if (x == 34) { bX015Y034 = pixelColorStringValue; }
                                if (x == 35) { bX015Y035 = pixelColorStringValue; }
                                if (x == 36) { bX015Y036 = pixelColorStringValue; }
                                if (x == 37) { bX015Y037 = pixelColorStringValue; }
                                if (x == 38) { bX015Y038 = pixelColorStringValue; }
                                if (x == 39) { bX015Y039 = pixelColorStringValue; }
                                if (x == 40) { bX015Y040 = pixelColorStringValue; }
                                if (x == 41) { bX015Y041 = pixelColorStringValue; }
                                if (x == 42) { bX015Y042 = pixelColorStringValue; }
                                if (x == 43) { bX015Y043 = pixelColorStringValue; }
                                if (x == 44) { bX015Y044 = pixelColorStringValue; }
                                if (x == 45) { bX015Y045 = pixelColorStringValue; }
                                if (x == 46) { bX015Y046 = pixelColorStringValue; }
                                if (x == 47) { bX015Y047 = pixelColorStringValue; }
                                if (x == 48) { bX015Y048 = pixelColorStringValue; }
                                if (x == 49) { bX015Y049 = pixelColorStringValue; }
                                if (x == 50) { bX015Y050 = pixelColorStringValue; }
                                if (x == 51) { bX015Y051 = pixelColorStringValue; }
                                if (x == 52) { bX015Y052 = pixelColorStringValue; }
                                if (x == 53) { bX015Y053 = pixelColorStringValue; }
                                if (x == 54) { bX015Y054 = pixelColorStringValue; }
                                if (x == 55) { bX015Y055 = pixelColorStringValue; }
                                if (x == 56) { bX015Y056 = pixelColorStringValue; }
                                if (x == 57) { bX015Y057 = pixelColorStringValue; }
                                if (x == 58) { bX015Y058 = pixelColorStringValue; }
                                if (x == 59) { bX015Y059 = pixelColorStringValue; }
                                if (x == 60) { bX015Y060 = pixelColorStringValue; }
                                if (x == 61) { bX015Y061 = pixelColorStringValue; }
                                if (x == 62) { bX015Y062 = pixelColorStringValue; }
                                if (x == 63) { bX015Y063 = pixelColorStringValue; }
                            }

                            if (y == 16)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0) { bX016Y000 = pixelColorStringValue; }
                                if (x == 1) { bX016Y001 = pixelColorStringValue; }
                                if (x == 2) { bX016Y002 = pixelColorStringValue; }
                                if (x == 3) { bX016Y003 = pixelColorStringValue; }
                                if (x == 4) { bX016Y004 = pixelColorStringValue; }
                                if (x == 5) { bX016Y005 = pixelColorStringValue; }
                                if (x == 6) { bX016Y006 = pixelColorStringValue; }
                                if (x == 7) { bX016Y007 = pixelColorStringValue; }
                                if (x == 8) { bX016Y008 = pixelColorStringValue; }
                                if (x == 9) { bX016Y009 = pixelColorStringValue; }
                                if (x == 10) { bX016Y010 = pixelColorStringValue; }
                                if (x == 11) { bX016Y011 = pixelColorStringValue; }
                                if (x == 12) { bX016Y012 = pixelColorStringValue; }
                                if (x == 13) { bX016Y013 = pixelColorStringValue; }
                                if (x == 14) { bX016Y014 = pixelColorStringValue; }
                                if (x == 15) { bX016Y015 = pixelColorStringValue; }
                                if (x == 16) { bX016Y016 = pixelColorStringValue; }
                                if (x == 17) { bX016Y017 = pixelColorStringValue; }
                                if (x == 18) { bX016Y018 = pixelColorStringValue; }
                                if (x == 19) { bX016Y019 = pixelColorStringValue; }
                                if (x == 20) { bX016Y020 = pixelColorStringValue; }
                                if (x == 21) { bX016Y021 = pixelColorStringValue; }
                                if (x == 22) { bX016Y022 = pixelColorStringValue; }
                                if (x == 23) { bX016Y023 = pixelColorStringValue; }
                                if (x == 24) { bX016Y024 = pixelColorStringValue; }
                                if (x == 25) { bX016Y025 = pixelColorStringValue; }
                                if (x == 26) { bX016Y026 = pixelColorStringValue; }
                                if (x == 27) { bX016Y027 = pixelColorStringValue; }
                                if (x == 28) { bX016Y028 = pixelColorStringValue; }
                                if (x == 29) { bX016Y029 = pixelColorStringValue; }
                                if (x == 30) { bX016Y030 = pixelColorStringValue; }
                                if (x == 31) { bX016Y031 = pixelColorStringValue; }
                                if (x == 32) { bX016Y032 = pixelColorStringValue; }
                                if (x == 33) { bX016Y033 = pixelColorStringValue; }
                                if (x == 34) { bX016Y034 = pixelColorStringValue; }
                                if (x == 35) { bX016Y035 = pixelColorStringValue; }
                                if (x == 36) { bX016Y036 = pixelColorStringValue; }
                                if (x == 37) { bX016Y037 = pixelColorStringValue; }
                                if (x == 38) { bX016Y038 = pixelColorStringValue; }
                                if (x == 39) { bX016Y039 = pixelColorStringValue; }
                                if (x == 40) { bX016Y040 = pixelColorStringValue; }
                                if (x == 41) { bX016Y041 = pixelColorStringValue; }
                                if (x == 42) { bX016Y042 = pixelColorStringValue; }
                                if (x == 43) { bX016Y043 = pixelColorStringValue; }
                                if (x == 44) { bX016Y044 = pixelColorStringValue; }
                                if (x == 45) { bX016Y045 = pixelColorStringValue; }
                                if (x == 46) { bX016Y046 = pixelColorStringValue; }
                                if (x == 47) { bX016Y047 = pixelColorStringValue; }
                                if (x == 48) { bX016Y048 = pixelColorStringValue; }
                                if (x == 49) { bX016Y049 = pixelColorStringValue; }
                                if (x == 50) { bX016Y050 = pixelColorStringValue; }
                                if (x == 51) { bX016Y051 = pixelColorStringValue; }
                                if (x == 52) { bX016Y052 = pixelColorStringValue; }
                                if (x == 53) { bX016Y053 = pixelColorStringValue; }
                                if (x == 54) { bX016Y054 = pixelColorStringValue; }
                                if (x == 55) { bX016Y055 = pixelColorStringValue; }
                                if (x == 56) { bX016Y056 = pixelColorStringValue; }
                                if (x == 57) { bX016Y057 = pixelColorStringValue; }
                                if (x == 58) { bX016Y058 = pixelColorStringValue; }
                                if (x == 59) { bX016Y059 = pixelColorStringValue; }
                                if (x == 60) { bX016Y060 = pixelColorStringValue; }
                                if (x == 61) { bX016Y061 = pixelColorStringValue; }
                                if (x == 62) { bX016Y062 = pixelColorStringValue; }
                                if (x == 63) { bX016Y063 = pixelColorStringValue; }
                            }

                            if (y == 17)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);


                                if (x == 0) { bX017Y000 = pixelColorStringValue; }
                                if (x == 1) { bX017Y001 = pixelColorStringValue; }
                                if (x == 2) { bX017Y002 = pixelColorStringValue; }
                                if (x == 3) { bX017Y003 = pixelColorStringValue; }
                                if (x == 4) { bX017Y004 = pixelColorStringValue; }
                                if (x == 5) { bX017Y005 = pixelColorStringValue; }
                                if (x == 6) { bX017Y006 = pixelColorStringValue; }
                                if (x == 7) { bX017Y007 = pixelColorStringValue; }
                                if (x == 8) { bX017Y008 = pixelColorStringValue; }
                                if (x == 9) { bX017Y009 = pixelColorStringValue; }
                                if (x == 10) { bX017Y010 = pixelColorStringValue; }
                                if (x == 11) { bX017Y011 = pixelColorStringValue; }
                                if (x == 12) { bX017Y012 = pixelColorStringValue; }
                                if (x == 13) { bX017Y013 = pixelColorStringValue; }
                                if (x == 14) { bX017Y014 = pixelColorStringValue; }
                                if (x == 15) { bX017Y015 = pixelColorStringValue; }
                                if (x == 16) { bX017Y016 = pixelColorStringValue; }
                                if (x == 17) { bX017Y017 = pixelColorStringValue; }
                                if (x == 18) { bX017Y018 = pixelColorStringValue; }
                                if (x == 19) { bX017Y019 = pixelColorStringValue; }
                                if (x == 20) { bX017Y020 = pixelColorStringValue; }
                                if (x == 21) { bX017Y021 = pixelColorStringValue; }
                                if (x == 22) { bX017Y022 = pixelColorStringValue; }
                                if (x == 23) { bX017Y023 = pixelColorStringValue; }
                                if (x == 24) { bX017Y024 = pixelColorStringValue; }
                                if (x == 25) { bX017Y025 = pixelColorStringValue; }
                                if (x == 26) { bX017Y026 = pixelColorStringValue; }
                                if (x == 27) { bX017Y027 = pixelColorStringValue; }
                                if (x == 28) { bX017Y028 = pixelColorStringValue; }
                                if (x == 29) { bX017Y029 = pixelColorStringValue; }
                                if (x == 30) { bX017Y030 = pixelColorStringValue; }
                                if (x == 31) { bX017Y031 = pixelColorStringValue; }
                                if (x == 32) { bX017Y032 = pixelColorStringValue; }
                                if (x == 33) { bX017Y033 = pixelColorStringValue; }
                                if (x == 34) { bX017Y034 = pixelColorStringValue; }
                                if (x == 35) { bX017Y035 = pixelColorStringValue; }
                                if (x == 36) { bX017Y036 = pixelColorStringValue; }
                                if (x == 37) { bX017Y037 = pixelColorStringValue; }
                                if (x == 38) { bX017Y038 = pixelColorStringValue; }
                                if (x == 39) { bX017Y039 = pixelColorStringValue; }
                                if (x == 40) { bX017Y040 = pixelColorStringValue; }
                                if (x == 41) { bX017Y041 = pixelColorStringValue; }
                                if (x == 42) { bX017Y042 = pixelColorStringValue; }
                                if (x == 43) { bX017Y043 = pixelColorStringValue; }
                                if (x == 44) { bX017Y044 = pixelColorStringValue; }
                                if (x == 45) { bX017Y045 = pixelColorStringValue; }
                                if (x == 46) { bX017Y046 = pixelColorStringValue; }
                                if (x == 47) { bX017Y047 = pixelColorStringValue; }
                                if (x == 48) { bX017Y048 = pixelColorStringValue; }
                                if (x == 49) { bX017Y049 = pixelColorStringValue; }
                                if (x == 50) { bX017Y050 = pixelColorStringValue; }
                                if (x == 51) { bX017Y051 = pixelColorStringValue; }
                                if (x == 52) { bX017Y052 = pixelColorStringValue; }
                                if (x == 53) { bX017Y053 = pixelColorStringValue; }
                                if (x == 54) { bX017Y054 = pixelColorStringValue; }
                                if (x == 55) { bX017Y055 = pixelColorStringValue; }
                                if (x == 56) { bX017Y056 = pixelColorStringValue; }
                                if (x == 57) { bX017Y057 = pixelColorStringValue; }
                                if (x == 58) { bX017Y058 = pixelColorStringValue; }
                                if (x == 59) { bX017Y059 = pixelColorStringValue; }
                                if (x == 60) { bX017Y060 = pixelColorStringValue; }
                                if (x == 61) { bX017Y061 = pixelColorStringValue; }
                                if (x == 62) { bX017Y062 = pixelColorStringValue; }
                                if (x == 63) { bX017Y063 = pixelColorStringValue; }
                            }

                            if (y == 18)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0) { bX018Y000 = pixelColorStringValue; }
                                if (x == 1) { bX018Y001 = pixelColorStringValue; }
                                if (x == 2) { bX018Y002 = pixelColorStringValue; }
                                if (x == 3) { bX018Y003 = pixelColorStringValue; }
                                if (x == 4) { bX018Y004 = pixelColorStringValue; }
                                if (x == 5) { bX018Y005 = pixelColorStringValue; }
                                if (x == 6) { bX018Y006 = pixelColorStringValue; }
                                if (x == 7) { bX018Y007 = pixelColorStringValue; }
                                if (x == 8) { bX018Y008 = pixelColorStringValue; }
                                if (x == 9) { bX018Y009 = pixelColorStringValue; }
                                if (x == 10) { bX018Y010 = pixelColorStringValue; }
                                if (x == 11) { bX018Y011 = pixelColorStringValue; }
                                if (x == 12) { bX018Y012 = pixelColorStringValue; }
                                if (x == 13) { bX018Y013 = pixelColorStringValue; }
                                if (x == 14) { bX018Y014 = pixelColorStringValue; }
                                if (x == 15) { bX018Y015 = pixelColorStringValue; }
                                if (x == 16) { bX018Y016 = pixelColorStringValue; }
                                if (x == 17) { bX018Y017 = pixelColorStringValue; }
                                if (x == 18) { bX018Y018 = pixelColorStringValue; }
                                if (x == 19) { bX018Y019 = pixelColorStringValue; }
                                if (x == 20) { bX018Y020 = pixelColorStringValue; }
                                if (x == 21) { bX018Y021 = pixelColorStringValue; }
                                if (x == 22) { bX018Y022 = pixelColorStringValue; }
                                if (x == 23) { bX018Y023 = pixelColorStringValue; }
                                if (x == 24) { bX018Y024 = pixelColorStringValue; }
                                if (x == 25) { bX018Y025 = pixelColorStringValue; }
                                if (x == 26) { bX018Y026 = pixelColorStringValue; }
                                if (x == 27) { bX018Y027 = pixelColorStringValue; }
                                if (x == 28) { bX018Y028 = pixelColorStringValue; }
                                if (x == 29) { bX018Y029 = pixelColorStringValue; }
                                if (x == 30) { bX018Y030 = pixelColorStringValue; }
                                if (x == 31) { bX018Y031 = pixelColorStringValue; }
                                if (x == 32) { bX018Y032 = pixelColorStringValue; }
                                if (x == 33) { bX018Y033 = pixelColorStringValue; }
                                if (x == 34) { bX018Y034 = pixelColorStringValue; }
                                if (x == 35) { bX018Y035 = pixelColorStringValue; }
                                if (x == 36) { bX018Y036 = pixelColorStringValue; }
                                if (x == 37) { bX018Y037 = pixelColorStringValue; }
                                if (x == 38) { bX018Y038 = pixelColorStringValue; }
                                if (x == 39) { bX018Y039 = pixelColorStringValue; }
                                if (x == 40) { bX018Y040 = pixelColorStringValue; }
                                if (x == 41) { bX018Y041 = pixelColorStringValue; }
                                if (x == 42) { bX018Y042 = pixelColorStringValue; }
                                if (x == 43) { bX018Y043 = pixelColorStringValue; }
                                if (x == 44) { bX018Y044 = pixelColorStringValue; }
                                if (x == 45) { bX018Y045 = pixelColorStringValue; }
                                if (x == 46) { bX018Y046 = pixelColorStringValue; }
                                if (x == 47) { bX018Y047 = pixelColorStringValue; }
                                if (x == 48) { bX018Y048 = pixelColorStringValue; }
                                if (x == 49) { bX018Y049 = pixelColorStringValue; }
                                if (x == 50) { bX018Y050 = pixelColorStringValue; }
                                if (x == 51) { bX018Y051 = pixelColorStringValue; }
                                if (x == 52) { bX018Y052 = pixelColorStringValue; }
                                if (x == 53) { bX018Y053 = pixelColorStringValue; }
                                if (x == 54) { bX018Y054 = pixelColorStringValue; }
                                if (x == 55) { bX018Y055 = pixelColorStringValue; }
                                if (x == 56) { bX018Y056 = pixelColorStringValue; }
                                if (x == 57) { bX018Y057 = pixelColorStringValue; }
                                if (x == 58) { bX018Y058 = pixelColorStringValue; }
                                if (x == 59) { bX018Y059 = pixelColorStringValue; }
                                if (x == 60) { bX018Y060 = pixelColorStringValue; }
                                if (x == 61) { bX018Y061 = pixelColorStringValue; }
                                if (x == 62) { bX018Y062 = pixelColorStringValue; }
                                if (x == 63) { bX018Y063 = pixelColorStringValue; }
                            }

                            if (y == 19)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0) { bX019Y000 = pixelColorStringValue; }
                                if (x == 1) { bX019Y001 = pixelColorStringValue; }
                                if (x == 2) { bX019Y002 = pixelColorStringValue; }
                                if (x == 3) { bX019Y003 = pixelColorStringValue; }
                                if (x == 4) { bX019Y004 = pixelColorStringValue; }
                                if (x == 5) { bX019Y005 = pixelColorStringValue; }
                                if (x == 6) { bX019Y006 = pixelColorStringValue; }
                                if (x == 7) { bX019Y007 = pixelColorStringValue; }
                                if (x == 8) { bX019Y008 = pixelColorStringValue; }
                                if (x == 9) { bX019Y009 = pixelColorStringValue; }
                                if (x == 10) { bX019Y010 = pixelColorStringValue; }
                                if (x == 11) { bX019Y011 = pixelColorStringValue; }
                                if (x == 12) { bX019Y012 = pixelColorStringValue; }
                                if (x == 13) { bX019Y013 = pixelColorStringValue; }
                                if (x == 14) { bX019Y014 = pixelColorStringValue; }
                                if (x == 15) { bX019Y015 = pixelColorStringValue; }
                                if (x == 16) { bX019Y016 = pixelColorStringValue; }
                                if (x == 17) { bX019Y017 = pixelColorStringValue; }
                                if (x == 18) { bX019Y018 = pixelColorStringValue; }
                                if (x == 19) { bX019Y019 = pixelColorStringValue; }
                                if (x == 20) { bX019Y020 = pixelColorStringValue; }
                                if (x == 21) { bX019Y021 = pixelColorStringValue; }
                                if (x == 22) { bX019Y022 = pixelColorStringValue; }
                                if (x == 23) { bX019Y023 = pixelColorStringValue; }
                                if (x == 24) { bX019Y024 = pixelColorStringValue; }
                                if (x == 25) { bX019Y025 = pixelColorStringValue; }
                                if (x == 26) { bX019Y026 = pixelColorStringValue; }
                                if (x == 27) { bX019Y027 = pixelColorStringValue; }
                                if (x == 28) { bX019Y028 = pixelColorStringValue; }
                                if (x == 29) { bX019Y029 = pixelColorStringValue; }
                                if (x == 30) { bX019Y030 = pixelColorStringValue; }
                                if (x == 31) { bX019Y031 = pixelColorStringValue; }
                                if (x == 32) { bX019Y032 = pixelColorStringValue; }
                                if (x == 33) { bX019Y033 = pixelColorStringValue; }
                                if (x == 34) { bX019Y034 = pixelColorStringValue; }
                                if (x == 35) { bX019Y035 = pixelColorStringValue; }
                                if (x == 36) { bX019Y036 = pixelColorStringValue; }
                                if (x == 37) { bX019Y037 = pixelColorStringValue; }
                                if (x == 38) { bX019Y038 = pixelColorStringValue; }
                                if (x == 39) { bX019Y039 = pixelColorStringValue; }
                                if (x == 40) { bX019Y040 = pixelColorStringValue; }
                                if (x == 41) { bX019Y041 = pixelColorStringValue; }
                                if (x == 42) { bX019Y042 = pixelColorStringValue; }
                                if (x == 43) { bX019Y043 = pixelColorStringValue; }
                                if (x == 44) { bX019Y044 = pixelColorStringValue; }
                                if (x == 45) { bX019Y045 = pixelColorStringValue; }
                                if (x == 46) { bX019Y046 = pixelColorStringValue; }
                                if (x == 47) { bX019Y047 = pixelColorStringValue; }
                                if (x == 48) { bX019Y048 = pixelColorStringValue; }
                                if (x == 49) { bX019Y049 = pixelColorStringValue; }
                                if (x == 50) { bX019Y050 = pixelColorStringValue; }
                                if (x == 51) { bX019Y051 = pixelColorStringValue; }
                                if (x == 52) { bX019Y052 = pixelColorStringValue; }
                                if (x == 53) { bX019Y053 = pixelColorStringValue; }
                                if (x == 54) { bX019Y054 = pixelColorStringValue; }
                                if (x == 55) { bX019Y055 = pixelColorStringValue; }
                                if (x == 56) { bX019Y056 = pixelColorStringValue; }
                                if (x == 57) { bX019Y057 = pixelColorStringValue; }
                                if (x == 58) { bX019Y058 = pixelColorStringValue; }
                                if (x == 59) { bX019Y059 = pixelColorStringValue; }
                                if (x == 60) { bX019Y060 = pixelColorStringValue; }
                                if (x == 61) { bX019Y061 = pixelColorStringValue; }
                                if (x == 62) { bX019Y062 = pixelColorStringValue; }
                                if (x == 63) { bX019Y063 = pixelColorStringValue; }
                            }

                            if (y == 20)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0) { bX020Y000 = pixelColorStringValue; }
                                if (x == 1) { bX020Y001 = pixelColorStringValue; }
                                if (x == 2) { bX020Y002 = pixelColorStringValue; }
                                if (x == 3) { bX020Y003 = pixelColorStringValue; }
                                if (x == 4) { bX020Y004 = pixelColorStringValue; }
                                if (x == 5) { bX020Y005 = pixelColorStringValue; }
                                if (x == 6) { bX020Y006 = pixelColorStringValue; }
                                if (x == 7) { bX020Y007 = pixelColorStringValue; }
                                if (x == 8) { bX020Y008 = pixelColorStringValue; }
                                if (x == 9) { bX020Y009 = pixelColorStringValue; }
                                if (x == 10) { bX020Y010 = pixelColorStringValue; }
                                if (x == 11) { bX020Y011 = pixelColorStringValue; }
                                if (x == 12) { bX020Y012 = pixelColorStringValue; }
                                if (x == 13) { bX020Y013 = pixelColorStringValue; }
                                if (x == 14) { bX020Y014 = pixelColorStringValue; }
                                if (x == 15) { bX020Y015 = pixelColorStringValue; }
                                if (x == 16) { bX020Y016 = pixelColorStringValue; }
                                if (x == 17) { bX020Y017 = pixelColorStringValue; }
                                if (x == 18) { bX020Y018 = pixelColorStringValue; }
                                if (x == 19) { bX020Y019 = pixelColorStringValue; }
                                if (x == 20) { bX020Y020 = pixelColorStringValue; }
                                if (x == 21) { bX020Y021 = pixelColorStringValue; }
                                if (x == 22) { bX020Y022 = pixelColorStringValue; }
                                if (x == 23) { bX020Y023 = pixelColorStringValue; }
                                if (x == 24) { bX020Y024 = pixelColorStringValue; }
                                if (x == 25) { bX020Y025 = pixelColorStringValue; }
                                if (x == 26) { bX020Y026 = pixelColorStringValue; }
                                if (x == 27) { bX020Y027 = pixelColorStringValue; }
                                if (x == 28) { bX020Y028 = pixelColorStringValue; }
                                if (x == 29) { bX020Y029 = pixelColorStringValue; }
                                if (x == 30) { bX020Y030 = pixelColorStringValue; }
                                if (x == 31) { bX020Y031 = pixelColorStringValue; }
                                if (x == 32) { bX020Y032 = pixelColorStringValue; }
                                if (x == 33) { bX020Y033 = pixelColorStringValue; }
                                if (x == 34) { bX020Y034 = pixelColorStringValue; }
                                if (x == 35) { bX020Y035 = pixelColorStringValue; }
                                if (x == 36) { bX020Y036 = pixelColorStringValue; }
                                if (x == 37) { bX020Y037 = pixelColorStringValue; }
                                if (x == 38) { bX020Y038 = pixelColorStringValue; }
                                if (x == 39) { bX020Y039 = pixelColorStringValue; }
                                if (x == 40) { bX020Y040 = pixelColorStringValue; }
                                if (x == 41) { bX020Y041 = pixelColorStringValue; }
                                if (x == 42) { bX020Y042 = pixelColorStringValue; }
                                if (x == 43) { bX020Y043 = pixelColorStringValue; }
                                if (x == 44) { bX020Y044 = pixelColorStringValue; }
                                if (x == 45) { bX020Y045 = pixelColorStringValue; }
                                if (x == 46) { bX020Y046 = pixelColorStringValue; }
                                if (x == 47) { bX020Y047 = pixelColorStringValue; }
                                if (x == 48) { bX020Y048 = pixelColorStringValue; }
                                if (x == 49) { bX020Y049 = pixelColorStringValue; }
                                if (x == 50) { bX020Y050 = pixelColorStringValue; }
                                if (x == 51) { bX020Y051 = pixelColorStringValue; }
                                if (x == 52) { bX020Y052 = pixelColorStringValue; }
                                if (x == 53) { bX020Y053 = pixelColorStringValue; }
                                if (x == 54) { bX020Y054 = pixelColorStringValue; }
                                if (x == 55) { bX020Y055 = pixelColorStringValue; }
                                if (x == 56) { bX020Y056 = pixelColorStringValue; }
                                if (x == 57) { bX020Y057 = pixelColorStringValue; }
                                if (x == 58) { bX020Y058 = pixelColorStringValue; }
                                if (x == 59) { bX020Y059 = pixelColorStringValue; }
                                if (x == 60) { bX020Y060 = pixelColorStringValue; }
                                if (x == 61) { bX020Y061 = pixelColorStringValue; }
                                if (x == 62) { bX020Y062 = pixelColorStringValue; }
                                if (x == 63) { bX020Y063 = pixelColorStringValue; }
                            }

                            if (y == 21)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0) { bX021Y000 = pixelColorStringValue; }
                                if (x == 1) { bX021Y001 = pixelColorStringValue; }
                                if (x == 2) { bX021Y002 = pixelColorStringValue; }
                                if (x == 3) { bX021Y003 = pixelColorStringValue; }
                                if (x == 4) { bX021Y004 = pixelColorStringValue; }
                                if (x == 5) { bX021Y005 = pixelColorStringValue; }
                                if (x == 6) { bX021Y006 = pixelColorStringValue; }
                                if (x == 7) { bX021Y007 = pixelColorStringValue; }
                                if (x == 8) { bX021Y008 = pixelColorStringValue; }
                                if (x == 9) { bX021Y009 = pixelColorStringValue; }
                                if (x == 10) { bX021Y010 = pixelColorStringValue; }
                                if (x == 11) { bX021Y011 = pixelColorStringValue; }
                                if (x == 12) { bX021Y012 = pixelColorStringValue; }
                                if (x == 13) { bX021Y013 = pixelColorStringValue; }
                                if (x == 14) { bX021Y014 = pixelColorStringValue; }
                                if (x == 15) { bX021Y015 = pixelColorStringValue; }
                                if (x == 16) { bX021Y016 = pixelColorStringValue; }
                                if (x == 17) { bX021Y017 = pixelColorStringValue; }
                                if (x == 18) { bX021Y018 = pixelColorStringValue; }
                                if (x == 19) { bX021Y019 = pixelColorStringValue; }
                                if (x == 20) { bX021Y020 = pixelColorStringValue; }
                                if (x == 21) { bX021Y021 = pixelColorStringValue; }
                                if (x == 22) { bX021Y022 = pixelColorStringValue; }
                                if (x == 23) { bX021Y023 = pixelColorStringValue; }
                                if (x == 24) { bX021Y024 = pixelColorStringValue; }
                                if (x == 25) { bX021Y025 = pixelColorStringValue; }
                                if (x == 26) { bX021Y026 = pixelColorStringValue; }
                                if (x == 27) { bX021Y027 = pixelColorStringValue; }
                                if (x == 28) { bX021Y028 = pixelColorStringValue; }
                                if (x == 29) { bX021Y029 = pixelColorStringValue; }
                                if (x == 30) { bX021Y030 = pixelColorStringValue; }
                                if (x == 31) { bX021Y031 = pixelColorStringValue; }
                                if (x == 32) { bX021Y032 = pixelColorStringValue; }
                                if (x == 33) { bX021Y033 = pixelColorStringValue; }
                                if (x == 34) { bX021Y034 = pixelColorStringValue; }
                                if (x == 35) { bX021Y035 = pixelColorStringValue; }
                                if (x == 36) { bX021Y036 = pixelColorStringValue; }
                                if (x == 37) { bX021Y037 = pixelColorStringValue; }
                                if (x == 38) { bX021Y038 = pixelColorStringValue; }
                                if (x == 39) { bX021Y039 = pixelColorStringValue; }
                                if (x == 40) { bX021Y040 = pixelColorStringValue; }
                                if (x == 41) { bX021Y041 = pixelColorStringValue; }
                                if (x == 42) { bX021Y042 = pixelColorStringValue; }
                                if (x == 43) { bX021Y043 = pixelColorStringValue; }
                                if (x == 44) { bX021Y044 = pixelColorStringValue; }
                                if (x == 45) { bX021Y045 = pixelColorStringValue; }
                                if (x == 46) { bX021Y046 = pixelColorStringValue; }
                                if (x == 47) { bX021Y047 = pixelColorStringValue; }
                                if (x == 48) { bX021Y048 = pixelColorStringValue; }
                                if (x == 49) { bX021Y049 = pixelColorStringValue; }
                                if (x == 50) { bX021Y050 = pixelColorStringValue; }
                                if (x == 51) { bX021Y051 = pixelColorStringValue; }
                                if (x == 52) { bX021Y052 = pixelColorStringValue; }
                                if (x == 53) { bX021Y053 = pixelColorStringValue; }
                                if (x == 54) { bX021Y054 = pixelColorStringValue; }
                                if (x == 55) { bX021Y055 = pixelColorStringValue; }
                                if (x == 56) { bX021Y056 = pixelColorStringValue; }
                                if (x == 57) { bX021Y057 = pixelColorStringValue; }
                                if (x == 58) { bX021Y058 = pixelColorStringValue; }
                                if (x == 59) { bX021Y059 = pixelColorStringValue; }
                                if (x == 60) { bX021Y060 = pixelColorStringValue; }
                                if (x == 61) { bX021Y061 = pixelColorStringValue; }
                                if (x == 62) { bX021Y062 = pixelColorStringValue; }
                                if (x == 63) { bX021Y063 = pixelColorStringValue; }
                            }

                            if (y == 22)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0) { bX022Y000 = pixelColorStringValue; }
                                if (x == 1) { bX022Y001 = pixelColorStringValue; }
                                if (x == 2) { bX022Y002 = pixelColorStringValue; }
                                if (x == 3) { bX022Y003 = pixelColorStringValue; }
                                if (x == 4) { bX022Y004 = pixelColorStringValue; }
                                if (x == 5) { bX022Y005 = pixelColorStringValue; }
                                if (x == 6) { bX022Y006 = pixelColorStringValue; }
                                if (x == 7) { bX022Y007 = pixelColorStringValue; }
                                if (x == 8) { bX022Y008 = pixelColorStringValue; }
                                if (x == 9) { bX022Y009 = pixelColorStringValue; }
                                if (x == 10) { bX022Y010 = pixelColorStringValue; }
                                if (x == 11) { bX022Y011 = pixelColorStringValue; }
                                if (x == 12) { bX022Y012 = pixelColorStringValue; }
                                if (x == 13) { bX022Y013 = pixelColorStringValue; }
                                if (x == 14) { bX022Y014 = pixelColorStringValue; }
                                if (x == 15) { bX022Y015 = pixelColorStringValue; }
                                if (x == 16) { bX022Y016 = pixelColorStringValue; }
                                if (x == 17) { bX022Y017 = pixelColorStringValue; }
                                if (x == 18) { bX022Y018 = pixelColorStringValue; }
                                if (x == 19) { bX022Y019 = pixelColorStringValue; }
                                if (x == 20) { bX022Y020 = pixelColorStringValue; }
                                if (x == 21) { bX022Y021 = pixelColorStringValue; }
                                if (x == 22) { bX022Y022 = pixelColorStringValue; }
                                if (x == 23) { bX022Y023 = pixelColorStringValue; }
                                if (x == 24) { bX022Y024 = pixelColorStringValue; }
                                if (x == 25) { bX022Y025 = pixelColorStringValue; }
                                if (x == 26) { bX022Y026 = pixelColorStringValue; }
                                if (x == 27) { bX022Y027 = pixelColorStringValue; }
                                if (x == 28) { bX022Y028 = pixelColorStringValue; }
                                if (x == 29) { bX022Y029 = pixelColorStringValue; }
                                if (x == 30) { bX022Y030 = pixelColorStringValue; }
                                if (x == 31) { bX022Y031 = pixelColorStringValue; }
                                if (x == 32) { bX022Y032 = pixelColorStringValue; }
                                if (x == 33) { bX022Y033 = pixelColorStringValue; }
                                if (x == 34) { bX022Y034 = pixelColorStringValue; }
                                if (x == 35) { bX022Y035 = pixelColorStringValue; }
                                if (x == 36) { bX022Y036 = pixelColorStringValue; }
                                if (x == 37) { bX022Y037 = pixelColorStringValue; }
                                if (x == 38) { bX022Y038 = pixelColorStringValue; }
                                if (x == 39) { bX022Y039 = pixelColorStringValue; }
                                if (x == 40) { bX022Y040 = pixelColorStringValue; }
                                if (x == 41) { bX022Y041 = pixelColorStringValue; }
                                if (x == 42) { bX022Y042 = pixelColorStringValue; }
                                if (x == 43) { bX022Y043 = pixelColorStringValue; }
                                if (x == 44) { bX022Y044 = pixelColorStringValue; }
                                if (x == 45) { bX022Y045 = pixelColorStringValue; }
                                if (x == 46) { bX022Y046 = pixelColorStringValue; }
                                if (x == 47) { bX022Y047 = pixelColorStringValue; }
                                if (x == 48) { bX022Y048 = pixelColorStringValue; }
                                if (x == 49) { bX022Y049 = pixelColorStringValue; }
                                if (x == 50) { bX022Y050 = pixelColorStringValue; }
                                if (x == 51) { bX022Y051 = pixelColorStringValue; }
                                if (x == 52) { bX022Y052 = pixelColorStringValue; }
                                if (x == 53) { bX022Y053 = pixelColorStringValue; }
                                if (x == 54) { bX022Y054 = pixelColorStringValue; }
                                if (x == 55) { bX022Y055 = pixelColorStringValue; }
                                if (x == 56) { bX022Y056 = pixelColorStringValue; }
                                if (x == 57) { bX022Y057 = pixelColorStringValue; }
                                if (x == 58) { bX022Y058 = pixelColorStringValue; }
                                if (x == 59) { bX022Y059 = pixelColorStringValue; }
                                if (x == 60) { bX022Y060 = pixelColorStringValue; }
                                if (x == 61) { bX022Y061 = pixelColorStringValue; }
                                if (x == 62) { bX022Y062 = pixelColorStringValue; }
                                if (x == 63) { bX022Y063 = pixelColorStringValue; }
                            }

                            if (y == 23)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0) { bX023Y000 = pixelColorStringValue; }
                                if (x == 1) { bX023Y001 = pixelColorStringValue; }
                                if (x == 2) { bX023Y002 = pixelColorStringValue; }
                                if (x == 3) { bX023Y003 = pixelColorStringValue; }
                                if (x == 4) { bX023Y004 = pixelColorStringValue; }
                                if (x == 5) { bX023Y005 = pixelColorStringValue; }
                                if (x == 6) { bX023Y006 = pixelColorStringValue; }
                                if (x == 7) { bX023Y007 = pixelColorStringValue; }
                                if (x == 8) { bX023Y008 = pixelColorStringValue; }
                                if (x == 9) { bX023Y009 = pixelColorStringValue; }
                                if (x == 10) { bX023Y010 = pixelColorStringValue; }
                                if (x == 11) { bX023Y011 = pixelColorStringValue; }
                                if (x == 12) { bX023Y012 = pixelColorStringValue; }
                                if (x == 13) { bX023Y013 = pixelColorStringValue; }
                                if (x == 14) { bX023Y014 = pixelColorStringValue; }
                                if (x == 15) { bX023Y015 = pixelColorStringValue; }
                                if (x == 16) { bX023Y016 = pixelColorStringValue; }
                                if (x == 17) { bX023Y017 = pixelColorStringValue; }
                                if (x == 18) { bX023Y018 = pixelColorStringValue; }
                                if (x == 19) { bX023Y019 = pixelColorStringValue; }
                                if (x == 20) { bX023Y020 = pixelColorStringValue; }
                                if (x == 21) { bX023Y021 = pixelColorStringValue; }
                                if (x == 22) { bX023Y022 = pixelColorStringValue; }
                                if (x == 23) { bX023Y023 = pixelColorStringValue; }
                                if (x == 24) { bX023Y024 = pixelColorStringValue; }
                                if (x == 25) { bX023Y025 = pixelColorStringValue; }
                                if (x == 26) { bX023Y026 = pixelColorStringValue; }
                                if (x == 27) { bX023Y027 = pixelColorStringValue; }
                                if (x == 28) { bX023Y028 = pixelColorStringValue; }
                                if (x == 29) { bX023Y029 = pixelColorStringValue; }
                                if (x == 30) { bX023Y030 = pixelColorStringValue; }
                                if (x == 31) { bX023Y031 = pixelColorStringValue; }
                                if (x == 32) { bX023Y032 = pixelColorStringValue; }
                                if (x == 33) { bX023Y033 = pixelColorStringValue; }
                                if (x == 34) { bX023Y034 = pixelColorStringValue; }
                                if (x == 35) { bX023Y035 = pixelColorStringValue; }
                                if (x == 36) { bX023Y036 = pixelColorStringValue; }
                                if (x == 37) { bX023Y037 = pixelColorStringValue; }
                                if (x == 38) { bX023Y038 = pixelColorStringValue; }
                                if (x == 39) { bX023Y039 = pixelColorStringValue; }
                                if (x == 40) { bX023Y040 = pixelColorStringValue; }
                                if (x == 41) { bX023Y041 = pixelColorStringValue; }
                                if (x == 42) { bX023Y042 = pixelColorStringValue; }
                                if (x == 43) { bX023Y043 = pixelColorStringValue; }
                                if (x == 44) { bX023Y044 = pixelColorStringValue; }
                                if (x == 45) { bX023Y045 = pixelColorStringValue; }
                                if (x == 46) { bX023Y046 = pixelColorStringValue; }
                                if (x == 47) { bX023Y047 = pixelColorStringValue; }
                                if (x == 48) { bX023Y048 = pixelColorStringValue; }
                                if (x == 49) { bX023Y049 = pixelColorStringValue; }
                                if (x == 50) { bX023Y050 = pixelColorStringValue; }
                                if (x == 51) { bX023Y051 = pixelColorStringValue; }
                                if (x == 52) { bX023Y052 = pixelColorStringValue; }
                                if (x == 53) { bX023Y053 = pixelColorStringValue; }
                                if (x == 54) { bX023Y054 = pixelColorStringValue; }
                                if (x == 55) { bX023Y055 = pixelColorStringValue; }
                                if (x == 56) { bX023Y056 = pixelColorStringValue; }
                                if (x == 57) { bX023Y057 = pixelColorStringValue; }
                                if (x == 58) { bX023Y058 = pixelColorStringValue; }
                                if (x == 59) { bX023Y059 = pixelColorStringValue; }
                                if (x == 60) { bX023Y060 = pixelColorStringValue; }
                                if (x == 61) { bX023Y061 = pixelColorStringValue; }
                                if (x == 62) { bX023Y062 = pixelColorStringValue; }
                                if (x == 63) { bX023Y063 = pixelColorStringValue; }
                            }

                            if (y == 24)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0) { bX024Y000 = pixelColorStringValue; }
                                if (x == 1) { bX024Y001 = pixelColorStringValue; }
                                if (x == 2) { bX024Y002 = pixelColorStringValue; }
                                if (x == 3) { bX024Y003 = pixelColorStringValue; }
                                if (x == 4) { bX024Y004 = pixelColorStringValue; }
                                if (x == 5) { bX024Y005 = pixelColorStringValue; }
                                if (x == 6) { bX024Y006 = pixelColorStringValue; }
                                if (x == 7) { bX024Y007 = pixelColorStringValue; }
                                if (x == 8) { bX024Y008 = pixelColorStringValue; }
                                if (x == 9) { bX024Y009 = pixelColorStringValue; }
                                if (x == 10) { bX024Y010 = pixelColorStringValue; }
                                if (x == 11) { bX024Y011 = pixelColorStringValue; }
                                if (x == 12) { bX024Y012 = pixelColorStringValue; }
                                if (x == 13) { bX024Y013 = pixelColorStringValue; }
                                if (x == 14) { bX024Y014 = pixelColorStringValue; }
                                if (x == 15) { bX024Y015 = pixelColorStringValue; }
                                if (x == 16) { bX024Y016 = pixelColorStringValue; }
                                if (x == 17) { bX024Y017 = pixelColorStringValue; }
                                if (x == 18) { bX024Y018 = pixelColorStringValue; }
                                if (x == 19) { bX024Y019 = pixelColorStringValue; }
                                if (x == 20) { bX024Y020 = pixelColorStringValue; }
                                if (x == 21) { bX024Y021 = pixelColorStringValue; }
                                if (x == 22) { bX024Y022 = pixelColorStringValue; }
                                if (x == 23) { bX024Y023 = pixelColorStringValue; }
                                if (x == 24) { bX024Y024 = pixelColorStringValue; }
                                if (x == 25) { bX024Y025 = pixelColorStringValue; }
                                if (x == 26) { bX024Y026 = pixelColorStringValue; }
                                if (x == 27) { bX024Y027 = pixelColorStringValue; }
                                if (x == 28) { bX024Y028 = pixelColorStringValue; }
                                if (x == 29) { bX024Y029 = pixelColorStringValue; }
                                if (x == 30) { bX024Y030 = pixelColorStringValue; }
                                if (x == 31) { bX024Y031 = pixelColorStringValue; }
                                if (x == 32) { bX024Y032 = pixelColorStringValue; }
                                if (x == 33) { bX024Y033 = pixelColorStringValue; }
                                if (x == 34) { bX024Y034 = pixelColorStringValue; }
                                if (x == 35) { bX024Y035 = pixelColorStringValue; }
                                if (x == 36) { bX024Y036 = pixelColorStringValue; }
                                if (x == 37) { bX024Y037 = pixelColorStringValue; }
                                if (x == 38) { bX024Y038 = pixelColorStringValue; }
                                if (x == 39) { bX024Y039 = pixelColorStringValue; }
                                if (x == 40) { bX024Y040 = pixelColorStringValue; }
                                if (x == 41) { bX024Y041 = pixelColorStringValue; }
                                if (x == 42) { bX024Y042 = pixelColorStringValue; }
                                if (x == 43) { bX024Y043 = pixelColorStringValue; }
                                if (x == 44) { bX024Y044 = pixelColorStringValue; }
                                if (x == 45) { bX024Y045 = pixelColorStringValue; }
                                if (x == 46) { bX024Y046 = pixelColorStringValue; }
                                if (x == 47) { bX024Y047 = pixelColorStringValue; }
                                if (x == 48) { bX024Y048 = pixelColorStringValue; }
                                if (x == 49) { bX024Y049 = pixelColorStringValue; }
                                if (x == 50) { bX024Y050 = pixelColorStringValue; }
                                if (x == 51) { bX024Y051 = pixelColorStringValue; }
                                if (x == 52) { bX024Y052 = pixelColorStringValue; }
                                if (x == 53) { bX024Y053 = pixelColorStringValue; }
                                if (x == 54) { bX024Y054 = pixelColorStringValue; }
                                if (x == 55) { bX024Y055 = pixelColorStringValue; }
                                if (x == 56) { bX024Y056 = pixelColorStringValue; }
                                if (x == 57) { bX024Y057 = pixelColorStringValue; }
                                if (x == 58) { bX024Y058 = pixelColorStringValue; }
                                if (x == 59) { bX024Y059 = pixelColorStringValue; }
                                if (x == 60) { bX024Y060 = pixelColorStringValue; }
                                if (x == 61) { bX024Y061 = pixelColorStringValue; }
                                if (x == 62) { bX024Y062 = pixelColorStringValue; }
                                if (x == 63) { bX024Y063 = pixelColorStringValue; }
                            }

                            if (y == 25)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0) { bX025Y000 = pixelColorStringValue; }
                                if (x == 1) { bX025Y001 = pixelColorStringValue; }
                                if (x == 2) { bX025Y002 = pixelColorStringValue; }
                                if (x == 3) { bX025Y003 = pixelColorStringValue; }
                                if (x == 4) { bX025Y004 = pixelColorStringValue; }
                                if (x == 5) { bX025Y005 = pixelColorStringValue; }
                                if (x == 6) { bX025Y006 = pixelColorStringValue; }
                                if (x == 7) { bX025Y007 = pixelColorStringValue; }
                                if (x == 8) { bX025Y008 = pixelColorStringValue; }
                                if (x == 9) { bX025Y009 = pixelColorStringValue; }
                                if (x == 10) { bX025Y010 = pixelColorStringValue; }
                                if (x == 11) { bX025Y011 = pixelColorStringValue; }
                                if (x == 12) { bX025Y012 = pixelColorStringValue; }
                                if (x == 13) { bX025Y013 = pixelColorStringValue; }
                                if (x == 14) { bX025Y014 = pixelColorStringValue; }
                                if (x == 15) { bX025Y015 = pixelColorStringValue; }
                                if (x == 16) { bX025Y016 = pixelColorStringValue; }
                                if (x == 17) { bX025Y017 = pixelColorStringValue; }
                                if (x == 18) { bX025Y018 = pixelColorStringValue; }
                                if (x == 19) { bX025Y019 = pixelColorStringValue; }
                                if (x == 20) { bX025Y020 = pixelColorStringValue; }
                                if (x == 21) { bX025Y021 = pixelColorStringValue; }
                                if (x == 22) { bX025Y022 = pixelColorStringValue; }
                                if (x == 23) { bX025Y023 = pixelColorStringValue; }
                                if (x == 24) { bX025Y024 = pixelColorStringValue; }
                                if (x == 25) { bX025Y025 = pixelColorStringValue; }
                                if (x == 26) { bX025Y026 = pixelColorStringValue; }
                                if (x == 27) { bX025Y027 = pixelColorStringValue; }
                                if (x == 28) { bX025Y028 = pixelColorStringValue; }
                                if (x == 29) { bX025Y029 = pixelColorStringValue; }
                                if (x == 30) { bX025Y030 = pixelColorStringValue; }
                                if (x == 31) { bX025Y031 = pixelColorStringValue; }
                                if (x == 32) { bX025Y032 = pixelColorStringValue; }
                                if (x == 33) { bX025Y033 = pixelColorStringValue; }
                                if (x == 34) { bX025Y034 = pixelColorStringValue; }
                                if (x == 35) { bX025Y035 = pixelColorStringValue; }
                                if (x == 36) { bX025Y036 = pixelColorStringValue; }
                                if (x == 37) { bX025Y037 = pixelColorStringValue; }
                                if (x == 38) { bX025Y038 = pixelColorStringValue; }
                                if (x == 39) { bX025Y039 = pixelColorStringValue; }
                                if (x == 40) { bX025Y040 = pixelColorStringValue; }
                                if (x == 41) { bX025Y041 = pixelColorStringValue; }
                                if (x == 42) { bX025Y042 = pixelColorStringValue; }
                                if (x == 43) { bX025Y043 = pixelColorStringValue; }
                                if (x == 44) { bX025Y044 = pixelColorStringValue; }
                                if (x == 45) { bX025Y045 = pixelColorStringValue; }
                                if (x == 46) { bX025Y046 = pixelColorStringValue; }
                                if (x == 47) { bX025Y047 = pixelColorStringValue; }
                                if (x == 48) { bX025Y048 = pixelColorStringValue; }
                                if (x == 49) { bX025Y049 = pixelColorStringValue; }
                                if (x == 50) { bX025Y050 = pixelColorStringValue; }
                                if (x == 51) { bX025Y051 = pixelColorStringValue; }
                                if (x == 52) { bX025Y052 = pixelColorStringValue; }
                                if (x == 53) { bX025Y053 = pixelColorStringValue; }
                                if (x == 54) { bX025Y054 = pixelColorStringValue; }
                                if (x == 55) { bX025Y055 = pixelColorStringValue; }
                                if (x == 56) { bX025Y056 = pixelColorStringValue; }
                                if (x == 57) { bX025Y057 = pixelColorStringValue; }
                                if (x == 58) { bX025Y058 = pixelColorStringValue; }
                                if (x == 59) { bX025Y059 = pixelColorStringValue; }
                                if (x == 60) { bX025Y060 = pixelColorStringValue; }
                                if (x == 61) { bX025Y061 = pixelColorStringValue; }
                                if (x == 62) { bX025Y062 = pixelColorStringValue; }
                                if (x == 63) { bX025Y063 = pixelColorStringValue; }
                            }

                            if (y == 26)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);


                                if (x == 0) { bX026Y000 = pixelColorStringValue; }
                                if (x == 1) { bX026Y001 = pixelColorStringValue; }
                                if (x == 2) { bX026Y002 = pixelColorStringValue; }
                                if (x == 3) { bX026Y003 = pixelColorStringValue; }
                                if (x == 4) { bX026Y004 = pixelColorStringValue; }
                                if (x == 5) { bX026Y005 = pixelColorStringValue; }
                                if (x == 6) { bX026Y006 = pixelColorStringValue; }
                                if (x == 7) { bX026Y007 = pixelColorStringValue; }
                                if (x == 8) { bX026Y008 = pixelColorStringValue; }
                                if (x == 9) { bX026Y009 = pixelColorStringValue; }
                                if (x == 10) { bX026Y010 = pixelColorStringValue; }
                                if (x == 11) { bX026Y011 = pixelColorStringValue; }
                                if (x == 12) { bX026Y012 = pixelColorStringValue; }
                                if (x == 13) { bX026Y013 = pixelColorStringValue; }
                                if (x == 14) { bX026Y014 = pixelColorStringValue; }
                                if (x == 15) { bX026Y015 = pixelColorStringValue; }
                                if (x == 16) { bX026Y016 = pixelColorStringValue; }
                                if (x == 17) { bX026Y017 = pixelColorStringValue; }
                                if (x == 18) { bX026Y018 = pixelColorStringValue; }
                                if (x == 19) { bX026Y019 = pixelColorStringValue; }
                                if (x == 20) { bX026Y020 = pixelColorStringValue; }
                                if (x == 21) { bX026Y021 = pixelColorStringValue; }
                                if (x == 22) { bX026Y022 = pixelColorStringValue; }
                                if (x == 23) { bX026Y023 = pixelColorStringValue; }
                                if (x == 24) { bX026Y024 = pixelColorStringValue; }
                                if (x == 25) { bX026Y025 = pixelColorStringValue; }
                                if (x == 26) { bX026Y026 = pixelColorStringValue; }
                                if (x == 27) { bX026Y027 = pixelColorStringValue; }
                                if (x == 28) { bX026Y028 = pixelColorStringValue; }
                                if (x == 29) { bX026Y029 = pixelColorStringValue; }
                                if (x == 30) { bX026Y030 = pixelColorStringValue; }
                                if (x == 31) { bX026Y031 = pixelColorStringValue; }
                                if (x == 32) { bX026Y032 = pixelColorStringValue; }
                                if (x == 33) { bX026Y033 = pixelColorStringValue; }
                                if (x == 34) { bX026Y034 = pixelColorStringValue; }
                                if (x == 35) { bX026Y035 = pixelColorStringValue; }
                                if (x == 36) { bX026Y036 = pixelColorStringValue; }
                                if (x == 37) { bX026Y037 = pixelColorStringValue; }
                                if (x == 38) { bX026Y038 = pixelColorStringValue; }
                                if (x == 39) { bX026Y039 = pixelColorStringValue; }
                                if (x == 40) { bX026Y040 = pixelColorStringValue; }
                                if (x == 41) { bX026Y041 = pixelColorStringValue; }
                                if (x == 42) { bX026Y042 = pixelColorStringValue; }
                                if (x == 43) { bX026Y043 = pixelColorStringValue; }
                                if (x == 44) { bX026Y044 = pixelColorStringValue; }
                                if (x == 45) { bX026Y045 = pixelColorStringValue; }
                                if (x == 46) { bX026Y046 = pixelColorStringValue; }
                                if (x == 47) { bX026Y047 = pixelColorStringValue; }
                                if (x == 48) { bX026Y048 = pixelColorStringValue; }
                                if (x == 49) { bX026Y049 = pixelColorStringValue; }
                                if (x == 50) { bX026Y050 = pixelColorStringValue; }
                                if (x == 51) { bX026Y051 = pixelColorStringValue; }
                                if (x == 52) { bX026Y052 = pixelColorStringValue; }
                                if (x == 53) { bX026Y053 = pixelColorStringValue; }
                                if (x == 54) { bX026Y054 = pixelColorStringValue; }
                                if (x == 55) { bX026Y055 = pixelColorStringValue; }
                                if (x == 56) { bX026Y056 = pixelColorStringValue; }
                                if (x == 57) { bX026Y057 = pixelColorStringValue; }
                                if (x == 58) { bX026Y058 = pixelColorStringValue; }
                                if (x == 59) { bX026Y059 = pixelColorStringValue; }
                                if (x == 60) { bX026Y060 = pixelColorStringValue; }
                                if (x == 61) { bX026Y061 = pixelColorStringValue; }
                                if (x == 62) { bX026Y062 = pixelColorStringValue; }
                                if (x == 63) { bX026Y063 = pixelColorStringValue; }
                            }

                            if (y == 27)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX027Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX027Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX027Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX027Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX027Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX027Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX027Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX027Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX027Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX027Y009 = pixelColorStringValue; }
                                if (x == 10) { bX027Y010 = pixelColorStringValue; }
                                if (x == 11) { bX027Y011 = pixelColorStringValue; }
                                if (x == 12) { bX027Y012 = pixelColorStringValue; }
                                if (x == 13) { bX027Y013 = pixelColorStringValue; }
                                if (x == 14) { bX027Y014 = pixelColorStringValue; }
                                if (x == 15) { bX027Y015 = pixelColorStringValue; }
                                if (x == 16) { bX027Y016 = pixelColorStringValue; }
                                if (x == 17) { bX027Y017 = pixelColorStringValue; }
                                if (x == 18) { bX027Y018 = pixelColorStringValue; }
                                if (x == 19) { bX027Y019 = pixelColorStringValue; }
                                if (x == 20) { bX027Y020 = pixelColorStringValue; }
                                if (x == 21) { bX027Y021 = pixelColorStringValue; }
                                if (x == 22) { bX027Y022 = pixelColorStringValue; }
                                if (x == 23) { bX027Y023 = pixelColorStringValue; }
                                if (x == 24) { bX027Y024 = pixelColorStringValue; }
                                if (x == 25) { bX027Y025 = pixelColorStringValue; }
                                if (x == 26) { bX027Y026 = pixelColorStringValue; }
                                if (x == 27) { bX027Y027 = pixelColorStringValue; }
                                if (x == 28) { bX027Y028 = pixelColorStringValue; }
                                if (x == 29) { bX027Y029 = pixelColorStringValue; }
                                if (x == 30) { bX027Y030 = pixelColorStringValue; }
                                if (x == 31) { bX027Y031 = pixelColorStringValue; }
                                if (x == 32) { bX027Y032 = pixelColorStringValue; }
                                if (x == 33) { bX027Y033 = pixelColorStringValue; }
                                if (x == 34) { bX027Y034 = pixelColorStringValue; }
                                if (x == 35) { bX027Y035 = pixelColorStringValue; }
                                if (x == 36) { bX027Y036 = pixelColorStringValue; }
                                if (x == 37) { bX027Y037 = pixelColorStringValue; }
                                if (x == 38) { bX027Y038 = pixelColorStringValue; }
                                if (x == 39) { bX027Y039 = pixelColorStringValue; }
                                if (x == 40) { bX027Y040 = pixelColorStringValue; }
                                if (x == 41) { bX027Y041 = pixelColorStringValue; }
                                if (x == 42) { bX027Y042 = pixelColorStringValue; }
                                if (x == 43) { bX027Y043 = pixelColorStringValue; }
                                if (x == 44) { bX027Y044 = pixelColorStringValue; }
                                if (x == 45) { bX027Y045 = pixelColorStringValue; }
                                if (x == 46) { bX027Y046 = pixelColorStringValue; }
                                if (x == 47) { bX027Y047 = pixelColorStringValue; }
                                if (x == 48) { bX027Y048 = pixelColorStringValue; }
                                if (x == 49) { bX027Y049 = pixelColorStringValue; }
                                if (x == 50) { bX027Y050 = pixelColorStringValue; }
                                if (x == 51) { bX027Y051 = pixelColorStringValue; }
                                if (x == 52) { bX027Y052 = pixelColorStringValue; }
                                if (x == 53) { bX027Y053 = pixelColorStringValue; }
                                if (x == 54) { bX027Y054 = pixelColorStringValue; }
                                if (x == 55) { bX027Y055 = pixelColorStringValue; }
                                if (x == 56) { bX027Y056 = pixelColorStringValue; }
                                if (x == 57) { bX027Y057 = pixelColorStringValue; }
                                if (x == 58) { bX027Y058 = pixelColorStringValue; }
                                if (x == 59) { bX027Y059 = pixelColorStringValue; }
                                if (x == 60) { bX027Y060 = pixelColorStringValue; }
                                if (x == 61) { bX027Y061 = pixelColorStringValue; }
                                if (x == 62) { bX027Y062 = pixelColorStringValue; }
                                if (x == 63) { bX027Y063 = pixelColorStringValue; }

                            }

                            if (y == 28)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX028Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX028Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX028Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX028Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX028Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX028Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX028Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX028Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX028Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX028Y009 = pixelColorStringValue; }
                                if (x == 10) { bX028Y010 = pixelColorStringValue; }
                                if (x == 11) { bX028Y011 = pixelColorStringValue; }
                                if (x == 12) { bX028Y012 = pixelColorStringValue; }
                                if (x == 13) { bX028Y013 = pixelColorStringValue; }
                                if (x == 14) { bX028Y014 = pixelColorStringValue; }
                                if (x == 15) { bX028Y015 = pixelColorStringValue; }
                                if (x == 16) { bX028Y016 = pixelColorStringValue; }
                                if (x == 17) { bX028Y017 = pixelColorStringValue; }
                                if (x == 18) { bX028Y018 = pixelColorStringValue; }
                                if (x == 19) { bX028Y019 = pixelColorStringValue; }
                                if (x == 20) { bX028Y020 = pixelColorStringValue; }
                                if (x == 21) { bX028Y021 = pixelColorStringValue; }
                                if (x == 22) { bX028Y022 = pixelColorStringValue; }
                                if (x == 23) { bX028Y023 = pixelColorStringValue; }
                                if (x == 24) { bX028Y024 = pixelColorStringValue; }
                                if (x == 25) { bX028Y025 = pixelColorStringValue; }
                                if (x == 26) { bX028Y026 = pixelColorStringValue; }
                                if (x == 27) { bX028Y027 = pixelColorStringValue; }
                                if (x == 28) { bX028Y028 = pixelColorStringValue; }
                                if (x == 29) { bX028Y029 = pixelColorStringValue; }
                                if (x == 30) { bX028Y030 = pixelColorStringValue; }
                                if (x == 31) { bX028Y031 = pixelColorStringValue; }
                                if (x == 32) { bX028Y032 = pixelColorStringValue; }
                                if (x == 33) { bX028Y033 = pixelColorStringValue; }
                                if (x == 34) { bX028Y034 = pixelColorStringValue; }
                                if (x == 35) { bX028Y035 = pixelColorStringValue; }
                                if (x == 36) { bX028Y036 = pixelColorStringValue; }
                                if (x == 37) { bX028Y037 = pixelColorStringValue; }
                                if (x == 38) { bX028Y038 = pixelColorStringValue; }
                                if (x == 39) { bX028Y039 = pixelColorStringValue; }
                                if (x == 40) { bX028Y040 = pixelColorStringValue; }
                                if (x == 41) { bX028Y041 = pixelColorStringValue; }
                                if (x == 42) { bX028Y042 = pixelColorStringValue; }
                                if (x == 43) { bX028Y043 = pixelColorStringValue; }
                                if (x == 44) { bX028Y044 = pixelColorStringValue; }
                                if (x == 45) { bX028Y045 = pixelColorStringValue; }
                                if (x == 46) { bX028Y046 = pixelColorStringValue; }
                                if (x == 47) { bX028Y047 = pixelColorStringValue; }
                                if (x == 48) { bX028Y048 = pixelColorStringValue; }
                                if (x == 49) { bX028Y049 = pixelColorStringValue; }
                                if (x == 50) { bX028Y050 = pixelColorStringValue; }
                                if (x == 51) { bX028Y051 = pixelColorStringValue; }
                                if (x == 52) { bX028Y052 = pixelColorStringValue; }
                                if (x == 53) { bX028Y053 = pixelColorStringValue; }
                                if (x == 54) { bX028Y054 = pixelColorStringValue; }
                                if (x == 55) { bX028Y055 = pixelColorStringValue; }
                                if (x == 56) { bX028Y056 = pixelColorStringValue; }
                                if (x == 57) { bX028Y057 = pixelColorStringValue; }
                                if (x == 58) { bX028Y058 = pixelColorStringValue; }
                                if (x == 59) { bX028Y059 = pixelColorStringValue; }
                                if (x == 60) { bX028Y060 = pixelColorStringValue; }
                                if (x == 61) { bX028Y061 = pixelColorStringValue; }
                                if (x == 62) { bX028Y062 = pixelColorStringValue; }
                                if (x == 63) { bX028Y063 = pixelColorStringValue; }

                            }

                            if (y == 29)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX029Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX029Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX029Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX029Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX029Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX029Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX029Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX029Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX029Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX029Y009 = pixelColorStringValue; }
                                if (x == 10) { bX029Y010 = pixelColorStringValue; }
                                if (x == 11) { bX029Y011 = pixelColorStringValue; }
                                if (x == 12) { bX029Y012 = pixelColorStringValue; }
                                if (x == 13) { bX029Y013 = pixelColorStringValue; }
                                if (x == 14) { bX029Y014 = pixelColorStringValue; }
                                if (x == 15) { bX029Y015 = pixelColorStringValue; }
                                if (x == 16) { bX029Y016 = pixelColorStringValue; }
                                if (x == 17) { bX029Y017 = pixelColorStringValue; }
                                if (x == 18) { bX029Y018 = pixelColorStringValue; }
                                if (x == 19) { bX029Y019 = pixelColorStringValue; }
                                if (x == 20) { bX029Y020 = pixelColorStringValue; }
                                if (x == 21) { bX029Y021 = pixelColorStringValue; }
                                if (x == 22) { bX029Y022 = pixelColorStringValue; }
                                if (x == 23) { bX029Y023 = pixelColorStringValue; }
                                if (x == 24) { bX029Y024 = pixelColorStringValue; }
                                if (x == 25) { bX029Y025 = pixelColorStringValue; }
                                if (x == 26) { bX029Y026 = pixelColorStringValue; }
                                if (x == 27) { bX029Y027 = pixelColorStringValue; }
                                if (x == 28) { bX029Y028 = pixelColorStringValue; }
                                if (x == 29) { bX029Y029 = pixelColorStringValue; }
                                if (x == 30) { bX029Y030 = pixelColorStringValue; }
                                if (x == 31) { bX029Y031 = pixelColorStringValue; }
                                if (x == 32) { bX029Y032 = pixelColorStringValue; }
                                if (x == 33) { bX029Y033 = pixelColorStringValue; }
                                if (x == 34) { bX029Y034 = pixelColorStringValue; }
                                if (x == 35) { bX029Y035 = pixelColorStringValue; }
                                if (x == 36) { bX029Y036 = pixelColorStringValue; }
                                if (x == 37) { bX029Y037 = pixelColorStringValue; }
                                if (x == 38) { bX029Y038 = pixelColorStringValue; }
                                if (x == 39) { bX029Y039 = pixelColorStringValue; }
                                if (x == 40) { bX029Y040 = pixelColorStringValue; }
                                if (x == 41) { bX029Y041 = pixelColorStringValue; }
                                if (x == 42) { bX029Y042 = pixelColorStringValue; }
                                if (x == 43) { bX029Y043 = pixelColorStringValue; }
                                if (x == 44) { bX029Y044 = pixelColorStringValue; }
                                if (x == 45) { bX029Y045 = pixelColorStringValue; }
                                if (x == 46) { bX029Y046 = pixelColorStringValue; }
                                if (x == 47) { bX029Y047 = pixelColorStringValue; }
                                if (x == 48) { bX029Y048 = pixelColorStringValue; }
                                if (x == 49) { bX029Y049 = pixelColorStringValue; }
                                if (x == 50) { bX029Y050 = pixelColorStringValue; }
                                if (x == 51) { bX029Y051 = pixelColorStringValue; }
                                if (x == 52) { bX029Y052 = pixelColorStringValue; }
                                if (x == 53) { bX029Y053 = pixelColorStringValue; }
                                if (x == 54) { bX029Y054 = pixelColorStringValue; }
                                if (x == 55) { bX029Y055 = pixelColorStringValue; }
                                if (x == 56) { bX029Y056 = pixelColorStringValue; }
                                if (x == 57) { bX029Y057 = pixelColorStringValue; }
                                if (x == 58) { bX029Y058 = pixelColorStringValue; }
                                if (x == 59) { bX029Y059 = pixelColorStringValue; }
                                if (x == 60) { bX029Y060 = pixelColorStringValue; }
                                if (x == 61) { bX029Y061 = pixelColorStringValue; }
                                if (x == 62) { bX029Y062 = pixelColorStringValue; }
                                if (x == 63) { bX029Y063 = pixelColorStringValue; }

                            }

                            if (y == 30)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX030Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX030Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX030Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX030Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX030Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX030Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX030Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX030Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX030Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX030Y009 = pixelColorStringValue; }
                                if (x == 10) { bX030Y010 = pixelColorStringValue; }
                                if (x == 11) { bX030Y011 = pixelColorStringValue; }
                                if (x == 12) { bX030Y012 = pixelColorStringValue; }
                                if (x == 13) { bX030Y013 = pixelColorStringValue; }
                                if (x == 14) { bX030Y014 = pixelColorStringValue; }
                                if (x == 15) { bX030Y015 = pixelColorStringValue; }
                                if (x == 16) { bX030Y016 = pixelColorStringValue; }
                                if (x == 17) { bX030Y017 = pixelColorStringValue; }
                                if (x == 18) { bX030Y018 = pixelColorStringValue; }
                                if (x == 19) { bX030Y019 = pixelColorStringValue; }
                                if (x == 20) { bX030Y020 = pixelColorStringValue; }
                                if (x == 21) { bX030Y021 = pixelColorStringValue; }
                                if (x == 22) { bX030Y022 = pixelColorStringValue; }
                                if (x == 23) { bX030Y023 = pixelColorStringValue; }
                                if (x == 24) { bX030Y024 = pixelColorStringValue; }
                                if (x == 25) { bX030Y025 = pixelColorStringValue; }
                                if (x == 26) { bX030Y026 = pixelColorStringValue; }
                                if (x == 27) { bX030Y027 = pixelColorStringValue; }
                                if (x == 28) { bX030Y028 = pixelColorStringValue; }
                                if (x == 29) { bX030Y029 = pixelColorStringValue; }
                                if (x == 30) { bX030Y030 = pixelColorStringValue; }
                                if (x == 31) { bX030Y031 = pixelColorStringValue; }
                                if (x == 32) { bX030Y032 = pixelColorStringValue; }
                                if (x == 33) { bX030Y033 = pixelColorStringValue; }
                                if (x == 34) { bX030Y034 = pixelColorStringValue; }
                                if (x == 35) { bX030Y035 = pixelColorStringValue; }
                                if (x == 36) { bX030Y036 = pixelColorStringValue; }
                                if (x == 37) { bX030Y037 = pixelColorStringValue; }
                                if (x == 38) { bX030Y038 = pixelColorStringValue; }
                                if (x == 39) { bX030Y039 = pixelColorStringValue; }
                                if (x == 40) { bX030Y040 = pixelColorStringValue; }
                                if (x == 41) { bX030Y041 = pixelColorStringValue; }
                                if (x == 42) { bX030Y042 = pixelColorStringValue; }
                                if (x == 43) { bX030Y043 = pixelColorStringValue; }
                                if (x == 44) { bX030Y044 = pixelColorStringValue; }
                                if (x == 45) { bX030Y045 = pixelColorStringValue; }
                                if (x == 46) { bX030Y046 = pixelColorStringValue; }
                                if (x == 47) { bX030Y047 = pixelColorStringValue; }
                                if (x == 48) { bX030Y048 = pixelColorStringValue; }
                                if (x == 49) { bX030Y049 = pixelColorStringValue; }
                                if (x == 50) { bX030Y050 = pixelColorStringValue; }
                                if (x == 51) { bX030Y051 = pixelColorStringValue; }
                                if (x == 52) { bX030Y052 = pixelColorStringValue; }
                                if (x == 53) { bX030Y053 = pixelColorStringValue; }
                                if (x == 54) { bX030Y054 = pixelColorStringValue; }
                                if (x == 55) { bX030Y055 = pixelColorStringValue; }
                                if (x == 56) { bX030Y056 = pixelColorStringValue; }
                                if (x == 57) { bX030Y057 = pixelColorStringValue; }
                                if (x == 58) { bX030Y058 = pixelColorStringValue; }
                                if (x == 59) { bX030Y059 = pixelColorStringValue; }
                                if (x == 60) { bX030Y060 = pixelColorStringValue; }
                                if (x == 61) { bX030Y061 = pixelColorStringValue; }
                                if (x == 62) { bX030Y062 = pixelColorStringValue; }
                                if (x == 63) { bX030Y063 = pixelColorStringValue; }

                            }

                            if (y == 31)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX031Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX031Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX031Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX031Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX031Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX031Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX031Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX031Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX031Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX031Y009 = pixelColorStringValue; }
                                if (x == 10) { bX031Y010 = pixelColorStringValue; }
                                if (x == 11) { bX031Y011 = pixelColorStringValue; }
                                if (x == 12) { bX031Y012 = pixelColorStringValue; }
                                if (x == 13) { bX031Y013 = pixelColorStringValue; }
                                if (x == 14) { bX031Y014 = pixelColorStringValue; }
                                if (x == 15) { bX031Y015 = pixelColorStringValue; }
                                if (x == 16) { bX031Y016 = pixelColorStringValue; }
                                if (x == 17) { bX031Y017 = pixelColorStringValue; }
                                if (x == 18) { bX031Y018 = pixelColorStringValue; }
                                if (x == 19) { bX031Y019 = pixelColorStringValue; }
                                if (x == 20) { bX031Y020 = pixelColorStringValue; }
                                if (x == 21) { bX031Y021 = pixelColorStringValue; }
                                if (x == 22) { bX031Y022 = pixelColorStringValue; }
                                if (x == 23) { bX031Y023 = pixelColorStringValue; }
                                if (x == 24) { bX031Y024 = pixelColorStringValue; }
                                if (x == 25) { bX031Y025 = pixelColorStringValue; }
                                if (x == 26) { bX031Y026 = pixelColorStringValue; }
                                if (x == 27) { bX031Y027 = pixelColorStringValue; }
                                if (x == 28) { bX031Y028 = pixelColorStringValue; }
                                if (x == 29) { bX031Y029 = pixelColorStringValue; }
                                if (x == 30) { bX031Y030 = pixelColorStringValue; }
                                if (x == 31) { bX031Y031 = pixelColorStringValue; }
                                if (x == 32) { bX031Y032 = pixelColorStringValue; }
                                if (x == 33) { bX031Y033 = pixelColorStringValue; }
                                if (x == 34) { bX031Y034 = pixelColorStringValue; }
                                if (x == 35) { bX031Y035 = pixelColorStringValue; }
                                if (x == 36) { bX031Y036 = pixelColorStringValue; }
                                if (x == 37) { bX031Y037 = pixelColorStringValue; }
                                if (x == 38) { bX031Y038 = pixelColorStringValue; }
                                if (x == 39) { bX031Y039 = pixelColorStringValue; }
                                if (x == 40) { bX031Y040 = pixelColorStringValue; }
                                if (x == 41) { bX031Y041 = pixelColorStringValue; }
                                if (x == 42) { bX031Y042 = pixelColorStringValue; }
                                if (x == 43) { bX031Y043 = pixelColorStringValue; }
                                if (x == 44) { bX031Y044 = pixelColorStringValue; }
                                if (x == 45) { bX031Y045 = pixelColorStringValue; }
                                if (x == 46) { bX031Y046 = pixelColorStringValue; }
                                if (x == 47) { bX031Y047 = pixelColorStringValue; }
                                if (x == 48) { bX031Y048 = pixelColorStringValue; }
                                if (x == 49) { bX031Y049 = pixelColorStringValue; }
                                if (x == 50) { bX031Y050 = pixelColorStringValue; }
                                if (x == 51) { bX031Y051 = pixelColorStringValue; }
                                if (x == 52) { bX031Y052 = pixelColorStringValue; }
                                if (x == 53) { bX031Y053 = pixelColorStringValue; }
                                if (x == 54) { bX031Y054 = pixelColorStringValue; }
                                if (x == 55) { bX031Y055 = pixelColorStringValue; }
                                if (x == 56) { bX031Y056 = pixelColorStringValue; }
                                if (x == 57) { bX031Y057 = pixelColorStringValue; }
                                if (x == 58) { bX031Y058 = pixelColorStringValue; }
                                if (x == 59) { bX031Y059 = pixelColorStringValue; }
                                if (x == 60) { bX031Y060 = pixelColorStringValue; }
                                if (x == 61) { bX031Y061 = pixelColorStringValue; }
                                if (x == 62) { bX031Y062 = pixelColorStringValue; }
                                if (x == 63) { bX031Y063 = pixelColorStringValue; }

                            }

                            if (y == 32)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX032Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX032Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX032Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX032Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX032Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX032Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX032Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX032Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX032Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX032Y009 = pixelColorStringValue; }
                                if (x == 10) { bX032Y010 = pixelColorStringValue; }
                                if (x == 11) { bX032Y011 = pixelColorStringValue; }
                                if (x == 12) { bX032Y012 = pixelColorStringValue; }
                                if (x == 13) { bX032Y013 = pixelColorStringValue; }
                                if (x == 14) { bX032Y014 = pixelColorStringValue; }
                                if (x == 15) { bX032Y015 = pixelColorStringValue; }
                                if (x == 16) { bX032Y016 = pixelColorStringValue; }
                                if (x == 17) { bX032Y017 = pixelColorStringValue; }
                                if (x == 18) { bX032Y018 = pixelColorStringValue; }
                                if (x == 19) { bX032Y019 = pixelColorStringValue; }
                                if (x == 20) { bX032Y020 = pixelColorStringValue; }
                                if (x == 21) { bX032Y021 = pixelColorStringValue; }
                                if (x == 22) { bX032Y022 = pixelColorStringValue; }
                                if (x == 23) { bX032Y023 = pixelColorStringValue; }
                                if (x == 24) { bX032Y024 = pixelColorStringValue; }
                                if (x == 25) { bX032Y025 = pixelColorStringValue; }
                                if (x == 26) { bX032Y026 = pixelColorStringValue; }
                                if (x == 27) { bX032Y027 = pixelColorStringValue; }
                                if (x == 28) { bX032Y028 = pixelColorStringValue; }
                                if (x == 29) { bX032Y029 = pixelColorStringValue; }
                                if (x == 30) { bX032Y030 = pixelColorStringValue; }
                                if (x == 31) { bX032Y031 = pixelColorStringValue; }
                                if (x == 32) { bX032Y032 = pixelColorStringValue; }
                                if (x == 33) { bX032Y033 = pixelColorStringValue; }
                                if (x == 34) { bX032Y034 = pixelColorStringValue; }
                                if (x == 35) { bX032Y035 = pixelColorStringValue; }
                                if (x == 36) { bX032Y036 = pixelColorStringValue; }
                                if (x == 37) { bX032Y037 = pixelColorStringValue; }
                                if (x == 38) { bX032Y038 = pixelColorStringValue; }
                                if (x == 39) { bX032Y039 = pixelColorStringValue; }
                                if (x == 40) { bX032Y040 = pixelColorStringValue; }
                                if (x == 41) { bX032Y041 = pixelColorStringValue; }
                                if (x == 42) { bX032Y042 = pixelColorStringValue; }
                                if (x == 43) { bX032Y043 = pixelColorStringValue; }
                                if (x == 44) { bX032Y044 = pixelColorStringValue; }
                                if (x == 45) { bX032Y045 = pixelColorStringValue; }
                                if (x == 46) { bX032Y046 = pixelColorStringValue; }
                                if (x == 47) { bX032Y047 = pixelColorStringValue; }
                                if (x == 48) { bX032Y048 = pixelColorStringValue; }
                                if (x == 49) { bX032Y049 = pixelColorStringValue; }
                                if (x == 50) { bX032Y050 = pixelColorStringValue; }
                                if (x == 51) { bX032Y051 = pixelColorStringValue; }
                                if (x == 52) { bX032Y052 = pixelColorStringValue; }
                                if (x == 53) { bX032Y053 = pixelColorStringValue; }
                                if (x == 54) { bX032Y054 = pixelColorStringValue; }
                                if (x == 55) { bX032Y055 = pixelColorStringValue; }
                                if (x == 56) { bX032Y056 = pixelColorStringValue; }
                                if (x == 57) { bX032Y057 = pixelColorStringValue; }
                                if (x == 58) { bX032Y058 = pixelColorStringValue; }
                                if (x == 59) { bX032Y059 = pixelColorStringValue; }
                                if (x == 60) { bX032Y060 = pixelColorStringValue; }
                                if (x == 61) { bX032Y061 = pixelColorStringValue; }
                                if (x == 62) { bX032Y062 = pixelColorStringValue; }
                                if (x == 63) { bX032Y063 = pixelColorStringValue; }

                            }

                            if (y == 33)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX033Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX033Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX033Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX033Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX033Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX033Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX033Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX033Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX033Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX033Y009 = pixelColorStringValue; }
                                if (x == 10) { bX033Y010 = pixelColorStringValue; }
                                if (x == 11) { bX033Y011 = pixelColorStringValue; }
                                if (x == 12) { bX033Y012 = pixelColorStringValue; }
                                if (x == 13) { bX033Y013 = pixelColorStringValue; }
                                if (x == 14) { bX033Y014 = pixelColorStringValue; }
                                if (x == 15) { bX033Y015 = pixelColorStringValue; }
                                if (x == 16) { bX033Y016 = pixelColorStringValue; }
                                if (x == 17) { bX033Y017 = pixelColorStringValue; }
                                if (x == 18) { bX033Y018 = pixelColorStringValue; }
                                if (x == 19) { bX033Y019 = pixelColorStringValue; }
                                if (x == 20) { bX033Y020 = pixelColorStringValue; }
                                if (x == 21) { bX033Y021 = pixelColorStringValue; }
                                if (x == 22) { bX033Y022 = pixelColorStringValue; }
                                if (x == 23) { bX033Y023 = pixelColorStringValue; }
                                if (x == 24) { bX033Y024 = pixelColorStringValue; }
                                if (x == 25) { bX033Y025 = pixelColorStringValue; }
                                if (x == 26) { bX033Y026 = pixelColorStringValue; }
                                if (x == 27) { bX033Y027 = pixelColorStringValue; }
                                if (x == 28) { bX033Y028 = pixelColorStringValue; }
                                if (x == 29) { bX033Y029 = pixelColorStringValue; }
                                if (x == 30) { bX033Y030 = pixelColorStringValue; }
                                if (x == 31) { bX033Y031 = pixelColorStringValue; }
                                if (x == 32) { bX033Y032 = pixelColorStringValue; }
                                if (x == 33) { bX033Y033 = pixelColorStringValue; }
                                if (x == 34) { bX033Y034 = pixelColorStringValue; }
                                if (x == 35) { bX033Y035 = pixelColorStringValue; }
                                if (x == 36) { bX033Y036 = pixelColorStringValue; }
                                if (x == 37) { bX033Y037 = pixelColorStringValue; }
                                if (x == 38) { bX033Y038 = pixelColorStringValue; }
                                if (x == 39) { bX033Y039 = pixelColorStringValue; }
                                if (x == 40) { bX033Y040 = pixelColorStringValue; }
                                if (x == 41) { bX033Y041 = pixelColorStringValue; }
                                if (x == 42) { bX033Y042 = pixelColorStringValue; }
                                if (x == 43) { bX033Y043 = pixelColorStringValue; }
                                if (x == 44) { bX033Y044 = pixelColorStringValue; }
                                if (x == 45) { bX033Y045 = pixelColorStringValue; }
                                if (x == 46) { bX033Y046 = pixelColorStringValue; }
                                if (x == 47) { bX033Y047 = pixelColorStringValue; }
                                if (x == 48) { bX033Y048 = pixelColorStringValue; }
                                if (x == 49) { bX033Y049 = pixelColorStringValue; }
                                if (x == 50) { bX033Y050 = pixelColorStringValue; }
                                if (x == 51) { bX033Y051 = pixelColorStringValue; }
                                if (x == 52) { bX033Y052 = pixelColorStringValue; }
                                if (x == 53) { bX033Y053 = pixelColorStringValue; }
                                if (x == 54) { bX033Y054 = pixelColorStringValue; }
                                if (x == 55) { bX033Y055 = pixelColorStringValue; }
                                if (x == 56) { bX033Y056 = pixelColorStringValue; }
                                if (x == 57) { bX033Y057 = pixelColorStringValue; }
                                if (x == 58) { bX033Y058 = pixelColorStringValue; }
                                if (x == 59) { bX033Y059 = pixelColorStringValue; }
                                if (x == 60) { bX033Y060 = pixelColorStringValue; }
                                if (x == 61) { bX033Y061 = pixelColorStringValue; }
                                if (x == 62) { bX033Y062 = pixelColorStringValue; }
                                if (x == 63) { bX033Y063 = pixelColorStringValue; }

                            }

                            if (y == 34)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX034Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX034Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX034Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX034Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX034Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX034Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX034Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX034Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX034Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX034Y009 = pixelColorStringValue; }
                                if (x == 10) { bX034Y010 = pixelColorStringValue; }
                                if (x == 11) { bX034Y011 = pixelColorStringValue; }
                                if (x == 12) { bX034Y012 = pixelColorStringValue; }
                                if (x == 13) { bX034Y013 = pixelColorStringValue; }
                                if (x == 14) { bX034Y014 = pixelColorStringValue; }
                                if (x == 15) { bX034Y015 = pixelColorStringValue; }
                                if (x == 16) { bX034Y016 = pixelColorStringValue; }
                                if (x == 17) { bX034Y017 = pixelColorStringValue; }
                                if (x == 18) { bX034Y018 = pixelColorStringValue; }
                                if (x == 19) { bX034Y019 = pixelColorStringValue; }
                                if (x == 20) { bX034Y020 = pixelColorStringValue; }
                                if (x == 21) { bX034Y021 = pixelColorStringValue; }
                                if (x == 22) { bX034Y022 = pixelColorStringValue; }
                                if (x == 23) { bX034Y023 = pixelColorStringValue; }
                                if (x == 24) { bX034Y024 = pixelColorStringValue; }
                                if (x == 25) { bX034Y025 = pixelColorStringValue; }
                                if (x == 26) { bX034Y026 = pixelColorStringValue; }
                                if (x == 27) { bX034Y027 = pixelColorStringValue; }
                                if (x == 28) { bX034Y028 = pixelColorStringValue; }
                                if (x == 29) { bX034Y029 = pixelColorStringValue; }
                                if (x == 30) { bX034Y030 = pixelColorStringValue; }
                                if (x == 31) { bX034Y031 = pixelColorStringValue; }
                                if (x == 32) { bX034Y032 = pixelColorStringValue; }
                                if (x == 33) { bX034Y033 = pixelColorStringValue; }
                                if (x == 34) { bX034Y034 = pixelColorStringValue; }
                                if (x == 35) { bX034Y035 = pixelColorStringValue; }
                                if (x == 36) { bX034Y036 = pixelColorStringValue; }
                                if (x == 37) { bX034Y037 = pixelColorStringValue; }
                                if (x == 38) { bX034Y038 = pixelColorStringValue; }
                                if (x == 39) { bX034Y039 = pixelColorStringValue; }
                                if (x == 40) { bX034Y040 = pixelColorStringValue; }
                                if (x == 41) { bX034Y041 = pixelColorStringValue; }
                                if (x == 42) { bX034Y042 = pixelColorStringValue; }
                                if (x == 43) { bX034Y043 = pixelColorStringValue; }
                                if (x == 44) { bX034Y044 = pixelColorStringValue; }
                                if (x == 45) { bX034Y045 = pixelColorStringValue; }
                                if (x == 46) { bX034Y046 = pixelColorStringValue; }
                                if (x == 47) { bX034Y047 = pixelColorStringValue; }
                                if (x == 48) { bX034Y048 = pixelColorStringValue; }
                                if (x == 49) { bX034Y049 = pixelColorStringValue; }
                                if (x == 50) { bX034Y050 = pixelColorStringValue; }
                                if (x == 51) { bX034Y051 = pixelColorStringValue; }
                                if (x == 52) { bX034Y052 = pixelColorStringValue; }
                                if (x == 53) { bX034Y053 = pixelColorStringValue; }
                                if (x == 54) { bX034Y054 = pixelColorStringValue; }
                                if (x == 55) { bX034Y055 = pixelColorStringValue; }
                                if (x == 56) { bX034Y056 = pixelColorStringValue; }
                                if (x == 57) { bX034Y057 = pixelColorStringValue; }
                                if (x == 58) { bX034Y058 = pixelColorStringValue; }
                                if (x == 59) { bX034Y059 = pixelColorStringValue; }
                                if (x == 60) { bX034Y060 = pixelColorStringValue; }
                                if (x == 61) { bX034Y061 = pixelColorStringValue; }
                                if (x == 62) { bX034Y062 = pixelColorStringValue; }
                                if (x == 63) { bX034Y063 = pixelColorStringValue; }

                            }

                            if (y == 35)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX035Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX035Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX035Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX035Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX035Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX035Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX035Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX035Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX035Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX035Y009 = pixelColorStringValue; }
                                if (x == 10) { bX035Y010 = pixelColorStringValue; }
                                if (x == 11) { bX035Y011 = pixelColorStringValue; }
                                if (x == 12) { bX035Y012 = pixelColorStringValue; }
                                if (x == 13) { bX035Y013 = pixelColorStringValue; }
                                if (x == 14) { bX035Y014 = pixelColorStringValue; }
                                if (x == 15) { bX035Y015 = pixelColorStringValue; }
                                if (x == 16) { bX035Y016 = pixelColorStringValue; }
                                if (x == 17) { bX035Y017 = pixelColorStringValue; }
                                if (x == 18) { bX035Y018 = pixelColorStringValue; }
                                if (x == 19) { bX035Y019 = pixelColorStringValue; }
                                if (x == 20) { bX035Y020 = pixelColorStringValue; }
                                if (x == 21) { bX035Y021 = pixelColorStringValue; }
                                if (x == 22) { bX035Y022 = pixelColorStringValue; }
                                if (x == 23) { bX035Y023 = pixelColorStringValue; }
                                if (x == 24) { bX035Y024 = pixelColorStringValue; }
                                if (x == 25) { bX035Y025 = pixelColorStringValue; }
                                if (x == 26) { bX035Y026 = pixelColorStringValue; }
                                if (x == 27) { bX035Y027 = pixelColorStringValue; }
                                if (x == 28) { bX035Y028 = pixelColorStringValue; }
                                if (x == 29) { bX035Y029 = pixelColorStringValue; }
                                if (x == 30) { bX035Y030 = pixelColorStringValue; }
                                if (x == 31) { bX035Y031 = pixelColorStringValue; }
                                if (x == 32) { bX035Y032 = pixelColorStringValue; }
                                if (x == 33) { bX035Y033 = pixelColorStringValue; }
                                if (x == 34) { bX035Y034 = pixelColorStringValue; }
                                if (x == 35) { bX035Y035 = pixelColorStringValue; }
                                if (x == 36) { bX035Y036 = pixelColorStringValue; }
                                if (x == 37) { bX035Y037 = pixelColorStringValue; }
                                if (x == 38) { bX035Y038 = pixelColorStringValue; }
                                if (x == 39) { bX035Y039 = pixelColorStringValue; }
                                if (x == 40) { bX035Y040 = pixelColorStringValue; }
                                if (x == 41) { bX035Y041 = pixelColorStringValue; }
                                if (x == 42) { bX035Y042 = pixelColorStringValue; }
                                if (x == 43) { bX035Y043 = pixelColorStringValue; }
                                if (x == 44) { bX035Y044 = pixelColorStringValue; }
                                if (x == 45) { bX035Y045 = pixelColorStringValue; }
                                if (x == 46) { bX035Y046 = pixelColorStringValue; }
                                if (x == 47) { bX035Y047 = pixelColorStringValue; }
                                if (x == 48) { bX035Y048 = pixelColorStringValue; }
                                if (x == 49) { bX035Y049 = pixelColorStringValue; }
                                if (x == 50) { bX035Y050 = pixelColorStringValue; }
                                if (x == 51) { bX035Y051 = pixelColorStringValue; }
                                if (x == 52) { bX035Y052 = pixelColorStringValue; }
                                if (x == 53) { bX035Y053 = pixelColorStringValue; }
                                if (x == 54) { bX035Y054 = pixelColorStringValue; }
                                if (x == 55) { bX035Y055 = pixelColorStringValue; }
                                if (x == 56) { bX035Y056 = pixelColorStringValue; }
                                if (x == 57) { bX035Y057 = pixelColorStringValue; }
                                if (x == 58) { bX035Y058 = pixelColorStringValue; }
                                if (x == 59) { bX035Y059 = pixelColorStringValue; }
                                if (x == 60) { bX035Y060 = pixelColorStringValue; }
                                if (x == 61) { bX035Y061 = pixelColorStringValue; }
                                if (x == 62) { bX035Y062 = pixelColorStringValue; }
                                if (x == 63) { bX035Y063 = pixelColorStringValue; }

                            }

                            if (y == 36)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX036Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX036Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX036Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX036Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX036Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX036Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX036Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX036Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX036Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX036Y009 = pixelColorStringValue; }
                                if (x == 10) { bX036Y010 = pixelColorStringValue; }
                                if (x == 11) { bX036Y011 = pixelColorStringValue; }
                                if (x == 12) { bX036Y012 = pixelColorStringValue; }
                                if (x == 13) { bX036Y013 = pixelColorStringValue; }
                                if (x == 14) { bX036Y014 = pixelColorStringValue; }
                                if (x == 15) { bX036Y015 = pixelColorStringValue; }
                                if (x == 16) { bX036Y016 = pixelColorStringValue; }
                                if (x == 17) { bX036Y017 = pixelColorStringValue; }
                                if (x == 18) { bX036Y018 = pixelColorStringValue; }
                                if (x == 19) { bX036Y019 = pixelColorStringValue; }
                                if (x == 20) { bX036Y020 = pixelColorStringValue; }
                                if (x == 21) { bX036Y021 = pixelColorStringValue; }
                                if (x == 22) { bX036Y022 = pixelColorStringValue; }
                                if (x == 23) { bX036Y023 = pixelColorStringValue; }
                                if (x == 24) { bX036Y024 = pixelColorStringValue; }
                                if (x == 25) { bX036Y025 = pixelColorStringValue; }
                                if (x == 26) { bX036Y026 = pixelColorStringValue; }
                                if (x == 27) { bX036Y027 = pixelColorStringValue; }
                                if (x == 28) { bX036Y028 = pixelColorStringValue; }
                                if (x == 29) { bX036Y029 = pixelColorStringValue; }
                                if (x == 30) { bX036Y030 = pixelColorStringValue; }
                                if (x == 31) { bX036Y031 = pixelColorStringValue; }
                                if (x == 32) { bX036Y032 = pixelColorStringValue; }
                                if (x == 33) { bX036Y033 = pixelColorStringValue; }
                                if (x == 34) { bX036Y034 = pixelColorStringValue; }
                                if (x == 35) { bX036Y035 = pixelColorStringValue; }
                                if (x == 36) { bX036Y036 = pixelColorStringValue; }
                                if (x == 37) { bX036Y037 = pixelColorStringValue; }
                                if (x == 38) { bX036Y038 = pixelColorStringValue; }
                                if (x == 39) { bX036Y039 = pixelColorStringValue; }
                                if (x == 40) { bX036Y040 = pixelColorStringValue; }
                                if (x == 41) { bX036Y041 = pixelColorStringValue; }
                                if (x == 42) { bX036Y042 = pixelColorStringValue; }
                                if (x == 43) { bX036Y043 = pixelColorStringValue; }
                                if (x == 44) { bX036Y044 = pixelColorStringValue; }
                                if (x == 45) { bX036Y045 = pixelColorStringValue; }
                                if (x == 46) { bX036Y046 = pixelColorStringValue; }
                                if (x == 47) { bX036Y047 = pixelColorStringValue; }
                                if (x == 48) { bX036Y048 = pixelColorStringValue; }
                                if (x == 49) { bX036Y049 = pixelColorStringValue; }
                                if (x == 50) { bX036Y050 = pixelColorStringValue; }
                                if (x == 51) { bX036Y051 = pixelColorStringValue; }
                                if (x == 52) { bX036Y052 = pixelColorStringValue; }
                                if (x == 53) { bX036Y053 = pixelColorStringValue; }
                                if (x == 54) { bX036Y054 = pixelColorStringValue; }
                                if (x == 55) { bX036Y055 = pixelColorStringValue; }
                                if (x == 56) { bX036Y056 = pixelColorStringValue; }
                                if (x == 57) { bX036Y057 = pixelColorStringValue; }
                                if (x == 58) { bX036Y058 = pixelColorStringValue; }
                                if (x == 59) { bX036Y059 = pixelColorStringValue; }
                                if (x == 60) { bX036Y060 = pixelColorStringValue; }
                                if (x == 61) { bX036Y061 = pixelColorStringValue; }
                                if (x == 62) { bX036Y062 = pixelColorStringValue; }
                                if (x == 63) { bX036Y063 = pixelColorStringValue; }

                            }

                            if (y == 37)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX037Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX037Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX037Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX037Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX037Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX037Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX037Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX037Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX037Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX037Y009 = pixelColorStringValue; }
                                if (x == 10) { bX037Y010 = pixelColorStringValue; }
                                if (x == 11) { bX037Y011 = pixelColorStringValue; }
                                if (x == 12) { bX037Y012 = pixelColorStringValue; }
                                if (x == 13) { bX037Y013 = pixelColorStringValue; }
                                if (x == 14) { bX037Y014 = pixelColorStringValue; }
                                if (x == 15) { bX037Y015 = pixelColorStringValue; }
                                if (x == 16) { bX037Y016 = pixelColorStringValue; }
                                if (x == 17) { bX037Y017 = pixelColorStringValue; }
                                if (x == 18) { bX037Y018 = pixelColorStringValue; }
                                if (x == 19) { bX037Y019 = pixelColorStringValue; }
                                if (x == 20) { bX037Y020 = pixelColorStringValue; }
                                if (x == 21) { bX037Y021 = pixelColorStringValue; }
                                if (x == 22) { bX037Y022 = pixelColorStringValue; }
                                if (x == 23) { bX037Y023 = pixelColorStringValue; }
                                if (x == 24) { bX037Y024 = pixelColorStringValue; }
                                if (x == 25) { bX037Y025 = pixelColorStringValue; }
                                if (x == 26) { bX037Y026 = pixelColorStringValue; }
                                if (x == 27) { bX037Y027 = pixelColorStringValue; }
                                if (x == 28) { bX037Y028 = pixelColorStringValue; }
                                if (x == 29) { bX037Y029 = pixelColorStringValue; }
                                if (x == 30) { bX037Y030 = pixelColorStringValue; }
                                if (x == 31) { bX037Y031 = pixelColorStringValue; }
                                if (x == 32) { bX037Y032 = pixelColorStringValue; }
                                if (x == 33) { bX037Y033 = pixelColorStringValue; }
                                if (x == 34) { bX037Y034 = pixelColorStringValue; }
                                if (x == 35) { bX037Y035 = pixelColorStringValue; }
                                if (x == 36) { bX037Y036 = pixelColorStringValue; }
                                if (x == 37) { bX037Y037 = pixelColorStringValue; }
                                if (x == 38) { bX037Y038 = pixelColorStringValue; }
                                if (x == 39) { bX037Y039 = pixelColorStringValue; }
                                if (x == 40) { bX037Y040 = pixelColorStringValue; }
                                if (x == 41) { bX037Y041 = pixelColorStringValue; }
                                if (x == 42) { bX037Y042 = pixelColorStringValue; }
                                if (x == 43) { bX037Y043 = pixelColorStringValue; }
                                if (x == 44) { bX037Y044 = pixelColorStringValue; }
                                if (x == 45) { bX037Y045 = pixelColorStringValue; }
                                if (x == 46) { bX037Y046 = pixelColorStringValue; }
                                if (x == 47) { bX037Y047 = pixelColorStringValue; }
                                if (x == 48) { bX037Y048 = pixelColorStringValue; }
                                if (x == 49) { bX037Y049 = pixelColorStringValue; }
                                if (x == 50) { bX037Y050 = pixelColorStringValue; }
                                if (x == 51) { bX037Y051 = pixelColorStringValue; }
                                if (x == 52) { bX037Y052 = pixelColorStringValue; }
                                if (x == 53) { bX037Y053 = pixelColorStringValue; }
                                if (x == 54) { bX037Y054 = pixelColorStringValue; }
                                if (x == 55) { bX037Y055 = pixelColorStringValue; }
                                if (x == 56) { bX037Y056 = pixelColorStringValue; }
                                if (x == 57) { bX037Y057 = pixelColorStringValue; }
                                if (x == 58) { bX037Y058 = pixelColorStringValue; }
                                if (x == 59) { bX037Y059 = pixelColorStringValue; }
                                if (x == 60) { bX037Y060 = pixelColorStringValue; }
                                if (x == 61) { bX037Y061 = pixelColorStringValue; }
                                if (x == 62) { bX037Y062 = pixelColorStringValue; }
                                if (x == 63) { bX037Y063 = pixelColorStringValue; }

                            }

                            if (y == 38)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX038Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX038Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX038Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX038Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX038Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX038Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX038Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX038Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX038Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX038Y009 = pixelColorStringValue; }
                                if (x == 10) { bX038Y010 = pixelColorStringValue; }
                                if (x == 11) { bX038Y011 = pixelColorStringValue; }
                                if (x == 12) { bX038Y012 = pixelColorStringValue; }
                                if (x == 13) { bX038Y013 = pixelColorStringValue; }
                                if (x == 14) { bX038Y014 = pixelColorStringValue; }
                                if (x == 15) { bX038Y015 = pixelColorStringValue; }
                                if (x == 16) { bX038Y016 = pixelColorStringValue; }
                                if (x == 17) { bX038Y017 = pixelColorStringValue; }
                                if (x == 18) { bX038Y018 = pixelColorStringValue; }
                                if (x == 19) { bX038Y019 = pixelColorStringValue; }
                                if (x == 20) { bX038Y020 = pixelColorStringValue; }
                                if (x == 21) { bX038Y021 = pixelColorStringValue; }
                                if (x == 22) { bX038Y022 = pixelColorStringValue; }
                                if (x == 23) { bX038Y023 = pixelColorStringValue; }
                                if (x == 24) { bX038Y024 = pixelColorStringValue; }
                                if (x == 25) { bX038Y025 = pixelColorStringValue; }
                                if (x == 26) { bX038Y026 = pixelColorStringValue; }
                                if (x == 27) { bX038Y027 = pixelColorStringValue; }
                                if (x == 28) { bX038Y028 = pixelColorStringValue; }
                                if (x == 29) { bX038Y029 = pixelColorStringValue; }
                                if (x == 30) { bX038Y030 = pixelColorStringValue; }
                                if (x == 31) { bX038Y031 = pixelColorStringValue; }
                                if (x == 32) { bX038Y032 = pixelColorStringValue; }
                                if (x == 33) { bX038Y033 = pixelColorStringValue; }
                                if (x == 34) { bX038Y034 = pixelColorStringValue; }
                                if (x == 35) { bX038Y035 = pixelColorStringValue; }
                                if (x == 36) { bX038Y036 = pixelColorStringValue; }
                                if (x == 37) { bX038Y037 = pixelColorStringValue; }
                                if (x == 38) { bX038Y038 = pixelColorStringValue; }
                                if (x == 39) { bX038Y039 = pixelColorStringValue; }
                                if (x == 40) { bX038Y040 = pixelColorStringValue; }
                                if (x == 41) { bX038Y041 = pixelColorStringValue; }
                                if (x == 42) { bX038Y042 = pixelColorStringValue; }
                                if (x == 43) { bX038Y043 = pixelColorStringValue; }
                                if (x == 44) { bX038Y044 = pixelColorStringValue; }
                                if (x == 45) { bX038Y045 = pixelColorStringValue; }
                                if (x == 46) { bX038Y046 = pixelColorStringValue; }
                                if (x == 47) { bX038Y047 = pixelColorStringValue; }
                                if (x == 48) { bX038Y048 = pixelColorStringValue; }
                                if (x == 49) { bX038Y049 = pixelColorStringValue; }
                                if (x == 50) { bX038Y050 = pixelColorStringValue; }
                                if (x == 51) { bX038Y051 = pixelColorStringValue; }
                                if (x == 52) { bX038Y052 = pixelColorStringValue; }
                                if (x == 53) { bX038Y053 = pixelColorStringValue; }
                                if (x == 54) { bX038Y054 = pixelColorStringValue; }
                                if (x == 55) { bX038Y055 = pixelColorStringValue; }
                                if (x == 56) { bX038Y056 = pixelColorStringValue; }
                                if (x == 57) { bX038Y057 = pixelColorStringValue; }
                                if (x == 58) { bX038Y058 = pixelColorStringValue; }
                                if (x == 59) { bX038Y059 = pixelColorStringValue; }
                                if (x == 60) { bX038Y060 = pixelColorStringValue; }
                                if (x == 61) { bX038Y061 = pixelColorStringValue; }
                                if (x == 62) { bX038Y062 = pixelColorStringValue; }
                                if (x == 63) { bX038Y063 = pixelColorStringValue; }

                            }

                            if (y == 39)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX039Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX039Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX039Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX039Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX039Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX039Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX039Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX039Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX039Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX039Y009 = pixelColorStringValue; }
                                if (x == 10) { bX039Y010 = pixelColorStringValue; }
                                if (x == 11) { bX039Y011 = pixelColorStringValue; }
                                if (x == 12) { bX039Y012 = pixelColorStringValue; }
                                if (x == 13) { bX039Y013 = pixelColorStringValue; }
                                if (x == 14) { bX039Y014 = pixelColorStringValue; }
                                if (x == 15) { bX039Y015 = pixelColorStringValue; }
                                if (x == 16) { bX039Y016 = pixelColorStringValue; }
                                if (x == 17) { bX039Y017 = pixelColorStringValue; }
                                if (x == 18) { bX039Y018 = pixelColorStringValue; }
                                if (x == 19) { bX039Y019 = pixelColorStringValue; }
                                if (x == 20) { bX039Y020 = pixelColorStringValue; }
                                if (x == 21) { bX039Y021 = pixelColorStringValue; }
                                if (x == 22) { bX039Y022 = pixelColorStringValue; }
                                if (x == 23) { bX039Y023 = pixelColorStringValue; }
                                if (x == 24) { bX039Y024 = pixelColorStringValue; }
                                if (x == 25) { bX039Y025 = pixelColorStringValue; }
                                if (x == 26) { bX039Y026 = pixelColorStringValue; }
                                if (x == 27) { bX039Y027 = pixelColorStringValue; }
                                if (x == 28) { bX039Y028 = pixelColorStringValue; }
                                if (x == 29) { bX039Y029 = pixelColorStringValue; }
                                if (x == 30) { bX039Y030 = pixelColorStringValue; }
                                if (x == 31) { bX039Y031 = pixelColorStringValue; }
                                if (x == 32) { bX039Y032 = pixelColorStringValue; }
                                if (x == 33) { bX039Y033 = pixelColorStringValue; }
                                if (x == 34) { bX039Y034 = pixelColorStringValue; }
                                if (x == 35) { bX039Y035 = pixelColorStringValue; }
                                if (x == 36) { bX039Y036 = pixelColorStringValue; }
                                if (x == 37) { bX039Y037 = pixelColorStringValue; }
                                if (x == 38) { bX039Y038 = pixelColorStringValue; }
                                if (x == 39) { bX039Y039 = pixelColorStringValue; }
                                if (x == 40) { bX039Y040 = pixelColorStringValue; }
                                if (x == 41) { bX039Y041 = pixelColorStringValue; }
                                if (x == 42) { bX039Y042 = pixelColorStringValue; }
                                if (x == 43) { bX039Y043 = pixelColorStringValue; }
                                if (x == 44) { bX039Y044 = pixelColorStringValue; }
                                if (x == 45) { bX039Y045 = pixelColorStringValue; }
                                if (x == 46) { bX039Y046 = pixelColorStringValue; }
                                if (x == 47) { bX039Y047 = pixelColorStringValue; }
                                if (x == 48) { bX039Y048 = pixelColorStringValue; }
                                if (x == 49) { bX039Y049 = pixelColorStringValue; }
                                if (x == 50) { bX039Y050 = pixelColorStringValue; }
                                if (x == 51) { bX039Y051 = pixelColorStringValue; }
                                if (x == 52) { bX039Y052 = pixelColorStringValue; }
                                if (x == 53) { bX039Y053 = pixelColorStringValue; }
                                if (x == 54) { bX039Y054 = pixelColorStringValue; }
                                if (x == 55) { bX039Y055 = pixelColorStringValue; }
                                if (x == 56) { bX039Y056 = pixelColorStringValue; }
                                if (x == 57) { bX039Y057 = pixelColorStringValue; }
                                if (x == 58) { bX039Y058 = pixelColorStringValue; }
                                if (x == 59) { bX039Y059 = pixelColorStringValue; }
                                if (x == 60) { bX039Y060 = pixelColorStringValue; }
                                if (x == 61) { bX039Y061 = pixelColorStringValue; }
                                if (x == 62) { bX039Y062 = pixelColorStringValue; }
                                if (x == 63) { bX039Y063 = pixelColorStringValue; }

                            }

                            if (y == 40)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX040Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX040Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX040Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX040Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX040Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX040Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX040Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX040Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX040Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX040Y009 = pixelColorStringValue; }
                                if (x == 10) { bX040Y010 = pixelColorStringValue; }
                                if (x == 11) { bX040Y011 = pixelColorStringValue; }
                                if (x == 12) { bX040Y012 = pixelColorStringValue; }
                                if (x == 13) { bX040Y013 = pixelColorStringValue; }
                                if (x == 14) { bX040Y014 = pixelColorStringValue; }
                                if (x == 15) { bX040Y015 = pixelColorStringValue; }
                                if (x == 16) { bX040Y016 = pixelColorStringValue; }
                                if (x == 17) { bX040Y017 = pixelColorStringValue; }
                                if (x == 18) { bX040Y018 = pixelColorStringValue; }
                                if (x == 19) { bX040Y019 = pixelColorStringValue; }
                                if (x == 20) { bX040Y020 = pixelColorStringValue; }
                                if (x == 21) { bX040Y021 = pixelColorStringValue; }
                                if (x == 22) { bX040Y022 = pixelColorStringValue; }
                                if (x == 23) { bX040Y023 = pixelColorStringValue; }
                                if (x == 24) { bX040Y024 = pixelColorStringValue; }
                                if (x == 25) { bX040Y025 = pixelColorStringValue; }
                                if (x == 26) { bX040Y026 = pixelColorStringValue; }
                                if (x == 27) { bX040Y027 = pixelColorStringValue; }
                                if (x == 28) { bX040Y028 = pixelColorStringValue; }
                                if (x == 29) { bX040Y029 = pixelColorStringValue; }
                                if (x == 30) { bX040Y030 = pixelColorStringValue; }
                                if (x == 31) { bX040Y031 = pixelColorStringValue; }
                                if (x == 32) { bX040Y032 = pixelColorStringValue; }
                                if (x == 33) { bX040Y033 = pixelColorStringValue; }
                                if (x == 34) { bX040Y034 = pixelColorStringValue; }
                                if (x == 35) { bX040Y035 = pixelColorStringValue; }
                                if (x == 36) { bX040Y036 = pixelColorStringValue; }
                                if (x == 37) { bX040Y037 = pixelColorStringValue; }
                                if (x == 38) { bX040Y038 = pixelColorStringValue; }
                                if (x == 39) { bX040Y039 = pixelColorStringValue; }
                                if (x == 40) { bX040Y040 = pixelColorStringValue; }
                                if (x == 41) { bX040Y041 = pixelColorStringValue; }
                                if (x == 42) { bX040Y042 = pixelColorStringValue; }
                                if (x == 43) { bX040Y043 = pixelColorStringValue; }
                                if (x == 44) { bX040Y044 = pixelColorStringValue; }
                                if (x == 45) { bX040Y045 = pixelColorStringValue; }
                                if (x == 46) { bX040Y046 = pixelColorStringValue; }
                                if (x == 47) { bX040Y047 = pixelColorStringValue; }
                                if (x == 48) { bX040Y048 = pixelColorStringValue; }
                                if (x == 49) { bX040Y049 = pixelColorStringValue; }
                                if (x == 50) { bX040Y050 = pixelColorStringValue; }
                                if (x == 51) { bX040Y051 = pixelColorStringValue; }
                                if (x == 52) { bX040Y052 = pixelColorStringValue; }
                                if (x == 53) { bX040Y053 = pixelColorStringValue; }
                                if (x == 54) { bX040Y054 = pixelColorStringValue; }
                                if (x == 55) { bX040Y055 = pixelColorStringValue; }
                                if (x == 56) { bX040Y056 = pixelColorStringValue; }
                                if (x == 57) { bX040Y057 = pixelColorStringValue; }
                                if (x == 58) { bX040Y058 = pixelColorStringValue; }
                                if (x == 59) { bX040Y059 = pixelColorStringValue; }
                                if (x == 60) { bX040Y060 = pixelColorStringValue; }
                                if (x == 61) { bX040Y061 = pixelColorStringValue; }
                                if (x == 62) { bX040Y062 = pixelColorStringValue; }
                                if (x == 63) { bX040Y063 = pixelColorStringValue; }

                            }

                            if (y == 41)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX041Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX041Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX041Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX041Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX041Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX041Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX041Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX041Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX041Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX041Y009 = pixelColorStringValue; }
                                if (x == 10) { bX041Y010 = pixelColorStringValue; }
                                if (x == 11) { bX041Y011 = pixelColorStringValue; }
                                if (x == 12) { bX041Y012 = pixelColorStringValue; }
                                if (x == 13) { bX041Y013 = pixelColorStringValue; }
                                if (x == 14) { bX041Y014 = pixelColorStringValue; }
                                if (x == 15) { bX041Y015 = pixelColorStringValue; }
                                if (x == 16) { bX041Y016 = pixelColorStringValue; }
                                if (x == 17) { bX041Y017 = pixelColorStringValue; }
                                if (x == 18) { bX041Y018 = pixelColorStringValue; }
                                if (x == 19) { bX041Y019 = pixelColorStringValue; }
                                if (x == 20) { bX041Y020 = pixelColorStringValue; }
                                if (x == 21) { bX041Y021 = pixelColorStringValue; }
                                if (x == 22) { bX041Y022 = pixelColorStringValue; }
                                if (x == 23) { bX041Y023 = pixelColorStringValue; }
                                if (x == 24) { bX041Y024 = pixelColorStringValue; }
                                if (x == 25) { bX041Y025 = pixelColorStringValue; }
                                if (x == 26) { bX041Y026 = pixelColorStringValue; }
                                if (x == 27) { bX041Y027 = pixelColorStringValue; }
                                if (x == 28) { bX041Y028 = pixelColorStringValue; }
                                if (x == 29) { bX041Y029 = pixelColorStringValue; }
                                if (x == 30) { bX041Y030 = pixelColorStringValue; }
                                if (x == 31) { bX041Y031 = pixelColorStringValue; }
                                if (x == 32) { bX041Y032 = pixelColorStringValue; }
                                if (x == 33) { bX041Y033 = pixelColorStringValue; }
                                if (x == 34) { bX041Y034 = pixelColorStringValue; }
                                if (x == 35) { bX041Y035 = pixelColorStringValue; }
                                if (x == 36) { bX041Y036 = pixelColorStringValue; }
                                if (x == 37) { bX041Y037 = pixelColorStringValue; }
                                if (x == 38) { bX041Y038 = pixelColorStringValue; }
                                if (x == 39) { bX041Y039 = pixelColorStringValue; }
                                if (x == 40) { bX041Y040 = pixelColorStringValue; }
                                if (x == 41) { bX041Y041 = pixelColorStringValue; }
                                if (x == 42) { bX041Y042 = pixelColorStringValue; }
                                if (x == 43) { bX041Y043 = pixelColorStringValue; }
                                if (x == 44) { bX041Y044 = pixelColorStringValue; }
                                if (x == 45) { bX041Y045 = pixelColorStringValue; }
                                if (x == 46) { bX041Y046 = pixelColorStringValue; }
                                if (x == 47) { bX041Y047 = pixelColorStringValue; }
                                if (x == 48) { bX041Y048 = pixelColorStringValue; }
                                if (x == 49) { bX041Y049 = pixelColorStringValue; }
                                if (x == 50) { bX041Y050 = pixelColorStringValue; }
                                if (x == 51) { bX041Y051 = pixelColorStringValue; }
                                if (x == 52) { bX041Y052 = pixelColorStringValue; }
                                if (x == 53) { bX041Y053 = pixelColorStringValue; }
                                if (x == 54) { bX041Y054 = pixelColorStringValue; }
                                if (x == 55) { bX041Y055 = pixelColorStringValue; }
                                if (x == 56) { bX041Y056 = pixelColorStringValue; }
                                if (x == 57) { bX041Y057 = pixelColorStringValue; }
                                if (x == 58) { bX041Y058 = pixelColorStringValue; }
                                if (x == 59) { bX041Y059 = pixelColorStringValue; }
                                if (x == 60) { bX041Y060 = pixelColorStringValue; }
                                if (x == 61) { bX041Y061 = pixelColorStringValue; }
                                if (x == 62) { bX041Y062 = pixelColorStringValue; }
                                if (x == 63) { bX041Y063 = pixelColorStringValue; }

                            }

                            if (y == 42)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX042Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX042Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX042Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX042Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX042Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX042Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX042Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX042Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX042Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX042Y009 = pixelColorStringValue; }
                                if (x == 10) { bX042Y010 = pixelColorStringValue; }
                                if (x == 11) { bX042Y011 = pixelColorStringValue; }
                                if (x == 12) { bX042Y012 = pixelColorStringValue; }
                                if (x == 13) { bX042Y013 = pixelColorStringValue; }
                                if (x == 14) { bX042Y014 = pixelColorStringValue; }
                                if (x == 15) { bX042Y015 = pixelColorStringValue; }
                                if (x == 16) { bX042Y016 = pixelColorStringValue; }
                                if (x == 17) { bX042Y017 = pixelColorStringValue; }
                                if (x == 18) { bX042Y018 = pixelColorStringValue; }
                                if (x == 19) { bX042Y019 = pixelColorStringValue; }
                                if (x == 20) { bX042Y020 = pixelColorStringValue; }
                                if (x == 21) { bX042Y021 = pixelColorStringValue; }
                                if (x == 22) { bX042Y022 = pixelColorStringValue; }
                                if (x == 23) { bX042Y023 = pixelColorStringValue; }
                                if (x == 24) { bX042Y024 = pixelColorStringValue; }
                                if (x == 25) { bX042Y025 = pixelColorStringValue; }
                                if (x == 26) { bX042Y026 = pixelColorStringValue; }
                                if (x == 27) { bX042Y027 = pixelColorStringValue; }
                                if (x == 28) { bX042Y028 = pixelColorStringValue; }
                                if (x == 29) { bX042Y029 = pixelColorStringValue; }
                                if (x == 30) { bX042Y030 = pixelColorStringValue; }
                                if (x == 31) { bX042Y031 = pixelColorStringValue; }
                                if (x == 32) { bX042Y032 = pixelColorStringValue; }
                                if (x == 33) { bX042Y033 = pixelColorStringValue; }
                                if (x == 34) { bX042Y034 = pixelColorStringValue; }
                                if (x == 35) { bX042Y035 = pixelColorStringValue; }
                                if (x == 36) { bX042Y036 = pixelColorStringValue; }
                                if (x == 37) { bX042Y037 = pixelColorStringValue; }
                                if (x == 38) { bX042Y038 = pixelColorStringValue; }
                                if (x == 39) { bX042Y039 = pixelColorStringValue; }
                                if (x == 40) { bX042Y040 = pixelColorStringValue; }
                                if (x == 41) { bX042Y041 = pixelColorStringValue; }
                                if (x == 42) { bX042Y042 = pixelColorStringValue; }
                                if (x == 43) { bX042Y043 = pixelColorStringValue; }
                                if (x == 44) { bX042Y044 = pixelColorStringValue; }
                                if (x == 45) { bX042Y045 = pixelColorStringValue; }
                                if (x == 46) { bX042Y046 = pixelColorStringValue; }
                                if (x == 47) { bX042Y047 = pixelColorStringValue; }
                                if (x == 48) { bX042Y048 = pixelColorStringValue; }
                                if (x == 49) { bX042Y049 = pixelColorStringValue; }
                                if (x == 50) { bX042Y050 = pixelColorStringValue; }
                                if (x == 51) { bX042Y051 = pixelColorStringValue; }
                                if (x == 52) { bX042Y052 = pixelColorStringValue; }
                                if (x == 53) { bX042Y053 = pixelColorStringValue; }
                                if (x == 54) { bX042Y054 = pixelColorStringValue; }
                                if (x == 55) { bX042Y055 = pixelColorStringValue; }
                                if (x == 56) { bX042Y056 = pixelColorStringValue; }
                                if (x == 57) { bX042Y057 = pixelColorStringValue; }
                                if (x == 58) { bX042Y058 = pixelColorStringValue; }
                                if (x == 59) { bX042Y059 = pixelColorStringValue; }
                                if (x == 60) { bX042Y060 = pixelColorStringValue; }
                                if (x == 61) { bX042Y061 = pixelColorStringValue; }
                                if (x == 62) { bX042Y062 = pixelColorStringValue; }
                                if (x == 63) { bX042Y063 = pixelColorStringValue; }

                            }

                            if (y == 43)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX043Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX043Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX043Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX043Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX043Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX043Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX043Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX043Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX043Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX043Y009 = pixelColorStringValue; }
                                if (x == 10) { bX043Y010 = pixelColorStringValue; }
                                if (x == 11) { bX043Y011 = pixelColorStringValue; }
                                if (x == 12) { bX043Y012 = pixelColorStringValue; }
                                if (x == 13) { bX043Y013 = pixelColorStringValue; }
                                if (x == 14) { bX043Y014 = pixelColorStringValue; }
                                if (x == 15) { bX043Y015 = pixelColorStringValue; }
                                if (x == 16) { bX043Y016 = pixelColorStringValue; }
                                if (x == 17) { bX043Y017 = pixelColorStringValue; }
                                if (x == 18) { bX043Y018 = pixelColorStringValue; }
                                if (x == 19) { bX043Y019 = pixelColorStringValue; }
                                if (x == 20) { bX043Y020 = pixelColorStringValue; }
                                if (x == 21) { bX043Y021 = pixelColorStringValue; }
                                if (x == 22) { bX043Y022 = pixelColorStringValue; }
                                if (x == 23) { bX043Y023 = pixelColorStringValue; }
                                if (x == 24) { bX043Y024 = pixelColorStringValue; }
                                if (x == 25) { bX043Y025 = pixelColorStringValue; }
                                if (x == 26) { bX043Y026 = pixelColorStringValue; }
                                if (x == 27) { bX043Y027 = pixelColorStringValue; }
                                if (x == 28) { bX043Y028 = pixelColorStringValue; }
                                if (x == 29) { bX043Y029 = pixelColorStringValue; }
                                if (x == 30) { bX043Y030 = pixelColorStringValue; }
                                if (x == 31) { bX043Y031 = pixelColorStringValue; }
                                if (x == 32) { bX043Y032 = pixelColorStringValue; }
                                if (x == 33) { bX043Y033 = pixelColorStringValue; }
                                if (x == 34) { bX043Y034 = pixelColorStringValue; }
                                if (x == 35) { bX043Y035 = pixelColorStringValue; }
                                if (x == 36) { bX043Y036 = pixelColorStringValue; }
                                if (x == 37) { bX043Y037 = pixelColorStringValue; }
                                if (x == 38) { bX043Y038 = pixelColorStringValue; }
                                if (x == 39) { bX043Y039 = pixelColorStringValue; }
                                if (x == 40) { bX043Y040 = pixelColorStringValue; }
                                if (x == 41) { bX043Y041 = pixelColorStringValue; }
                                if (x == 42) { bX043Y042 = pixelColorStringValue; }
                                if (x == 43) { bX043Y043 = pixelColorStringValue; }
                                if (x == 44) { bX043Y044 = pixelColorStringValue; }
                                if (x == 45) { bX043Y045 = pixelColorStringValue; }
                                if (x == 46) { bX043Y046 = pixelColorStringValue; }
                                if (x == 47) { bX043Y047 = pixelColorStringValue; }
                                if (x == 48) { bX043Y048 = pixelColorStringValue; }
                                if (x == 49) { bX043Y049 = pixelColorStringValue; }
                                if (x == 50) { bX043Y050 = pixelColorStringValue; }
                                if (x == 51) { bX043Y051 = pixelColorStringValue; }
                                if (x == 52) { bX043Y052 = pixelColorStringValue; }
                                if (x == 53) { bX043Y053 = pixelColorStringValue; }
                                if (x == 54) { bX043Y054 = pixelColorStringValue; }
                                if (x == 55) { bX043Y055 = pixelColorStringValue; }
                                if (x == 56) { bX043Y056 = pixelColorStringValue; }
                                if (x == 57) { bX043Y057 = pixelColorStringValue; }
                                if (x == 58) { bX043Y058 = pixelColorStringValue; }
                                if (x == 59) { bX043Y059 = pixelColorStringValue; }
                                if (x == 60) { bX043Y060 = pixelColorStringValue; }
                                if (x == 61) { bX043Y061 = pixelColorStringValue; }
                                if (x == 62) { bX043Y062 = pixelColorStringValue; }
                                if (x == 63) { bX043Y063 = pixelColorStringValue; }

                            }

                            if (y == 44)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX044Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX044Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX044Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX044Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX044Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX044Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX044Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX044Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX044Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX044Y009 = pixelColorStringValue; }
                                if (x == 10) { bX044Y010 = pixelColorStringValue; }
                                if (x == 11) { bX044Y011 = pixelColorStringValue; }
                                if (x == 12) { bX044Y012 = pixelColorStringValue; }
                                if (x == 13) { bX044Y013 = pixelColorStringValue; }
                                if (x == 14) { bX044Y014 = pixelColorStringValue; }
                                if (x == 15) { bX044Y015 = pixelColorStringValue; }
                                if (x == 16) { bX044Y016 = pixelColorStringValue; }
                                if (x == 17) { bX044Y017 = pixelColorStringValue; }
                                if (x == 18) { bX044Y018 = pixelColorStringValue; }
                                if (x == 19) { bX044Y019 = pixelColorStringValue; }
                                if (x == 20) { bX044Y020 = pixelColorStringValue; }
                                if (x == 21) { bX044Y021 = pixelColorStringValue; }
                                if (x == 22) { bX044Y022 = pixelColorStringValue; }
                                if (x == 23) { bX044Y023 = pixelColorStringValue; }
                                if (x == 24) { bX044Y024 = pixelColorStringValue; }
                                if (x == 25) { bX044Y025 = pixelColorStringValue; }
                                if (x == 26) { bX044Y026 = pixelColorStringValue; }
                                if (x == 27) { bX044Y027 = pixelColorStringValue; }
                                if (x == 28) { bX044Y028 = pixelColorStringValue; }
                                if (x == 29) { bX044Y029 = pixelColorStringValue; }
                                if (x == 30) { bX044Y030 = pixelColorStringValue; }
                                if (x == 31) { bX044Y031 = pixelColorStringValue; }
                                if (x == 32) { bX044Y032 = pixelColorStringValue; }
                                if (x == 33) { bX044Y033 = pixelColorStringValue; }
                                if (x == 34) { bX044Y034 = pixelColorStringValue; }
                                if (x == 35) { bX044Y035 = pixelColorStringValue; }
                                if (x == 36) { bX044Y036 = pixelColorStringValue; }
                                if (x == 37) { bX044Y037 = pixelColorStringValue; }
                                if (x == 38) { bX044Y038 = pixelColorStringValue; }
                                if (x == 39) { bX044Y039 = pixelColorStringValue; }
                                if (x == 40) { bX044Y040 = pixelColorStringValue; }
                                if (x == 41) { bX044Y041 = pixelColorStringValue; }
                                if (x == 42) { bX044Y042 = pixelColorStringValue; }
                                if (x == 43) { bX044Y043 = pixelColorStringValue; }
                                if (x == 44) { bX044Y044 = pixelColorStringValue; }
                                if (x == 45) { bX044Y045 = pixelColorStringValue; }
                                if (x == 46) { bX044Y046 = pixelColorStringValue; }
                                if (x == 47) { bX044Y047 = pixelColorStringValue; }
                                if (x == 48) { bX044Y048 = pixelColorStringValue; }
                                if (x == 49) { bX044Y049 = pixelColorStringValue; }
                                if (x == 50) { bX044Y050 = pixelColorStringValue; }
                                if (x == 51) { bX044Y051 = pixelColorStringValue; }
                                if (x == 52) { bX044Y052 = pixelColorStringValue; }
                                if (x == 53) { bX044Y053 = pixelColorStringValue; }
                                if (x == 54) { bX044Y054 = pixelColorStringValue; }
                                if (x == 55) { bX044Y055 = pixelColorStringValue; }
                                if (x == 56) { bX044Y056 = pixelColorStringValue; }
                                if (x == 57) { bX044Y057 = pixelColorStringValue; }
                                if (x == 58) { bX044Y058 = pixelColorStringValue; }
                                if (x == 59) { bX044Y059 = pixelColorStringValue; }
                                if (x == 60) { bX044Y060 = pixelColorStringValue; }
                                if (x == 61) { bX044Y061 = pixelColorStringValue; }
                                if (x == 62) { bX044Y062 = pixelColorStringValue; }
                                if (x == 63) { bX044Y063 = pixelColorStringValue; }

                            }

                            if (y == 45)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX045Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX045Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX045Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX045Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX045Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX045Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX045Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX045Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX045Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX045Y009 = pixelColorStringValue; }
                                if (x == 10) { bX045Y010 = pixelColorStringValue; }
                                if (x == 11) { bX045Y011 = pixelColorStringValue; }
                                if (x == 12) { bX045Y012 = pixelColorStringValue; }
                                if (x == 13) { bX045Y013 = pixelColorStringValue; }
                                if (x == 14) { bX045Y014 = pixelColorStringValue; }
                                if (x == 15) { bX045Y015 = pixelColorStringValue; }
                                if (x == 16) { bX045Y016 = pixelColorStringValue; }
                                if (x == 17) { bX045Y017 = pixelColorStringValue; }
                                if (x == 18) { bX045Y018 = pixelColorStringValue; }
                                if (x == 19) { bX045Y019 = pixelColorStringValue; }
                                if (x == 20) { bX045Y020 = pixelColorStringValue; }
                                if (x == 21) { bX045Y021 = pixelColorStringValue; }
                                if (x == 22) { bX045Y022 = pixelColorStringValue; }
                                if (x == 23) { bX045Y023 = pixelColorStringValue; }
                                if (x == 24) { bX045Y024 = pixelColorStringValue; }
                                if (x == 25) { bX045Y025 = pixelColorStringValue; }
                                if (x == 26) { bX045Y026 = pixelColorStringValue; }
                                if (x == 27) { bX045Y027 = pixelColorStringValue; }
                                if (x == 28) { bX045Y028 = pixelColorStringValue; }
                                if (x == 29) { bX045Y029 = pixelColorStringValue; }
                                if (x == 30) { bX045Y030 = pixelColorStringValue; }
                                if (x == 31) { bX045Y031 = pixelColorStringValue; }
                                if (x == 32) { bX045Y032 = pixelColorStringValue; }
                                if (x == 33) { bX045Y033 = pixelColorStringValue; }
                                if (x == 34) { bX045Y034 = pixelColorStringValue; }
                                if (x == 35) { bX045Y035 = pixelColorStringValue; }
                                if (x == 36) { bX045Y036 = pixelColorStringValue; }
                                if (x == 37) { bX045Y037 = pixelColorStringValue; }
                                if (x == 38) { bX045Y038 = pixelColorStringValue; }
                                if (x == 39) { bX045Y039 = pixelColorStringValue; }
                                if (x == 40) { bX045Y040 = pixelColorStringValue; }
                                if (x == 41) { bX045Y041 = pixelColorStringValue; }
                                if (x == 42) { bX045Y042 = pixelColorStringValue; }
                                if (x == 43) { bX045Y043 = pixelColorStringValue; }
                                if (x == 44) { bX045Y044 = pixelColorStringValue; }
                                if (x == 45) { bX045Y045 = pixelColorStringValue; }
                                if (x == 46) { bX045Y046 = pixelColorStringValue; }
                                if (x == 47) { bX045Y047 = pixelColorStringValue; }
                                if (x == 48) { bX045Y048 = pixelColorStringValue; }
                                if (x == 49) { bX045Y049 = pixelColorStringValue; }
                                if (x == 50) { bX045Y050 = pixelColorStringValue; }
                                if (x == 51) { bX045Y051 = pixelColorStringValue; }
                                if (x == 52) { bX045Y052 = pixelColorStringValue; }
                                if (x == 53) { bX045Y053 = pixelColorStringValue; }
                                if (x == 54) { bX045Y054 = pixelColorStringValue; }
                                if (x == 55) { bX045Y055 = pixelColorStringValue; }
                                if (x == 56) { bX045Y056 = pixelColorStringValue; }
                                if (x == 57) { bX045Y057 = pixelColorStringValue; }
                                if (x == 58) { bX045Y058 = pixelColorStringValue; }
                                if (x == 59) { bX045Y059 = pixelColorStringValue; }
                                if (x == 60) { bX045Y060 = pixelColorStringValue; }
                                if (x == 61) { bX045Y061 = pixelColorStringValue; }
                                if (x == 62) { bX045Y062 = pixelColorStringValue; }
                                if (x == 63) { bX045Y063 = pixelColorStringValue; }

                            }

                            if (y == 46)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX046Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX046Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX046Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX046Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX046Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX046Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX046Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX046Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX046Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX046Y009 = pixelColorStringValue; }
                                if (x == 10) { bX046Y010 = pixelColorStringValue; }
                                if (x == 11) { bX046Y011 = pixelColorStringValue; }
                                if (x == 12) { bX046Y012 = pixelColorStringValue; }
                                if (x == 13) { bX046Y013 = pixelColorStringValue; }
                                if (x == 14) { bX046Y014 = pixelColorStringValue; }
                                if (x == 15) { bX046Y015 = pixelColorStringValue; }
                                if (x == 16) { bX046Y016 = pixelColorStringValue; }
                                if (x == 17) { bX046Y017 = pixelColorStringValue; }
                                if (x == 18) { bX046Y018 = pixelColorStringValue; }
                                if (x == 19) { bX046Y019 = pixelColorStringValue; }
                                if (x == 20) { bX046Y020 = pixelColorStringValue; }
                                if (x == 21) { bX046Y021 = pixelColorStringValue; }
                                if (x == 22) { bX046Y022 = pixelColorStringValue; }
                                if (x == 23) { bX046Y023 = pixelColorStringValue; }
                                if (x == 24) { bX046Y024 = pixelColorStringValue; }
                                if (x == 25) { bX046Y025 = pixelColorStringValue; }
                                if (x == 26) { bX046Y026 = pixelColorStringValue; }
                                if (x == 27) { bX046Y027 = pixelColorStringValue; }
                                if (x == 28) { bX046Y028 = pixelColorStringValue; }
                                if (x == 29) { bX046Y029 = pixelColorStringValue; }
                                if (x == 30) { bX046Y030 = pixelColorStringValue; }
                                if (x == 31) { bX046Y031 = pixelColorStringValue; }
                                if (x == 32) { bX046Y032 = pixelColorStringValue; }
                                if (x == 33) { bX046Y033 = pixelColorStringValue; }
                                if (x == 34) { bX046Y034 = pixelColorStringValue; }
                                if (x == 35) { bX046Y035 = pixelColorStringValue; }
                                if (x == 36) { bX046Y036 = pixelColorStringValue; }
                                if (x == 37) { bX046Y037 = pixelColorStringValue; }
                                if (x == 38) { bX046Y038 = pixelColorStringValue; }
                                if (x == 39) { bX046Y039 = pixelColorStringValue; }
                                if (x == 40) { bX046Y040 = pixelColorStringValue; }
                                if (x == 41) { bX046Y041 = pixelColorStringValue; }
                                if (x == 42) { bX046Y042 = pixelColorStringValue; }
                                if (x == 43) { bX046Y043 = pixelColorStringValue; }
                                if (x == 44) { bX046Y044 = pixelColorStringValue; }
                                if (x == 45) { bX046Y045 = pixelColorStringValue; }
                                if (x == 46) { bX046Y046 = pixelColorStringValue; }
                                if (x == 47) { bX046Y047 = pixelColorStringValue; }
                                if (x == 48) { bX046Y048 = pixelColorStringValue; }
                                if (x == 49) { bX046Y049 = pixelColorStringValue; }
                                if (x == 50) { bX046Y050 = pixelColorStringValue; }
                                if (x == 51) { bX046Y051 = pixelColorStringValue; }
                                if (x == 52) { bX046Y052 = pixelColorStringValue; }
                                if (x == 53) { bX046Y053 = pixelColorStringValue; }
                                if (x == 54) { bX046Y054 = pixelColorStringValue; }
                                if (x == 55) { bX046Y055 = pixelColorStringValue; }
                                if (x == 56) { bX046Y056 = pixelColorStringValue; }
                                if (x == 57) { bX046Y057 = pixelColorStringValue; }
                                if (x == 58) { bX046Y058 = pixelColorStringValue; }
                                if (x == 59) { bX046Y059 = pixelColorStringValue; }
                                if (x == 60) { bX046Y060 = pixelColorStringValue; }
                                if (x == 61) { bX046Y061 = pixelColorStringValue; }
                                if (x == 62) { bX046Y062 = pixelColorStringValue; }
                                if (x == 63) { bX046Y063 = pixelColorStringValue; }

                            }

                            if (y == 47)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX047Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX047Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX047Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX047Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX047Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX047Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX047Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX047Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX047Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX047Y009 = pixelColorStringValue; }
                                if (x == 10) { bX047Y010 = pixelColorStringValue; }
                                if (x == 11) { bX047Y011 = pixelColorStringValue; }
                                if (x == 12) { bX047Y012 = pixelColorStringValue; }
                                if (x == 13) { bX047Y013 = pixelColorStringValue; }
                                if (x == 14) { bX047Y014 = pixelColorStringValue; }
                                if (x == 15) { bX047Y015 = pixelColorStringValue; }
                                if (x == 16) { bX047Y016 = pixelColorStringValue; }
                                if (x == 17) { bX047Y017 = pixelColorStringValue; }
                                if (x == 18) { bX047Y018 = pixelColorStringValue; }
                                if (x == 19) { bX047Y019 = pixelColorStringValue; }
                                if (x == 20) { bX047Y020 = pixelColorStringValue; }
                                if (x == 21) { bX047Y021 = pixelColorStringValue; }
                                if (x == 22) { bX047Y022 = pixelColorStringValue; }
                                if (x == 23) { bX047Y023 = pixelColorStringValue; }
                                if (x == 24) { bX047Y024 = pixelColorStringValue; }
                                if (x == 25) { bX047Y025 = pixelColorStringValue; }
                                if (x == 26) { bX047Y026 = pixelColorStringValue; }
                                if (x == 27) { bX047Y027 = pixelColorStringValue; }
                                if (x == 28) { bX047Y028 = pixelColorStringValue; }
                                if (x == 29) { bX047Y029 = pixelColorStringValue; }
                                if (x == 30) { bX047Y030 = pixelColorStringValue; }
                                if (x == 31) { bX047Y031 = pixelColorStringValue; }
                                if (x == 32) { bX047Y032 = pixelColorStringValue; }
                                if (x == 33) { bX047Y033 = pixelColorStringValue; }
                                if (x == 34) { bX047Y034 = pixelColorStringValue; }
                                if (x == 35) { bX047Y035 = pixelColorStringValue; }
                                if (x == 36) { bX047Y036 = pixelColorStringValue; }
                                if (x == 37) { bX047Y037 = pixelColorStringValue; }
                                if (x == 38) { bX047Y038 = pixelColorStringValue; }
                                if (x == 39) { bX047Y039 = pixelColorStringValue; }
                                if (x == 40) { bX047Y040 = pixelColorStringValue; }
                                if (x == 41) { bX047Y041 = pixelColorStringValue; }
                                if (x == 42) { bX047Y042 = pixelColorStringValue; }
                                if (x == 43) { bX047Y043 = pixelColorStringValue; }
                                if (x == 44) { bX047Y044 = pixelColorStringValue; }
                                if (x == 45) { bX047Y045 = pixelColorStringValue; }
                                if (x == 46) { bX047Y046 = pixelColorStringValue; }
                                if (x == 47) { bX047Y047 = pixelColorStringValue; }
                                if (x == 48) { bX047Y048 = pixelColorStringValue; }
                                if (x == 49) { bX047Y049 = pixelColorStringValue; }
                                if (x == 50) { bX047Y050 = pixelColorStringValue; }
                                if (x == 51) { bX047Y051 = pixelColorStringValue; }
                                if (x == 52) { bX047Y052 = pixelColorStringValue; }
                                if (x == 53) { bX047Y053 = pixelColorStringValue; }
                                if (x == 54) { bX047Y054 = pixelColorStringValue; }
                                if (x == 55) { bX047Y055 = pixelColorStringValue; }
                                if (x == 56) { bX047Y056 = pixelColorStringValue; }
                                if (x == 57) { bX047Y057 = pixelColorStringValue; }
                                if (x == 58) { bX047Y058 = pixelColorStringValue; }
                                if (x == 59) { bX047Y059 = pixelColorStringValue; }
                                if (x == 60) { bX047Y060 = pixelColorStringValue; }
                                if (x == 61) { bX047Y061 = pixelColorStringValue; }
                                if (x == 62) { bX047Y062 = pixelColorStringValue; }
                                if (x == 63) { bX047Y063 = pixelColorStringValue; }

                            }

                            if (y == 48)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX048Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX048Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX048Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX048Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX048Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX048Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX048Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX048Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX048Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX048Y009 = pixelColorStringValue; }
                                if (x == 10) { bX048Y010 = pixelColorStringValue; }
                                if (x == 11) { bX048Y011 = pixelColorStringValue; }
                                if (x == 12) { bX048Y012 = pixelColorStringValue; }
                                if (x == 13) { bX048Y013 = pixelColorStringValue; }
                                if (x == 14) { bX048Y014 = pixelColorStringValue; }
                                if (x == 15) { bX048Y015 = pixelColorStringValue; }
                                if (x == 16) { bX048Y016 = pixelColorStringValue; }
                                if (x == 17) { bX048Y017 = pixelColorStringValue; }
                                if (x == 18) { bX048Y018 = pixelColorStringValue; }
                                if (x == 19) { bX048Y019 = pixelColorStringValue; }
                                if (x == 20) { bX048Y020 = pixelColorStringValue; }
                                if (x == 21) { bX048Y021 = pixelColorStringValue; }
                                if (x == 22) { bX048Y022 = pixelColorStringValue; }
                                if (x == 23) { bX048Y023 = pixelColorStringValue; }
                                if (x == 24) { bX048Y024 = pixelColorStringValue; }
                                if (x == 25) { bX048Y025 = pixelColorStringValue; }
                                if (x == 26) { bX048Y026 = pixelColorStringValue; }
                                if (x == 27) { bX048Y027 = pixelColorStringValue; }
                                if (x == 28) { bX048Y028 = pixelColorStringValue; }
                                if (x == 29) { bX048Y029 = pixelColorStringValue; }
                                if (x == 30) { bX048Y030 = pixelColorStringValue; }
                                if (x == 31) { bX048Y031 = pixelColorStringValue; }
                                if (x == 32) { bX048Y032 = pixelColorStringValue; }
                                if (x == 33) { bX048Y033 = pixelColorStringValue; }
                                if (x == 34) { bX048Y034 = pixelColorStringValue; }
                                if (x == 35) { bX048Y035 = pixelColorStringValue; }
                                if (x == 36) { bX048Y036 = pixelColorStringValue; }
                                if (x == 37) { bX048Y037 = pixelColorStringValue; }
                                if (x == 38) { bX048Y038 = pixelColorStringValue; }
                                if (x == 39) { bX048Y039 = pixelColorStringValue; }
                                if (x == 40) { bX048Y040 = pixelColorStringValue; }
                                if (x == 41) { bX048Y041 = pixelColorStringValue; }
                                if (x == 42) { bX048Y042 = pixelColorStringValue; }
                                if (x == 43) { bX048Y043 = pixelColorStringValue; }
                                if (x == 44) { bX048Y044 = pixelColorStringValue; }
                                if (x == 45) { bX048Y045 = pixelColorStringValue; }
                                if (x == 46) { bX048Y046 = pixelColorStringValue; }
                                if (x == 47) { bX048Y047 = pixelColorStringValue; }
                                if (x == 48) { bX048Y048 = pixelColorStringValue; }
                                if (x == 49) { bX048Y049 = pixelColorStringValue; }
                                if (x == 50) { bX048Y050 = pixelColorStringValue; }
                                if (x == 51) { bX048Y051 = pixelColorStringValue; }
                                if (x == 52) { bX048Y052 = pixelColorStringValue; }
                                if (x == 53) { bX048Y053 = pixelColorStringValue; }
                                if (x == 54) { bX048Y054 = pixelColorStringValue; }
                                if (x == 55) { bX048Y055 = pixelColorStringValue; }
                                if (x == 56) { bX048Y056 = pixelColorStringValue; }
                                if (x == 57) { bX048Y057 = pixelColorStringValue; }
                                if (x == 58) { bX048Y058 = pixelColorStringValue; }
                                if (x == 59) { bX048Y059 = pixelColorStringValue; }
                                if (x == 60) { bX048Y060 = pixelColorStringValue; }
                                if (x == 61) { bX048Y061 = pixelColorStringValue; }
                                if (x == 62) { bX048Y062 = pixelColorStringValue; }
                                if (x == 63) { bX048Y063 = pixelColorStringValue; }

                            }

                            if (y == 49)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX049Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX049Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX049Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX049Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX049Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX049Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX049Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX049Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX049Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX049Y009 = pixelColorStringValue; }
                                if (x == 10) { bX049Y010 = pixelColorStringValue; }
                                if (x == 11) { bX049Y011 = pixelColorStringValue; }
                                if (x == 12) { bX049Y012 = pixelColorStringValue; }
                                if (x == 13) { bX049Y013 = pixelColorStringValue; }
                                if (x == 14) { bX049Y014 = pixelColorStringValue; }
                                if (x == 15) { bX049Y015 = pixelColorStringValue; }
                                if (x == 16) { bX049Y016 = pixelColorStringValue; }
                                if (x == 17) { bX049Y017 = pixelColorStringValue; }
                                if (x == 18) { bX049Y018 = pixelColorStringValue; }
                                if (x == 19) { bX049Y019 = pixelColorStringValue; }
                                if (x == 20) { bX049Y020 = pixelColorStringValue; }
                                if (x == 21) { bX049Y021 = pixelColorStringValue; }
                                if (x == 22) { bX049Y022 = pixelColorStringValue; }
                                if (x == 23) { bX049Y023 = pixelColorStringValue; }
                                if (x == 24) { bX049Y024 = pixelColorStringValue; }
                                if (x == 25) { bX049Y025 = pixelColorStringValue; }
                                if (x == 26) { bX049Y026 = pixelColorStringValue; }
                                if (x == 27) { bX049Y027 = pixelColorStringValue; }
                                if (x == 28) { bX049Y028 = pixelColorStringValue; }
                                if (x == 29) { bX049Y029 = pixelColorStringValue; }
                                if (x == 30) { bX049Y030 = pixelColorStringValue; }
                                if (x == 31) { bX049Y031 = pixelColorStringValue; }
                                if (x == 32) { bX049Y032 = pixelColorStringValue; }
                                if (x == 33) { bX049Y033 = pixelColorStringValue; }
                                if (x == 34) { bX049Y034 = pixelColorStringValue; }
                                if (x == 35) { bX049Y035 = pixelColorStringValue; }
                                if (x == 36) { bX049Y036 = pixelColorStringValue; }
                                if (x == 37) { bX049Y037 = pixelColorStringValue; }
                                if (x == 38) { bX049Y038 = pixelColorStringValue; }
                                if (x == 39) { bX049Y039 = pixelColorStringValue; }
                                if (x == 40) { bX049Y040 = pixelColorStringValue; }
                                if (x == 41) { bX049Y041 = pixelColorStringValue; }
                                if (x == 42) { bX049Y042 = pixelColorStringValue; }
                                if (x == 43) { bX049Y043 = pixelColorStringValue; }
                                if (x == 44) { bX049Y044 = pixelColorStringValue; }
                                if (x == 45) { bX049Y045 = pixelColorStringValue; }
                                if (x == 46) { bX049Y046 = pixelColorStringValue; }
                                if (x == 47) { bX049Y047 = pixelColorStringValue; }
                                if (x == 48) { bX049Y048 = pixelColorStringValue; }
                                if (x == 49) { bX049Y049 = pixelColorStringValue; }
                                if (x == 50) { bX049Y050 = pixelColorStringValue; }
                                if (x == 51) { bX049Y051 = pixelColorStringValue; }
                                if (x == 52) { bX049Y052 = pixelColorStringValue; }
                                if (x == 53) { bX049Y053 = pixelColorStringValue; }
                                if (x == 54) { bX049Y054 = pixelColorStringValue; }
                                if (x == 55) { bX049Y055 = pixelColorStringValue; }
                                if (x == 56) { bX049Y056 = pixelColorStringValue; }
                                if (x == 57) { bX049Y057 = pixelColorStringValue; }
                                if (x == 58) { bX049Y058 = pixelColorStringValue; }
                                if (x == 59) { bX049Y059 = pixelColorStringValue; }
                                if (x == 60) { bX049Y060 = pixelColorStringValue; }
                                if (x == 61) { bX049Y061 = pixelColorStringValue; }
                                if (x == 62) { bX049Y062 = pixelColorStringValue; }
                                if (x == 63) { bX049Y063 = pixelColorStringValue; }

                            }

                            if (y == 50)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX050Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX050Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX050Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX050Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX050Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX050Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX050Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX050Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX050Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX050Y009 = pixelColorStringValue; }
                                if (x == 10) { bX050Y010 = pixelColorStringValue; }
                                if (x == 11) { bX050Y011 = pixelColorStringValue; }
                                if (x == 12) { bX050Y012 = pixelColorStringValue; }
                                if (x == 13) { bX050Y013 = pixelColorStringValue; }
                                if (x == 14) { bX050Y014 = pixelColorStringValue; }
                                if (x == 15) { bX050Y015 = pixelColorStringValue; }
                                if (x == 16) { bX050Y016 = pixelColorStringValue; }
                                if (x == 17) { bX050Y017 = pixelColorStringValue; }
                                if (x == 18) { bX050Y018 = pixelColorStringValue; }
                                if (x == 19) { bX050Y019 = pixelColorStringValue; }
                                if (x == 20) { bX050Y020 = pixelColorStringValue; }
                                if (x == 21) { bX050Y021 = pixelColorStringValue; }
                                if (x == 22) { bX050Y022 = pixelColorStringValue; }
                                if (x == 23) { bX050Y023 = pixelColorStringValue; }
                                if (x == 24) { bX050Y024 = pixelColorStringValue; }
                                if (x == 25) { bX050Y025 = pixelColorStringValue; }
                                if (x == 26) { bX050Y026 = pixelColorStringValue; }
                                if (x == 27) { bX050Y027 = pixelColorStringValue; }
                                if (x == 28) { bX050Y028 = pixelColorStringValue; }
                                if (x == 29) { bX050Y029 = pixelColorStringValue; }
                                if (x == 30) { bX050Y030 = pixelColorStringValue; }
                                if (x == 31) { bX050Y031 = pixelColorStringValue; }
                                if (x == 32) { bX050Y032 = pixelColorStringValue; }
                                if (x == 33) { bX050Y033 = pixelColorStringValue; }
                                if (x == 34) { bX050Y034 = pixelColorStringValue; }
                                if (x == 35) { bX050Y035 = pixelColorStringValue; }
                                if (x == 36) { bX050Y036 = pixelColorStringValue; }
                                if (x == 37) { bX050Y037 = pixelColorStringValue; }
                                if (x == 38) { bX050Y038 = pixelColorStringValue; }
                                if (x == 39) { bX050Y039 = pixelColorStringValue; }
                                if (x == 40) { bX050Y040 = pixelColorStringValue; }
                                if (x == 41) { bX050Y041 = pixelColorStringValue; }
                                if (x == 42) { bX050Y042 = pixelColorStringValue; }
                                if (x == 43) { bX050Y043 = pixelColorStringValue; }
                                if (x == 44) { bX050Y044 = pixelColorStringValue; }
                                if (x == 45) { bX050Y045 = pixelColorStringValue; }
                                if (x == 46) { bX050Y046 = pixelColorStringValue; }
                                if (x == 47) { bX050Y047 = pixelColorStringValue; }
                                if (x == 48) { bX050Y048 = pixelColorStringValue; }
                                if (x == 49) { bX050Y049 = pixelColorStringValue; }
                                if (x == 50) { bX050Y050 = pixelColorStringValue; }
                                if (x == 51) { bX050Y051 = pixelColorStringValue; }
                                if (x == 52) { bX050Y052 = pixelColorStringValue; }
                                if (x == 53) { bX050Y053 = pixelColorStringValue; }
                                if (x == 54) { bX050Y054 = pixelColorStringValue; }
                                if (x == 55) { bX050Y055 = pixelColorStringValue; }
                                if (x == 56) { bX050Y056 = pixelColorStringValue; }
                                if (x == 57) { bX050Y057 = pixelColorStringValue; }
                                if (x == 58) { bX050Y058 = pixelColorStringValue; }
                                if (x == 59) { bX050Y059 = pixelColorStringValue; }
                                if (x == 60) { bX050Y060 = pixelColorStringValue; }
                                if (x == 61) { bX050Y061 = pixelColorStringValue; }
                                if (x == 62) { bX050Y062 = pixelColorStringValue; }
                                if (x == 63) { bX050Y063 = pixelColorStringValue; }

                            }

                            if (y == 51)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX051Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX051Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX051Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX051Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX051Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX051Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX051Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX051Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX051Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX051Y009 = pixelColorStringValue; }
                                if (x == 10) { bX051Y010 = pixelColorStringValue; }
                                if (x == 11) { bX051Y011 = pixelColorStringValue; }
                                if (x == 12) { bX051Y012 = pixelColorStringValue; }
                                if (x == 13) { bX051Y013 = pixelColorStringValue; }
                                if (x == 14) { bX051Y014 = pixelColorStringValue; }
                                if (x == 15) { bX051Y015 = pixelColorStringValue; }
                                if (x == 16) { bX051Y016 = pixelColorStringValue; }
                                if (x == 17) { bX051Y017 = pixelColorStringValue; }
                                if (x == 18) { bX051Y018 = pixelColorStringValue; }
                                if (x == 19) { bX051Y019 = pixelColorStringValue; }
                                if (x == 20) { bX051Y020 = pixelColorStringValue; }
                                if (x == 21) { bX051Y021 = pixelColorStringValue; }
                                if (x == 22) { bX051Y022 = pixelColorStringValue; }
                                if (x == 23) { bX051Y023 = pixelColorStringValue; }
                                if (x == 24) { bX051Y024 = pixelColorStringValue; }
                                if (x == 25) { bX051Y025 = pixelColorStringValue; }
                                if (x == 26) { bX051Y026 = pixelColorStringValue; }
                                if (x == 27) { bX051Y027 = pixelColorStringValue; }
                                if (x == 28) { bX051Y028 = pixelColorStringValue; }
                                if (x == 29) { bX051Y029 = pixelColorStringValue; }
                                if (x == 30) { bX051Y030 = pixelColorStringValue; }
                                if (x == 31) { bX051Y031 = pixelColorStringValue; }
                                if (x == 32) { bX051Y032 = pixelColorStringValue; }
                                if (x == 33) { bX051Y033 = pixelColorStringValue; }
                                if (x == 34) { bX051Y034 = pixelColorStringValue; }
                                if (x == 35) { bX051Y035 = pixelColorStringValue; }
                                if (x == 36) { bX051Y036 = pixelColorStringValue; }
                                if (x == 37) { bX051Y037 = pixelColorStringValue; }
                                if (x == 38) { bX051Y038 = pixelColorStringValue; }
                                if (x == 39) { bX051Y039 = pixelColorStringValue; }
                                if (x == 40) { bX051Y040 = pixelColorStringValue; }
                                if (x == 41) { bX051Y041 = pixelColorStringValue; }
                                if (x == 42) { bX051Y042 = pixelColorStringValue; }
                                if (x == 43) { bX051Y043 = pixelColorStringValue; }
                                if (x == 44) { bX051Y044 = pixelColorStringValue; }
                                if (x == 45) { bX051Y045 = pixelColorStringValue; }
                                if (x == 46) { bX051Y046 = pixelColorStringValue; }
                                if (x == 47) { bX051Y047 = pixelColorStringValue; }
                                if (x == 48) { bX051Y048 = pixelColorStringValue; }
                                if (x == 49) { bX051Y049 = pixelColorStringValue; }
                                if (x == 50) { bX051Y050 = pixelColorStringValue; }
                                if (x == 51) { bX051Y051 = pixelColorStringValue; }
                                if (x == 52) { bX051Y052 = pixelColorStringValue; }
                                if (x == 53) { bX051Y053 = pixelColorStringValue; }
                                if (x == 54) { bX051Y054 = pixelColorStringValue; }
                                if (x == 55) { bX051Y055 = pixelColorStringValue; }
                                if (x == 56) { bX051Y056 = pixelColorStringValue; }
                                if (x == 57) { bX051Y057 = pixelColorStringValue; }
                                if (x == 58) { bX051Y058 = pixelColorStringValue; }
                                if (x == 59) { bX051Y059 = pixelColorStringValue; }
                                if (x == 60) { bX051Y060 = pixelColorStringValue; }
                                if (x == 61) { bX051Y061 = pixelColorStringValue; }
                                if (x == 62) { bX051Y062 = pixelColorStringValue; }
                                if (x == 63) { bX051Y063 = pixelColorStringValue; }

                            }

                            if (y == 52)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX052Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX052Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX052Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX052Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX052Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX052Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX052Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX052Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX052Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX052Y009 = pixelColorStringValue; }
                                if (x == 10) { bX052Y010 = pixelColorStringValue; }
                                if (x == 11) { bX052Y011 = pixelColorStringValue; }
                                if (x == 12) { bX052Y012 = pixelColorStringValue; }
                                if (x == 13) { bX052Y013 = pixelColorStringValue; }
                                if (x == 14) { bX052Y014 = pixelColorStringValue; }
                                if (x == 15) { bX052Y015 = pixelColorStringValue; }
                                if (x == 16) { bX052Y016 = pixelColorStringValue; }
                                if (x == 17) { bX052Y017 = pixelColorStringValue; }
                                if (x == 18) { bX052Y018 = pixelColorStringValue; }
                                if (x == 19) { bX052Y019 = pixelColorStringValue; }
                                if (x == 20) { bX052Y020 = pixelColorStringValue; }
                                if (x == 21) { bX052Y021 = pixelColorStringValue; }
                                if (x == 22) { bX052Y022 = pixelColorStringValue; }
                                if (x == 23) { bX052Y023 = pixelColorStringValue; }
                                if (x == 24) { bX052Y024 = pixelColorStringValue; }
                                if (x == 25) { bX052Y025 = pixelColorStringValue; }
                                if (x == 26) { bX052Y026 = pixelColorStringValue; }
                                if (x == 27) { bX052Y027 = pixelColorStringValue; }
                                if (x == 28) { bX052Y028 = pixelColorStringValue; }
                                if (x == 29) { bX052Y029 = pixelColorStringValue; }
                                if (x == 30) { bX052Y030 = pixelColorStringValue; }
                                if (x == 31) { bX052Y031 = pixelColorStringValue; }
                                if (x == 32) { bX052Y032 = pixelColorStringValue; }
                                if (x == 33) { bX052Y033 = pixelColorStringValue; }
                                if (x == 34) { bX052Y034 = pixelColorStringValue; }
                                if (x == 35) { bX052Y035 = pixelColorStringValue; }
                                if (x == 36) { bX052Y036 = pixelColorStringValue; }
                                if (x == 37) { bX052Y037 = pixelColorStringValue; }
                                if (x == 38) { bX052Y038 = pixelColorStringValue; }
                                if (x == 39) { bX052Y039 = pixelColorStringValue; }
                                if (x == 40) { bX052Y040 = pixelColorStringValue; }
                                if (x == 41) { bX052Y041 = pixelColorStringValue; }
                                if (x == 42) { bX052Y042 = pixelColorStringValue; }
                                if (x == 43) { bX052Y043 = pixelColorStringValue; }
                                if (x == 44) { bX052Y044 = pixelColorStringValue; }
                                if (x == 45) { bX052Y045 = pixelColorStringValue; }
                                if (x == 46) { bX052Y046 = pixelColorStringValue; }
                                if (x == 47) { bX052Y047 = pixelColorStringValue; }
                                if (x == 48) { bX052Y048 = pixelColorStringValue; }
                                if (x == 49) { bX052Y049 = pixelColorStringValue; }
                                if (x == 50) { bX052Y050 = pixelColorStringValue; }
                                if (x == 51) { bX052Y051 = pixelColorStringValue; }
                                if (x == 52) { bX052Y052 = pixelColorStringValue; }
                                if (x == 53) { bX052Y053 = pixelColorStringValue; }
                                if (x == 54) { bX052Y054 = pixelColorStringValue; }
                                if (x == 55) { bX052Y055 = pixelColorStringValue; }
                                if (x == 56) { bX052Y056 = pixelColorStringValue; }
                                if (x == 57) { bX052Y057 = pixelColorStringValue; }
                                if (x == 58) { bX052Y058 = pixelColorStringValue; }
                                if (x == 59) { bX052Y059 = pixelColorStringValue; }
                                if (x == 60) { bX052Y060 = pixelColorStringValue; }
                                if (x == 61) { bX052Y061 = pixelColorStringValue; }
                                if (x == 62) { bX052Y062 = pixelColorStringValue; }
                                if (x == 63) { bX052Y063 = pixelColorStringValue; }

                            }

                            if (y == 53)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX053Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX053Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX053Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX053Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX053Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX053Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX053Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX053Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX053Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX053Y009 = pixelColorStringValue; }
                                if (x == 10) { bX053Y010 = pixelColorStringValue; }
                                if (x == 11) { bX053Y011 = pixelColorStringValue; }
                                if (x == 12) { bX053Y012 = pixelColorStringValue; }
                                if (x == 13) { bX053Y013 = pixelColorStringValue; }
                                if (x == 14) { bX053Y014 = pixelColorStringValue; }
                                if (x == 15) { bX053Y015 = pixelColorStringValue; }
                                if (x == 16) { bX053Y016 = pixelColorStringValue; }
                                if (x == 17) { bX053Y017 = pixelColorStringValue; }
                                if (x == 18) { bX053Y018 = pixelColorStringValue; }
                                if (x == 19) { bX053Y019 = pixelColorStringValue; }
                                if (x == 20) { bX053Y020 = pixelColorStringValue; }
                                if (x == 21) { bX053Y021 = pixelColorStringValue; }
                                if (x == 22) { bX053Y022 = pixelColorStringValue; }
                                if (x == 23) { bX053Y023 = pixelColorStringValue; }
                                if (x == 24) { bX053Y024 = pixelColorStringValue; }
                                if (x == 25) { bX053Y025 = pixelColorStringValue; }
                                if (x == 26) { bX053Y026 = pixelColorStringValue; }
                                if (x == 27) { bX053Y027 = pixelColorStringValue; }
                                if (x == 28) { bX053Y028 = pixelColorStringValue; }
                                if (x == 29) { bX053Y029 = pixelColorStringValue; }
                                if (x == 30) { bX053Y030 = pixelColorStringValue; }
                                if (x == 31) { bX053Y031 = pixelColorStringValue; }
                                if (x == 32) { bX053Y032 = pixelColorStringValue; }
                                if (x == 33) { bX053Y033 = pixelColorStringValue; }
                                if (x == 34) { bX053Y034 = pixelColorStringValue; }
                                if (x == 35) { bX053Y035 = pixelColorStringValue; }
                                if (x == 36) { bX053Y036 = pixelColorStringValue; }
                                if (x == 37) { bX053Y037 = pixelColorStringValue; }
                                if (x == 38) { bX053Y038 = pixelColorStringValue; }
                                if (x == 39) { bX053Y039 = pixelColorStringValue; }
                                if (x == 40) { bX053Y040 = pixelColorStringValue; }
                                if (x == 41) { bX053Y041 = pixelColorStringValue; }
                                if (x == 42) { bX053Y042 = pixelColorStringValue; }
                                if (x == 43) { bX053Y043 = pixelColorStringValue; }
                                if (x == 44) { bX053Y044 = pixelColorStringValue; }
                                if (x == 45) { bX053Y045 = pixelColorStringValue; }
                                if (x == 46) { bX053Y046 = pixelColorStringValue; }
                                if (x == 47) { bX053Y047 = pixelColorStringValue; }
                                if (x == 48) { bX053Y048 = pixelColorStringValue; }
                                if (x == 49) { bX053Y049 = pixelColorStringValue; }
                                if (x == 50) { bX053Y050 = pixelColorStringValue; }
                                if (x == 51) { bX053Y051 = pixelColorStringValue; }
                                if (x == 52) { bX053Y052 = pixelColorStringValue; }
                                if (x == 53) { bX053Y053 = pixelColorStringValue; }
                                if (x == 54) { bX053Y054 = pixelColorStringValue; }
                                if (x == 55) { bX053Y055 = pixelColorStringValue; }
                                if (x == 56) { bX053Y056 = pixelColorStringValue; }
                                if (x == 57) { bX053Y057 = pixelColorStringValue; }
                                if (x == 58) { bX053Y058 = pixelColorStringValue; }
                                if (x == 59) { bX053Y059 = pixelColorStringValue; }
                                if (x == 60) { bX053Y060 = pixelColorStringValue; }
                                if (x == 61) { bX053Y061 = pixelColorStringValue; }
                                if (x == 62) { bX053Y062 = pixelColorStringValue; }
                                if (x == 63) { bX053Y063 = pixelColorStringValue; }

                            }

                            if (y == 54)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX054Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX054Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX054Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX054Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX054Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX054Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX054Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX054Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX054Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX054Y009 = pixelColorStringValue; }
                                if (x == 10) { bX054Y010 = pixelColorStringValue; }
                                if (x == 11) { bX054Y011 = pixelColorStringValue; }
                                if (x == 12) { bX054Y012 = pixelColorStringValue; }
                                if (x == 13) { bX054Y013 = pixelColorStringValue; }
                                if (x == 14) { bX054Y014 = pixelColorStringValue; }
                                if (x == 15) { bX054Y015 = pixelColorStringValue; }
                                if (x == 16) { bX054Y016 = pixelColorStringValue; }
                                if (x == 17) { bX054Y017 = pixelColorStringValue; }
                                if (x == 18) { bX054Y018 = pixelColorStringValue; }
                                if (x == 19) { bX054Y019 = pixelColorStringValue; }
                                if (x == 20) { bX054Y020 = pixelColorStringValue; }
                                if (x == 21) { bX054Y021 = pixelColorStringValue; }
                                if (x == 22) { bX054Y022 = pixelColorStringValue; }
                                if (x == 23) { bX054Y023 = pixelColorStringValue; }
                                if (x == 24) { bX054Y024 = pixelColorStringValue; }
                                if (x == 25) { bX054Y025 = pixelColorStringValue; }
                                if (x == 26) { bX054Y026 = pixelColorStringValue; }
                                if (x == 27) { bX054Y027 = pixelColorStringValue; }
                                if (x == 28) { bX054Y028 = pixelColorStringValue; }
                                if (x == 29) { bX054Y029 = pixelColorStringValue; }
                                if (x == 30) { bX054Y030 = pixelColorStringValue; }
                                if (x == 31) { bX054Y031 = pixelColorStringValue; }
                                if (x == 32) { bX054Y032 = pixelColorStringValue; }
                                if (x == 33) { bX054Y033 = pixelColorStringValue; }
                                if (x == 34) { bX054Y034 = pixelColorStringValue; }
                                if (x == 35) { bX054Y035 = pixelColorStringValue; }
                                if (x == 36) { bX054Y036 = pixelColorStringValue; }
                                if (x == 37) { bX054Y037 = pixelColorStringValue; }
                                if (x == 38) { bX054Y038 = pixelColorStringValue; }
                                if (x == 39) { bX054Y039 = pixelColorStringValue; }
                                if (x == 40) { bX054Y040 = pixelColorStringValue; }
                                if (x == 41) { bX054Y041 = pixelColorStringValue; }
                                if (x == 42) { bX054Y042 = pixelColorStringValue; }
                                if (x == 43) { bX054Y043 = pixelColorStringValue; }
                                if (x == 44) { bX054Y044 = pixelColorStringValue; }
                                if (x == 45) { bX054Y045 = pixelColorStringValue; }
                                if (x == 46) { bX054Y046 = pixelColorStringValue; }
                                if (x == 47) { bX054Y047 = pixelColorStringValue; }
                                if (x == 48) { bX054Y048 = pixelColorStringValue; }
                                if (x == 49) { bX054Y049 = pixelColorStringValue; }
                                if (x == 50) { bX054Y050 = pixelColorStringValue; }
                                if (x == 51) { bX054Y051 = pixelColorStringValue; }
                                if (x == 52) { bX054Y052 = pixelColorStringValue; }
                                if (x == 53) { bX054Y053 = pixelColorStringValue; }
                                if (x == 54) { bX054Y054 = pixelColorStringValue; }
                                if (x == 55) { bX054Y055 = pixelColorStringValue; }
                                if (x == 56) { bX054Y056 = pixelColorStringValue; }
                                if (x == 57) { bX054Y057 = pixelColorStringValue; }
                                if (x == 58) { bX054Y058 = pixelColorStringValue; }
                                if (x == 59) { bX054Y059 = pixelColorStringValue; }
                                if (x == 60) { bX054Y060 = pixelColorStringValue; }
                                if (x == 61) { bX054Y061 = pixelColorStringValue; }
                                if (x == 62) { bX054Y062 = pixelColorStringValue; }
                                if (x == 63) { bX054Y063 = pixelColorStringValue; }

                            }

                            if (y == 55)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX055Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX055Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX055Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX055Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX055Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX055Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX055Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX055Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX055Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX055Y009 = pixelColorStringValue; }
                                if (x == 10) { bX055Y010 = pixelColorStringValue; }
                                if (x == 11) { bX055Y011 = pixelColorStringValue; }
                                if (x == 12) { bX055Y012 = pixelColorStringValue; }
                                if (x == 13) { bX055Y013 = pixelColorStringValue; }
                                if (x == 14) { bX055Y014 = pixelColorStringValue; }
                                if (x == 15) { bX055Y015 = pixelColorStringValue; }
                                if (x == 16) { bX055Y016 = pixelColorStringValue; }
                                if (x == 17) { bX055Y017 = pixelColorStringValue; }
                                if (x == 18) { bX055Y018 = pixelColorStringValue; }
                                if (x == 19) { bX055Y019 = pixelColorStringValue; }
                                if (x == 20) { bX055Y020 = pixelColorStringValue; }
                                if (x == 21) { bX055Y021 = pixelColorStringValue; }
                                if (x == 22) { bX055Y022 = pixelColorStringValue; }
                                if (x == 23) { bX055Y023 = pixelColorStringValue; }
                                if (x == 24) { bX055Y024 = pixelColorStringValue; }
                                if (x == 25) { bX055Y025 = pixelColorStringValue; }
                                if (x == 26) { bX055Y026 = pixelColorStringValue; }
                                if (x == 27) { bX055Y027 = pixelColorStringValue; }
                                if (x == 28) { bX055Y028 = pixelColorStringValue; }
                                if (x == 29) { bX055Y029 = pixelColorStringValue; }
                                if (x == 30) { bX055Y030 = pixelColorStringValue; }
                                if (x == 31) { bX055Y031 = pixelColorStringValue; }
                                if (x == 32) { bX055Y032 = pixelColorStringValue; }
                                if (x == 33) { bX055Y033 = pixelColorStringValue; }
                                if (x == 34) { bX055Y034 = pixelColorStringValue; }
                                if (x == 35) { bX055Y035 = pixelColorStringValue; }
                                if (x == 36) { bX055Y036 = pixelColorStringValue; }
                                if (x == 37) { bX055Y037 = pixelColorStringValue; }
                                if (x == 38) { bX055Y038 = pixelColorStringValue; }
                                if (x == 39) { bX055Y039 = pixelColorStringValue; }
                                if (x == 40) { bX055Y040 = pixelColorStringValue; }
                                if (x == 41) { bX055Y041 = pixelColorStringValue; }
                                if (x == 42) { bX055Y042 = pixelColorStringValue; }
                                if (x == 43) { bX055Y043 = pixelColorStringValue; }
                                if (x == 44) { bX055Y044 = pixelColorStringValue; }
                                if (x == 45) { bX055Y045 = pixelColorStringValue; }
                                if (x == 46) { bX055Y046 = pixelColorStringValue; }
                                if (x == 47) { bX055Y047 = pixelColorStringValue; }
                                if (x == 48) { bX055Y048 = pixelColorStringValue; }
                                if (x == 49) { bX055Y049 = pixelColorStringValue; }
                                if (x == 50) { bX055Y050 = pixelColorStringValue; }
                                if (x == 51) { bX055Y051 = pixelColorStringValue; }
                                if (x == 52) { bX055Y052 = pixelColorStringValue; }
                                if (x == 53) { bX055Y053 = pixelColorStringValue; }
                                if (x == 54) { bX055Y054 = pixelColorStringValue; }
                                if (x == 55) { bX055Y055 = pixelColorStringValue; }
                                if (x == 56) { bX055Y056 = pixelColorStringValue; }
                                if (x == 57) { bX055Y057 = pixelColorStringValue; }
                                if (x == 58) { bX055Y058 = pixelColorStringValue; }
                                if (x == 59) { bX055Y059 = pixelColorStringValue; }
                                if (x == 60) { bX055Y060 = pixelColorStringValue; }
                                if (x == 61) { bX055Y061 = pixelColorStringValue; }
                                if (x == 62) { bX055Y062 = pixelColorStringValue; }
                                if (x == 63) { bX055Y063 = pixelColorStringValue; }

                            }

                            if (y == 56)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX056Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX056Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX056Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX056Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX056Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX056Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX056Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX056Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX056Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX056Y009 = pixelColorStringValue; }
                                if (x == 10) { bX056Y010 = pixelColorStringValue; }
                                if (x == 11) { bX056Y011 = pixelColorStringValue; }
                                if (x == 12) { bX056Y012 = pixelColorStringValue; }
                                if (x == 13) { bX056Y013 = pixelColorStringValue; }
                                if (x == 14) { bX056Y014 = pixelColorStringValue; }
                                if (x == 15) { bX056Y015 = pixelColorStringValue; }
                                if (x == 16) { bX056Y016 = pixelColorStringValue; }
                                if (x == 17) { bX056Y017 = pixelColorStringValue; }
                                if (x == 18) { bX056Y018 = pixelColorStringValue; }
                                if (x == 19) { bX056Y019 = pixelColorStringValue; }
                                if (x == 20) { bX056Y020 = pixelColorStringValue; }
                                if (x == 21) { bX056Y021 = pixelColorStringValue; }
                                if (x == 22) { bX056Y022 = pixelColorStringValue; }
                                if (x == 23) { bX056Y023 = pixelColorStringValue; }
                                if (x == 24) { bX056Y024 = pixelColorStringValue; }
                                if (x == 25) { bX056Y025 = pixelColorStringValue; }
                                if (x == 26) { bX056Y026 = pixelColorStringValue; }
                                if (x == 27) { bX056Y027 = pixelColorStringValue; }
                                if (x == 28) { bX056Y028 = pixelColorStringValue; }
                                if (x == 29) { bX056Y029 = pixelColorStringValue; }
                                if (x == 30) { bX056Y030 = pixelColorStringValue; }
                                if (x == 31) { bX056Y031 = pixelColorStringValue; }
                                if (x == 32) { bX056Y032 = pixelColorStringValue; }
                                if (x == 33) { bX056Y033 = pixelColorStringValue; }
                                if (x == 34) { bX056Y034 = pixelColorStringValue; }
                                if (x == 35) { bX056Y035 = pixelColorStringValue; }
                                if (x == 36) { bX056Y036 = pixelColorStringValue; }
                                if (x == 37) { bX056Y037 = pixelColorStringValue; }
                                if (x == 38) { bX056Y038 = pixelColorStringValue; }
                                if (x == 39) { bX056Y039 = pixelColorStringValue; }
                                if (x == 40) { bX056Y040 = pixelColorStringValue; }
                                if (x == 41) { bX056Y041 = pixelColorStringValue; }
                                if (x == 42) { bX056Y042 = pixelColorStringValue; }
                                if (x == 43) { bX056Y043 = pixelColorStringValue; }
                                if (x == 44) { bX056Y044 = pixelColorStringValue; }
                                if (x == 45) { bX056Y045 = pixelColorStringValue; }
                                if (x == 46) { bX056Y046 = pixelColorStringValue; }
                                if (x == 47) { bX056Y047 = pixelColorStringValue; }
                                if (x == 48) { bX056Y048 = pixelColorStringValue; }
                                if (x == 49) { bX056Y049 = pixelColorStringValue; }
                                if (x == 50) { bX056Y050 = pixelColorStringValue; }
                                if (x == 51) { bX056Y051 = pixelColorStringValue; }
                                if (x == 52) { bX056Y052 = pixelColorStringValue; }
                                if (x == 53) { bX056Y053 = pixelColorStringValue; }
                                if (x == 54) { bX056Y054 = pixelColorStringValue; }
                                if (x == 55) { bX056Y055 = pixelColorStringValue; }
                                if (x == 56) { bX056Y056 = pixelColorStringValue; }
                                if (x == 57) { bX056Y057 = pixelColorStringValue; }
                                if (x == 58) { bX056Y058 = pixelColorStringValue; }
                                if (x == 59) { bX056Y059 = pixelColorStringValue; }
                                if (x == 60) { bX056Y060 = pixelColorStringValue; }
                                if (x == 61) { bX056Y061 = pixelColorStringValue; }
                                if (x == 62) { bX056Y062 = pixelColorStringValue; }
                                if (x == 63) { bX056Y063 = pixelColorStringValue; }

                            }

                            if (y == 57)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX057Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX057Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX057Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX057Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX057Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX057Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX057Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX057Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX057Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX057Y009 = pixelColorStringValue; }
                                if (x == 10) { bX057Y010 = pixelColorStringValue; }
                                if (x == 11) { bX057Y011 = pixelColorStringValue; }
                                if (x == 12) { bX057Y012 = pixelColorStringValue; }
                                if (x == 13) { bX057Y013 = pixelColorStringValue; }
                                if (x == 14) { bX057Y014 = pixelColorStringValue; }
                                if (x == 15) { bX057Y015 = pixelColorStringValue; }
                                if (x == 16) { bX057Y016 = pixelColorStringValue; }
                                if (x == 17) { bX057Y017 = pixelColorStringValue; }
                                if (x == 18) { bX057Y018 = pixelColorStringValue; }
                                if (x == 19) { bX057Y019 = pixelColorStringValue; }
                                if (x == 20) { bX057Y020 = pixelColorStringValue; }
                                if (x == 21) { bX057Y021 = pixelColorStringValue; }
                                if (x == 22) { bX057Y022 = pixelColorStringValue; }
                                if (x == 23) { bX057Y023 = pixelColorStringValue; }
                                if (x == 24) { bX057Y024 = pixelColorStringValue; }
                                if (x == 25) { bX057Y025 = pixelColorStringValue; }
                                if (x == 26) { bX057Y026 = pixelColorStringValue; }
                                if (x == 27) { bX057Y027 = pixelColorStringValue; }
                                if (x == 28) { bX057Y028 = pixelColorStringValue; }
                                if (x == 29) { bX057Y029 = pixelColorStringValue; }
                                if (x == 30) { bX057Y030 = pixelColorStringValue; }
                                if (x == 31) { bX057Y031 = pixelColorStringValue; }
                                if (x == 32) { bX057Y032 = pixelColorStringValue; }
                                if (x == 33) { bX057Y033 = pixelColorStringValue; }
                                if (x == 34) { bX057Y034 = pixelColorStringValue; }
                                if (x == 35) { bX057Y035 = pixelColorStringValue; }
                                if (x == 36) { bX057Y036 = pixelColorStringValue; }
                                if (x == 37) { bX057Y037 = pixelColorStringValue; }
                                if (x == 38) { bX057Y038 = pixelColorStringValue; }
                                if (x == 39) { bX057Y039 = pixelColorStringValue; }
                                if (x == 40) { bX057Y040 = pixelColorStringValue; }
                                if (x == 41) { bX057Y041 = pixelColorStringValue; }
                                if (x == 42) { bX057Y042 = pixelColorStringValue; }
                                if (x == 43) { bX057Y043 = pixelColorStringValue; }
                                if (x == 44) { bX057Y044 = pixelColorStringValue; }
                                if (x == 45) { bX057Y045 = pixelColorStringValue; }
                                if (x == 46) { bX057Y046 = pixelColorStringValue; }
                                if (x == 47) { bX057Y047 = pixelColorStringValue; }
                                if (x == 48) { bX057Y048 = pixelColorStringValue; }
                                if (x == 49) { bX057Y049 = pixelColorStringValue; }
                                if (x == 50) { bX057Y050 = pixelColorStringValue; }
                                if (x == 51) { bX057Y051 = pixelColorStringValue; }
                                if (x == 52) { bX057Y052 = pixelColorStringValue; }
                                if (x == 53) { bX057Y053 = pixelColorStringValue; }
                                if (x == 54) { bX057Y054 = pixelColorStringValue; }
                                if (x == 55) { bX057Y055 = pixelColorStringValue; }
                                if (x == 56) { bX057Y056 = pixelColorStringValue; }
                                if (x == 57) { bX057Y057 = pixelColorStringValue; }
                                if (x == 58) { bX057Y058 = pixelColorStringValue; }
                                if (x == 59) { bX057Y059 = pixelColorStringValue; }
                                if (x == 60) { bX057Y060 = pixelColorStringValue; }
                                if (x == 61) { bX057Y061 = pixelColorStringValue; }
                                if (x == 62) { bX057Y062 = pixelColorStringValue; }
                                if (x == 63) { bX057Y063 = pixelColorStringValue; }

                            }

                            if (y == 58)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX058Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX058Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX058Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX058Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX058Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX058Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX058Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX058Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX058Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX058Y009 = pixelColorStringValue; }
                                if (x == 10) { bX058Y010 = pixelColorStringValue; }
                                if (x == 11) { bX058Y011 = pixelColorStringValue; }
                                if (x == 12) { bX058Y012 = pixelColorStringValue; }
                                if (x == 13) { bX058Y013 = pixelColorStringValue; }
                                if (x == 14) { bX058Y014 = pixelColorStringValue; }
                                if (x == 15) { bX058Y015 = pixelColorStringValue; }
                                if (x == 16) { bX058Y016 = pixelColorStringValue; }
                                if (x == 17) { bX058Y017 = pixelColorStringValue; }
                                if (x == 18) { bX058Y018 = pixelColorStringValue; }
                                if (x == 19) { bX058Y019 = pixelColorStringValue; }
                                if (x == 20) { bX058Y020 = pixelColorStringValue; }
                                if (x == 21) { bX058Y021 = pixelColorStringValue; }
                                if (x == 22) { bX058Y022 = pixelColorStringValue; }
                                if (x == 23) { bX058Y023 = pixelColorStringValue; }
                                if (x == 24) { bX058Y024 = pixelColorStringValue; }
                                if (x == 25) { bX058Y025 = pixelColorStringValue; }
                                if (x == 26) { bX058Y026 = pixelColorStringValue; }
                                if (x == 27) { bX058Y027 = pixelColorStringValue; }
                                if (x == 28) { bX058Y028 = pixelColorStringValue; }
                                if (x == 29) { bX058Y029 = pixelColorStringValue; }
                                if (x == 30) { bX058Y030 = pixelColorStringValue; }
                                if (x == 31) { bX058Y031 = pixelColorStringValue; }
                                if (x == 32) { bX058Y032 = pixelColorStringValue; }
                                if (x == 33) { bX058Y033 = pixelColorStringValue; }
                                if (x == 34) { bX058Y034 = pixelColorStringValue; }
                                if (x == 35) { bX058Y035 = pixelColorStringValue; }
                                if (x == 36) { bX058Y036 = pixelColorStringValue; }
                                if (x == 37) { bX058Y037 = pixelColorStringValue; }
                                if (x == 38) { bX058Y038 = pixelColorStringValue; }
                                if (x == 39) { bX058Y039 = pixelColorStringValue; }
                                if (x == 40) { bX058Y040 = pixelColorStringValue; }
                                if (x == 41) { bX058Y041 = pixelColorStringValue; }
                                if (x == 42) { bX058Y042 = pixelColorStringValue; }
                                if (x == 43) { bX058Y043 = pixelColorStringValue; }
                                if (x == 44) { bX058Y044 = pixelColorStringValue; }
                                if (x == 45) { bX058Y045 = pixelColorStringValue; }
                                if (x == 46) { bX058Y046 = pixelColorStringValue; }
                                if (x == 47) { bX058Y047 = pixelColorStringValue; }
                                if (x == 48) { bX058Y048 = pixelColorStringValue; }
                                if (x == 49) { bX058Y049 = pixelColorStringValue; }
                                if (x == 50) { bX058Y050 = pixelColorStringValue; }
                                if (x == 51) { bX058Y051 = pixelColorStringValue; }
                                if (x == 52) { bX058Y052 = pixelColorStringValue; }
                                if (x == 53) { bX058Y053 = pixelColorStringValue; }
                                if (x == 54) { bX058Y054 = pixelColorStringValue; }
                                if (x == 55) { bX058Y055 = pixelColorStringValue; }
                                if (x == 56) { bX058Y056 = pixelColorStringValue; }
                                if (x == 57) { bX058Y057 = pixelColorStringValue; }
                                if (x == 58) { bX058Y058 = pixelColorStringValue; }
                                if (x == 59) { bX058Y059 = pixelColorStringValue; }
                                if (x == 60) { bX058Y060 = pixelColorStringValue; }
                                if (x == 61) { bX058Y061 = pixelColorStringValue; }
                                if (x == 62) { bX058Y062 = pixelColorStringValue; }
                                if (x == 63) { bX058Y063 = pixelColorStringValue; }

                            }

                            if (y == 59)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX059Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX059Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX059Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX059Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX059Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX059Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX059Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX059Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX059Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX059Y009 = pixelColorStringValue; }
                                if (x == 10) { bX059Y010 = pixelColorStringValue; }
                                if (x == 11) { bX059Y011 = pixelColorStringValue; }
                                if (x == 12) { bX059Y012 = pixelColorStringValue; }
                                if (x == 13) { bX059Y013 = pixelColorStringValue; }
                                if (x == 14) { bX059Y014 = pixelColorStringValue; }
                                if (x == 15) { bX059Y015 = pixelColorStringValue; }
                                if (x == 16) { bX059Y016 = pixelColorStringValue; }
                                if (x == 17) { bX059Y017 = pixelColorStringValue; }
                                if (x == 18) { bX059Y018 = pixelColorStringValue; }
                                if (x == 19) { bX059Y019 = pixelColorStringValue; }
                                if (x == 20) { bX059Y020 = pixelColorStringValue; }
                                if (x == 21) { bX059Y021 = pixelColorStringValue; }
                                if (x == 22) { bX059Y022 = pixelColorStringValue; }
                                if (x == 23) { bX059Y023 = pixelColorStringValue; }
                                if (x == 24) { bX059Y024 = pixelColorStringValue; }
                                if (x == 25) { bX059Y025 = pixelColorStringValue; }
                                if (x == 26) { bX059Y026 = pixelColorStringValue; }
                                if (x == 27) { bX059Y027 = pixelColorStringValue; }
                                if (x == 28) { bX059Y028 = pixelColorStringValue; }
                                if (x == 29) { bX059Y029 = pixelColorStringValue; }
                                if (x == 30) { bX059Y030 = pixelColorStringValue; }
                                if (x == 31) { bX059Y031 = pixelColorStringValue; }
                                if (x == 32) { bX059Y032 = pixelColorStringValue; }
                                if (x == 33) { bX059Y033 = pixelColorStringValue; }
                                if (x == 34) { bX059Y034 = pixelColorStringValue; }
                                if (x == 35) { bX059Y035 = pixelColorStringValue; }
                                if (x == 36) { bX059Y036 = pixelColorStringValue; }
                                if (x == 37) { bX059Y037 = pixelColorStringValue; }
                                if (x == 38) { bX059Y038 = pixelColorStringValue; }
                                if (x == 39) { bX059Y039 = pixelColorStringValue; }
                                if (x == 40) { bX059Y040 = pixelColorStringValue; }
                                if (x == 41) { bX059Y041 = pixelColorStringValue; }
                                if (x == 42) { bX059Y042 = pixelColorStringValue; }
                                if (x == 43) { bX059Y043 = pixelColorStringValue; }
                                if (x == 44) { bX059Y044 = pixelColorStringValue; }
                                if (x == 45) { bX059Y045 = pixelColorStringValue; }
                                if (x == 46) { bX059Y046 = pixelColorStringValue; }
                                if (x == 47) { bX059Y047 = pixelColorStringValue; }
                                if (x == 48) { bX059Y048 = pixelColorStringValue; }
                                if (x == 49) { bX059Y049 = pixelColorStringValue; }
                                if (x == 50) { bX059Y050 = pixelColorStringValue; }
                                if (x == 51) { bX059Y051 = pixelColorStringValue; }
                                if (x == 52) { bX059Y052 = pixelColorStringValue; }
                                if (x == 53) { bX059Y053 = pixelColorStringValue; }
                                if (x == 54) { bX059Y054 = pixelColorStringValue; }
                                if (x == 55) { bX059Y055 = pixelColorStringValue; }
                                if (x == 56) { bX059Y056 = pixelColorStringValue; }
                                if (x == 57) { bX059Y057 = pixelColorStringValue; }
                                if (x == 58) { bX059Y058 = pixelColorStringValue; }
                                if (x == 59) { bX059Y059 = pixelColorStringValue; }
                                if (x == 60) { bX059Y060 = pixelColorStringValue; }
                                if (x == 61) { bX059Y061 = pixelColorStringValue; }
                                if (x == 62) { bX059Y062 = pixelColorStringValue; }
                                if (x == 63) { bX059Y063 = pixelColorStringValue; }

                            }

                            if (y == 60)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX060Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX060Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX060Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX060Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX060Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX060Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX060Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX060Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX060Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX060Y009 = pixelColorStringValue; }
                                if (x == 10) { bX060Y010 = pixelColorStringValue; }
                                if (x == 11) { bX060Y011 = pixelColorStringValue; }
                                if (x == 12) { bX060Y012 = pixelColorStringValue; }
                                if (x == 13) { bX060Y013 = pixelColorStringValue; }
                                if (x == 14) { bX060Y014 = pixelColorStringValue; }
                                if (x == 15) { bX060Y015 = pixelColorStringValue; }
                                if (x == 16) { bX060Y016 = pixelColorStringValue; }
                                if (x == 17) { bX060Y017 = pixelColorStringValue; }
                                if (x == 18) { bX060Y018 = pixelColorStringValue; }
                                if (x == 19) { bX060Y019 = pixelColorStringValue; }
                                if (x == 20) { bX060Y020 = pixelColorStringValue; }
                                if (x == 21) { bX060Y021 = pixelColorStringValue; }
                                if (x == 22) { bX060Y022 = pixelColorStringValue; }
                                if (x == 23) { bX060Y023 = pixelColorStringValue; }
                                if (x == 24) { bX060Y024 = pixelColorStringValue; }
                                if (x == 25) { bX060Y025 = pixelColorStringValue; }
                                if (x == 26) { bX060Y026 = pixelColorStringValue; }
                                if (x == 27) { bX060Y027 = pixelColorStringValue; }
                                if (x == 28) { bX060Y028 = pixelColorStringValue; }
                                if (x == 29) { bX060Y029 = pixelColorStringValue; }
                                if (x == 30) { bX060Y030 = pixelColorStringValue; }
                                if (x == 31) { bX060Y031 = pixelColorStringValue; }
                                if (x == 32) { bX060Y032 = pixelColorStringValue; }
                                if (x == 33) { bX060Y033 = pixelColorStringValue; }
                                if (x == 34) { bX060Y034 = pixelColorStringValue; }
                                if (x == 35) { bX060Y035 = pixelColorStringValue; }
                                if (x == 36) { bX060Y036 = pixelColorStringValue; }
                                if (x == 37) { bX060Y037 = pixelColorStringValue; }
                                if (x == 38) { bX060Y038 = pixelColorStringValue; }
                                if (x == 39) { bX060Y039 = pixelColorStringValue; }
                                if (x == 40) { bX060Y040 = pixelColorStringValue; }
                                if (x == 41) { bX060Y041 = pixelColorStringValue; }
                                if (x == 42) { bX060Y042 = pixelColorStringValue; }
                                if (x == 43) { bX060Y043 = pixelColorStringValue; }
                                if (x == 44) { bX060Y044 = pixelColorStringValue; }
                                if (x == 45) { bX060Y045 = pixelColorStringValue; }
                                if (x == 46) { bX060Y046 = pixelColorStringValue; }
                                if (x == 47) { bX060Y047 = pixelColorStringValue; }
                                if (x == 48) { bX060Y048 = pixelColorStringValue; }
                                if (x == 49) { bX060Y049 = pixelColorStringValue; }
                                if (x == 50) { bX060Y050 = pixelColorStringValue; }
                                if (x == 51) { bX060Y051 = pixelColorStringValue; }
                                if (x == 52) { bX060Y052 = pixelColorStringValue; }
                                if (x == 53) { bX060Y053 = pixelColorStringValue; }
                                if (x == 54) { bX060Y054 = pixelColorStringValue; }
                                if (x == 55) { bX060Y055 = pixelColorStringValue; }
                                if (x == 56) { bX060Y056 = pixelColorStringValue; }
                                if (x == 57) { bX060Y057 = pixelColorStringValue; }
                                if (x == 58) { bX060Y058 = pixelColorStringValue; }
                                if (x == 59) { bX060Y059 = pixelColorStringValue; }
                                if (x == 60) { bX060Y060 = pixelColorStringValue; }
                                if (x == 61) { bX060Y061 = pixelColorStringValue; }
                                if (x == 62) { bX060Y062 = pixelColorStringValue; }
                                if (x == 63) { bX060Y063 = pixelColorStringValue; }

                            }

                            if (y == 61)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX061Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX061Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX061Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX061Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX061Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX061Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX061Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX061Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX061Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX061Y009 = pixelColorStringValue; }
                                if (x == 10) { bX061Y010 = pixelColorStringValue; }
                                if (x == 11) { bX061Y011 = pixelColorStringValue; }
                                if (x == 12) { bX061Y012 = pixelColorStringValue; }
                                if (x == 13) { bX061Y013 = pixelColorStringValue; }
                                if (x == 14) { bX061Y014 = pixelColorStringValue; }
                                if (x == 15) { bX061Y015 = pixelColorStringValue; }
                                if (x == 16) { bX061Y016 = pixelColorStringValue; }
                                if (x == 17) { bX061Y017 = pixelColorStringValue; }
                                if (x == 18) { bX061Y018 = pixelColorStringValue; }
                                if (x == 19) { bX061Y019 = pixelColorStringValue; }
                                if (x == 20) { bX061Y020 = pixelColorStringValue; }
                                if (x == 21) { bX061Y021 = pixelColorStringValue; }
                                if (x == 22) { bX061Y022 = pixelColorStringValue; }
                                if (x == 23) { bX061Y023 = pixelColorStringValue; }
                                if (x == 24) { bX061Y024 = pixelColorStringValue; }
                                if (x == 25) { bX061Y025 = pixelColorStringValue; }
                                if (x == 26) { bX061Y026 = pixelColorStringValue; }
                                if (x == 27) { bX061Y027 = pixelColorStringValue; }
                                if (x == 28) { bX061Y028 = pixelColorStringValue; }
                                if (x == 29) { bX061Y029 = pixelColorStringValue; }
                                if (x == 30) { bX061Y030 = pixelColorStringValue; }
                                if (x == 31) { bX061Y031 = pixelColorStringValue; }
                                if (x == 32) { bX061Y032 = pixelColorStringValue; }
                                if (x == 33) { bX061Y033 = pixelColorStringValue; }
                                if (x == 34) { bX061Y034 = pixelColorStringValue; }
                                if (x == 35) { bX061Y035 = pixelColorStringValue; }
                                if (x == 36) { bX061Y036 = pixelColorStringValue; }
                                if (x == 37) { bX061Y037 = pixelColorStringValue; }
                                if (x == 38) { bX061Y038 = pixelColorStringValue; }
                                if (x == 39) { bX061Y039 = pixelColorStringValue; }
                                if (x == 40) { bX061Y040 = pixelColorStringValue; }
                                if (x == 41) { bX061Y041 = pixelColorStringValue; }
                                if (x == 42) { bX061Y042 = pixelColorStringValue; }
                                if (x == 43) { bX061Y043 = pixelColorStringValue; }
                                if (x == 44) { bX061Y044 = pixelColorStringValue; }
                                if (x == 45) { bX061Y045 = pixelColorStringValue; }
                                if (x == 46) { bX061Y046 = pixelColorStringValue; }
                                if (x == 47) { bX061Y047 = pixelColorStringValue; }
                                if (x == 48) { bX061Y048 = pixelColorStringValue; }
                                if (x == 49) { bX061Y049 = pixelColorStringValue; }
                                if (x == 50) { bX061Y050 = pixelColorStringValue; }
                                if (x == 51) { bX061Y051 = pixelColorStringValue; }
                                if (x == 52) { bX061Y052 = pixelColorStringValue; }
                                if (x == 53) { bX061Y053 = pixelColorStringValue; }
                                if (x == 54) { bX061Y054 = pixelColorStringValue; }
                                if (x == 55) { bX061Y055 = pixelColorStringValue; }
                                if (x == 56) { bX061Y056 = pixelColorStringValue; }
                                if (x == 57) { bX061Y057 = pixelColorStringValue; }
                                if (x == 58) { bX061Y058 = pixelColorStringValue; }
                                if (x == 59) { bX061Y059 = pixelColorStringValue; }
                                if (x == 60) { bX061Y060 = pixelColorStringValue; }
                                if (x == 61) { bX061Y061 = pixelColorStringValue; }
                                if (x == 62) { bX061Y062 = pixelColorStringValue; }
                                if (x == 63) { bX061Y063 = pixelColorStringValue; }

                            }

                            if (y == 62)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX062Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX062Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX062Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX062Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX062Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX062Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX062Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX062Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX062Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX062Y009 = pixelColorStringValue; }
                                if (x == 10) { bX062Y010 = pixelColorStringValue; }
                                if (x == 11) { bX062Y011 = pixelColorStringValue; }
                                if (x == 12) { bX062Y012 = pixelColorStringValue; }
                                if (x == 13) { bX062Y013 = pixelColorStringValue; }
                                if (x == 14) { bX062Y014 = pixelColorStringValue; }
                                if (x == 15) { bX062Y015 = pixelColorStringValue; }
                                if (x == 16) { bX062Y016 = pixelColorStringValue; }
                                if (x == 17) { bX062Y017 = pixelColorStringValue; }
                                if (x == 18) { bX062Y018 = pixelColorStringValue; }
                                if (x == 19) { bX062Y019 = pixelColorStringValue; }
                                if (x == 20) { bX062Y020 = pixelColorStringValue; }
                                if (x == 21) { bX062Y021 = pixelColorStringValue; }
                                if (x == 22) { bX062Y022 = pixelColorStringValue; }
                                if (x == 23) { bX062Y023 = pixelColorStringValue; }
                                if (x == 24) { bX062Y024 = pixelColorStringValue; }
                                if (x == 25) { bX062Y025 = pixelColorStringValue; }
                                if (x == 26) { bX062Y026 = pixelColorStringValue; }
                                if (x == 27) { bX062Y027 = pixelColorStringValue; }
                                if (x == 28) { bX062Y028 = pixelColorStringValue; }
                                if (x == 29) { bX062Y029 = pixelColorStringValue; }
                                if (x == 30) { bX062Y030 = pixelColorStringValue; }
                                if (x == 31) { bX062Y031 = pixelColorStringValue; }
                                if (x == 32) { bX062Y032 = pixelColorStringValue; }
                                if (x == 33) { bX062Y033 = pixelColorStringValue; }
                                if (x == 34) { bX062Y034 = pixelColorStringValue; }
                                if (x == 35) { bX062Y035 = pixelColorStringValue; }
                                if (x == 36) { bX062Y036 = pixelColorStringValue; }
                                if (x == 37) { bX062Y037 = pixelColorStringValue; }
                                if (x == 38) { bX062Y038 = pixelColorStringValue; }
                                if (x == 39) { bX062Y039 = pixelColorStringValue; }
                                if (x == 40) { bX062Y040 = pixelColorStringValue; }
                                if (x == 41) { bX062Y041 = pixelColorStringValue; }
                                if (x == 42) { bX062Y042 = pixelColorStringValue; }
                                if (x == 43) { bX062Y043 = pixelColorStringValue; }
                                if (x == 44) { bX062Y044 = pixelColorStringValue; }
                                if (x == 45) { bX062Y045 = pixelColorStringValue; }
                                if (x == 46) { bX062Y046 = pixelColorStringValue; }
                                if (x == 47) { bX062Y047 = pixelColorStringValue; }
                                if (x == 48) { bX062Y048 = pixelColorStringValue; }
                                if (x == 49) { bX062Y049 = pixelColorStringValue; }
                                if (x == 50) { bX062Y050 = pixelColorStringValue; }
                                if (x == 51) { bX062Y051 = pixelColorStringValue; }
                                if (x == 52) { bX062Y052 = pixelColorStringValue; }
                                if (x == 53) { bX062Y053 = pixelColorStringValue; }
                                if (x == 54) { bX062Y054 = pixelColorStringValue; }
                                if (x == 55) { bX062Y055 = pixelColorStringValue; }
                                if (x == 56) { bX062Y056 = pixelColorStringValue; }
                                if (x == 57) { bX062Y057 = pixelColorStringValue; }
                                if (x == 58) { bX062Y058 = pixelColorStringValue; }
                                if (x == 59) { bX062Y059 = pixelColorStringValue; }
                                if (x == 60) { bX062Y060 = pixelColorStringValue; }
                                if (x == 61) { bX062Y061 = pixelColorStringValue; }
                                if (x == 62) { bX062Y062 = pixelColorStringValue; }
                                if (x == 63) { bX062Y063 = pixelColorStringValue; }

                            }

                            if (y == 63)
                            {
                                Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);

                                if (x == 0)  { bX063Y000 = pixelColorStringValue; }
                                if (x == 1)  { bX063Y001 = pixelColorStringValue; }
                                if (x == 2)  { bX063Y002 = pixelColorStringValue; }
                                if (x == 3)  { bX063Y003 = pixelColorStringValue; }
                                if (x == 4)  { bX063Y004 = pixelColorStringValue; }
                                if (x == 5)  { bX063Y005 = pixelColorStringValue; }
                                if (x == 6)  { bX063Y006 = pixelColorStringValue; }
                                if (x == 7)  { bX063Y007 = pixelColorStringValue; }
                                if (x == 8)  { bX063Y008 = pixelColorStringValue; }
                                if (x == 9)  { bX063Y009 = pixelColorStringValue; }
                                if (x == 10) { bX063Y010 = pixelColorStringValue; }
                                if (x == 11) { bX063Y011 = pixelColorStringValue; }
                                if (x == 12) { bX063Y012 = pixelColorStringValue; }
                                if (x == 13) { bX063Y013 = pixelColorStringValue; }
                                if (x == 14) { bX063Y014 = pixelColorStringValue; }
                                if (x == 15) { bX063Y015 = pixelColorStringValue; }
                                if (x == 16) { bX063Y016 = pixelColorStringValue; }
                                if (x == 17) { bX063Y017 = pixelColorStringValue; }
                                if (x == 18) { bX063Y018 = pixelColorStringValue; }
                                if (x == 19) { bX063Y019 = pixelColorStringValue; }
                                if (x == 20) { bX063Y020 = pixelColorStringValue; }
                                if (x == 21) { bX063Y021 = pixelColorStringValue; }
                                if (x == 22) { bX063Y022 = pixelColorStringValue; }
                                if (x == 23) { bX063Y023 = pixelColorStringValue; }
                                if (x == 24) { bX063Y024 = pixelColorStringValue; }
                                if (x == 25) { bX063Y025 = pixelColorStringValue; }
                                if (x == 26) { bX063Y026 = pixelColorStringValue; }
                                if (x == 27) { bX063Y027 = pixelColorStringValue; }
                                if (x == 28) { bX063Y028 = pixelColorStringValue; }
                                if (x == 29) { bX063Y029 = pixelColorStringValue; }
                                if (x == 30) { bX063Y030 = pixelColorStringValue; }
                                if (x == 31) { bX063Y031 = pixelColorStringValue; }
                                if (x == 32) { bX063Y032 = pixelColorStringValue; }
                                if (x == 33) { bX063Y033 = pixelColorStringValue; }
                                if (x == 34) { bX063Y034 = pixelColorStringValue; }
                                if (x == 35) { bX063Y035 = pixelColorStringValue; }
                                if (x == 36) { bX063Y036 = pixelColorStringValue; }
                                if (x == 37) { bX063Y037 = pixelColorStringValue; }
                                if (x == 38) { bX063Y038 = pixelColorStringValue; }
                                if (x == 39) { bX063Y039 = pixelColorStringValue; }
                                if (x == 40) { bX063Y040 = pixelColorStringValue; }
                                if (x == 41) { bX063Y041 = pixelColorStringValue; }
                                if (x == 42) { bX063Y042 = pixelColorStringValue; }
                                if (x == 43) { bX063Y043 = pixelColorStringValue; }
                                if (x == 44) { bX063Y044 = pixelColorStringValue; }
                                if (x == 45) { bX063Y045 = pixelColorStringValue; }
                                if (x == 46) { bX063Y046 = pixelColorStringValue; }
                                if (x == 47) { bX063Y047 = pixelColorStringValue; }
                                if (x == 48) { bX063Y048 = pixelColorStringValue; }
                                if (x == 49) { bX063Y049 = pixelColorStringValue; }
                                if (x == 50) { bX063Y050 = pixelColorStringValue; }
                                if (x == 51) { bX063Y051 = pixelColorStringValue; }
                                if (x == 52) { bX063Y052 = pixelColorStringValue; }
                                if (x == 53) { bX063Y053 = pixelColorStringValue; }
                                if (x == 54) { bX063Y054 = pixelColorStringValue; }
                                if (x == 55) { bX063Y055 = pixelColorStringValue; }
                                if (x == 56) { bX063Y056 = pixelColorStringValue; }
                                if (x == 57) { bX063Y057 = pixelColorStringValue; }
                                if (x == 58) { bX063Y058 = pixelColorStringValue; }
                                if (x == 59) { bX063Y059 = pixelColorStringValue; }
                                if (x == 60) { bX063Y060 = pixelColorStringValue; }
                                if (x == 61) { bX063Y061 = pixelColorStringValue; }
                                if (x == 62) { bX063Y062 = pixelColorStringValue; }
                                if (x == 63) { bX063Y063 = pixelColorStringValue; }

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
                dta.Rows.Add("cellX000", bX000Y000, bX000Y001, bX000Y002, bX000Y003, bX000Y004, bX000Y005, bX000Y006, bX000Y007, bX000Y008, bX000Y009, bX000Y010, bX000Y011, bX000Y012, bX000Y013, bX000Y014, bX000Y015, bX000Y016, bX000Y017, bX000Y018, bX000Y019, bX000Y020, bX000Y021, bX000Y022, bX000Y023, bX000Y024, bX000Y025, bX000Y026, bX000Y027, bX000Y028, bX000Y029, bX000Y030, bX000Y031, bX000Y032, bX000Y033, bX000Y034, bX000Y035, bX000Y036, bX000Y037, bX000Y038, bX000Y039, bX000Y040, bX000Y041, bX000Y042, bX000Y043, bX000Y044, bX000Y045, bX000Y046, bX000Y047, bX000Y048, bX000Y049, bX000Y050, bX000Y051, bX000Y052, bX000Y053, bX000Y054, bX000Y055, bX000Y056, bX000Y057, bX000Y058, bX000Y059, bX000Y060, bX000Y061, bX000Y062, bX000Y063 );
                dta.Rows.Add("cellX001", bX001Y000, bX001Y001, bX001Y002, bX001Y003, bX001Y004, bX001Y005, bX001Y006, bX001Y007, bX001Y008, bX001Y009, bX001Y010, bX001Y011, bX001Y012, bX001Y013, bX001Y014, bX001Y015, bX001Y016, bX001Y017, bX001Y018, bX001Y019, bX001Y020, bX001Y021, bX001Y022, bX001Y023, bX001Y024, bX001Y025, bX001Y026, bX001Y027, bX001Y028, bX001Y029, bX001Y030, bX001Y031, bX001Y032, bX001Y033, bX001Y034, bX001Y035, bX001Y036, bX001Y037, bX001Y038, bX001Y039, bX001Y040, bX001Y041, bX001Y042, bX001Y043, bX001Y044, bX001Y045, bX001Y046, bX001Y047, bX001Y048, bX001Y049, bX001Y050, bX001Y051, bX001Y052, bX001Y053, bX001Y054, bX001Y055, bX001Y056, bX001Y057, bX001Y058, bX001Y059, bX001Y060, bX001Y061, bX001Y062, bX001Y063);
                dta.Rows.Add("cellX002", bX002Y000, bX002Y001, bX002Y002, bX002Y003, bX002Y004, bX002Y005, bX002Y006, bX002Y007, bX002Y008, bX002Y009, bX002Y010, bX002Y011, bX002Y012, bX002Y013, bX002Y014, bX002Y015, bX002Y016, bX002Y017, bX002Y018, bX002Y019, bX002Y020, bX002Y021, bX002Y022, bX002Y023, bX002Y024, bX002Y025, bX002Y026, bX002Y027, bX002Y028, bX002Y029, bX002Y030, bX002Y031, bX002Y032, bX002Y033, bX002Y034, bX002Y035, bX002Y036, bX002Y037, bX002Y038, bX002Y039, bX002Y040, bX002Y041, bX002Y042, bX002Y043, bX002Y044, bX002Y045, bX002Y046, bX002Y047, bX002Y048, bX002Y049, bX002Y050, bX002Y051, bX002Y052, bX002Y053, bX002Y054, bX002Y055, bX002Y056, bX002Y057, bX002Y058, bX002Y059, bX002Y060, bX002Y061, bX002Y062, bX002Y063);
                dta.Rows.Add("cellX003", bX003Y000, bX003Y001, bX003Y002, bX003Y003, bX003Y004, bX003Y005, bX003Y006, bX003Y007, bX003Y008, bX003Y009, bX003Y010, bX003Y011, bX003Y012, bX003Y013, bX003Y014, bX003Y015, bX003Y016, bX003Y017, bX003Y018, bX003Y019, bX003Y020, bX003Y021, bX003Y022, bX003Y023, bX003Y024, bX003Y025, bX003Y026, bX003Y027, bX003Y028, bX003Y029, bX003Y030, bX003Y031, bX003Y032, bX003Y033, bX003Y034, bX003Y035, bX003Y036, bX003Y037, bX003Y038, bX003Y039, bX003Y040, bX003Y041, bX003Y042, bX003Y043, bX003Y044, bX003Y045, bX003Y046, bX003Y047, bX003Y048, bX003Y049, bX003Y050, bX003Y051, bX003Y052, bX003Y053, bX003Y054, bX003Y055, bX003Y056, bX003Y057, bX003Y058, bX003Y059, bX003Y060, bX003Y061, bX003Y062, bX003Y063);
                dta.Rows.Add("cellX004", bX004Y000, bX004Y001, bX004Y002, bX004Y003, bX004Y004, bX004Y005, bX004Y006, bX004Y007, bX004Y008, bX004Y009, bX004Y010, bX004Y011, bX004Y012, bX004Y013, bX004Y014, bX004Y015, bX004Y016, bX004Y017, bX004Y018, bX004Y019, bX004Y020, bX004Y021, bX004Y022, bX004Y023, bX004Y024, bX004Y025, bX004Y026, bX004Y027, bX004Y028, bX004Y029, bX004Y030, bX004Y031, bX004Y032, bX004Y033, bX004Y034, bX004Y035, bX004Y036, bX004Y037, bX004Y038, bX004Y039, bX004Y040, bX004Y041, bX004Y042, bX004Y043, bX004Y044, bX004Y045, bX004Y046, bX004Y047, bX004Y048, bX004Y049, bX004Y050, bX004Y051, bX004Y052, bX004Y053, bX004Y054, bX004Y055, bX004Y056, bX004Y057, bX004Y058, bX004Y059, bX004Y060, bX004Y061, bX004Y062, bX004Y063);
                dta.Rows.Add("cellX005", bX005Y000, bX005Y001, bX005Y002, bX005Y003, bX005Y004, bX005Y005, bX005Y006, bX005Y007, bX005Y008, bX005Y009, bX005Y010, bX005Y011, bX005Y012, bX005Y013, bX005Y014, bX005Y015, bX005Y016, bX005Y017, bX005Y018, bX005Y019, bX005Y020, bX005Y021, bX005Y022, bX005Y023, bX005Y024, bX005Y025, bX005Y026, bX005Y027, bX005Y028, bX005Y029, bX005Y030, bX005Y031, bX005Y032, bX005Y033, bX005Y034, bX005Y035, bX005Y036, bX005Y037, bX005Y038, bX005Y039, bX005Y040, bX005Y041, bX005Y042, bX005Y043, bX005Y044, bX005Y045, bX005Y046, bX005Y047, bX005Y048, bX005Y049, bX005Y050, bX005Y051, bX005Y052, bX005Y053, bX005Y054, bX005Y055, bX005Y056, bX005Y057, bX005Y058, bX005Y059, bX005Y060, bX005Y061, bX005Y062, bX005Y063);
                dta.Rows.Add("cellX006", bX006Y000, bX006Y001, bX006Y002, bX006Y003, bX006Y004, bX006Y005, bX006Y006, bX006Y007, bX006Y008, bX006Y009, bX006Y010, bX006Y011, bX006Y012, bX006Y013, bX006Y014, bX006Y015, bX006Y016, bX006Y017, bX006Y018, bX006Y019, bX006Y020, bX006Y021, bX006Y022, bX006Y023, bX006Y024, bX006Y025, bX006Y026, bX006Y027, bX006Y028, bX006Y029, bX006Y030, bX006Y031, bX006Y032, bX006Y033, bX006Y034, bX006Y035, bX006Y036, bX006Y037, bX006Y038, bX006Y039, bX006Y040, bX006Y041, bX006Y042, bX006Y043, bX006Y044, bX006Y045, bX006Y046, bX006Y047, bX006Y048, bX006Y049, bX006Y050, bX006Y051, bX006Y052, bX006Y053, bX006Y054, bX006Y055, bX006Y056, bX006Y057, bX006Y058, bX006Y059, bX006Y060, bX006Y061, bX006Y062, bX006Y063);
                dta.Rows.Add("cellX007", bX007Y000, bX007Y001, bX007Y002, bX007Y003, bX007Y004, bX007Y005, bX007Y006, bX007Y007, bX007Y008, bX007Y009, bX007Y010, bX007Y011, bX007Y012, bX007Y013, bX007Y014, bX007Y015, bX007Y016, bX007Y017, bX007Y018, bX007Y019, bX007Y020, bX007Y021, bX007Y022, bX007Y023, bX007Y024, bX007Y025, bX007Y026, bX007Y027, bX007Y028, bX007Y029, bX007Y030, bX007Y031, bX007Y032, bX007Y033, bX007Y034, bX007Y035, bX007Y036, bX007Y037, bX007Y038, bX007Y039, bX007Y040, bX007Y041, bX007Y042, bX007Y043, bX007Y044, bX007Y045, bX007Y046, bX007Y047, bX007Y048, bX007Y049, bX007Y050, bX007Y051, bX007Y052, bX007Y053, bX007Y054, bX007Y055, bX007Y056, bX007Y057, bX007Y058, bX007Y059, bX007Y060, bX007Y061, bX007Y062, bX007Y063);
                dta.Rows.Add("cellX008", bX008Y000, bX008Y001, bX008Y002, bX008Y003, bX008Y004, bX008Y005, bX008Y006, bX008Y007, bX008Y008, bX008Y009, bX008Y010, bX008Y011, bX008Y012, bX008Y013, bX008Y014, bX008Y015, bX008Y016, bX008Y017, bX008Y018, bX008Y019, bX008Y020, bX008Y021, bX008Y022, bX008Y023, bX008Y024, bX008Y025, bX008Y026, bX008Y027, bX008Y028, bX008Y029, bX008Y030, bX008Y031, bX008Y032, bX008Y033, bX008Y034, bX008Y035, bX008Y036, bX008Y037, bX008Y038, bX008Y039, bX008Y040, bX008Y041, bX008Y042, bX008Y043, bX008Y044, bX008Y045, bX008Y046, bX008Y047, bX008Y048, bX008Y049, bX008Y050, bX008Y051, bX008Y052, bX008Y053, bX008Y054, bX008Y055, bX008Y056, bX008Y057, bX008Y058, bX008Y059, bX008Y060, bX008Y061, bX008Y062, bX008Y063);
                dta.Rows.Add("cellX009", bX009Y000, bX009Y001, bX009Y002, bX009Y003, bX009Y004, bX009Y005, bX009Y006, bX009Y007, bX009Y008, bX009Y009, bX009Y010, bX009Y011, bX009Y012, bX009Y013, bX009Y014, bX009Y015, bX009Y016, bX009Y017, bX009Y018, bX009Y019, bX009Y020, bX009Y021, bX009Y022, bX009Y023, bX009Y024, bX009Y025, bX009Y026, bX009Y027, bX009Y028, bX009Y029, bX009Y030, bX009Y031, bX009Y032, bX009Y033, bX009Y034, bX009Y035, bX009Y036, bX009Y037, bX009Y038, bX009Y039, bX009Y040, bX009Y041, bX009Y042, bX009Y043, bX009Y044, bX009Y045, bX009Y046, bX009Y047, bX009Y048, bX009Y049, bX009Y050, bX009Y051, bX009Y052, bX009Y053, bX009Y054, bX009Y055, bX009Y056, bX009Y057, bX009Y058, bX009Y059, bX009Y060, bX009Y061, bX009Y062, bX009Y063);
                dta.Rows.Add("cellX010", bX010Y000, bX010Y001, bX010Y002, bX010Y003, bX010Y004, bX010Y005, bX010Y006, bX010Y007, bX010Y008, bX010Y009, bX010Y010, bX010Y011, bX010Y012, bX010Y013, bX010Y014, bX010Y015, bX010Y016, bX010Y017, bX010Y018, bX010Y019, bX010Y020, bX010Y021, bX010Y022, bX010Y023, bX010Y024, bX010Y025, bX010Y026, bX010Y027, bX010Y028, bX010Y029, bX010Y030, bX010Y031, bX010Y032, bX010Y033, bX010Y034, bX010Y035, bX010Y036, bX010Y037, bX010Y038, bX010Y039, bX010Y040, bX010Y041, bX010Y042, bX010Y043, bX010Y044, bX010Y045, bX010Y046, bX010Y047, bX010Y048, bX010Y049, bX010Y050, bX010Y051, bX010Y052, bX010Y053, bX010Y054, bX010Y055, bX010Y056, bX010Y057, bX010Y058, bX010Y059, bX010Y060, bX010Y061, bX010Y062, bX010Y063);
                dta.Rows.Add("cellX011", bX011Y000, bX011Y001, bX011Y002, bX011Y003, bX011Y004, bX011Y005, bX011Y006, bX011Y007, bX011Y008, bX011Y009, bX011Y010, bX011Y011, bX011Y012, bX011Y013, bX011Y014, bX011Y015, bX011Y016, bX011Y017, bX011Y018, bX011Y019, bX011Y020, bX011Y021, bX011Y022, bX011Y023, bX011Y024, bX011Y025, bX011Y026, bX011Y027, bX011Y028, bX011Y029, bX011Y030, bX011Y031, bX011Y032, bX011Y033, bX011Y034, bX011Y035, bX011Y036, bX011Y037, bX011Y038, bX011Y039, bX011Y040, bX011Y041, bX011Y042, bX011Y043, bX011Y044, bX011Y045, bX011Y046, bX011Y047, bX011Y048, bX011Y049, bX011Y050, bX011Y051, bX011Y052, bX011Y053, bX011Y054, bX011Y055, bX011Y056, bX011Y057, bX011Y058, bX011Y059, bX011Y060, bX011Y061, bX011Y062, bX011Y063);
                dta.Rows.Add("cellX012", bX012Y000, bX012Y001, bX012Y002, bX012Y003, bX012Y004, bX012Y005, bX012Y006, bX012Y007, bX012Y008, bX012Y009, bX012Y010, bX012Y011, bX012Y012, bX012Y013, bX012Y014, bX012Y015, bX012Y016, bX012Y017, bX012Y018, bX012Y019, bX012Y020, bX012Y021, bX012Y022, bX012Y023, bX012Y024, bX012Y025, bX012Y026, bX012Y027, bX012Y028, bX012Y029, bX012Y030, bX012Y031, bX012Y032, bX012Y033, bX012Y034, bX012Y035, bX012Y036, bX012Y037, bX012Y038, bX012Y039, bX012Y040, bX012Y041, bX012Y042, bX012Y043, bX012Y044, bX012Y045, bX012Y046, bX012Y047, bX012Y048, bX012Y049, bX012Y050, bX012Y051, bX012Y052, bX012Y053, bX012Y054, bX012Y055, bX012Y056, bX012Y057, bX012Y058, bX012Y059, bX012Y060, bX012Y061, bX012Y062, bX012Y063);
                dta.Rows.Add("cellX013", bX013Y000, bX013Y001, bX013Y002, bX013Y003, bX013Y004, bX013Y005, bX013Y006, bX013Y007, bX013Y008, bX013Y009, bX013Y010, bX013Y011, bX013Y012, bX013Y013, bX013Y014, bX013Y015, bX013Y016, bX013Y017, bX013Y018, bX013Y019, bX013Y020, bX013Y021, bX013Y022, bX013Y023, bX013Y024, bX013Y025, bX013Y026, bX013Y027, bX013Y028, bX013Y029, bX013Y030, bX013Y031, bX013Y032, bX013Y033, bX013Y034, bX013Y035, bX013Y036, bX013Y037, bX013Y038, bX013Y039, bX013Y040, bX013Y041, bX013Y042, bX013Y043, bX013Y044, bX013Y045, bX013Y046, bX013Y047, bX013Y048, bX013Y049, bX013Y050, bX013Y051, bX013Y052, bX013Y053, bX013Y054, bX013Y055, bX013Y056, bX013Y057, bX013Y058, bX013Y059, bX013Y060, bX013Y061, bX013Y062, bX013Y063);
                dta.Rows.Add("cellX014", bX014Y000, bX014Y001, bX014Y002, bX014Y003, bX014Y004, bX014Y005, bX014Y006, bX014Y007, bX014Y008, bX014Y009, bX014Y010, bX014Y011, bX014Y012, bX014Y013, bX014Y014, bX014Y015, bX014Y016, bX014Y017, bX014Y018, bX014Y019, bX014Y020, bX014Y021, bX014Y022, bX014Y023, bX014Y024, bX014Y025, bX014Y026, bX014Y027, bX014Y028, bX014Y029, bX014Y030, bX014Y031, bX014Y032, bX014Y033, bX014Y034, bX014Y035, bX014Y036, bX014Y037, bX014Y038, bX014Y039, bX014Y040, bX014Y041, bX014Y042, bX014Y043, bX014Y044, bX014Y045, bX014Y046, bX014Y047, bX014Y048, bX014Y049, bX014Y050, bX014Y051, bX014Y052, bX014Y053, bX014Y054, bX014Y055, bX014Y056, bX014Y057, bX014Y058, bX014Y059, bX014Y060, bX014Y061, bX014Y062, bX014Y063);

                dta.Rows.Add("cellX015", bX015Y000, bX015Y001, bX015Y002, bX015Y003, bX015Y004, bX015Y005, bX015Y006, bX015Y007, bX015Y008, bX015Y009, bX015Y010, bX015Y011, bX015Y012, bX015Y013, bX015Y014, bX015Y015, bX015Y016, bX015Y017, bX015Y018, bX015Y019, bX015Y020, bX015Y021, bX015Y022, bX015Y023, bX015Y024, bX015Y025, bX015Y026, bX015Y027, bX015Y028, bX015Y029, bX015Y030, bX015Y031, bX015Y032, bX015Y033, bX015Y034, bX015Y035, bX015Y036, bX015Y037, bX015Y038, bX015Y039, bX015Y040, bX015Y041, bX015Y042, bX015Y043, bX015Y044, bX015Y045, bX015Y046, bX015Y047, bX015Y048, bX015Y049, bX015Y050, bX015Y051, bX015Y052, bX015Y053, bX015Y054, bX015Y055, bX015Y056, bX015Y057, bX015Y058, bX015Y059, bX015Y060, bX015Y061, bX015Y062, bX015Y063);
                dta.Rows.Add("cellX016", bX016Y000, bX016Y001, bX016Y002, bX016Y003, bX016Y004, bX016Y005, bX016Y006, bX016Y007, bX016Y008, bX016Y009, bX016Y010, bX016Y011, bX016Y012, bX016Y013, bX016Y014, bX016Y015, bX016Y016, bX016Y017, bX016Y018, bX016Y019, bX016Y020, bX016Y021, bX016Y022, bX016Y023, bX016Y024, bX016Y025, bX016Y026, bX016Y027, bX016Y028, bX016Y029, bX016Y030, bX016Y031, bX016Y032, bX016Y033, bX016Y034, bX016Y035, bX016Y036, bX016Y037, bX016Y038, bX016Y039, bX016Y040, bX016Y041, bX016Y042, bX016Y043, bX016Y044, bX016Y045, bX016Y046, bX016Y047, bX016Y048, bX016Y049, bX016Y050, bX016Y051, bX016Y052, bX016Y053, bX016Y054, bX016Y055, bX016Y056, bX016Y057, bX016Y058, bX016Y059, bX016Y060, bX016Y061, bX016Y062, bX016Y063);
                dta.Rows.Add("cellX017", bX017Y000, bX017Y001, bX017Y002, bX017Y003, bX017Y004, bX017Y005, bX017Y006, bX017Y007, bX017Y008, bX017Y009, bX017Y010, bX017Y011, bX017Y012, bX017Y013, bX017Y014, bX017Y015, bX017Y016, bX017Y017, bX017Y018, bX017Y019, bX017Y020, bX017Y021, bX017Y022, bX017Y023, bX017Y024, bX017Y025, bX017Y026, bX017Y027, bX017Y028, bX017Y029, bX017Y030, bX017Y031, bX017Y032, bX017Y033, bX017Y034, bX017Y035, bX017Y036, bX017Y037, bX017Y038, bX017Y039, bX017Y040, bX017Y041, bX017Y042, bX017Y043, bX017Y044, bX017Y045, bX017Y046, bX017Y047, bX017Y048, bX017Y049, bX017Y050, bX017Y051, bX017Y052, bX017Y053, bX017Y054, bX017Y055, bX017Y056, bX017Y057, bX017Y058, bX017Y059, bX017Y060, bX017Y061, bX017Y062, bX017Y063);
                dta.Rows.Add("cellX018", bX018Y000, bX018Y001, bX018Y002, bX018Y003, bX018Y004, bX018Y005, bX018Y006, bX018Y007, bX018Y008, bX018Y009, bX018Y010, bX018Y011, bX018Y012, bX018Y013, bX018Y014, bX018Y015, bX018Y016, bX018Y017, bX018Y018, bX018Y019, bX018Y020, bX018Y021, bX018Y022, bX018Y023, bX018Y024, bX018Y025, bX018Y026, bX018Y027, bX018Y028, bX018Y029, bX018Y030, bX018Y031, bX018Y032, bX018Y033, bX018Y034, bX018Y035, bX018Y036, bX018Y037, bX018Y038, bX018Y039, bX018Y040, bX018Y041, bX018Y042, bX018Y043, bX018Y044, bX018Y045, bX018Y046, bX018Y047, bX018Y048, bX018Y049, bX018Y050, bX018Y051, bX018Y052, bX018Y053, bX018Y054, bX018Y055, bX018Y056, bX018Y057, bX018Y058, bX018Y059, bX018Y060, bX018Y061, bX018Y062, bX018Y063);
                dta.Rows.Add("cellX019", bX019Y000, bX019Y001, bX019Y002, bX019Y003, bX019Y004, bX019Y005, bX019Y006, bX019Y007, bX019Y008, bX019Y009, bX019Y010, bX019Y011, bX019Y012, bX019Y013, bX019Y014, bX019Y015, bX019Y016, bX019Y017, bX019Y018, bX019Y019, bX019Y020, bX019Y021, bX019Y022, bX019Y023, bX019Y024, bX019Y025, bX019Y026, bX019Y027, bX019Y028, bX019Y029, bX019Y030, bX019Y031, bX019Y032, bX019Y033, bX019Y034, bX019Y035, bX019Y036, bX019Y037, bX019Y038, bX019Y039, bX019Y040, bX019Y041, bX019Y042, bX019Y043, bX019Y044, bX019Y045, bX019Y046, bX019Y047, bX019Y048, bX019Y049, bX019Y050, bX019Y051, bX019Y052, bX019Y053, bX019Y054, bX019Y055, bX019Y056, bX019Y057, bX019Y058, bX019Y059, bX019Y060, bX019Y061, bX019Y062, bX019Y063);
                dta.Rows.Add("cellX020", bX020Y000, bX020Y001, bX020Y002, bX020Y003, bX020Y004, bX020Y005, bX020Y006, bX020Y007, bX020Y008, bX020Y009, bX020Y010, bX020Y011, bX020Y012, bX020Y013, bX020Y014, bX020Y015, bX020Y016, bX020Y017, bX020Y018, bX020Y019, bX020Y020, bX020Y021, bX020Y022, bX020Y023, bX020Y024, bX020Y025, bX020Y026, bX020Y027, bX020Y028, bX020Y029, bX020Y030, bX020Y031, bX020Y032, bX020Y033, bX020Y034, bX020Y035, bX020Y036, bX020Y037, bX020Y038, bX020Y039, bX020Y040, bX020Y041, bX020Y042, bX020Y043, bX020Y044, bX020Y045, bX020Y046, bX020Y047, bX020Y048, bX020Y049, bX020Y050, bX020Y051, bX020Y052, bX020Y053, bX020Y054, bX020Y055, bX020Y056, bX020Y057, bX020Y058, bX020Y059, bX020Y060, bX020Y061, bX020Y062, bX020Y063);
                dta.Rows.Add("cellX021", bX021Y000, bX021Y001, bX021Y002, bX021Y003, bX021Y004, bX021Y005, bX021Y006, bX021Y007, bX021Y008, bX021Y009, bX021Y010, bX021Y011, bX021Y012, bX021Y013, bX021Y014, bX021Y015, bX021Y016, bX021Y017, bX021Y018, bX021Y019, bX021Y020, bX021Y021, bX021Y022, bX021Y023, bX021Y024, bX021Y025, bX021Y026, bX021Y027, bX021Y028, bX021Y029, bX021Y030, bX021Y031, bX021Y032, bX021Y033, bX021Y034, bX021Y035, bX021Y036, bX021Y037, bX021Y038, bX021Y039, bX021Y040, bX021Y041, bX021Y042, bX021Y043, bX021Y044, bX021Y045, bX021Y046, bX021Y047, bX021Y048, bX021Y049, bX021Y050, bX021Y051, bX021Y052, bX021Y053, bX021Y054, bX021Y055, bX021Y056, bX021Y057, bX021Y058, bX021Y059, bX021Y060, bX021Y061, bX021Y062, bX021Y063);
                dta.Rows.Add("cellX022", bX022Y000, bX022Y001, bX022Y002, bX022Y003, bX022Y004, bX022Y005, bX022Y006, bX022Y007, bX022Y008, bX022Y009, bX022Y010, bX022Y011, bX022Y012, bX022Y013, bX022Y014, bX022Y015, bX022Y016, bX022Y017, bX022Y018, bX022Y019, bX022Y020, bX022Y021, bX022Y022, bX022Y023, bX022Y024, bX022Y025, bX022Y026, bX022Y027, bX022Y028, bX022Y029, bX022Y030, bX022Y031, bX022Y032, bX022Y033, bX022Y034, bX022Y035, bX022Y036, bX022Y037, bX022Y038, bX022Y039, bX022Y040, bX022Y041, bX022Y042, bX022Y043, bX022Y044, bX022Y045, bX022Y046, bX022Y047, bX022Y048, bX022Y049, bX022Y050, bX022Y051, bX022Y052, bX022Y053, bX022Y054, bX022Y055, bX022Y056, bX022Y057, bX022Y058, bX022Y059, bX022Y060, bX022Y061, bX022Y062, bX022Y063);
                dta.Rows.Add("cellX023", bX023Y000, bX023Y001, bX023Y002, bX023Y003, bX023Y004, bX023Y005, bX023Y006, bX023Y007, bX023Y008, bX023Y009, bX023Y010, bX023Y011, bX023Y012, bX023Y013, bX023Y014, bX023Y015, bX023Y016, bX023Y017, bX023Y018, bX023Y019, bX023Y020, bX023Y021, bX023Y022, bX023Y023, bX023Y024, bX023Y025, bX023Y026, bX023Y027, bX023Y028, bX023Y029, bX023Y030, bX023Y031, bX023Y032, bX023Y033, bX023Y034, bX023Y035, bX023Y036, bX023Y037, bX023Y038, bX023Y039, bX023Y040, bX023Y041, bX023Y042, bX023Y043, bX023Y044, bX023Y045, bX023Y046, bX023Y047, bX023Y048, bX023Y049, bX023Y050, bX023Y051, bX023Y052, bX023Y053, bX023Y054, bX023Y055, bX023Y056, bX023Y057, bX023Y058, bX023Y059, bX023Y060, bX023Y061, bX023Y062, bX023Y063);
                dta.Rows.Add("cellX024", bX024Y000, bX024Y001, bX024Y002, bX024Y003, bX024Y004, bX024Y005, bX024Y006, bX024Y007, bX024Y008, bX024Y009, bX024Y010, bX024Y011, bX024Y012, bX024Y013, bX024Y014, bX024Y015, bX024Y016, bX024Y017, bX024Y018, bX024Y019, bX024Y020, bX024Y021, bX024Y022, bX024Y023, bX024Y024, bX024Y025, bX024Y026, bX024Y027, bX024Y028, bX024Y029, bX024Y030, bX024Y031, bX024Y032, bX024Y033, bX024Y034, bX024Y035, bX024Y036, bX024Y037, bX024Y038, bX024Y039, bX024Y040, bX024Y041, bX024Y042, bX024Y043, bX024Y044, bX024Y045, bX024Y046, bX024Y047, bX024Y048, bX024Y049, bX024Y050, bX024Y051, bX024Y052, bX024Y053, bX024Y054, bX024Y055, bX024Y056, bX024Y057, bX024Y058, bX024Y059, bX024Y060, bX024Y061, bX024Y062, bX024Y063);
                dta.Rows.Add("cellX025", bX025Y000, bX025Y001, bX025Y002, bX025Y003, bX025Y004, bX025Y005, bX025Y006, bX025Y007, bX025Y008, bX025Y009, bX025Y010, bX025Y011, bX025Y012, bX025Y013, bX025Y014, bX025Y015, bX025Y016, bX025Y017, bX025Y018, bX025Y019, bX025Y020, bX025Y021, bX025Y022, bX025Y023, bX025Y024, bX025Y025, bX025Y026, bX025Y027, bX025Y028, bX025Y029, bX025Y030, bX025Y031, bX025Y032, bX025Y033, bX025Y034, bX025Y035, bX025Y036, bX025Y037, bX025Y038, bX025Y039, bX025Y040, bX025Y041, bX025Y042, bX025Y043, bX025Y044, bX025Y045, bX025Y046, bX025Y047, bX025Y048, bX025Y049, bX025Y050, bX025Y051, bX025Y052, bX025Y053, bX025Y054, bX025Y055, bX025Y056, bX025Y057, bX025Y058, bX025Y059, bX025Y060, bX025Y061, bX025Y062, bX025Y063);
                dta.Rows.Add("cellX026", bX026Y000, bX026Y001, bX026Y002, bX026Y003, bX026Y004, bX026Y005, bX026Y006, bX026Y007, bX026Y008, bX026Y009, bX026Y010, bX026Y011, bX026Y012, bX026Y013, bX026Y014, bX026Y015, bX026Y016, bX026Y017, bX026Y018, bX026Y019, bX026Y020, bX026Y021, bX026Y022, bX026Y023, bX026Y024, bX026Y025, bX026Y026, bX026Y027, bX026Y028, bX026Y029, bX026Y030, bX026Y031, bX026Y032, bX026Y033, bX026Y034, bX026Y035, bX026Y036, bX026Y037, bX026Y038, bX026Y039, bX026Y040, bX026Y041, bX026Y042, bX026Y043, bX026Y044, bX026Y045, bX026Y046, bX026Y047, bX026Y048, bX026Y049, bX026Y050, bX026Y051, bX026Y052, bX026Y053, bX026Y054, bX026Y055, bX026Y056, bX026Y057, bX026Y058, bX026Y059, bX026Y060, bX026Y061, bX026Y062, bX026Y063);
                dta.Rows.Add("cellX027", bX027Y000, bX027Y001, bX027Y002, bX027Y003, bX027Y004, bX027Y005, bX027Y006, bX027Y007, bX027Y008, bX027Y009, bX027Y010, bX027Y011, bX027Y012, bX027Y013, bX027Y014, bX027Y015, bX027Y016, bX027Y017, bX027Y018, bX027Y019, bX027Y020, bX027Y021, bX027Y022, bX027Y023, bX027Y024, bX027Y025, bX027Y026, bX027Y027, bX027Y028, bX027Y029, bX027Y030, bX027Y031, bX027Y032, bX027Y033, bX027Y034, bX027Y035, bX027Y036, bX027Y037, bX027Y038, bX027Y039, bX027Y040, bX027Y041, bX027Y042, bX027Y043, bX027Y044, bX027Y045, bX027Y046, bX027Y047, bX027Y048, bX027Y049, bX027Y050, bX027Y051, bX027Y052, bX027Y053, bX027Y054, bX027Y055, bX027Y056, bX027Y057, bX027Y058, bX027Y059, bX027Y060, bX027Y061, bX027Y062, bX027Y063);
                dta.Rows.Add("cellX028", bX028Y000, bX028Y001, bX028Y002, bX028Y003, bX028Y004, bX028Y005, bX028Y006, bX028Y007, bX028Y008, bX028Y009, bX028Y010, bX028Y011, bX028Y012, bX028Y013, bX028Y014, bX028Y015, bX028Y016, bX028Y017, bX028Y018, bX028Y019, bX028Y020, bX028Y021, bX028Y022, bX028Y023, bX028Y024, bX028Y025, bX028Y026, bX028Y027, bX028Y028, bX028Y029, bX028Y030, bX028Y031, bX028Y032, bX028Y033, bX028Y034, bX028Y035, bX028Y036, bX028Y037, bX028Y038, bX028Y039, bX028Y040, bX028Y041, bX028Y042, bX028Y043, bX028Y044, bX028Y045, bX028Y046, bX028Y047, bX028Y048, bX028Y049, bX028Y050, bX028Y051, bX028Y052, bX028Y053, bX028Y054, bX028Y055, bX028Y056, bX028Y057, bX028Y058, bX028Y059, bX028Y060, bX028Y061, bX028Y062, bX028Y063);
                dta.Rows.Add("cellX029", bX029Y000, bX029Y001, bX029Y002, bX029Y003, bX029Y004, bX029Y005, bX029Y006, bX029Y007, bX029Y008, bX029Y009, bX029Y010, bX029Y011, bX029Y012, bX029Y013, bX029Y014, bX029Y015, bX029Y016, bX029Y017, bX029Y018, bX029Y019, bX029Y020, bX029Y021, bX029Y022, bX029Y023, bX029Y024, bX029Y025, bX029Y026, bX029Y027, bX029Y028, bX029Y029, bX029Y030, bX029Y031, bX029Y032, bX029Y033, bX029Y034, bX029Y035, bX029Y036, bX029Y037, bX029Y038, bX029Y039, bX029Y040, bX029Y041, bX029Y042, bX029Y043, bX029Y044, bX029Y045, bX029Y046, bX029Y047, bX029Y048, bX029Y049, bX029Y050, bX029Y051, bX029Y052, bX029Y053, bX029Y054, bX029Y055, bX029Y056, bX029Y057, bX029Y058, bX029Y059, bX029Y060, bX029Y061, bX029Y062, bX029Y063);
                dta.Rows.Add("cellX030", bX030Y000, bX030Y001, bX030Y002, bX030Y003, bX030Y004, bX030Y005, bX030Y006, bX030Y007, bX030Y008, bX030Y009, bX030Y010, bX030Y011, bX030Y012, bX030Y013, bX030Y014, bX030Y015, bX030Y016, bX030Y017, bX030Y018, bX030Y019, bX030Y020, bX030Y021, bX030Y022, bX030Y023, bX030Y024, bX030Y025, bX030Y026, bX030Y027, bX030Y028, bX030Y029, bX030Y030, bX030Y031, bX030Y032, bX030Y033, bX030Y034, bX030Y035, bX030Y036, bX030Y037, bX030Y038, bX030Y039, bX030Y040, bX030Y041, bX030Y042, bX030Y043, bX030Y044, bX030Y045, bX030Y046, bX030Y047, bX030Y048, bX030Y049, bX030Y050, bX030Y051, bX030Y052, bX030Y053, bX030Y054, bX030Y055, bX030Y056, bX030Y057, bX030Y058, bX030Y059, bX030Y060, bX030Y061, bX030Y062, bX030Y063);
                dta.Rows.Add("cellX031", bX031Y000, bX031Y001, bX031Y002, bX031Y003, bX031Y004, bX031Y005, bX031Y006, bX031Y007, bX031Y008, bX031Y009, bX031Y010, bX031Y011, bX031Y012, bX031Y013, bX031Y014, bX031Y015, bX031Y016, bX031Y017, bX031Y018, bX031Y019, bX031Y020, bX031Y021, bX031Y022, bX031Y023, bX031Y024, bX031Y025, bX031Y026, bX031Y027, bX031Y028, bX031Y029, bX031Y030, bX031Y031, bX031Y032, bX031Y033, bX031Y034, bX031Y035, bX031Y036, bX031Y037, bX031Y038, bX031Y039, bX031Y040, bX031Y041, bX031Y042, bX031Y043, bX031Y044, bX031Y045, bX031Y046, bX031Y047, bX031Y048, bX031Y049, bX031Y050, bX031Y051, bX031Y052, bX031Y053, bX031Y054, bX031Y055, bX031Y056, bX031Y057, bX031Y058, bX031Y059, bX031Y060, bX031Y061, bX031Y062, bX031Y063);
                dta.Rows.Add("cellX032", bX032Y000, bX032Y001, bX032Y002, bX032Y003, bX032Y004, bX032Y005, bX032Y006, bX032Y007, bX032Y008, bX032Y009, bX032Y010, bX032Y011, bX032Y012, bX032Y013, bX032Y014, bX032Y015, bX032Y016, bX032Y017, bX032Y018, bX032Y019, bX032Y020, bX032Y021, bX032Y022, bX032Y023, bX032Y024, bX032Y025, bX032Y026, bX032Y027, bX032Y028, bX032Y029, bX032Y030, bX032Y031, bX032Y032, bX032Y033, bX032Y034, bX032Y035, bX032Y036, bX032Y037, bX032Y038, bX032Y039, bX032Y040, bX032Y041, bX032Y042, bX032Y043, bX032Y044, bX032Y045, bX032Y046, bX032Y047, bX032Y048, bX032Y049, bX032Y050, bX032Y051, bX032Y052, bX032Y053, bX032Y054, bX032Y055, bX032Y056, bX032Y057, bX032Y058, bX032Y059, bX032Y060, bX032Y061, bX032Y062, bX032Y063);
                dta.Rows.Add("cellX033", bX033Y000, bX033Y001, bX033Y002, bX033Y003, bX033Y004, bX033Y005, bX033Y006, bX033Y007, bX033Y008, bX033Y009, bX033Y010, bX033Y011, bX033Y012, bX033Y013, bX033Y014, bX033Y015, bX033Y016, bX033Y017, bX033Y018, bX033Y019, bX033Y020, bX033Y021, bX033Y022, bX033Y023, bX033Y024, bX033Y025, bX033Y026, bX033Y027, bX033Y028, bX033Y029, bX033Y030, bX033Y031, bX033Y032, bX033Y033, bX033Y034, bX033Y035, bX033Y036, bX033Y037, bX033Y038, bX033Y039, bX033Y040, bX033Y041, bX033Y042, bX033Y043, bX033Y044, bX033Y045, bX033Y046, bX033Y047, bX033Y048, bX033Y049, bX033Y050, bX033Y051, bX033Y052, bX033Y053, bX033Y054, bX033Y055, bX033Y056, bX033Y057, bX033Y058, bX033Y059, bX033Y060, bX033Y061, bX033Y062, bX033Y063);
                dta.Rows.Add("cellX034", bX034Y000, bX034Y001, bX034Y002, bX034Y003, bX034Y004, bX034Y005, bX034Y006, bX034Y007, bX034Y008, bX034Y009, bX034Y010, bX034Y011, bX034Y012, bX034Y013, bX034Y014, bX034Y015, bX034Y016, bX034Y017, bX034Y018, bX034Y019, bX034Y020, bX034Y021, bX034Y022, bX034Y023, bX034Y024, bX034Y025, bX034Y026, bX034Y027, bX034Y028, bX034Y029, bX034Y030, bX034Y031, bX034Y032, bX034Y033, bX034Y034, bX034Y035, bX034Y036, bX034Y037, bX034Y038, bX034Y039, bX034Y040, bX034Y041, bX034Y042, bX034Y043, bX034Y044, bX034Y045, bX034Y046, bX034Y047, bX034Y048, bX034Y049, bX034Y050, bX034Y051, bX034Y052, bX034Y053, bX034Y054, bX034Y055, bX034Y056, bX034Y057, bX034Y058, bX034Y059, bX034Y060, bX034Y061, bX034Y062, bX034Y063);
                dta.Rows.Add("cellX035", bX035Y000, bX035Y001, bX035Y002, bX035Y003, bX035Y004, bX035Y005, bX035Y006, bX035Y007, bX035Y008, bX035Y009, bX035Y010, bX035Y011, bX035Y012, bX035Y013, bX035Y014, bX035Y015, bX035Y016, bX035Y017, bX035Y018, bX035Y019, bX035Y020, bX035Y021, bX035Y022, bX035Y023, bX035Y024, bX035Y025, bX035Y026, bX035Y027, bX035Y028, bX035Y029, bX035Y030, bX035Y031, bX035Y032, bX035Y033, bX035Y034, bX035Y035, bX035Y036, bX035Y037, bX035Y038, bX035Y039, bX035Y040, bX035Y041, bX035Y042, bX035Y043, bX035Y044, bX035Y045, bX035Y046, bX035Y047, bX035Y048, bX035Y049, bX035Y050, bX035Y051, bX035Y052, bX035Y053, bX035Y054, bX035Y055, bX035Y056, bX035Y057, bX035Y058, bX035Y059, bX035Y060, bX035Y061, bX035Y062, bX035Y063);
                dta.Rows.Add("cellX036", bX036Y000, bX036Y001, bX036Y002, bX036Y003, bX036Y004, bX036Y005, bX036Y006, bX036Y007, bX036Y008, bX036Y009, bX036Y010, bX036Y011, bX036Y012, bX036Y013, bX036Y014, bX036Y015, bX036Y016, bX036Y017, bX036Y018, bX036Y019, bX036Y020, bX036Y021, bX036Y022, bX036Y023, bX036Y024, bX036Y025, bX036Y026, bX036Y027, bX036Y028, bX036Y029, bX036Y030, bX036Y031, bX036Y032, bX036Y033, bX036Y034, bX036Y035, bX036Y036, bX036Y037, bX036Y038, bX036Y039, bX036Y040, bX036Y041, bX036Y042, bX036Y043, bX036Y044, bX036Y045, bX036Y046, bX036Y047, bX036Y048, bX036Y049, bX036Y050, bX036Y051, bX036Y052, bX036Y053, bX036Y054, bX036Y055, bX036Y056, bX036Y057, bX036Y058, bX036Y059, bX036Y060, bX036Y061, bX036Y062, bX036Y063);
                dta.Rows.Add("cellX037", bX037Y000, bX037Y001, bX037Y002, bX037Y003, bX037Y004, bX037Y005, bX037Y006, bX037Y007, bX037Y008, bX037Y009, bX037Y010, bX037Y011, bX037Y012, bX037Y013, bX037Y014, bX037Y015, bX037Y016, bX037Y017, bX037Y018, bX037Y019, bX037Y020, bX037Y021, bX037Y022, bX037Y023, bX037Y024, bX037Y025, bX037Y026, bX037Y027, bX037Y028, bX037Y029, bX037Y030, bX037Y031, bX037Y032, bX037Y033, bX037Y034, bX037Y035, bX037Y036, bX037Y037, bX037Y038, bX037Y039, bX037Y040, bX037Y041, bX037Y042, bX037Y043, bX037Y044, bX037Y045, bX037Y046, bX037Y047, bX037Y048, bX037Y049, bX037Y050, bX037Y051, bX037Y052, bX037Y053, bX037Y054, bX037Y055, bX037Y056, bX037Y057, bX037Y058, bX037Y059, bX037Y060, bX037Y061, bX037Y062, bX037Y063);
                dta.Rows.Add("cellX038", bX038Y000, bX038Y001, bX038Y002, bX038Y003, bX038Y004, bX038Y005, bX038Y006, bX038Y007, bX038Y008, bX038Y009, bX038Y010, bX038Y011, bX038Y012, bX038Y013, bX038Y014, bX038Y015, bX038Y016, bX038Y017, bX038Y018, bX038Y019, bX038Y020, bX038Y021, bX038Y022, bX038Y023, bX038Y024, bX038Y025, bX038Y026, bX038Y027, bX038Y028, bX038Y029, bX038Y030, bX038Y031, bX038Y032, bX038Y033, bX038Y034, bX038Y035, bX038Y036, bX038Y037, bX038Y038, bX038Y039, bX038Y040, bX038Y041, bX038Y042, bX038Y043, bX038Y044, bX038Y045, bX038Y046, bX038Y047, bX038Y048, bX038Y049, bX038Y050, bX038Y051, bX038Y052, bX038Y053, bX038Y054, bX038Y055, bX038Y056, bX038Y057, bX038Y058, bX038Y059, bX038Y060, bX038Y061, bX038Y062, bX038Y063);
                dta.Rows.Add("cellX039", bX039Y000, bX039Y001, bX039Y002, bX039Y003, bX039Y004, bX039Y005, bX039Y006, bX039Y007, bX039Y008, bX039Y009, bX039Y010, bX039Y011, bX039Y012, bX039Y013, bX039Y014, bX039Y015, bX039Y016, bX039Y017, bX039Y018, bX039Y019, bX039Y020, bX039Y021, bX039Y022, bX039Y023, bX039Y024, bX039Y025, bX039Y026, bX039Y027, bX039Y028, bX039Y029, bX039Y030, bX039Y031, bX039Y032, bX039Y033, bX039Y034, bX039Y035, bX039Y036, bX039Y037, bX039Y038, bX039Y039, bX039Y040, bX039Y041, bX039Y042, bX039Y043, bX039Y044, bX039Y045, bX039Y046, bX039Y047, bX039Y048, bX039Y049, bX039Y050, bX039Y051, bX039Y052, bX039Y053, bX039Y054, bX039Y055, bX039Y056, bX039Y057, bX039Y058, bX039Y059, bX039Y060, bX039Y061, bX039Y062, bX039Y063);
                dta.Rows.Add("cellX040", bX040Y000, bX040Y001, bX040Y002, bX040Y003, bX040Y004, bX040Y005, bX040Y006, bX040Y007, bX040Y008, bX040Y009, bX040Y010, bX040Y011, bX040Y012, bX040Y013, bX040Y014, bX040Y015, bX040Y016, bX040Y017, bX040Y018, bX040Y019, bX040Y020, bX040Y021, bX040Y022, bX040Y023, bX040Y024, bX040Y025, bX040Y026, bX040Y027, bX040Y028, bX040Y029, bX040Y030, bX040Y031, bX040Y032, bX040Y033, bX040Y034, bX040Y035, bX040Y036, bX040Y037, bX040Y038, bX040Y039, bX040Y040, bX040Y041, bX040Y042, bX040Y043, bX040Y044, bX040Y045, bX040Y046, bX040Y047, bX040Y048, bX040Y049, bX040Y050, bX040Y051, bX040Y052, bX040Y053, bX040Y054, bX040Y055, bX040Y056, bX040Y057, bX040Y058, bX040Y059, bX040Y060, bX040Y061, bX040Y062, bX040Y063);
                dta.Rows.Add("cellX041", bX041Y000, bX041Y001, bX041Y002, bX041Y003, bX041Y004, bX041Y005, bX041Y006, bX041Y007, bX041Y008, bX041Y009, bX041Y010, bX041Y011, bX041Y012, bX041Y013, bX041Y014, bX041Y015, bX041Y016, bX041Y017, bX041Y018, bX041Y019, bX041Y020, bX041Y021, bX041Y022, bX041Y023, bX041Y024, bX041Y025, bX041Y026, bX041Y027, bX041Y028, bX041Y029, bX041Y030, bX041Y031, bX041Y032, bX041Y033, bX041Y034, bX041Y035, bX041Y036, bX041Y037, bX041Y038, bX041Y039, bX041Y040, bX041Y041, bX041Y042, bX041Y043, bX041Y044, bX041Y045, bX041Y046, bX041Y047, bX041Y048, bX041Y049, bX041Y050, bX041Y051, bX041Y052, bX041Y053, bX041Y054, bX041Y055, bX041Y056, bX041Y057, bX041Y058, bX041Y059, bX041Y060, bX041Y061, bX041Y062, bX041Y063);
                dta.Rows.Add("cellX042", bX042Y000, bX042Y001, bX042Y002, bX042Y003, bX042Y004, bX042Y005, bX042Y006, bX042Y007, bX042Y008, bX042Y009, bX042Y010, bX042Y011, bX042Y012, bX042Y013, bX042Y014, bX042Y015, bX042Y016, bX042Y017, bX042Y018, bX042Y019, bX042Y020, bX042Y021, bX042Y022, bX042Y023, bX042Y024, bX042Y025, bX042Y026, bX042Y027, bX042Y028, bX042Y029, bX042Y030, bX042Y031, bX042Y032, bX042Y033, bX042Y034, bX042Y035, bX042Y036, bX042Y037, bX042Y038, bX042Y039, bX042Y040, bX042Y041, bX042Y042, bX042Y043, bX042Y044, bX042Y045, bX042Y046, bX042Y047, bX042Y048, bX042Y049, bX042Y050, bX042Y051, bX042Y052, bX042Y053, bX042Y054, bX042Y055, bX042Y056, bX042Y057, bX042Y058, bX042Y059, bX042Y060, bX042Y061, bX042Y062, bX042Y063);

                dta.Rows.Add("cellX043", bX043Y000, bX043Y001, bX043Y002, bX043Y003, bX043Y004, bX043Y005, bX043Y006, bX043Y007, bX043Y008, bX043Y009, bX043Y010, bX043Y011, bX043Y012, bX043Y013, bX043Y014, bX043Y015, bX043Y016, bX043Y017, bX043Y018, bX043Y019, bX043Y020, bX043Y021, bX043Y022, bX043Y023, bX043Y024, bX043Y025, bX043Y026, bX043Y027, bX043Y028, bX043Y029, bX043Y030, bX043Y031, bX043Y032, bX043Y033, bX043Y034, bX043Y035, bX043Y036, bX043Y037, bX043Y038, bX043Y039, bX043Y040, bX043Y041, bX043Y042, bX043Y043, bX043Y044, bX043Y045, bX043Y046, bX043Y047, bX043Y048, bX043Y049, bX043Y050, bX043Y051, bX043Y052, bX043Y053, bX043Y054, bX043Y055, bX043Y056, bX043Y057, bX043Y058, bX043Y059, bX043Y060, bX043Y061, bX043Y062, bX043Y063);
                dta.Rows.Add("cellX044", bX044Y000, bX044Y001, bX044Y002, bX044Y003, bX044Y004, bX044Y005, bX044Y006, bX044Y007, bX044Y008, bX044Y009, bX044Y010, bX044Y011, bX044Y012, bX044Y013, bX044Y014, bX044Y015, bX044Y016, bX044Y017, bX044Y018, bX044Y019, bX044Y020, bX044Y021, bX044Y022, bX044Y023, bX044Y024, bX044Y025, bX044Y026, bX044Y027, bX044Y028, bX044Y029, bX044Y030, bX044Y031, bX044Y032, bX044Y033, bX044Y034, bX044Y035, bX044Y036, bX044Y037, bX044Y038, bX044Y039, bX044Y040, bX044Y041, bX044Y042, bX044Y043, bX044Y044, bX044Y045, bX044Y046, bX044Y047, bX044Y048, bX044Y049, bX044Y050, bX044Y051, bX044Y052, bX044Y053, bX044Y054, bX044Y055, bX044Y056, bX044Y057, bX044Y058, bX044Y059, bX044Y060, bX044Y061, bX044Y062, bX044Y063);
                dta.Rows.Add("cellX045", bX045Y000, bX045Y001, bX045Y002, bX045Y003, bX045Y004, bX045Y005, bX045Y006, bX045Y007, bX045Y008, bX045Y009, bX045Y010, bX045Y011, bX045Y012, bX045Y013, bX045Y014, bX045Y015, bX045Y016, bX045Y017, bX045Y018, bX045Y019, bX045Y020, bX045Y021, bX045Y022, bX045Y023, bX045Y024, bX045Y025, bX045Y026, bX045Y027, bX045Y028, bX045Y029, bX045Y030, bX045Y031, bX045Y032, bX045Y033, bX045Y034, bX045Y035, bX045Y036, bX045Y037, bX045Y038, bX045Y039, bX045Y040, bX045Y041, bX045Y042, bX045Y043, bX045Y044, bX045Y045, bX045Y046, bX045Y047, bX045Y048, bX045Y049, bX045Y050, bX045Y051, bX045Y052, bX045Y053, bX045Y054, bX045Y055, bX045Y056, bX045Y057, bX045Y058, bX045Y059, bX045Y060, bX045Y061, bX045Y062, bX045Y063);
                dta.Rows.Add("cellX046", bX046Y000, bX046Y001, bX046Y002, bX046Y003, bX046Y004, bX046Y005, bX046Y006, bX046Y007, bX046Y008, bX046Y009, bX046Y010, bX046Y011, bX046Y012, bX046Y013, bX046Y014, bX046Y015, bX046Y016, bX046Y017, bX046Y018, bX046Y019, bX046Y020, bX046Y021, bX046Y022, bX046Y023, bX046Y024, bX046Y025, bX046Y026, bX046Y027, bX046Y028, bX046Y029, bX046Y030, bX046Y031, bX046Y032, bX046Y033, bX046Y034, bX046Y035, bX046Y036, bX046Y037, bX046Y038, bX046Y039, bX046Y040, bX046Y041, bX046Y042, bX046Y043, bX046Y044, bX046Y045, bX046Y046, bX046Y047, bX046Y048, bX046Y049, bX046Y050, bX046Y051, bX046Y052, bX046Y053, bX046Y054, bX046Y055, bX046Y056, bX046Y057, bX046Y058, bX046Y059, bX046Y060, bX046Y061, bX046Y062, bX046Y063);
                dta.Rows.Add("cellX047", bX047Y000, bX047Y001, bX047Y002, bX047Y003, bX047Y004, bX047Y005, bX047Y006, bX047Y007, bX047Y008, bX047Y009, bX047Y010, bX047Y011, bX047Y012, bX047Y013, bX047Y014, bX047Y015, bX047Y016, bX047Y017, bX047Y018, bX047Y019, bX047Y020, bX047Y021, bX047Y022, bX047Y023, bX047Y024, bX047Y025, bX047Y026, bX047Y027, bX047Y028, bX047Y029, bX047Y030, bX047Y031, bX047Y032, bX047Y033, bX047Y034, bX047Y035, bX047Y036, bX047Y037, bX047Y038, bX047Y039, bX047Y040, bX047Y041, bX047Y042, bX047Y043, bX047Y044, bX047Y045, bX047Y046, bX047Y047, bX047Y048, bX047Y049, bX047Y050, bX047Y051, bX047Y052, bX047Y053, bX047Y054, bX047Y055, bX047Y056, bX047Y057, bX047Y058, bX047Y059, bX047Y060, bX047Y061, bX047Y062, bX047Y063);
                dta.Rows.Add("cellX048", bX048Y000, bX048Y001, bX048Y002, bX048Y003, bX048Y004, bX048Y005, bX048Y006, bX048Y007, bX048Y008, bX048Y009, bX048Y010, bX048Y011, bX048Y012, bX048Y013, bX048Y014, bX048Y015, bX048Y016, bX048Y017, bX048Y018, bX048Y019, bX048Y020, bX048Y021, bX048Y022, bX048Y023, bX048Y024, bX048Y025, bX048Y026, bX048Y027, bX048Y028, bX048Y029, bX048Y030, bX048Y031, bX048Y032, bX048Y033, bX048Y034, bX048Y035, bX048Y036, bX048Y037, bX048Y038, bX048Y039, bX048Y040, bX048Y041, bX048Y042, bX048Y043, bX048Y044, bX048Y045, bX048Y046, bX048Y047, bX048Y048, bX048Y049, bX048Y050, bX048Y051, bX048Y052, bX048Y053, bX048Y054, bX048Y055, bX048Y056, bX048Y057, bX048Y058, bX048Y059, bX048Y060, bX048Y061, bX048Y062, bX048Y063);
                dta.Rows.Add("cellX049", bX049Y000, bX049Y001, bX049Y002, bX049Y003, bX049Y004, bX049Y005, bX049Y006, bX049Y007, bX049Y008, bX049Y009, bX049Y010, bX049Y011, bX049Y012, bX049Y013, bX049Y014, bX049Y015, bX049Y016, bX049Y017, bX049Y018, bX049Y019, bX049Y020, bX049Y021, bX049Y022, bX049Y023, bX049Y024, bX049Y025, bX049Y026, bX049Y027, bX049Y028, bX049Y029, bX049Y030, bX049Y031, bX049Y032, bX049Y033, bX049Y034, bX049Y035, bX049Y036, bX049Y037, bX049Y038, bX049Y039, bX049Y040, bX049Y041, bX049Y042, bX049Y043, bX049Y044, bX049Y045, bX049Y046, bX049Y047, bX049Y048, bX049Y049, bX049Y050, bX049Y051, bX049Y052, bX049Y053, bX049Y054, bX049Y055, bX049Y056, bX049Y057, bX049Y058, bX049Y059, bX049Y060, bX049Y061, bX049Y062, bX049Y063);
                dta.Rows.Add("cellX050", bX050Y000, bX050Y001, bX050Y002, bX050Y003, bX050Y004, bX050Y005, bX050Y006, bX050Y007, bX050Y008, bX050Y009, bX050Y010, bX050Y011, bX050Y012, bX050Y013, bX050Y014, bX050Y015, bX050Y016, bX050Y017, bX050Y018, bX050Y019, bX050Y020, bX050Y021, bX050Y022, bX050Y023, bX050Y024, bX050Y025, bX050Y026, bX050Y027, bX050Y028, bX050Y029, bX050Y030, bX050Y031, bX050Y032, bX050Y033, bX050Y034, bX050Y035, bX050Y036, bX050Y037, bX050Y038, bX050Y039, bX050Y040, bX050Y041, bX050Y042, bX050Y043, bX050Y044, bX050Y045, bX050Y046, bX050Y047, bX050Y048, bX050Y049, bX050Y050, bX050Y051, bX050Y052, bX050Y053, bX050Y054, bX050Y055, bX050Y056, bX050Y057, bX050Y058, bX050Y059, bX050Y060, bX050Y061, bX050Y062, bX050Y063);
                dta.Rows.Add("cellX051", bX051Y000, bX051Y001, bX051Y002, bX051Y003, bX051Y004, bX051Y005, bX051Y006, bX051Y007, bX051Y008, bX051Y009, bX051Y010, bX051Y011, bX051Y012, bX051Y013, bX051Y014, bX051Y015, bX051Y016, bX051Y017, bX051Y018, bX051Y019, bX051Y020, bX051Y021, bX051Y022, bX051Y023, bX051Y024, bX051Y025, bX051Y026, bX051Y027, bX051Y028, bX051Y029, bX051Y030, bX051Y031, bX051Y032, bX051Y033, bX051Y034, bX051Y035, bX051Y036, bX051Y037, bX051Y038, bX051Y039, bX051Y040, bX051Y041, bX051Y042, bX051Y043, bX051Y044, bX051Y045, bX051Y046, bX051Y047, bX051Y048, bX051Y049, bX051Y050, bX051Y051, bX051Y052, bX051Y053, bX051Y054, bX051Y055, bX051Y056, bX051Y057, bX051Y058, bX051Y059, bX051Y060, bX051Y061, bX051Y062, bX051Y063);
                dta.Rows.Add("cellX052", bX052Y000, bX052Y001, bX052Y002, bX052Y003, bX052Y004, bX052Y005, bX052Y006, bX052Y007, bX052Y008, bX052Y009, bX052Y010, bX052Y011, bX052Y012, bX052Y013, bX052Y014, bX052Y015, bX052Y016, bX052Y017, bX052Y018, bX052Y019, bX052Y020, bX052Y021, bX052Y022, bX052Y023, bX052Y024, bX052Y025, bX052Y026, bX052Y027, bX052Y028, bX052Y029, bX052Y030, bX052Y031, bX052Y032, bX052Y033, bX052Y034, bX052Y035, bX052Y036, bX052Y037, bX052Y038, bX052Y039, bX052Y040, bX052Y041, bX052Y042, bX052Y043, bX052Y044, bX052Y045, bX052Y046, bX052Y047, bX052Y048, bX052Y049, bX052Y050, bX052Y051, bX052Y052, bX052Y053, bX052Y054, bX052Y055, bX052Y056, bX052Y057, bX052Y058, bX052Y059, bX052Y060, bX052Y061, bX052Y062, bX052Y063);
                dta.Rows.Add("cellX053", bX053Y000, bX053Y001, bX053Y002, bX053Y003, bX053Y004, bX053Y005, bX053Y006, bX053Y007, bX053Y008, bX053Y009, bX053Y010, bX053Y011, bX053Y012, bX053Y013, bX053Y014, bX053Y015, bX053Y016, bX053Y017, bX053Y018, bX053Y019, bX053Y020, bX053Y021, bX053Y022, bX053Y023, bX053Y024, bX053Y025, bX053Y026, bX053Y027, bX053Y028, bX053Y029, bX053Y030, bX053Y031, bX053Y032, bX053Y033, bX053Y034, bX053Y035, bX053Y036, bX053Y037, bX053Y038, bX053Y039, bX053Y040, bX053Y041, bX053Y042, bX053Y043, bX053Y044, bX053Y045, bX053Y046, bX053Y047, bX053Y048, bX053Y049, bX053Y050, bX053Y051, bX053Y052, bX053Y053, bX053Y054, bX053Y055, bX053Y056, bX053Y057, bX053Y058, bX053Y059, bX053Y060, bX053Y061, bX053Y062, bX053Y063);
                dta.Rows.Add("cellX054", bX054Y000, bX054Y001, bX054Y002, bX054Y003, bX054Y004, bX054Y005, bX054Y006, bX054Y007, bX054Y008, bX054Y009, bX054Y010, bX054Y011, bX054Y012, bX054Y013, bX054Y014, bX054Y015, bX054Y016, bX054Y017, bX054Y018, bX054Y019, bX054Y020, bX054Y021, bX054Y022, bX054Y023, bX054Y024, bX054Y025, bX054Y026, bX054Y027, bX054Y028, bX054Y029, bX054Y030, bX054Y031, bX054Y032, bX054Y033, bX054Y034, bX054Y035, bX054Y036, bX054Y037, bX054Y038, bX054Y039, bX054Y040, bX054Y041, bX054Y042, bX054Y043, bX054Y044, bX054Y045, bX054Y046, bX054Y047, bX054Y048, bX054Y049, bX054Y050, bX054Y051, bX054Y052, bX054Y053, bX054Y054, bX054Y055, bX054Y056, bX054Y057, bX054Y058, bX054Y059, bX054Y060, bX054Y061, bX054Y062, bX054Y063);
                dta.Rows.Add("cellX055", bX055Y000, bX055Y001, bX055Y002, bX055Y003, bX055Y004, bX055Y005, bX055Y006, bX055Y007, bX055Y008, bX055Y009, bX055Y010, bX055Y011, bX055Y012, bX055Y013, bX055Y014, bX055Y015, bX055Y016, bX055Y017, bX055Y018, bX055Y019, bX055Y020, bX055Y021, bX055Y022, bX055Y023, bX055Y024, bX055Y025, bX055Y026, bX055Y027, bX055Y028, bX055Y029, bX055Y030, bX055Y031, bX055Y032, bX055Y033, bX055Y034, bX055Y035, bX055Y036, bX055Y037, bX055Y038, bX055Y039, bX055Y040, bX055Y041, bX055Y042, bX055Y043, bX055Y044, bX055Y045, bX055Y046, bX055Y047, bX055Y048, bX055Y049, bX055Y050, bX055Y051, bX055Y052, bX055Y053, bX055Y054, bX055Y055, bX055Y056, bX055Y057, bX055Y058, bX055Y059, bX055Y060, bX055Y061, bX055Y062, bX055Y063);
                dta.Rows.Add("cellX056", bX056Y000, bX056Y001, bX056Y002, bX056Y003, bX056Y004, bX056Y005, bX056Y006, bX056Y007, bX056Y008, bX056Y009, bX056Y010, bX056Y011, bX056Y012, bX056Y013, bX056Y014, bX056Y015, bX056Y016, bX056Y017, bX056Y018, bX056Y019, bX056Y020, bX056Y021, bX056Y022, bX056Y023, bX056Y024, bX056Y025, bX056Y026, bX056Y027, bX056Y028, bX056Y029, bX056Y030, bX056Y031, bX056Y032, bX056Y033, bX056Y034, bX056Y035, bX056Y036, bX056Y037, bX056Y038, bX056Y039, bX056Y040, bX056Y041, bX056Y042, bX056Y043, bX056Y044, bX056Y045, bX056Y046, bX056Y047, bX056Y048, bX056Y049, bX056Y050, bX056Y051, bX056Y052, bX056Y053, bX056Y054, bX056Y055, bX056Y056, bX056Y057, bX056Y058, bX056Y059, bX056Y060, bX056Y061, bX056Y062, bX056Y063);

                dta.Rows.Add("cellX057", bX057Y000, bX057Y001, bX057Y002, bX057Y003, bX057Y004, bX057Y005, bX057Y006, bX057Y007, bX057Y008, bX057Y009, bX057Y010, bX057Y011, bX057Y012, bX057Y013, bX057Y014, bX057Y015, bX057Y016, bX057Y017, bX057Y018, bX057Y019, bX057Y020, bX057Y021, bX057Y022, bX057Y023, bX057Y024, bX057Y025, bX057Y026, bX057Y027, bX057Y028, bX057Y029, bX057Y030, bX057Y031, bX057Y032, bX057Y033, bX057Y034, bX057Y035, bX057Y036, bX057Y037, bX057Y038, bX057Y039, bX057Y040, bX057Y041, bX057Y042, bX057Y043, bX057Y044, bX057Y045, bX057Y046, bX057Y047, bX057Y048, bX057Y049, bX057Y050, bX057Y051, bX057Y052, bX057Y053, bX057Y054, bX057Y055, bX057Y056, bX057Y057, bX057Y058, bX057Y059, bX057Y060, bX057Y061, bX057Y062, bX057Y063);
                dta.Rows.Add("cellX058", bX058Y000, bX058Y001, bX058Y002, bX058Y003, bX058Y004, bX058Y005, bX058Y006, bX058Y007, bX058Y008, bX058Y009, bX058Y010, bX058Y011, bX058Y012, bX058Y013, bX058Y014, bX058Y015, bX058Y016, bX058Y017, bX058Y018, bX058Y019, bX058Y020, bX058Y021, bX058Y022, bX058Y023, bX058Y024, bX058Y025, bX058Y026, bX058Y027, bX058Y028, bX058Y029, bX058Y030, bX058Y031, bX058Y032, bX058Y033, bX058Y034, bX058Y035, bX058Y036, bX058Y037, bX058Y038, bX058Y039, bX058Y040, bX058Y041, bX058Y042, bX058Y043, bX058Y044, bX058Y045, bX058Y046, bX058Y047, bX058Y048, bX058Y049, bX058Y050, bX058Y051, bX058Y052, bX058Y053, bX058Y054, bX058Y055, bX058Y056, bX058Y057, bX058Y058, bX058Y059, bX058Y060, bX058Y061, bX058Y062, bX058Y063);
                dta.Rows.Add("cellX059", bX059Y000, bX059Y001, bX059Y002, bX059Y003, bX059Y004, bX059Y005, bX059Y006, bX059Y007, bX059Y008, bX059Y009, bX059Y010, bX059Y011, bX059Y012, bX059Y013, bX059Y014, bX059Y015, bX059Y016, bX059Y017, bX059Y018, bX059Y019, bX059Y020, bX059Y021, bX059Y022, bX059Y023, bX059Y024, bX059Y025, bX059Y026, bX059Y027, bX059Y028, bX059Y029, bX059Y030, bX059Y031, bX059Y032, bX059Y033, bX059Y034, bX059Y035, bX059Y036, bX059Y037, bX059Y038, bX059Y039, bX059Y040, bX059Y041, bX059Y042, bX059Y043, bX059Y044, bX059Y045, bX059Y046, bX059Y047, bX059Y048, bX059Y049, bX059Y050, bX059Y051, bX059Y052, bX059Y053, bX059Y054, bX059Y055, bX059Y056, bX059Y057, bX059Y058, bX059Y059, bX059Y060, bX059Y061, bX059Y062, bX059Y063);
                dta.Rows.Add("cellX060", bX060Y000, bX060Y001, bX060Y002, bX060Y003, bX060Y004, bX060Y005, bX060Y006, bX060Y007, bX060Y008, bX060Y009, bX060Y010, bX060Y011, bX060Y012, bX060Y013, bX060Y014, bX060Y015, bX060Y016, bX060Y017, bX060Y018, bX060Y019, bX060Y020, bX060Y021, bX060Y022, bX060Y023, bX060Y024, bX060Y025, bX060Y026, bX060Y027, bX060Y028, bX060Y029, bX060Y030, bX060Y031, bX060Y032, bX060Y033, bX060Y034, bX060Y035, bX060Y036, bX060Y037, bX060Y038, bX060Y039, bX060Y040, bX060Y041, bX060Y042, bX060Y043, bX060Y044, bX060Y045, bX060Y046, bX060Y047, bX060Y048, bX060Y049, bX060Y050, bX060Y051, bX060Y052, bX060Y053, bX060Y054, bX060Y055, bX060Y056, bX060Y057, bX060Y058, bX060Y059, bX060Y060, bX060Y061, bX060Y062, bX060Y063);
                dta.Rows.Add("cellX061", bX061Y000, bX061Y001, bX061Y002, bX061Y003, bX061Y004, bX061Y005, bX061Y006, bX061Y007, bX061Y008, bX061Y009, bX061Y010, bX061Y011, bX061Y012, bX061Y013, bX061Y014, bX061Y015, bX061Y016, bX061Y017, bX061Y018, bX061Y019, bX061Y020, bX061Y021, bX061Y022, bX061Y023, bX061Y024, bX061Y025, bX061Y026, bX061Y027, bX061Y028, bX061Y029, bX061Y030, bX061Y031, bX061Y032, bX061Y033, bX061Y034, bX061Y035, bX061Y036, bX061Y037, bX061Y038, bX061Y039, bX061Y040, bX061Y041, bX061Y042, bX061Y043, bX061Y044, bX061Y045, bX061Y046, bX061Y047, bX061Y048, bX061Y049, bX061Y050, bX061Y051, bX061Y052, bX061Y053, bX061Y054, bX061Y055, bX061Y056, bX061Y057, bX061Y058, bX061Y059, bX061Y060, bX061Y061, bX061Y062, bX061Y063);
                dta.Rows.Add("cellX062", bX062Y000, bX062Y001, bX062Y002, bX062Y003, bX062Y004, bX062Y005, bX062Y006, bX062Y007, bX062Y008, bX062Y009, bX062Y010, bX062Y011, bX062Y012, bX062Y013, bX062Y014, bX062Y015, bX062Y016, bX062Y017, bX062Y018, bX062Y019, bX062Y020, bX062Y021, bX062Y022, bX062Y023, bX062Y024, bX062Y025, bX062Y026, bX062Y027, bX062Y028, bX062Y029, bX062Y030, bX062Y031, bX062Y032, bX062Y033, bX062Y034, bX062Y035, bX062Y036, bX062Y037, bX062Y038, bX062Y039, bX062Y040, bX062Y041, bX062Y042, bX062Y043, bX062Y044, bX062Y045, bX062Y046, bX062Y047, bX062Y048, bX062Y049, bX062Y050, bX062Y051, bX062Y052, bX062Y053, bX062Y054, bX062Y055, bX062Y056, bX062Y057, bX062Y058, bX062Y059, bX062Y060, bX062Y061, bX062Y062, bX062Y063);
                dta.Rows.Add("cellX063", bX063Y000, bX063Y001, bX063Y002, bX063Y003, bX063Y004, bX063Y005, bX063Y006, bX063Y007, bX063Y008, bX063Y009, bX063Y010, bX063Y011, bX063Y012, bX063Y013, bX063Y014, bX063Y015, bX063Y016, bX063Y017, bX063Y018, bX063Y019, bX063Y020, bX063Y021, bX063Y022, bX063Y023, bX063Y024, bX063Y025, bX063Y026, bX063Y027, bX063Y028, bX063Y029, bX063Y030, bX063Y031, bX063Y032, bX063Y033, bX063Y034, bX063Y035, bX063Y036, bX063Y037, bX063Y038, bX063Y039, bX063Y040, bX063Y041, bX063Y042, bX063Y043, bX063Y044, bX063Y045, bX063Y046, bX063Y047, bX063Y048, bX063Y049, bX063Y050, bX063Y051, bX063Y052, bX063Y053, bX063Y054, bX063Y055, bX063Y056, bX063Y057, bX063Y058, bX063Y059, bX063Y060, bX063Y061, bX063Y062, bX063Y063);







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

                        if (i < 64)
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










        // future button event for 128s

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Write 128s clicked");
            richTextBox1.AppendText(Environment.NewLine + "Writing 128s clicked...");
            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }























        // Test button to Process Audio... 

        private void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Audio Processing... doing nothing");
            richTextBox1.AppendText(Environment.NewLine + "Audio Processing...");
            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();

            // test wav file
            // var fileName = ("Resources/zulu.wav");



            // Initialize a new instance of the SpeechSynthesizer.
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output. 
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.
            synth.Speak("Good Evening.");

            Console.WriteLine("Audio Spoken");
            
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



        private void label1_Click(object sender, EventArgs e)
        {
            // nothing
        }

        private void button13_Click(object sender, EventArgs e)
        {

            mastercancel = false;
            // need to set this thru UI for safing -- also need a cancel boolean if we clicked anywhere


            for (int i = 0; i < loopnum; i++)
            {
                if (mastercancel == false)
                {

                    // mouse import procedure for FaunaEcoSubcellType1's
                    // select all and import, then run this while Data Table Import Options is in focus()

                    //first click location -- accesses the dropdown -- comment is for 1440p
                    int xpos1 = 1850;     // int xpos1 = 1240;
                    int ypos1 = 1084;      // int ypos1 = 720;
                    //Console.WriteLine("First click");
                    SetCursorPos(xpos1, ypos1);
                    System.Threading.Thread.Sleep(400);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, xpos1, ypos1, 0, 0);
                    System.Threading.Thread.Sleep(100);
                    mouse_event(MOUSEEVENTF_LEFTUP, xpos1, ypos1, 0, 0);

                    // second click -- selects the type of data table (type1 here)
                    int xpos2 = 1770;        // int xpos2 = 1240;
                    int ypos2 = 1241;         // int ypos2 = 878;
                    //Console.WriteLine("Second click");
                    SetCursorPos(xpos2, ypos2);
                    System.Threading.Thread.Sleep(400);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, xpos2, ypos2, 0, 0);
                    System.Threading.Thread.Sleep(100);
                    mouse_event(MOUSEEVENTF_LEFTUP, xpos2, ypos2, 0, 0);

                    // Third click -- hits OK!
                    int xpos3 = 1696;       // int xpos3 = 1051;
                    int ypos3 = 1104;        // int ypos3 = 743;
                    //Console.WriteLine("OK click");
                    SetCursorPos(xpos3, ypos3);
                    System.Threading.Thread.Sleep(400);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, xpos3, ypos3, 0, 0);
                    System.Threading.Thread.Sleep(100);
                    mouse_event(MOUSEEVENTF_LEFTUP, xpos3, ypos3, 0, 0);

                    // final wait task for unreal to catchup

                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("Done with loop " + i + "/" + loopnum);
                    richTextBox1.AppendText(Environment.NewLine + "Done with loop " + i + "/" + loopnum);
                    richTextBox1.Focus();
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.ScrollToCaret();
                }
            }



        }

        private void font_MouseMove(object sender, MouseEventArgs e)
        {
            // Point coordinates = Cursor.Position;
            // Console.WriteLine("Coordinates are: " + coordinates);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // add 
            loopnum = loopnum + 10;
            button13.Text = "Run (" + loopnum.ToString() + ")";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (loopnum == 10)
            {
                // dont continue past 10 since 0 is pointless
            }

            else
            {
                // subtract
                loopnum = loopnum - 10;
                button13.Text = "Run (" + loopnum.ToString() + ")";
            }
        }
    }
}
