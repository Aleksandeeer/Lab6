using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace ClassTasks9._10._21
{
    class Class
    {
        struct Student
        {
            public string name;
            public string surname;
            public ushort YearOfBirth;
            public string subject;
            public ushort scores;
        }

        private const string PathToListStudent = @"C:\\Users\\Huawei\\source\\repos\\ClassTasks9.10.21\\Students.txt";
        static void Main()
        {
            //Console.WriteLine("Task 1");
            //int count;
            //Console.Write("Введите количество викингов в каждой команде:");
            //count = Convert.ToInt32(Console.ReadLine());
            //int[] BavarianBeerBears = new int[count];
            //int[] ScandinavianSchollers = new int[count];
            //for (int i = 0; i < count; i++)
            //{
            //    Console.Write($"{i + 1} викинг из \"Bavarian Beer Bears\" показал: ");
            //    BavarianBeerBears[i] = Convert.ToByte(Console.ReadLine());
            //}
            //for (int i = 0; i < count; i++)
            //{
            //    Console.Write($"{i + 1} викинг из \"Scandinavian Schollers\" показал: ");
            //    ScandinavianSchollers[i] = Convert.ToByte(Console.ReadLine());
            //}
            //var BavariansFive = BavarianBeerBears.Count(x => x == 5);
            //Console.WriteLine("Количество пятёрок в \"Bavarian Beer Bear\": " + BavariansFive);
            //var SchollersFive = ScandinavianSchollers.Count(x => x == 5);
            //Console.WriteLine("Количество пятёрок в \"Bavarian Beer Bear\": " + SchollersFive);
            //if (BavariansFive == SchollersFive)
            //{
            //    Console.WriteLine("Drinks All Round! Free Beers on Bjorg!");
            //}
            //else
            //{
            //    Console.WriteLine("Ой, Бьорг - пончик! Ни для кого пива!");
            //}

            //Console.WriteLine("\nTask 2");
            //List<int> Pictures = new List<int>();
            //string Numberfromfile; int numberofstring = 0;
            //StreamReader sr = new StreamReader("C:\\Users\\Huawei\\source\\repos\\ClassTasks9.10.21\\Numbers.txt");
            //while ((Numberfromfile = sr.ReadLine()) != null)
            //{
            //    Pictures[numberofstring] = Convert.ToInt32(Numberfromfile);
            //    numberofstring++;
            //}
            //Random rnd = new Random();
            //foreach (int numb in Pictures)
            //{
            //    int random = rnd.Next(0, 63);
            //    int buffer = Pictures[random];
            //    Pictures[random] = Pictures[numb];
            //    Pictures[numb] = buffer;
            //    Console.WriteLine(Pictures[numb] + ", ");
            //}

            Console.WriteLine("\nTask 3");
            string stringfromfile; int numberString = 1;
            Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();
            StreamReader fileTextRead = new StreamReader(PathToListStudent);
                while ((stringfromfile = fileTextRead.ReadLine()) != null) //считывание файла построчно пока не кончатся символы
                {
                    string[] dateStudent = stringfromfile.Split();
                    Student studentNew; //создание нового студента
                    studentNew.surname = dateStudent[0];
                    studentNew.name = dateStudent[1];
                    studentNew.YearOfBirth = Convert.ToUInt16(dateStudent[2]);
                    studentNew.subject = dateStudent[3];
                    studentNew.scores = Convert.ToUInt16(dateStudent[4]);
                    studentDictionary.Add(dateStudent[0] + " " + dateStudent[1], studentNew);
                    numberString++; //переход на следующую строку
                }
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("* * * Меню * * *\n1.Добавить нового студента\n2.Удалить студента по имени и фамилии\n3. Сортировать по баллам");
                Console.Write("Выберите действие. Нажми цифру: ");
                byte choiсe = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();
                switch (choiсe)
                {
                    case 1:
                        Student studentNew;
                        Console.Write("Введите имя: ");
                        studentNew.name = Console.ReadLine();
                        Console.Write("Введите фамилию студента: ");
                        studentNew.surname = Console.ReadLine();
                        Console.Write("Введите год рождения: ");
                        studentNew.YearOfBirth = Convert.ToUInt16(Console.ReadLine());
                        Console.Write("Введите основной предмет: ");
                        studentNew.subject = Console.ReadLine();
                        Console.Write("Введите количество баллов: ");
                        studentNew.scores = Convert.ToUInt16(Console.ReadLine());
                        studentDictionary.Add(studentNew.name + " " + studentNew.surname, studentNew);
                        break;
                    case 2:
                        Console.Write("Введите имя и фамилию студента: ");
                        string studentRemove = Console.ReadLine();
                        if (!studentDictionary.Remove(studentRemove))
                        {
                            Console.WriteLine("Ошибка: такого студента не существует");
                        }
                        break;
                    case 3:
                       // studentDictionary = studentDictionary.OrderBy(item => item.Value.scores).ToDictionary(item => item.Key, item => item.Value);
                        List<Student> studentsList = new List<Student>();
                        foreach (var item in studentDictionary)
                        {
                            studentsList.Add(item.Value);
                        }
                        foreach (var item in QuickSortListStruct(studentsList))
                        {
                            Console.WriteLine(item.name + " " + item.surname + " "
                                + item.YearOfBirth + " " + item.subject + " " + item.scores);
                        }
                        break;
                    default:
                        flag = false;
                        break;
                }
            }

            Console.WriteLine("\nTask 4");
            Console.WriteLine("\nTask 5"); //не сделал оба














            Console.ReadKey();
        }
        
        static List<Student> QuickSortListStruct(List<Student> list)
        {
            int left = 0, right = list.Count() - 1;
            Student a, b;
            if (left >= right)
            {
                return list;
            }
            var fundation = left - 1;
            for (var i = left; i < right; i++)
            {
                if (list[i].scores < list[right].scores)
                {
                    fundation++;
                    a = list[fundation];
                    b = list[i];
                    Swap(ref a, ref b);
                }
            }
            return list;
        }
        static List<Student> QuickSortListStruct(List<Student> list, int left, int right)
        {
            Student a, b;
            if (left >= right)
            {
                return list;
            }
            var fundation = left - 1;
            for (var i = left; i < right; i++)
            {
                if (list[i].scores < list[right].scores)
                {
                    fundation++;
                    a = list[fundation];
                    b = list[i];
                    Swap(ref a, ref b);
                }
            }

            fundation++;
            a = list[fundation];
            b = list[right];
            Swap(ref a, ref b);
            QuickSortListStruct(list, left, fundation - 1);
            QuickSortListStruct(list, fundation + 1, right);

            return list;
        }
        static void Swap(ref Student x, ref Student y)
        {
            var t = x;
            x = y;
            y = t;
        }
    }
}