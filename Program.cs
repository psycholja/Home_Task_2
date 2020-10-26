using System;
using System.Buffers;
using System.IO;

namespace Home_Task__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employees:\n");

            using (StreamReader sr = File.OpenText("HT2.csv"))

            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }
                    Console.ReadLine();
                
            }

        }
    }

        
        
       