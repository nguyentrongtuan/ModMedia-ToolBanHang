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
    class ContentInTable: MainWindowViewModel
    {
        private string _ContentCol1 = "";
        private string _ContentCol2 = "";
        public string ContentCol1
        {
            get => _ContentCol1; 
            set => SetProperty(ref _ContentCol1, value);
        }

        public string ContentCol2
        {
            get => _ContentCol2; 
            set => SetProperty(ref _ContentCol2, value);
        }
    }
}
