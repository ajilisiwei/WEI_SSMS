using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEI_SSMS_MODELS;

namespace WEI_SSMS.Models
{
    public class MainWinTopMess : NotificationObject
    {

        private string _loginUserName;

        public string LoginUserName
        {
            get
            {
                return _loginUserName;
            }
            set
            {
                this._loginUserName = value;
                this.RaisePropertyChanged("LoginUserName");
            }
        }


        private DateTime _loginTime;

        public DateTime LoginTime
        {
            get
            {
                return _loginTime;
            }
            set
            {
                this._loginTime = value;
                this.RaisePropertyChanged("LoginTime");
            }
        }
        
        
    }
}
