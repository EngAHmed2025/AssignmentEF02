using AssignmentEF02.Dbcontext;
using AssignmentEF02.Entites;

namespace AssignmentEF02
{
    internal class Program
    {
        static void Main()
        {
  
            ITIDbcontext dbcontext = new ITIDbcontext();

            Students Stu01 = new Students()
            {
                FName = "ahmed",
                LName = "Gamal",
                Age = 25,
                

            };

            Students Stu02= new Students()
            {
                FName = "Mohamed",
                LName = "Gamal",
                Age = 30,


            };

            Instructor Ins01 = new Instructor()
            {
                Name = "ahmed",
                Salary = 4000,
                HourRate = DateTime.Now,
                Bouns = 5000
            };


             dbcontext.Students.Add(Stu01);
              dbcontext.Students.Add(Stu02);
            dbcontext.Instructors.Add(Ins01);
             Console.WriteLine(dbcontext.Students.Add(Stu02).State);
               dbcontext.SaveChanges();
        }
    }
}
