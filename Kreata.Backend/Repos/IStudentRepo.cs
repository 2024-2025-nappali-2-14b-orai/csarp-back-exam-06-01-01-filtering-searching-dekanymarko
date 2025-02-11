using Kreata.Backend.Repos.Base;
using Kreta.Shared.Enums;
using Kreta.Shared.Models;

namespace Kreata.Backend.Repos
{
    public interface IStudentRepo : IBaseRepo<Student>
    {
        public Task<Student> GetByNameAsync(string firstName, string lastName);
        Task<int> GetNumberOfStudentByYearAsync(int year);
        Task<int> GetNumberOfStudentByYearAndMonthAsync(int year, int month);
        public Task<List<Student>> GetStudentByClass(int schoolYear, SchoolClassType schoolClassType);
    }
}
