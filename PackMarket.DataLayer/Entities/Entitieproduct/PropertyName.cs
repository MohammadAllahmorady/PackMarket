using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackMarket.DataLayer.Entities.Entitieproduct
{
    public class PropertyName
    {
        [Key]
        public int PropertyNameId { get; set; }
        [Display(Name = "عنوان خصوصیات")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MinLength(5, ErrorMessage = "{0} نمی تواند کمتر از {1} باشد.")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1}باشد.")]
        public string PropertyTitle { get; set; }

        #region Relation

        public List<PropertyName_Category> PropertyNameCategories { get; set; }

        #endregion

    }
}
