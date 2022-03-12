using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MasayaNaturistCenter.View.UserControls
{
    public partial class SpinBox : UserControl
    {

        public int value
        {
            get { return (int)GetValue(valueProperty); }
            set { SetValue(valueProperty, value); }
        }
        public static readonly DependencyProperty valueProperty =
            DependencyProperty.Register("value", typeof(int), typeof(SpinBox), new PropertyMetadata(0));
        public SpinBox()
        {
            InitializeComponent();
            spinBox.ValueChanged += new RoutedPropertyChangedEventHandler<double>(value_Changed);
            spinBox.Minimum = 0;
            spinBox.Maximum = 999;
            spinBox.SmallChange = 1;
        }

        private void value_Changed(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            value = (int)spinBox.Value;
        }
    }
}
