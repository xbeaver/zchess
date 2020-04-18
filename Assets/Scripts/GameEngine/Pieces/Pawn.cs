﻿using System.Collections.Generic;
using UnityEngine;

namespace GameEngine.Pieces
{
    public class Pawn : BasePiece
    {
        private readonly Vector2Int _direction;
        public bool IsFirstMove = true;
        public Pawn(Color color) : base(color)
        {
            _direction = color == Color.white
                ? new Vector2Int(0, 1)
                : new Vector2Int(0, -1);
        }

        public override List<Vector2Int> GetPotentialMoves(Vector2Int position)
        {
            return Rules.Move.Pawn.GetPotentialMoves(position, _direction, IsFirstMove);
        }

        public override void BeingMoved()
        {
            base.BeingMoved();
            IsFirstMove = false;
        }
    }
}