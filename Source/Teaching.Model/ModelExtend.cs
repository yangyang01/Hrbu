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
}
