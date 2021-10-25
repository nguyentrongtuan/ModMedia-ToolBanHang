using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Base;
using System.Windows.Input;
using System.Diagnostics;
using ToolBanHang.ViewModels;
using System.Windows;
using ToolBanHang.Model;
using System.Collections.ObjectModel;

namespace ToolBanHang.Model

{
    class ListTableInListBox: ViewModelBase
    {
        public ListTableInListBox()
        {
            


        }

        private string _Col1 = "";
        private string _Col2 = "";
        private ContextMenuInListView _menu;
        private ObservableCollection<ContentInTable> _ContentInCol = new ObservableCollection<ContentInTable>();

        public ObservableCollection<ContentInTable> ContentInCol
        {
            get => _ContentInCol; 
            set => SetProperty(ref _ContentInCol, value);
        }

        public string Col1
        {
            get => _Col1; set => SetProperty(ref _Col1, value);
        }
        public string Col2
        {
            get => _Col2; set => SetProperty(ref _Col2, value);
        }
        public ContextMenuInListView menu
        {
            get => _menu; set => SetProperty(ref _menu, value);
        }

    

    }
}
