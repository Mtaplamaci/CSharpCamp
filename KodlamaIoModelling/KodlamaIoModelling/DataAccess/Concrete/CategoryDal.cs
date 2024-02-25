using KodlamaIoModelling.DataAccess.Abstract;
using KodlamaIoModelling.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelling.DataAccess.Concrete;

public class CategoryDal : ICategoryDal
{
    List<Category> _categories;
    public CategoryDal()
    {
        _categories = new List<Category>
        {
            new Category{Id=1,CategoryName="Yazılım" },
            new Category{Id=2,CategoryName="QA Test"},
            new Category{Id=3,CategoryName="Veri Bilimi"}
        };
    }

    public void Add(Category entity)
    {
        _categories.Add(entity);
    }

    public void Delete(int id)
    {
        var categoryToDelete = _categories.SingleOrDefault(c => c.Id == id);
        _categories.Remove(categoryToDelete);
    }
    public List<Category> GetAll()
    {
        return _categories;
    }

    public Category Get(int id)
    {
        return _categories.SingleOrDefault(c => c.Id == id);
    }

    public void Update(Category entity)
    {
        var categoryToUpdate = _categories.SingleOrDefault(c => c.Id == entity.Id);
        if (categoryToUpdate != null)
        {
            categoryToUpdate.CategoryName = entity.CategoryName;
        }
        else
        {
            Console.WriteLine("kategori bulunamadı.");
        }
    }
}
