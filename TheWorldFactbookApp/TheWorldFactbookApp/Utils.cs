using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TheWorldFactbookLib;

namespace TheWorldFactbookApp
{
    public static class Utils
    {
        private static XmlSerializer Formatter = new XmlSerializer(typeof(Country[]));
        private const string ProgramName = @"THEWORLDFACTBOOK";
        private const string KeyName = @"LASTFILE";
        /// <summary>
        /// Get full path to the last opened file from Registry.
        /// If it was empty then default file is going to be returned.
        /// </summary>
        /// <returns>full path</returns>
        public static string GetLastFile(string defaultFile)
        {
            RegistryKey rkey = Registry.CurrentUser.OpenSubKey(ProgramName, true);
            if (rkey == null)
            {
                SetLastFile(defaultFile);
                rkey = Registry.CurrentUser.OpenSubKey(ProgramName, true);
            }
            return (string)rkey.GetValue(KeyName);
        }

        /// <summary>
        /// Set the file to Registry.
        /// </summary>
        /// <param name="file"></param>
        public static void SetLastFile(string file)
        {
            RegistryKey rkey = Registry.CurrentUser.OpenSubKey(ProgramName, true);
            if (rkey == null)
            {
                rkey = Registry.CurrentUser.CreateSubKey(ProgramName, true);
            }
            if (rkey.GetValue(KeyName) == null)
            {
                rkey.CreateSubKey(KeyName, true);
            }
            file = Path.GetFullPath(file);
            rkey.SetValue(KeyName, file);
        }

        public static void ClearRegistry()
        {
            Registry.CurrentUser.DeleteSubKeyTree(ProgramName);
        }

        public static Country[] ReadCountries(string filename)
        {
            Country[] countries;
            using (StreamReader reader = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read)))
            {
                countries = (Country[])Formatter.Deserialize(reader);
            }
            return countries;
        }
        public static void WriteCountries(string filename, Country[] countries) 
        {

        }
        public static void SetCountries2Table(Country[] countries, DataTable table)
        {
            table.Clear();
            for (int i = 0; i < countries.Length; i++)
            {
                DataRow dr = table.NewRow();
                UpdateDataRow(dr, countries[i]);
                table.Rows.Add(dr);
            }
        }
        public static void UpdateDataRow(DataRow dr, Country c)
        {
            dr[Country.NameLabel] = c.Name;
            dr[Country.CapitalLabel] = c.Capital;
            dr[Geography.TotalAreaLabel] = c.Geography.TotalArea;
            dr[Population.AmountLabel] = c.Population.Amount;
            dr[Economy.GDPNominalLabel] = c.Economy.GDPnominal;
            dr[Economy.GDPpppLabel] = c.Economy.GDPppp;
        }
        public static Country DataRow2Country(DataRow dr)
        {
            Country c = new Country()
            {
                Name = (string)dr[Country.NameLabel],
                Capital = (string)dr[Country.CapitalLabel],
                Geography = new Geography()
                {
                    TotalArea = (long)dr[Geography.TotalAreaLabel]
                },
                Population = new Population()
                {
                    Amount = (long)dr[Population.AmountLabel]
                },
                Economy = new Economy()
                {
                    GDPnominal = (long)dr[Economy.GDPNominalLabel],
                    GDPppp = (long)dr[Economy.GDPpppLabel]
                }
            };
            return c;
        }
    }
}
