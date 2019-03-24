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
            var fileName = @"C: \Users\hager\Desktop\DnDItemList\DnDItemListCSV.csv";
            var fileContents = NewWeapon.ReadFile(fileName);
            Console.WriteLine(fileContents);
            Console.ReadLine();
        }
    }
}