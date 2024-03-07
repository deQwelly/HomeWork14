using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    [Serializable]
    public class Mood
    {
        public bool AmIGood;
        public bool AmIFull;

        public Mood(bool amIGood, bool amIFull)
        {
            AmIGood = amIGood;
            AmIFull = amIFull;
        }

        public Mood() { }

        public override string ToString()
        {
            string s1 = "";
            string s2 = "";

            if (AmIGood)
            {
                s1 = "Mood: good, ";
            }
            else
            {
                s1 = "Mood: bad, ";
            }

            if (AmIFull)
            {
                s2 = "Fullness: yes";
            }
            else
            {
                s2 = "Fullness: no";
            }

            return s1 + s2;
        }
    }
}
