using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork14
{
    [Serializable]
    [XmlRoot("Main")]
    public class AllData
    {
        [XmlArray("Cowsheds")]
        [XmlArrayItem("Cowshed")]
        public List<Cowshed> Cowsheds { get; set; } = new List<Cowshed>();

        [XmlArray("People")]
        [XmlArrayItem("Person")]
        public List<Person> People { get; set; } = new List<Person>();

        [XmlArray("Bulls")]
        [XmlArrayItem("Bull")]
        public List<Bull> Bulls { get; set; } = new List<Bull>();

        [XmlArray("Cows")]
        [XmlArrayItem("Cow")]
        public List<Cow> Cows { get; set; } = new List<Cow>();
    }
}
