using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;

namespace QuillGames.Sudoku
{
    public class Sudoku
    {
        /*
         *      Cols
         *        1  2  3  4  5  6  7  8  9
         * Rows +--------------------------+
         *   1  | 0| 1| 2| 3| 4| 5| 6| 7| 8|
         *   2  | 9|10|11|12|13|14|15|16|17|
         *   3  |18|19|20|21|22|23|24|25|26|
         *   4  |27|28|29|30|31|32|33|34|35|
         *   5  |36|37|38|39|40|41|42|43|44|
         *   6  |45|46|47|48|49|50|51|52|52|
         *   7  |54|55|56|57|58|59|60|61|62|
         *   8  |63|64|65|66|67|68|69|70|71|
         *   9  |72|73|74|75|76|77|78|79|80|
         *      +--------------------------+
         * 
         * Represents the numbers in the puzzle.
         * We will use 0 to denote an unfilled spot.
         */
        public readonly int[] _puzzle = new int[81];

        public Sudoku(int[] puzzleInitializer)
        {
            if (puzzleInitializer.Length < _puzzle.Length)
                throw new ArgumentException("Not enough spaces to initialize the puzzle.", nameof(puzzleInitializer));

            for (int i = 0; i < _puzzle.Length; i++)
            {
                if (puzzleInitializer[i] > 9 || puzzleInitializer[i] < 0)
                    throw new ArgumentException("All numbers must be be 0 (no entry), or 1 thru 9.");

                _puzzle[i] = puzzleInitializer[i];
            }
        }

        public bool Check()
        {
            bool IsValid(int[] numbers)
            {
                var count = numbers.Where(p => p != 0).Count();
                var distinct = numbers.Where(p => p != 0).Distinct().Count();

                return distinct == count;
            };

            // Assume valid until we see a bad row, col, or square.
            bool valid = true;
            int ix = 0;
            do
            {
                // Row
                valid = valid && IsValid(GetRow(ix + 1));

                // Col
                valid = valid && IsValid(GetCol(ix + 1));

                // Square
                valid = valid && IsValid(GetSquare(ix + 1));

                ix++;
            } while (valid && ix < 9);

            return valid;
        }

        public bool Completed()
        {
            return _puzzle.All(p => p > 0);
        }

        /// <summary>
        /// Gets a single cell from the puzzle. Rows and columns are indexed starting at 1.
        /// </summary>
        /// <remarks>
        /// Every access to a number should go through this method. If we follow
        /// this rule, then changing the way that the puzzle is 'backed' (such as 
        /// from a single array to a multi-dimensional), would only require changing
        /// this method.
        /// </remarks>
        /// <returns>The number at the cell.</returns>
        public int GetCell(int row, int col)
        {
            int r = row - 1, c = col - 1;
            return _puzzle[(r * 9) + c];
        }

        public void SetCell(int row, int col, int val)
        {
            if (val < 0 || val > 9)
                throw new ArgumentException("Value must be zero (clear cell) or 1 thru 9.");

            int r = row - 1, c = col - 1;
            _puzzle[(r * 9) + c] = val;
        }

        /// <summary>
        /// Gets a single row from the puzzle. Rows are indexed starting at 1.
        /// </summary>
        /// <returns>A sequence of integers in the row.</returns>
        public int[] GetRow(int row)
        {
            int[] rowNumbers = new int[9];
            for (int i = 0; i < rowNumbers.Length; i++)
            {
                rowNumbers[i] = GetCell(row, i + 1);
            }

            return rowNumbers;
        }

        /// <summary>
        /// Gets a single column from the puzzle. Columns are indexed starting at 1.
        /// </summary>
        /// <returns>A sequence of integers in the column.</returns>
        public int[] GetCol(int col)
        {
            int[] colNumbers = new int[9];
            for (int i = 0; i < colNumbers.Length; i++)
            {
                colNumbers[i] = GetCell(i + 1, col);
            }

            return colNumbers;
        }

        /// <summary>
        /// Gets a single square from the puzzle. Squares are indexed starting at 1.
        /// </summary>
        /// <returns>A sequence of integers in the square.</returns>
        public int[] GetSquare(int square)
        {
            int[] squareNumbers = new int[9];
            int rowOffset = ((square - 1) % 3 * 3) + 1;
            int colOffset = ((square - 1) % 3 * 3) + 1;

            int ix = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    squareNumbers[ix] = GetCell(row + rowOffset, col + colOffset);
                    ix++;
                }
            }

            return squareNumbers;
        }
    }
}
