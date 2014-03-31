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
    public partial class TeachingSyllabusDetailUI
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public Nullable<int> CourseCode { get; set; }
        [DataMember]
        public string CourseContent { get; set; }
        [DataMember]
        public Nullable<int> TheoreticalLessons { get; set; }
        [DataMember]
        public Nullable<int> ExperimentLessons { get; set; }
        [DataMember]
        public Nullable<int> ExerciseLessons { get; set; }
        [DataMember]
        public Nullable<int> ComputerLessons { get; set; }
        [DataMember]
        public string TeachRequirement { get; set; }
        [DataMember]
        public string Synopsis { get; set; }
        [DataMember]
        public string TeachKeyPoint { get; set; }
        [DataMember]
        public string LessonReview { get; set; }
        [DataMember]
        public string TeachingAims { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public Nullable<int> SerialNo { get; set; }

    }
}
