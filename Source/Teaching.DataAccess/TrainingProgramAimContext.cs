using Hrbu.Teaching.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;

namespace Teaching.DataAccess
{
    public class TrainingProgramAimContext : DBContext<TrainingProgramAim>
    {
        public static List<TrainingProgramAim> GetTrainAimByPage(QueryString query, int startPage, int pageSize, out int totalCount)
        {
            using (var ctx = CreateContext())
            {
                var sql = from t in ctx.Set<TrainingProgramAim>()
                          orderby t.id
                          select t;
                //if (query.SchoolYear!= null)
                //{
                //    sql = sql.Where(x => x.SchoolYear == query.SchoolYear);
                //}
                //if (query.SchoolSemester != null)
                //{
                //    sql = sql.Where(x => x.SchoolSemester==query.SchoolSemester);
                //}
                //if (query.Grade != null)
                //{
                //    sql = sql.Where(x => x.Grade == query.Grade);
                //}
                totalCount = sql.Count();
                return sql.ToList();
            }
        }
    }
}
