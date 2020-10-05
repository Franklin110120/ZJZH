﻿using Game1.Controller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Game1
{
 
    public class MainStage : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private List<IController> controllers;

<<<<<<< HEAD



=======
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
        /// <summary>
        /// Active sprite. Exposed as a class property
        /// </summary>

        //Link class
        public ILink Link { get; set; }
        /// <summary>
        /// A list that holds all loaded sprites.
        /// 
        /// </summary>
        //Projectile Factory
        public IProjectileFactory ProjectileFactory { get; set; }

        public ILinkState[] Linkstates { get; }

        public MainStage()
        {
            graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = GlobalDefinitions.GraphicsWidth;
            graphics.PreferredBackBufferHeight = GlobalDefinitions.GraphicsHeight;

            this.Link = new Link(this);
<<<<<<< HEAD
            this.ProjectileFactory = new ProjectileFactory(this);

=======
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f

            controllers = new List<IController>
            {
                new KeyboardController(this)
            };
<<<<<<< HEAD
=======
        }

        /// <summary>
        /// Reset all sprites to a known state
        /// </summary>
        public void ResetState()
        {
            Link.Reset();
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // Explicitly set mouse visible option to make the game intuitive
            this.IsMouseVisible = true;
            this.TargetElapsedTime = TimeSpan.FromSeconds(1.0f / 100.0f);
            this.IsFixedTimeStep = false;
            graphics.SynchronizeWithVerticalRetrace = false;
<<<<<<< HEAD
            this.ProjectileFactory.Initialize();

=======
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f

            // Create instances and register commands
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
            
            Texture2DStorage.LoadAllTextures(this.Content);

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
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
            foreach (var controller in controllers)
            {
                controller.Update();
            }
            this.ProjectileFactory.Update();
            Link.Update();
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
<<<<<<< HEAD
            this.ProjectileFactory.Draw(spriteBatch);
            Link.State.Draw(spriteBatch);
=======

            Link.State.GetSprite.Draw(spriteBatch);
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f

            spriteBatch.End();
            base.Draw(gameTime);
        }

        
    }
}
