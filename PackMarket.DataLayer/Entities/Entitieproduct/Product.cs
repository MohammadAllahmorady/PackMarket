using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PackMarket.DataLayer.Entities.Entitieproduct.FaQ;

namespace PackMarket.DataLayer.Entities.Entitieproduct
{
    public class Product 
    {
        [Key]
        public int ProductId { get; set; }

        [Display(Name = "عنوان فارسی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MinLength(3,ErrorMessage = "{0} نمی تواند کمتر از {1} باشد.")]
        [MaxLength(500,ErrorMessage = "{0} نمی تواند بیشتر از {1}باشد.")]
        public string ProductFaTitle { get; set; }

        [Display(Name = "عنوان انگلیسی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MinLength(3, ErrorMessage = "{0} نمی تواند کمتر از {1} باشد.")]
        [MaxLength(500, ErrorMessage = "{0} نمی تواند بیشتر از {1}باشد.")]
        public string ProductEnTitle { get; set; }

        [Display(Name = "تعداد فروش")]
        public int ProductSell { get; set; }

        [Display(Name = "امتیاز محصول")]
        public byte ProductStart { get; set; }

        [Display(Name = "تصویر محصول")]
        public string ProductImg { get; set; }

        [Display(Name = "بر چسب های محصول")]
        public string ProductTag { get; set; }

        public DateTime ProductCreate { get; set; }
        public DateTime ProductUpdate { get; set; }

        [Display(Name = "وزن محصول")]
        public int ProductWeith { get; set; }

        [Display(Name = "تایید شود ؟")]
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public bool IsOrginal { get; set; }

        public int CategoryId { get; set; }
        public int BrandId { get; set; }

        #region Relation
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }

        public List<Review> Reviews { get; set; }
        public List<PropertyValue> PropertyValue { get; set; }
        public List<Question> Questions { get; set; }
        public List<Comment> Comments { get; set; }
        public List<ProductGallery> ProductGalleries { get; set; }
        public List<ProductPrice> ProductPrices { get; set; }
        #endregion
    }
}
