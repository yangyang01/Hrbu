using System;
using System.Collections.Generic;
using System.Data;
using Teaching.Model;

namespace Hrbu.Teaching.Model
{
    public partial class BasicInfo
    {
        public StudentBasicInfo StudentBasicInfo { get; set; }
        public TeacherBasicInfo TeacherBasicInfo { get; set; }
        public string ClassName { get; set; }
        public string CollageName { get; set; }
        public string MajorName { get; set; }
    }
    public partial class UserInfo
    {
        public User User { get; set; }
        public string RoleName { get; set; }
    }

    public partial class Course 
    {
        public CourseInfo CourseInfo { get; set; }
        public string CoursePropertyCn { get; set; }
        public string CourseTypeCn { get; set; }
    }
    public partial class TrainingProgramCourseInfo
    {
        public TrainingProgramInfo TrainingProgramInfo { get; set; }
        public string CourseName { get; set; }
        public string CoursePropertyCn { get; set; }
        public string CourseTypeCn { get; set; }
        public Nullable<int> Credit { get; set; }
        public Nullable<int> PeriodTotal { get; set; }
        public string SchoolYear { set; get; }
        public string SchoolSemester { set; get; }
        public string ProfessionalEmphasis { set; get; }
        public string EvaluationMode { set; get; }
    }
}
