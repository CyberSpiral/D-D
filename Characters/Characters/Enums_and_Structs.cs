using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    enum HitDice
    {
        d4 = 4, d6 = 6, d8 = 8, d10 = 10, d20 = 20
    }
    struct AbilityScore
    {
        int strength;
        int dexterity;
        int constitution;
        int intelligence;
        int wisdom;
        int charisma;
    }
    struct Skills
    {
        int acrobatics;
        int animalHandling;
        int arcana;
        int athletics;
        int deception;
        int history;
        int insight;
        int intimidation;
        int investigation;
        int medicine;
        int nature;
        int perception;
        int performance;
        int persuation;
        int religion;
        int sleightOfHand;
        int stealth;
        int survival;
    }
    struct SavingThrows
    {
        bool strength;
        bool dexterity;
        bool constitution;
        bool intelligence;
        bool wisdom;
        bool charisma; 
    }

}
