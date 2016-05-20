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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WEI_SSMS.ViewModels;
using WEI_SSMS_COMMON;

namespace WEI_SSMS
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowModel mainWindowModel { set; get; }
        public MainWindow()
        {
            InitializeComponent();
            this.mainWindowModel = new MainWindowModel();
            this.DataContext = mainWindowModel;
        }
    }
}
