﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NmhCNT1K22Lesson12.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NguyenMinhHiep_20123212Entities : DbContext
    {
        public NguyenMinhHiep_20123212Entities()
            : base("name=NguyenMinhHiep_20123212Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<NguyenMinhHiep_SACH> NguyenMinhHiep_SACH { get; set; }
        public virtual DbSet<NguyenMinhHiep_TACGIA> NguyenMinhHiep_TACGIA { get; set; }
    }
}
