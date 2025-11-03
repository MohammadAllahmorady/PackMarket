using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackMarket.DataLayer.Entities.Entitieproduct.FaQ
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Display(Name = "عنوان نظر")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MinLength(4, ErrorMessage = "{0} نمی تواند کمتر از {1} باشد.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}باشد.")]
        public string CommentTitle { get; set; }
        [Display(Name = "توضیحات نظر")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MinLength(10, ErrorMessage = "{0} نمی تواند کمتر از {1} باشد.")]
        [MaxLength(500, ErrorMessage = "{0} نمی تواند بیشتر از {1}باشد.")]
        public string CommentDescription { get; set; }
        public int CommentLike { get; set; }
        public int CommentDistlike  { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
        public byte Recommend { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }

        #region Relation
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        #endregion
    }
}
