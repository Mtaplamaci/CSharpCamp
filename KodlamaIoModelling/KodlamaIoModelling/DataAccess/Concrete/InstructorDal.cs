using KodlamaIoModelling.DataAccess.Abstract;
using KodlamaIoModelling.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelling.DataAccess.Concrete;

public class InstructorDal : IInstructorDal
{
    List<Instructor> _instructors;
    public InstructorDal()
    {
        _instructors = new List<Instructor>
        {
            new Instructor{Id=1,FirstName="Engin", LastName="Demiroğ"},
            new Instructor{Id=2,FirstName="Muhammed", LastName="Taplamacı"},
            new Instructor{Id=3,FirstName="Derin", LastName="Demiroğ"}

        };
    }
    public void Add(Instructor entity)
    {
        _instructors.Add(entity);
    }

    public void Delete(int id)
    {
        var instructorToDelete = _instructors.SingleOrDefault(i => i.Id == id);
        _instructors.Remove(instructorToDelete);
    }

    public Instructor Get(int id)
    {
        return _instructors.SingleOrDefault(i => i.Id == id);
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public void Update(Instructor entity)
    {
        var instructorToUpdate = _instructors.SingleOrDefault(i => i.Id == entity.Id);
        if (instructorToUpdate != null)
        {
            instructorToUpdate.FirstName = entity.FirstName;
            instructorToUpdate.LastName = entity.LastName;
        }
        else
        {
            Console.WriteLine("eğitmen bulunamadı.");
        }

    }
}
