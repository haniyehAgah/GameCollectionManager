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
    public partial class Form1 : Form
    {
        List<Game> games = new List<Game>();
        private void RefreshDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = games;
        }

        public Form1()
        {
            InitializeComponent();
            genereCombo.DataSource = Enum.GetValues(typeof(Genre));
            platformCombo.DataSource = Enum.GetValues(typeof(Platform));
            releaseYear.Maximum = DateTime.Now.Year;
            games = JsonService.Load();
            RefreshDataGrid();
            clearFields();
        }

        private void clearFields()
        {
            GameNameTXT.Clear();
            genereCombo.SelectedItem = -1;
            platformCombo.SelectedItem = -1;
            releaseYear.Value = releaseYear.Minimum;
            rating.Value = rating.Minimum;
            installCheck.Checked = false;
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
            };
            
            games.Add(game);
            JsonService.Save(games);
            clearFields();
            RefreshDataGrid();
        }

        private int selectindex = -1;

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("از پاک کردن این بازی مطمئن هستید؟", "بله", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (selectindex>=0 && selectindex<games.Count)
                {
                    games.RemoveAt(selectindex);
                    JsonService.Save(games);
                    clearFields();
                    RefreshDataGrid();
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
                RefreshDataGrid();
            }
            clearFields();
            JsonService.Save(games);
        }
    }

    public class Game
    {
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
