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
    public partial class DataDicUI
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string DataName { get; set; }
    }
}
