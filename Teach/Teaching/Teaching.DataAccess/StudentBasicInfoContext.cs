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
   public class StudentBasicInfoContext:DBContext<StudentBasicInfo>
    {
       public static List<StudentBasicInfo> GetStudentInfoByPage(int startPage, int pageSize, out int totalCount)
       {
           using (var ctx = CreateContext())
           {
               var sql = from s in ctx.Set<StudentBasicInfo>()
                         orderby s.id
                         select s;
               totalCount = sql.Count();
               return sql.ToList();
           }
       }
    }
}
