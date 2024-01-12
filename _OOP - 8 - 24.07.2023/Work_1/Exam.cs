using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    public class Exam
    {
        public string? ExamName { get; private set; }
        public int Mark { get; set; }

        public Exam (string examName)
        {
            ExamName = examName;
        }
    }
}
