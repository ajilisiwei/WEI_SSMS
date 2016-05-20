using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEI_SSMS_MODELS;

namespace WEI_SSMS
{
    public class PresentUserModel : NotificationObject
    {
        /// <summary>
        /// 用户名
        /// </summary>
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

        /// <summary>
        /// 登录时间
        /// </summary>
        private string _logintime;
        public string LoginTime
        {
            get
            {
                return _logintime;
            }
            set
            {
                this._logintime = value;
                this.RaisePropertyChanged("LoginTime");
            }
        }

        /// <summary>
        /// 当前用户model
        /// </summary>
        private UsersModel _presentuserinfo;
        public UsersModel PresentUserInfo
        {
            get
            {
                return _presentuserinfo;
            }
            set
            {
                this._presentuserinfo = value;
                this.RaisePropertyChanged("PresentUserInfo");
            }
        }
    }
}
