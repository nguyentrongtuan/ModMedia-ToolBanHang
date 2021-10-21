using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Data;
using Template.Base;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using ToolBanHang.Model;
using System.Diagnostics;

namespace ToolBanHang.ViewModel
{
    class MainWindowViewModel: ViewModelBase
    {

        public MainWindowViewModel()
        {
            CmBtnCreateListView = new DelegateCommand(() =>
            {
                ListTable.Add(new ListTable
                {
                    col1 = "Nội dung 1",
                    col2 = "Nội dung 2"
                });
            });

            BtnDeleteTable = new DelegateCommand<ListTable>((e) =>
            {
                ListTable.Remove(e);
                Debug.WriteLine("qwefqwejkf");
            });
        }

        private ObservableCollection<ListTable> _ListTable = new ObservableCollection<ListTable>();

        public ObservableCollection<ListTable> ListTable
        {
            get => _ListTable; set => SetProperty(ref _ListTable, value);
        }

        public ICommand CmBtnCreateListView { get; set; }
        public ICommand BtnDeleteTable { get; set; }
    }
}