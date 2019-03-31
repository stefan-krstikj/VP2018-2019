using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezultati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Details<int, string> newDetails1 = new Details<int, string>();
            Details<int, string> newDetails2 = new Details<int, string>();
            Details<int, string> newDetails3 = new Details<int, string>();
            newDetails1.Key = 2;
            newDetails1.Value = "Player1";
            newDetails2.Key = 3;
            newDetails2.Value = "Player2";
            newDetails3.Key = 5;
            newDetails3.Value = "Player3";
            Basketball team1 = new Basketball();
            team1.gameDetails.Add(newDetails1);
            team1.gameDetails.Add(newDetails2);

            Basketball team2 = new Basketball();
            team2.gameDetails.Add(newDetails3);
            Game<Basketball> newGame = new Game<Basketball>("Barcelona", "Real M", 2, 1, team1, team2);
            boxBasketball.Items.Add(newGame);


        }

        public void addBasketballGame(Game<Basketball> game)
        {
            boxBasketball.Items.Add(game);
        }

        public void addFootballGame(Game<Football> game)
        {
            boxFootball.Items.Add(game);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            addMatch addMatchForm = new addMatch(this);
            if(addMatchForm.ShowDialog() == DialogResult.OK)
            {
                if(addMatchForm.type == "fudbal")
                {
                    boxFootball.Items.Add(addMatchForm.fGame);
                }
                else
                {
                    boxBasketball.Items.Add(addMatchForm.bGame);
                }
            }
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boxBasketball_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game<Basketball> selectedGame = (Game<Basketball>) boxBasketball.SelectedItem;
            txtHomeName.Text = selectedGame.homeTeam;
            txtAwayName.Text = selectedGame.visitorTeam;

            txtMatchDate.Text = selectedGame.date.ToString();
            txtResult.Text = String.Format("{0} : {1}", selectedGame.scoreHome, selectedGame.scoreVisitor);

            boxHomeStrelci.DataSource = selectedGame.detailsHome.gameDetails;
            boxAwayStrelci.DataSource = selectedGame.detailsVisitor.gameDetails;
        }

        private void boxFootball_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game<Football> selectedGame = (Game<Football>)boxFootball.SelectedItem;
            txtHomeName.Text = selectedGame.homeTeam;
            txtAwayName.Text = selectedGame.visitorTeam;

            txtMatchDate.Text = selectedGame.date.ToString();
            txtResult.Text = String.Format("{0} : {1}", selectedGame.scoreHome, selectedGame.scoreVisitor);

            boxHomeStrelci.DataSource = selectedGame.detailsHome.gameDetails;
            boxAwayStrelci.DataSource = selectedGame.detailsVisitor.gameDetails;
        }
    }

    public class Details<K, V>
    {
        // cuvame ime na igrac, so postignat rezultat
        public K Key { get; set; }
        public V Value { get; set; }

        public override string ToString()
        {
            return String.Format("{0} - {1}", Key.ToString(), Value.ToString());
        }
    }

    public class GameDetails<K, V>
    {
        // list aod site igraci so nivni rezultati
        public List<Details<K, V>> gameDetails { get; set; }
        
    }

    public class Football : GameDetails<string, string>
    {
        // klasa za fudbalska igra
        public Football()
        {
            this.gameDetails = new List<Details<string, string>>();
        }

    }

    public class Basketball : GameDetails<int, string>
    {
        // klasa za kosarkarska igra
        public Basketball()
        {
            this.gameDetails = new List<Details<int, string>>();
        }
    }

    public class Game<T>
    {
        // prima objekt od klasata Basketball ili Football.
        // vo T se cuva 'Basketball' ili 'Football'
    
        public string homeTeam;
        public string visitorTeam;
        public int scoreHome;
        public int scoreVisitor;
        public T detailsHome;
        public T detailsVisitor;
        public DateTime date;

        public Game(string homeT, string visitorT, int scoreH, int scoreV, T detailsH, T detailsV)
        {
            this.date = DateTime.MaxValue;
            this.homeTeam = homeT;
            this.visitorTeam = visitorT;
            this.scoreHome = scoreH;
            this.scoreVisitor = scoreV;
            this.detailsHome = detailsH;
            this.detailsVisitor = detailsV;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} : {2} {3}", homeTeam, scoreHome, scoreVisitor, visitorTeam);
        }
    }
}
