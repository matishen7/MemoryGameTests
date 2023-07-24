using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGameTests
{
    public class BoardTests
    {
        [Test]
        public void Board_AllCardsFound_False()
        {
            var board = new ConsoleBoardBuilder()
                .WithDimensions(4, 6)
                .Build();
            var a = board.EndGame();
            Assert.That(a, Is.EqualTo(false));

        }

        [Test]
        public void Board_AllCardsFound_True()
        {
            var board = new ConsoleBoardBuilder()
                .WithDimensions(2, 2)
                .Build();
            for (var i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2;j++)
                    board.cells[i][j].SetAsFound();
            }
            var result = board.EndGame();
            Assert.That(result, Is.EqualTo(true));

        }

        [Test]
        public void Board_CheckIfCardsMatch_True()
        {
            var board = new ConsoleBoardBuilder()
                .WithDimensions(2, 2)
                .Build();
            var image1 = board.cells[0][0].GetImage();
            var image2 = board.cells[0][1].GetImage();
            var result = board.CheckIfCardsMatch(0,0,0,1);
            Assert.That(result, Is.EqualTo(true));

        }

        [Test]
        public void Board_CheckIfCardsMatch_False()
        {
            var board = new ConsoleBoardBuilder()
                .WithDimensions(2, 2)
                .Build();
            var image1 = board.cells[0][0].GetImage();
            var image2 = board.cells[1][1].GetImage();
            var result = board.CheckIfCardsMatch(0, 0, 1, 1);
            Assert.That(result, Is.EqualTo(false));

        }
    }
}
