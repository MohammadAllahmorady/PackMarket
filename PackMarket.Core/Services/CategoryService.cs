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
    public class CategoryService : ICategoryService
    {
        private PackMarketContext _context;

        public CategoryService(PackMarketContext context)
        {
            _context = context;
        }
        public int AddCategory(Category category)
        {
            try
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return category.CategoryId;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public bool DeleteCategory(Category category)
        {
            try
            {
                _context.Categories.Update(category);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Category findCategoryById(int categoryId)
        {
            return _context.Categories.Find(categoryId);
        }

        public List<Category> ShowAllCategories()
        {
            return _context.Categories.Where(c=>!c.IsDelete&&c.SubCategory==null).ToList();
        }

        public List<Category> ShowAllSubCategory(int categoryId)
        {
            return _context.Categories.Where(c=>!c.IsDelete&&c.SubCategory==categoryId).ToList();
        }

        public bool UpdateCategory(Category category)
        {
            try
            {
                _context.Categories.Update(category);
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
