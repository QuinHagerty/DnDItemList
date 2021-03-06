﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDItemList
{
    class Weapon
    {
        public string Name;
        public string Category;
        public string Damage;
        public string DamageType;
        public string ItemRarity;
        public string Properties;
        public string Range;
        public string Weight;

        public string AsString()
        {
            return this.Name + "," +
            this.Category + "," +
            this.Damage + "," +
            this.DamageType + "," +
            this.ItemRarity + "," +
            this.Properties + "," +
            this.Range + "," +
            this.Weight;
        }
    }
}
