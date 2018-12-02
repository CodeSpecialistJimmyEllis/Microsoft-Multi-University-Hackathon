// JESUS IS LORD! ONLY THROUGH CHRIST JESUS WHO IS GOD IS THIS POSSIBLE! JESUS IS LORD!


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ResumeVideoGame
{
    class ScreenManager
    {

        #region Variables
        // JESUS IS LORD creating custom content Manager JESUS IS LORD <<< GRAPHICS >>> 
        ContentManager content;
        //JESUS IS LORD! DICTIONARY! JESUS IS LORD!
        // Dictionary<string, GameScreen> screens = new Dictionary<string, GameScreen>();
        // ONE INSTANCE GLOBAL CLASS //
        // JESUS IS LORD SCREEN STACK
        private static ScreenManager instance;
        GameScreen currentScreen;
        GameScreen newScreen;
        //JESUS IS LORD <<< GAME STATES>>> DIFERENT GAMES STATES ABOVE JESUS IS LORD!

       // OpeningTitleScreen openingtitlescreen;
       // LoginTitleScreen logintitlescreen;

        Stack<GameScreen> screenStack = new Stack<GameScreen>();

        // Screen width and height

        Vector2 dimensions = Vector2.Zero;
        /* JESUS IS LORD VARIABLE LIST JESUS IS LORD
         * 1. JESUS IS LORD! (global instance of screen manager) instance of screen manager that only exists once through out phole game JESUS IS LORD! 
         * 2. JESUS IS LORD! (actual game screens) 2 GAME SCREENS TO SHOW PEOPLE! JESUS IS LORD!
         * 3. JESUS IS LORD! (game screen organizatioN)STACK OF GAME SCREENS TO MOVE BETWEEN IN THE NAME OF ORGANIZATION JESUS IS LROD!
         * 4. JESUS IS LORD! (details of game screen) THE SIZE OF THE RESPECTED SCREENS! JESUS IS LORD! 
         * */

        #endregion

        #region Properties
        // JESUS IS LORD <<< PHEONOMINA >>> ALLOWS YOU TO GET THE INSTANCE OF THE SCREEN MANAGER! JESUS IS LORD!

        /*
        public OpeningTitleScreen Openingtitlescreen
        {

            get
            {
                if (openingtitlescreen != null)
                    return openingtitlescreen;

                else
                    return null;
            }
        }

        public LoginTitleScreen Logintitlescreen
        {

            get
            {
                if (logintitlescreen != null)
                    return logintitlescreen;

                else
                    return null;
            }
        } */
        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ScreenManager();
                return instance;
            }
        }
        // JESUS IS LORD <<< PHEONOMINA >>> SETS THE SIZE OF THE SCREEN AND GETS IT JESUS IS LORD! 
        public Vector2 Dimensions
        {
            get { return dimensions; }
            set { dimensions = value; }
        }

        #endregion

        #region Main Methods

        // JESUS IS LORD INITIALIZES ARE GOOD BECAUSE THEY CAN BE RECALLED TO OVER AND OVER WHILE CONSTRUCTORS ONLY CALLED ONCE! THAT'S WHY CONSTRUCTORS AND INITAILZIE METHODS OARE DIFFERNET JES US IS LORD!

        // JESUS IS LORD LOAD OR UNLOAD SCREEN <<< PHEONOMINA >>>
        public void AddScreen(GameScreen screen)
        {
            //JESUS IS LORD CHANGE SCREENS IN HERE JESUS IS LORD!
            newScreen = screen;
            screenStack.Push(screen);
            currentScreen.UnloadContent();
            currentScreen = newScreen;
            currentScreen.LoadContent(content);
        }



        public void Initialize()
        {
           // logintitlescreen = new LoginTitleScreen();
            currentScreen = new OpeningTitleScreen();
        }
        public void LoadContent(ContentManager Content)
        {

            content = new ContentManager(Content.ServiceProvider, "Content");
            currentScreen.LoadContent(Content);
        }
        public void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);
        }

        #endregion
    }
}


