using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Monogame_Polymorfism
{
    public class BaseClass
    {
        protected Microsoft.Xna.Framework.Vector2 position;
        protected Texture2D texture;
        protected Color color;

        protected Rectangle playerRectangle;
        public Rectangle Rectangle{
            get{
                return playerRectangle;
            }
        }
        public BaseClass(Texture2D texture, Microsoft.Xna.Framework.Vector2 position){
            this.texture = texture;
            this.position = position;
        }

        public void Draw(SpriteBatch spriteBatch){
        playerRectangle = new Rectangle((int)position.X,(int)position.Y,50,50);
        spriteBatch.Draw(texture, playerRectangle, Color.Red);
    } 
    }
}