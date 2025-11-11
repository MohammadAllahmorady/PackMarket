using PackMarket.Core.Services.Interfaces;
using PackMarket.DataLayer.Entities.Entitieproduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackMarket.DataLayer.Context;

namespace PackMarket.Core.Services
{
    public class ProductService : IProductService
    {
        private PackMarketContext _Context;

        public ProductService(PackMarketContext context)
        {
            _Context = context;
        }

        public int AddColor(ProductColor productColor)
        {
            try
            {
                _Context.ProductColors.Add(productColor);
                _Context.SaveChanges();
                return productColor.ColorId;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public bool ExistColor(string nameColor, string codeColor,int colorid)
        {
            return _Context.ProductColors.Any(c => c.ColorName == nameColor && c.ColorCode == codeColor && c.ColorId!=colorid);
        }

        public ProductColor FindColorById(int colorId)
        {
            return _Context.ProductColors.Find(colorId);
        }

        public List<ProductColor> ShowAllColor()
        {
            return _Context.ProductColors.ToList();
        }

        public bool UpdateColor(ProductColor productColor)
        {
            try
            {
                _Context.ProductColors.Update(productColor);
                _Context.SaveChanges();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
