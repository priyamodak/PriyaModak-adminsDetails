using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_EF_CRUD_PostgreSQL.Models
{
    [Table("Student", Schema = "public")]
    public class StudentClass
    {
        [Key]
        public int id { get; set; }
        public string studentname { get; set; }
        public string email { get; set; }

    }
}