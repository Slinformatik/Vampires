using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vampires
{
    class Doctor : People 
    {
        bool IsImmune;

        public Doctor(string name, bool sex, double weakness, Room place, string[] answer)
            : base(name, sex, weakness, place, answer)
        {
            IsImmune = true;
        }

        public Infected Healing(People ppl)
        {
            People temp = ppl;
            MainWindow.allPeople.Remove(ppl);
            ppl = null;
            return new Infected(temp.GetName(), temp.GetSex(), temp.GetWeakness(), ppl.GetPlace(), ppl.GetAnswer());
            
        }
    }
}
