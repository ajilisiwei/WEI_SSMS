using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WEI_SSMS_MODELS;
using WEI_SSMS_SERVICE;

namespace WEI_SSMS
{
    public class Login : NotificationObject
    {
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

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                this._password = value;
                this.RaisePropertyChanged("Password");
            }
        }

        public Action<object> LoginSuccessAction;

        public void LoginAction(object obj)
        {
            UsersModel usermodel = new UsersModel();
            usermodel.LoginName ="wei";
            usermodel.Password = "123";
            if (new UsersService().UserLogin(usermodel))
            {
                if (LoginSuccessAction != null)
                {
                    LoginSuccessAction.BeginInvoke(null,null,null);
                }
            }
        }

    }
}
