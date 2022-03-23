using System.Windows;

namespace MasayaNaturistCenter.ViewModel.Command
{
    public class StateBarCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            if (parameter.ToString() == "exit")
                Application.Current.Shutdown();
            else if (parameter.ToString() == "minimize")
                Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
