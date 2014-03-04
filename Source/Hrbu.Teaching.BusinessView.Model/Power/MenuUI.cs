using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hrbu.Teaching.BusinessView.Model.Power
{
    [Serializable]
    [DataContract]
    public partial class MenuUI
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string URL { get; set; }
        [DataMember]
        public string NameCn { get; set; }
        [DataMember]
        public string NameEn { get; set; }
        [DataMember]
        public int ParentId { get; set; }
        [DataMember]
        public int SeqNo { get; set; }
    }
}
