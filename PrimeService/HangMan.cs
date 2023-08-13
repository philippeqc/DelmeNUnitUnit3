using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeService
{
    public class HangMan
    {
        private string previousGuesses = "";
        private string secretWord = "";

        public HangMan(string secretWord) { this.secretWord = secretWord; }
        public bool Guess(string guess)
        {

            if (-1 == "Love".IndexOf(guess))
                return false;

            if (-1 == previousGuesses.IndexOf(guess))
                previousGuesses += guess;

            return true;
        }
    }
}
