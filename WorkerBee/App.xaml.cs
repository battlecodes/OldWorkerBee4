using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WorkerBee.Views;

namespace WorkerBee
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {

            MainWindowViewModel mainWindowViewModel =
                new MainWindowViewModel();
            MainWindow = new MainWindowView()
            {
                DataContext = mainWindowViewModel,
            };
            MainWindow.Show();



            base.OnStartup(e);
        }
    }
}
