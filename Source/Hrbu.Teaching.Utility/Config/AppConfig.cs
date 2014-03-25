using Hrbu.Teaching.Utility;
using System.Configuration;


namespace Hrbu.Teachings.Utility
{
    public class AppConfig : IConfig
    {
        const string ConnectionKey = "TCMGConnection";
        public string ConnectionString
        {
            get
            {
                try
                {
                    return ConfigurationManager.ConnectionStrings[ConnectionKey].ConnectionString;
                }
                catch
                {
                    return "data source=jennyl-pc;initial catalog=TCMG;persist security info=True;user id=sa;password=123;MultipleActiveResultSets=True";
                }
            }
        }

        public string WorkflowURL
        {
            get
            {
                var conf = ConfigurationManager.AppSettings["WorkflowURL"];

                return string.IsNullOrWhiteSpace(conf) ? "http://localhost:8899" : ConfigurationManager.AppSettings["WorkflowURL"];

            }
        }

        public string WebHomeURL
        {
            get
            {
                return ConfigurationManager.AppSettings["WebHomeURL"];
            }
        }

        //public bool IsValidationAD
        //{
        //    get
        //    {
        //        return ConfigurationManager.AppSettings["IsValidationAD"].ToBool();
        //    }
        //}

        public string TeacherInfoExcelPath
        {
            get
            {
                return ConfigurationManager.AppSettings["TeacherInfoExcelPath"];
            }
        }

        public string SessionTimeout
        {
            get
            {
                return ConfigurationManager.AppSettings["SessionTimeout"];
            }
        }

        public string BulkCopyConnection
        {
            get
            {
                return ConfigurationManager.AppSettings["BulkCopyConnection"];
            }
        }

        public string HrNewsImages
        {
            get
            {
                return ConfigurationManager.AppSettings["HrNewsImages"];
            }
        }

        private static readonly AppConfig instance = new AppConfig();

        public static AppConfig Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
