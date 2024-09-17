using BethanysPieShopHRM.Shared.Domain;

namespace StudentView.Services
{
    public class MockDataService
    {
        private static List<Student>? _students = default!;

        public static List<Student>? Students
        {
            get
            {

                _students ??= InitializeMockStudents();

                return _students;
            }
        }

        private static List<Student> InitializeMockStudents()
        {
            var e1 = new Student
            {
                BirthDate = new DateTime(1989, 3, 11),
                City = "Brussels",
                Email = "bethany@bethanyspieshop.com",
                StudentId = 1,
                FirstName = "Bethany",
                LastName = "Smith",
                Gender = Gender.Female,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2015, 3, 1),

            };

            var e2 = new Student
            {
                
                BirthDate = new DateTime(1979, 1, 16),
                City = "Antwerp",
                Email = "gill@bethanyspieshop.com",
                StudentId = 2,
                FirstName = "Gill",
                LastName = "Cleeren",
                Gender = Gender.Female,
  
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2017, 12, 24),

            };

            return [e1, e2];
        }

    }
}
