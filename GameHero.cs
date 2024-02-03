using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameHero : GameObject
    {
        public static List<Bullet> bullets;
        public GameHero(Image image, GameCell startCell)
            : base(GameObjectType.PLAYER, image)
        {
            base.CurrentCell = startCell;
            bullets = new List<Bullet>();
        }

        public void move(GameCell gameCell)
        {
            base.CurrentCell = gameCell;
        }

        public void moveBullets()
        {

            for (int i = 0; i < bullets.Count; i++)
            {
                if (bullets[i].CurrentCell == bullets[i].nextCell(GameDirection.Right))
                {
                    bullets[i].CurrentCell.setGameObject(ImageProvider.getBlankGameObject());
                    bullets.RemoveAt(i);
                }
                else if(GameCollision.isPlayerBulletCollideWithHorizontalEnemy(bullets[i].nextCell(GameDirection.Right)))
                {
                    GameGrid.addScore(1);
                    GameGrid.decreaseHorizontalEnemyHealth(1);
                    bullets[i].CurrentCell.setGameObject(ImageProvider.getBlankGameObject());
                    bullets.RemoveAt(i);
                }
                else if (GameCollision.isPlayerBulletCollideWithVerticalEnemy(bullets[i].nextCell(GameDirection.Right)))
                {
                    GameGrid.addScore(1);
                    GameGrid.decreaseVerticalEnemyHealth(1);
                    bullets[i].CurrentCell.setGameObject(ImageProvider.getBlankGameObject());
                    bullets.RemoveAt(i);
                }
                else if (GameCollision.isPlayerBulletCollideWithRandomEnemy(bullets[i].nextCell(GameDirection.Right)))
                {
                    GameGrid.addScore(1);
                    GameGrid.decreaseRandomEnemyHealth(1);
                    bullets[i].CurrentCell.setGameObject(ImageProvider.getBlankGameObject());
                    bullets.RemoveAt(i);
                }

                else
                {
                    bullets[i].move(bullets[i].nextCell(GameDirection.Right));
                }

            }
        }

        public void generateBullet()
        {
            Bullet bullet = new Bullet(ImageProvider.getHeroBulletImage(), this.CurrentCell.nextCell(GameDirection.Right));
            bullets.Add(bullet);
        }
    }
}
