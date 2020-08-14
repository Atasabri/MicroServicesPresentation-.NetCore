using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamsService_Domain.Models
{
   public class Exam
    {
        [Key]
        public int ID { get; set; }
        public string ExamName { get; set; }
        public string ExamTime { get; set; }
        public DateTime ExamDate { get; set; }
    }
}
