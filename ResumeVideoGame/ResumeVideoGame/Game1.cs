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

namespace ResumeVideoGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //after several seconds disappear 
        public static GameTime gameTime;
        public static TimeSpan timeSpan;
        public static string heldTimeCatcher;
        SpriteFont font;

        ResumeVideoGame resumevideogame;
        JobSkills jobskills;
        PlayVideoState playvideostate;
        public enum GameStates
        {
            gameplay, computerrepair, sourcecode, jobskills
        }

       public static GameStates gamestates;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            #region 
            
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
            resumevideogame = new ResumeVideoGame();
            jobskills = new JobSkills();
            gamestates = GameStates.gameplay;
            playvideostate = new PlayVideoState();

            ScreenManager.Instance.Initialize();

            ScreenManager.Instance.Dimensions = new Vector2(800, 600);
            graphics.PreferredBackBufferWidth = (int)ScreenManager.Instance.Dimensions.X;
            graphics.PreferredBackBufferHeight = (int)ScreenManager.Instance.Dimensions.Y;
            #endregion
            graphics.ApplyChanges();

            //after several seconds disappear 
            // gametime
            gameTime = new GameTime();
            timeSpan = new TimeSpan();
            // gametime
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
            font = Content.Load<SpriteFont>("content/Font1");
            ScreenManager.Instance.LoadContent(Content);
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
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.LeftTrigger) || Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Delete))
            {

                this.Exit();
            }
            // Allows the game to exit

            //after several seconds disappear code
            gameTime.ElapsedGameTime.Add(timeSpan);

            ScreenManager.Instance.Update(gameTime);

            //after several seconds disappear 
            heldTimeCatcher = gameTime.TotalGameTime.Seconds.ToString();
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

            ScreenManager.Instance.Draw(spriteBatch);

           // after several seconds disappear draw code 
          //  spriteBatch.DrawString(font, heldTimeCatcher.ToString(), new Vector2(0, 30), Color.White);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
