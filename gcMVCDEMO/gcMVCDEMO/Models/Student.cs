using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gcMVCDEMO.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public String  FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }

       
        /* public Student(int StudentId,String FirstName,String LastName,String Email)
        {
            this.StudentId = StudentId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;

        }*/
        public Student()
        {

        }

        public Student(int studentId, string firstName, string lastName, string email)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}
