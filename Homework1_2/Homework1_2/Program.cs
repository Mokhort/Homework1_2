using System;
using System.IO;
namespace Homework1_2
{
    class Program
    {
        static int nod(int a, int b) {
            int t;
            while (b != 0)
            {
                t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
    

        static void Main(string[] args)
        {
            Console.WriteLine("Start programm\n");

            if (args.Length == 0)
            {
                Console.WriteLine("Please enter argument - file.txt.");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine($"parameter count = {args.Length}");

                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine($"Arg[{i}] = [{args[i]}]");
                }
                string path = args[0];

                int len = System.IO.File.ReadAllLines(path).Length;
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    int i = 0;
                    int j = 0;
                    int[] mas = new int[len]; 

                       while ((line = sr.ReadLine()) != null)
                       { 
                           mas[i] = Int32.Parse(line);
                           //Console.WriteLine(mas[i]);
                           i++;
                       }
                    Console.WriteLine("Result:\n");
                    for (i = 0; i < len-1; i++) {
                        for (j = i+1; j < len; j++)
                        {
                            if ((mas[i] > 0)&&(mas[j] > 0)){

                                if (nod(mas[i],mas[j]) ==1)
                                Console.WriteLine("{0} {1}",mas[i],mas[j]);                         
                            }
                        }
                    }
                }

            }
            Console.ReadKey();

        }
    }
}
