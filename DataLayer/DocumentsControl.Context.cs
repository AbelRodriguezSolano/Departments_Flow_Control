﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using EntitiesLayer;

    public partial class DocumentsControlEntities : DbContext
    {
        public DocumentsControlEntities()
            : base("name=DocumentsControlEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Codigo_Documento> Codigo_Documento { get; set; }
        public virtual DbSet<Departamento> Departamentoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    
        public virtual ObjectResult<VistaUsuarios_Result> VistaUsuarios()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VistaUsuarios_Result>("VistaUsuarios");
        }
    
        public virtual ObjectResult<Rep_Doc_DateRange_Result> Rep_Doc_DateRange(Nullable<System.DateTime> dateStart, Nullable<System.DateTime> dateEnd)
        {
            var dateStartParameter = dateStart.HasValue ?
                new ObjectParameter("DateStart", dateStart) :
                new ObjectParameter("DateStart", typeof(System.DateTime));
    
            var dateEndParameter = dateEnd.HasValue ?
                new ObjectParameter("DateEnd", dateEnd) :
                new ObjectParameter("DateEnd", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Rep_Doc_DateRange_Result>("Rep_Doc_DateRange", dateStartParameter, dateEndParameter);
        }
    
        public virtual ObjectResult<Rep_Doc_DepDest_Result> Rep_Doc_DepDest(Nullable<int> depDest)
        {
            var depDestParameter = depDest.HasValue ?
                new ObjectParameter("DepDest", depDest) :
                new ObjectParameter("DepDest", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Rep_Doc_DepDest_Result>("Rep_Doc_DepDest", depDestParameter);
        }
    
        public virtual ObjectResult<Rep_Doc_DepOrig_Result> Rep_Doc_DepOrig(Nullable<int> depOrig)
        {
            var depOrigParameter = depOrig.HasValue ?
                new ObjectParameter("DepOrig", depOrig) :
                new ObjectParameter("DepOrig", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Rep_Doc_DepOrig_Result>("Rep_Doc_DepOrig", depOrigParameter);
        }
    
        public virtual ObjectResult<Rep_Doc_User_Result> Rep_Doc_User(string userEmail)
        {
            var userEmailParameter = userEmail != null ?
                new ObjectParameter("UserEmail", userEmail) :
                new ObjectParameter("UserEmail", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Rep_Doc_User_Result>("Rep_Doc_User", userEmailParameter);
        }
    
        public virtual ObjectResult<VistaSecuencia_Result> VistaSecuencia()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VistaSecuencia_Result>("VistaSecuencia");
        }
    }
}