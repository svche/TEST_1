using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_1
{
    class Program
    {
        public struct Student
        {
            public string lastname;
            public int birth;
            public char faculty;
            public string group;
        }

        static void Main(string[] args)
        {
            int countOfStudents = 6;
            Student[] students = new Student[countOfStudents];
            int yearNow = 2017;
            int countOfgroup = 4;

            students[0].lastname = "Aaaa";
            students[0].birth = 1995;
            students[0].faculty = 'A';
            students[0].group = "A-10";

            students[1].lastname = "Bbbb";
            students[1].birth = 1997;
            students[1].faculty = 'A';
            students[1].group = "A-11";

            students[2].lastname = "Cccc";
            students[2].birth = 1996;
            students[2].faculty = 'B';
            students[2].group = "B-10";

            students[3].lastname = "Dddd";
            students[3].birth = 1998;
            students[3].faculty = 'B';
            students[3].group = "B-11";

            students[4].lastname = "Eeee";
            students[4].birth = 2000;
            students[4].faculty = 'C';
            students[4].group = "C-10";

            students[5].lastname = "Ffff";
            students[5].birth = 1999;
            students[5].faculty = 'C';
            students[5].group = "C-11";



            /* enter from console  
             
            Console.WriteLine("\tENTER INFORMATION ABOUT STUDENTS");

            Console.Write("\nHow many students do you want to save?: ");
            int countStudents = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < countStudents; i++)

            {
                Console.WriteLine("\nStudent {0}", (i + 1));

                Console.Write("Last name: ");
                students[i].lastname = Console.ReadLine();

                Console.Write("Year of birth: ");
                students[i].born = int.Parse(Console.ReadLine());

                Console.Write("Faculty: ");
                students[i].faculty = Console.ReadLine();

                Console.Write("Group: ");
                students[i].group = Console.ReadLine();
            }
            */

            Console.WriteLine("\nHere is {0} studentds in memory\n", countOfStudents);

            bool b = true;

            do
            {
                Menu();

                Console.Write("\nENTER THE NUMBER OF MENU:  ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)                                                   //student list
                {
                    Console.WriteLine("\nSTUDENTS LIST:");

                    for (int i = 0; i < countOfStudents; i++)

                    {
                        Console.WriteLine("\nStudent {0}", (i + 1));
                        Console.WriteLine("Last name: " + students[i].lastname);
                        Console.WriteLine("Birth: " + students[i].birth);
                        Console.WriteLine("Faculty: " + students[i].faculty);
                        Console.WriteLine("Group: " + students[i].group);
                    }
                    Console.WriteLine();
                }

                if (choice == 2)                                                    //sorting                                           
                {
                    Console.WriteLine("\nSORTING:");

                    for (int i = 0; i < countOfStudents; i++)                       // by lastname
                    {
                        for (int j = 0; j < countOfStudents - 1; j++)
                        {
                            if (students[j].lastname[0] > students[j + 1].lastname[0])
                            {
                                Student temp = students[j + 1];
                                students[j + 1] = students[j];
                                students[j] = temp;
                            }
                        }
                    }
                    Console.WriteLine("\nLastname\tBirth\t\tFaculty\t\tGroup\n");

                    for (int i = 0; i < countOfStudents; i++) Console.WriteLine(students[i].lastname +
                       "\t\t" + students[i].birth + "\t\t" + students[i].faculty + "\t\t" + students[i].group);
                    Console.WriteLine();


                    for (int i = 0; i < countOfStudents; i++)                       // by year of birth
                    {
                        for (int j = 0; j < countOfStudents - 1; j++)
                        {
                            if (students[j].birth < students[j + 1].birth)
                            {
                                Student temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                    Console.WriteLine("\n\nBirth\t\tLastname\tFaculty\t\tGroup\n");

                    for (int i = 0; i < countOfStudents; i++) Console.WriteLine(students[i].birth +
                       "\t\t" + students[i].lastname + "\t\t" + students[i].faculty + "\t\t" + students[i].group);
                    Console.WriteLine();


                    for (int i = 0; i < countOfStudents; i++)                       // by group
                    {
                        for (int j = 0; j < countOfStudents - 1; j++)
                        {
                            if (students[j].group[0] > students[j + 1].group[0])
                            {
                                Student temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                            else if (students[j].group[0] == students[j + 1].group[0])
                            {
                                for (int k = 1; k < countOfgroup; k++)
                                {
                                    if (students[j].group[k] > students[j + 1].group[k])
                                    {
                                        Student temp = students[j];
                                        students[j] = students[j + 1];
                                        students[j + 1] = temp;
                                    }
                                }
                               
                            }

                        }


                    }
                
                    
                        Console.WriteLine("\n\nGroup\t\tLastname\tBirth\t\tFaculty\n");

                        for (int i = 0; i < countOfStudents; i++) Console.WriteLine(students[i].group +
                           "\t\t" + students[i].lastname + "\t\t" + students[i].birth + "\t\t" + students[i].faculty);
                        Console.WriteLine();

                    }

                    if (choice == 3)
                    {
                        Console.WriteLine("\nAGE INFO:");

                        int[] years = new int[countOfStudents];
                        double sumYears = 0;
                        double averageYears = 0;

                        for (int i = 0; i < countOfStudents; i++)                       // average year
                        {
                            years[i] = yearNow - students[i].birth;
                            sumYears += years[i];
                        }
                        averageYears = sumYears / countOfStudents;

                        Console.WriteLine("\nAverage years is: " + averageYears);


                        int minAge = students[0].birth;
                        int maxAge = students[0].birth;                                //min & max year
                        int indMinAge = 0;
                        int indMaxAge = 0;

                        for (int i = 1; i < countOfStudents; i++)
                        {
                            if (students[i].birth > minAge)
                            {
                                minAge = students[i].birth;
                                minAge = yearNow - minAge;
                                indMinAge = i;
                            }
                            else
                            if (students[i].birth < maxAge)
                            {
                                maxAge = students[i].birth;
                                maxAge = yearNow - maxAge;
                                indMaxAge = i;
                            }
                        }

                        Console.WriteLine("\n\nBirth\t\tLastname\tFaculty\t\tGroup\n");

                        Console.WriteLine(students[indMinAge].birth + "\t\t" + students[indMinAge].lastname + "\t\t" +
                            students[indMinAge].faculty + "\t\t" + students[indMinAge].group + "\tMin age - " + minAge);

                        Console.WriteLine(students[indMaxAge].birth + "\t\t" + students[indMaxAge].lastname + "\t\t" +
                            students[indMaxAge].faculty + "\t\t" + students[indMaxAge].group + "\tMax age - " + (yearNow - maxAge));

                    }

                    if (choice == 4)
                    {
                        Console.WriteLine("\nEXIT");
                        b = false;
                    }

                } while (b) ;


            
}

        static void Menu()
        {
            Console.Write(@"
_______________________________________________________________
______________________S_E_L_E_C_T______________________________

        \1/               \2/           \3/          \4/       
    STUDENTS LIST       SORTING       AGE INFO       EXIT       
_______________________________________________________________");
            Console.WriteLine();
        }



    }
}



