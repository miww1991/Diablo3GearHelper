using System;
using System.Collections.Generic;
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
using Diablo3GearHelper.Types;

namespace Diablo3GearHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Hero[] _heroes;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.BTagNameTextBox.Text = "Everix#1486";  // Temp for Testing
        }

    #region Event Handlers

        private void ImportCharactersButton_OnClick(object sender, RoutedEventArgs e)
        {
            // Convert the entered battle tag into the format needed by the D3 API
            string battleTag = GetBattleTag();
            if (battleTag == null)
            {
                MessageBox.Show("Invalid BattleTag entered. Please enter in the format \"Elevarin#1192\"");
                return;
            }

            // Using the battle tag entered, retrieve hero names
            this._heroes = WebDataRetriever.GetHeroes(battleTag);

            // Clear our characters combo box
            this.CharacterComboBox.Items.Clear();

            // If we have an invalid heroes list, return to avoid exceptions
            if (_heroes == null || _heroes.Length <= 0)
            {
                return;
            }
            
            // Add each hero to the list of characters
            foreach (Hero hero in this._heroes)
            {
                this.CharacterComboBox.Items.Add(hero);
            }

            // Set our selection to the first character on the account
            this.CharacterComboBox.SelectedIndex = 0;

            // Enable our ComboBox now that it has items in it
            this.CharacterComboBox.IsEnabled = true;
        }

    #endregion

    #region Helper methods

        private string GetBattleTag()
        {
            string[] tokens = this.BTagNameTextBox.Text.Split(new char[] { '#', '-' });
            if (tokens.Length != 2)
            {
                return null;
            }

            return tokens[0] + "-" + tokens[1];
        }

    #endregion

    }
}
