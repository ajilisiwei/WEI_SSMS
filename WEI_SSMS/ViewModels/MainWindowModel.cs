using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEI_SSMS.Models;

namespace WEI_SSMS.ViewModels
{
    public class MainWindowModel
    {
        public MainWinTopMess mainWinTopMess { set; get; }

        public MainWindowModel()
        {
            this.mainWinTopMess = new MainWinTopMess();
            this.mainWinTopMess.LoginUserName = "wei";
            this.mainWinTopMess.LoginTime = DateTime.Now;
        }
    }
}
