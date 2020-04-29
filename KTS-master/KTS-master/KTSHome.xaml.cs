using Cake.Npm.AddUser;
using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
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
using System.Diagnostics;
using DirectoryEntry = System.DirectoryServices.DirectoryEntry;
using System.DirectoryServices.AccountManagement;

namespace KTS
{
    /// <summary>
    /// Interaction logic for KTSHome.xaml
    /// </summary>
    public partial class KTSHome : Page
    {
        public KTSHome()
        {
            InitializeComponent();
        }

        private void Button_Click_Redagavimas(object sender, RoutedEventArgs e)
        {
            Redagavimas red = new Redagavimas();
            this.NavigationService.Navigate(red);
        }

        private void Button_Click_Registration(object sender, RoutedEventArgs e)
        {
            KTSRegister ktsRegister = new KTSRegister();
            this.NavigationService.Navigate(ktsRegister);
        }

        private void Button_Click_Logout(object sender, RoutedEventArgs e)
        {
            KTSLogin ktsLogin = new KTSLogin();
            this.NavigationService.Navigate(ktsLogin);
        }

    }
}
