using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerCassandra.Entiteti
{
    public class Vozila
    {
        public string id_vozila { get; set; }
        public string tip { get; set; }
        public string naziv { get; set; }
        public string model { get; set; }
        public string isrent { get; set; }
    }
}
