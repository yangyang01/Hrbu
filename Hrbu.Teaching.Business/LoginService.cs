using Hrbu.Teaching.BusinessView.Model.Power;
using Hrbu.Teaching.Interface;
using Hrbu.Teaching.Model.Convertor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.DataAccess;
using Teaching.Model;

namespace Hrbu.Teaching.Business
{
    public class LoginService : ILogin
    {
        public List<UserUI> GetUserInfoById(int Id)
        {
            return EntityMapping.Auto<List<User>, List<UserUI>>(LoginContext.GetUserInfoById(Id));
        }

        public bool GetUserByNoAndPass(string No, string password)
        {
            return LoginContext.GetUserByNoAndPass(No, password);
        }

        public bool GetRoleByNo(string No)
        {
            return LoginContext.GetRoleByNo(No);
        }

        public List<string> GetAllRole()
        {
            throw new NotImplementedException();
        }


        public UserUI GetUserInfoByNo(string No)
        {
            return EntityMapping.Auto<User, UserUI>(LoginContext.FirstOrDefault(x => x.UserNo == No));
        }
    }
}
