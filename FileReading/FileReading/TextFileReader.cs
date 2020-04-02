using System;
using System.IO;

namespace FileReading
{
    public class TextFileReader
    {
        public void ReadTextFile(string textFile)
        {
            string[] text = File.ReadAllLines(textFile);

            foreach (string line in text)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();

        }
    }
}