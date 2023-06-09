﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace MVC5Library.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class DbLibraryEntities : DbContext
{
    public DbLibraryEntities()
        : base("name=DbLibraryEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

    public virtual DbSet<TBLAuthor> TBLAuthor { get; set; }

    public virtual DbSet<TBLBook> TBLBook { get; set; }

    public virtual DbSet<TBLCategory> TBLCategory { get; set; }

    public virtual DbSet<TBLCriminal> TBLCriminal { get; set; }

    public virtual DbSet<TBLEmployee> TBLEmployee { get; set; }

    public virtual DbSet<TBLMovement> TBLMovement { get; set; }

    public virtual DbSet<TBLSafe> TBLSafe { get; set; }

    public virtual DbSet<TBLUser> TBLUser { get; set; }

    public virtual DbSet<TBLAbout> TBLAbout { get; set; }

    public virtual DbSet<TBLContact> TBLContact { get; set; }

    public virtual DbSet<TBLMessage> TBLMessage { get; set; }

    public virtual DbSet<TBLAnnouncement> TBLAnnouncement { get; set; }

    public virtual DbSet<TBLAdmin> TBLAdmin { get; set; }

    public virtual DbSet<TBLComment> TBLComment { get; set; }

    public virtual DbSet<TBLTodo> TBLTodo { get; set; }


    public virtual ObjectResult<string> TopCountBookAuthor()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("TopCountBookAuthor");
    }


    public virtual ObjectResult<string> TopBestPerson()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("TopBestPerson");
    }


    public virtual ObjectResult<string> TopOnlineUser()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("TopOnlineUser");
    }


    public virtual ObjectResult<string> TopReadBook()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("TopReadBook");
    }

}

}

