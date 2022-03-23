using System.Windows;
using System.Windows.Controls;

namespace MasayaNaturistCenter.ViewComponents.CustomControls
{
    public class HamburgerMenuItem : RadioButton
    {
        static HamburgerMenuItem()
        {
            DefaultStyleKeyProperty
                .OverrideMetadata(typeof(HamburgerMenuItem),
                    new FrameworkPropertyMetadata(typeof(HamburgerMenuItem)));
        }
    }
}
