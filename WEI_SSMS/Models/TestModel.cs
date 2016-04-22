using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEI_SSMS_BLL;
using WEI_SSMS_MODELS;

namespace WEI_SSMS.Models
{
    public class TestModel : NotificationObject
    {
        private UsersModel _userModel;

        public UsersModel UserModel 
        {
            get
            {
                return _userModel;
            }
            set
            {
                this._userModel = value;
                this.RaisePropertyChanged("UserModel");
            }
        }

        private string _username;

        public string UserName 
        {
            get
            {
                return _username;
            }
            set
            {
                this._username = value;
                this.RaisePropertyChanged("UserName");
            }
        }

        private List<UsersModel> _userlist;
        public List<UsersModel> UserList
        {
            get {
                return _userlist;
            }
            set {
                this._userlist = value;
                this.RaisePropertyChanged("UserList");
            }
        }

        public Action<bool> AddUserResturn;
        public Action<bool> UpdateUserResturn;
        public Action<bool> DeleteUserResturn;
        public Action<bool> ReserachResturn;

        public void AddUserAction(object usermodel)
        {
            try
            {
                UsersModel um = new UsersModel();
                um.UserName = UserName;
                if (new UsersBll().AddUser(um))
                {
                    if (AddUserResturn != null)
                    {
                        AddUserResturn.BeginInvoke(true, null, null);
                    }
                }
                else 
                {
                    if (AddUserResturn != null)
                    {
                        AddUserResturn.BeginInvoke(false, null, null);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void ReserachAction(object usermode)
        {
            try
            {
               UserList=new UsersBll().GetAllUsers();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateAction()
        {
            try
            {

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

    }
}
