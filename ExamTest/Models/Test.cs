using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTest.Models
{
    public class Test
    {
        [Key]
        public int IdTest { get; set; }
        public DateTime SysDate { get; set; }
        public string TestName { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }       
    }
}
