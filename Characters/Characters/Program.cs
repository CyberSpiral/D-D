using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            DDClass druid = new DDClass(new Skills(0,1,1,0,0,0,1,0,0,1,1,1,0,0,1,0,0,1),"Greatsword, staff",
                new SavingThrows[2] { new SavingThrows(true,false,false,false,false,false), new SavingThrows(false,false,false,true,false,false)},
                )
        }
    }
}
