using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ScoolManagement_3.Models.MetaClass
{
    public class CoursesMetaData
    {
        [StringLength(50)]
        public string Title { get; set; }
        [Range(1,8)]
        public int Credits { get; set; }
        

    }
    [MetadataType(typeof(CoursesMetaData))]
    public partial class Course
    {

    }
}