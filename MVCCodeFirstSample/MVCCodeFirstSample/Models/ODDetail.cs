using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCodeFirstSample.Models
{
    public class ODDetail
    {
        [Key]
        [Required]
        [DisplayName("訂單明細ID")]
        public Guid DID { get; set; }

        [DisplayName("訂單主檔ID")]
        public Guid MasterID { get; set; }

        [StringLength(20)]
        [DisplayName("商品名稱")]
        public string ProdName { get; set; }

        [DisplayName("商品單價")]
        public int Price { get; set; }

        [DisplayName("訂購數量")]
        public int Number { get; set; }

        [ForeignKey("MasterID")]
        public virtual ODMaster OdMaster { get; set; }
    }
}