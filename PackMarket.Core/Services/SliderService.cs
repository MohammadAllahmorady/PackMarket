using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackMarket.Core.Services.Interfaces;
using PackMarket.DataLayer.Context;
using PackMarket.DataLayer.Entities;

namespace PackMarket.Core.Services
{
    public class SliderService : ISliderService
    {
        private PackMarketContext _context;

        public SliderService(PackMarketContext context)
        {
            _context=context;
        }
        public int AddSlider(MainSlider mainSlider)
        {
            
            try
            {
                _context.MainSlider.Add(mainSlider);
                _context.SaveChanges();
                return mainSlider.SliderId;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public bool DeleteSlider(MainSlider mainSlider)
        {
            try
            {
                _context.MainSlider.Remove(mainSlider);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public MainSlider FindSliderById(int sliderId)
        {
            return _context.MainSlider.Find(sliderId);
        }

        public List<MainSlider> ShowAllSliders()
        {
            return _context.MainSlider.OrderBy(s => s.SliderSort).ToList();
        }

        public bool UpdateSlider(MainSlider mainSlider)
        {
            try
            {
                _context.MainSlider.Update(mainSlider);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
