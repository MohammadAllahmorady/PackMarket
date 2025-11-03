using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackMarket.DataLayer.Entities.Entitieproduct
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Display(Name = "توضیحات محصول")]
        [MaxLength(10000,ErrorMessage = "{0} نمی تواند بیشتر از {1}باشد.")]
        public string ReviewDescription { get; set; }

        [Display(Name = "نقات ضعف محصول")]
        [MaxLength(1000, ErrorMessage = "{0} نمی تواند بیشتر از {1}باشد.")]
        public string ReviewNegative { get; set; }

        [Display(Name = "نقات قوت محصول")]
        [MaxLength(1000, ErrorMessage = "{0} نمی تواند بیشتر از {1}باشد.")]
        public string ReviewPositive { get; set; }

        [Display(Name = "عنوان مقاله")]
        [MaxLength(10000, ErrorMessage = "{0} نمی تواند بیشتر از {1}باشد.")]
        public string ArticleTitle { get; set; }

        [Display(Name = "توضیحات مقاله")]
        public string ArticleDescription { get; set; }

        public int ProductId { get; set; }

        #region Relation
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        #endregion
    }
}
