using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBanHang.ViewModel
{
    class MainViewModel: BaseViewModel
    {
        public bool IsLoaded { set; get; }
        public MainViewModel()
        {
            
            if (!IsLoaded)
            {
                IsLoaded = true;
                // MessageBox.Show("a");
                
            }
        }

        
    }
}
