using EZInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        GameHero hero;
        VerticalPlayer vertical;
        HorizontalPlayer horizontal;
        SmartPlayer smart;
        List<GameEnemy> playerList;
        public int herohealth ;
        int timer = 0;
        public Form1()
        {
            InitializeComponent();
            playerList = new List<GameEnemy>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameGrid grid = new GameGrid("maze1.txt", 17, 38);
            printMaze(grid);
            GameCell cell = grid.getCell(6, 10);
            hero = new GameHero(ImageProvider.getHeroImage(), cell);
            vertical = new VerticalPlayer(ImageProvider.getVerticalPlayerImage(), grid.getCell(8, 35));
            horizontal = new HorizontalPlayer(ImageProvider.getHorizontalPlayerImage(), grid.getCell(15, 15));
            smart = new SmartPlayer(ImageProvider.getSmartPlayerImage(), grid.getCell(2, 4));
            playerList.Add(vertical);
            playerList.Add(horizontal);
            playerList.Add(smart);
        }

        private void printMaze(GameGrid grid)
        {
            for (int i = 0; i < grid.Rows; i++)
            {
                for (int j = 0; j < grid.Cols; j++)
                {
                    GameCell cell = grid.getCell(i, j);
                    this.Controls.Add(cell.PictureBox);
                }
            }
        }


        private void repeater_Tick(object sender, EventArgs e)
        {

            GameCell potentialNewCell = hero.CurrentCell;
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                potentialNewCell = hero.CurrentCell.nextCell(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                potentialNewCell = hero.CurrentCell.nextCell(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                potentialNewCell = hero.CurrentCell.nextCell(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                potentialNewCell = hero.CurrentCell.nextCell(GameDirection.Down);
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                hero.generateBullet();
            }
            GameCell currentCell = hero.CurrentCell;
            currentCell.setGameObject(ImageProvider.getBlankGameObject());
            hero.move(potentialNewCell);



            hero.moveBullets();
            scorelabel.Text = GameGrid.getScore().ToString();
            verticalhealth.Text = GameGrid.getVerticalEnemyHealth().ToString();
            horizontalhealth.Text = GameGrid.getHorizontalEnemyHealth().ToString();
            randomhealth.Text = GameGrid.getRandomEnemyHealth().ToString();

            if (scorelabel.Text == 25.ToString()) 
            {
                MessageBox.Show("You Won..");
                this.Close();
                Form moreForm = new firstform();
                moreForm.Show();
            }
            if (verticalhealth.Text == 0.ToString())
            {
                playerList.Remove(vertical);
            }
            if (horizontalhealth.Text == 0.ToString())
            {
                playerList.Remove(horizontal);
            }
            if (randomhealth.Text == 0.ToString())
            {
                playerList.Remove(smart);
            }
            if (randomhealth.Text == 0.ToString() && horizontalhealth.Text == 0.ToString() && randomhealth.Text == 0.ToString())
            {
                MessageBox.Show("You Won..");
                this.Close();
                Form moreForm = new firstform();
                moreForm.Show();
            }
                foreach (var x in playerList)
            {
                x.move(x.nextCell());
            }

                timer++;
        }


        private void playerbulletloop_Tick(object sender, EventArgs e)
        {



            foreach (var x in playerList)
            {
                if (timer % 10 == 0)
                {
                    x.generateBullet();
                }
                x.moveBullets();

                herolbl.Text = GameGrid.getPlayerHealth().ToString();
                if (herolabel.Text == 0.ToString())
                {
                    MessageBox.Show("You Loss..");
                    this.Close();
                    Form moreForm = new firstform();
                    moreForm.Show();
                }


            }
            timer++;
        }


    }
}
