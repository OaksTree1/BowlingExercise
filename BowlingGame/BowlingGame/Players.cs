using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    internal class Players
    {
        public string Name { get; set; }
        public int Skill { get; set; }


        public Players(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }

    }
}




