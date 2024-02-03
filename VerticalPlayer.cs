using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class VerticalPlayer : GameEnemy
    {
        public int herohealth = 20;
        private GameDirection direction = GameDirection.Down;
        List<Bullet> bullets;
        public VerticalPlayer(Image ghostImage, GameCell startCell) : base(ghostImage, GameObjectType.VERTICALENEMY)
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
            GameCell gameCell = base.CurrentCell;
            GameCell gameCell2 = base.CurrentCell.nextCell(direction);
            if (gameCell2 == gameCell)
            {
                if (direction == GameDirection.Up)
                {
                    direction = GameDirection.Down;
                }
                else if (direction == GameDirection.Down)
                {
                    direction = GameDirection.Up;
                }
            }
            else
            {
                gameCell = gameCell2;
            }

            return gameCell;
        }

        public override void generateBullet()
        {
            Bullet bullet = new Bullet(ImageProvider.getVerticalBulletImage(), this.CurrentCell.nextCell(GameDirection.Left));
            bullets.Add(bullet);
        }

        public override void moveBullets()
        {

            for (int i = 0; i < bullets.Count; i++)
            {
                if (bullets[i].CurrentCell == bullets[i].nextCell(GameDirection.Left))
                {
                    GameCell currentCell = this.CurrentCell;
                    bullets[i].CurrentCell.setGameObject(ImageProvider.getBlankGameObject());
                    bullets.RemoveAt(i);
                }
                else if(bullets[i].nextCell(GameDirection.Left).CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {
                    GameGrid.decreasePlayerHealth(1);
                    bullets[i].CurrentCell.setGameObject(ImageProvider.getBlankGameObject());
                    bullets.RemoveAt(i);                  
                }
                else
                {
                    bullets[i].move(bullets[i].nextCell(GameDirection.Left));
                }
            }
        }
}
}
