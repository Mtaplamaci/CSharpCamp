using KodlamaIoModelling.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelling.DataAccess.Abstract;

public interface ICategoryDal
{
 List<Category> GetAll();
    void Add(Category category);
    void Delete(int Id);
    void Update(Category category);
}

