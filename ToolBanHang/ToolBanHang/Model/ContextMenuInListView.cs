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

namespace ToolBanHang.Model
{
    class ContextMenuInListView:MainWindowViewModel
    {
        private string _HeaderMenu1 = "";
        private string _HeaderMenu2 = "";
        public ContextMenuInListView()
        {

            BtnMenu1 = new DelegateCommand<ListTableInListBox>((e) =>
            {
                Debug.WriteLine("wefuiwehfk");
                MessageBox.Show(e.ContentInCol[0].ContentCol1);
                // MessageBox.Show("menu 1");
            });
        }
        public string HeaderMenu1
        {
            get => _HeaderMenu1; set => SetProperty(ref _HeaderMenu1, value);
        }
        
        public string HeaderMenu2
        {
            get => _HeaderMenu2; set => SetProperty(ref _HeaderMenu2, value);
        }

        public ICommand BtnMenu1 { get; set; }
    }
}
