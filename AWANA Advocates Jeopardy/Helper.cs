using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWANA_Advocates_Jeopardy
{
     public static class Helper
    {
        public static string connectionValue(String name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static Dictionary<string,string> ConvertListToMap(List<LessonPlan> list)
        {
            Dictionary<string,string> returnMap = new Dictionary<string,string>();

            foreach(LessonPlan lesson in list){
                returnMap.Add(lesson.cell, lesson.question);
            }

            return returnMap;

        }
    }
}
