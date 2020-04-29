using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.Protocols;
using System.IO;
using System.Linq;
using System.Net;
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

namespace KTS
{
    /// <summary>
    /// Interaction logic for KTSLogin.xaml
    /// </summary>
    public partial class KTSLogin : Page
    {
        public KTSLogin()
        {
            InitializeComponent();
        }

        private void Button_Click_Home(object sender, RoutedEventArgs e)
        {
            KTSHome ktsHome = new KTSHome();
            this.NavigationService.Navigate(ktsHome);
        }


        public void ValidateUserByBind(object sender, RoutedEventArgs e)
        {

            using (DirectoryEntry entry = new DirectoryEntry())
            {
                entry.Username = textBoxEmail.Text;
                entry.Password = passwordBox1.Password;

                DirectorySearcher searcher = new DirectorySearcher(entry);

                searcher.Filter = "(objectclass=user)";

                try
                {
                    searcher.FindOne();
                    MessageBox.Show("Prisijungta sekmingai!");
                    Button_Click_Home(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Neteisingi Duomenys.");
                    if (ex.Message == "-2147023570")
                    {
                        MessageBox.Show("Klaidingi duomenys.");  
                    }
                }
            }

        }


    }


}
