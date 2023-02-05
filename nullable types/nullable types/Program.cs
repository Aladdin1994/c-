using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;

namespace nullable_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "abbas abbasov", "tural elxanli", "elsen deliyev", "koroglu itaparan", "abbasli sadiqov" };
            string opt;
            do
            {
                Console.WriteLine("\n1. Butun telebelere bax");
                Console.WriteLine("2.Yeni telebe elave et");
                Console.WriteLine("3. Telebeler uzre axtaris et");
                Console.WriteLine("4. Telebelerin adlarına bax");
                Console.WriteLine("5. Siyahıda adın olub olmadığına bax");
                Console.WriteLine("0. menudan cix");

                Console.WriteLine("\nsecim edin");
                opt = Console.ReadLine();
                switch (opt)
                { 
                    case "1":
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i]);
                        }
                        break;
                    case "2":
                        Console.WriteLine("telebenin adini daxil edin");
                        string std;
                       
                        do
                        {
                             std = Console.ReadLine();
                            if (std.Length >=3)
                            { 
                                Array.Resize(ref students, students.Length + 1);
                            
                                students[students.Length - 1] = std;
                           

                            }
                        }
                          
                         while (std.Length<=3);
                         break;
                      case "3":
                         Console.WriteLine("axtarix deyeri daxil et");

                          string input1 = Console.ReadLine();
                          bool isExist = false;

                        for(int i=0; i < students.Length; i++)
                        {
                            if (students[i].ToLower().Contains(input1) || students[i].ToUpper().Contains(input1))
                            {
                                Console.WriteLine(students[i]);
                                isExist = true;
                            }
                            else
                                Console.WriteLine("bele shexs yoxdur");
                            break;
                        }
                         

                                break;

                        case "4":
                        Console.WriteLine("adlar");
                        string name;
                        string[] names;
                        for(int i = 0; i < students.Length; i++)
                        {
                           names = students[i].Split(' ');
                            name= names[0];
                           
                           Console.WriteLine(name);
                        }
                        
                        break;
                         case "5":
                        Console.WriteLine("are name there");// ad ordadi?
                        Console.ReadLine();
                        string input = Console.ReadLine();
                       string search = input;
                        for(int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i].Contains(search));
                            if (true)
                            {
                                Console.WriteLine("var");
                                break;
                            }
                        }
                        if(false)
                        {
                            Console.WriteLine("yox");
                            break;
                        }

                        break;
                        case "0":
                        Console.WriteLine("Proses bitdi");
                       break;
                      default:
                        Console.WriteLine("yeniden cehd");
                          break;


                }
            } while (opt != "0");
             

            
        }
    }
}
 