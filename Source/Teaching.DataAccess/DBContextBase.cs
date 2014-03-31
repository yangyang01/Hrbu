using Hrbu.Teaching.Utility;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Teaching.Model;

namespace Hrbu.Teaching.DataAccess
{
    public class DBContextBase : DbContext
    {
        public DBContextBase()
            : base(ConfigFactory.CreateConfigInstance().ConnectionString)
        { }

        public DBContextBase(string conn)
            : base(conn)
        {

        }
        public string ConnectionString
        {
            get
            {
                return this.Database.Connection.ConnectionString;
            }
        }

        public DbSet<Authorizations> Authorizations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<DataDic> DataDic { get; set; }
        public DbSet<DataDicInfo> DataDicInfo { get; set; }
        public DbSet<StudentBasicInfo> StudentBasicInfo { get; set; }
        public DbSet<TeacherBasicInfo> TeacherBasicInfo { get; set; }
        public DbSet<CourseInfo> CourseInfo { get; set; }
        public DbSet<TrainingProgramAim> TrainingProgramAim { get; set; }
        public DbSet<TrainingProgramInfo> TrainingProgramInfo { get; set; }
        public DbSet<TeachingSyllabusBasic> TeachingSyllabusBasic { get; set; }
        public DbSet<TeachingSyllabusDetail> TeachingSyllabusDetail { get; set; }
        public DbSet<AssessmentSyllabusBasic> AssessmentSyllabusBasic { get; set; }
        public DbSet<AssessmentSyllabusDetail> AssessmentSyllabusDetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//移除复数表名的契约
        }
    }
}
