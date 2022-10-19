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
    /// Interaction logic for BookLogo.xaml
    /// </summary>
    public partial class BookLogo : UserControl
    {

        public static readonly DependencyProperty BookNameProperty =
            DependencyProperty.Register("BookName", typeof(string),
                typeof(BookLogo), new PropertyMetadata(null));



        public string BookName
        {
            get { return (string)GetValue(BookNameProperty); }
            set { SetValue(BookNameProperty, value); }
        }



        public BookLogo()
        {
            InitializeComponent();
        }
    }
}
