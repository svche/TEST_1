using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{ 
//Затем создать меню в котором будут на выбор следующие функции:
//                                                    -- Вывести список студентов;
//                                           Показать средний возраст студентов;
//           --  Показать минимальный и максимальный возраст студентов и соответственно этих студентов;
//  !!! Сортировка по: фамилии - году рождения - группе - факультету и соответственно после этого вывести отсортированный список;
//                                       Выход. Меню можно использовать пока не выберем выход.
    class Program
    {
        public struct Student
        {
            public string lastname;
            public int born;
            public string faculty;
            public string group;
        }
        static void Main(string[] args)
        {

            //if (choice == 1)
            //{
            //    for (int i = 0; i < countStudents; i++)
            //    {
            //        Console.WriteLine("Student {0}: {1}, {2}, {3}, {4}.\n", i, students[i].lastname, students[i].born,
            //            students[i].faculty, students[i].group);
            //    }
            //    Console.WriteLine();
            //}




            //if (choice == 2)
            //{
            //    for (int i = 0; i < countStudents; i++)
            //    {
            //        for (int j = 0; j < countStudents; j++)
            //        {

            //        }
            //    }
            //}

            int countOfStudents = 6;
            Student[] students = new Student[countOfStudents];

            students[0].lastname = "Fenenko";

            Console.WriteLine(students[0].lastname[0][1]);


            


        }
    }
}
