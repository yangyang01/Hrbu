using Hrbu.Teaching.BusinessView.Model.TeachDocument;
using Hrbu.Teaching.Interface;
using Hrbu.Teaching.Model.Convertor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.DataAccess;
using Teaching.Model;

namespace Hrbu.Teaching.Business
{
    public class TeachDocumentService : ITeachDocument
    {

        public List<CourseInfoUI> GetCourseNameList()
        {
            return EntityMapping.Auto<List<CourseInfo>, List<CourseInfoUI>>(CourseInfoContext.GetCourseNameList());
        }
    }
}
