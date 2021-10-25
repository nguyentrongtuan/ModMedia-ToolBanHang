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
    class ClassComboBox : MainWindowViewModel
    {
        private string _Box11 = "";
        private string _Box12 = "";
        public string Box11
        {
            get => _Box11; set => SetProperty(ref _Box11, value);
        }

        public string Box12
        {
            get => _Box12; set => SetProperty(ref _Box12, value);
        }
    }
}
