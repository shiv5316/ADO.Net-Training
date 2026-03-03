using DraftApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftApp.Repositories
{
    public class StudentRepositories : IStudentRepositories
    {
        private readonly StudentPortalDbContext _context;

        public StudentRepositories(StudentPortalDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAllAsync(string q = null)
        {
            var query = _context.Students.AsQueryable();

            if (!string.IsNullOrEmpty(q))
                query = query.Where(s => s.FullName.Contains(q));

            return await query.ToListAsync();
        }

        public async Task<Student?> GetByIdAsync(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task AddAsync(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }
        }
    }
}