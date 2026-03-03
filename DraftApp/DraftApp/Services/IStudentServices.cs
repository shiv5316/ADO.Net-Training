using DraftApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftApp.Services
{
    public interface IStudentServices
    {
        Task<List<Student>> SearchAsync(string q = null);
        Task<Student?> GetAsync(int id);
        Task<(bool ok, string message)> CreateAsync(Student student);
        Task UpdateAsync(Student student);
        Task DeleteAsync(int id);
    }
}
