using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfRelativeSourceExample
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }



        public CommandBase ModifyCmd
        {
            get
            {
                return new CommandBase(o =>
                {
                    MessageBox.Show($"UserModel Modify:{Name}");
                });
            }
        }

    }
}
