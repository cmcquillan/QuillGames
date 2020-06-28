using System;
using Xunit;

namespace QuillGames.Sudoku.Tests
{
    public class SudokuTests
    {
        [Fact]
        public void Sudoku_ValidPuzzlesShouldCheckAsTrue()
        {
            // Arrange
            var puzzle = new Sudoku(ValidPuzzles.Puzzle1);

            // Act
            var result = puzzle.Check();

            // Assert
            Assert.True(result);
        }
    }
}
