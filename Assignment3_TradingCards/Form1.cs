using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment3_TradingCards
{
    public partial class Form1 : Form
    {
        List<Football> players;
        Image img;
        private ListViewItem deletedItem = null;
        public Form1()
        {
            InitializeComponent();
            players = new List<Football>()
            {
                new Football { PlayerName = "Lionel Messi", Team = "Inter Miami", Photo = "messi.jpg", GoalsScored = "Goals " + 23, Height = "Height " +1.70, Assists = "Assists " +9, PassAccuracy = "PassAccuracy: " + 86, Rating = "Rating " +91 },
                new Football { PlayerName = "Cristiano Ronaldo", Team = "Al Nassr", Photo = "ronaldo.jpg", GoalsScored = "Goals "+18, Height = "Height " +1.87, Assists = "Assists " +3, PassAccuracy = "PassAccuracy: " +80, Rating = "Rating " +89 },
                new Football { PlayerName = "Kylian Mbappé", Team = "Paris Saint-Germain", Photo = "mbappe.jpg", GoalsScored = "Goals "+28, Height = "Height " +1.78, Assists = "Assists " +5, PassAccuracy = "PassAccuracy: " +  84, Rating = "Rating " +91 },
                new Football { PlayerName = "Erling Haaland", Team = "Manchester City", Photo = "haaland.jpg", GoalsScored = "Goals "+31, Height = "Height " +1.95, Assists = "Assists " +4, PassAccuracy ="PassAccuracy: " + 79, Rating = "Rating " +91 },
                new Football { PlayerName = "Kevin De Bruyne", Team = "Manchester City", Photo = "debruyne.jpg", GoalsScored ="Goals "+ 10, Height = "Height " +1.80, Assists = "Assists " +15, PassAccuracy ="PassAccuracy: " + 87, Rating = "Rating " +90 },
                new Football { PlayerName = "Neymar Jr.", Team = "Al Hilal", Photo = "neymar.jpg", GoalsScored = "Goals "+16, Height = "Height " +1.75, Assists = "Assists " +8, PassAccuracy = "PassAccuracy: " +83, Rating ="Rating " + 89 },
                new Football { PlayerName = "Mohamed Salah", Team = "Liverpool", Photo = "salah.jpg", GoalsScored = "Goals "+26, Height = "Height " +1.75, Assists = "Assists " +9, PassAccuracy = "PassAccuracy: " + 84, Rating = "Rating " +90 },
                new Football { PlayerName = "Harry Kane", Team = "Bayern Munich", Photo = "kane.jpg", GoalsScored = "Goals "+29, Height = "Height " +1.88, Assists = "Assists " +5, PassAccuracy = "PassAccuracy: " +82, Rating = "Rating " +89 },
                new Football { PlayerName = "Robert Lewandowski", Team = "Barcelona", Photo = "lewandowski.jpg", GoalsScored = "Goals "+30, Height = "Height " +1.85, Assists = "Assists " +4, PassAccuracy = "PassAccuracy: " + 79, Rating = "Rating " +90 },
                new Football { PlayerName = "Luka Modrić", Team = "Real Madrid", Photo = "modric.jpg", GoalsScored = "Goals "+7, Height ="Height " + 1.72, Assists = "Assists " + 8, PassAccuracy = "PassAccuracy: " + 90, Rating = "Rating " + 88 }

            };           
        }

        private void FillTheData(IEnumerable<Football> list)
        {
            MainList.Items.Clear();
            foreach (var player in list)
            {
                //MessageBox.Show(house.PostalCode, house.Id.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListViewItem item = new ListViewItem(player.PlayerName);

                item.SubItems.Add(player.Team);
                
                item.SubItems.Add(player.GoalsScored.ToString());
                item.SubItems.Add(player.Height.ToString());
                item.SubItems.Add(player.Assists.ToString());
                item.SubItems.Add(player.PassAccuracy.ToString());
                item.SubItems.Add(player.Rating.ToString());
                item.SubItems.Add(player.Photo);
                MainList.Items.Add(item);
                
            }
        }

       
        private void btn_GetData_Click(object sender, EventArgs e)
        {
            FillTheData(players);
        }


        private void MainList_Selected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (MainList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = MainList.SelectedItems[0];
                labelName.Text = selectedItem.SubItems[0].Text; // Update the label with the player's name
                labelTeam.Text = selectedItem.SubItems[1].Text;
                string imagePath = Path.Combine("Images", selectedItem.SubItems[7].Text);
                img = Image.FromFile(imagePath);
                pictureBox.Image = img;
                labelGoalsScored.Text = selectedItem.SubItems[2].Text;
                labelHeight.Text = selectedItem.SubItems[3].Text;
                labelAssists.Text = selectedItem.SubItems[4].Text;
                labelPassAccuracy.Text = selectedItem.SubItems[5].Text;
                labelRating.Text = selectedItem.SubItems[6].Text;
            }
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image = null;
                pictureBox.BackColor = Color.DarkSlateBlue;
                labelName.Visible = false;
                labelTeam.Visible = false;
                labelAssists.Visible = true;
                labelPassAccuracy.Visible = true;
                labelRating.Visible = true;
                labelGoalsScored.Visible = true;
                labelHeight.Visible = true;
            }

            else
            {
                ListViewItem selectedItem = MainList.SelectedItems[0];
                labelName.Text = selectedItem.SubItems[0].Text; // Update the label with the player's name
                labelTeam.Text = selectedItem.SubItems[1].Text;
                string imagePath = Path.Combine("Images", selectedItem.SubItems[7].Text);
                img = Image.FromFile(imagePath);
                pictureBox.Image = img;
                labelName.Visible = true;
                labelTeam.Visible = true;
                labelAssists.Visible = false;
                labelPassAccuracy.Visible = false;
                labelRating.Visible = false;
                labelGoalsScored.Visible = false;
                labelHeight.Visible = false;

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(MainList.SelectedItems.Count > 0)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            labelAssists.Visible = false;
            labelPassAccuracy.Visible = false;
            labelRating.Visible = false;
            labelGoalsScored.Visible = false;
            labelHeight.Visible = false;
        }
    }
}

//Ask pedro what he means by you can be able to remove or add through ui