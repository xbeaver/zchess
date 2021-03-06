﻿using UnityEngine;
using UnityEngine.UI;

namespace View
{
    public class Board : MonoBehaviour
    {
        private readonly string[] cellLetters = {"a", "b", "c", "d", "e", "f", "g", "h"};
        public GameObject mCellPrefab;
        public Cell[,] mAllCells = new Cell[8, 8];

        // Start is called before the first frame update
        public void Create()
        {
            for (var y = 0; y < 8; y++)
            {
                for (var x = 0; x < 8; x++)
                {
                    var newCell = Instantiate(mCellPrefab, transform);
                    var rectTransform = newCell.GetComponent<RectTransform>();
                    rectTransform.anchoredPosition = new Vector2((x * 100) + 50, (y * 100) + 50);

                    mAllCells[x, y] = newCell.GetComponent<Cell>();
                    mAllCells[x, y].Setup();
                    mAllCells[x, y].SetPosition(x, y);

                    if ((x + y) % 2 == 1)
                    {
                        mAllCells[x, y].GetComponent<Image>().color = new Color32(230, 220, 187, 255);
                    }

                    if (x == 0)
                    {
                        mAllCells[x, y].GetComponent<Cell>().mLetterPlace.text = (y + 1).ToString();
                        mAllCells[x, y].GetComponent<Cell>().mLetterPlace.enabled = true;
                    }

                    if (y == 0)
                    {
                        mAllCells[x, y].GetComponent<Cell>().mNumberPlace.text = cellLetters[x];
                        mAllCells[x, y].GetComponent<Cell>().mNumberPlace.enabled = true;
                    }
                }
            }
        }
    }
}