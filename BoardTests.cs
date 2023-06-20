using MemoryGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGameTests
{
    public class BoardBuilderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BoardBuilder_Should_Build_ConsoleBoard_WithLength2()
        {
            var board = new ConsoleBoardBuilder()
                .WithDimensions(2, 2)
                .Build();
            Assert.That(board.cells.Length, Is.EqualTo(2));
        }

        [Test]
        public void BoardBuilder_Should_Build_ConsoleBoard_WithLength4()
        {
            var board = new ConsoleBoardBuilder()
                .WithDimensions(4, 2)
                .Build();
            Assert.That(board.cells.Length, Is.EqualTo(4));
        }

        [Test]
        public void BoardBuilder_Should_Build_ConsoleBoard_WithLength6()
        {
            var board = new ConsoleBoardBuilder()
                .WithDimensions(4, 6)
                .Build();
            Assert.That(board.cells.Length, Is.EqualTo(4));
            for (int i = 0; i < 4; i++)
                Assert.That(board.cells[i].Length, Is.EqualTo(6));

        }
    }
}
