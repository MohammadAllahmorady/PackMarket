using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackMarket.DataLayer.Entities.Entitieproduct
{
    public class ProductGurantee
    {
        [Key]
        public int GuranteeId { get; set; }
        [Display(Name = "اسم گارانتی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MinLength(5, ErrorMessage = "{0} نمی تواند کمتر از {1} باشد.")]
        [MaxLength(150, ErrorMessage = "{0} نمی تواند بیشتر از {1}باشد.")]
        public string GuranteeName { get; set; }

        #region Relation

        public List<ProductPrice> ProductPrices { get; set; }

        #endregion

    }
}
