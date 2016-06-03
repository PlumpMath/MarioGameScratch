using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using MarioGameScratch.Sprites;
using Microsoft.Xna.Framework;
using MarioGameScratch.Sprites.Blocks;

namespace MarioGameScratch.Factories
{
    class BlockSpriteFactory
    {
        private Texture2D blockSpriteSheet;

        private static BlockSpriteFactory instance = new BlockSpriteFactory();

        public static BlockSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private BlockSpriteFactory() { }

        public void LoadAllTextures(ContentManager content)
        {
            blockSpriteSheet = content.Load<Texture2D>("blocks");
        }

        public ISprite CreateQuestionBlockSprite()
        {
            return new QuestionBlockSprite(blockSpriteSheet, new Rectangle(0, 0, 50, 50));
        }
    }
}
