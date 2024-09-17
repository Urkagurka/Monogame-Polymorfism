using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Polymorfism;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    Player player;
    Texture2D pixel;
    Enemy enemy;

    List<BaseClass> enemies = new List<BaseClass>();

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        pixel = new Texture2D(GraphicsDevice,1,1);
        pixel.SetData(new Color[]{Color.White});

        player = new Player(pixel);
        Enemy enemy = new Enemy(pixel, new Vector2(100,100));

        enemies.Add(player);
        enemies.Add(enemy);
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        foreach(BaseClass enemy in enemies)
        {
            enemy.Update();
        }

        base.Update(gameTime);

        
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.White);

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }

    public void RemoveEnemy(){
        List<BaseClass> temp = new List<BaseClass>();
        Random rand = new Random();
        MouseState ms = Mouse.GetState();
        foreach (var enemy in enemies){
            if(rand.Next(1,1000) !=1)
            temp.Add(enemy);
        
        }
        enemies = temp;
    }

    public void AddEnemy(){
        Random rand = new Random();
        enemies.Add(new Enemy(pixel,new Vector2(rand.Next(0,700),10)));
        
    }
}
