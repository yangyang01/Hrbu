using Hrbu.Teaching.BusinessView.Model.Power;
using Hrbu.Teaching.WebUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.Utility;
using Hrbu.Teaching.Interface;

namespace Teaching.Pages.Power
{
    public partial class DataAddUp : BasePage
    {
        public IPower power { get; set; }
        public int DicId
        {
            get
            {
                return GetQueryValue("DicId").ToInt();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["DicId"] != null)
            {
                var data = power.GetDataDicInfoById(DicId);

                this.txtDataName.Text = data.InfoName;
            }
        }
        protected void btSure_Click(object sender, EventArgs e)
        {
            if (Request["DicId"] != null)
            {
                var dataDicInfo = power.GetDataDicInfoById(DicId);

                dataDicInfo.Id = DicId;
                dataDicInfo.InfoName = this.txtDataName.Text;
                power.UpdateDataDic(dataDicInfo);
                WebMessageBox(this.Page, string.Format("'操作成功!',RefreshParentAndCloseSelf"));
            }
            else
            {
                DataDicInfoUI dataInfo = new DataDicInfoUI();
                dataInfo.InfoName = this.txtDataName.Text;
                power.AddDataDic(dataInfo);
                WebMessageBox(this.Page, string.Format("'操作成功!',RefreshParentAndCloseSelf"));

            }
        }

    }
}