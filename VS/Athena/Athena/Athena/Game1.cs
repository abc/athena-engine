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
using ACEx.UI;

namespace Athena
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont Calibri;
        Texture2D Cursor;

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
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Calibri = this.Content.Load<SpriteFont>("calibri");
            Cursor = this.Content.Load<Texture2D>("cursor");
            Blank = this.Content.Load<Texture2D>("blank");

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
        MouseState state;
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

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


            bool debug = false;
            

            spriteBatch.Begin();

            Cursor mainCursor = new Cursor();
            //spriteBatch.Draw(Blank, new Rectangle(50, 50, 100, 40), Color.Black);
            //spriteBatch.Draw(Blank, new Rectangle(50, 50, 99, 39), Color.White);
            //spriteBatch.Draw(Blank, new Rectangle(51, 51, 98, 38), Color.LightGray);
            //spriteBatch.DrawString(Calibri, "Click me!", new Vector2(70, 58), Color.Black);
            // spriteBatch.Draw(Blank, new Rectangle(0, 0, 50, 50), Color.White);
            Button button = new Button(50, 50, 70, 30, Calibri, Blank, "Test");

            if (mainCursor.Clicks(button))
            {
                button.IsClicked();
            }
            
            button.Draw(spriteBatch);
            mainCursor.Draw(Cursor, spriteBatch);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
