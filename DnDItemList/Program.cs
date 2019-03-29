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
            var fileName = @"C:\Users\hager\Desktop\DnDItemList\DnDItemListCSV.csv";
            List<Weapon> DnDWeaponList = new List<Weapon>();
            ReadWrite.ReadData(fileName, DnDWeaponList);
            var Done = false;
            while (!Done)
            {
                Console.WriteLine("Welcome to the DnD 5E item database");
                Console.WriteLine("Would you like to 1. View the items, 2. add an item,  3. edit an existing item, or 4. Quit? Please type the number of your option.");

                var userResponse = Console.ReadLine();
                int userNumber = Convert.ToInt16(userResponse);

                switch (userNumber)
                {
                    case 1:
                        ReadWrite.ViewData(DnDWeaponList);
                        break;
                    case 2:
                        ReadWrite.AddData(DnDWeaponList);
                        break;
                    //case 3:
                    //    ReadWrite.EditData();
                    //    break;
                    case 4:
                        Done = true;
                        break;
                }
                ReadWrite.WriteData(fileName, DnDWeaponList);
            }
            //ReadWrite.WriteData(fileName, DnDWeaponList);
        }
    }
}