using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vampires
{
    class Corpse : People
    {
        public Corpse(string name, bool sex, double weakness, Room place, string[] answer)
            :base(name, sex, weakness, place, answer)
        {

        }
    }
}
