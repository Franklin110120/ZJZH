using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace MyFirstGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont credit;
        SpriteFont author;
        SpriteFont url;
        Texture2D texture;
        private float interfaceWidth = (float)800;
        private float interfaceHeight = (float)400;
        private Vector2 location;
        List<object> controllerList; // could also be defined as List <IController>
        List<object> textSpriteList;
        ISprite sprite;

        public float InterfaceWidth
        {
            get
            {
                return this.interfaceWidth;
            }
            set
            {
                this.interfaceWidth = value;
            }
        }
        public float InterfaceHeight
        {
            get
            {
                return this.interfaceHeight;

            }
            set
            {
                this.interfaceHeight = value;
            }
        }



        

        public ISprite Sprite
        {
            get
            {
                return this.sprite;
            }
            set
            {
                this.sprite = value;
            }
        }

        public Texture2D Texture
        {
            get
            {
                return this.texture;
            }
            set
            {
                this.texture = value;
            }
        }

        public Vector2 Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform avny initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            controllerList = new List<object>();
            controllerList.Add(new KbController (this));
            controllerList.Add(new MsController (this));

            
            
            location = new Vector2(InterfaceWidth / 2, InterfaceHeight / 2);
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

            // TODO: use this.Content to load your game content here
            texture = Content.Load<Texture2D>("Mario");
            credit = Content.Load<SpriteFont>("credit");
            author = Content.Load<SpriteFont>("author");
            url = Content.Load<SpriteFont>("url");

            textSpriteList = new List<object>();
            textSpriteList.Add(new TextDrawSprite1(credit));
            textSpriteList.Add(new TextDrawSprite2(author));
            textSpriteList.Add(new TextDrawSprite3(url));

            
            sprite = new NMNASprite  (texture );

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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            foreach (IController controller in controllerList)
            {
                controller.Update();
            }

            sprite.Update();

            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            sprite.Draw(spriteBatch, location);

            foreach (ITextSprite textsprite in textSpriteList)
            {
                textsprite.Draw(spriteBatch );
            }


            base.Draw(gameTime);
        }
    }
}
