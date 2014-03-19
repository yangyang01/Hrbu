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
    public class TeacherBasicInfoContext:DBContext<TeacherBasicInfo>
    {
        public static List<BasicInfo> GetTeacherInfoByPage(int startPage, int pageSize, out int totalCount)
        {
            using (var ctx = CreateContext())
            {
                var sql = from t in ctx.Set<TeacherBasicInfo>()
                          join d in ctx.Set<DataDicInfo>() on t.Collage equals d.Id
                          into d1
                          from d2 in d1.DefaultIfEmpty()
                          join dd in ctx.Set<DataDicInfo>() on t.Major equals dd.Id
                          into dd1
                          from dd2 in d1.DefaultIfEmpty()
                          orderby t.Id
                          select new BasicInfo { 
                          TeacherBasicInfo=t,
                          CollageName=d2.InfoName,
                          MajorName=dd2.InfoName
                          };
                totalCount = sql.Count();
                return sql.ToList();
            }
        }
        public static TeacherBasicInfo GetTeacherInfoById(int Id)
        {
            using (var ctx = CreateContext())
            {
                var sql = from t in ctx.Set<TeacherBasicInfo>()
                          where t.Id == Id
                          select t;
                return sql.FirstOrDefault();
            }
        }
        public static List<BasicInfo> GetTeacherSelfInfoById(string No)
        {
            using (var ctx = CreateContext())
            {
                var sql = from t in ctx.Set<TeacherBasicInfo>()
                          join d in ctx.Set<DataDicInfo>() on t.Collage equals d.Id
                          into d1
                          from d2 in d1.DefaultIfEmpty()
                          join dd in ctx.Set<DataDicInfo>() on t.Major equals dd.Id
                          into dd1
                          from dd2 in d1.DefaultIfEmpty()
                          orderby t.Id
                          where t.EmpNo == No
                          select new BasicInfo { 
                          TeacherBasicInfo=t,
                          CollageName=d2.InfoName,
                          MajorName=dd2.InfoName
                          };
                return sql.ToList();
            }
        }
    }
}
