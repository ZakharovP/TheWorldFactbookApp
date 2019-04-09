using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TheWorldFactbookLib;

namespace TheWorldFactbookParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Country rus = new Country()
            {
                Name = "Russia",
                Capital = "Moscow",
                Geography = new Geography()
                {
                    TotalArea = 100
                },
                Population = new Population()
                {
                    Amount = 150
                },
                Economy = new Economy()
                {
                    GDPtotal = 200,
                    GDPppp = 1
                }
            };

            Country ger = new Country()
            {
                Name = "Germany",
                Capital = "Berlin",
                Geography = new Geography()
                {
                    TotalArea = 50
                },
                Population = new Population()
                {
                    Amount = 80
                },
                Economy = new Economy()
                {
                    GDPtotal = 150,
                    GDPppp = 10
                }
            };
            XmlSerializer formatter = new XmlSerializer(typeof(Country[]));
            
            String filename = "test.xml";
            Country[] countries = new Country[] { rus, ger };
            using (StreamWriter writer = new StreamWriter(new FileStream(filename, FileMode.Create, FileAccess.Write)))
            {
                formatter.Serialize(writer, countries);
            }
            using (StreamReader reader = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read)))
            {
                Country[] tmp = (Country[])formatter.Deserialize(reader);
            }
        }
    }
}
