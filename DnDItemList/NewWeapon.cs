using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDItemList
{
    class NewWeapon
    {
        public static List<Weapon> ReadFile(string fileName)
        {
            List<Weapon> DnDWeaponList = new List<Weapon>();

            using (var reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
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
            }

            return DnDWeaponList;
        }

        public static void WriteFile(List<Weapon> NewWeapons, string path)
        {
            // using (var fileStream = new FileStream(String.Format("Person{0}.txt", Id), FileMode.OpenOrCreate))
            using (var streamWriter = new StreamWriter(path))
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
                    "/n";

                    //append
                }

                //write
            }
        }
    }
}
