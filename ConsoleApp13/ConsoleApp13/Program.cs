using System;
using System.Collections.Generic;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Student> students = new List<Student>();

            Student student1 = new Student()
            {
                FullName = " Adil Bayramov",
                No = 1                            
            };

            Student student2 = new Student()
            {
                FullName = " Rasim Eliyev",
                No = 2
            };

            Student student3 = new Student()
            {
                FullName = " Nihad Qurbanov",
                No = 3
            };
            do
            {    
                
            menu:

            Console.WriteLine("1. Tələbə əlavə et");
            Console.WriteLine("2. Tələbəyə imtahan əlavə et");
            Console.WriteLine("3. Tələbənin bir imtahan balına bax");
            Console.WriteLine("4. Tələbənin bütün imtahanlarını göstər");
            Console.WriteLine("5. Tələbənin imtahan ortalamasını göstər");
            Console.WriteLine("6. Tələbədən imtahan sil");
            Console.WriteLine("0. Proqramı bitir");

            chose:
                Console.WriteLine("Seciminizi edin:");
                string option = Console.ReadLine();

                switch(option)
                {
                    case "1":
                        Console.WriteLine("");                      
                        goto menu;
                    case "2":
                        Console.WriteLine();
                        goto menu;
                    case "3":
                        Console.WriteLine();
                        goto menu;
                    case "4":
                        Console.WriteLine();
                        goto menu;
                    case "5":
                        Console.WriteLine();
                        goto menu;
                    case "6":
                        Console.WriteLine();
                        goto menu;
                    case "0":
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Seciminiz yalnisdir");
                        goto chose;
                }

            } while (true);


        }
    }
}
