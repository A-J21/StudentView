using System.ComponentModel.DataAnnotations.Schema;

namespace BethanysPieShopHRM.Shared.Domain
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public DateTime? BirthDate { get; set; }

        public string Email { get; set; } = string.Empty;


        public string? City { get; set; }

        public Gender? Gender { get; set; }


        public string Comment { get; set; } = string.Empty;

        public DateTime? JoinedDate { get; set; }

        public DateTime? ExitDate { get; set; }


        [NotMapped]
        public byte[]? ImageContent { get; set; }
        public string? ImageName { get; set; }
    }
}
