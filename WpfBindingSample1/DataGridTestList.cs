using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfBindingSample1
{
    class DataGridTestList
    {
        // バインディングの指定先プロパティ
        public ObservableCollection<DataGridTest> Data { get; }

        // コンストラクタ(データ入力)
        public DataGridTestList()
        {
            Data = new ObservableCollection<DataGridTest> {
                new DataGridTest { Subj="国語", Points=90, Name="田中　一郎", ClassName="A" },
                new DataGridTest { Subj="数学", Points=50, Name="鈴木　二郎", ClassName="A" },
                new DataGridTest { Subj="英語", Points=90, Name="佐藤　三郎", ClassName="B" }
            };
        }
    }
}
