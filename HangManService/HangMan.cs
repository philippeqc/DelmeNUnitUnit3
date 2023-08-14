using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HangManService
{
    public class HangMan
    {
        private string secretWord = "";
        private int badGuessLimit = 3;

        public HangMan(string secretWord, int badGuessLimit = 3)
        {
            this.secretWord = secretWord;
            this.badGuessLimit = badGuessLimit;
        }

        public bool CheckGuesses(string guesses)
        {
            int badGuess = 0;
            HashSet<char> remainingSecretLetters = new HashSet<char>(secretWord);
            foreach (var letterGuess in guesses)
            {
                if (-1 == secretWord.IndexOf(letterGuess))
                {
                    if (badGuess == badGuessLimit)
                        return false;
                    badGuess++;
                }
                else
                    remainingSecretLetters.Remove(letterGuess);
            }

            if(remainingSecretLetters.Count > 0)
                return false;
            return true;
        }
    }
}
