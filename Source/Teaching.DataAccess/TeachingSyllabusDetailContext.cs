using Hrbu.Teaching.DataAccess;
using Hrbu.Teaching.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;

namespace Teaching.DataAccess
{
    public class TeachingSyllabusDetailContext : DBContext<TeachingSyllabusDetail>
    {
        public static bool IsExitTeachingDetailInfo(int CourseCode, int SerialNo)
        {
            using (var ctx = CreateContext())
            {
                var sql = from t in ctx.Set<TeachingSyllabusDetail>()
                          where t.SerialNo == SerialNo && t.CourseCode == CourseCode
                          select t;
                return sql.Count() > 0;
            }
        }
        public static List<TeachingSyllabusInfo> GetTeachingSyllabusDetailByPage(int CourseCode,int startPage, int pageSize, out int totalCount)
        {
            using (var ctx = CreateContext())
            {
                var sql = from t in ctx.Set<TeachingSyllabusDetail>()
                          orderby t.SerialNo
                          where t.CourseCode==CourseCode
                          select new TeachingSyllabusInfo
                          {
                              TeachingSyllabusDetail=t,
                              Total=t.ExerciseLessons+t.ExperimentLessons+t.ComputerLessons+t.TheoreticalLessons
                          };
                totalCount = sql.Count();
                return sql.Skip(pageSize * (startPage - 1)).Take(pageSize).ToList();
            }
        }


    }
}
