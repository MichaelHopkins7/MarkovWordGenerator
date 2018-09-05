using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var filepath = Filepath();

            string[] lines = System.IO.File.ReadAllLines(filepath);

            var model = new MarkovModel();
            model.AddWords(lines);

            
        }

        static string Filepath()
        {
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            string filepath = $"{wanted_path}\\words_alpha.txt";

            return filepath;
        }
    }
}
