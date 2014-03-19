using Hrbu.Teaching.BusinessView.Model.TeachDocument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hrbu.Teaching.Interface
{
    [ServiceContract]
    public partial interface ITeachDocument
    {
        [OperationContract]
        List<CourseInfoUI> GetCourseNameList();
    }
}
