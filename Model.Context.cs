﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ITWebNetEntities3 : DbContext
    {
        public ITWebNetEntities3()
            : base("name=ITWebNetEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Заказ_услуги> Заказ_услуги { get; set; }
        public virtual DbSet<Отзыв> Отзыв { get; set; }
        public virtual DbSet<Авторизация> Авторизация { get; set; }
    }
}
