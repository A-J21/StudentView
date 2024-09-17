using BethanysPieShopHRM.Shared.Domain;
using StudentView.Services;

namespace StudentView.Components.Pages
{
    public partial class StudentOverview
    {
        public List<Student> Students { get; set; } = default!;
        protected async override Task OnInitializedAsync()
        {
            Students = MockDataService.Students;
        }
    }
}
