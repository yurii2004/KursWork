//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yurii_Bel_IT31
{
    using System;
    using System.Collections.Generic;
    
    public partial class СтальнаяТруба
    {
        public СтальнаяТруба()
        {
            this.УчастокТрубопровода = new HashSet<УчастокТрубопровода>();
        }
    
        public int НомерТрубы { get; set; }
        public string Наименование { get; set; }
        public Nullable<int> НаружныйДиаметр { get; set; }
        public Nullable<int> Толщина { get; set; }
        public Nullable<int> ПогонныйВнутреннийОбъем { get; set; }
        public Nullable<int> ПогонныйВес { get; set; }
    
        public virtual ICollection<УчастокТрубопровода> УчастокТрубопровода { get; set; }
    }
}
