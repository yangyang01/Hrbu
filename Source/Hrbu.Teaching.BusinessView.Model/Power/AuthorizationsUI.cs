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
    public class AuthorizationsUI
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<int> MenuId { get; set; }
        [DataMember]
        public Nullable<int> RoleId { get; set; }
        [DataMember]
        public string MenuName { get; set; }
        [DataMember]
        public Nullable<bool> Enable { get; set; }
    }
}
