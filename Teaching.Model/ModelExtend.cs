using System;
using System.Collections.Generic;
using System.Data;
using Teaching.Model;

namespace Hrbu.Teaching.Model
{
    public partial class StudentInfo
    {
        public StudentBasicInfo StudentBasicInfo { get; set; }
        public string CollageName { get; set; }
        public string MajorName { get; set; }
    }
}
