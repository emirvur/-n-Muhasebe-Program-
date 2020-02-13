using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netsatis.Interfaces;

namespace netsatis.tables
{
   public class HizliSatisGrup:IEntity
    {
        public int Id { get; set; }

        public string GrupAdi { get; set; }

        public string Aciklama { get; set; }

      
    }
}
