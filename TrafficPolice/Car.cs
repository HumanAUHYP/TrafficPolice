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
    using System.Collections.Generic;
    
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.Tech_inspect_car = new HashSet<Tech_inspect_car>();
        }
    
        public int ID_Car { get; set; }
        public string License_plate { get; set; }
        public string Engine_number { get; set; }
        public string Colour { get; set; }
        public string Car_brand { get; set; }
        public Nullable<int> Technical_passport_number { get; set; }
        public string Image { get; set; }
    
        public virtual Technical_Passport Technical_Passport { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tech_inspect_car> Tech_inspect_car { get; set; }
    }
}
