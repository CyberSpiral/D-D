using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    class Background
    {
        Skills skillProficiencies;
        string feature;
        string toolProficiencies;
        string[] languages;
        string equipment;


        /// <param name="s">Skill Proficiencies</param>
        /// <param name="f">Feature</param>
        /// <param name="l">Languages</param>
        /// <param name="e">Equipment</param>
        /// <param name="tp">Tool Proficiencies</param>
        public Background(Skills s, string f, string[] l, string e, string tP)
        {
            skillProficiencies = s;
            feature = f;
            toolProficiencies = tP;
            languages = l;
            equipment = e;
        }

        /// <param name="s">Skill Proficiencies</param>
        /// <param name="f">Feature</param>
        /// <param name="e">Equipment</param>
        /// <param name="tp">Tool Proficiencies</param>
        public Background(Skills s, string f, string e, string tP)
        {
            skillProficiencies = s;
            toolProficiencies = tP;
            feature = f;
            equipment = e;
        }

        /// <param name="s">Skill Proficiencies</param>
        /// <param name="f">Feature</param>
        /// <param name="l">Languages</param>
        /// <param name="e">Equipment</param>
        public Background(Skills s, string f, string[] l, string e)
        {
            skillProficiencies = s;
            feature = f;
            languages = l;
            equipment = e;
        }
    }
}
