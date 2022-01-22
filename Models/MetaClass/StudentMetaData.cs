using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ScoolManagement_3.Models.MetaClass
{
    public class StudentMetaData
    {
        [StringLength(50)]
        [Display (Name="Last Name")]
        public string LastName { get; set; }
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
       
        [Display(Name = "Enrollment Date")]
        public Nullable<System.DateTime> EnrollmentDate { get; set; }
        [StringLength(50)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

    }
    [MetadataType(typeof(StudentMetaData))]
    public partial class Student
    {

    }
}