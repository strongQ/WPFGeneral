using Microsoft.Extensions.DependencyInjection;
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
using WPFGeneral.ViewModels;

namespace WPFGeneral
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = App.Current.Services.GetService<MainWindowVM>();
        }

        private void TrayMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            if (sender is MenuItem)
            {
                var item = sender as MenuItem;

                if (item == null) return;

                if (item.Tag.Equals("桌面"))
                {
                    this.WindowState = WindowState.Normal;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newTheme = WPFUI.Appearance.Theme.GetAppTheme() == WPFUI.Appearance.ThemeType.Dark
            ? WPFUI.Appearance.ThemeType.Light
            : WPFUI.Appearance.ThemeType.Dark;

            // We apply the theme to the entire application.
            WPFUI.Appearance.Theme.Apply(
                themeType: newTheme,
                backgroundEffect: WPFUI.Appearance.BackgroundType.Mica,
                updateAccent: true,
                forceBackground: false);
        }
    }
}
