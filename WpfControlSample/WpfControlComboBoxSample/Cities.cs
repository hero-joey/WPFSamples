using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlComboBoxSample
{
    internal class Cities : ObservableCollection<String>
    {
        public Cities()
        {
            Add("YunNan");
            Add("GuiZhou");
            Add("SiChuan");
        }
    }
}
