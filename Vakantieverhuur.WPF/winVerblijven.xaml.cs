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
using System.Windows.Shapes;
using Vakantieverhuur.LIB.Entities;
using Vakantieverhuur.LIB.Services;

namespace Vakantieverhuur.WPF
{
    /// <summary>
    /// Interaction logic for winVerblijven.xaml
    /// </summary>
    public partial class winVerblijven : Window
    {
        public winVerblijven()
        {
            InitializeComponent();
        }

        public string situatie="";
        public Verblijf verblijf = null;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(situatie=="view")
            {
                grpGegevens.IsEnabled = false;
                lblTitel.Content = "Verblijf bekijken";
                btnBewaren.Visibility = Visibility.Hidden;
                btnAnnuleren.Content = "Sluiten";
            }
            else
            {
                grpGegevens.IsEnabled = true;
                btnBewaren.Visibility = Visibility.Visible;
                btnAnnuleren.Content = "Annuleren";
                if(situatie == "new")
                {
                    lblTitel.Content = "Verblijf toevoegen";
                }
                else
                {
                    lblTitel.Content = "Verblijf verwijderen";
                }
            }
            if(verblijf == null)
            {
                cmbSoorten.SelectedIndex = 0;
                txtHuisNaam.Text = "";
            }
            else
            {
                if (verblijf is Vakantiehuis)
                {
                    cmbSoorten.SelectedIndex = 0;
                    chkPersoonlijkSanitair.Visibility = Visibility.Hidden;

                }
                else
                {
                    cmbSoorten.SelectedIndex = 1;
                    chkPersoonlijkSanitair.Visibility = Visibility.Visible;
                }

                txtHuisNaam.Text = verblijf.HuisNaam;
                txtStraatEnNummer.Text = verblijf.StraatEnNummer;
            }
        }
        private void cmbSoorten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnAnnuleren_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnBewaren_Click(object sender, RoutedEventArgs e)
        {

        }

        

    }
}
