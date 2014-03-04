
namespace Hrbu.Teaching.Utility
{
    public class Cultures
    {
        public const string zh_cn = "zh-CN";
        public const string en_us = "en-US";
    }



    public enum ItemStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public enum PageStatus
    {
        View, New, Edit, Readonly
    }

    public enum OpinionStatus
    {
        All,
        NotMail,
        OnlyEdit,
        OnlyView
    }

    public class ApplicationPurpose
    {
        public const string Create = "CREATE";
        public const string View = "VIEW";
        public const string Approve = "APPROVE";
        public const string History = "HISTORY";
        public const string Edit = "EDIT";
        public const string CreateDirect = "CREATEDIRECT";
    }
}
