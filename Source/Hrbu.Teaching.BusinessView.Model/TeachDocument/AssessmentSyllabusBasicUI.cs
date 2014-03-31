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
    public partial class AssessmentSyllabusBasicUI
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public Nullable<int> CourseCode { get; set; }
        [DataMember]
        public string AssessmentPurpose { get; set; }
        [DataMember]
        public string CourseFoundation { get; set; }
        [DataMember]
        public string InspectionScope { get; set; }
        [DataMember]
        public Nullable<int> EvaluationMode { get; set; }
        [DataMember]
        public string TestRequirements { get; set; }
        [DataMember]
        public string SOTopicProportion { get; set; }
        [DataMember]
        public string TopicProportion { get; set; }
        [DataMember]
        public string DifficultyLevel { get; set; }
        [DataMember]
        public Nullable<int> AssessmentType { get; set; }
    }
}
