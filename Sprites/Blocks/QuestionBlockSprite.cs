using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace MarioGameScratch.Sprites.Blocks
{
    class QuestionBlockSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        public Rectangle Source { get; set; }

        public QuestionBlockSprite(Texture2D texture, Rectangle source)
        {
            Texture = texture;
            Source = source;
        }

        public void Draw(SpriteBatch sb, Vector2 destination)
        {
            Rectangle destinationRectangle = new Rectangle((int)destination.X, (int)destination.Y, Source.Width, Source.Height);
            sb.Begin();
            sb.Draw(Texture, destinationRectangle, Source, Color.White);
            sb.End();
        }

        public void Update()
        {
            // not implemented
        }
    }
}
