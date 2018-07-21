
namespace Launcher
{
    enum LauncherState
    {
        Idle,
        Downloading,
        Uninstall,
        Repair,
        PendingUpdate
    };
    class StateHandler
    {
        LauncherState state = LauncherState.Idle;

        public LauncherState getLauncherState()
        {
            return state;
        }
        public void changeButtonState(LauncherState newState, main MainForm)
        {
            state = newState;
            switch (state)
            {
                case LauncherState.Idle:
                    {
                        //MainForm._Play.Enabled = true;
                        //MainForm._Play.BackgroundImage = Properties.Resources.button;
                        //MainForm._button1.BackgroundImage = Properties.Resources.button;
                        //MainForm._button2.BackgroundImage = Properties.Resources.button;
                        //MainForm._button3.BackgroundImage = Properties.Resources.button;
                        //MainForm._button4.BackgroundImage = Properties.Resources.button;
                        //MainForm._button5.BackgroundImage = Properties.Resources.button;
                        //MainForm._button6.BackgroundImage = Properties.Resources.button;
                        //
                        //MainForm._button7.BackgroundImage = Properties.Resources.button;
                        //MainForm._button8.BackgroundImage = Properties.Resources.button;
                        //MainForm._button9.BackgroundImage = Properties.Resources.button;
                        //
                        //MainForm._button10.BackgroundImage = Properties.Resources.button;
                        //MainForm._button11.BackgroundImage = Properties.Resources.button;
                        //MainForm._button12.BackgroundImage = Properties.Resources.button;
                        //MainForm._MinimizeButton.BackgroundImage = Properties.Resources.button;
                        //MainForm._CloseButton.BackgroundImage = Properties.Resources.button;











                        break;
                    }

            }
        }







    }






}
