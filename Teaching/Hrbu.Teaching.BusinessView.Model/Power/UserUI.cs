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
    public partial class UserUI
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string UserNo { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public int RoleId { get; set; }
    }
}

