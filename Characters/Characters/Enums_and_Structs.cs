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
        public int strength;
        public int dexterity;
        public int constitution;
        public int intelligence;
        public int wisdom;
        public int charisma;

        public AbilityScore(int str, int dex, int con, int inT, int wis, int cha)
        {
            strength = str;
            dexterity = dex;
            constitution = con;
            intelligence = inT;
            wisdom = wis;
            charisma = cha;
        }
    }
    struct Skills
    {
        public int acrobatics;
        public int animalHandling;
        public int arcana;
        public int athletics;
        public int deception;
        public int history;
        public int insight;
        public int intimidation;
        public int investigation;
        public int medicine;
        public int nature;
        public int perception;
        public int performance;
        public int persuation;
        public int religion;
        public int sleightOfHand;
        public int stealth;
        public int survival;

        /// <summary>
        /// Different skills
        /// </summary>
        /// <param name="acr">Acrobatics</param>
        /// <param name="ani">Animal Handling</param>
        /// <param name="arc">Arcana</param>
        /// <param name="ath">Athletics</param>
        /// <param name="dec">Deception</param>
        /// <param name="his">History</param>
        /// <param name="ins">Insight</param>
        /// <param name="inT">Intimidation</param>
        /// <param name="inv">Investigation</param>
        /// <param name="med">Medicine</param>
        /// <param name="nat">Nature</param>
        /// <param name="perC">Perception</param>
        /// <param name="perF">Performance</param>
        /// <param name="perS">Persuation</param>
        /// <param name="rel">Religion</param>
        /// <param name="sle">Sleight of Hand</param>
        /// <param name="ste">Stealth</param>
        /// <param name="sur">Survival</param>
        public Skills(int acr, int ani, int arc, int ath, int dec, int his, int ins, int inT, int inv, int med,
            int nat, int perC, int perF, int perS, int rel, int sle, int ste, int sur)
        {
            acrobatics = acr;
            animalHandling = ani;
            arcana = arc;
            athletics = ath;
            deception = dec;
            history = his;
            insight = ins;
            intimidation = inT;
            investigation = inv;
            medicine = med;
            nature = nat;
            perception = perC;
            performance = perF;
            persuation = perS;
            religion = rel;
            sleightOfHand = sle;
            stealth = ste;
            survival = sur;
        }
    }
    struct SavingThrows
    {
        public bool strength;
        public bool dexterity;
        public bool constitution;
        public bool intelligence;
        public bool wisdom;
        public bool charisma; 

        public SavingThrows(bool str, bool dex, bool con, bool inT, bool wis, bool cha)
        {
            strength = str;
            dexterity = dex;
            constitution = con;
            intelligence = inT;
            wisdom = wis;
            charisma = cha;
        }
    }

}
