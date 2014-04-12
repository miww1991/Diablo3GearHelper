//#define TESTING

using System.Windows;
using System.Collections.Generic;
using Diablo3GearHelper.Types;
using System.Diagnostics;
using System;
using System.Windows.Input;

namespace Diablo3GearHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Hero[] _heroes;
        private string battleTag;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
//#if DEBUG && TESTING
            this.BTagNameTextBox.Text = "Everix#1486";  // Temp for Testing
#if DEBUG && TESTING
            // Temp to skip having to import account
            Hero testHero = new Hero("Everix", 606264, 70, false, 101, HeroGender.Male, false, ClassType.Wizard, 1396632618);
            this.CharacterComboBox.Items.Add(testHero);
            this.CharacterComboBox.SelectedIndex = 0;
            this.CharacterComboBox.IsEnabled = true;
            this.battleTag = GetBattleTag();
#endif
        }

        private void ImportCharactersButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;

            // Convert the entered battle tag into the format needed by the D3 API
            this.battleTag = GetBattleTag();
            if (this.battleTag == null)
            {
                MessageBox.Show("Invalid BattleTag entered. Please enter in the format \"Elevarin#1192\"");
                return;
            }

            // Using the battle tag entered, retrieve hero names
            this._heroes = WebDataRetriever.GetHeroes(this.battleTag);

            // Clear our characters combo box
            this.CharacterComboBox.Items.Clear();

            // If we have an invalid heroes list, return to avoid exceptions
            if (_heroes == null || _heroes.Length <= 0)
            {
                return;
            }

            // Add each hero to the list of characters
            List<Hero> heroes = new List<Hero>();
            foreach (Hero hero in this._heroes)
            {
                heroes.Add(hero);
                this.CharacterComboBox.Items.Add(hero);
            }
            this._heroes = heroes.ToArray();

            // Set our selection to the first character on the account
            this.CharacterComboBox.SelectedIndex = 0;

            // Enable our ComboBox now that it has items in it
            this.CharacterComboBox.IsEnabled = true;

            this.Cursor = Cursors.Arrow;
        }

        private void ImportCharacterButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            Hero hero = this.CharacterComboBox.SelectedItem as Hero;

            Stopwatch watch = new Stopwatch();
            watch.Start();

            WebDataRetriever.GetDetailedHeroInformation(this.battleTag, ref hero);

            watch.Stop();
            TimeSpan ts = watch.Elapsed;

            this.Cursor = Cursors.Arrow;
        }

        private string GetBattleTag()
        {
            string[] tokens = this.BTagNameTextBox.Text.Split(new char[] { '#', '-' });
            if (tokens.Length != 2)
            {
                return null;
            }

            return tokens[0] + "-" + tokens[1];
        }
    }
}
