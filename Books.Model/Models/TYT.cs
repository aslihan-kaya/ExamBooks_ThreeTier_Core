using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Books.Model.Models
{
    public class TYT
    {
        [Key]
        public int TytID { get; set; }
        [Required]
        public string LessonName { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]
        public string BookType { get; set; }
        [StringLength(50), Required]
        public string BookAuthor { get; set; }
        public int PageCount { get; set; }
        [ForeignKey("EXAM")]
        public int ExamID { get; set; }
        public virtual EXAM EXAM { get; set; }
    }
}
