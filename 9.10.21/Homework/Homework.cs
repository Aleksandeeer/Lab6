using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework
{
    class Homework
    {
        static FileInfo filePasssword = new FileInfo(@"C:\\Users\\Huawei\\source\\repos\\ClassTasks9.10.21\\passwords.txt");
        static void Main()
        {
            Console.WriteLine("Homework 1");
            using (StreamReader filePasswordRead = filePasssword.OpenText())
            {
                string passwordBinary = filePasswordRead.ReadToEnd();
                Console.Write("Введите строку возможных паролей: ");
                string inputPasswords = Console.ReadLine();
                object result = CheckPasword(inputPasswords.Split(), passwordBinary);
                try
                {
                    bool unboxingresult = (bool)result;
                    Console.WriteLine("Правильного пароля нет!");
                }
                catch
                {
                    string unboxingresult = (string)result;
                    Console.WriteLine("Пароль: " + unboxingresult);
                }
            }

            Console.WriteLine("\nHomework 2");
            Console.Write("Введите фразу из 4 слов: ");
            string inputUser = Console.ReadLine().Trim();
            if (inputUser.Split().Length != 4)
            {
                throw new FormatException("Wrong number of words in pharse. Task 2");
            }
            inputUser = ConvertStrRuToRamsayLanguage(inputUser);
            Console.WriteLine(inputUser);

            Console.ReadKey();
        }
        static object CheckPasword(string[] userPasswords, string passwordBinary)
        {
            string password = "";
            foreach (var item in passwordBinary.Split())
            {
                if (CheckBinarityOfString(item))
                {
                    throw new FormatException("Task 1. Char From file do not have binary form!");
                }
                password += (char)Convert.ToInt32(item, 2);
            }
            foreach (var item in userPasswords)
            {
                if (item.Equals(password))
                {
                    return item;
                }
            }
            return false;
        }
        static bool CheckBinarityOfString(string s)
        {
            if (s.Length != 8)
            {
                return false;
            }
            foreach (var item in s.ToCharArray())
            {
                if (item != '0' || item != '1')
                {
                    return false;
                }
            }
            return true;
        }
        static string ConvertStrRuToRamsayLanguage(string str)
        {
            string strNewFormat = "";
            foreach (var item in str.ToCharArray())
            {
                if (item == 'А' || item == 'а')
                {
                    strNewFormat += '@';
                }
                else if (Array.IndexOf("уоиэыюеёя".ToCharArray(), Char.ToLower(item)) != -1)
                {
                    strNewFormat += '*';
                }
                else if (item == ' ')
                {
                    strNewFormat += "!!! ";
                }
                else
                {
                    strNewFormat += item;
                }
            }
            strNewFormat += "!!!";
            return strNewFormat.ToUpper();
        }
    }
}
