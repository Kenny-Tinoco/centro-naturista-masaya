using System.Windows;
using System.Windows.Controls;

namespace MasayaNaturistCenter.ViewComponents.UserControls
{
    public partial class BackButton : UserControl
    {
        public BackButton()
        {
            InitializeComponent();
        }

        public event RoutedEventHandler BackButtonClick
        {
            add { AddHandler(BackButtonClickEvent, value); }
            remove { RemoveHandler(BackButtonClickEvent, value); }
        }
        
        public static readonly RoutedEvent BackButtonClickEvent =
            EventManager.RegisterRoutedEvent(nameof(BackButtonClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(BackButton));


        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(BackButtonClickEvent));
        }
    }
}
