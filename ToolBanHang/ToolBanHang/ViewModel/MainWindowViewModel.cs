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

                ListTableInListBox.Add(new ListTableInListBox
                {
                    col1 = "Header Cột 2",
                    col2 = "Header Cột 1",
                    menu = new ContextMenuInListView
                    {
                        HeaderMenu = "Menu 1",
                    }
                });

               
            });

            BtnDeleteTable = new DelegateCommand<ListTableInListBox>((e) =>
            {
                ListTableInListBox.Remove(e);
            });

            BtnMenu1 = new DelegateCommand<ListTableInListBox>((e) =>
            {
                Debug.WriteLine("aaaa");
            });
        }

        private ObservableCollection<ListTableInListBox> _ListTableInListBox = new ObservableCollection<ListTableInListBox>();

        public ObservableCollection<ListTableInListBox> ListTableInListBox
        {
            get => _ListTableInListBox; set => SetProperty(ref _ListTableInListBox, value);
        }

        private ObservableCollection<ContextMenuInListView> _ContextMenuInListView = new ObservableCollection<ContextMenuInListView>();


        public ObservableCollection<ContextMenuInListView> ContextMenuInListView
        {
            get => _ContextMenuInListView; set => SetProperty(ref _ContextMenuInListView, value);
        }

        public ICommand CmBtnCreateListView { get; set; }
        public ICommand BtnDeleteTable { get; set; }
        public ICommand BtnMenu1 { get; set; }
    }
}