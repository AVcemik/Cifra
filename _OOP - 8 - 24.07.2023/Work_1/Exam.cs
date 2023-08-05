using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class Exam
    {
        public string? Name { get; private set; }
        public Mark? Mark { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
