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
    /// Interaction logic for TopBar.xaml
    /// </summary>
    public partial class TopBar : UserControl
    {

        public static readonly DependencyProperty BookLogoNameProperty =
            DependencyProperty.Register("BookLogoName", typeof(string),
                typeof(TopBar), new PropertyMetadata(null));



        public string BookLogoName
        {
            get { return (string)GetValue(BookLogoNameProperty); }
            set { SetValue(BookLogoNameProperty, value); }
        }



        public TopBar()
        {
            InitializeComponent();
        }
    }
}
