using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MasayaNaturistCenter.View.UserControls
{
    public partial class CustomButton : UserControl
    {
        public CustomButton()
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

        public event RoutedEventHandler CustomButtonClick
        {
            add { AddHandler(CustomButtonClickEvent, value); }
            remove { RemoveHandler(CustomButtonClickEvent, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(CustomButton), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(CustomButton), new PropertyMetadata());

        public static readonly RoutedEvent CustomButtonClickEvent =
            EventManager.RegisterRoutedEvent(nameof(CustomButtonClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CustomButton));


        private void customButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(CustomButtonClickEvent));
        }
    }
}
