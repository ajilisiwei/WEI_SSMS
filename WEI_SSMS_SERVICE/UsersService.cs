using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEI_SSMS_DAL;
using WEI_SSMS_MODELS;

namespace WEI_SSMS_SERVICE
{
    public class UsersService : BaseService<UsersModel, Users, Guid>
    {
        public bool UserLogin(UsersModel usermodel)
        {
            try 
            {
                if (GetSearchList(u => u.LoginName == usermodel.LoginName && u.Password == usermodel.Password).Count() >=1)
                    return true;
                else return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }



    }
}
