using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Books.Model.Models
{
    public class EXAM
    {
        [Key]
        public int ExamID { get; set; }
        public string ExamName { get; set; }
    }
}
