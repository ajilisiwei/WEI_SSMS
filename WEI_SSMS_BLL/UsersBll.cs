using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEI_SSMS_COMMON;
using WEI_SSMS_MODELS;
using WEI_SSMS_SERVICE;

namespace WEI_SSMS_BLL
{
    public class UsersBll
    {
        private UsersService _userSvc = new UsersService();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        public bool Login(UsersModel userModel)
        {
            try 
            {
                var users = _userSvc.GetSearchList(u => u.LoginName == userModel.LoginName && u.Password == userModel.Password).FirstOrDefault();
                if(users!=null){
                    CommonMess.PersentUser = users; //添加当前登录用户
                    return true;
                } 
                else return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        public bool AddUser(UsersModel userModel)
        {
            try
            {
                userModel.UserID = Guid.NewGuid();
                userModel.CreatedOn = DateTime.Now;
                userModel.CreatedBy = CommonMess.PersentUser.UserName;
                return _userSvc.Add(userModel);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        public bool UpdateUser(UsersModel userModel)
        {
            try
            {
                userModel.ModifiedOn = DateTime.Now;
                userModel.ModifiedBy = CommonMess.PersentUser.UserName;
                return _userSvc.Update(userModel);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public bool DeleteUser(Guid userID)
        {
            try
            {
                return _userSvc.Delete(userID);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public List<UsersModel> GetAllUsers()
        {
            try
            {
                var userlist = _userSvc.GetSearchList(u=>u.UserName!=null).ToList();
                return userlist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
