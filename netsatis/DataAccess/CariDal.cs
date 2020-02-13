using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netsatis.tables;
using netsatis.Interfaces;
using netsatis.Context;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;
using netsatis.Repositories;
using netsatis.Validations;

namespace netsatis.DataAccess
{
    public class CariDAL : EntityRepositoryBase<netsatisContext, Cari,CariValidator>

    {
        private string[] Alacaklar =
        {
               "Perakende Satış Faturası","Toptan Satış Faturası","Alış İade Faturası","Ödeme Fişi"
        };
        private string[] Borclar =
        {
            "Alış Faturası","Satış İade Faturası","Tahsilat Fişi"
        };
        public object GetCariler(netsatisContext context)
        {
            var result = context.Cariler.GroupJoin(context.Fisler, c => c.CariKodu, c => c.CariKodu, (cariler, fisler) => new
            {
                cariler.Id,
                cariler.Durumu,
                cariler.CariKodu,
                cariler.CariAdi,
                cariler.CariTuru,
                cariler.YetkiliKisi,
                cariler.FaturaUnvani,
                cariler.Telefon,
                cariler.CepTelefonu,
                cariler.Fax,
                cariler.Email,
                cariler.Web,
                cariler.Il,
                cariler.Ilce,
                cariler.Semt,
                cariler.CariGrubu,
                cariler.CariAltGrubu,
                cariler.OzelKod1,
                cariler.OzelKod2,
                cariler.OzelKod3,
                cariler.OzelKod4,
                cariler.VergiNo,
                cariler.VergiDairesi,
                cariler.IskontoOrani,
                cariler.RiskLimiti,
                cariler.AlisOzelFiyati,
                cariler.SatisOzelFiyati,
                cariler.Aciklama,
                AlisToplam = fisler.Where(c => Borclar.Contains(c.FisTuru)).Sum(c => c.ToplamTutar) ?? 0,
                SatisToplam = fisler.Where(c => Alacaklar.Contains(c.FisTuru)).Sum(c => c.ToplamTutar) ?? 0
            }).GroupJoin(context.KasaHareketleri, c => c.CariKodu, c => c.CariKodu, (cariler, kasahareket) => new
            {
                cariler.Id,
                cariler.Durumu,
                cariler.CariKodu,
                cariler.CariAdi,
                cariler.CariTuru,
                cariler.YetkiliKisi,
                cariler.FaturaUnvani,
                cariler.Telefon,
                cariler.CepTelefonu,
                cariler.Fax,
                cariler.Email,
                cariler.Web,
                cariler.Il,
                cariler.Ilce,
                cariler.Semt,
                cariler.CariGrubu,
                cariler.CariAltGrubu,
                cariler.OzelKod1,
                cariler.OzelKod2,
                cariler.OzelKod3,
                cariler.OzelKod4,
                cariler.VergiNo,
                cariler.VergiDairesi,
                cariler.IskontoOrani,
                cariler.RiskLimiti,
                cariler.AlisOzelFiyati,
                cariler.SatisOzelFiyati,
                cariler.Aciklama,
                Alacak =
                       cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                Borc = cariler.SatisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                Bakiye =
                       (cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0)) -
                      (  cariler.SatisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0))
                  }).ToList();
        return result;

            }
        public object CariFisAyrinti(netsatisContext context,string cariKodu)
        {
            var result = context.Fisler.Where(c => c.CariKodu == cariKodu).GroupJoin(
                context.KasaHareketleri.Where(c => c.CariKodu == cariKodu), c => c.CariKodu, c=>c.CariKodu,
                (fisler, kasahareket) => new
                {
                    fisler.Id,
                    fisler.FisKodu,
                    fisler.FisTuru,
                    fisler.PlasiyerKodu,
                    fisler.PlasiyerAdi,
                    fisler.BelgeNo,
                    fisler.Tarih,
                    fisler.İskontoOrani,
                    fisler.İskontoTutar,
                    fisler.Aciklama,
                    fisler.ToplamTutar,
                    Odenen = context.KasaHareketleri.Where(c=>c.FisKodu==fisler.FisKodu).Sum(c=>c.Tutar)??0,
                KalanOdeme=fisler.ToplamTutar - context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).Sum(c=>c.Tutar)??0



            }
                ).ToList();
            return result;
        }

        public object CariFisGenelToplam(netsatisContext context,string cariKodu)
        {
            var result=(from c in context.Fisler.Where(c=>c.CariKodu==cariKodu) group c by new {c.FisTuru} 
            into grp 
                       select new
            {
                           Bilgi=grp.Key.FisTuru,
                           KayitSayisi=grp.Count(),
                           ToplamTutar=grp.Sum(c=>c.ToplamTutar)

            }).ToList();
            return result;
        }
        public object CariGenelToplam(netsatisContext context, string cariKodu)
        {
            decimal alacak =
                (context.Fisler.Where(c => c.CariKodu == cariKodu &&Borclar.Contains(c.FisTuru))
             .Sum(c => c.ToplamTutar) ?? 0) +
             (context.KasaHareketleri.Where(c => c.CariKodu == cariKodu && c.Hareket == "Kasa Giriş")
             .Sum(c => c.Tutar) ?? 0);
            decimal borc =
                (context.Fisler.Where(c => c.CariKodu == cariKodu &&Alacaklar.Contains(c.FisTuru))
             .Sum(c => c.ToplamTutar) ?? 0) +
             (context.KasaHareketleri.Where(c => c.CariKodu == cariKodu && c.Hareket == "Kasa Çıkış")
             .Sum(c => c.Tutar) ?? 0);

            List<GenelToplam> geneltoplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi="Alacak",
                    Tutar=0
                },
                new GenelToplam
                {
                    Bilgi="Borç",
                    Tutar=borc
                },
                new GenelToplam
                {
                    Bilgi="Bakiye",
                    Tutar=alacak-borc
                }

            };
            return geneltoplamlar;
        }
        public CariBakiye CariBakiyesi(netsatisContext context,string cariKodu)
        {
            decimal alacak =
             (context.Fisler.Where(c => c.CariKodu == cariKodu && Borclar.Contains(c.FisTuru))
          .Sum(c => c.ToplamTutar) ?? 0) +
          (context.KasaHareketleri.Where(c => c.CariKodu == cariKodu && c.Hareket == "Kasa Giriş")
          .Sum(c => c.Tutar) ?? 0);
            decimal borc =
                (context.Fisler.Where(c => c.CariKodu == cariKodu && Alacaklar.Contains(c.FisTuru))
             .Sum(c => c.ToplamTutar) ?? 0) +
             (context.KasaHareketleri.Where(c => c.CariKodu == cariKodu && c.Hareket == "Kasa Çıkış")
             .Sum(c => c.Tutar) ?? 0);
            CariBakiye entity = new CariBakiye
            {
                CariKodu=cariKodu,
                RiskLimiti=Convert.ToDecimal(context.Cariler.Where(c=>c.CariKodu==cariKodu).SingleOrDefault().RiskLimiti),
                Alacak=alacak,
                Borc=borc,
                Bakiye=alacak-borc
            };
            return entity;
        }
                
        }
    }

