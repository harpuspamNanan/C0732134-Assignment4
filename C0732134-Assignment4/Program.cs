using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732134_Assignment4
{
    class Program
    {
        ArrayList Beowulf;

        static void Main(string[] args)
        {

            Program p = new Program();
            p.Beowulf = new ArrayList();
        }

        public void Run()
        {
            this.ReadTextFiles();
        }


        public void ReadTextFiles()
        {
            // Read file using StreamReader. Read file line by line
            using (StreamReader file = new StreamReader("c:/area51/beowulf.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }


        public int FindNumberOfBlankSpaces(string line)
        {
            // https://stackoverflow.com/questions/17812566/count-words-and-spaces-in-s

            int countLetters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c))
                    countLetters++;
                if (char.IsWhiteSpace(c))
                    countSpaces++;
            }
            return countSpaces;
        }
        
    }
}
