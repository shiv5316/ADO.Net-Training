using DraftApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DraftApp.Repositories;

namespace DraftApp.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepositories _repo;

        public StudentServices(IStudentRepositories repo)
        {
            _repo = repo;
        }

        public Task<List<Student>> SearchAsync(string q = null)
            => _repo.GetAllAsync(q);

        public Task<Student?> GetAsync(int id)
            => _repo.GetByIdAsync(id);

        public async Task<(bool ok, string message)> CreateAsync(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.FullName))
                return (false, "Full Name is required.");

            if (string.IsNullOrWhiteSpace(student.Email))
                return (false, "Email is required.");

            student.CreatedAt = DateTime.Now;

            await _repo.AddAsync(student);
            return (true, "Student Created Successfully");
        }

        public Task UpdateAsync(Student student)
            => _repo.UpdateAsync(student);

        public Task DeleteAsync(int id)
            => _repo.DeleteAsync(id);
    }
}

