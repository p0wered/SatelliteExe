using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CourseWork
{
    public partial class SateliteDbModel : DbContext
    {
        public SateliteDbModel()
            : base("name=SateliteDbModel")
        {
        }

        public virtual DbSet<Бригады_специалистов> Бригады_специалистов { get; set; }
        public virtual DbSet<Клиентские_компании> Клиентские_компании { get; set; }
        public virtual DbSet<Космические_компании> Космические_компании { get; set; }
        public virtual DbSet<Наземные_станции> Наземные_станции { get; set; }
        public virtual DbSet<Операции> Операции { get; set; }
        public virtual DbSet<Орбиты> Орбиты { get; set; }
        public virtual DbSet<Ресурсы> Ресурсы { get; set; }
        public virtual DbSet<Ресурсы_Операции> Ресурсы_Операции { get; set; }
        public virtual DbSet<Сбои> Сбои { get; set; }
        public virtual DbSet<Спутники> Спутники { get; set; }
        public virtual DbSet<Технические_обслуживания> Технические_обслуживания { get; set; }
        public virtual DbSet<Штабы_управления> Штабы_управления { get; set; }
        public virtual DbSet<View_ActiveOperations> View_ActiveOperations { get; set; }
        public virtual DbSet<View_ClientsSatelliteCount> View_ClientsSatelliteCount { get; set; }
        public virtual DbSet<View_SatellitesByOrbit> View_SatellitesByOrbit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Бригады_специалистов>()
                .Property(e => e.Стаж)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Бригады_специалистов>()
                .HasMany(e => e.Технические_обслуживания)
                .WithRequired(e => e.Бригады_специалистов)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Клиентские_компании>()
                .HasMany(e => e.Спутники)
                .WithRequired(e => e.Клиентские_компании)
                .HasForeignKey(e => e.Клиент)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Космические_компании>()
                .HasMany(e => e.Операции)
                .WithRequired(e => e.Космические_компании)
                .HasForeignKey(e => e.Компания_организатор)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Наземные_станции>()
                .HasMany(e => e.Спутники)
                .WithRequired(e => e.Наземные_станции)
                .HasForeignKey(e => e.Станция_вылета)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Операции>()
                .HasMany(e => e.Ресурсы_Операции)
                .WithRequired(e => e.Операции)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Операции>()
                .HasMany(e => e.Спутники)
                .WithRequired(e => e.Операции)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Орбиты>()
                .Property(e => e.Высота)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Орбиты>()
                .Property(e => e.Период_обращения)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Орбиты>()
                .Property(e => e.Градус_наклона)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Орбиты>()
                .HasMany(e => e.Спутники)
                .WithRequired(e => e.Орбиты)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ресурсы>()
                .HasMany(e => e.Ресурсы_Операции)
                .WithRequired(e => e.Ресурсы)
                .HasForeignKey(e => e.Ресурс_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Спутники>()
                .HasMany(e => e.Сбои)
                .WithRequired(e => e.Спутники)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Спутники>()
                .HasMany(e => e.Технические_обслуживания)
                .WithRequired(e => e.Спутники)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Штабы_управления>()
                .HasMany(e => e.Наземные_станции)
                .WithRequired(e => e.Штабы_управления)
                .HasForeignKey(e => e.Идентификатор_оператора)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<View_SatellitesByOrbit>()
                .Property(e => e.Высота)
                .HasPrecision(10, 2);
        }
    }
}
