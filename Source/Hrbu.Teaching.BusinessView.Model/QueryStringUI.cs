using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hrbu.Teaching.BusinessView.Model
{
    [DataContract]
    public class QueryStringUI
    {
        [DataMember]
        public string UserNo { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public Nullable<int> CourseCode { get; set; }
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public Nullable<int> SchoolYear { get; set; }
        [DataMember]
        public Nullable<int> SchoolSemester { get; set; }
        [DataMember]
        public Nullable<int> Grade { get; set; }
    }
}
