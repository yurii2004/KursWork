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
    
    public partial class УзелСети
    {
        public УзелСети()
        {
            this.ПотребительТепла = new HashSet<ПотребительТепла>();
            this.ТепловойКолодец = new HashSet<ТепловойКолодец>();
            this.ТепловойПункт = new HashSet<ТепловойПункт>();
            this.УчастокТрубопровода = new HashSet<УчастокТрубопровода>();
            this.УчастокТрубопровода1 = new HashSet<УчастокТрубопровода>();
        }
    
        public int НомерУзла { get; set; }
        public Nullable<int> НомерСети { get; set; }
    
        public virtual ICollection<ПотребительТепла> ПотребительТепла { get; set; }
        public virtual ТепловаяСеть ТепловаяСеть { get; set; }
        public virtual ICollection<ТепловойКолодец> ТепловойКолодец { get; set; }
        public virtual ICollection<ТепловойПункт> ТепловойПункт { get; set; }
        public virtual ICollection<УчастокТрубопровода> УчастокТрубопровода { get; set; }
        public virtual ICollection<УчастокТрубопровода> УчастокТрубопровода1 { get; set; }
    }
}
