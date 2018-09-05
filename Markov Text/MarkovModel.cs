using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov_Text
{
    struct FirstCharacter
    {

    }

    struct MiddleCharacter
    {

    }

    struct FinalCharacter
    {

    }

    class MarkovModel
    {
        FirstCharacter[] firstCharacters = new FirstCharacter[26];
        MiddleCharacter[] middleCharacters = new MiddleCharacter[26];
        FinalCharacter[] finalCharacters = new FinalCharacter[26];

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
                AddFirstCharacter();
                AddMiddleCharacter();
                AddEndCharacter();
            }
        }

        private void AddEndCharacter()
        {
            throw new NotImplementedException();
            
        }

        private void AddMiddleCharacter()
        {
            throw new NotImplementedException();
        }

        private void AddFirstCharacter()
        {
            throw new NotImplementedException();
        }
    }
}

