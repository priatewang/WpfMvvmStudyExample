using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace WpfRelativeSourceExample
{
    public class UserManageUCViewModel : ViewModelBase
    {
        public ObservableCollection<UserModel> Users{ get; set; }


        public UserManageUCViewModel()
        {
            Users= new ObservableCollection<UserModel>();
            Users.Add(new UserModel() { Id=1,Name="张三",Age=11});
            Users.Add(new UserModel() { Id=2,Name="李四",Age=22});
        }

        public CommandBase ModifyCmd
        {
            get
            {
                return new CommandBase(o =>
                {
                    var user=o as UserModel;
                    MessageBox.Show($"UserManageUCViewModel Modify:{user.Name}");
                });
            }
        }

    }
}
