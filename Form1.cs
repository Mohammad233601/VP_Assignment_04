using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF_Cricket_team_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PlayerRoster = new ObservableCollection<string>();

         
            PlayerListBox.ItemsSource = PlayerRoster;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PlayerListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a player to remove.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

          
            string selectedPlayer = PlayerListBox.SelectedItem.ToString();
            PlayerRoster.Remove(selectedPlayer);
            MessageBox.Show($"Player '{selectedPlayer}' removed successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerName = PlayerNameTextBox.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(playerName))
            {
                MessageBox.Show("Player name cannot be empty.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (PlayerRoster.Contains(playerName))
            {
                MessageBox.Show("Player name already exists in the roster.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            
            PlayerRoster.Add(playerName);
            MessageBox.Show($"Player '{playerName}' added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            
            PlayerNameTextBox.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
}
