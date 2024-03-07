using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;

namespace HomeWork14
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CowshedApp());

            var coushed1 = new Cowshed("БурятаТВ");

            var person1 = new Person("Дадя Вася", 56, coushed1, new Mood(false, true));
            var person2 = new Person("Сын Петр", 25, coushed1, new Mood(true, true));

            var cow1 = new Cow("Маргооша", 4, coushed1, new Mood(true, true));
            var cow2 = new Cow("Жучка", 7, coushed1, new Mood(false, false));
            var cow3 = new Cow("Ромашка", 5, coushed1, new Mood(false, true));
            var cow4 = new Cow("Василиса", 6, coushed1, new Mood(true, true));

            var bull1 = new Bull("Бакенбард", 6, coushed1, new Mood(true, false));

            var data = new AllData()
            {
                Cowsheds = new List<Cowshed>() { coushed1 },
                Cows = new List<Cow>() { cow1, cow2, cow3, cow4 },
                Bulls = new List<Bull>() { bull1 },
                People = new List<Person>() { person1, person2 },
            };

            // xml serializing
            var xmlSerializer = new XmlSerializer(typeof(AllData));

            using (var fs = new FileStream("data.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, data);
            }

            // json serializing
            var jsonSerializing = JsonSerializer.Serialize(data);
            File.WriteAllText("data.json", jsonSerializing);
        }
    }
}
