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
    /// Interaction logic for NavigationBarButton.xaml
    /// </summary>
    public partial class NavigationBarButton : UserControl
    {

        public static readonly DependencyProperty ButtonContentTextProperty =
            DependencyProperty.Register("ButtonContentText", typeof(string),
                typeof(NavigationBarButton), new PropertyMetadata(null));



        public string ButtonContentText
        {
            get { return (string)GetValue(ButtonContentTextProperty); }
            set { SetValue(ButtonContentTextProperty, value); }
        }



        public NavigationBarButton()
        {
            InitializeComponent();
        }
    }
}
