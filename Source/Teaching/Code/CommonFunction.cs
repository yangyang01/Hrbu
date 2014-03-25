using System.Linq;
using System.Web.UI.WebControls;
using Hrbu.Teaching.BusinessView.Model;
using Hrbu.Teaching.Interface;
using StructureMap;
using System;

namespace Hrbu.Teaching.WebUI.Code
{
    public static class CommonFunction
    {
        public static IPower powerService = ObjectFactory.Container.GetInstance<IPower>();
        public static ITeachDocument TeachDocumentService = ObjectFactory.Container.GetInstance<ITeachDocument>();

        public static void BindDropDownListWithDefault(this DropDownList obj, int type)
         {
            if (obj != null)
            {
                obj.Items.Clear();
                var typeList = powerService.GetDataDicByType(type);
                obj.DataSource = typeList;
                obj.DataTextField = "InfoName";
                obj.DataValueField = "Id";
                obj.DataBind();
                obj.Items.Insert(0, new ListItem("请选择", ""));
            }
        }

        public static void BindRoleDropDownListWithDefault(this DropDownList obj)
        {
            if (obj != null)
            {
                obj.Items.Clear();
                var typeList = powerService.GetRoleNameList();
                obj.DataSource = typeList;
                obj.DataTextField = "describe";
                obj.DataValueField = "id";
                obj.DataBind();
                obj.Items.Insert(0, new ListItem("请选择", ""));
            }
        }

        public static void BindCourseDropDownListWithDefault(this DropDownList obj)
        {
            if (obj != null)
            {
                obj.Items.Clear();
                var typeList = TeachDocumentService.GetCourseNameList();
                obj.DataSource = typeList;
                obj.DataTextField = "CourseName";
                obj.DataValueField = "CourseCode";
                obj.DataBind();
                obj.Items.Insert(0, new ListItem("请选择", ""));
            }
        }
       
    }
}