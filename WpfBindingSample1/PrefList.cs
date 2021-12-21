using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBindingSample1
{
    class PrefList
    {
        public ObservableCollection<string> ComboBoxData { get; }
        public PrefList()
        {
            ComboBoxData = new ObservableCollection<string> { 
                "北海道",
                "青森県",
                "岩手県",
                "秋田県"
            };
            // ↓でも可
            //Data = new ObservableCollection<string>();
            //Data.Add( "北海道" );
            //Data.Add( "青森県" );
            //Data.Add( "岩手県" );
            //Data.Add( "秋田県" );
        }
    }
}
