using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameCollectionManager
{
    using System.Linq;
    public partial class Form1 : Form
    {
        List<Game> games = new List<Game>();
        private void RefreshDataGrid()
        {
            var result = games.AsEnumerable();
            //Search
            if(!string.IsNullOrWhiteSpace(searchTXT.Text))
            {
                result = result.Where(g => g.Name.ToLower().Contains(searchTXT.Text.ToLower()));
            }
            //Filter
            if(genreFilterCombo.SelectedIndex>0)
            {
                result = result.Where(g => g.genre.ToString() == genreFilterCombo.Text);
            }
            //Sort
            switch(sortCombo.Text)
            {
                case "Name":
                    result = result.OrderBy(g => g.Name);
                    break;
                case "Release Year":
                    result = result.OrderByDescending(g => g.ReleaseYear);
                    break;
                case "Rating":
                    result = result.OrderByDescending(g => g.Rating);
                    break;
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result.ToList();
        }

        public Form1()
        {
            InitializeComponent();
            //Filter
            genreFilterCombo.Items.Clear();
            genreFilterCombo.Items.Add("All genre");
            genreFilterCombo.Items.Add("Action");
            genreFilterCombo.Items.Add("Adventure");
            genreFilterCombo.Items.Add("RPG");
            genreFilterCombo.Items.Add("Strategy");
            genreFilterCombo.Items.Add("Shooter");
            genreFilterCombo.Items.Add("Horror");
            genreFilterCombo.Items.Add("Sport");
            genreFilterCombo.Items.Add("BattleRoyale");
            genreFilterCombo.Items.Add("puzzle");
            genreFilterCombo.Items.Add("Rhythm");
            //Sort
            sortCombo.Items.Clear();
            sortCombo.Items.Add("None");
            sortCombo.Items.Add("Name");
            sortCombo.Items.Add("Release Year");
            sortCombo.Items.Add("Rating");

            genereCombo.DataSource = Enum.GetValues(typeof(Genre));
            platformCombo.DataSource = Enum.GetValues(typeof(Platform));
            releaseYear.Maximum = DateTime.Now.Year;
            games = JsonService.Load();
            RefreshDataGrid();
            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            tatalLbl.Text = "Tatal Game : " + games.Count;

            int installed = games.Count(g => g.Installed);
            installedLbl.Text = "Installed : " + installed;

            if (games.Count>0)
            {
                averegeLbl.Text = "Averege Rating : " + games.Average(g => g.Rating).ToString("0.0");
            }
            else
            {
                averegeLbl.Text = "Averege Rating : 0";
            }

            if(games.Count>0)
            {
                Game newest = games.OrderByDescending(g => g.ReleaseYear).First();
                newestLbl.Text = "Newest Game : " + newest.Name;
            }
            else
            {
                newestLbl.Text = "Newest Game : -";
            }
        }

        private void clearFields()
        {
            GameNameTXT.Clear();
            genereCombo.SelectedItem = -1;
            platformCombo.SelectedItem = -1;
            releaseYear.Value = releaseYear.Minimum;
            rating.Value = rating.Minimum;
            installCheck.Checked = false;
            favoriteCheck.Checked = false;
            genereCombo.SelectedItem = null;
            platformCombo.SelectedItem = null;
            dataGridView1.ClearSelection();
            GameNameTXT.Focus();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GameNameTXT.Text))
            {
                MessageBox.Show("نام بازی را وارد کنید.");
                return;
            }

            Game game = new Game
            {
                Name = GameNameTXT.Text,
                genre = (Genre)genereCombo.SelectedItem,
                platform = (Platform)platformCombo.SelectedItem,
                ReleaseYear = (int)releaseYear.Value,
                Rating = (int)rating.Value,
                Installed = installCheck.Checked,
                IsFavorite = favoriteCheck.Checked,
            };
            
            games.Add(game);
            JsonService.Save(games);
            clearFields();
            RefreshDataGrid();
            UpdateStatistics();
        }

        private int selectindex = -1;

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count==0)
            {
                MessageBox.Show("لطفا اول یک بازی را انتخاب کنید");
                return;
            }

            DialogResult result = MessageBox.Show("از پاک کردن این بازی مطمئن هستید؟", "بله", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (selectindex>=0 && selectindex<games.Count)
                {
                    games.RemoveAt(selectindex);
                    JsonService.Save(games);
                    clearFields();
                    RefreshDataGrid();
                    UpdateStatistics();
                    selectindex = -1;
                }
                else
                {
                    MessageBox.Show("ابتدا یک بازی انتخاب کنید.");
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                selectindex = e.RowIndex;
                GameNameTXT.Text = games[selectindex].Name;
                genereCombo.SelectedItem = games[selectindex].genre;
                platformCombo.SelectedItem = games[selectindex].platform;
                releaseYear.Value = games[selectindex].ReleaseYear;
                rating.Value = games[selectindex].Rating;
                installCheck.Checked = games[selectindex].Installed;
                favoriteCheck.Checked = games[selectindex].IsFavorite;
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (selectindex!=-1)
            {
                games[selectindex].Name = GameNameTXT.Text;
                games[selectindex].genre = (Genre)genereCombo.SelectedItem;
                games[selectindex].platform = (Platform)platformCombo.SelectedItem;
                games[selectindex].ReleaseYear = (int)releaseYear.Value;
                games[selectindex].Rating = (int)rating.Value;
                games[selectindex].Installed = installCheck.Checked;
                games[selectindex].IsFavorite = favoriteCheck.Checked;
                RefreshDataGrid();
                UpdateStatistics();
            }
            clearFields();
            JsonService.Save(games);
        }

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void GenreFilterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void SortCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            clearFields();
        }
    }

    public class Game
    {
        public bool IsFavorite { get; set; }
        public string Name { get; set; }
        public Genre genre { get; set; }
        public Platform platform { get; set; }
        public int ReleaseYear { get; set; }
        public int Rating { get; set; }
        public bool Installed { get; set; }
    }

    public enum Genre
    {
        Action,
        Adventure,
        RPG,
        Strategy,
        Shooter,
        Horror,
        Sport,
        BattleRoyale,
        puzzle,
        Rhythm
    }

    public enum Platform
    {
        PC,
        PlayStation,
        Xbox,
        NintendoSwitch,
        Mobile
    }


}
