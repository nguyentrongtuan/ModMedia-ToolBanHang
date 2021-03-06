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

            BtnOpenDialogInTable = new DelegateCommand<ListTableInListBox>( (e) =>
            {
                Var1 = e.ContentInCol[0].ContentCol1;
                Window _WindowShowTable = new WindowShowTable();
                _WindowShowTable.DataContext = this;
                _WindowShowTable.ShowDialog();

            });

            


            BtnShowRow1 = new DelegateCommand<ListTableInListBox>((e) =>
            {
                MessageBox.Show(Var1);
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

            SrcImgCredit = "https://4.bp.blogspot.com/-Bua0PkbS1ZE/XEWVnOW4b0I/AAAAAAAAZyQ/mEsUKkkEgLoX3b4QHYs5hVkbGmFomXtRQCLcBGAs/s1600/thetindung-diiho.jpg";
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

        private ObservableCollection<ListTableInListBox> _ListTableInListBox1 = new ObservableCollection<ListTableInListBox>();

        public ObservableCollection<ListTableInListBox> ListTableInListBox1
        {
            get => _ListTableInListBox1; set => SetProperty(ref _ListTableInListBox1, value);
        }

        private ObservableCollection<ContextMenuInListView> _ContextMenuInListView = new ObservableCollection<ContextMenuInListView>();


        public ObservableCollection<ContextMenuInListView> ContextMenuInListView
        {
            get => _ContextMenuInListView; set => SetProperty(ref _ContextMenuInListView, value);
        }

        private ObservableCollection<ContentInTable> _TableInWindowShowTable = new ObservableCollection<ContentInTable>();

        public ObservableCollection<ContentInTable> TableInWindowShowTable
        {
            get => _TableInWindowShowTable; set => SetProperty(ref _TableInWindowShowTable, value);
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

        private string _SrcImgCredit = "";

        public string SrcImgCredit
        {
            get => _SrcImgCredit; set => SetProperty(ref _SrcImgCredit, value);
        }

        private string _Var1 = "";
        public string Var1
        {
            get => _Var1; set => SetProperty(ref _Var1, value);
        }

        public ICommand BtnLogin { get; set; }

        public ICommand CmBtnCreateListView { get; set; }
        public ICommand BtnDeleteTable { get; set; }
        public ICommand BtnAddRowTable { get; set; }
        public ICommand BtnOpenDialogInTable { get; set; }

        
        public ICommand BtnLoadComboBox { get; set; }
        public ICommand BtnOpenForm1 { get; set; }
        public ICommand BtnShowRow1 { get; set; }
    }
    
}