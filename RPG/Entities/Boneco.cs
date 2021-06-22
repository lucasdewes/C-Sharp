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
        public decimal HP { get; set; }
        public decimal BaseDamage { get; set; }
        public decimal CritChance { get; set; }
        public decimal CritAmmount { get; set; }
        public decimal Armor { get; set; }

        public Boneco()
        {
        }

        public Boneco(string name, decimal hP, decimal baseDamage, decimal critChance, decimal critAmmount, decimal armor)
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
            return $"Name: {Name}, HP: {HP}, Damage: {BaseDamage}, Armor: {Armor}, CritCance: {CritChance}%, CritX: {CritAmmount}";
        }

        public decimal DamageAmount()
        {
            decimal minValue = BaseDamage * 0.9m;
            decimal maxValue = BaseDamage * 1.1m;
            Random random = new Random();
            if (random.Next(100) <= CritChance)
            {
                return decimal.Round(
                    (decimal)random.NextDouble() * maxValue - minValue + minValue * (CritAmmount / 100)
                    , 1);
            }
            else
            {
                return decimal.Round((decimal)random.NextDouble() * (maxValue - minValue) + minValue, 1);
            }
        }

        public void LvlUp(decimal lvlUP)
        {
            HP += HP * lvlUP;
            BaseDamage += BaseDamage * lvlUP;
            CritChance += CritChance * lvlUP;
            CritAmmount += CritAmmount * lvlUP;
            Armor += Armor * lvlUP;
        }
    }
}