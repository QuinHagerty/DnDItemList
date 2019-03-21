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
            var fileContents = ReadFile(fileName);
            Console.WriteLine(fileContents);
            Console.ReadLine();
        }

        public static List<Weapon> ReadFile(string fileName)
        {
            List<Weapon> DnDWeaponList = new List<Weapon>();
            //return reader.ReadToEnd();

            using (var reader = new StreamReader(fileName))
            {
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var data = line.Split(',');
                    var Weapon = new Weapon
                    {
                        Name = data[0],
                        Category = data[1],
                        Damage = data[2],
                        DamageType = data[3],
                        ItemRarity = data[4],
                        Properties = data[5],
                        Range = data[6],
                        Weight = data[7]
                    };
                    // prevent duplicates
                    DnDWeaponList.Add(Weapon);
                }
                foreach (Weapon weapon in DnDWeaponList)
                {
                    Console.WriteLine(weapon.Name + " " + weapon.Category + " " + weapon.Damage + " " + weapon.DamageType + " " + weapon.ItemRarity + " " + weapon.Properties + " " + weapon.Range + " " + weapon.Weight + ".");
                }
            }

            return DnDWeaponList;
        }
    }
}