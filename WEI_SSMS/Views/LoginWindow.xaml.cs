using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WEI_SSMS.Common;

namespace WEI_SSMS.Views
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public LoginModel loginmodel = null;
        public Login()
        {
            InitializeComponent();
            LoginModel.LoginSuccessAction = new Action<object>(this.OpenMainWindow);
            LoginModel.CloseWindowAction = new Action(this.CloseWindow);
            //LoginModel loginmodel = new LoginModel();
            loginmodel = new LoginModel();
            this.DataContext = loginmodel;
        }

        public void OpenMainWindow(Object obj)
        {
            this.Dispatcher.Invoke
            (new Action(() =>
                {
                    Window mainwindow = new MainWindow();
                    mainwindow.Show();
                    this.Close();
                })); 
        }

        public void CloseWindow()
        {
            this.Dispatcher.Invoke
                (new Action(() =>
                {
                    this.Close();
                }));
        }

        private void Txt_Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            loginmodel.login.Password = this.Txt_Password.Password;
        }

    }
}
