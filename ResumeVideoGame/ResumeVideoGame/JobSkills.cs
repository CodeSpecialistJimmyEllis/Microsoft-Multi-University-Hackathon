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
    public class JobSkills : GameScreen
    {
      

        Texture2D csharp;
        Texture2D xna;
        Texture2D computerrepair;
        Texture2D hardwarespecialist;

        Song backgroundmusic;

        Texture2D background;
        public JobSkills()
        {


        }

       public override void LoadContent(ContentManager Content)
        {

            base.LoadContent(Content);
            // Create a new SpriteBatch, which can be used to draw textures.


         
            

            backgroundmusic = Content.Load<Song>("jobskills/bgmusic01");
            MediaPlayer.Play(backgroundmusic);
            background = Content.Load<Texture2D>("jobskills/jobskills");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        public override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // Allows the game to exit

            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Enter) || GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.Start))
            {
                ScreenManager.Instance.AddScreen(new OpeningTitleScreen());
            }
            // TODO: Add your update logic here

        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Draw(SpriteBatch spriteBatch)
        {
           
            // TODO: Add your drawing code here

           
            spriteBatch.Draw(background, new Rectangle(0, 0, 800, 600), Color.White);
         

        }
    }
}
