using System;
using Xunit;

namespace QuillGames.Sudoku.Tests
{
    public class SudokuTests
    {
        [Fact]
        public void Sudoku_Check_ValidPartiallyFinishedPuzzlesShouldCheckAsTrue()
        {
            // Arrange
            var puzzle = new Sudoku(ValidPuzzles.PartiallyFinished1);

            // Act
            var result = puzzle.Check();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Sudoku_Check_ValidPuzzlesShouldCheckAsTrue()
        {
            // Arrange
            var puzzle = new Sudoku(ValidPuzzles.Puzzle1);

            // Act
            var result = puzzle.Check();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Sudoku_GetCell_ReturnsNumberAtLocation()
        {
            // Arrange
            var puzzle = new Sudoku(ValidPuzzles.Puzzle1);

            // Act
            var num = puzzle.GetCell(1, 1);

            // Assert
            Assert.Equal(4, num);
        }

        [Fact]
        public void Sudoku_GetRow_ReturnsNumbersFromRow()
        {
            // Arrange
            var puzzle = new Sudoku(ValidPuzzles.Puzzle1);

            // Act
            var row = puzzle.GetRow(1);

            // Assert
            Assert.Equal(4, row[0]);
            Assert.Equal(3, row[1]);
            Assert.Equal(5, row[2]);
            Assert.Equal(2, row[3]);
            Assert.Equal(6, row[4]);
            Assert.Equal(9, row[5]);
            Assert.Equal(7, row[6]);
            Assert.Equal(8, row[7]);
            Assert.Equal(1, row[8]);
        }

        [Fact]
        public void Sudoku_GetCol_ReturnsNumbersFromColumn()
        {
            // Arrange
            var puzzle = new Sudoku(ValidPuzzles.Puzzle1);

            // Act
            var col = puzzle.GetCol(1);

            // Assert
            Assert.Equal(4, col[0]);
            Assert.Equal(6, col[1]);
            Assert.Equal(1, col[2]);
            Assert.Equal(8, col[3]);
            Assert.Equal(3, col[4]);
            Assert.Equal(9, col[5]);
            Assert.Equal(5, col[6]);
            Assert.Equal(2, col[7]);
            Assert.Equal(7, col[8]);
        }

        [Fact]
        public void Sudoku_GetCol_ReturnsNumbersFromMiddleColumn()
        {
            // Arrange
            var puzzle = new Sudoku(ValidPuzzles.Puzzle1);

            // Act
            var col = puzzle.GetCol(2);

            // Assert
            Assert.Equal(3, col[0]);
            Assert.Equal(8, col[1]);
            Assert.Equal(9, col[2]);
            Assert.Equal(2, col[3]);
            Assert.Equal(7, col[4]);
            Assert.Equal(5, col[5]);
            Assert.Equal(1, col[6]);
            Assert.Equal(4, col[7]);
            Assert.Equal(6, col[8]);
        }

        [Fact]
        public void Sudoku_GetSquare_ReturnsNumbersFromSquare()
        {
            // Arrange
            var puzzle = new Sudoku(ValidPuzzles.Puzzle1);

            // Act
            var square = puzzle.GetSquare(1);

            // Assert
            Assert.Equal(4, square[0]);
            Assert.Equal(3, square[1]);
            Assert.Equal(5, square[2]);
            Assert.Equal(6, square[3]);
            Assert.Equal(8, square[4]);
            Assert.Equal(2, square[5]);
            Assert.Equal(1, square[6]);
            Assert.Equal(9, square[7]);
            Assert.Equal(7, square[8]);
        }

        [Fact]
        public void Sudoku_GetSquare_ReturnsNumbersFromMiddleSquare()
        {
            // Arrange
            var puzzle = new Sudoku(ValidPuzzles.Puzzle1);

            // Act
            var square = puzzle.GetSquare(5);

            // Assert
            Assert.Equal(1, square[0]);
            Assert.Equal(9, square[1]);
            Assert.Equal(5, square[2]);
            Assert.Equal(6, square[3]);
            Assert.Equal(8, square[4]);
            Assert.Equal(2, square[5]);
            Assert.Equal(7, square[6]);
            Assert.Equal(4, square[7]);
            Assert.Equal(3, square[8]);
        }

    }
}
