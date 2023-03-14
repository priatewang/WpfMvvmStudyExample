using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfComplexClassExample.Base;

namespace WpfComplexClassExample
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<User> _users;

        public ObservableCollection<User> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }
        

        public ICommand MutliCommand
        {
            get => new CommandBase(new Action<object>(o =>
            {
                IList list=o as IList;
                List<User> users=new List<User>();
                foreach (User item in list)
                {
                    users.Add(item);
                }
            }));
        }

        public MainWindowViewModel()
        {
            UserDataInit();

        }
        /// <summary>
        ///模拟数据（忽略）
        /// </summary>
        void UserDataInit()
        {
            Users = new ObservableCollection<User>();
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
