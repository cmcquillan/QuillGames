﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuillGames.Sudoku.Tests
{
    public static class ValidPuzzles
    {
        public static int[] Puzzle1 = new int[]
        {
            4, 3, 5, 2, 6, 9, 7, 8, 1,
            6, 8, 2, 5, 7, 1, 4, 9, 3,
            1, 9, 7, 8, 3, 4, 5, 6, 2,

            8, 2, 6, 1, 9, 5, 3, 4, 7,
            3, 7, 4, 6, 8, 2, 9, 1, 5,
            9, 5, 1, 7, 4, 3, 6, 2, 8,

            5, 1, 9, 3, 2, 6, 8, 7, 4,
            2, 4, 8, 9, 5, 7, 1, 3, 6,
            7, 6, 3, 4, 1, 8, 2, 5, 9
        };

        public static int[] PartiallyFinished1 = new int[]
        {
            4, 3, 0, 2, 6, 0, 7, 8, 1,
            6, 8, 2, 5, 7, 1, 4, 9, 3,
            1, 9, 0, 0, 0, 4, 5, 0, 2,

            0, 2, 6, 1, 9, 5, 3, 4, 7,
            3, 0, 4, 6, 0, 2, 0, 1, 5,
            9, 5, 0, 7, 4, 3, 6, 2, 8,

            5, 1, 9, 3, 0, 6, 8, 7, 4,
            2, 0, 8, 9, 0, 0, 1, 0, 6,
            7, 6, 3, 4, 0, 0, 2, 5, 9
        };
    }
}
