using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    class DDClass
    {
        bool isSpellCaster;
        HitDice hitDice;
        string[] toolProficiencies;
        SavingThrows[] savingThrows;
        Skills choosableSkills;
        string[] equipment;

        public DDClass(Skills cS, string[] eq, SavingThrows[] sT, string[] tP, HitDice hD, bool iSC)
        {
            isSpellCaster = iSC;
            hitDice = hD;
            toolProficiencies = tP;
            savingThrows = sT;
            choosableSkills = cS;
            equipment = eq;
        }

    }
}
