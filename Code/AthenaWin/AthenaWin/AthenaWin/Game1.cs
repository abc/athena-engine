using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

using AthenaEngine.Framework;
using AthenaEngine.Framework.Gameplay;
using AthenaEngine.Framework.Primatives;
using AthenaEngine.Framework.Systems;
using AthenaEngine.Framework.Interfaces;

namespace AthenaWin
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
        Level test;
        Camera2D Camera;
        Character Player;
        

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

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>   
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            textureManager = new ResourceManager<Texture2D>(this);
            
            this.Camera = new Camera2D(this);
            
            textureManager.Add("blank", this.Content.Load<Texture2D>("blank"));
            test = new Level("level1", spriteBatch, textureManager);
            Player = new Character(new Vector2(-50, -100), new Vector2(500, 500), spriteBatch, this.Content.Load<Texture2D>("blank"));
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
        protected override void Draw(GameTime gameTime)
        {
            Camera.Focus = Player;
            GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.CornflowerBlue);
            spriteBatch.Begin(SpriteSortMode.FrontToBack, BlendState.Additive, null, null, null, null, Camera.Transform);
            test.Draw();
            Player.Draw();
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
