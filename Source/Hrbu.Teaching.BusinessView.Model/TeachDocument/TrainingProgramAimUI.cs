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
    public partial class TrainingProgramAimUI
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public Nullable<int> SchoolSemester { get; set; }
        [DataMember]
        public Nullable<int> Grade { get; set; }
        [DataMember]
        public string TrainAim { get; set; }
        [DataMember]
        public string SpecificationRequirements { get; set; }
        [DataMember]
        public string LearningDegree { get; set; }
        [DataMember]
        public string TeachingPlatform { get; set; }
        [DataMember]
        public string ProfessionalPlatform { get; set; }
        [DataMember]
        public string PracticalPlatform { get; set; }
        [DataMember]
        public Nullable<int> SchoolYear { get; set; }

    }
}
