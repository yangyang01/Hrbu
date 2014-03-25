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
    public partial class TeachingSyllabusBasicUI
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public Nullable<int> CourseCode { get; set; }
        [DataMember]
        public string TeachAim { get; set; }
        [DataMember]
        public string TeachTask { get; set; }
        [DataMember]
        public string TeachContent { get; set; }
        [DataMember]
        public string TeachPrinciple { get; set; }
        [DataMember]
        public string TeachMethod { get; set; }
        [DataMember]
        public Nullable<int> PrerequisiteCourse { get; set; }
        [DataMember]
        public string Textbook { get; set; }
        [DataMember]
        public string ReferenceBook { get; set; }
    }
}
