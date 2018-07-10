
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
                        MainForm._Play.Text = "Play Latest";
                        MainForm._Play.Enabled = true;
                        MainForm._Play.BackgroundImage = Properties.Resources.button;
                        break;
                    }

            }
        }
    }
}
