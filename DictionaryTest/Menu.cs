using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTest
{
    class Menu
    {
        Vocabulary vocabulary= new Vocabulary();
        UserIn user= new UserIn();
        bool end = false;

        public void Start()
        {
            Console.WriteLine("Vocabulary started. \n\n");

            while (!end)
            {
                Console.WriteLine("Enter choise:\n"+
                    "1.Add word\n" +
                    "2.Show word\n" +
                    "3.Show vocabulary\n" +
                    "4.Update word in vocabulary\n" +
                    "5.Delete word in vocabulary\n" +
                    "6.Exit program\n");

                int choise = user.UserEnterNumber();

                switch(choise)
                {

                    case 1:

                        Console.WriteLine("Enter word:");
                        string word = user.UserEnterString();
                        Console.WriteLine("Enter translate:");
                        string translate = user.UserEnterString();

                        vocabulary.AddWord(word, translate);
                        break;

                    case 2:

                        Console.WriteLine("Enter word to translate:");
                        string showWord= user.UserEnterString();
                        if (vocabulary.CheckKey(showWord))
                        {
                            Console.WriteLine("Translate:");
                            vocabulary.ShowWord(showWord);
                            Console.WriteLine("");
                        }
                        else
                            Console.WriteLine("No word found.");

                        break;

                    case 3:
                        Console.WriteLine("Vocabulary:");
                        vocabulary.ShowVoc();
                        Console.WriteLine("");
                        break;

                    case 4:
                        Console.WriteLine("Enter word to update:");
                        vocabulary.UpdateWord( user.UserEnterString());
                        Console.WriteLine("Word updated.\n");

                        break;

                    case 5:
                        Console.WriteLine("Enter word to delete:");
                        vocabulary.DeleteWord(user.UserEnterString());
                        Console.WriteLine("Word deleted.\n");

                        break;

                    case 6:

                        end = true;

                        break;

                    default:
                        break;



                }

                



            }
            
        }

        



    }
}
