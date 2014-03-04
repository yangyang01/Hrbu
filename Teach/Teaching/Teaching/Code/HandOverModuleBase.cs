using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS.Eka.HTHR.BusinessView.Model;
using System.Web.UI;
using Newtonsoft.Json;
using WS.Eka.HTHR.Utility;
using WS.Eka.HTHR.Interface;
using WS.Eka.HTHR.Core;
using System.Web.UI.WebControls;

namespace WS.Eka.HTHR.WebUI.Code
{
    public class HandOverModule<T> : BaseUserControl
    {
        protected void SetTitle(Label title)
        {
            title.Text = this.BasePage.HandOverModule != null ? this.BasePage.HandOverModule.HandoverTitle : "";
        }

        private IQuit QuitService = IOCFactory.GetInstance<IQuit>();

        public T ModuleDetail
        {
            get
            {
                if (BasePage.HandOverModule != null && BasePage.HandOverModule.HandoverContent != null)
                {
                    return JsonConvert.DeserializeObject<T>(BasePage.HandOverModule.HandoverContent);
                }
                return default(T);
            }
        }

        protected void UpdateData(T newModel)
        {
            QuitHandoverUI quitHandOverModel = new QuitHandoverUI();

            quitHandOverModel = this.BasePage.HandOverModule;

            quitHandOverModel.HandoverContent = JsonConvert.SerializeObject(newModel);

            quitHandOverModel.ConfirmDate = DateTime.Now;

            quitHandOverModel.Status = (int)HandoverStatus.Confirmed;

            quitHandOverModel.HandoverRealManager = this.BasePage.CurrentUser.Id;

            QuitService.UpdateQuitHandOverInfo(quitHandOverModel, CurrentUser.Id);

            this.BasePage.WebMessageBox(this.Page, "确认成功！", "RefreshParentAndCloseSelf");
        }

        public bool IsHandOverModuleConfirmed
        {
            get
            {
                bool confirmed = false;
                if (this.BasePage.HandOverModule != null && this.BasePage.HandOverModule.Status != null)
                {
                    confirmed = this.BasePage.HandOverModule.Status.Value == (int)HandoverStatus.Confirmed;
                }
                return confirmed;
            }
        }

        protected virtual void SetDisplayMode()
        { 
        }
    }
}