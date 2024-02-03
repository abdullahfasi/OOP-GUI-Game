using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Game
{
    class GameGrid
    {
        private static int score = 0;

        private static int playerHealth = 20;

        private static int horizontalEnemyHealth = 10;

        private static int verticalEnemyHealth = 10;

        private static int randomEnemyHealth = 10;
        private GameCell[,] cells;

        private int rows;

        private int cols;

        public int Rows
        {
            get
            {
                return rows;
            }
            set
            {
                rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return cols;
            }
            set
            {
                cols = value;
            }
        }

        public GameGrid(string fileName, int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            cells = new GameCell[rows, cols];
            loadGrid(fileName);
        }

        public GameCell getCell(int x, int y)
        {
            return cells[x, y];
        }

        private void loadGrid(string fileName)
        {
            StreamReader streamReader = new StreamReader(fileName);
            for (int i = 0; i < rows; i++)
            {
                string text = streamReader.ReadLine();
                for (int j = 0; j < cols; j++)
                {
                    GameCell gameCell = new GameCell(i, j, this);
                    char displayCharacter = text[j];
                    GameObjectType gameObjectType = GameObject.getGameObjectType(displayCharacter);
                    Image gameObjectImage = ImageProvider.getGameObjectImage(displayCharacter);
                    GameObject gameObject = new GameObject(gameObjectType, gameObjectImage);
                    gameCell.setGameObject(gameObject);
                    cells[i, j] = gameCell;
                }
            }

            streamReader.Close();
        }
        public static int getScore()
        {
            return score;
        }

        public static int getPlayerHealth()
        {
            return playerHealth;
        }

        public static int getHorizontalEnemyHealth()
        {
            return horizontalEnemyHealth;
        }
        public static int getVerticalEnemyHealth()
        {
            return verticalEnemyHealth;
        }
        public static  int getRandomEnemyHealth()
        {
            return randomEnemyHealth;
        }
        public static void addScore(int increment)
        {
            score += increment;
        }

        public static void decreasePlayerHealth(int decrement)
        {
            playerHealth -= decrement;
        }

        public static void decreaseHorizontalEnemyHealth(int decrement)
        {
            horizontalEnemyHealth -= decrement;
        }

        public static void decreaseVerticalEnemyHealth(int decrement)
        {
            verticalEnemyHealth -= decrement;
        }

        public static void decreaseRandomEnemyHealth(int decrement)
        {
            randomEnemyHealth -= decrement;
        }
    }
}
