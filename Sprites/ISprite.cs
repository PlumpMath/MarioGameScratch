using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioGameScratch.Sprites
{
    public interface ISprite
    {
        Texture2D Texture { get; set; }
        void Update();
        void Draw(SpriteBatch sb, Vector2 destination);
    }
}
