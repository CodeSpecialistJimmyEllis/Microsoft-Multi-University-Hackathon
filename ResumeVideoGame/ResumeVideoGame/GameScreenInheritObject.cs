// JESUS IS LORD! ONLY THROUGH CHRIST JESUS WHO IS GOD IS THIS POSSIBLE! JESUS IS LORD!


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
    public class GameScreen
    {


        /*  public  GameScreen(bool choice)
          {
              this.displayEndScenes = choice;

          }
          public GameScreen()
          {


          } */
        protected ContentManager content;
        //public virtual void Initialize() { }

        public virtual void LoadContent(ContentManager Content)
        {
            content = new ContentManager(Content.ServiceProvider, "Content");
        }
        public virtual void UnloadContent()
        {
            content.Unload();
        }
        public virtual void Update(GameTime gameTime)
        {

        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}
