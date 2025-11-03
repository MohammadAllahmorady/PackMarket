using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackMarket.DataLayer.Entities.Entitieproduct
{
    public class ProductGallery
    {
        [Key]
        public int GalleryId { get; set; }
        [Display(Name = "تصویر محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string ImageName { get; set; }

        public int ProductId { get; set; }

        #region Relation
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        #endregion
    }
}
