using Microsoft.VisualBasic.FileIO;
using System;

namespace AccessModifiers_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course= new Course();

            string option;
            do
            {
                Console.WriteLine("\n1. Qrup elave et");
                Console.WriteLine("2. Bütün qruplara bax");
                Console.WriteLine("3. Verilmiş point aralığındaki qruplara bax");
                Console.WriteLine("4. Verilmiş nömrəsi qrupa bax");
                Console.WriteLine("5. Verilmiş qruplar üzrə axtarış et");
                Console.WriteLine("0. Menudan cıx");


                Console.WriteLine("\nSecim edin:");
                option = Console.ReadLine();

                switch(option)
                {
                    case "1":
                        Console.WriteLine("Group nomresi:");
                        string name=Console.ReadLine();

                        Console.WriteLine("orta qiymeti daxil et:");
                        double AvgPoint=Convert.ToDouble(Console.ReadLine());

                        Group group = new Group()
                        {
                            
                            NO = name,
                            Averagepoint = AvgPoint,

                        };
                            course.AddGroups(group);
                        break;
                        case "2":
                        for(int i = 0; i < course.groups.Length;i++)
                        {
                            Console.WriteLine($"\nName:{course.groups[i].NO}");
                            Console.WriteLine($"Average point:{course.groups[i].Averagepoint}");
                        }

                        break;
                        case "3":

                        Console.WriteLine("min Point:");
                        string minPoint = Console.ReadLine();
                        int min = Convert.ToInt32(minPoint);

                        Console.WriteLine("max Point:");
                        string maxPoint = Console.ReadLine();
                        int max = Convert.ToInt32(maxPoint);

                        for(int i=0; i < course.groups.Length; i++)
                        {
                            if (course.groups[i].Averagepoint >= min && course.groups[i].Averagepoint<=max)
                            {
                                Console.WriteLine($"{course.groups[i].NO}");
                                Console.WriteLine($"{course.groups[i].Averagepoint}");
                            }
                        }

                        break; 
                        case "4":
                        string categoryy = Console.ReadLine();

                        for (int  i = 0; i < course.groups.Length;i++)
                        {
                            if (course.groups[i].NO==categoryy)
                            {
                                Console.WriteLine((course.groups[i].NO));
                            }
                            else
                            {

                            }
                              
                        }

                        break;
                        case "5":
                      


                        break;
                        case "0":

                        break;
                    default:
                        Console.WriteLine("Secim duzgun deyil!");
                        break;
                }
            } while (option != "0");
        }
    }
}
