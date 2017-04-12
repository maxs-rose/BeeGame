﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeeGame.Core.Enums;
using UnityEngine;
using BeeGame.Items;

namespace BeeGame.Blocks
{
    [Serializable]
    public class Dirt : Block
    {
        public Dirt() : base(){}

        public override Tile TexturePosition(Direction direction)
        {
            return new Tile { x = 2, y = 9 };
        }

        public override int GetHashCode()
        {
            return 4;
        }

        public override string ToString()
        {
            return $"Bedrock ID: {GetHashCode()}";
        }
    }
}