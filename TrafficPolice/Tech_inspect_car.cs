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
    
    public partial class Tech_inspect_car
    {
        public int ID_inspect { get; set; }
        public Nullable<int> ID_Car { get; set; }
        public Nullable<int> ID_Owner { get; set; }
        public Nullable<int> ID_History { get; set; }
        public Nullable<int> ID_Officer { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual Inspection_History Inspection_History { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual Traffic_Police_Officer Traffic_Police_Officer { get; set; }
    }
}
