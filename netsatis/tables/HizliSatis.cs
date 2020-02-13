using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netsatis.Interfaces;

namespace netsatis.tables
{
    public class HizliSatis:IEntity
    {
        public int Id { get; set; }

        public  string Barkod { get; set; }

        public  string UrunAdi { get; set; }

        public int GrupId { get; set; }
    }
}
