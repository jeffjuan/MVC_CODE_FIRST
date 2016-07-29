using MVCCodeFirstSample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCodeFirstSample.DAL
{
    public class EFContext : DbContext
    {
        public EFContext():base("name=DefaultConnection")
        {
            Database.SetInitializer<EFContext>(new DBInitialize());
        }

        public virtual DbSet<ODMaster> ODMASTER { get; set; }
        public virtual DbSet<ODDetail> ODDETAIL { get; set; }
    }
}