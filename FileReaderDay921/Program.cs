using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReaderDay921
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Create an instance of StreamReader to read from a file
            StreamReader reader = new StreamReader("..\\..\\..\\Sample.txt");
            string line = reader.ReadLine();
            //Console.WriteLine(firstLine);

            int lineNumber = 0;

            while(line!= null)
            {
                lineNumber++;
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                line = reader.ReadLine();

            }
            reader.Close();
            
            /*
            StreamWriter writer = new StreamWriter("..\\..\\Aswers.txt");

            using (writer)
            {
                writer.WriteLine("Write anything.");
            }

            

            StreamWriter writer = new StreamWriter("..\\..\\numbers.txt");

            using (writer)
            {
                for(int i=1; i<=20; i++)
                {
                    writer.WriteLine(i);
                }


                
            }
            */
        }
    }
}
