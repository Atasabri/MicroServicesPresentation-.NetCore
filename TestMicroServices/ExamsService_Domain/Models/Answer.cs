using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExamsService_Domain.Models
{
   public class Answer
    {
        [Key]
        public int ID { get; set; }
        public string AnswerDescription { get; set; }

        public int QuestionID { get; set; }
        [ForeignKey("QuestionID")]
        public Question Question { get; set; }
    }
}
