using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEI_SSMS.Command;

namespace WEI_SSMS
{
    public class TestWindoeModel
    {
        public DelegateCommand AddUserCmd { set; get; }
        public DelegateCommand ReserachUserCmd { set; get; }
        public TestModel TestModel { set; get; }

        public TestWindoeModel()
        {
            TestModel = new TestModel();
            AddUserCmd = new DelegateCommand();
            ReserachUserCmd = new DelegateCommand();
            this.AddUserCmd.ExecuteCommand = new Action<object>(this.TestModel.AddUserAction);
            this.ReserachUserCmd.ExecuteCommand = new Action<object>(this.TestModel.ReserachAction);
        }

    }
}
