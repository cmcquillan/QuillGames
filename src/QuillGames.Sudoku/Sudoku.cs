using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace QuillGames.Sudoku
{
    public class Sudoku
    {
        public const int Unfilled = 0;

        /*
         * +--------------------------+
         * | 0| 1| 2| 3| 4| 5| 6| 7| 8|
         * | 9|10|11|12|13|14|15|16|17|
         * |18|19|20|21|22|23|24|25|26|
         * |27|28|29|30|31|32|33|34|35|
         * |36|37|38|39|40|41|42|43|44|
         * |45|46|47|48|49|50|51|52|52|
         * |54|55|56|57|58|59|60|61|62|
         * |63|64|65|66|67|68|69|70|71|
         * |72|73|74|75|76|77|78|79|80|
         * +--------------------------+
         * 
         * Represents the numbers in the puzzle.
         * We will use 0 to denote an unfilled spot.
         */
        public readonly int[] _puzzle = new int[81];

        /*
         * Represents the numbers which are read-only. 
         * These are the starter numbers for the puzzle
         */
        public readonly bool[] _readOnly = new bool[81];

        public Sudoku(int[] puzzleInitializer)
        {
            if (puzzleInitializer.Length < _puzzle.Length)
                throw new ArgumentException("Not enough spaces to initialize the puzzle.", nameof(puzzleInitializer));

            for (int i = 0; i < _puzzle.Length; i++)
            {
                _puzzle[i] = puzzleInitializer[i];
                _readOnly[i] = true;
            }
        }

        public bool Check()
        {
            return false;
        }
    }
}
