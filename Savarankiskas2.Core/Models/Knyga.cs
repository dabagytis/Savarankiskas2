using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas2.Core.Models
{
    public class Knyga
    {
        public int KnygosID { get; set; }
        public string Pavadinimas { get; set; }
        public string Autorius { get; set; }
        public int IsleidimoMetai { get; set; }
        public string Zanras { get; set; }

        public Knyga()
        {

        }

        public Knyga(int knygosID, string pavadinimas, string autorius, int isleidimoMetai, string zanras)
        {
            KnygosID = knygosID;
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            IsleidimoMetai = isleidimoMetai;
            Zanras = zanras;
        }
    }
}
