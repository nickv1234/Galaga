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

namespace Galaga_Character
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont font;
        string scorewords;
        int scorenum;
        Texture2D galaga;
        Texture2D shot;

        KeyboardState oldkb;

        Rectangle Rship;
        Rectangle Rshot;
        Rectangle Rlife;
        Rectangle Rlife2;

        


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
            oldkb = Keyboard.GetState();

            

            Rship = new Rectangle(250, 300, 64, 64);
            Rshot = new Rectangle(0, 0, 7, 37);

            Rlife = new Rectangle(5, 445, 32, 32);
            Rlife2 = new Rectangle(37, 445, 32, 32);

            scorewords = "Score: ";
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
            galaga = this.Content.Load<Texture2D>("ship");
            shot = this.Content.Load<Texture2D>("pew");

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        /// //hfhaei
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
            KeyboardState kb = Keyboard.GetState();

            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            /*if (Rshot.Intersects(enemy))
            {
                scorenum += 100;
                
            }
            */

            if (kb.IsKeyDown(Keys.Left))
            {
                Rship.X -= 3;
            }

            if (kb.IsKeyDown(Keys.Right))
            {
                Rship.X += 3;
            }

            //shoots 
            //if (kb.IsKeyDown(Keys.Space) && !oldkb.IsKeyDown(Keys.Space))
            //{
                 //shot.Y-=5;
            //}
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
            spriteBatch.Begin();
            spriteBatch.Draw(galaga, Rship, Color.White);
            spriteBatch.Draw(shot, Rshot, Color.White);
            spriteBatch.Draw(galaga, Rlife, Color.White);
            spriteBatch.Draw(galaga, Rlife2, Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
