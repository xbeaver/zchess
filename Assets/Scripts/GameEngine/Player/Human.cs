﻿using GameEngine.Logic;
using GameEngine.Logic.Levels;
using UnityEngine;

namespace GameEngine.Player
{
    public class Human : BasePlayer
    {
        public Human(Color color, float timer = 0) : base(color, timer)
        {
        }

        public override IlogicEngine GetLogicEngine()
        {
            return null;
        }
    }
}