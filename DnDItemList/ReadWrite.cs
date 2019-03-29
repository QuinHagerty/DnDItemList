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
        //This method takes my CSV and uses a stream reader to read it into a list of weapon objects. This happens right when the app opens.
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

        //This method writes all the weapons currently in the database to the console for the user to read through.
        public static List<Weapon> ViewData(List<Weapon> DnDWeaponList)
        {
            foreach (Weapon weapon in DnDWeaponList)
            {
                Console.WriteLine(weapon.AsString());
            }
            return DnDWeaponList;
        }

        //This method promts the user about each property of the new weapon and saves it as that properties value then adds it to the existing list.
        public static List<Weapon> AddData(List<Weapon> DnDWeaponList)
        {
            var newWeapon = new Weapon();
            EditWeapon(newWeapon);

            DnDWeaponList.Add(newWeapon);
            return DnDWeaponList;
        }

        //This method lets the user go to an existing weapon and edit all of the property values and saves the item to the list.
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
                return;
            }
            Console.WriteLine(tmp.AsString());
            EditWeapon(tmp);
        }

        //This method helps keep my code dry by holding the promts for add and edit in one place.
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

        //This method runs at the end and writes the list back to a string to be saved as the CSV to be used next time the app is launched.
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