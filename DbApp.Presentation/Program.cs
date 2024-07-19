// See https://aka.ms/new-console-template for more information
using DbApp.Presentation.Data;

Console.WriteLine("Hello, World!");


//Ekleme
using (var db = new EducationDbContext())
{
    var newGroup = new DbApp.Presentation.Data.Entites.Group()
    {
        Name = "Ozz Akademi 2",
        StartDate = new DateTime(2024, 5, 1),
        EndDate = new DateTime(2024, 5, 1),
        IsActive = true
    };

    db.Groups.Add(newGroup);
    int affectedRows = db.SaveChanges();
}


//Listeleme
using (var db = new EducationDbContext())
{
    var groupsNotList = db.Groups;
    var groups = db.Groups.ToList();

    var students = db.Students.ToList();
}

//Silme
using (var db = new EducationDbContext())
{
    var groupDeleted = db.Groups.FirstOrDefault(x => x.GroupId == 2006);
    db.Groups.Remove(groupDeleted);
    int affectedRows = db.SaveChanges();

    //List<string> numbers = new List<string>() { "Adriana lima","Hande", "Adriana lima" };
    //numbers.FirstOrDefault(x => x == "Adriana lima");
}

//Güncelleme
using (var db = new EducationDbContext())
{
    var groupUpdated = db.Groups.FirstOrDefault(x => x.GroupId == 2006);

    if (groupUpdated != null)
    {
        groupUpdated.Name = "Mms Akademi";
        groupUpdated.StartDate = DateTime.Now.AddYears(-5);
        int affectedRows = db.SaveChanges();
    }

}


Console.ReadLine();