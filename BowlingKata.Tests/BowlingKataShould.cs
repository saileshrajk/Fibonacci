using NUnit.Framework;

namespace BowlingKata.Tests
{
    [TestFixture]
    public class BowlingKataShould
    {
        [Test]
        public void returns_10_for_a_strike()
        {
            var bowlingKata = new BowlingKata();

            var score = bowlingKata.GetScore("X");
            
            Assert.That(score,Is.EqualTo(10));
        }
    }
}
