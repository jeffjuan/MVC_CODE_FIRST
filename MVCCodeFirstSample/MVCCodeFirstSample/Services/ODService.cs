using MVCCodeFirstSample.DAL;
using MVCCodeFirstSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirstSample.Services
{
    public class ODService
    {
        private EFContext _db = new EFContext();

        public EFContext DB
        {
            get
            {
                return _db;
            }
        }

        public IEnumerable<ODMaster> GetAll()
        {
            var data = DB.ODMASTER.ToList();
            return data;
        }



    }
}