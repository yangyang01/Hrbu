﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hrbu.Teaching.BusinessView.Model.Power
{
    [Serializable]
    [DataContract]
   public partial class DataDicInfoUI
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string InfoName { get; set; }
        [DataMember]
        public Nullable<int> DataDicId { get; set; }


    }
}
