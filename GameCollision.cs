using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameCollision
    {
        public static bool isPlayerBulletCollideWithEnemy(GameCell potentialCell)
        {
            bool flag = false;
            if (potentialCell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
            {
                flag = true;
            }
            return flag;
        }
        public static bool isPlayerBulletCollideWithHorizontalEnemy(GameCell potentialCell)
        {
            bool flag = false;
            if (potentialCell.CurrentGameObject.GameObjectType == GameObjectType.HORIZONTALENEMY)
            {
                flag = true;
            }
            return flag;
        }
        public static bool isPlayerBulletCollideWithVerticalEnemy(GameCell potentialCell)
        {
            bool flag = false;
            if (potentialCell.CurrentGameObject.GameObjectType == GameObjectType.VERTICALENEMY)
            {
                flag = true;
            }
            return flag;
        }
        public static bool isPlayerBulletCollideWithRandomEnemy(GameCell potentialCell)
        {
            bool flag = false;
            if (potentialCell.CurrentGameObject.GameObjectType == GameObjectType.SMARTENEMY)
            {
                flag = true;
            }
            return flag;
        }
    }
}
