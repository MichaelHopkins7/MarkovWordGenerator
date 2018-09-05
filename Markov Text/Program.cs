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
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            string filepath = $"{wanted_path}\\words_alpha.txt";

            string[] lines = System.IO.File.ReadAllLines(filepath);

            Console.WriteLine(wanted_path);

            for (var i = 0; i < 10; ++i)
            {
                Console.WriteLine("\t" + lines[i]);
            }
        }
    }
}
