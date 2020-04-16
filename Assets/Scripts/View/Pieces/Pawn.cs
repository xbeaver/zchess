﻿using UnityEngine;
using UnityEngine.UI;

namespace View.Pieces
{
    public class Pawn : BasePiece
    {
        public override void Setup(Color newTeamColor, Color32 newSpriteColor)
        {
            base.Setup(newTeamColor, newSpriteColor);
            GetComponent<Image>().sprite = Resources.Load<Sprite>("T_Pawn");
        }
    }
}