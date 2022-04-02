using System.Windows;

namespace MasayaNaturistCenter.View
{
    public partial class Startup : Window
    {
        public Startup()
        {
            InitializeComponent();
            MaximizarVentana();
        }
        private void MaximizarVentana()
        {
            #region Sentencias de para el agrandado de la pantalla
            Width = SystemParameters.WorkArea.Width;
            Height = SystemParameters.WorkArea.Height;
            Top = SystemParameters.WorkArea.Bottom - Height;
            Left = SystemParameters.PrimaryScreenWidth - Width;
            #endregion
        }
    }
}
