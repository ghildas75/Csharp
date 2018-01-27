using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Student { 
   
        public int Id { get; set; }
        public String Nom { get; set; }
        public  String Prenom { get; set; }
        public String  Email { get; set; }
        public List<Student> Students { get; }

        public Student(int Id, String Nom,String  prenom, String Email)
        {
            this.Nom = Nom;
            this.Id = Id;
            this.Prenom = prenom;
            this.Email = Email;
            Students = new List<Student>();
            Student student1 = new Student(2, "","","");
            Student student2 = new Student(3, "", "", "");
            Student student3 = new Student(4, "", "", "");
            Students.Add(student1);
            Students.Add(student2);
            Students.Add(student3);



        }
    }
}
