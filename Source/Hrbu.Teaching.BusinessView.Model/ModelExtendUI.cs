using Hrbu.Teaching.BusinessView.Model.BasicInfo;
using Hrbu.Teaching.BusinessView.Model.Power;
using Hrbu.Teaching.BusinessView.Model.TeachDocument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hrbu.Teaching.BusinessView.Model
{
    [DataContract]
    public class BasicInfoUI
    {
        [DataMember]
        public StudentBasicInfoUI StudentBasicInfo { get; set; }
        [DataMember]
        public TeacherBasicInfoUI TeacherBasicInfo { get; set; }
        [DataMember]
        public string ClassName { get; set; }
        [DataMember]
        public string CollageName { get; set; }
        [DataMember]
        public string MajorName { get; set; }
    }

    [DataContract]
    public partial class UserInfoUI
    {
        [DataMember]
        public UserUI User { get; set; }
        [DataMember]
        public string RoleName { get; set; }
    }
    [DataContract]
    public partial class CourseUI
    {
        [DataMember]
        public CourseInfoUI CourseInfo { get; set; }
        [DataMember]
        public string CoursePropertyCn { get; set; }
        [DataMember]
        public string CourseTypeCn { get; set; }
    }

    public partial class TrainingProgramCourseInfoUI
    {
        [DataMember]
        public TrainingProgramInfoUI TrainingProgramInfo { get; set; }
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public string CoursePropertyCn { get; set; }
        [DataMember]
        public string CourseTypeCn { get; set; }
        [DataMember]
        public Nullable<int> Credit { get; set; }
        [DataMember]
        public Nullable<int> PeriodTotal { get; set; }
        [DataMember]
        public string SchoolYear { set; get; }
        [DataMember]
        public string SchoolSemester { set; get; }
        [DataMember]
        public string ProfessionalEmphasis { set; get; }
        [DataMember]
        public string EvaluationMode { set; get; }
        
    }
}
