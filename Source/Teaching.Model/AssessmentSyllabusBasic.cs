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
    
    public partial class AssessmentSyllabusBasic
    {
        public int id { get; set; }
        public Nullable<int> CourseCode { get; set; }
        public string AssessmentPurpose { get; set; }
        public string CourseFoundation { get; set; }
        public string InspectionScope { get; set; }
        public Nullable<int> EvaluationMode { get; set; }
        public string TestRequirements { get; set; }
        public string SOTopicProportion { get; set; }
        public string TopicProportion { get; set; }
        public string DifficultyLevel { get; set; }
    }
}
