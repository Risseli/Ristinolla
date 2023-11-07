using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ristinolla
{
    public class PelaajaTiedot         
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Syntymapaiva { get; set; }
        public int Voitot { get; set; } 

        public int Tappiot { get; set; }

        public int Tasapelit { get; set; }
        public double PelattuAika { get; set; }  
        

    }
}
