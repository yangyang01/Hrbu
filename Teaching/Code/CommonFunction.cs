using System.Linq;
using System.Web.UI.WebControls;
using WS.Eka.HTHR.BusinessView.Model;
using WS.Eka.HTHR.Core;
using WS.Eka.HTHR.Interface;

namespace WS.Eka.HTHR.WebUI.Code
{
    public static class CommonFunction
    {
        static IBasicInfo service = IOCFactory.GetInstance<IBasicInfo>();
        public static void BindDropDownListWithNOEmpty(this DropDownList obj, string type)
        {
            if (obj != null)
            {
                var typeList = service.GetBasicDataByType(type);
                obj.DataSource = typeList;
                obj.DataTextField = "ChineseName";
                obj.DataValueField = "Code";
                obj.DataBind();
            }
        }

        public static void BindDropDownListWithEmpty(this DropDownList obj, string type)
        {
            if (obj != null)
            {
                var typeList = service.GetBasicDataByType(type);
                typeList.Insert(0, new BasicDataUI() { Code = "", ChineseName = "请选择" });
                obj.DataSource = typeList;
                obj.DataTextField = "ChineseName";
                obj.DataValueField = "Code";
                obj.DataBind();
            }
        }

        public static void BindDropDownListWithDefault(this DropDownList obj, string type)
        {
            if (obj != null)
            {
                obj.Items.Clear();
                var typeList = service.GetBasicDataByType(type);
                obj.DataSource = typeList;
                obj.DataTextField = "ChineseName";
                obj.DataValueField = "Code";
                obj.DataBind();
                obj.Items.Insert(0, new ListItem("请选择", ""));
            }
        }

        public static void BindDropDownListWithDefaultOrderByCN(this DropDownList obj, string type)
        {
            if (obj != null)
            {
                obj.Items.Clear();
                var typeList = service.GetBasicDataByType(type).OrderBy(p => p.ChineseName);
                obj.DataSource = typeList;
                obj.DataTextField = "ChineseName";
                obj.DataValueField = "Code";
                obj.DataBind();
                obj.Items.Insert(0, new ListItem("请选择", ""));
            }
        }

        public static void BindDropDownListWithDefaultFromSource(this DropDownList ddl, object source,
            string dataTextField, string dataValueField, string defaultText = "请选择", string dafaultValue = "")
        {
            if (ddl != null)
            {
                ddl.Items.Clear();
                ddl.DataSource = source;
                ddl.DataTextField = dataTextField;
                ddl.DataValueField = dataValueField;
                ddl.DataBind();
                ddl.Items.Insert(0, new ListItem(defaultText, dafaultValue));
            }
        }

        public static void BindDropDownListWithoutDefaultFromSource(this DropDownList ddl, object source, string dataTextField, string dataValueField)
        {
            if (ddl != null)
            {
                ddl.Items.Clear();
                ddl.DataSource = source;
                ddl.DataTextField = dataTextField;
                ddl.DataValueField = dataValueField;
                ddl.DataBind();
            }
        }
    }
}