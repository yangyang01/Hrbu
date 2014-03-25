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
    public partial class TrainingProgramInfoUI
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public Nullable<int> SchoolSemester { get; set; }
        [DataMember]
        public Nullable<int> Grade { get; set; }
        [DataMember]
        public Nullable<int> ProfessionalEmphasis { get; set; }
        [DataMember]
        public Nullable<int> CourseCode { get; set; }
        [DataMember]
        public Nullable<int> TeachingPeriod { get; set; }
        [DataMember]
        public Nullable<int> ExperimentPeriod { get; set; }
        [DataMember]
        public Nullable<int> PracticeWeeks { get; set; }
        [DataMember]
        public Nullable<int> EvaluationMode { get; set; }
        [DataMember]
        public string Remark { get; set; }
        [DataMember]
        public Nullable<int> SchoolYear { get; set; }
    }
}
