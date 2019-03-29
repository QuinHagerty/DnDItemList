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
        public static List<Weapon> ReadData(string fileName, List<Weapon>DnDWeaponList)
        {
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
            }
            
            return DnDWeaponList;
        }

        public static List<Weapon> ViewData(List<Weapon> DnDWeaponList)
        {
            foreach (Weapon weapon in DnDWeaponList)
            {
                Console.WriteLine(weapon.AsString());
            }
            return DnDWeaponList;
        }

        public static List<Weapon> AddData(List<Weapon> DnDWeaponList)
        {
            var newWeapon = new Weapon();
            EditWeapon(newWeapon);

            DnDWeaponList.Add(newWeapon);
            return DnDWeaponList;
        }

        public static void EditData(List<Weapon> DnDWeaponList, string path)
        {
            Console.WriteLine("What is the name of the item you wish to edit?");
            var editItem = Console.ReadLine();
            Weapon tmp = null;

            foreach (Weapon weapon in DnDWeaponList)
            {
                if (weapon.Name == editItem)
                {
                    tmp = weapon;
                    break;
                }
            }
            if(tmp == null)
            {
                // ERROR MSG
                return;
            }
            Console.WriteLine(tmp.AsString());
            EditWeapon(tmp);
        }

        public static void EditWeapon(Weapon newWeapon)
        {
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
        }


        public static void WriteData(string fileName, List<Weapon> DnDWeaponList)
        {
            string WeaponString = string.Empty;

                foreach (Weapon weapon in DnDWeaponList)
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
            File.WriteAllText(fileName, WeaponString);
        }
    }
}

//string WeaponString = string.Empty;

//           foreach (Weapon weapon in NewWeapons)
//           {
//               WeaponString +=
//               weapon.Name + "," +
//               weapon.Category + "," +
//               weapon.Damage + "," +
//               weapon.DamageType + "," +
//               weapon.ItemRarity + "," +
//               weapon.Properties + "," +
//               weapon.Range + "," +
//               weapon.Weight +
//               Environment.NewLine;
//           }
//           File.WriteAllText(path, WeaponString);