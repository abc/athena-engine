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

using AthenaEngine.Framework;
using AthenaEngine.Framework.Gameplay;
using AthenaEngine.Framework.Interfaces;
using AthenaEngine.Framework.Primatives;
using AthenaEngine.Framework.Systems;
using AthenaEngine.Framework.UI;

namespace Athena
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        // TODO: Remove warning suppression once it's used.
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        ResourceManager<Texture2D> textureManager;
        ResourceManager<SpriteFont> fontManager;
        Level test;
        Camera2D Camera;
        Character Player;
        bool FirstRun = true;
        KeyboardState OldState;
        

        /// <summary>
        /// The actual game class constructor.
        /// </summary>
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
        public SpriteFont font;

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>   
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            textureManager = new ResourceManager<Texture2D>(this);
            fontManager = new ResourceManager<SpriteFont>(this);
            
            this.Camera = new Camera2D(this);
            
            textureManager.Add("blank", this.Content.Load<Texture2D>("blank"));
            textureManager.Add("pokemon", this.Content.Load<Texture2D>("pokemon-tiles"));
            textureManager.Add("Boards", this.Content.Load<Texture2D>("Boards"));
            textureManager.Add("guy", this.Content.Load<Texture2D>("guy"));
            fontManager.Add("SpriteFont1", this.Content.Load<SpriteFont>("SpriteFonts/UIFont"));
            test = new Level("level1", spriteBatch, textureManager);
            this.Player = new Character(new Vector2(75, 75), new Vector2(25, 25), spriteBatch, textureManager.Get("guy"), test);
            // Player.SpriteColor = Color.Red;
            Camera.Focus = Player;
            Camera.Initialize();
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
        protected override void Update(GameTime gameTime)
        {
            KeyboardState State = Keyboard.GetState();

            if (FirstRun)
            {
                if (State.IsKeyDown(Keys.W))
                {
                    Player.Move(Directions.UP);
                }
                if (State.IsKeyDown(Keys.A))
                {
                    Player.Move(Directions.LEFT);
                }
                if (State.IsKeyDown(Keys.S))
                {
                    Player.Move(Directions.DOWN);
                }
                if (State.IsKeyDown(Keys.D))
                {
                    Player.Move(Directions.RIGHT);
                }

                OldState = State;
                FirstRun = false;
            }
            else if (OldState != State)
            {
                if (State.IsKeyDown(Keys.W))
                {
                    Player.Move(Directions.UP);
                }
                if (State.IsKeyDown(Keys.A))
                {
                    Player.Move(Directions.LEFT);
                }
                if (State.IsKeyDown(Keys.S))
                {
                    Player.Move(Directions.DOWN);
                }
                if (State.IsKeyDown(Keys.D))
                {
                    Player.Move(Directions.RIGHT);
                }

                OldState = State;
            }
            else
            {
                // Do nothing.
            }

            Camera.Update(gameTime);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            Debug.Mode = Debug.Modes.GAME;

            GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.CornflowerBlue);

            if (Debug.Mode == Debug.Modes.GAME)
            {
                Camera.Focus = Player;

                spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, Camera.Transform);
                
                test.Draw();
                Player.Draw();
                spriteBatch.End();
            }

            else if (Debug.Mode == Debug.Modes.UI)
            {
//                UIButton test = new UIButton(new Vector2(0, 0), new Vector2(50, 50), spriteBatch, textureManager.Get("blank"));
                UI Test = new UI(spriteBatch, textureManager, fontManager);

                Test.AddButton(new Vector2(5, 5), "HI");
                Test.AddButton(new Vector2(50, 50), "ASK!");
                spriteBatch.Begin();
                // Test.Draw();
                // int x = 6;
                // int y = 105;

                // spriteBatch.Draw(textureManager.Get("pokemon"), new Rectangle(0, 0, 25, 25), new Rectangle((x - 1) * 25, (y - 1 )* 25, 25, 25), Color.White);
                Player.Draw();
                test.Draw();
                
                
                spriteBatch.End();

                
            }
            
            base.Draw(gameTime);
        }
    }
}
