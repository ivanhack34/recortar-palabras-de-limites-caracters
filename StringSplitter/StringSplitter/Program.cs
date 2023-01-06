using System;
using System.Collections.Generic;
using System.Linq;

namespace StringSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputComment = "Creame con javascript, separame en una cadena de 50 caracteres en cadenas de 10 caracteres. Sin cortar las palabras.";
            string inputString = inputComment;
            List<string> substrings = SplitString(inputString, 10);

            // Imprimimos el resultado
            foreach (string substring in substrings)
            {
                Console.WriteLine(substring);
            }
        }

        static List<string> SplitString(string inputString, int chunkSize)
        {
            string[] arrayComment = inputString.Split(' ');
            List<string> resultComment = new List<string>();

            string chunk = "";

            foreach (string word in arrayComment)
            {
                if ((chunk + " " + word).Length > chunkSize)
                {
                    resultComment.Add(chunk);
                    chunk = "";
                }
                chunk += " " + word;
            }

            if (chunk != "")
            {
                resultComment.Add(chunk);
            }

            return resultComment;
        }
    }
}
