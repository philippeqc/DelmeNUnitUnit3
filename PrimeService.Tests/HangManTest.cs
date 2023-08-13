using NUnit.Framework;

namespace PrimeService.Tests
{
    [TestFixture]
    public class HangManTest
    {
        private PrimeService.HangMan _hangMan;
        [SetUp]
        public void Setup()
        {
            string secretWord = "Love";
            _hangMan = new PrimeService.HangMan(secretWord);
        }

        [Test]
        public void GuessingALetterFoundInSecretWordIsASuccess()
        {
            var letterInSecret = "L";
            var actual = _hangMan.Guess(letterInSecret);
            Assert.IsTrue(actual, $"The letter {letterInSecret} should be in the word");
        }

        [Test]
        public void GuessingALetterNotFoundInSecretWordIsAFailure()
        {
            var letterNotInSecret = "X";
            var actual = _hangMan.Guess(letterNotInSecret);
            Assert.IsFalse(actual, $"The letter {letterNotInSecret} should not be in the word");
        }

        [Test]
        public void GuessingAnAlreadyGuessedLetterIsNotAFailure()
        {
            var letterInSecret = "L";
            var actualFirstTest = _hangMan.Guess(letterInSecret);
            Assert.IsTrue(actualFirstTest, $"The letter {letterInSecret} should be in the word");
            var actualSecondGuess = _hangMan.Guess(letterInSecret);
            Assert.IsTrue(actualSecondGuess, $"Re-guessing the letter {letterInSecret} should not be valid");
        }


        [Test]
        public void GuessingAllLetterIsNotAFailure()
        {
            var letterInSecret = "L";
            var actualFirstTest = _hangMan.Guess(letterInSecret);
            Assert.IsTrue(actualFirstTest, $"The letter {letterInSecret} should be in the word");
            var actualSecondGuess = _hangMan.Guess(letterInSecret);
            Assert.IsTrue(actualSecondGuess, $"Re-guessing the letter {letterInSecret} should not be valid");
        }

    }

    [TestFixture]
    public class HangManTest2
    {

        [Test]
        public void GuessingAllLettersCorrectlyInTheSecretWordIsASuccess()
        {
            string secretWord = "love";
            var hangMan = new PrimeService.HangMan2(secretWord);
            var guesses = secretWord;
            Assert.IsTrue(hangMan.CheckGuesses(guesses));
        }


        [Test]
        public void MissingAnyLettersInTheSecretWordIsAFailure()
        {
            string secretWord = "love";
            var hangMan = new PrimeService.HangMan2(secretWord);
            var guesses = "lov";
            Assert.IsFalse(hangMan.CheckGuesses(guesses));
        }

        [Test]
        public void GuessingAnAbsentLetterAndAllLettersCorrectlyInTheSecretWordIsASuccess()
        {
            string secretWord = "love";
            var hangMan = new PrimeService.HangMan2(secretWord);
            var guesses = "y" + secretWord;
            Assert.IsTrue(hangMan.CheckGuesses(guesses));
        }


        [Test]
        public void MakingTooManyBadGuessIsAFailure()
        {
            string secretWord = "love";
            var hangMan = new PrimeService.HangMan2(secretWord, 3);
            var guesses = "wxyz";
            Assert.IsFalse(hangMan.CheckGuesses(guesses));
        }

        [Test]
        public void MakingTooManyBadGuessIsAFailureEvenMixedWithAllTheGoodGuess()
        {
            string secretWord = "love";
            var hangMan = new PrimeService.HangMan2(secretWord, 3);
            var guesses = secretWord + "wxyz";
            Assert.IsFalse(hangMan.CheckGuesses(guesses));
        }
    }
}