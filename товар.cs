//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sklad
{
    using System;
    using System.Collections.Generic;
    
    public partial class товар
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public товар()
        {
            this.Товар_Заказ = new HashSet<Товар_Заказ>();
        }
    
        public int id { get; set; }
        public int idтовар { get; set; }
        public Nullable<int> idзаказ { get; set; }
        public int кол_во { get; set; }
        public string ЕдИзм { get; set; }
        public decimal СтоимЗаЕд { get; set; }
        public bool наличие { get; set; }
        public string Наименование { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Товар_Заказ> Товар_Заказ { get; set; }
    }
}
