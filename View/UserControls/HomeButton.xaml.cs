using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MasayaNaturistCenter.View.UserControls
{
    public partial class HomeButton : UserControl
    {
        public HomeButton()
        {
            InitializeComponent();
        }
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public event RoutedEventHandler HomeButtonClick
        {
            add { AddHandler(HomeButtonClickEvent, value); }
            remove { RemoveHandler(HomeButtonClickEvent, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(CustomButton), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(CustomButton), new PropertyMetadata());

        public static readonly RoutedEvent HomeButtonClickEvent =
            EventManager.RegisterRoutedEvent(nameof(HomeButtonClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(HomeButton));


        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(HomeButtonClickEvent));
        }
    }
}
