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

            Console.WriteLine("Welcome to the DnD 5E item database");
            Console.WriteLine("Would you like to 1. View the items, 2. add an item, or 3. edit an existing item? Please type the number of your option.");
            var userResponse = Console.ReadLine();
            int userNumber = Convert.ToInt16(userResponse);

            switch (userNumber)
            {
                case 1:
                    ReadWrite.ViewData(fileName);
                    break;
                //case 2:
                //    ReadWrite.AddData();
                //    break;
                //case 3:
                //    ReadWrite.EditData();
                //    break;

            }
            Console.ReadLine();
        }
    }
}