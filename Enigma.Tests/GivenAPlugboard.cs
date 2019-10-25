using NUnit.Framework;

namespace Enigma.Tests
{
    [TestFixture]
    [Parallelizable]
    public class GivenAPlugboard
    {
        private Plugboard _subject;

        [OneTimeSetUp]
        public void WhenNoConfigurationHasBeenDefined()
        {
            _subject = new Plugboard();
        }

        [Test]
        public void ThenTheUsersInputIsNotModified()
        {
            Assert.That(_subject.Process('A'), Is.EqualTo('A'));
        }
    }
}