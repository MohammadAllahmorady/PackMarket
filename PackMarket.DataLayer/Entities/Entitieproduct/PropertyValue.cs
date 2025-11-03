using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackMarket.DataLayer.Entities.Entitieproduct
{
    public class PropertyValue
    {
        [Key]
        public int PropertyValueId { get; set; }
        [Display(Name = "مقدار خصوصیات")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MinLength(10, ErrorMessage = "{0} نمی تواند کمتر از {1} باشد.")]
        [MaxLength(1000, ErrorMessage = "{0} نمی تواند بیشتر از {1}باشد.")]
        public string propertyvalue { get; set; }
        public int ProductId { get; set; }

        #region Relation
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        #endregion

    }
}
