using StudentEntityF.Models;
using StudentEntityF.Repositaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEntityF.Services
{
    class StudentService : IStudentService
    {
        private readonly IStudentRepository repo;
        public StudentService(IStudentRepository repo)
        {
            this.repo = repo;
        }
        public int AddStudent(Student stud)
        {
            stud.IsActive = 1;
            return repo.AddStudent(stud);
        }

        public int DeleteStudent(int id)
        {
            return repo.DeleteStudent(id);
        }

        public List<Student> GetAllStudents()
        {
            return repo.GetAllStudents();
        }

        public Student GetStudentById(int id)
        {
            return repo.GetStudentById(id);
        }

        public int UpdateStudent(Student stud)
        {
            return repo.UpdateStudent(stud);
        }



    }
}
