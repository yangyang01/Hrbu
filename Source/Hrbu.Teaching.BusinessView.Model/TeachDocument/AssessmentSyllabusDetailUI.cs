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
    public partial class AssessmentSyllabusDetailUI
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public Nullable<int> CourseCode { get; set; }
        [DataMember]
        public string Chapter { get; set; }
        [DataMember]
        public string KnowledgePoint { get; set; }
        [DataMember]
        public string Memorization { get; set; }
        [DataMember]
        public string Comprehend { get; set; }
        [DataMember]
        public string Apply { get; set; }
        [DataMember]
        public string SampleQuestion { get; set; }
    }
}
