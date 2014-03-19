using Hrbu.Teaching.BusinessView.Model.BasicInfo;
using Hrbu.Teaching.BusinessView.Model.Power;
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
}
