//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class event12
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public event12()
        {
            this.entry1 = new HashSet<entry1>();
        }
    
        public int numb_event { get; set; }
        public System.DateTime date_event { get; set; }
        public string locationn { get; set; }
        public string name_event { get; set; }
        public string street_event { get; set; }
        public int house_event { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<entry1> entry1 { get; set; }
    }
}