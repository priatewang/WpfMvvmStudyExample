using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Threading;
using System.Windows.Input;

namespace WpfMvvmLightExample.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                //方式一：
                //_name = value;
                //RaisePropertyChanged();
                //方式二：
                Set(ref _name, value);

            }
        }

        public ICommand ChangeNameCmd
        {
            get
            {
                return new RelayCommand<object>(o =>
                {
                    Name = "命令改名";
                });
            }
        }


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            Name = "lisi";
            
        }



    }
}