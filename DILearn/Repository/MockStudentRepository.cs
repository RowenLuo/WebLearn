using DILearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DILearn.Repository
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _students;

        public MockStudentRepository()
        {
            _students = new List<Student>
            {
                new Student
                {
                    ID = 1,
                    Name = "Tom",
                    Email = "123@qq.com"
                },
                new Student
                {
                    ID = 2,
                    Name = "Jack",
                    Email = "456@qq.com"
                },
                new Student
                {
                    ID = 3,
                    Name = "Jerry",
                    Email = "789@qq.com"
                }
            };
        }

        public Student GetStudent(int id)
        {
            return _students.FirstOrDefault(student => student.ID == id);
        }
    }
}
