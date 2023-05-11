using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfRelativeSourceExample
{
    internal class MainwindowViewModel: ViewModelBase
    {

        public UserManageUCViewModel UserManage { get; set; }


        public MainwindowViewModel()
        {
            UserManage = new UserManageUCViewModel();
        }

    }
}
