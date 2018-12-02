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
    public class PlayVideoState : GameScreen 
    {
       
        Texture2D background;

        VideoPlayer videoplayer;
        Video video;
        Video video2;
        Song videogamemusic;
        Texture2D videotexture;
        Rectangle videotexturerect;
        int state;
        SpriteFont font; 
        public PlayVideoState()
        {
   
            // TODO: Add your initialization logic here
            videotexturerect = new Rectangle(0, 120, 512, 256);
            state = 0;
     
        }

        public PlayVideoState(int newstate)
        {

            // TODO: Add your initialization logic here
            videotexturerect = new Rectangle(0, 120, 512, 256);
            this.state = newstate;
            
        }


        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        public override void LoadContent(ContentManager Content)
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            base.LoadContent(Content);
            background = Content.Load<Texture2D>("PlayVideoState/backgroundcode");
            videoplayer = new VideoPlayer();
            video = Content.Load<Video>("PlayVideoState/deepestmasterofcode");
            video2 = Content.Load<Video>("PlayVideoState/computerrepairspeedvideofinal");
            // TODO: use this.Content to load your game content here
            videogamemusic = Content.Load<Song>("PlayVideoState/bgmusic01");

            // load sprite fonit
            font = Content.Load<SpriteFont>("ResumeGamePlayState/SpriteFont1");
            if (state == 0)
                videoplayer.Play(video2);
            else if (state == 1)
                videoplayer.Play(video);

            MediaPlayer.Play(videogamemusic);
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


            if ((GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.Start) || (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Enter))) && (state == 0))
            {
                ScreenManager.Instance.AddScreen(new ResumeVideoGame(1));
            }

            if ((GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.Start) || (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Enter))) && (state == 1))
            {
                ScreenManager.Instance.AddScreen(new ResumeVideoGame(2));
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Draw(SpriteBatch spriteBatch)
        {

          
            videotexture = videoplayer.GetTexture();
            // TODO: Add your drawing code here



            spriteBatch.Draw(background, new Rectangle(0, 0, 800, 600), Color.White);
            spriteBatch.Draw(videotexture, videotexturerect, Color.White);


            if (videoplayer.State == MediaState.Stopped)
            {
                spriteBatch.DrawString(font, "PRESS ENTER", new Vector2(0, 0), Color.White);
            }
         

        }
    }
}
