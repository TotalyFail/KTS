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
using System.Text.RegularExpressions;
using Xunit;
using System.Diagnostics;

using System.DirectoryServices.AccountManagement;



namespace KTS
{
    /// <summary>
    /// Interaction logic for KTSRegister.xaml
    /// </summary>
    public partial class KTSRegister : Page
    {
        public KTSRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //string stringDomainName = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
                PrincipalContext PrincipalContext4 = new PrincipalContext(ContextType.Domain, "TEISMAS.AD");
                UserPrincipal UserPrincipal1 = new UserPrincipal(PrincipalContext4, textboxLonOnName.Text, passwordboxUserPass.Password, true);

                UserPrincipal1.UserPrincipalName = textboxSamAccountName.Text;
                UserPrincipal1.Name = textboxName.Text;
                UserPrincipal1.VoiceTelephoneNumber = textboxPhoneNumber.Text;
                UserPrincipal1.Surname = textboxSurname.Text;
                UserPrincipal1.DisplayName = textboxDisplayName.Text;
                UserPrincipal1.Description = textboxDescription.Text;
                
                if (radiobuttonEnable.IsChecked == true)
                {
                    UserPrincipal1.Enabled = true;
                }
                else
                {
                    UserPrincipal1.Enabled = false;
                }

                if (UserPrincipal1.UserPrincipalName == null || UserPrincipal1.Name == null || UserPrincipal1.VoiceTelephoneNumber == null || UserPrincipal1.Surname == null || UserPrincipal1.DisplayName == null || UserPrincipal1.Description == null)
                {
                    MessageBox.Show("Ne visi laukai uzpildyti");
                }

                else
                {
                    UserPrincipal1.Save();
                    MessageBox.Show("Saved Sucessfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Slaptazodis turi atitikti reikalavimus. Bent viena didzioji raide, bent vienas specialus simbolis ir bent vienas skaicius. Ilgis ne trumpesnis nei 6 simboliai.");
            }
        }

        private void Button_Click_Remove(object sender, RoutedEventArgs e)
        {
            PrincipalContext context = new PrincipalContext(ContextType.Domain, "TEISMAS.AD", "Administrator@Teismas.AD", "A.dmin123");
            if (username.Text.Length > 3)
            {
                UserPrincipal user = UserPrincipal.FindByIdentity(context, username.Text);

                if (user != null)
                {
                    user.Delete();
                    MessageBox.Show("Vartotojas istrintas sekmingai.");
                }
            }
        }

    }

}

