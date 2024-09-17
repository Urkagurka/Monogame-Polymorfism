using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Monogame_Polymorfism
{
    public class Player : BaseClass
    {

  
        public Player(Texture2D texture): base(texture, new Vector2(400,240)){
        }


        public void Update(){
        KeyboardState kState = Keyboard.GetState();
        if(kState.IsKeyDown(Keys.W)){
            position.Y -=10;
        }
        if(kState.IsKeyDown(Keys.S)){
            position.Y +=10;
        }
        if(kState.IsKeyDown(Keys.A)){
            position.X -=10;
        }
        if(kState.IsKeyDown(Keys.D)){
            position.X +=10;
        }
        if(kState.IsKeyDown(Keys.R)){
            position.X =0;
            position.Y =0;
        }
        }
        public void Draw(SpriteBatch spriteBatch){
        Rectangle playerRectangle = new Rectangle((int)position.X,(int)position.Y,50,50);
        spriteBatch.Draw(texture, playerRectangle, Color.Red);
    }
    }
}