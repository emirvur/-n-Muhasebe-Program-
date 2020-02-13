using System;
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
    public class FisMap : EntityTypeConfiguration<Fis>
    {
        public FisMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisTuru).HasMaxLength(30);
            this.Property(p => p.FisKodu).HasMaxLength(12);
            this.Property(p => p.CariAdi).HasMaxLength(50);
       
            this.Property(p => p.CariKodu).HasMaxLength(12);

            this.Property(p => p.FaturaUnvani).HasMaxLength(50);
            this.Property(p => p.CepTelefonu).HasMaxLength(20);
            this.Property(p => p.Il).HasMaxLength(20);
            this.Property(p => p.Ilce).HasMaxLength(20);
            this.Property(p => p.Semt).HasMaxLength(20);
            this.Property(p => p.Adres).HasMaxLength(100);
            this.Property(p => p.VergiDairesi).HasMaxLength(30);
            this.Property(p => p.VergiNo).HasMaxLength(15);


            this.Property(p => p.BelgeNo).HasMaxLength(20);
            this.Property(p => p.PlasiyerKodu).HasMaxLength(12);
            this.Property(p => p.PlasiyerAdi).HasMaxLength(50);
            this.Property(p => p.İskontoOrani).HasPrecision(5,2);
            this.Property(p => p.İskontoTutar).HasPrecision(12,2);
            this.Property(p => p.ToplamTutar).HasPrecision(12,2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Fisler");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.CariKodu).HasColumnName("CariKodu");
            this.Property(p => p.CariAdi).HasColumnName("CariAdi");
            this.Property(p => p.FisTuru).HasColumnName("FisTuru");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.FisTuru).HasColumnName("FaturaUnvani");

            this.Property(p => p.FisTuru).HasColumnName("CepTelefonu");

            this.Property(p => p.FisTuru).HasColumnName("Il");

            this.Property(p => p.FisTuru).HasColumnName("Ilce");

            this.Property(p => p.FisTuru).HasColumnName("Semt");

            this.Property(p => p.FisTuru).HasColumnName("Adres");
            this.Property(p => p.FisTuru).HasColumnName("VergiDairesi");

            this.Property(p => p.FisTuru).HasColumnName("VergiNo");


            this.Property(p => p.BelgeNo).HasColumnName("BelgeNo");
            this.Property(p => p.PlasiyerKodu).HasColumnName("PlasiyerKodu");
            this.Property(p => p.PlasiyerAdi).HasColumnName("PlasiyerAdi");
            this.Property(p => p.İskontoOrani).HasColumnName("İskontoOrani");
            this.Property(p => p.İskontoTutar).HasColumnName("İskontoTutar");
            this.Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");


        }
    }
}
