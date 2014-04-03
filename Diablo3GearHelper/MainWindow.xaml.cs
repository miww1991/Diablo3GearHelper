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
        public MainWindow()
        {
            InitializeComponent();
        }

#region Event Handlers
        private void IdentifyButton_OnClick(object sender, RoutedEventArgs e)
        {
            string battleTag = GetBattleTag();
            if (battleTag == null)
            {
                MessageBox.Show("Invalid BattleTag entered. Please in the format \"Sandra#1192\"");
                return;
            }

            Hero[] heroes = WebDataRetriever.GetHeroes(battleTag);
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
