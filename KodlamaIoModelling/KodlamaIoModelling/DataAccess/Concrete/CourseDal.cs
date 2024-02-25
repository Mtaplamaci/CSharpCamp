using KodlamaIoModelling.DataAccess.Abstract;
using KodlamaIoModelling.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelling.DataAccess.Concrete;

public class CourseDal : ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        courses = new List<Course>
        {
           new Course
           {
               Id=1,
               CategoryId=2,
               InstructorId=1,
               CourseName ="Selenium with Python",
               Description="test otomasyonda zirveye",
               Price=0,
           },
           new Course
           {
                Id=2,
                CategoryId=3,
                InstructorId=1,
                CourseName ="C# geliştime Kampı",
                Description="Yazılımda zirveye",
                Price=0,
              },
           new Course
           {
                 Id=3,
                 CategoryId=1,
                 InstructorId=2,
                 CourseName ="Veri Bilimi İçin Python",
                 Description="Veri biliğminde zirveye",
                 Price=0,
                  },
        };
    }
    public void Add(Course entity)
    {
        courses.Add(entity);
    }

    public void Delete(int id)
    {
        var courseToDelete = courses.SingleOrDefault(c => c.Id == id);
        if (courseToDelete != null)
        {
            courses.Remove(courseToDelete);
        }
        else
        {
            Console.WriteLine("kurs bulunamadı.");
        }
    }

    public Course Get(int id)
    {
        return courses.SingleOrDefault(c => c.Id == id);
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public void Update(Course entity)
    {
        var courseToUpdate = courses.SingleOrDefault(c => c.Id == entity.Id);
        if (courseToUpdate != null)
        {
            courseToUpdate.CategoryId = entity.CategoryId;
            courseToUpdate.InstructorId = entity.InstructorId;
            courseToUpdate.CourseName = entity.CourseName;
            courseToUpdate.Description = entity.Description;
            courseToUpdate.Price = entity.Price;
        }
        else
        {
            Console.WriteLine("Böyle bir kurs bulunamadı.");
        }
    }
}
