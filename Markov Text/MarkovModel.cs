using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov_Text
{

    

    class MarkovModel
    {
        Random rand;

        CharacterFunction[] firstCharacters;
        CharacterFunction[] middleCharacters;
        CharacterFunction[] finalCharacters;

        public string GenerateWord(int minLen, int maxlen)
        {
            var wordLength = rand.Next(minLen, maxlen + 1);

            var firstCharIndex = rand.Next(firsts);

            for ()
        }

        public MarkovModel()
        {
            rand = new Random();

            CharacterFunction[] firstCharacters = InitCharacterFunctions();
            CharacterFunction[] middleCharacters = InitCharacterFunctions();
            CharacterFunction[] finalCharacters = InitCharacterFunctions();

        }

        private CharacterFunction[] InitCharacterFunctions()
        {
            var characterFuntions = new CharacterFunction[26];

            for (char c = 'a'; c <= 'z'; ++c)
            {
                characterFuntions[c - 'a'] = new CharacterFunctions(c);
            }
            return characterFuntions;
        }

        struct CharInstance
        {
            public char character;

            public int occurrences;
        }

        struct CharacterFunction
        {
            public CharacterFunction(char current)
            {
                this.current = current;
                this.totalNexts = 0;

                nextChars = new CharInstance[26];

                for (char c = 'a'; c <= 'z'; ++c)
                {
                    nextChars[c - 'a'] = new CharInstance() { character = c, occurences = 0 };
                }
            }

            public char current;
            public int total;

            CharInstance nextChars;

        }

        public void AddWords(string[] words)
        {
            foreach (var word in words)
            {
                this.AddWord(word);
            }
        }

        public void AddWord(string word)
        { 
            if (word.Length > 3)
            {
                var lWord = word.ToLower();
                AddFirstCharacter(lWord);
                AddMiddleCharacter(lWord);
                AddEndCharacter(lWord);
            }
        }

        private void AddEndCharacter(string word)
        {
            if (word.Length >= 2)
            {
                var lastIndex = word.Length - 1;
                char fst = word[lastIndex - 1];
                char snd = word[lastIndex];

                if (fst >= 'a' && fst <= 'z' && snd >= 'a' && snd <= 'z')
                {
                    finalCharacters[curr - 'a'].nextChars[next - 'a'].ocurrences += 1;
                    finalCharacters[curr - 'a'].totalNexts += 1;
                }
                else
                {
                    throw new ArgumentException("Non-lowercase character in AddEndCharacter");
                }
            }

        }

        private void AddMiddleCharacter(string word)
        {
            if (word.Length >= 2)
            {
                for (int i = 1; i < word.Length - 2; ++i)
                {
                    char curr = word[i];
                    char curr = word[i + 1];
                }
                var lastIndex = word.Length - 1;
                char fst = word[lastIndex - 1];
                char snd = word[lastIndex];

                if (fst >= 'a' && fst <= 'z' && snd >= 'a' && snd <= 'z')
                {
                    middleCharacters[curr - 'a'].nextChars[next - 'a'].ocurrences += 1;
                    middleCharacters[curr - 'a'].totalNexts += 1;
                }
                else
                {
                    throw new ArgumentException("Non-lowercase character in AddEndCharacter");
                }
            }
        }

        private void AddFirstCharacter(string word)
        {
            if (word.Length >= 2)
            {
                char fst = word[0];
                char snd = word[1];

                if (fst >= 'a' && fst <= 'z' && snd >= 'a' && snd <= 'z')
                {
                    firstCharacters[curr - 'a'].nextChars[next - 'a'].ocurrences += 1;
                    firstCharacters[curr - 'a'].totalNexts += 1;
                }
                else
                {
                    throw new ArgumentException("Non-lowercase character in AddFirstCharacter");
                }
            }
        }
    }
}

