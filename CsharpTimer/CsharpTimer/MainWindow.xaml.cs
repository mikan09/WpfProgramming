using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CsharpTimer
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;

        private StreamWriter _sw;

        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            // 優先順位を指定してタイマのインスタンスを生成
            _timer = new DispatcherTimer( DispatcherPriority.Background );

            // インターバルを設定
            _timer.Interval = new TimeSpan( 0, 0, 1 );

            // タイマメソッドを設定
            _timer.Tick += ( e, s ) => { TimerMethod();  };

            // 画面が閉じられるときに、タイマを停止
            this.Closing += ( e, s ) => { _timer.Stop(); _sw.Close(); };

            _timer.Start();


            _sw = new StreamWriter( @"C:\work\Test\test.csv", true, Encoding.UTF8 );

        }

        private void TimerMethod()
        {
            var nowTime = DateTime.Now.ToString( "HH:mm:ss" );
            uxClock.Text = nowTime;
            _sw.WriteLine( nowTime );
        }
    }
}

