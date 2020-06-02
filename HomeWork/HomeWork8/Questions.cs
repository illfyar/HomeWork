using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.HomeWork8
{
    [Serializable]
    public struct Questions
    {
        public List<Question> QuestionsList { get; set; } 
        public int CurrentNumberQuestion { get; set; }

    }
}
