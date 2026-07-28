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
        private void dataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = games;
        }

        public Form1()
        {
            InitializeComponent();
            genereCombo.DataSource = Enum.GetValues(typeof(Gener));
            platformCombo.DataSource = Enum.GetValues(typeof(platForm));
            releaseYear.Maximum = DateTime.Now.Year;
            games = JsonService.Load();
            dataGrid();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Name = GameNameTXT.Text;
            game.gener = (Gener)genereCombo.SelectedItem;
            game.platform = (platForm)platformCombo.SelectedItem;
            game.releaseYear = (int)releaseYear.Value;
            game.rating = (int)rating.Value;
            game.installed = installCheck.Checked;

            games.Add(game);
            JsonService.Save(games);
            dataGrid();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!= null)
            {
                int index = dataGridView1.CurrentRow.Index;
                games.RemoveAt(index);
                dataGrid();
            }
            JsonService.Save(games);
        }

        private int selectindex = -1;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                selectindex = e.RowIndex;
                GameNameTXT.Text = games[selectindex].Name;
                genereCombo.SelectedItem = games[selectindex].gener;
                platformCombo.SelectedItem = games[selectindex].platform;
                releaseYear.Value = games[selectindex].releaseYear;
                rating.Value = games[selectindex].rating;
                installCheck.Checked = games[selectindex].installed;
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (selectindex!=-1)
            {
                games[selectindex].Name = GameNameTXT.Text;
                games[selectindex].gener = (Gener)genereCombo.SelectedItem;
                games[selectindex].platform = (platForm)platformCombo.SelectedItem;
                games[selectindex].releaseYear = (int)releaseYear.Value;
                games[selectindex].rating = (int)rating.Value;
                games[selectindex].installed = installCheck.Checked;
                dataGrid();
            }
            JsonService.Save(games);
        }
    }

    public class Game
    {
        public string Name { get; set; }
        public Gener gener { get; set; }
        public platForm platform { get; set; }
        public int releaseYear { get; set; }
        public int rating { get; set; }
        public bool installed { get; set; }
    }

    public enum Gener
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

    public enum platForm
    {
        PC,
        PlayStation,
        Xbox,
        NintendoSwitch,
        Mobile
    }


}
