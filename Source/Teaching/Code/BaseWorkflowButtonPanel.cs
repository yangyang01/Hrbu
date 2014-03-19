using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using WS.Eka.HTHR.BusinessView.Model;
using WS.Eka.HTHR.WebUI.Interface;

namespace WS.Eka.HTHR.WebUI.Code
{
    public class BaseWorkflowButtonPanel : System.Web.UI.UserControl, IButtonPanel
    {
        protected override void OnInit(EventArgs e)
        {
            var buttonList = this.GetWorkFlowButtonList();

            //初始化按钮的点击事件
            foreach (var button in buttonList)
            {
                button.Button.Click += new EventHandler(Button_Click);
            }
            base.OnInit(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            IButtonAction workflowAction = this.Page as IButtonAction;

            //update 2013-11-13 ffzhai 考虑当按钮用户控件位于一个UserControl里面的情况
            if (workflowAction == null)
            {
                workflowAction = this.Parent as IButtonAction;
            }

            if (workflowAction != null)
            {
                var buttonList = this.GetWorkFlowButtonList();

                //初始化按钮的客户端点击事件
                foreach (var button in buttonList)
                {
                    workflowAction.PrepareButton(button);
                }
                base.OnLoad(e);
            }
        }

        public virtual List<WorkFlowButton> GetWorkFlowButtonList()
        {
            throw new Exception("Your ButtonControl must implement GetWorkflowButtonList.");
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            IButtonAction buttonAction = this.Page as IButtonAction;

            //update 2013-11-13 ffzhai 考虑当按钮用户控件位于一个UserControl里面的情况
            if (buttonAction == null)
            {
                buttonAction = this.Parent as IButtonAction;
            }

            WorkFlowButton clickTarget = this.FindWorkflowButton((Button)sender);
            if (buttonAction != null)
            {
                buttonAction.Click(clickTarget);
            }
        }

        private WorkFlowButton FindWorkflowButton(Button button)
        {
            foreach (var btn in this.GetWorkFlowButtonList())
            {
                if (btn.Button == button) return btn;
            }

            return null;
        }
    }
}