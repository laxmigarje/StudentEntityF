using EmployeeEntityF.Data;
using StudentEntityF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEntityF.Repositaries
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;
        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddStudent(Student stud)
        {
            db.Students.Add(stud);
            int res = db.SaveChanges();
            return res;
        }

        public int DeleteStudent(int id)
        {
            int res = 0;
            var s = db.Students.Where(x => x.Id == id).FirstOrDefault();
            if (s != null)
            {
                s.IsActive = 0;
                res = db.SaveChanges();

            }
            return res;
        }

        public List<Student> GetAllStudents()
        {
            var model = (from s in db.Students
                         where s.IsActive == 1
                         select s).ToList();

            return model;
        }

        public Student GetStudentById(int id)
        {
            var s = db.Students.Where(x => x.Id == id).FirstOrDefault();
            return s;

        }

        public int UpdateStudent(Student stud)
        {
            int res = 0;
            var s = db.Students.Where(x => x.Id == stud.Id).FirstOrDefault();
            if (s != null)
            {
                s.id = stud.id;
                s.firstname = stud.firstname;
                s.lastname = s.lastname;

                s.age = stud.age;
                s.gender = stud.gender;
                s.address = stud.address;
                s.password = stud.password;

                s.IsActive = 1;
                res = db.SaveChanges();

            }
            return res;
        }

    }
}
