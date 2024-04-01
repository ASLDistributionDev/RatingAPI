﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RatingAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RatingAPIEntities : DbContext
    {
        public RatingAPIEntities()
            : base("name=RatingAPIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LookupReference> LookupReferences { get; set; }
        public virtual DbSet<RatesArchive> RatesArchives { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<SpecialRate> SpecialRates { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<WebResponse> WebResponses { get; set; }
        public virtual DbSet<WebRequest> WebRequests { get; set; }
        public virtual DbSet<AccessorialRate> AccessorialRates { get; set; }
        public virtual DbSet<Accessorial> Accessorials { get; set; }
        public virtual DbSet<UOM> UOMs { get; set; }
        public virtual DbSet<WebRequestAccessorial> WebRequestAccessorials { get; set; }
    }
}
