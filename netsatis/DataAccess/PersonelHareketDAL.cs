using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netsatis.Interfaces;
using netsatis.Repositories;
using netsatis.tables;
using netsatis.Context;
using netsatis.Validations;

namespace netsatis.DataAccess
{
   public class PersonelHareketDAL : EntityRepositoryBase<netsatisContext, PersonelHareket, PersonelHareketValidator>
    {
    }
}
