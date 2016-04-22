using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WEI_SSMS.Views
{
    /// <summary>
    /// TestWindow.xaml 的交互逻辑
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindoeModel testwindowmodel = null;
        public TestWindow()
        {
            InitializeComponent();
            testwindowmodel = new TestWindoeModel();
            this.testwindowmodel.TestModel.AddUserResturn = new Action<bool>(this.AddUserReturn);
            this.DataContext = testwindowmodel;
        }

        public void AddUserReturn(bool success)
        {
            if (success)
                MessageBox.Show("用户添加成功！");
            else
                MessageBox.Show("用户添加失败！");
        }
    }
}
