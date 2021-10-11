using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vampires
{
    class Infected : People
    {
        int InfectedDays;

        public Infected(string name, bool sex, double weakness, Room place, string[] answer)
            :base(name,sex,weakness,place,answer)
        {
            InfectedDays = 0;
        }
    }
}
