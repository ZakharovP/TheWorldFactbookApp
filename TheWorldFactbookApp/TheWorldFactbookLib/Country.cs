using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorldFactbookLib
{
    public class Country
    {
        public const string NameLabel = "Name";
        public string Name;
        public const string CapitalLabel = "Capital";
        public string Capital;
        public Geography Geography;
        public Population Population;
        public Economy Economy;
    }
    public class Geography
    {
        public const string TotalAreaLabel = "Total Area (sq km)";
        public long TotalArea;  
    }
    public class Population
    {
        public const string AmountLabel = "Population";
        public long Amount;
    }
    public class Economy
    {
        public const string GDPNominalLabel = "GDP nominal (mln usd)";
        public long GDPnominal;
        public const string GDPpppLabel = "GDP ppp (usd)";
        public long GDPppp;
    }
}

