using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using ACEx.Graphics;
using ACEx.Game;

namespace Athena
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        BatchHandler batchHandler;
        Character Player;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        /// 

        Texture2D Blank;
        char[,] tiles = new char[320, 240];

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            batchHandler = new BatchHandler(spriteBatch);
            Blank = this.Content.Load<Texture2D>("blank");
            Player = new Character(5, 5, Blank); 

            int counter = 0;
            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader("testlevel.txt");

            while ((line = file.ReadLine()) != null)
            {
                char[] chars = line.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                        tiles[i, counter] = chars[i];
                }
                    counter++;
            }
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        /// 
        KeyboardState oldState;
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();


            var newState = Keyboard.GetState();

            if (newState.IsKeyDown(Keys.W) && !oldState.IsKeyDown(Keys.W))
            {
                Player.MoveUp();
            }
            if (newState.IsKeyDown(Keys.A) && !oldState.IsKeyDown(Keys.A))
            {
                Player.MoveLeft();
            }
            if (newState.IsKeyDown(Keys.S) && !oldState.IsKeyDown(Keys.S))
            {
                Player.MoveDown();
            }
            if (newState.IsKeyDown(Keys.D) && !oldState.IsKeyDown(Keys.D))
            {
                Player.MoveRight();
            }

            oldState = newState;

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        /// 

        
        protected override void Draw(GameTime gameTime)
        {


            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    if (tiles[i, j] == 'X')
                    {
                        batchHandler.Draw<Tile>(new Tile(i, j, Blank));
                    }
                }
            }
            //batchHandler.Draw<Tile>(new Tile(2, 3, Blank));
            //batchHandler.Draw<Tile>(new Tile(2, 4, Blank));
            //batchHandler.Draw<Tile>(new Tile(2, 5, Blank));
            //batchHandler.Draw<Tile>(new Tile(2, 6, Blank));
            //batchHandler.Draw<Tile>(new Tile(3, 2, Blank));
            //batchHandler.Draw<Tile>(new Tile(3, 6, Blank));
            //batchHandler.Draw<Tile>(new Tile(5, 2, Blank));
            //batchHandler.Draw<Tile>(new Tile(5, 3, Blank));
            //batchHandler.Draw<Tile>(new Tile(5, 4, Blank));
            //batchHandler.Draw<Tile>(new Tile(5, 5, Blank));
            //batchHandler.Draw<Tile>(new Tile(5, 6, Blank));
            //batchHandler.Draw<Tile>(new Tile(6, 4, Blank));
            //batchHandler.Draw<Tile>(new Tile(7, 2, Blank));
            //batchHandler.Draw<Tile>(new Tile(7, 3, Blank));
            //batchHandler.Draw<Tile>(new Tile(7, 4, Blank));
            //batchHandler.Draw<Tile>(new Tile(7, 5, Blank));
            //batchHandler.Draw<Tile>(new Tile(7, 6, Blank));

            //batchHandler.Draw<Tile>(new Tile(9, 2, Blank));
            //batchHandler.Draw<Tile>(new Tile(10, 2, Blank));
            //batchHandler.Draw<Tile>(new Tile(9, 3, Blank));
            //batchHandler.Draw<Tile>(new Tile(9, 4, Blank));
            //batchHandler.Draw<Tile>(new Tile(9, 5, Blank));
            //batchHandler.Draw<Tile>(new Tile(9, 6, Blank));
            //batchHandler.Draw<Tile>(new Tile(10, 4, Blank));
            //batchHandler.Draw<Tile>(new Tile(11, 2, Blank));
            //batchHandler.Draw<Tile>(new Tile(11, 3, Blank));
            //batchHandler.Draw<Tile>(new Tile(11, 4, Blank));
            //batchHandler.Draw<Tile>(new Tile(11, 5, Blank));
            //batchHandler.Draw<Tile>(new Tile(11, 6, Blank));
            //batchHandler.Draw<Tile>(new Tile(15, 15, Blank));
            batchHandler.Draw<Character>(Player);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
