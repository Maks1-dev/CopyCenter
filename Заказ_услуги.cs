//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CopyCenter
{
    using System;
    using System.Collections.Generic;
    
    public partial class Заказ_услуги
    {
        public int id { get; set; }
        public string Наименование_услуги { get; set; }
    
        public virtual Отзыв Отзыв { get; set; }
    }
}
