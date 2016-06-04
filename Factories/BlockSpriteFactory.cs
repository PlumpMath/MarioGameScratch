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

        private const int BlockLength = 32;

        private const int CeilingBlockOffset = BlockLength * 0;
        private const int UsedBlockOffset = BlockLength * 1;
        private const int QuestionBlockOffset = BlockLength * 2;
        private const int BrickBlockOffset = BlockLength * 3;
        private const int FloorBlockOffset = BlockLength * 4;

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
        public ISprite CreateCeilingBlockSprite()
        {
            return CreateBlockSprite(CeilingBlockOffset);
        }

        public ISprite CreateQuestionBlockSprite()
        {
            return CreateBlockSprite(QuestionBlockOffset);
        }

        private BlockSprite CreateBlockSprite(int offset)
        {
            return new BlockSprite(blockSpriteSheet, new Rectangle(offset, 0, BlockLength, BlockLength));
        }

    }
}
