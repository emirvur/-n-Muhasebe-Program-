using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netsatis.Context;
using netsatis.tables;
using netsatis.Validations;
using netsatis.Repositories;

namespace netsatis.DataAccess
{
  public  class HizliSatisDAL:EntityRepositoryBase<netsatisContext,HizliSatis,HizliSatisValidator>
    {
    }
}
