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
    
    public partial class Сотрудник
    {
        public Сотрудник()
        {
            this.ПослужнойСписок = new HashSet<ПослужнойСписок>();
            this.УчастокТрубопровода = new HashSet<УчастокТрубопровода>();
        }
    
        public int КодСотрудника { get; set; }
        public Nullable<int> КодДолжности { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
    
        public virtual Должность Должность { get; set; }
        public virtual ICollection<ПослужнойСписок> ПослужнойСписок { get; set; }
        public virtual ICollection<УчастокТрубопровода> УчастокТрубопровода { get; set; }
    }
}
