using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using WPFGeneral.ViewModels;

namespace WPFGeneral
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Gets the current <see cref="App"/> instance in use
        /// </summary>
        public new static App Current => (App)Application.Current;
        public App()
        {
            Services = ConfigureServices();
        }
        public IServiceProvider Services { get; }
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Services


            // Viewmodels
            services.AddTransient<MainWindowVM>();

            return services.BuildServiceProvider();
        }
    }
}
