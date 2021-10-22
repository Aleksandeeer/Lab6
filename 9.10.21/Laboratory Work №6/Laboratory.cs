using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Laboratory_Work__6
{
    class Laboratory
    {
        static void Main()
        {
            Console.WriteLine("Task 6.1");
            string array = (File.ReadAllText("C:\\Users\\Huawei\\source\\repos\\ClassTasks9.10.21\\Буквы.txt"));
            Console.WriteLine($"Количество гласных: {GetCountVowels(array)}\nКоличество согласных: {GetCountConsonans(array)}");

            Console.WriteLine("\nTask 6.2");
            LinkedList<int> matrix1 = new LinkedList<int>();
            LinkedList<int> matrix2 = new LinkedList<int>();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Введите a({i + 1},{j + 1}) для 1ой и 2ой матрицы:");
                    matrix1.AddLast(Convert.ToInt32(Console.ReadLine()));
                    matrix2.AddLast(Convert.ToInt32(Console.ReadLine()));

                }
            }
            Console.WriteLine("1 - печать матриц\n2 - умножение матриц\nВыберите: ");
            try
            {
            start:
                int todo = Convert.ToInt32(Console.ReadLine());
                if (todo == 1)
                {
                    Press(matrix1, matrix2);
                }
                else if (todo == 2)
                {
                    Multiplication(matrix1, matrix2);
                }
                else
                {
                    Console.WriteLine("Ошибка: введеное неверное число. Повторите ввод: ");
                    goto start;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введён неверный формат.");
            }

            Console.WriteLine("\nTask 6.3");
            Random rnd = new Random();
            Dictionary<int, double> months = new Dictionary<int, double>(12);
            double sum; int numberofmonth = 0;
            double[] temperature = new double[30];
            for (int m = 0; m < 12; m++) //заполнение месяцей и дней температурами
            {
                sum = 0;
                for (int i = 0; i < 30; i++)
                {
                    temperature[i] = rnd.Next(120, 300)/10;
                    sum += temperature[i];
                }
                AverageTemperature(numberofmonth, sum, months); //метод для нахождения средних температур в каждом месяце
                numberofmonth++; //прибавление для метода
            }
            for (int k = 0; k < 12; k++) //сортировка массива средних температур
            {
                for (int l = 0; l < 12; l++)
                {
                    if (months[k] < months[l])
                    {
                        double buffer = months[k];
                        months[k] = months[l];
                        months[l] = buffer;
                    }
                }
            }
            Console.Write("Отсортированный массив: ");
            foreach(var celsium in months)
                Console.Write(celsium.Value + ", ");

            Console.ReadKey();
        }
        static void Press(LinkedList<int> Array1, LinkedList<int> Array2)
        {
            Console.WriteLine("1ая матрица:");
            for (int i = 0; i < 4; i++)
            {
               Console.Write(Array1.First() + " ");
               if (i == 1 || i == 3)
               {
                   Console.WriteLine();
               }
               Array1.RemoveFirst();
            }
            Console.WriteLine("2ая матрица:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(Array2.First() + " ");
                if (i == 1)
                {
                    Console.WriteLine();
                }
                Array2.RemoveFirst();
            }
        }
        static void Multiplication(LinkedList<int> matrix1, LinkedList<int> matrix2)
        {
            int a11, a12, a21, a22;
            a11 = matrix1.ElementAt(0) * matrix2.ElementAt(0) + matrix1.ElementAt(1) * matrix2.ElementAt(2);
            a12 = matrix1.ElementAt(0) * matrix2.ElementAt(1) + matrix1.ElementAt(1) * matrix2.ElementAt(3);
            a21 = matrix1.ElementAt(2) * matrix2.ElementAt(0) + matrix1.ElementAt(3) * matrix2.ElementAt(2);
            a22 = matrix1.ElementAt(2) * matrix2.ElementAt(1) + matrix1.ElementAt(3) * matrix2.ElementAt(3);
            Console.WriteLine(a11 + " " + a12 + "\n" + a21 + " " + a22);
        }
        static void AverageTemperature(int numberofmonth, double sum, Dictionary<int, double> months)
        {
            months[numberofmonth] = Math.Round(sum / 30, 2);
            Console.WriteLine($"в {numberofmonth + 1} месяце: " + months[numberofmonth]);
        }
        static int GetCountVowels (string array)
        {
            int lowelscount = 0;
            List<char> vowels = new List<char>() { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (array[i] == vowels[j])
                    {
                        lowelscount++;
                    }
                }
            }
            return lowelscount;
        }
        static int GetCountConsonans (string array)
        {
            int consonanscount = 0;
            List<char> consonans = new List<char>() { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ъ' };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < 23; j++)
                {
                    if (array[i] == consonans[j])
                    {
                        consonanscount++;
                    }
                }
            }
            return consonanscount;
        }
    }
}
