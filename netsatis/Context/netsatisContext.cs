﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using netsatis.tables;
using netsatis.Mapping;

namespace netsatis.Context
{
    public class netsatisContext:DbContext
    {
        public DbSet<Stok> Stoklar { get; set; }

        public DbSet<Cari> Cariler { get; set; }

        public DbSet<Fis> Fisler { get; set; }

        public DbSet<StokHareket> StokHareketleri { get; set; }

        public DbSet<KasaHareket> KasaHareketleri { get; set; }

        public DbSet<Depo> Depolar { get; set; }

        public DbSet<Kasa> Kasalar { get; set; }

        public DbSet<OdemeTuru> OdemeTurleri { get; set; }

        public DbSet<Tanim> Tanimlar { get; set; }

        
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<PersonelHareket> PersonelHareketleri { get; set; }

        public DbSet<HizliSatis> HizliSatislar { get; set; }
        public DbSet<HizliSatisGrup> HizliSatisGruplari { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CariMap());
            modelBuilder.Configurations.Add(new StokMap());
            modelBuilder.Configurations.Add(new DepoMap());
            modelBuilder.Configurations.Add(new FisMap());
            modelBuilder.Configurations.Add(new KasaHareketMap());
            modelBuilder.Configurations.Add(new KasaMap());
            modelBuilder.Configurations.Add(new OdemeTuruMap());
            modelBuilder.Configurations.Add(new StokHareketMap());
            modelBuilder.Configurations.Add(new TanimMap());
            modelBuilder.Configurations.Add(new PersonelMap());
            modelBuilder.Configurations.Add(new PersonelHareketMap());

            modelBuilder.Configurations.Add(new HizliSatisMap());
            modelBuilder.Configurations.Add(new HizliSatisGrupMap());
        }
    }
}
