using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCCodeFirstSample.Models
{
    public class ODMaster
    {
        [Key]
        [Required]
        [DisplayName("訂單主檔ID")]
        public Guid MID { get; set; }

        [StringLength(20)]
        [DisplayName("購買人姓名")]
        public string Name { get; set; }

        [StringLength(10)]
        [DisplayName("購買人電話")]
        public string Phone { get; set; }

        [DisplayName("訂單日期")]
        public DateTime? OrderDate { get; set; }

        public virtual ICollection<ODDetail> OdDetails { get; set; }

        public ODMaster()
        {
            MID = Guid.NewGuid();
            OrderDate = DateTime.Now;
        }
    }
}