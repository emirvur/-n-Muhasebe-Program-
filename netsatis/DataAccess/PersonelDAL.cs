﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netsatis.Context;
using netsatis.Repositories;
using netsatis.tables;
using netsatis.Validations;
using netsatis.DataAccess;


namespace netsatis.DataAccess
{
   public class PersonelDAL:EntityRepositoryBase<netsatisContext,Personel,PersonelValidator>
    {
        public object PersonelListele(netsatisContext context)
        {
            var result=context.Personeller.GroupJoin(context.Fisler,c=>c.PersonelKodu,c=>c.PlasiyerKodu,(personel,fis)=> new
            { 
                personel.Id,
                personel.Calisiyor,
                personel.PersonelKodu,
                personel.PersonelAdi,
                personel.Unvani,
                personel.TcKimlikNo,
                personel.IseGirisTarihi,
                personel.IstenCikisTarihi,
                personel.VergiDairesi,
                personel.VergiNo,
                personel.CepTelefonu,
                personel.Telefon,
                personel.Fax,
                personel.Il,
                personel.Ilce,
                personel.Semt,
                personel.Adres,
                personel.EMail,
                personel.Web,
                personel.PrimOrani,
                personel.AylikMaasi,
                personel.Aciklama,
                ToplamSatis=fis.Where(c=>c.FisTuru=="Perakende Satış Faturası").Sum(c=>c.ToplamTutar)??0,
                PrimTutari= (fis.Where(c => c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar)??0)/100*personel.PrimOrani



            }
                ).ToList();
            return result;
        }

        public object TariheGorePersonelListele(netsatisContext context,int Ay,int Yil)
        {
            var result = context.Personeller.GroupJoin(context.Fisler, c => c.PersonelKodu, c => c.PlasiyerKodu, (personel, fis) => new
            {
                personel.Id,
                personel.Calisiyor,
                personel.PersonelKodu,
                personel.PersonelAdi,
                personel.Unvani,
                personel.TcKimlikNo,
                personel.IseGirisTarihi,
                personel.IstenCikisTarihi,
                personel.VergiDairesi,
                personel.VergiNo,
                personel.CepTelefonu,
                personel.Telefon,
                personel.Fax,
                personel.Il,
                personel.Ilce,
                personel.Semt,
                personel.Adres,
                personel.EMail,
                personel.Web,
                personel.PrimOrani,
                personel.AylikMaasi,
                personel.Aciklama,
                ToplamSatis = fis.Where(c => c.FisTuru == "Perakende Satış Faturası" && c.Tarih.Month==Ay&&c.Tarih.Year==Yil).Sum(c => c.ToplamTutar) ?? 0,
                PrimTutari = (fis.Where(c => c.FisTuru == "Perakende Satış Faturası" && c.Tarih.Month == Ay && c.Tarih.Year == Yil).Sum(c => c.ToplamTutar) ?? 0) / 100 * personel.PrimOrani



            }
                ).ToList();
            return result;
        }
        public object PersonelFisToplam(netsatisContext context,string personelKodu)
        {
            var result = (from c in context.Fisler.Where(c => c.PlasiyerKodu==personelKodu)
                          group c by new { c.FisTuru } into grp
                          select new
                          {
                              Bilgi = grp.Key.FisTuru,
                       KayitSayisi=grp.Count(),
                       ToplamTutar=grp.Sum(c=>c.ToplamTutar)
                          }).ToList();
            return result;
        }
    }
}
