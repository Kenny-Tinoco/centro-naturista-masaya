using System.Windows;
using System.Windows.Controls.Ribbon;

namespace MasayaNaturistCenter.ViewComponents.CustomControls
{
    public class HamburgerMenuItem : RibbonRadioButton
    {
        static HamburgerMenuItem()
        {
            DefaultStyleKeyProperty
                .OverrideMetadata(typeof(HamburgerMenuItem),
                    new FrameworkPropertyMetadata(typeof(HamburgerMenuItem)));
        }
    }
}
