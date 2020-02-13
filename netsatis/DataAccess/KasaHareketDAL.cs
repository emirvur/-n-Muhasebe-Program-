using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netsatis.Context;
using netsatis.Repositories;
using netsatis.tables;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;
using netsatis.Validations;

namespace netsatis.DataAccess
{
    public class KasaHareketDAL : EntityRepositoryBase<netsatisContext, KasaHareket,KasaHareketValidator>
    {
    }
}
