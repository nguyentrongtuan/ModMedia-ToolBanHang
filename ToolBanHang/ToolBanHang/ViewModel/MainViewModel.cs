using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Data;



namespace ToolBanHang.ViewModel
{
    class MainViewModel: BaseViewModel
    {
        public bool IsLoaded { set; get; }
        public ICommand TestCM  { set; get; }
        public MainViewModel()
        {
            
            if (!IsLoaded)
            {
                IsLoaded = true;
                // MessageBox.Show("a");
                
            }
            
            

            TestCM = new RelayCommand<object>((p) => { return true; }, (p) => {
                MessageBox.Show("a");
            });  
           
        }

        
    }
}