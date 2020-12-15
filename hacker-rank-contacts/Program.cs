using System;
using System.Collections.Generic;

namespace hacker_rank_contacts
{
    class Program
    {
        static void Main()
        {
            string[][] operations = new string[9][];
            operations[0] = new string[] { "add", "hack" };
            operations[1] = new string[] { "add", "hackerrank" };
            operations[2] = new string[] { "add", "cap" };
            operations[3] = new string[] { "add", "card" };
            operations[3] = new string[] { "add", "paralelepipedo" };
            operations[4] = new string[] { "find", "cap" };
            operations[5] = new string[] { "find", "car" };
            operations[6] = new string[] { "find", "hat" };
            operations[7] = new string[] { "find", "hac" };
            operations[8] = new string[] { "find", "paralelu" };
            Contacts(operations);
        }

        static void Contacts(string[][] queries)
        {
            Node root = new Node();
            for (int i = 0; i < queries.Length; i++)
            {
                if (queries[i][0].Equals("add"))
                {
                    Insert(queries[i][1], root);
                }
                else
                {
                    bool result = Search(queries[i][1], root);
                    if (result)
                    {
                        Console.WriteLine("Found!");
                    }
                    else
                    {
                        Console.WriteLine("Not Found!");
                    }
                }
            }
            Console.ReadKey();
        }

        static void Insert(string word, Node current)
        {
            char[] characteres = word.ToCharArray();
            foreach (char c in characteres)
            {
                Node child = current.Children.GetValueOrDefault(c);
                if (child is null)
                {
                    child = new Node();
                    current.Children.Add(c, child);
                }
                if (c.Equals(characteres.GetLastItem()))
                    child.IsCompleteWord = true;
                current = child;
            }
        }

        static bool Search(string key, Node current)
        {
            bool founded = true;
            char[] characteres = key.ToCharArray();
            foreach (char c in characteres)
            {
                Node child = current.Children.GetValueOrDefault(c);
                if (child is null)
                    founded = false;
                current = child;
            }
            return founded;
        }

        static int GetWordsCountThatStartWith(string key, Node current)
        {
            //get words count that starts with specific key.
            
            
        }
    }
}
