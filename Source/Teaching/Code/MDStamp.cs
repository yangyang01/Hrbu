using System.Collections.Generic;
using WS.Eka.HTHR.BusinessView.Model;
using WS.Eka.HTHR.Core;
using WS.Eka.HTHR.Interface;
using WS.Eka.HTHR.Utility;

namespace WS.Eka.HTHR.WebUI.Code
{
    public class MDStamp : StampBase
    {
        
        private const string imgPathBase = "/Content/stamp/";

        private const string imgCreate = "Create.png";
        private const string imgPending = "Pending1.png";
        private const string imgApproved = "Approved.png";
        private const string imgRejected = "Rejected.png";
        private const string imgAskForMore = "AskForMore.png";
        private const string imgCancel = "Rejected.png";
        
        private long applicationId;
        private ApprovalAction action;

        public MDStamp(long applicationId, ApprovalAction action)
        {
            this.applicationId = applicationId;
            this.action = action;
        }

        public override string ToString()
        {
            stamps = new List<SingleStamp>();
            IApplicationAction appaction = IOCFactory.GetInstance<IApplicationAction>();
            IApplication application = IOCFactory.GetInstance<IApplication>();
            ApplicationUI app = application.GetpplicationByID(this.applicationId);
            List<ApplicationActionUI> appcationList = appaction.GetApplicationActionByAppID(this.applicationId, action);
            if (appcationList != null && appcationList.Count > 0)
            {
                foreach (var item in appcationList)
                {
                    var actionuser = item.ActionUserName;
                    if (item.Action == (int)ApprovalAction.Create && !string.IsNullOrEmpty(item.AgentToUserName) && item.AgentToUserName != item.ActionUserName)
                    {
                        actionuser = item.AgentToUserName.Trim();
                    }
                    stamps.Add(new SingleStamp() { ImgPath = imgPathBase + GetAppActionPicture((ApprovalAction)item.Action), Line1 = actionuser, Line2 = item.ActionTime.ToString("yyyy-MM-dd"), ToolTips = EnumDataSource<ApprovalAction>.GetDisplayValue(item.Action, "zh-cn") });
                }
                if (action != ApprovalAction.Approve)
                {
                    IAttendance leave = IOCFactory.GetInstance<IAttendance>();
                    IApplication iapplication = IOCFactory.GetInstance<IApplication>();
                    List<TaskUserExtendUI> taskListuser = iapplication.GetApplicationToDoTaskWithUser(this.applicationId);
                    List<TaskGroupExtendUI> taskListgroup = iapplication.GetApplicationToDoTaskWithGroup(this.applicationId);
                    if (app.Status == (int)ApplicationStatus.Pending)
                    {
                        string todouser = string.Empty;
                        if (taskListuser != null && taskListuser.Count > 0)
                        {
                            int length = taskListuser.Count;
                            for (int i = 0; i < length; i++)
                            {
                                todouser = todouser + taskListuser[i].vwEmpBasicInfo.ChineseName + ";";
                            }
                        }
                        if (taskListgroup != null && taskListgroup.Count > 0)
                        {
                            int length = taskListgroup.Count;
                            for (int i = 0; i < length; i++)
                            {
                                todouser = todouser + taskListgroup[i].AuthorizationGroup.NAME + ";";
                            }
                        }
                        todouser = todouser.Trim(';');
                        stamps.Add(new SingleStamp() { ImgPath = imgPathBase + imgPending, Line1 = todouser, Line2 = "", ToolTips = "待处理" });
                    }
                }
                
                //string CNTitle = "<p>" + Resources.NameResource.Process + "&nbsp;(" + Resources.NameResource.Current + ":";
                //int count = appcationList.Count - 1;
                //string Status = appcationList[count].ActionUserName + " " + EnumDataSource<ApprovalAction>.GetDisplayValue(appcationList[count].Action, "zh-cn");
                //string TotalContent = CNTitle + Status + ")</p>";
                //return TotalContent + base.ToString();

                return base.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        private string GetAppActionPicture(ApprovalAction action)
        {
            string pic = string.Empty;
            switch (action)
            {
                case ApprovalAction.Create:
                    pic = imgCreate;
                    break;
                case ApprovalAction.Reject:
                    pic = imgRejected;
                    break;
                case ApprovalAction.Approve:
                    pic = imgApproved;
                    break;
                case ApprovalAction.AskForMore:
                    pic = imgAskForMore;
                    break;
                case ApprovalAction.Withdraw:
                    pic = imgCancel;
                    break;
                default:
                    pic = imgCreate;
                    break;
            }

            return pic;
        }
    }
}