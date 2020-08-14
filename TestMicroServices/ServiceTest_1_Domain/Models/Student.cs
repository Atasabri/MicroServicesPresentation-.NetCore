using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsService_Domain.Models
{
   public  class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Level { get; set; }
    }
}
