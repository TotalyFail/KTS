using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.IO;
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

namespace KTS
{
    /// <summary>
    /// Interaction logic for RedagavimoPvz.xaml
    /// </summary>
    public partial class Redagavimas : Page
    {
        public Redagavimas()
        {
            InitializeComponent();
            CreateDynamicWPFGrid();
        }

        public void CreateDynamicWPFGrid()

        {

            DynamicGrid.Width = 800;

            DynamicGrid.HorizontalAlignment = HorizontalAlignment.Left;

            DynamicGrid.VerticalAlignment = VerticalAlignment.Top;

            DynamicGrid.ShowGridLines = true;

            DynamicGrid.Background = new SolidColorBrush(Colors.LightSteelBlue);



            // Create Columns

            ColumnDefinition gridCol1 = new ColumnDefinition();

            ColumnDefinition gridCol2 = new ColumnDefinition();

            ColumnDefinition gridCol3 = new ColumnDefinition();

            ColumnDefinition gridCol4 = new ColumnDefinition();

            ColumnDefinition gridCol5 = new ColumnDefinition();

            DynamicGrid.ColumnDefinitions.Add(gridCol1);

            DynamicGrid.ColumnDefinitions.Add(gridCol2);

            DynamicGrid.ColumnDefinitions.Add(gridCol3);

            DynamicGrid.ColumnDefinitions.Add(gridCol4);

            DynamicGrid.ColumnDefinitions.Add(gridCol5);



            // Create Rows

            RowDefinition gridRow1 = new RowDefinition();

            gridRow1.Height = new GridLength(45);

            DynamicGrid.RowDefinitions.Add(gridRow1);

            // Add first column header

            TextBlock txtBlock1 = new TextBlock();

            txtBlock1.Text = "Vardas Pavarde";

            txtBlock1.FontSize = 14;

            txtBlock1.FontWeight = FontWeights.Bold;

            txtBlock1.Foreground = new SolidColorBrush(Colors.Green);

            txtBlock1.VerticalAlignment = VerticalAlignment.Top;

            Grid.SetRow(txtBlock1, 0);

            Grid.SetColumn(txtBlock1, 0);



            // Add second column header

            TextBlock txtBlock2 = new TextBlock();

            txtBlock2.Text = "Pastas";

            txtBlock2.FontSize = 14;

            txtBlock2.FontWeight = FontWeights.Bold;

            txtBlock2.Foreground = new SolidColorBrush(Colors.Green);

            txtBlock2.VerticalAlignment = VerticalAlignment.Top;

            Grid.SetRow(txtBlock2, 0);

            Grid.SetColumn(txtBlock2, 1);



            // Add third column header

            TextBlock txtBlock3 = new TextBlock();

            txtBlock3.Text = "Kabinetas";

            txtBlock3.FontSize = 14;

            txtBlock3.FontWeight = FontWeights.Bold;

            txtBlock3.Foreground = new SolidColorBrush(Colors.Green);

            txtBlock3.VerticalAlignment = VerticalAlignment.Top;

            Grid.SetRow(txtBlock3, 0);

            Grid.SetColumn(txtBlock3, 2);

            // Add fourth column header

            TextBlock txtBlock4 = new TextBlock();

            txtBlock4.Text = "Update";

            txtBlock4.FontSize = 14;

            txtBlock4.FontWeight = FontWeights.Bold;

            txtBlock4.Foreground = new SolidColorBrush(Colors.Green);

            txtBlock4.VerticalAlignment = VerticalAlignment.Top;

            Grid.SetRow(txtBlock4, 0);

            Grid.SetColumn(txtBlock4, 4);


            // Add fifth column header

            TextBlock txtBlock5 = new TextBlock();


            txtBlock5.Text = "Padalinys";

            txtBlock5.FontSize = 14;

            txtBlock5.FontWeight = FontWeights.Bold;

            txtBlock5.Foreground = new SolidColorBrush(Colors.Green);

            txtBlock5.VerticalAlignment = VerticalAlignment.Top;

            Grid.SetRow(txtBlock5, 0);

            Grid.SetColumn(txtBlock5, 3);


            //// Add column headers to the Grid

            DynamicGrid.Children.Add(txtBlock1);

            DynamicGrid.Children.Add(txtBlock2);

            DynamicGrid.Children.Add(txtBlock3);

            DynamicGrid.Children.Add(txtBlock4);

            DynamicGrid.Children.Add(txtBlock5);

            createRow();


            // Display grid into a Window
           // this.Content = DynamicGrid;

        }

        public void createRow()
        {


            ComboBox cbOne = new ComboBox();

            using (StreamReader sr = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + "Kabinetai.txt"))
            {
                String[] line = sr.ReadToEnd().Split(';');
                foreach (String ln in line)
                    cbOne.Items.Add(ln);
            }


            int count = 0;
                using (var context = new PrincipalContext(ContextType.Domain, "TEISMAS.AD"))
                {
                    using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
                    {
                    foreach (var result in searcher.FindAll())
                    {
                        count++;
                        DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;
                        //Debug.WriteLine("Last Name : " + de.Properties["sn"].Value);
                        //Debug.WriteLine("SAM account name   : " + de.Properties["samAccountName"].Value);
                        //Debug.WriteLine("User principal name: " + de.Properties["userPrincipalName"].Value);

                        RowDefinition gridRow1 = new RowDefinition();

                        gridRow1.Height = new GridLength(30);

                        DynamicGrid.RowDefinitions.Add(gridRow1);

                        TextBox authorText = new TextBox();

                        authorText.Text = de.Properties["samAccountName"].Value.ToString();

                        authorText.FontSize = 12;

                        authorText.FontWeight = FontWeights.Bold;

                        Grid.SetRow(authorText, count);

                        Grid.SetColumn(authorText, 0);



                        TextBox mailText = new TextBox();

                        if (de.Properties["mail"].Value == null)
                        {
                            mailText.Text = " ";
                        }

                        else
                        {
                            mailText.Text = de.Properties["mail"].Value.ToString();
                        }

                        mailText.FontSize = 12;

                        mailText.FontWeight = FontWeights.Bold;

                        Grid.SetRow(mailText, count);

                        Grid.SetColumn(mailText, 1);



                        TextBox kabText = new TextBox();

                        if (de.Properties["physicalDeliveryOfficeName"].Value == null)
                        {
                            kabText.Text = "";
                        }

                        else
                        {
                            kabText.Text = de.Properties["physicalDeliveryOfficeName"].Value.ToString();
                        }

                        kabText.FontSize = 12;

                        kabText.FontWeight = FontWeights.Bold;

                        Grid.SetRow(kabText, count);

                        Grid.SetColumn(kabText, 2);

                        Button button = new Button();

                        button.Content = "Update";

                        Grid.SetRow(button, count);
                        Grid.SetColumn(button, 4);

                        TextBox padText = new TextBox();

                        if (de.Properties["description"].Value == null)
                        {
                            padText.Text = "";
                        }

                        else
                        {
                            padText.Text = de.Properties["description"].Value.ToString();
                        }

                        padText.FontSize = 12;

                        padText.FontWeight = FontWeights.Bold;

                        Grid.SetRow(padText, count);
                        Grid.SetColumn(padText, 3);
                        // Add first row to Grid

                        button.Click += (sender, e) =>
                        {
                            if (kabText.Text.Length > 1)
                            {
                                de.Properties["physicalDeliveryOfficeName"].Value = kabText.Text;
                            }

                            else
                            {
                                de.Properties["physicalDeliveryOfficeName"].Value = " ";
                            }

                            if (mailText.Text.Length > 1)
                            {
                                de.Properties["mail"].Value = mailText.Text;
                            }

                            else
                            {
                                de.Properties["mail"].Value = " ";
                            }

                            if (padText.Text.Length > 1)
                            {
                                de.Properties["description"].Value = padText.Text;
                            }
                            else
                            {
                                de.Properties["description"].Value = " ";
                            }

                            de.CommitChanges();
                            Redagavimas redagavimas = new Redagavimas();
                            this.NavigationService.Navigate(redagavimas);
                            MessageBox.Show("Informacija pakeista sekmingai.");
                        };

                        DynamicGrid.Children.Add(authorText);

                        DynamicGrid.Children.Add(mailText);

                        DynamicGrid.Children.Add(kabText);

                        DynamicGrid.Children.Add(button);

                        DynamicGrid.Children.Add(padText);

                    }
                    }
                }
        }
         
        private void Button_Click_Update(object sender, RoutedEventArgs e, PrincipalContext pc, DirectoryEntry de, string kabNr)
        {
            de.Properties["Description"].Value = kabNr;
        }
    }
}
