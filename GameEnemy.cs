using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class GameEnemy : GameObject
    {


        public GameEnemy(Image ghostImage, GameObjectType enemyType)
            : base(enemyType, ghostImage)
        {
        }

        public abstract GameCell nextCell();

        public abstract void move(GameCell gameCell);
        public abstract void generateBullet();

        public abstract void moveBullets();

    }
}
