﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GYM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GymEntities10 : DbContext
    {
        public GymEntities10()
            : base("name=GymEntities10")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cenovnik> cenovniks { get; set; }
        public virtual DbSet<clan> clans { get; set; }
        public virtual DbSet<korisnik> korisniks { get; set; }
        public virtual DbSet<osoba> osobas { get; set; }
        public virtual DbSet<rezultati> rezultatis { get; set; }
        public virtual DbSet<termin> termins { get; set; }
    }
}
