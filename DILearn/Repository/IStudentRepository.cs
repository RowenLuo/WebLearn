using DILearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DILearn.Repository
{
    public interface IStudentRepository
    {
        Student GetStudent(int id);
    }
}
