using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackMarket.DataLayer.Entities.Entitieproduct.FaQ
{
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }
        [Display(Name = "متن پاسخ")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MinLength(10, ErrorMessage = "{0} نمی تواند کمتر از {1} باشد.")]
        [MaxLength(1000, ErrorMessage = "{0} نمی تواند بیشتر از {1}باشد.")]
        public string AnswerDescription { get; set; }
        public DateTime CreateDate { get; set; }
        public int QuestionId { get; set; }

        #region Relation
        [ForeignKey("QuestionId")]
        public Question Question { get; set; }

        #endregion
    }
}
