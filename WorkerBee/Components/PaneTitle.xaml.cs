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

namespace WorkerBee.Components
{
    /// <summary>
    /// Interaction logic for PaneTitle.xaml
    /// </summary>
    public partial class PaneTitle : UserControl
    {

        public static readonly DependencyProperty TitleLabelTextProperty =
            DependencyProperty.Register("TitleLabelText", typeof(string),
                typeof(PaneTitle), new PropertyMetadata("Placeholder"));



        public string TitleLabelText
        {
            get { return (string)GetValue(TitleLabelTextProperty); }
            set { SetValue(TitleLabelTextProperty, value); }
        }



        public PaneTitle()
        {
            InitializeComponent();
        }
    }
}
