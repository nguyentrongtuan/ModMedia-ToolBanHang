using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Base;
using System.Windows.Input;
using System.Diagnostics;
using ToolBanHang.ViewModel;

namespace ToolBanHang.Model

{
    class ListTable:ViewModelBase
    {
        public ListTable()
        {
            DeleteBtn = new DelegateCommand<object>((e) =>
            {
                
                Debug.WriteLine("wefuiwehfk");
                //MainWindowViewModel.
            });
        }
        private string _col1 = "wefjwejfwjf";
        private string _col2 = "wfjkwjef";
        public string col1
        {
            get => _col1; set => SetProperty(ref _col1, value);
        }
        public string col2
        {
            get => _col2; set => SetProperty(ref _col2, value);
        }
        public ICommand DeleteBtn { get; set; }
    }
}
