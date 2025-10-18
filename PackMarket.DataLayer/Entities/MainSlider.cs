using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string? SliderAlt { get; set; }
        [Display(Name = "ترتیب اسلایدر")]
        [Required(ErrorMessage = "لطفا {0} وارد کنید.")]
        public int? SliderSort { get; set; }
        [Display(Name = "وضعیت اسلایدر")]
        public bool IsActive { get; set; }

        [Display(Name = "تصویر اسلایدر")]
        public string? SliderImage { get; set; }

        [Display(Name = "لینک اسلایدر")]
        public string? SliderLink { get; set; }
      

    }
}
