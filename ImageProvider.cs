using Game.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class ImageProvider
    {
        public static GameObject getBlankGameObject()
        {
            return new GameObject(GameObjectType.NONE, Resources.simplebox);
        }
        public static Image getHeroImage()
        {
            return Resources.Hero;
        }
        public static Image getVerticalPlayerImage()
        {
            return Resources.verticalplayer;
        }
        public static Image getHorizontalPlayerImage()
        {
            return Resources.horizontalplayer;
        }
        public static Image getSmartPlayerImage()
        {
            return Resources.smartplayer;
        }

        public static Image getHeroBulletImage()
        {
            return Resources.herofire;
        }
        public static Image getHorizontalBulletImage()
        {
            return Resources.horizontalfire;
        }
        public static Image getVerticalBulletImage()
        {
            return Resources.verticalfire;
        }
        public static Image getSmartBulletImage()
        {
            return Resources.smartfire;
        }

        public static Image getGameObjectImage(char displayCharacter)
        {
            Image result = Resources.simplebox;
            if (displayCharacter == '|' || displayCharacter == '%')
            {
                result = Resources.vertical;
            }

            if (displayCharacter == '#')
            {
                result = Resources.horizontal;
            }

            /*if (displayCharacter == 'P' || displayCharacter == 'p')
            {
                result = Resources.player;
            }*/

            return result;
        }
    }
}
