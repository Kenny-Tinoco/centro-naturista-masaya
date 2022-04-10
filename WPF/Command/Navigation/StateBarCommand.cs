using System.Windows;
using WPF.MVVMEssentials.Commands;

namespace WPF.Command.Navigation
{
    public class StateBarCommand : CommandBase
    {
        public override void Execute( object parameter )
        {
            if (parameter.ToString() == "exit")
                Application.Current.Shutdown();
            else if (parameter.ToString() == "minimize")
                Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
