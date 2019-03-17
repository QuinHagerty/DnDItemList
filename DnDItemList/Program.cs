using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DnDItemList
{
    class Program
    {
        public static void Main(string[] args)
        {
        
            Console.WriteLine("Here");
            var fileName = @"C: \Users\hager\Desktop\DnDItemList\DnDItemListCSV.csv";
            var fileContents = ReadFile(fileName);
            Console.WriteLine(fileContents);
            Console.ReadLine();
        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
