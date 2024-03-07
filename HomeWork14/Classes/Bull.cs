using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    [Serializable]
    public class Bull
    {
        private static int id = 1;
        public int ID { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public Cowshed Cowshed { get; set; }
        public Mood Mood { get; set; }

        public Bull()
        {
            ID = id++;
        }

        public Bull(string name, byte age, Cowshed cowshed, Mood mood)
        {
            ID = id++;
            Name = name;
            Age = age;
            Cowshed = cowshed;
            Mood = mood;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}, Cowshed: {Cowshed.Name}, {Mood}";
        }
    }
}
