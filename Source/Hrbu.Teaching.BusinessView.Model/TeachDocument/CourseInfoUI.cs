using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hrbu.Teaching.BusinessView.Model.TeachDocument
{
    [Serializable]
    [DataContract]
    public partial class CourseInfoUI
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<int> CourseCode { get; set; }
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public Nullable<int> CourseProperty { get; set; }
        [DataMember]
        public Nullable<int> CourseType { get; set; }
        [DataMember]
        public Nullable<int> Credit { get; set; }
        [DataMember]
        public Nullable<int> PeriodTotal { get; set; }
    }
}
