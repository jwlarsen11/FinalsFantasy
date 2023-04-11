using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalsFantasy
{
    public class Entity
    {
        protected int defense;
        protected int hitPoints;
        protected int intelligence;
        protected int magicDefense;
        protected string name;
        protected int skillPoints;
        protected int speed;
        protected int strength;
        protected bool isDefending;

        public string Attack(Entity target)
        {
            throw new System.NotImplementedException();
        }

        public string Defend()
        {
            throw new System.NotImplementedException();
        }
    }
}