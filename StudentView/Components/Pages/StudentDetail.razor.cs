using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using StudentView.Services;

namespace StudentView.Components.Pages
{
    public partial class StudentDetail
    {
        [Parameter]

        public int StudentId { get; set; }

        public Student Student { get; set; } = new Student();

        protected override void OnInitialized()
        {
            Student = MockDataService.Students.Single(e => e.StudentId == StudentId);
        }
    }
}
