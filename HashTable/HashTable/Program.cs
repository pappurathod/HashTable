using System;
namespace HashTable
{
    class Program
    {
        public static void CountWordFrequency(string sentence, MyMapNode<string, int> frequencyDictionary)
        {
            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                if (frequencyDictionary.Exists(word))
                {
                    frequencyDictionary.Add(word, frequencyDictionary.Get(word) + 1);
                }
                else
                {
                    frequencyDictionary.Add(word, 1);
                }
            }
            frequencyDictionary.PrintDictionary();            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hash table program");
            MyMapNode<string, int> frequencyDictionary = new MyMapNode<string, int>(10);
            CountWordFrequency("To be or not to be", frequencyDictionary);
            Console.ReadLine();
        }
    }

}
