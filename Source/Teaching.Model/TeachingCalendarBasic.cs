//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Teaching.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeachingCalendarBasic
    {
        public int id { get; set; }
        public Nullable<int> SchoolSemester { get; set; }
        public Nullable<int> CourseCode { get; set; }
        public Nullable<int> SemesterPeriod { get; set; }
        public Nullable<int> WeekPeriod { get; set; }
        public string Class { get; set; }
        public string Teacher { get; set; }
        public string StaffRoomPrincipal { get; set; }
        public string CollagePrincipal { get; set; }
    }
}
