using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PackMarket.DataLayer.Entities.Entitieproduct
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Display(Name = " عنوان دسته بندی به فارسی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MinLength(3, ErrorMessage = "{0} نمی تواند کمتر از {1} باشد.")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1}باشد.")]
        public string CategoryFaTitle{ get; set; }

        [Display(Name = " عنوان دسته بندی به انگلیسی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MinLength(3, ErrorMessage = "{0} نمی تواند کمتر از {1} باشد.")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1}باشد.")]
        public string CategoryEnTitle { get; set; }

        public int SubCategory { get; set; }
        public bool IsDelete { get; set; }
        #region Relation
        public List<Product> Products { get; set; }
        public List<PropertyName_Category> PropertyNameCategories { get; set; }
        [ForeignKey("SubCategory")]
        public Category Categori { get; set; }
        #endregion
    }
}
