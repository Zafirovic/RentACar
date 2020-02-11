using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerCassandra.Entiteti
{
    public class RentVozilo
    {
        public string id_rent { get; set; }
        public string jmbg { get; set; }
        public string id_vozila { get; set; }
        public string date_rent { get; set; }
        public string date_to_return { get; set; }
    }
}
