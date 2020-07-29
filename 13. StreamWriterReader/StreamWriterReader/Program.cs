using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriterReader
{
    class Program
    {
        public static void ReadFile(string path)
        {
            try
            {
                using (StreamReader fileReader = new StreamReader(path))
                {
                    string line = fileReader.ReadLine();
                    while (line != null)
                    {
                        line = fileReader.ReadLine();
                        Console.WriteLine(line);
                    }

                    fileReader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Read: {ex.Message}" );
            }
        }

        public static void WriteFile(string path)
        {
            try
            {
                using (StreamWriter fileWriter = new StreamWriter(path))
                {
                    Random random = new Random();

                    Console.WriteLine("Insert the number of Random Values:");
                    int numberRandom = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i <= numberRandom; i++)
                    {
                        fileWriter.WriteLine(random.Next(50));
                    }

                    fileWriter.Close();
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Exception Write: {ex.Message}");
            }
        }

        static void Main(string[] args)
        {
            string path = "D:\\04. Proyectos\\StreamWriterReader\\test.txt";

            Console.WriteLine("Calling Method Write File");
            Console.WriteLine();
            WriteFile(path);
            Console.WriteLine();

            Console.WriteLine("Calling Method Read File");
            ReadFile(path);

            Console.ReadKey();

        }
    }
}
