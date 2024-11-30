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

namespace Assignment3_TradingCards
{
    public partial class Form1 : Form
    {
        List<Football> players;
        Image img;
        ListViewItem TempItem;
        private bool drawBorder = true;  // boolean to control border visibility
        Pen borderPen = new Pen(Color.Black, 5); // default pen to draw border

        List<ListViewItem> deletedPlayers = new List<ListViewItem>(); // to store deleted players
        public Form1()
        {
            InitializeComponent();
            players = new List<Football>()
            {
                new Football { PlayerName = "Lionel Messi", Team = "Inter Miami", Photo = "messi.jpg", GoalsScored = 23, Height = 1.70f, Assists = 9, PassAccuracy = 86, Rating = 91 },
                new Football { PlayerName = "Cristiano Ronaldo", Team = "Al Nassr", Photo = "ronaldo.jpg", GoalsScored = 18, Height = 1.87f, Assists = 3, PassAccuracy = 80, Rating = 89 },
                new Football { PlayerName = "Kylian Mbappé", Team = "Real Madrid", Photo = "mbappe.jpg", GoalsScored = 28, Height = 1.78f, Assists = 5, PassAccuracy = 84, Rating = 91 },
                new Football { PlayerName = "Erling Haaland", Team = "Manchester City", Photo = "haaland.jpg", GoalsScored = 31, Height = 1.95f, Assists = 4, PassAccuracy = 79, Rating = 91 },
                new Football { PlayerName = "Kevin De Bruyne", Team = "Manchester City", Photo = "debruyne.jpg", GoalsScored = 10, Height = 1.80f, Assists = 15, PassAccuracy = 87, Rating = 90 },
                new Football { PlayerName = "Neymar Jr.", Team = "Al Hilal", Photo = "neymar.jpg", GoalsScored = 16, Height = 1.75f, Assists = 8, PassAccuracy = 83, Rating = 89 },
                new Football { PlayerName = "Mohamed Salah", Team = "Liverpool", Photo = "salah.jpg", GoalsScored = 26, Height = 1.75f, Assists = 9, PassAccuracy = 84, Rating = 90 },
                new Football { PlayerName = "Harry Kane", Team = "Bayern Munich", Photo = "kane.jpg", GoalsScored = 29, Height = 1.88f, Assists = 5, PassAccuracy = 82, Rating = 89 },
                new Football { PlayerName = "Robert Lewandowski", Team = "Barcelona", Photo = "lewandowski.jpg", GoalsScored = 30, Height = 1.85f, Assists = 4, PassAccuracy = 79, Rating = 90 },
                new Football { PlayerName = "Luka Modrić", Team = "Real Madrid", Photo = "modric.jpg", GoalsScored = 7, Height = 1.72f, Assists = 8, PassAccuracy = 90, Rating = 88 }
            };
        }

        private void FillTheData(IEnumerable<Football> list)
        {
            MainList.Items.Clear();
            foreach (var player in list)
            {
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
            List<Football> TempPlayersList = players;
            FillTheData(TempPlayersList);
            btn_GetData.Enabled = false;
            btn_Delete.Enabled = true;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            labelName.Visible = false;
            labelTeam.Visible = false;

            labelAssists.Visible = false;
            labelPassAccuracy.Visible = false;
            labelRating.Visible = false;
            labelGoalsScored.Visible = false;
            labelHeight.Visible = false;
            lbl_placeholder.Visible = false;
            btn_Delete.Enabled = false; // delete button does not work when program first start

        }



    }
}