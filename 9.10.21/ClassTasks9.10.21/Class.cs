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
        static List<string> listMates = new List<string>();
        struct Student
        {
            public string name;
            public string surname;
            public ushort YearOfBirth;
            public string subject;
            public ushort scores;
        }



        struct Employee
        {
            public string name;
            public string position;
            public byte impudence;
            public bool stupidity;
            public List<Employee> mates;
        }
        struct Table
        {
            public string colour;
            public byte number;
            public List<Employee> persons;
        }



        struct Granny
        {
            public string name;
            public byte age;
            public List<Disease> diseases;
            public string medicine;
        }
        struct Hospital
        {
            public string name;
            public List<Disease> treatment;
            public List<Granny> patient;
            public ushort capacity;
        }
        enum Disease : byte
        {
            Оспа = 1,
            Грипп,
            Чахотка,
            Covid19,
            Артрит,
            Сифилис,
            Гепатит,
            Лихорадка
        }

        const string PathToStudent = @"..\..\files\Students.txt";
        const string PathToWorkersFull = @"..\..\files\WorkersFull.txt";
        const string PathToWorkersMini = @"..\..\files\WorkersMini.txt";
        const string PathToTables = @"..\..\files\Tables.txt";
        const string PathToHospitals = @"..\..\files\ListHospitals.txt";
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

            //Console.WriteLine("\nTask 3");
            //string stringfromfile; int numberString = 1;
            //Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();
            //StreamReader fileTextRead = new StreamReader(PathToListStudent);
            //    while ((stringfromfile = fileTextRead.ReadLine()) != null) //считывание файла построчно пока не кончатся символы
            //    {
            //        string[] dateStudent = stringfromfile.Split();
            //        Student studentNew; //создание нового студента
            //        studentNew.surname = dateStudent[0];
            //        studentNew.name = dateStudent[1];
            //        studentNew.YearOfBirth = Convert.ToUInt16(dateStudent[2]);
            //        studentNew.subject = dateStudent[3];
            //        studentNew.scores = Convert.ToUInt16(dateStudent[4]);
            //        studentDictionary.Add(dateStudent[0] + " " + dateStudent[1], studentNew);
            //        numberString++; //переход на следующую строку
            //    }
            //bool flag = true;
            //while (flag)
            //{
            //    Console.WriteLine("* * * Меню * * *\n1.Добавить нового студента\n2.Удалить студента по имени и фамилии\n3. Сортировать по баллам");
            //    Console.Write("Выберите действие. Нажми цифру: ");
            //    byte choiсe = Convert.ToByte(Console.ReadLine());
            //    Console.WriteLine();
            //    switch (choiсe)
            //    {
            //        case 1:
            //            Student studentNew;
            //            Console.Write("Введите имя: ");
            //            studentNew.name = Console.ReadLine();
            //            Console.Write("Введите фамилию студента: ");
            //            studentNew.surname = Console.ReadLine();
            //            Console.Write("Введите год рождения: ");
            //            studentNew.YearOfBirth = Convert.ToUInt16(Console.ReadLine());
            //            Console.Write("Введите основной предмет: ");
            //            studentNew.subject = Console.ReadLine();
            //            Console.Write("Введите количество баллов: ");
            //            studentNew.scores = Convert.ToUInt16(Console.ReadLine());
            //            studentDictionary.Add(studentNew.name + " " + studentNew.surname, studentNew);
            //            break;
            //        case 2:
            //            Console.Write("Введите имя и фамилию студента: ");
            //            string studentRemove = Console.ReadLine();
            //            if (!studentDictionary.Remove(studentRemove))
            //            {
            //                Console.WriteLine("Ошибка: такого студента не существует");
            //            }
            //            break;
            //        case 3:
            //           // studentDictionary = studentDictionary.OrderBy(item => item.Value.scores).ToDictionary(item => item.Key, item => item.Value);
            //            List<Student> studentsList = new List<Student>();
            //            foreach (var item in studentDictionary)
            //            {
            //                studentsList.Add(item.Value);
            //            }
            //            foreach (var item in QuickSortListStruct(studentsList))
            //            {
            //                Console.WriteLine(item.name + " " + item.surname + " "
            //                    + item.YearOfBirth + " " + item.subject + " " + item.scores);
            //            }
            //            break;
            //        default:
            //            flag = false;
            //            break;
            //    }
            //}

            Console.WriteLine("Task 4");
            Queue<Employee> queEmployee = new Queue<Employee>(); //обьявление всех переменных
            Stack<Table> stackTable = new Stack<Table>();
            Stack<Table> containerTable = new Stack<Table>();
            StreamReader FileTextWork = new StreamReader(PathToWorkersMini);
            string stringFromfile;

            while ((stringFromfile = FileTextWork.ReadLine()) != null) //считывание файла в лист
            {
                listMates.Add(stringFromfile);
            }

            AddTableFromFile(ref stackTable); //записывание столов в stack
            FillQueueOfEmployees(ref queEmployee); //записывание сотрудников в очередь

            while (queEmployee.Count != 0)
            {
                Employee currentEmployee = queEmployee.Dequeue(); //извлекает и возвращает первый элемент очереди
                Table tableLastFree;
                Table currentTable;
                tableLastFree.colour = "";
                tableLastFree.number = 0;
                tableLastFree.persons = new List<Employee>();
                bool flag2 = false;
                while (stackTable.Count != 0 && !flag2)
                {
                    currentTable = stackTable.Pop(); //Удаляет и возвращает объект в начале stack
                    if (currentTable.persons.Count == 0)
                    {
                        currentTable.persons.Add(currentEmployee);
                        stackTable.Push(currentTable); //Вставляет объект как верхний элемент стека Stack
                        flag2 = true;
                    }
                    else if (currentEmployee.stupidity)
                    {
                        if (currentTable.persons.Count < 3) //если людей за столом меньше 3ёх, то...
                        {
                            tableLastFree = currentTable;
                            foreach (var item in currentTable.persons.ToArray())
                            {
                                if (!GetExistingConnectionEmployees(item, currentEmployee)) //приписывание сотрудников к столу
                                {
                                    currentTable.persons.Add(currentEmployee);
                                    stackTable.Push(currentTable);
                                    flag2 = true;
                                }
                            }
                            if (!flag2)
                            {
                                containerTable.Push(currentTable);
                            }
                        }
                        else
                        {
                            containerTable.Push(currentTable);
                        }
                    }
                    else
                    {
                        if (currentEmployee.impudence > 0)
                        {
                            if (currentTable.persons.Count < 4)
                            {
                                tableLastFree = currentTable;
                                foreach (var item in currentTable.persons.ToArray())
                                {
                                    if (GetExistingConnectionEmployees(item, currentEmployee)) //приписывание сотрудников к столу
                                    {
                                        currentTable.persons.Add(currentEmployee);
                                        stackTable.Push(currentTable);
                                        flag2 = true;
                                    }
                                }
                                if (!flag2)
                                {
                                    containerTable.Push(currentTable);
                                }
                            }
                            else
                            {
                                containerTable.Push(currentTable);
                            }
                        }
                        else
                        {
                            if (currentTable.persons.Count < 3)
                            {
                                tableLastFree = currentTable;
                                foreach (var item in currentTable.persons.ToArray())
                                {
                                    if (GetExistingConnectionEmployees(item, currentEmployee))
                                    {
                                        currentTable.persons.Add(currentEmployee);
                                        stackTable.Push(currentTable);
                                        flag2 = true;
                                    }
                                }
                                if (!flag2)
                                {
                                    containerTable.Push(currentTable);
                                }
                            }
                            else
                            {
                                containerTable.Push(currentTable);
                            }
                        }
                    }
                }
                while (containerTable.Count != 0 && !flag2)
                {
                    currentTable = containerTable.Pop();
                    if (tableLastFree.number == currentTable.number)
                    {
                        tableLastFree.persons.Add(currentEmployee);
                        stackTable.Push(currentTable);
                        flag2 = true;
                    }
                    else
                    {
                        stackTable.Push(currentTable);
                    }
                }
                while (containerTable.Count != 0)
                {
                    stackTable.Push(containerTable.Pop());
                }
                if (!flag2)
                {
                    Console.WriteLine($"Cотруднику {currentEmployee.name} {currentEmployee.position} не досталось свободного места.");
                }
            }
            Console.WriteLine("\nСписок столов: ");
            foreach (var item in stackTable)
            {
                Console.WriteLine($"\nНомер стола - {item.number}\nЦвет стола - {item.colour}\nКоличество персон за столом: {item.persons.Count}" +
                    $"Персоны за столом: ");
                foreach (var person in item.persons)
                {
                    Console.WriteLine(person.name + " " + person.position);
                }
            }




            Console.WriteLine("Task 5");
            Queue<Granny> visitorsGranny = new Queue<Granny>();
            Stack<Granny> grannyDead = new Stack<Granny>();
            Stack<Hospital> hospitals = new Stack<Hospital>();
            Stack<Hospital> containerHospitals = new Stack<Hospital>();
            StreamReader fileTextRead = new StreamReader(PathToHospitals);
            bool flagExistingDesies = true, flagFound = true;
            string stringfromfile;
            int numberString = 1;

            while ((stringfromfile = fileTextRead.ReadLine()) != null)
            {
                string[] dateHospital = stringfromfile.Split('\\');
                if (dateHospital.Length != 3)
                {
                     Console.WriteLine($"Длина {numberString} строки не соответсвует формату");
                }
                else
                {
                    Hospital newHospital;
                    newHospital.name = dateHospital[0]; //имя больницы
                    newHospital.treatment = new List<Disease>(); //болезнь, лечение от которой оказывает эта больница
                    for (int i = 0; i < dateHospital[1].Length; i++)
                    {
                        newHospital.treatment.Add((Disease)(byte)dateHospital[1][i]);
                    }
                    ushort.TryParse(dateHospital[2], out newHospital.capacity);
                    newHospital.patient = new List<Granny>(); //пациент
                    hospitals.Push(newHospital);////Вставляет бабулю как верхний элемент стека Stack
                }
                numberString++;
            }
            Console.Write("Введите количество бабуль: ");
            if (!ushort.TryParse(Console.ReadLine(), out ushort numGranny))
            {
                throw new FormatException("Ошибка: введено некорректное значение. Повторите ввод");
            }
            for (int i = 1; i < numGranny + 1; i++)
            {
                Console.WriteLine($"{i} Бабуля:");
                Granny newGranny;
                Console.Write("Введите имя: ");
                newGranny.name = Console.ReadLine();
                Console.Write("Введите возраст: ");
                if (!byte.TryParse(Console.ReadLine(), out newGranny.age) || newGranny.age < 40)
                {
                    Console.WriteLine("Ошибка: введено некорректное значение. Попробуй снова");
                    i--;
                    continue;
                }
                newGranny.diseases = new List<Disease>();
                Console.WriteLine("Список болезней:\nОспа.\nГрипп.\nЧахотка.\nCovid19.\nАртрит.\nСифилиc.\nГепатит.\nЛихорадка.");
                while (flagExistingDesies)
                {
                    Console.Write("Введите болезень: ");
                    if (!byte.TryParse(Console.ReadLine(), out byte choiсe) || choiсe == 0 || choiсe > 8)
                    {
                        flagExistingDesies = false;
                    }
                    else
                    {
                        if (newGranny.diseases.Contains((Disease)choiсe))
                        {
                            Console.WriteLine("У бабушки уже есть такая болезнь!");
                        }
                        else
                        {
                            newGranny.diseases.Add((Disease)choiсe);
                        }
                    }
                }
                Console.Write("Введите название лекарcтва: ");
                newGranny.medicine = Console.ReadLine();
                visitorsGranny.Enqueue(newGranny);
            }
            while (visitorsGranny.Count != 0)
            {
                Granny grannyCurrent = visitorsGranny.Dequeue(); 
                Console.WriteLine($"Имя бабули: {grannyCurrent.name}\nЛекарство бабули: {grannyCurrent.medicine}\n" +
                    $"Возраст бабули: {grannyCurrent.age}\nБолезни бабушки: ");
                foreach (var item in grannyCurrent.diseases)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                while (hospitals.Count != 0 && flagFound)
                {
                    Hospital hospitalCurrent = hospitals.Pop();
                    if (hospitalCurrent.capacity != 0)
                    {
                        if (grannyCurrent.diseases.Count == 0)
                        {
                            hospitalCurrent.patient.Add(grannyCurrent);
                            hospitalCurrent.capacity--;
                            hospitals.Push(hospitalCurrent);
                            flagFound = false;
                        }
                        else if (KnowFateGranny(grannyCurrent.diseases, hospitalCurrent.treatment))
                        {
                            hospitalCurrent.patient.Add(grannyCurrent);
                            hospitalCurrent.capacity--;
                            hospitals.Push(hospitalCurrent);
                            flagFound = false;
                        }
                        else
                        {
                            containerHospitals.Push(hospitalCurrent);
                        }
                    }
                    else
                    {
                        containerHospitals.Push(hospitalCurrent);
                    }
                }
                while (containerHospitals.Count != 0)
                {
                    hospitals.Push(containerHospitals.Pop());
                }
                if (flagFound)
                {
                   grannyDead.Push(grannyCurrent);
                }
            }
            Console.WriteLine("\n\nСписок Больниц");
            foreach (var item in hospitals)
            {
                Console.WriteLine($"\n\nНазвание больницы: {item.name}");
                Console.WriteLine($"В больнице лечат: ");
                foreach (var treatment in item.treatment)
                {
                    Console.WriteLine(treatment + "\t");
                }
                Console.WriteLine($"В больнице лечатcя: ");
                foreach (var patient in item.patient)
                {
                    Console.WriteLine(patient.name + " " + patient.age + "лет(год)");
                }
                Console.WriteLine($"В больнице осталось свободных мест: {item.capacity}");



                Console.ReadKey();
            }
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
        static void FillQueueOfEmployees(ref Queue<Employee> queueEmployee)
        {
            List<Employee> listEmployees = new List<Employee>();
            StreamReader fileTextRead = new StreamReader(PathToWorkersFull);
            string stringfromfile;
            int numberString = 1;
            while ((stringfromfile = fileTextRead.ReadLine()) != null)
            {
                string[] dateEmployee = stringfromfile.Split();
                if (dateEmployee.Length != 4)
                {
                    Console.WriteLine($"Длина строки {numberString} не соответсвует формату. Работники");
                }
                else
                {
                    Employee newEmployee;
                    newEmployee.name = dateEmployee[0];
                    newEmployee.position = dateEmployee[1];
                    if (!byte.TryParse(dateEmployee[2], out newEmployee.impudence) || newEmployee.impudence > 10)
                    {
                        throw new FormatException($"Нагласть сотрудника строки {numberString} из файла не соответсвует формату");
                    }
                    newEmployee.stupidity = dateEmployee[3].Equals("тупой"); //сравнение двух экземпляров
                    if (newEmployee.stupidity)
                    {
                        if (newEmployee.impudence >= listEmployees.Count)
                        {
                            listEmployees.Insert(0, newEmployee); //вставляет элемент по указанному индексу
                        }
                        else if (newEmployee.impudence == 0)
                        {
                            listEmployees.Insert(listEmployees.Count - 1, newEmployee);
                        }
                        else
                        {
                            listEmployees.Insert(listEmployees.Count - newEmployee.impudence, newEmployee);
                        }
                    }
                    else
                    {
                        listEmployees.Add(newEmployee);
                    }
                }
                numberString++;
            }
            foreach (var item in listEmployees)
            {
                queueEmployee.Enqueue(item); //добавление элемента в конец очереди
            }
        }
        static void AddTableFromFile(ref Stack<Table> tables)
        {
            StreamReader fileTextRead = new StreamReader(PathToTables);
            string stringfromfile;
            int numberString = 1;
            while ((stringfromfile = fileTextRead.ReadLine()) != null)
            {
                string[] msTable = stringfromfile.Split();
                Table newTable;
                newTable.persons = new List<Employee>();
                newTable.colour = msTable[0];
                byte.TryParse(msTable[1], out newTable.number);
                tables.Push(newTable);
            }
            numberString++;
        }
        static bool GetExistingConnectionEmployees(Employee employee1, Employee employee2)
        {
            foreach (var item in listMates)
            {
                string strNameEmp1 = employee1.name + " " + employee1.position;
                string strNameEmp2 = employee2.name + " " + employee2.position;
                if (item.Contains(strNameEmp1) && item.Contains(strNameEmp2))
                {
                    return true;
                }
            }
            return false;
        }
            static bool KnowFateGranny(List<Disease> diseasesGranny, List<Disease> treatmentsHospital)
            {
                byte NumberCurableDisease = 0;
                foreach (var item in diseasesGranny)
                {
                    if (treatmentsHospital.Contains(item))
                    {
                        NumberCurableDisease++;
                    }
                }
                return (double)NumberCurableDisease / diseasesGranny.Count() >= 0.5; //возвращает значение если оно >= 0,5
            }
        }
}