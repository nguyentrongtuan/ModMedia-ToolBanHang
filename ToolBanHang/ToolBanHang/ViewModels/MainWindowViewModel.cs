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

namespace ToolBanHang.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {

        public MainWindowViewModel()
        {


            CmBtnCreateListView = new DelegateCommand(() =>
            {
                var listContent = new List<ContentInTable>();
                listContent.Add(new ContentInTable() { ContentCol1 = "Abigail", ContentCol2 = "Abigail" });
                listContent.Add(new ContentInTable() { ContentCol1 = "Abigail1", ContentCol2 = "Abigail1" });
                listContent.Add(new ContentInTable() { ContentCol1 = "Abigail2", ContentCol2 = "Abigail2" });

                ListTableInListBox.Add(new ListTableInListBox
                {
                    menu = new ContextMenuInListView
                    {
                        HeaderMenu1 = "Menu 1",
                        HeaderMenu2 = "Menu 2"
                    },
                    ContentInCol = new ObservableCollection<ContentInTable>(listContent)
                });

                listContent.Add(new ContentInTable() { ContentCol1 = "Abigail3", ContentCol2 = "Abigail3" });




            });


            BtnLoadComboBox = new DelegateCommand<ClassComboBox>((e) =>
            {
                var listDatamyComboBox = new List<ClassComboBox>();
                listDatamyComboBox.Add(new ClassComboBox() { Box11 = "a", Box12 = "Description of a" });
                listDatamyComboBox.Add(new ClassComboBox() { Box11 = "a1", Box12 = "Description of a1" });
                listDatamyComboBox.Add(new ClassComboBox() { Box11 = "a2", Box12 = "Description of a2" });
                MyComboBox = new ObservableCollection<ClassComboBox>(listDatamyComboBox);
            });


            BtnDeleteTable = new DelegateCommand<ListTableInListBox>((e) =>
            {
                ListTableInListBox.Remove(e);
            });

            BtnAddRowTable = new DelegateCommand<ListTableInListBox>((e) =>
            {
                e.ContentInCol.Add(new ContentInTable()
                {
                    ContentCol1 = "wrjkff n",
                    ContentCol2 = "wjhwef n"
                });
            });

            BtnOpenForm1 = new DelegateCommand(() =>
            {
                Window _WindowForm1 = new WindowForm1();
                _WindowForm1.ShowDialog();
            });

            TbName = "Tuấn";
            TbPhone = "0906006";
            BtnLogin = new DelegateCommand(() =>
            {
                MessageBox.Show(TbName);
            });
        }

        private ObservableCollection<ClassComboBox> _MyComboBox = new ObservableCollection<ClassComboBox>();

        public ObservableCollection<ClassComboBox> MyComboBox
        {
            get => _MyComboBox; set => SetProperty(ref _MyComboBox, value);
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

        private string _TbName = "";
        private string _TbPhone = "";

        public string TbName
        {
            get => _TbName; set => SetProperty(ref _TbName, value);
        }

        public string TbPhone
        {
            get => _TbPhone; set => SetProperty(ref _TbPhone, value);
        }


        public ICommand BtnLogin { get; set; }

        public ICommand CmBtnCreateListView { get; set; }
        public ICommand BtnDeleteTable { get; set; }
        public ICommand BtnAddRowTable { get; set; }

        
        public ICommand BtnLoadComboBox { get; set; }
        public ICommand BtnOpenForm1 { get; set; }
    }
}