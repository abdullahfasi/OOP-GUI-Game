using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class HorizontalPlayer : GameEnemy
    {
        public int herohealth = 20;
        GameDirection direction = GameDirection.Left;
        List<Bullet> bullets;
        public HorizontalPlayer(Image ghostImage, GameCell startCell) : base(ghostImage, GameObjectType.HORIZONTALENEMY)
        {
            base.CurrentCell = startCell;
            bullets = new List<Bullet>();
        }

        public override void move(GameCell gameCell)
        {
            if (this.CurrentCell != null)
            {
                this.CurrentCell.setGameObject(ImageProvider.getBlankGameObject());

            }
            CurrentCell = gameCell;
        }

        public override GameCell nextCell()
        {

            GameCell nextCell = this.CurrentCell;

            GameCell potentialNextCell = this.CurrentCell.nextCell(direction);

            if (potentialNextCell == nextCell)
            {
                if (direction == GameDirection.Left)
                {
                    direction = GameDirection.Right;
                }
                else if (direction == GameDirection.Right)
                {
                    direction = GameDirection.Left;
                }
            }
            else
            {
                nextCell = potentialNextCell;
            }
            return nextCell;

        }
        public override void generateBullet()
        {
            Bullet bullet = new Bullet(ImageProvider.getHorizontalBulletImage(), this.CurrentCell.nextCell(GameDirection.Up));
            bullets.Add(bullet);
        }
        public override void moveBullets()
        {

            for (int i = 0; i < bullets.Count; i++)
            {
                if (bullets[i].CurrentCell == bullets[i].nextCell(GameDirection.Up))
                {
                    GameCell currentCell = this.CurrentCell;
                    bullets[i].CurrentCell.setGameObject(ImageProvider.getBlankGameObject());
                    bullets.RemoveAt(i);
                }
                else if (bullets[i].nextCell(GameDirection.Up).CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {
                    GameGrid.decreasePlayerHealth(1);
                    bullets[i].CurrentCell.setGameObject(ImageProvider.getBlankGameObject());
                    bullets.RemoveAt(i);
                }
                else
                {
                    bullets[i].move(bullets[i].nextCell(GameDirection.Up));
                }
            }
        }
    }
}
