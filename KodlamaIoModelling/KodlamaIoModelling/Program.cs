// See https://aka.ms/new-console-template for more information

using KodlamaIoModelling.Business.Concrete;
using KodlamaIoModelling.DataAccess.Concrete;
using KodlamaIoModelling.Entities.Concrete;

Console.WriteLine("---------Kursları Listele---------");
CourseManager courseManager = new(new CourseDal());
List<Course> courses = courseManager.GetAll();
foreach (var course in courses)
{
    Console.WriteLine(course.CourseName);
}

Console.WriteLine("---------Kategorileri Listele---------");
CategoryManager categoryManager = new(new CategoryDal());
List<Category> categories = categoryManager.GetAll();
foreach (var category in categories)
{
    Console.WriteLine(category.CategoryName);
}

Console.WriteLine("---------Kurs Ekle---------");
Course course1 = new()
{
    Id = 4,
    CategoryId = 3,
    InstructorId = 1,
    CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
    Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampı",
    Price = 100
};
courseManager.Add(course1);
List<Course> courses1 = courseManager.GetAll();
foreach (var course in courses1)
{
    Console.WriteLine(course.CourseName);
}

Console.WriteLine("---------Kategori Ekle---------");
Category category1 = new()
{
    Id = 4,
    CategoryName = "Yazılım"
};
categoryManager.Add(category1);
List<Category> categories1 = categoryManager.GetAll();
foreach (var category in categories1)
{
    Console.WriteLine(category.CategoryName);
}

Console.WriteLine("---------Kurs Güncelle---------");
Course course2 = new()
{
    Id = 4,
    CategoryId = 3,
    InstructorId = 1,
    CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
    Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampı",
    Price = 200
};

courseManager.Update(course2);
List<Course> courses2 = courseManager.GetAll();
foreach (var course in courses2)
{
    Console.WriteLine(course.CourseName);
}

Console.WriteLine("---------Kurs Sil---------");
courseManager.Delete(4);
List<Course> courses3 = courseManager.GetAll();
foreach (var course in courses3)
{
    Console.WriteLine(course.CourseName);
}