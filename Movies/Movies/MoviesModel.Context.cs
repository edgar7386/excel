﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Movies
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class moviesContext : DbContext
    {
        public moviesContext()
            : base("name=moviesContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Directores> Directores { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Nacionalidades> Nacionalidades { get; set; }
        public virtual DbSet<Bases> Bases { get; set; }
        public virtual DbSet<Generos> Generos { get; set; }
        public virtual DbSet<Autores> Autores { get; set; }
    }
}
