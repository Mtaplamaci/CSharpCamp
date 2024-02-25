﻿using KodlamaIoModelling.Business.Abstract;
using KodlamaIoModelling.DataAccess.Abstract;
using KodlamaIoModelling.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelling.Business.Concrete;

public class CourseManager:ICourseService
{
    ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(int id)
    {
        _courseDal.Delete(id);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }
}
