using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using netsatis.tables;
using System.ComponentModel.DataAnnotations.Schema;


namespace netsatis.Mapping
{
    public class HizliSatisGrupMap:EntityTypeConfiguration<HizliSatisGrup>
    {
        public HizliSatisGrupMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.GrupAdi).HasMaxLength(20);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("HizliSatisGruplari");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.GrupAdi).HasColumnName("GrupAdi");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
