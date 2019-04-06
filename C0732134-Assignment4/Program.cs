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
            p.ReadTextFiles();
            Console.ReadLine();
        }

        public void Run()
        {
            this.ReadTextFiles();
        }


        public void ReadTextFiles()
        {
            // Read file using StreamReader. Read file line by line
            using (StreamReader file = new StreamReader("U:/Users/732134/Peter/5 April, 2019/C0732134-Assignment4/Beowulf.txt"))
            {
                int counter = 0, words=0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);                    
                    counter++;                   
                }
                file.Close();
                //FindNumberOfBlankSpaces(Beowulf);
                Console.WriteLine($"\n\n\t\t\tFile has {counter} lines.\n");                                // Section A

                Console.WriteLine($"\t\t\tFile has {ToCountWords()} words.\n");                                          // Section B
                FindBothOfTheWords();                                   // Section C  &  D
                FindAvgLetterOfaWord();                                 // Section E

            }
        }
        public long ToCountWords()                                                              // Section B               
        {
            long countWords = 0;
            int place = 0;
            String takeLine;
            StreamReader takeInputFromTextFile = new StreamReader("U:/Users/732134/Peter/5 April, 2019/C0732134-Assignment4/Beowulf.txt");
            takeLine = takeInputFromTextFile.ReadToEnd();

            string word = takeLine.Trim();

            while (place < word.Length)
            {
                while (place < word.Length && !char.IsWhiteSpace(word[place]))
                    place++;

                countWords++;

                while (place < word.Length && char.IsWhiteSpace(word[place]))
                    place++;
            }

            return countWords;
        }

        public void FindBothOfTheWords ()                                                                           // Section C
        {
            int temp=0;
            foreach (var item in File.ReadAllLines("U:/Users/732134/Peter/5 April, 2019/C0732134-Assignment4/Beowulf.txt"))
            {
                temp++;
                if (item.Contains("sea") && item.Contains("fare"))                                              // Section C
                    Console.WriteLine($"Sea and Fare Occured at {temp} Line");

                else if (item.Contains("fare") && (!item.Contains("war")) )                                    // Section D
                    Console.WriteLine($" \t\t\t\t\t\tFare without the word War came at {temp} Line");
            }
           
        }


        public void FindAvgLetterOfaWord()                                                                  // Section E
        {
            long totalWords = ToCountWords();
            double avg = 0.0;
            float sum = 0;
            foreach (var item in File.ReadAllLines("U:/Users/732134/Peter/5 April, 2019/C0732134-Assignment4/Beowulf.txt"))
            {
                sum += item.Length;
            }
            avg = sum / (float)totalWords;
            avg = Math.Round(avg, 3);
            Console.WriteLine($"\n\n\nThe Average Letters per Word is {avg}");
        }
    }
}
