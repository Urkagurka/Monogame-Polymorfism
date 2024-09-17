using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_Polymorfism
{
    public class Enemy : BaseClass
    {
        public Enemy(Texture2D texture, Vector2 position):base(texture, position){
            color = Color.Black;
        }

        public override void Update(){
            position.Y--;
        }
    }
}