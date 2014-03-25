using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teaching.Model
{
    public class QueryString
    {
        public string UserNo { get; set; }
        public string UserName { get; set; }
        public Nullable<int> CourseCode { get; set; }
        public string CourseName { get; set; }
        public Nullable<int> SchoolYear { get; set; }
        public Nullable<int> SchoolSemester { get; set; }
        public Nullable<int> Grade { get; set; }

    }
}
