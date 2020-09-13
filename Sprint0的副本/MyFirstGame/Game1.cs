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
        public float InterfaceWidth { get; set; }
        public float InterfaceHeight { get; set; }

        List<object> controllerList; // could also be defined as List <IController>
        List<object> textSpriteList;
        public ISprite Sprite { get; set; }
        public Texture2D Texture { get; set; }
        public Vector2 Location { get; set; }


     

       


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            this.InterfaceWidth = (float)800;
            this.InterfaceHeight = (float)400;
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            controllerList = new List<object>();
            controllerList.Add(new KbController (this));
            controllerList.Add(new MsController (this));

            this.IsMouseVisible = true;

            this.Location  = new Vector2(InterfaceWidth / 2, InterfaceHeight / 2);
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

            this.Texture = Content.Load<Texture2D>("Mario");
            credit = Content.Load<SpriteFont>("credit");
            author = Content.Load<SpriteFont>("author");
            url = Content.Load<SpriteFont>("url");

            textSpriteList = new List<object>();
            textSpriteList.Add(new TextDrawSprite1(credit));
            textSpriteList.Add(new TextDrawSprite2(author));
            textSpriteList.Add(new TextDrawSprite3(url));

            
            this.Sprite = new NMNASprite  (this.Texture  );

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
        }
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            foreach (IController controller in controllerList)
            {
                controller.Update();
            }

            this.Sprite .Update();

            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            this.Sprite .Draw(spriteBatch, this.Location );

            foreach (ITextSprite textsprite in textSpriteList)
            {
                textsprite.Draw(spriteBatch );
            }


            base.Draw(gameTime);
        }
    }
}
