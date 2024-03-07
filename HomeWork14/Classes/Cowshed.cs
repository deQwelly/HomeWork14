using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    [Serializable]
    public class Cowshed
    {
        private static int id = 1;

        public int ID { get; set; }
        public string Name { get; set; }
        public Cowshed(string name)
        {
            ID = id++;
            Name = name;
        }

        public Cowshed()
        {
            ID = id++;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}";
        }
    }
}
