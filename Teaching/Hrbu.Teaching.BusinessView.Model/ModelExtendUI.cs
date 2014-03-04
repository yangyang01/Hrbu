using Hrbu.Teaching.BusinessView.Model.BasicInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hrbu.Teaching.BusinessView.Model
{
    [DataContract]
    public class StudentInfoUI
    {
        [DataMember]
        public StudentBasicInfoUI StudentBasicInfo { get; set; }
        [DataMember]
        public string CollageName { get; set; }
        [DataMember]
        public string MajorName { get; set; }
    }
}
