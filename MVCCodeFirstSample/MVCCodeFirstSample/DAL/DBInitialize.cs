using MVCCodeFirstSample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCodeFirstSample.DAL
{
    public class DBInitialize : CreateDatabaseIfNotExists<EFContext>
    {
        protected override void Seed(EFContext db)
        {
            // 預設訂單
            new List<ODMaster>
                {
                    new ODMaster { Name="Mary", Phone="0999999999"}

                }.ForEach(a => db.ODMASTER.Add(a));

            ODMaster OD = new ODMaster();
            OD = db.ODMASTER.Local.FirstOrDefault();

            new List<ODDetail>
                {
                    new ODDetail { MasterID = OD.MID, Number = 10, ProdName = "自動鉛筆", Price=5}

                }.ForEach(a => db.ODDETAIL.Add(a));

            db.SaveChanges();
            base.Seed(db);
        }
    }
}