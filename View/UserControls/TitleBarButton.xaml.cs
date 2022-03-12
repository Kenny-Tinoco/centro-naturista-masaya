using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MasayaNaturistCenter.View.UserControls
{
    public partial class TitleBarButton : UserControl
    {
        public TitleBarButton()
        {
            InitializeComponent();
        }


        public object styleButton
        {
            get { return (object)GetValue(styleButtonProperty); }
            set { SetValue(styleButtonProperty, value); }
        }

        public static readonly DependencyProperty styleButtonProperty =
            DependencyProperty.Register("styleButton", typeof(object), typeof(TitleBarButton), new PropertyMetadata(0));



        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public event RoutedEventHandler TitleBarButtonClick
        {
            add { AddHandler(TitleBarButtonClickEvent, value); }
            remove { RemoveHandler(TitleBarButtonClickEvent, value); }
        }
        
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(ImageSource), typeof(TitleBarButton), new PropertyMetadata());
       
        public static readonly RoutedEvent TitleBarButtonClickEvent = 
            EventManager.RegisterRoutedEvent(nameof(TitleBarButtonClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TitleBarButton));


        private void titleBarButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(TitleBarButtonClickEvent));
        }
    }
}
