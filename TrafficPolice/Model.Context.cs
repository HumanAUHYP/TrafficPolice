//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrafficPolice
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TrafficPoliceEntities1 : DbContext
    {
        public TrafficPoliceEntities1()
            : base("name=TrafficPoliceEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Inspection_History> Inspection_History { get; set; }
        public virtual DbSet<Owner> Owner { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tech_inspect_car> Tech_inspect_car { get; set; }
        public virtual DbSet<Technical_Passport> Technical_Passport { get; set; }
        public virtual DbSet<Traffic_Police_Officer> Traffic_Police_Officer { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
