using PackMarket.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackMarket.Core.Services.Interfaces
{
    public interface ISliderService
    {
        List<MainSlider> ShowAllSliders(int page);
        MainSlider FindSliderById(int id);
        int AddSlider(MainSlider mainSlider);
        bool UpdateSlider(MainSlider mainSlider);
        bool DeleteSlider(MainSlider mainSlider);
        public int SliderCount();

    }
}
