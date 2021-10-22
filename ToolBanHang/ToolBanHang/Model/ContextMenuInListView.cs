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
    class ContextMenuInListView:ViewModelBase
    {
        private string _HeaderMenu = "";
        public ContextMenuInListView()
        {
            BtnMenu = new DelegateCommand<ContextMenuInListView>((e) =>
            {
                // Debug.WriteLine("wefuiwehfk");
                MessageBox.Show("Menu 1");
            });
           
        }
        public string HeaderMenu
        {
            get => _HeaderMenu; set => SetProperty(ref _HeaderMenu, value);
        }

        public ICommand BtnMenu { get; set; }
    }
}
