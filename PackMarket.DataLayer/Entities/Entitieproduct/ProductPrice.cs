using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackMarket.DataLayer.Entities.Entitieproduct
{
    public class ProductPrice
    {
        [Key]
        public int ProductPriceId { get; set; }

        [Display(Name = "قیمت اصلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public int MainPrice { get; set; }

        [Display(Name = "قیمت ویژه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public int SpecialPrice { get; set; }

        [Display(Name = "تعداد کالا")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public int Count { get; set; }

        [Display(Name = "تعداد خرید کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public int MaxOrderCount { get; set; }

        public int ProductColorId { get; set; }
        public int  ProductGuranteeId { get; set; }
        public int ProductId { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime EndDateDisCount { get; set; }

        #region Relation
        [ForeignKey("ProductColorId")]
        public ProductColor ProductColor { get; set; }

        [ForeignKey("ProductGuranteeId")]
        public ProductGurantee ProductGurantee { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        #endregion==========
    }
}
