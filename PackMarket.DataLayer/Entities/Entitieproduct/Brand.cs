using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackMarket.DataLayer.Entities.Entitieproduct
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        [Display(Name = "عنوان برند")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MinLength(5, ErrorMessage = "{0} نمی تواند کمتر از {1} باشد.")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1}باشد.")]
        public string BrandName { get; set; }

        #region Relation

        public List<Product> Products { get; set; }

        #endregion
    }
}
