using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTest
{
    class Vocabulary
    {
        private Dictionary<string, List<string>> dictionary = new Dictionary<string,List<string>>();




        public bool CheckKey(string key)
        {
            if (dictionary.ContainsKey(key))
                return true;
            return false;
        }


        public void AddWord(string word, string translate)
        {
            if(CheckKey(word))
            {
                dictionary[word].Add(translate);
                Console.WriteLine("Word added. \n");
            }
            else
            {
                dictionary.Add(word, new List<string>());
                dictionary[word].Add(translate);
                Console.WriteLine("Word added. \n");
            }
        }

        public void DeleteWord(string key)
        {
            if (dictionary.ContainsKey(key))
                dictionary.Remove(key);
            else
                Console.WriteLine("No word found.\n");
        }

        public void UpdateWord(string key)
        {
            UserIn userIn = new UserIn();
            if (dictionary.ContainsKey(key))
            {
                Console.WriteLine("Select update:\n"+
                    "1.Update word \n" +
                    "1.Update translate \n");
                int choise = userIn.UserEnterNumber();

                if (choise == 1)
                {
                    Console.WriteLine("Enter new word:");
                    string updatedWord = userIn.UserEnterString();
                    dictionary.Add(updatedWord, dictionary[key]);
                    DeleteWord(key);
                }
                else if (choise == 2)
                {
                    dictionary[key] = new List<string>();
                    Console.WriteLine("Enter new translate:");
                    dictionary[key].Add(userIn.UserEnterString());
                }
                else
                    Console.WriteLine("Wrong choise.");
                
            }

        }


        public void ShowWord(string key)
        {
            if (CheckKey(key))
            {
                foreach (var value in dictionary[key])
                {
                    Console.WriteLine(value);
                }
            }
            else { Console.WriteLine(" No word found.\n"); }
        }

        public void ShowVoc()
        {
            foreach (var value in dictionary)
            {
                Console.WriteLine(value.Key + ": ");
                foreach (var transl in value.Value)
                {
                    Console.WriteLine(transl);
                }
            }
        }

    }
}
