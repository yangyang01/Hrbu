using System.ComponentModel;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace Hrbu.Teaching.Utility
{
    public static class Helper
    {
        public const string NODisable = "NODisable";
        /// <summary>
        /// Set Panel child contols to editable
        /// </summary>
        /// <param name="panel">The parent container</param>
        /// <param name="isReadonly">true:set control to editable, false: set control to readonly</param>
        public static void ControlEditable(Control panel, bool editable)
        {
            if (panel == null || editable)
                return;
            Control[] ctls = panel.Controls.Cast<Control>().ToArray();
            for (int i = 0; i < ctls.Length; i++)
            {
                Control p = ctls[i];

                bool skip = SkipControl(p);
                if (skip)
                {
                    continue;
                }

                if (p is TextBox)
                {
                    TextBox q = p as TextBox;
                    //q.Attributes.Add("disabled", "disabled");
                    q.ReadOnly = true;
                }
                else if (p is DropDownList)
                {
                    DropDownList q = p as DropDownList;
                    q.Attributes.Add("disabled", "disabled");
                }
                else if (p is CheckBox)
                {
                    CheckBox q = p as CheckBox;
                    q.Attributes.Add("disabled", "disabled");
                }
                else if (p is RadioButtonList)
                {
                    RadioButtonList q = p as RadioButtonList;
                    q.Attributes.Add("disabled", "disabled");
                }
                else if (p is CheckBoxList)
                {
                    CheckBoxList q = p as CheckBoxList;
                    q.Attributes.Add("disabled", "disabled");
                }
                else if (p is HtmlImage)
                {
                    HtmlImage q = p as HtmlImage;
                    q.Visible = false;
                }
                else if (p is HtmlAnchor)
                {
                    HtmlAnchor q = p as HtmlAnchor;
                    q.Attributes.Add("disabled", "disabled");
                }

                //set property for all of the children
                if (p.HasControls())
                {
                    ControlEditable(p, editable);
                }
            }
        }

        public static void EnableControl(Control panel, bool isEnable)
        {
            if (panel == null)
                return;
            Control[] ctls = panel.Controls.Cast<Control>().ToArray();
            for (int i = 0; i < ctls.Length; i++)
            {
                Control p = ctls[i];

                bool skip = SkipControl(p);
                if (skip)
                {
                    continue;
                }

                if (p is TextBox)
                {
                    TextBox q = p as TextBox;
                    q.Enabled = isEnable;
                }
                else if (p is DropDownList)
                {
                    DropDownList q = p as DropDownList;
                    q.Enabled = isEnable;
                }
                else if (p is CheckBox)
                {
                    CheckBox q = p as CheckBox;
                    q.Enabled = isEnable;
                }
                else if (p is RadioButtonList)
                {
                    RadioButtonList q = p as RadioButtonList;
                    q.Enabled = isEnable;
                }
                else if (p is CheckBoxList)
                {
                    CheckBoxList q = p as CheckBoxList;
                    q.Enabled = isEnable;
                }
                else if (p is HtmlImage)
                {
                    HtmlImage q = p as HtmlImage;
                    q.Visible = isEnable;
                }
                else if (p is HtmlAnchor)
                {
                    HtmlAnchor q = p as HtmlAnchor;
                    if (isEnable)
                    {
                        q.Attributes.Add("disabled", "disabled");
                    }
                    else
                    {
                        q.Attributes.Remove("disabled");
                    }
                }

                //set property for all of the children
                if (p.HasControls())
                {
                    EnableControl(p, isEnable);
                }
            }
        }

        public static bool SkipControl(Control p)
        {
            string attribute = string.Empty;
            if (p is HtmlGenericControl)
            {
                HtmlGenericControl htmlControl = p as HtmlGenericControl;
                attribute = htmlControl.Attributes[NODisable];
            }
            if (p is WebControl)
            {
                WebControl webControl = p as WebControl;
                attribute = webControl.Attributes[NODisable];
            }
            if (p is HtmlTableCell)
            {
                HtmlTableCell htmltableCell = p as HtmlTableCell;
                attribute = htmltableCell.Attributes[NODisable];
            }
            if (!string.IsNullOrEmpty(attribute) && attribute.ToLower() == "true")
                return true;
            return false;
        }

        public static string GetContentTypeFromExtension(string extension)
        {
            string contentType = string.Empty;
            switch (extension.ToUpperInvariant())
            {
                case "XLSX":
                    contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    break;
                case "DOCX":
                    contentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                    break;
                case "PPTX":
                    contentType = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
                    break;
                case "BMP":
                    contentType = "image/bmp";
                    break;
                case "JPG":
                    contentType = "image/jpg";
                    break;
                case "PNG":
                    contentType = "image/png";
                    break;
                case "PDF":
                    contentType = "application/pdf";
                    break;
                case "DOC":
                    contentType = "application/msword";
                    break;
                case "XLS":
                    contentType = "application/excel";
                    break;
                case "PPT":
                    contentType = "application/mspowerpoint";
                    break;
                case "TXT":
                    contentType = "text/plain";
                    break;
                case "MSG":
                    contentType = "application/outlook";
                    break;
                case "ZIP":
                    contentType = "application/zip";
                    break;
                default:
                    contentType = "text/plain";
                    Logger.Log("Unsupported file format");
                    break;
            }
            return contentType;
        }

        public static string GetAbsoluteUri(string absoluteUri, string relativeUri)
        {
            const char UriSplitter = '/';
            StringBuilder builder = new StringBuilder();
            absoluteUri = absoluteUri.Trim();
            if (absoluteUri.StartsWith(".") || absoluteUri.StartsWith("/"))
            {
                throw new Exception(string.Format("The parameter absoluteUri {0} is relative", absoluteUri));
            }
            else if (absoluteUri.StartsWith("http", StringComparison.InvariantCultureIgnoreCase))
            {
                if (absoluteUri.EndsWith(new string(UriSplitter, 1)))
                {
                    absoluteUri = absoluteUri.Substring(0, absoluteUri.Length - 1).Trim();
                }
                else
                {
                    // Nothing to do.
                }
                int firstComma = absoluteUri.IndexOf(':');
                if (firstComma < 0)
                {
                    throw new Exception(string.Format("Uri {0} should have protocol type!", absoluteUri));
                }
                else
                {
                    string[] protocolAndUri = new string[] { absoluteUri.Substring(0, firstComma), absoluteUri.Substring(firstComma + 1) };

                    absoluteUri = protocolAndUri[1];
                    int lastSplitter = absoluteUri.LastIndexOf(UriSplitter);
                    if (lastSplitter == (absoluteUri.Length - 1))
                    {
                        throw new Exception(string.Format("Invalid format in uri {0}", absoluteUri));
                    }
                    else
                    {
                        string[] segments = relativeUri.Split(new char[] { UriSplitter }, StringSplitOptions.RemoveEmptyEntries);
                        string[] splittingAbsoluteUris = absoluteUri.Split(new char[] { UriSplitter }, StringSplitOptions.RemoveEmptyEntries);
                        Stack<string> stack = new Stack<string>();
                        foreach (string splittingAbsoluteUri in splittingAbsoluteUris)
                        {
                            stack.Push(splittingAbsoluteUri);
                        }
                        stack.Pop();

                        foreach (string segment in segments)
                        {
                            switch (segment)
                            {
                                case ".":
                                    continue;
                                case "..":
                                    stack.Pop();
                                    break;
                                default:
                                    stack.Push(segment);
                                    break;
                            }
                        }
                        builder.AppendFormat("{0}://", protocolAndUri[0]);

                        string[] array = stack.ToArray();
                        for (var i = array.Length - 1; i >= 0; i--)
                        {
                            builder.AppendFormat("{0}/", array[i]);
                        }
                        builder.Remove(builder.Length - 1, 1);
                    }
                }
            }
            else
            {
                throw new Exception(string.Format("Unknown uri {0}", absoluteUri));
            }

            return builder.ToString();
        }

        public static List<T> ReaderToList<T>(IDataReader dr)
        {
            using (dr)
            {
                List<string> field = new List<string>(dr.FieldCount);

                for (int i = 0; i < dr.FieldCount; i++)
                {
                    field.Add(dr.GetName(i).ToLower());
                }

                List<T> list = new List<T>();

                while (dr.Read())
                {
                    T model = Activator.CreateInstance<T>();

                    foreach (PropertyInfo property in model.GetType().GetProperties(BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance))
                    {
                        switch (property.Name)
                        {
                            case "DeptName":
                                if (!IsNullOrDBNull(dr["部门班组"]))
                                {
                                    property.SetValue(model, HackType(dr["部门班组"], property.PropertyType), null);
                                }
                                break;
                            case "EmployeeName":
                                if (!IsNullOrDBNull(dr["姓名"]))
                                {
                                    property.SetValue(model, HackType(dr["姓名"], property.PropertyType), null);
                                }
                                break;
                            case "Date":
                                if (!IsNullOrDBNull(dr["日期"]))
                                {
                                    property.SetValue(model, HackType(dr["日期"], property.PropertyType), null);
                                }
                                break;
                            case "OnDuty":
                                if (!IsNullOrDBNull(dr["上午上班"]))
                                {
                                    property.SetValue(model, HackType(dr["上午上班"], property.PropertyType), null);
                                }
                                break;
                            case "OnDutyDesc":
                                if (!IsNullOrDBNull(dr["上班描述"]))
                                {
                                    property.SetValue(model, HackType(dr["上班描述"], property.PropertyType), null);
                                }
                                break;
                            case "OffDuty":
                                if (!IsNullOrDBNull(dr["下午下班"]))
                                {
                                    property.SetValue(model, HackType(dr["下午下班"], property.PropertyType), null);
                                }
                                break;
                            case "OffDutyDesc":
                                if (!IsNullOrDBNull(dr["下班描述"]))
                                {
                                    property.SetValue(model, HackType(dr["下班描述"], property.PropertyType), null);
                                }
                                break;
                            case "LateMinutes":
                                if (!IsNullOrDBNull(dr["迟到分钟"]))
                                {
                                    property.SetValue(model, HackType(dr["迟到分钟"], property.PropertyType), null);
                                }
                                break;
                            case "LeaveEarlyMinutes":
                                if (!IsNullOrDBNull(dr["早退分钟"]))
                                {
                                    property.SetValue(model, HackType(dr["早退分钟"], property.PropertyType), null);
                                }
                                break;
                            case "OTHours":
                                if (!IsNullOrDBNull(dr["加班小时"]))
                                {
                                    property.SetValue(model, HackType(dr["加班小时"], property.PropertyType), null);
                                }
                                break;
                            case "AbsentDays":
                                if (!IsNullOrDBNull(dr["旷工(天)"]))
                                {
                                    property.SetValue(model, HackType(dr["旷工(天)"], property.PropertyType), null);
                                }
                                break;
                            case "UnClockInCount":
                                if (!IsNullOrDBNull(dr["未刷次数"]))
                                {
                                    property.SetValue(model, HackType(dr["未刷次数"], property.PropertyType), null);
                                }
                                break;
                            case "EmpNo":
                                if (!IsNullOrDBNull(dr["工号"]))
                                {
                                    property.SetValue(model, HackType(dr["工号"], property.PropertyType), null);
                                }
                                break;
                        }
                    }
                    list.Add(model);
                }
                return list;
            }
        }

        public static DataTable ListToDataTable<T>(List<T> list)
        {
            DataTable table = new DataTable(typeof(T).Name);

            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in Props)
            {
                table.Columns.Add(prop.Name);
            }

            foreach (T item in list)
            {
                var values = new object[Props.Length];

                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }

                table.Rows.Add(values);
            }
            return table;
        }

        public static bool IsNullOrDBNull(object obj)
        {
            return ((obj is DBNull) || (string.IsNullOrEmpty(obj.ToString())));
        }

        /// <summary>
        /// 对可空类型进行判断转化
        /// </summary>
        /// <param name="value">转换对象</param>
        /// <param name="conversionType">转换对象类型</param>
        /// <returns></returns>
        public static object HackType(object value, Type conversionType)
        {
            if (conversionType.IsGenericType && conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                    return null;

                System.ComponentModel.NullableConverter nullableConverter = new NullableConverter(conversionType);
                conversionType = nullableConverter.UnderlyingType;
            }
            return Convert.ChangeType(value, conversionType);
        }

        /// <summary>
        /// 重写Distinct,便于通过Lambda表达式查找
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="source"></param>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        //public static IEnumerable<TSource> Distinct<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        //{
        //    HashSet<TKey> seenKeys = new HashSet<TKey>();

        //    foreach (TSource element in source)
        //    {
        //        var elementValue = keySelector(element);
        //        if (seenKeys.Add(elementValue))
        //        {
        //            yield return element;
        //        }
        //    }
        //}

        public static bool IsNumberic(string str)
        {
            bool isNum = true;
            if (str != null && str.Length > 0)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    int chr = Convert.ToChar(str[i]);
                    if (chr < 48 || chr > 57)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                isNum = false;
            }
            return isNum;
        }

        public static List<string> GetDateToQuery()
        {
            return GetDateToQuery(DateTime.Now);
        }

        public static List<string> GetDateToQuery(DateTime curruntMouth)
        {
            List<string> list = new List<string>();
            list.Add(curruntMouth.DateFormatString(DateTimeExtensions.DATE_MOUTH));
            for (int i = 1; i <= 12; i++)
            {
                string month = curruntMouth.AddMonths(-i).DateFormatString(DateTimeExtensions.DATE_MOUTH);
                list.Add(month);
            }
            return list;
        }

        public static string IntToWeekString(this int obj)
        {
            var weeks = new string[] { "一", "二", "三", "四", "五", "六", "日", };

            if (obj > 0 && obj < 8)
            {
                return weeks[obj - 1];
            }
            return null;
        }

        public static void SelectedByText(this DropDownList ddlList, string text)
        {
            if (ddlList == null) return;
            ddlList.SelectedIndex = ddlList.Items.IndexOf(ddlList.Items.FindByText(text));
        }

        public static void SelectedByValue(this DropDownList ddlList, string value)
        { 
            if (ddlList == null) return;
            ddlList.SelectedIndex = ddlList.Items.IndexOf(ddlList.Items.FindByValue(value));
        }

        public static void SelectedByIndex(this DropDownList ddlList, int index)
        {
            if (ddlList == null) return;

            if (index > ddlList.Items.Count) index = 0;

            ddlList.SelectedIndex = index;
        }


        public static void BindDataToListControl(this ListControl control, object dataSource, string textField, string valueField)
        {
            if (dataSource != null)
            {
                control.DataSource = dataSource;

                control.DataTextField = textField;

                control.DataValueField = valueField;

                control.DataBind();
            }
        }
    }

}
