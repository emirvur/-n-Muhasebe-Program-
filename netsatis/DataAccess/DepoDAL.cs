using netsatis.Context;
using netsatis.Repositories;
using netsatis.tables;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netsatis.Validations;

namespace netsatis.DataAccess
{
    public class DepoDAL: EntityRepositoryBase<netsatisContext, Depo,DepoValidator>
    {
        public object DepoBazindaStokListele(netsatisContext context, string stokKodu)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokKodu == stokKodu),
                c => c.DepoKodu, c => c.DepoKodu, (depolar, stokhareketleri) => new
                {
                    depolar.Id,
                    depolar.DepoKodu,
                    depolar.DepoAdi,
                    depolar.YetkiliKodu,
                    depolar.YetkiliAdi,
                    depolar.Telefon,
                    depolar.Il,
                    depolar.Ilce,
                    depolar.Semt,
                    depolar.Adres,
                    StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                    StokÇıkış = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ??
                    0 - stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,

                }
                ).ToList();
            return result;
        }
    }
}
