using StudentEntityF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEntityF.Repositaries
{
   public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        int AddStudent(Student stud);
        int UpdateStudent(Student stud);
        int DeleteStudent(int id);
    }
}
