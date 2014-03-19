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
    public class StudentBasicInfoContext : DBContext<StudentBasicInfo>
    {
        public static List<BasicInfo> GetStudentInfoByPage(int startPage, int pageSize, out int totalCount)
        {
            using (var ctx = CreateContext())
            {
                var sql = from s in ctx.Set<StudentBasicInfo>()
                          join d in ctx.Set<DataDicInfo>() on s.Major equals d.Id
                          into d1
                          from d2 in d1.DefaultIfEmpty()
                          where d2.DataDicId == 3||d2.DataDicId==null
                          orderby s.id
                          select new BasicInfo
                          {
                              StudentBasicInfo = s,
                              MajorName = d2.InfoName
                          };
                totalCount = sql.Count();
                return sql.ToList();
            }
        }
        public static StudentBasicInfo GetStudentInfoById(int Id)
        {
            using (var ctx = CreateContext())
            {
                var sql = from s in ctx.Set<StudentBasicInfo>()
                          where s.id == Id
                          select s;
                return sql.FirstOrDefault();

            }
        }
        public static List<BasicInfo> GetStudentSelfInfoById(string No)
        {
            using (var ctx = CreateContext())
            {
                var sql = from s in ctx.Set<StudentBasicInfo>()
                          join d in ctx.Set<DataDicInfo>() on s.Major equals d.Id
                          into d1
                          from d2 in d1.DefaultIfEmpty()
                          where s.StudentNo==No&&(d2.DataDicId == 3||d2.DataDicId==null)
                          orderby s.id
                          select new BasicInfo
                          {
                              StudentBasicInfo = s,
                              MajorName = d2.InfoName
                          };
                return sql.ToList();
            }
        }
    }
}
