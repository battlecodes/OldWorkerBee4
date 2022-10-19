using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WorkerBee.Stores;
using WorkerBee.ViewModels;
using WorkerBee.Views;

namespace WorkerBee
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly LayoutNavigationStore _layoutNavigationStore;



        private readonly NavigationStore _navigationStore;



        public App()
        {
            _layoutNavigationStore = new LayoutNavigationStore();
            _navigationStore = new NavigationStore();
        }



        protected override void OnStartup(StartupEventArgs e)
        {
            // Setting the layout navigation store's CurrentContentViewModel
            // to the home view-model on startup is FOR TESTING ONLY!!!!!!!!
            _layoutNavigationStore.CurrentContentViewModel = new HomeViewModel();

            // Setting the navigation store's CurrentMainViewModel to the
            // layout view-model on startup is FOR TESTING ONLY!!!!!!!!!!
            _navigationStore.CurrentMainViewModel = new LayoutViewModel(_layoutNavigationStore);



            MainWindowViewModel mainWindowViewModel =
                new MainWindowViewModel(_navigationStore);
            MainWindow = new MainWindowView()
            {
                DataContext = mainWindowViewModel,
            };
            MainWindow.Show();



            base.OnStartup(e);
        }
    }
}
