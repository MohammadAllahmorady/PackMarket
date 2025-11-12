using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackMarket.DataLayer.Entities.Entitieproduct;

namespace PackMarket.Core.Services.Interfaces
{
    public interface ICategoryService
    {
        List<Category> ShowAllCategories();
        int AddCategory(Category category);
        bool UpdateCategory(Category category);

        bool DeleteCategory(Category category);
        List<Category> ShowAllSubCategory(int categoryId);

        Category findCategoryById(int  categoryId);
    }
}
