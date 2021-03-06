﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using netsatis.tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace netsatis.Mapping
{
    public class StokHareketMap : EntityTypeConfiguration<StokHareket>
    {
        public StokHareketMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(12);
            this.Property(p => p.Hareket).HasMaxLength(10);
            this.Property(p => p.StokKodu).HasMaxLength(12);
            this.Property(p => p.StokAdi).HasMaxLength(12);
            this.Property(p => p.BarkodTuru).HasMaxLength(50);
            this.Property(p => p.Barkod).HasMaxLength(15);
            this.Property(p => p.Birimi).HasMaxLength(20);
            this.Property(p => p.Miktar).HasPrecision(12,3);
            this.Property(p => p.BirimFiyati).HasPrecision(12, 3);
            this.Property(p => p.İndirimOrani).HasPrecision(5, 2);
            this.Property(p => p.DepoKodu).HasMaxLength(12);
            this.Property(p => p.DepoAdi).HasMaxLength(30);
            this.Property(p => p.SeriNo).HasMaxLength(200);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("StokHareketleri");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            this.Property(p => p.SeriNo).HasColumnName("SeriNo");
            this.Property(p => p.DepoAdi).HasColumnName("DepoAdi");
            this.Property(p => p.DepoKodu).HasColumnName("DepoKodu");
            this.Property(p => p.İndirimOrani).HasColumnName("İndirimOrani");
            this.Property(p => p.BirimFiyati).HasColumnName("BirimFiyati");
            this.Property(p => p.Birimi).HasColumnName("Birimi");
            this.Property(p => p.Miktar).HasColumnName("Miktar");
            this.Property(p => p.Barkod).HasColumnName("Barkod");
            this.Property(p => p.BarkodTuru).HasColumnName("BarkodTuru");
            this.Property(p => p.StokAdi).HasColumnName("StokAdi");
            this.Property(p => p.StokKodu).HasColumnName("StokKodu");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.Hareket).HasColumnName("Hareket");


        }
    }
}
