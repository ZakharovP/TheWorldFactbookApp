using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorldFactbookLib
{
    public class Country
    {
        public string Name;
        public string Capital;
        public Geography Geography;
        public Population Population;
        public Economy Economy;
    }
    public class Geography
    {
        public long TotalArea;  
    }
    public class Population
    {
        public long Amount;
    }
    public class Economy
    {
        public long GDPtotal;
        public long GDPppp;
    }
}

