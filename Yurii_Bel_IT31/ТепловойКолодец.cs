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
    
    public partial class ТепловойКолодец
    {
        public int НомерТепловогоКолодца { get; set; }
        public string Наименование { get; set; }
        public Nullable<int> НомерУзла { get; set; }
    
        public virtual УзелСети УзелСети { get; set; }
    }
}
