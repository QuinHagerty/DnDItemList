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
            Console.WriteLine("Welcome to the DnD 5E item database");
            Console.WriteLine("Would you like to 1. View the items, 2. add an item, or 3. edit an existing item? Please type the number of your option.");
            userResponse = Console.ReadLine();

        switch (userResponse)
        {
            case 1: ViewItems
                foreach (Weapon weapon in DnDWeaponList)
                {
                    Console.WriteLine(
                        "Name:" + weapon.Name +
                        " Category:" + weapon.Category +
                        " Damage:" + weapon.Damage +
                        " Damage Type:" + weapon.DamageType +
                        " Item Rarity:" + weapon.ItemRarity +
                        " Properties:" + weapon.Properties +
                        " Range:" + weapon.Range +
                        " Weight:" + weapon.Weight +
                        ".");
                }
                break;
            case 2:
                Console.WriteLine();
                break;
            case 3:
                Console.WriteLine();
                break;

        }


            var fileName = @"C: \Users\hager\Desktop\DnDItemList\DnDItemListCSV.csv";
            List<Weapon> fileContents = FileFunctions.ReadFile(fileName);

            FileFunctions.WriteFile(NewWeapon(fileContents), fileName);
        }

        private static List<Weapon> NewWeapon(List<Weapon> fileContents)
        {
            var newWeapon = new Weapon();
            Console.WriteLine("Enter new weapon name: ");
            newWeapon.Name = Console.ReadLine();
            Console.WriteLine("Enter " + newWeapon.Name + " Category");
            newWeapon.Category = Console.ReadLine();
            Console.WriteLine("Enter " + newWeapon.Name + " Damage");
            newWeapon.Damage = Console.ReadLine();
            Console.WriteLine("Enter " + newWeapon.Name + " Damage Type");
            newWeapon.DamageType = Console.ReadLine();
            Console.WriteLine("Enter " + newWeapon.Name + " Item Rarity");
            newWeapon.ItemRarity = Console.ReadLine();
            Console.WriteLine("Enter " + newWeapon.Name + " Properties");
            newWeapon.Properties = Console.ReadLine();
            Console.WriteLine("Enter " + newWeapon.Name + " Range");
            newWeapon.Range = Console.ReadLine();
            Console.WriteLine("Enter " + newWeapon.Name + " Weight");
            newWeapon.Weight = Console.ReadLine();

            fileContents.Add(newWeapon);
            return fileContents;
        }
    }
}