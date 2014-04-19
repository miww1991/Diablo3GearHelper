#define TESTING

using System.Windows;
using System.Collections.Generic;
using Diablo3GearHelper.Types;
using System.Diagnostics;
using System;
using System.Linq;
using System.Windows.Input;
using System.Windows.Controls;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Diablo3GearHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Hero[] _heroes;
        private Hero selectedHero;
        private string battleTag;

        private List<string> DPSStrings = new List<string>(new string[] { "Critical Hit Chance", "Critical Hit Damage", "Attack Speed", "Average Damage" });
        private readonly string[] EHPStrings = { "Vitality", "% Life", "Armor", "All Resistances" };

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
            this.ImportCharacterButton.IsEnabled = true;
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
            this.ImportCharacterButton.IsEnabled = true;

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

            if (this.selectedHero != null)
            {
                this.DPSStrings.Remove(this.selectedHero.PrimaryStatType.ToString());
            }
            this.DPSStrings.Insert(0, hero.PrimaryStatType.ToString());

            this.selectedHero = hero;
            this.Stat1.Items.Clear();
            foreach (string item in this.DPSStrings)
            {
                this.Stat1.Items.Add(item);
            }

            foreach (string item in this.EHPStrings)
            {
                this.Stat1.Items.Add(item);
            }

            this.Stat1.SelectedIndex = 0;
            this.Stat1.IsEnabled = true;
            this.Stat1Amount.IsEnabled = true;
            this.Stat2.IsEnabled = true;
            this.Stat2Amount.IsEnabled = true;

            this.Cursor = Cursors.Arrow;
        }

        private void DPSEnchantButton_OnClick(object sender, RoutedEventArgs e)
        {
            Item item = this.ItemComboBox.SelectedItem as Item;
        }

        private void Stat1Amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (!((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Decimal || e.Key == Key.OemPeriod))
            {
                e.Handled = true;
            }
            else
            {
                TextBox textBox = sender as TextBox;
                int idx = textBox.SelectionStart;
                int percentIdx = textBox.Text.IndexOf('%');

                if (percentIdx >= 0 && idx > percentIdx)
                {
                    e.Handled = true;
                }
            }
        }

        private void Stat1Amount_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            int idx = textBox.SelectionStart;
            int percentIdx = textBox.Text.IndexOf('%');

            if (e.Key == Key.Delete)
            {
                if (idx == percentIdx)
                {
                    e.Handled = true;
                }
            }
            else if (e.Key == Key.Back)
            {
                if (idx == percentIdx + 1)
                {
                    e.Handled = true;
                }
            }
        }

        private void Stat1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox textBox = sender as ComboBox;

            if (textBox.SelectedItem != null)
            {
                this.Stat2.Items.Clear();

                string selectedItem = (string)textBox.SelectedItem;

                if (this.DPSStrings.Contains(selectedItem))
                {
                    foreach (string item in this.DPSStrings.Where(s => s != selectedItem))
                    {
                        this.Stat2.Items.Add(item);
                    }
                }
                else
                {
                    Debug.Assert(this.EHPStrings.Contains(selectedItem));

                    foreach (string item in this.EHPStrings.Where(s => s != selectedItem))
                    {
                        this.Stat2.Items.Add(item);
                    }
                }

                if (selectedItem == "Critical Hit Chance"
                 || selectedItem == "Critical Hit Damage"
                 || selectedItem == "Attack Speed"
                 || selectedItem == "% Life")
                {
                    if (!this.Stat1Amount.Text.Contains('%'))
                    {
                        this.Stat1Amount.Text += '%';
                    }
                }

                this.Stat2.SelectedIndex = 0;
            }
        }

        private void Stat1Amount_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tBox = sender as TextBox;

            UpdateStatEquivalencies();
        }

        private void Stat2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedItem = comboBox.Items[comboBox.SelectedIndex];
                UpdateStatEquivalencies();
            }
        }

        // Helper method
        private string GetBattleTag()
        {
            string[] tokens = this.BTagNameTextBox.Text.Split(new char[] { '#', '-' });
            if (tokens.Length != 2)
            {
                return null;
            }

            return tokens[0] + "-" + tokens[1];
        }

        // Helper method
        private AffixType StringToAffix(string stringToConvert)
        {
            AffixType retValue;

            stringToConvert = stringToConvert.Replace("%", "Percent");
            stringToConvert = stringToConvert.Replace(" ", "");
            bool success = Enum.TryParse<AffixType>(stringToConvert, out retValue);

            if (success)
            {
                return retValue;
            }
            else
            {
                return AffixType.InvalidAffix;
            }
        }

        // Helper method
        private void UpdateStatEquivalencies()
        {
            float result = 0.0f;
            string textToParse = this.Stat1Amount.Text.Replace("%", "");
            bool canParse = float.TryParse(textToParse, out result);

            if (canParse && this.Stat2.SelectedItem != null)
            {
                AffixType affix1 = this.StringToAffix((string)this.Stat1.SelectedItem);
                AffixType affix2 = this.StringToAffix((string)this.Stat2.SelectedItem);

                float weight1 = this.selectedHero.CalculateStatWeight(affix1);
                float weight2 = this.selectedHero.CalculateStatWeight(affix2);

                float multiplier = (weight2 / weight1) / result;

                float displayNum = (float)Math.Round(1 / multiplier, 2);
                string selectedItem = this.Stat2.SelectedItem as string;

                if (selectedItem == "Critical Hit Chance"
                 || selectedItem == "Critical Hit Damage"
                 || selectedItem == "Attack Speed"
                 || selectedItem == "% Life")
                {
                    this.Stat2Amount.Text = displayNum.ToString() + "%";
                }
                else
                {
                    this.Stat2Amount.Text = displayNum.ToString();
                }
            }
            else
            {
                this.Stat2Amount.Text = "";
            }
        }
    }
}
