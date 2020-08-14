using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExamsService_Domain.Models
{
   public class Question
    {
        [Key]
        public int ID { get; set; }
        public string QuestionName { get; set; }

        public int ExamID { get; set; }
        [ForeignKey("ExamID")]
        public Exam Exam { get; set; }
    }
}
