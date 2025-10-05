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
        List<MainSlider> ShowAllSliders();
        MainSlider FindSliderById(int id);
        int AddSlider(MainSlider mainSlider);
        bool UpdateSlider(MainSlider mainSlider);
        bool DeleteSlider(MainSlider mainSlider);

    }
}
