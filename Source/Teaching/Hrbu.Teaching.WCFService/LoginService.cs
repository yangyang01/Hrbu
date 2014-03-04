using Hrbu.Teaching.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;
using Hrbu.Teaching.Model.Convertor;
using Teaching.DataAccess;
using Hrbu.Teaching.BusinessView.Model.Power;

namespace Hrbu.Teaching.WCFService
{
   public class LoginService:ILogin
    {
       public List<UserUI> GetUserInfoById(int Id)
       {
           return EntityMapping.Auto<List<User>, List<UserUI>>(LoginContext.GetUserInfoById(Id));
       }

       public bool GetUserByNoAndPass(string No, string password)
       {
           return LoginContext.GetUserByNoAndPass(No, password);
       }

       public bool GetRoleByNo(String No)
       {
           return LoginContext.GetRoleByNo(No);
       }

       public List<string> GetAllRole()
       {
           return LoginContext.GetAllRole();
       }
    }
}
