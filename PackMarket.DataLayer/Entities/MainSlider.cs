using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackMarket.DataLayer.Entities
{
    public class MainSlider 
    {
        [Key]
        public int SliderId { get; set; }
        [Display(Name = "عنوان اسلایدر")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری است.")]
        public string SliderTitle { get; set; }
        [Display(Name = "Altاسلایدر")]
        public string SliderAlt { get; set; }
        [Display(Name = "تصویر اسلایدر")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری است.")]
        public string SliderImage { get; set; }
        public int SliderSort { get; set; }
        [Display(Name = "وضعیت اسلایدر")]
        public bool IsActive { get; set; }
        [Display(Name = "لینک اسلایدر")]
        public string SliderLink { get; set; }
      

    }
}
