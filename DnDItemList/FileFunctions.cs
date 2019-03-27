using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDItemList
{
    class FileFunctions
    {
        public static List<Weapon> ReadFile(string fileName)
        {
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
                    
                    
                    // prevent duplicates
                    DnDWeaponList.Add(Weapon);
                }
            }
            return DnDWeaponList;
        }

        public static void WriteFile(List<Weapon> NewWeapons, string path)
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
    }
}
