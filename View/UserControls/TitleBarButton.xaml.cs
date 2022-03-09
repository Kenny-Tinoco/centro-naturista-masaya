using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MasayaNaturistCenter.View.UserControls
{
    public partial class TitleBarButton : UserControl
    {
        public TitleBarButton()
        {
            InitializeComponent();
        }
        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public event RoutedEventHandler TitleBarButtonClick
        {
            add { AddHandler(TitleBarButtonClickEvent, value); }
            remove { RemoveHandler(TitleBarButtonClickEvent, value); }
        }
        
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(CustomButton), new PropertyMetadata());
       
        public static readonly RoutedEvent TitleBarButtonClickEvent = 
            EventManager.RegisterRoutedEvent(nameof(TitleBarButtonClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TitleBarButton));


        private void titleBarButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(TitleBarButtonClickEvent));
        }
    }
}
