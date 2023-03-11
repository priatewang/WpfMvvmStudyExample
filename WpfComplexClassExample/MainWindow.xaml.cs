using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfComplexClassExample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<User> Users;
        public MainWindow()
        {
            InitializeComponent();
           // UserDataInit();
            //UserListView.ItemsSource = Users;
            this.DataContext=new MainWindowViewModel();
        }


        void UserDataInit()
        {
            Users=new ObservableCollection<User>();
            for (int i = 0; i < 10; i++)
            {
                Users.Add(new User()
                {
                    Id = i,
                    Name = "张三",
                    Email = "11111@123.com",
                    UserName = "admin" + i,
                    Desc = "这是一个用户"
                });

            }
        }
    }
}
