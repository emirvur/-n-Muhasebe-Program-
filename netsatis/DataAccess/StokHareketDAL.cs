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
    public class StokHareketDAL : EntityRepositoryBase<netsatisContext, StokHareket,StokHareketValidator>
    {
        public object GetGenelStok(netsatisContext context, string stokKodu)
        {
            var result = (from c in context.StokHareketleri.Where(c => c.StokKodu == stokKodu)
                          group c by new { c.Hareket } into g
                          select new
                          {
                              Bilgi = g.Key.Hareket,
                              KayitSayisi = g.Count(),
                              Toplam = g.Sum(c => c.Miktar)
                          }
                          ).ToList();
            return result;
        }
        public object GetDepoStok(netsatisContext context, string stokKodu)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokKodu == stokKodu),
                c => c.DepoKodu, c => c.DepoKodu, (depolar, stokhareketleri) => new
                {
                    depolar.DepoKodu,
                    depolar.DepoAdi,
                    StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                    StokÇıkış = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ??
                    0 - stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,

                }
                ).ToList();
            return result;
        }
        public object DepoStokListele(netsatisContext context,string depoKodu)
        {
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu), c => c.StokKodu, c => c.StokKodu, (Stoklar, StokHareketleri) =>
                   new
                   {

                       Stoklar.Barkod,
                       Stoklar.StokAdi,              
                       StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giris").Sum(c => c.Miktar) ?? 0,
                       StokCikis = StokHareketleri.Where(c => c.Hareket == "Stok Cikis").Sum(c => c.Miktar) ?? 0,
                       MevcutStok = StokHareketleri.Where(c => c.Hareket == "Stok Giris").Sum(c => c.Miktar) - StokHareketleri.Where(c => c.Hareket == "Stok Cikis").Sum(c => c.Miktar) ?? 0

                   }
          ).ToList();
            return tablo;

        }
        public object DepoİstatistikListele(netsatisContext context, string depoKodu)
        {
           

            List<GenelToplam> geneltoplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi="Stok Giriş",
                    KayitSayisi=context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu && c.Hareket=="Stok Giriş").Count(),
                    Tutar=context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu &&c.Hareket=="Stok Giriş").Sum(c=>c.Miktar)??0
                },
                new GenelToplam
                {
                    Bilgi="Stok Çıkış",
                    KayitSayisi=context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu && c.Hareket=="Stok Çıkış").Count(),
                    Tutar=context.StokHareketleri.Where(c=>c.DepoKodu==depoKodu &&c.Hareket=="Stok Çıkış").Sum(c=>c.Miktar)??0
                },
               

            };
            return geneltoplamlar;
        }
    }

}

