using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
namespace ResumeVideoGame
{
    class ScrollingBackgroundBottom
    {

        #region Fields
        //JESUS IS LORD <<< GRAPHICS >>> SCROLLING BACKGROUNDS
        Texture2D scrollingOne;
        Texture2D scrollingTwo;

        // JESUS IS GOD! <<<GRAPHICS ON SCREEN>>>>
        SpriteBatch ab;
        //JESUS IS LORD RECTANGLE <<< GRAPHICS>>>> RECTANGLE FOR GRAPHICS
        Rectangle scrollingOneRect;
        Rectangle scrollingTwoRect;

        Vector2 a;
        Vector2 b;

        ContentManager content;
        // JESUS IS LORD speed of scrolling background <<< control >>>
        int scrollingSpeed = 3;


        // JESUS IS LORD <<< SCROLLING BACKGROUND >>>> PHENOMINA
        bool scrolling = true;
        #endregion

        #region Properties
        public Texture2D ScrollingOne
        {
            get { return scrollingOne; }
            set { scrollingOne = value; }
        }

        public Texture2D ScrollingTwo
        {
            get { return scrollingTwo; }
            set { scrollingTwo = value; }
        }


        public Rectangle ScrollingOneRect
        {
            get { return scrollingOneRect; }
            set { scrollingOneRect = value; }
        }

        public Rectangle ScrollingTwoRect
        {
            get { return scrollingTwoRect; }
            set { scrollingTwoRect = value; }
        }

        public Vector2 A
        {
            get { return a; }
            set { value = a; }
        }

        public Vector2 B
        {
            get { return b; }
            set { b = value; }
        }

        public int ScrollingSpeed
        {
            get { return scrollingSpeed; }
            set { scrollingSpeed = value; }
        }
        #endregion

        #region Constructors

        public ScrollingBackgroundBottom()
        {
            scrollingSpeed = 1;
        }

        #endregion

        #region LoadContent
        public void LoadContent(ContentManager Content)
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            //spriteBatch = new SpriteBatch(GraphicsDevice);
            scrollingOne = Content.Load<Texture2D>("backgrounds/scrolling/scrolling1a");
            scrollingTwo = Content.Load<Texture2D>("backgrounds/scrolling/scrolling2a");

            scrollingOneRect = new Rectangle(0, 500, 800, 100);
            scrollingTwoRect = new Rectangle(-800, 500, 800, 100);



            // TODO: use this.Content to load your game content here
        }



        #endregion

        #region Update
        public void Update(GameTime gameTime)
        {
            // Allows the game to exit
            // ONLY THROGH CHRIST JESUS WHO IS GOD! JESUS IS LORD!
            /*
            #region scrolling forward equation
            scrollingOneRect.X = scrollingOneRect.X + scrollingSpeed;

            if (scrollingOneRect.X >= 800)
                scrollingOneRect.X = 0;



            scrollingTwoRect.X = scrollingTwoRect.X + scrollingSpeed;

            if (scrollingTwoRect.X >= 0)
                scrollingTwoRect.X = -800;
            #endregion 
            */


            #region scrolling backwards
            if (scrollingOneRect.X != 0 || !(scrollingOneRect.X < 0))
            {

                scrollingOneRect.X = scrollingOneRect.X - scrollingSpeed;
                //   scrollingTwoRect.X = scrollingTwoRect.X - scrollingSpeed;
                if (scrollingOneRect.X == 0 || scrollingOneRect.X < 0)
                {

                    scrollingOneRect.X = 800;
                }
            }

            if (scrollingTwoRect.X != -800 || !(scrollingTwoRect.X < -800))
            {

                scrollingTwoRect.X -= scrollingSpeed;

                if (scrollingTwoRect.X == -800 || scrollingTwoRect.X < -800)
                {

                    scrollingTwoRect.X = 0;
                }
            }
            #endregion 
            // TODO: Add your update logic here

            //base.Update(gameTime);
        }


        #endregion

        #region Draw


        public void Draw(SpriteBatch spriteBatch)
        {


            //GraphicsDevice.Clear(Color.CornflowerBlue);

            //spriteBatch.Begin();
            spriteBatch.Draw(scrollingOne, scrollingOneRect, Color.White);
            spriteBatch.Draw(scrollingTwo, scrollingTwoRect, Color.White);
            //spriteBatch.End();

            // TODO: Add your drawing code here

            //base.Draw(gameTime);
        }
        #endregion
    }
}
