using DraftApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DraftApp.Repositories
{
    public interface IStudentRepositories
    {
        Task<List<Student>> GetAllAsync(string q = null);
        Task<Student?> GetByIdAsync(int id);
        Task AddAsync(Student student);
        Task UpdateAsync(Student student);
        Task DeleteAsync(int id);
    }
}
