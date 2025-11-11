using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackMarket.DataLayer.Entities.Entitieproduct;

namespace PackMarket.Core.Services.Interfaces
{
    public interface IProductService
    {
        #region ProductColor

        List<ProductColor> ShowAllColor();
        int AddColor(ProductColor productColor);
        bool UpdateColor(ProductColor productColor);
        ProductColor FindColorById(int colorId);
        bool ExistColor(string nameColor, string codeColor,int colorid);

        #endregion
    }
}
