using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    class Player
    {
        public string Name { get; set; }
        public DDClass[] chosenClasses { get; set; }
        public AbilityScore abilityScores { get; set; }
        public Skills skills { get; set; }
        public string proficiencies { get; set; }
        public Background background { get; set; }

        public Player()
        {

        }

        

    }
}
