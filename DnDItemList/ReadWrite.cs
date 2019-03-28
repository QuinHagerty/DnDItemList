using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDItemList
{
    class ReadWrite
    {
        public static List<Weapon> ViewData(string fileName)
        {

            //List<Weapon> fileContents = ReadWrite.ViewData(fileName);

            List<Weapon> DnDWeaponList = new List<Weapon>();

            using (var reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var columns = line.Split(',');
                    var Weapon = new Weapon()
                    {
                        Name = columns[0],
                        Category = columns[1],
                        Damage = columns[2],
                        DamageType = columns[3],
                        ItemRarity = columns[4],
                        Properties = columns[5],
                        Range = columns[6],
                        Weight = columns[7]
                    };
                    DnDWeaponList.Add(Weapon);
                }
                foreach (Weapon weapon in DnDWeaponList)
                {
                    Console.Write(
                    weapon.Name + "," +
                    weapon.Category + "," +
                    weapon.Damage + "," +
                    weapon.DamageType + "," +
                    weapon.ItemRarity + "," +
                    weapon.Properties + "," +
                    weapon.Range + "," +
                    weapon.Weight +
                    Environment.NewLine);
                }
            }
            return DnDWeaponList;
        }

        public static void AddData(List<Weapon> NewWeapons, string path)
        {
            string WeaponString = string.Empty;

            foreach (Weapon weapon in NewWeapons)
            {
                WeaponString +=
                weapon.Name + "," +
                weapon.Category + "," +
                weapon.Damage + "," +
                weapon.DamageType + "," +
                weapon.ItemRarity + "," +
                weapon.Properties + "," +
                weapon.Range + "," +
                weapon.Weight +
                Environment.NewLine;
            }
            File.WriteAllText(path, WeaponString);
        }

        private static List<Weapon> AddData(List<Weapon> fileContents)
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
