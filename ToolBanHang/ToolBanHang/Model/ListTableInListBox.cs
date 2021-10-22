using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Base;
using System.Windows.Input;
using System.Diagnostics;
using ToolBanHang.ViewModel;
using System.Windows;

namespace ToolBanHang.Model

{
    class ListTableInListBox:ViewModelBase
    {
        public ListTableInListBox()
        {
            
        }
        private string _col1 = "";
        private string _col2 = "";
        private ContextMenuInListView _menu;
        

        public string col1
        {
            get => _col1; set => SetProperty(ref _col1, value);
        }
        public string col2
        {
            get => _col2; set => SetProperty(ref _col2, value);
        }
        public ContextMenuInListView menu
        {
            get => _menu; set => SetProperty(ref _menu, value);
        }

    }
}
