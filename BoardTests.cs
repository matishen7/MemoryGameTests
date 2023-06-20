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
        public void BoardBuilder_Should_Build_ConsoleBoard()
        {
            var board = new ConsoleBoardBuilder()
                .WithDimensions(2, 2)
                .Build();
            Assert.That(board.cells.Length, Is.EqualTo(2));
        }
    }
}
