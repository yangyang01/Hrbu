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
    public partial class StudentBasicInfoUI
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string StudentNo { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Sex { get; set; }
        [DataMember]
        public int Major { get; set; }
        [DataMember]
        public string Class { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Tel { get; set; }
        [DataMember]
        public string Mail { get; set; }
        [DataMember]
        public string Photo { get; set; }
        [DataMember]
        public string ZipCope { get; set; }
        [DataMember]
        public string Contacts { get; set; }
    }
}
