using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraindoRPGcomPOO.src.Entities
{
    abstract class  Hero
    {
        public Hero(string name, int level, string heroType,int hp,int mp)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            HP = hp;
            MP = mp;
        }

        
        protected string Name { get; set; }
        protected int Level { get; set; }
        protected string HeroType { get; set; }
        protected int HP { get; set; }
        protected int MP { get; set; }

        public override string ToString()
        {
            return "Nome: " + this.Name + Environment.NewLine + "lvl: " + this.Level + Environment.NewLine + "Classe: " + this.HeroType + Environment.NewLine+
                "HP: "+this.HP+Environment.NewLine+"MP: "+this.MP;
        }

        public virtual string Ataque() 
        {
            return this.Name + " Atacou com sua espada";
        }

        public virtual string Ataque(int bonus)
        {
            if (bonus > 6)
            {
                return Name + " Efetuou um ataque de espada super efetivo com bônus de " + bonus;

            }
            else
            {
                return Name + " Efetuou um ataque de espada com força fraca com bônus de ataque de " + bonus;
            }
        }
    }
}
