using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaPiche.Data.Entities
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = "Apellido")]
        public String LastName { get; set; }
        [Display (Name = "Primer Nombre")]
        public String FirstMidName { get; set; }
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Nombre Completo")]

        public string FullName
        {
            get
            {
                return FirstMidName + ' ' + LastName;
            }
        }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
