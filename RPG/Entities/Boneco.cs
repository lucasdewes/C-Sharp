using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities
{
    class Boneco
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int BaseDamage { get; set; }
        public int CritChance { get; set; }
        public int CritAmmount { get; set; }
        public int Armor { get; set; }

        public Boneco()
        {
        }

        public Boneco(string name, int hP, int baseDamage, int critChance, int critAmmount, int armor)
        {
            Name = name;
            HP = hP;
            BaseDamage = baseDamage;
            CritChance = critChance;
            CritAmmount = critAmmount;
            Armor = armor;
        }

        public string ShowStatus()
        {
            return $"Name: {Name}, HP: {HP}, Damage: {BaseDamage}, CritCance: {CritChance}%, CritX: {CritAmmount}";
        }
    }
}