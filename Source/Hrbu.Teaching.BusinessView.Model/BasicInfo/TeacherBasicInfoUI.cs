using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hrbu.Teaching.BusinessView.Model.BasicInfo
{
    [Serializable]
    [DataContract]
    public partial class TeacherBasicInfoUI
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string EmpNo { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Sex { get; set; }
        [DataMember]
        public string Collage { get; set; }
        [DataMember]
        public string Major { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Tel { get; set; }
        [DataMember]
        public string Mail { get; set; }
        [DataMember]
        public string Photo { get; set; }
        [DataMember]
        public string Course1 { get; set; }
        [DataMember]
        public string Course2 { get; set; }
        [DataMember]
        public string Course3 { get; set; }
        [DataMember]
        public string Course4 { get; set; }
        [DataMember]
        public string PATP { get; set; }
        [DataMember]
        public string HightestDegree { get; set; }
        [DataMember]
        public string GraduationSchool { get; set; }
        [DataMember]
        public string IndividualResume { get; set; }
        [DataMember]
        public string IdentityType { get; set; }
    }
}
