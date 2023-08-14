using NUnit.Framework;

namespace HangManService.Tests
{
    [TestFixture]
    public class HangManTest
    {
        [Test]
        public void GuessingAllLettersCorrectlyInTheSecretWordIsASuccess()
        {
            var hangMan = new HangManService.HangMan("love");
            Assert.IsTrue(hangMan.CheckGuesses("love"));
        }

        [Test]
        public void MissingAnyLettersInTheSecretWordIsAFailure()
        {
            var hangMan = new HangManService.HangMan("love");
            Assert.IsFalse(hangMan.CheckGuesses("lov"));
        }

        [Test]
        public void MakingUpToLimitMistakeIsASuccess()
        {
            var badGuesses = "xyz";
            var hangMan = new HangManService.HangMan("love", badGuesses.Length);
            Assert.IsTrue(hangMan.CheckGuesses("lovexyz"));
        }

        [Test]
        public void MakingMoreThanLimitMistakeIsAFailure()
        {
            var badGuesses = "xyz";
            var hangMan = new HangManService.HangMan("love", badGuesses.Length - 1);
            Assert.IsFalse(hangMan.CheckGuesses("lovexyz"));
        }
    }
}