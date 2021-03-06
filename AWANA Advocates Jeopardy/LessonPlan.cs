using System;
using System.Collections.Generic;
using System.Text;

namespace AWANA_Advocates_Jeopardy
{
    public class LessonPlan
    {
        public int refNum { get; set; }
        public string lessonName { get; set; }
        public string cell { get; set; }
        public string question { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{ lessonName} {cell}";
            }
        }
    }
}