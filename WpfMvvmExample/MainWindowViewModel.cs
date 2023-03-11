using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmExample.Base;

namespace WpfMvvmExample
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _name;
        private ObservableCollection<string> _messages;
        private string _mySelectedItem;
        private string _status;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string NewName { get; set; }

        public string MySelectedItem
        {
            get
            {
                return _mySelectedItem;
            }
            set
            {
                _mySelectedItem = value;
                OnPropertyChanged();
            }
        }

        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                OnPropertyChanged();
            }
        }

        public List<string> Options { get; set; }

        public ObservableCollection<string> Messages
        {
            get
            {
                return _messages;
            }
            set
            {
                _messages = value;
                OnPropertyChanged();
            }
        }


        public CommandBase UpdateCommand
        {
            get
            {
                return new CommandBase(obj =>
                {
                    Name = obj.ToString() + "---" + NewName;
                });
            }
        }

        public CommandBase ChangedCommand
        {
            get
            {
                return new CommandBase(obj =>
                {
                    MySelectedItem = obj.ToString();
                });
            }
        }

        public CommandBase StatusCommand
        {
            get
            {
                return new CommandBase(obj =>
                {
                    Status = "鼠标进入";
                });
            }
        }


        public MainWindowViewModel()
        {
            Name = "1234";
            NewName = "张三";
            Options = new List<string>() { "选项1", "选项2", "选项3" };
            MySelectedItem = "未选择";
            Status = "无状态";
            Messages = new ObservableCollection<string>() { "消息1", "消息2", "消息3", "消息4" };

        }
    }
}
