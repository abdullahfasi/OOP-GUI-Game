using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class SmartPlayer : GameEnemy
    {
        public int herohealth = 20;
        private GameDirection direction = GameDirection.Down;
        public static Random random;
        List<Bullet> bullets;
        public SmartPlayer(Image ghostImage, GameCell startCell) : base(ghostImage, GameObjectType.SMARTENEMY)
        {
            base.CurrentCell = startCell;
            bullets = new List<Bullet>();
        }

        public override void move(GameCell gameCell)
        {
            if (base.CurrentCell != null)
            {
                base.CurrentCell.setGameObject(ImageProvider.getBlankGameObject());
            }

            base.CurrentCell = gameCell;
        }

        public override GameCell nextCell()
        {
            int value = generateRandomNumber();
            if (value == 0)
            {
                direction = GameDirection.Right;
            }
            else if (value == 1)
            {
                direction = GameDirection.Left;
            }
            else if (value == 2)
            {
                direction = GameDirection.Up;
            }
            else if (value == 3)
            {
                direction = GameDirection.Down;
            }
            GameCell gameCell = base.CurrentCell;
            GameCell gameCell2 = base.CurrentCell.nextCell(direction);
            return gameCell2;
        }
        public int generateRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(4);
        }
        public override void generateBullet()
        {
            Bullet bullet = new Bullet(ImageProvider.getSmartBulletImage(), this.CurrentCell.nextCell(GameDirection.Right));
            bullets.Add(bullet);
        }

        public override void moveBullets()
        {
            for (int i = 0; i < bullets.Count; i++)
            {
                if (bullets[i].CurrentCell == bullets[i].nextCell(GameDirection.Right))
                {
                    GameCell currentCell = this.CurrentCell;
                    bullets[i].CurrentCell.setGameObject(ImageProvider.getBlankGameObject());
                    bullets.RemoveAt(i);
                }
                else if (bullets[i].nextCell(GameDirection.Right).CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {
                    GameGrid.decreasePlayerHealth(1);
                    bullets[i].CurrentCell.setGameObject(ImageProvider.getBlankGameObject());
                    bullets.RemoveAt(i);
                 
                }
                else
                {
                    bullets[i].move(bullets[i].nextCell(GameDirection.Right));
                }
            }
        }
    }
}
