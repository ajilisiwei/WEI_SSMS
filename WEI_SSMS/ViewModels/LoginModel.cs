using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WEI_SSMS.Command;
using WEI_SSMS_MODELS;

namespace WEI_SSMS
{
   public class LoginModel
    {
        public DelegateCommand LoginCmd { get; set; } 
        public DelegateCommand CloseWindowCmd { get; set; }
        public Login login { get; set; }

        public static Action<object> LoginSuccessAction = null;

        public static Action CloseWindowAction;

        public LoginModel()
        {
            this.login = new Login();
            this.LoginCmd = new DelegateCommand();
            this.CloseWindowCmd = new DelegateCommand();
            this.LoginCmd.ExecuteCommand = new Action<object>(this.login.LoginAction);
            this.CloseWindowCmd.ExecuteCommand = new Action<object>(this.CloosWindow);
            this.login.LoginSuccessAction = LoginSuccessAction;
        }

        public void CloosWindow(object obj)
        {
            if (CloseWindowAction != null)
            {
                CloseWindowAction.BeginInvoke(null, null);
            }
        }

    }
}
