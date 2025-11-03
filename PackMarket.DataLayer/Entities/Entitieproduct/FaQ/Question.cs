using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackMarket.DataLayer.Entities.Entitieproduct.FaQ
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        [Display(Name = "متن سئوال")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MinLength(3, ErrorMessage = "{0} نمی تواند کمتر از {1} باشد.")]
        [MaxLength(1000, ErrorMessage = "{0} نمی تواند بیشتر از {1}باشد.")]
        public string QuestionDescription { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }

        #region Relation
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public List<Answer> Answers { get; set; }
        #endregion
    }
}
