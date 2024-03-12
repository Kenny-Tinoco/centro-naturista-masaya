﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WPF.ViewsComponent.UserControls
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

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(HomeButton), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(HomeButton), new PropertyMetadata());

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandPropety); }
            set { SetValue(CommandPropety, value); }
        }

        public static readonly DependencyProperty CommandPropety =
            DependencyProperty.Register("Command", typeof(ICommand), typeof(HomeButton), new PropertyMetadata());


        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.Register("CommandParameter", typeof(object), typeof(HomeButton), new PropertyMetadata(string.Empty));

    }
}
