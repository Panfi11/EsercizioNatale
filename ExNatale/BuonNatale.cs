using System.Windows;

namespace ExNatale
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Onbtn_Click(object sender, RoutedEventArgs e)
        {
            txb1.IsEnabled = true;
            txb2.IsEnabled = true;
            txb3.IsEnabled = true;
            txb4.IsEnabled = true;
            txb5.IsEnabled = true;
            txb6.IsEnabled = true;
            btnCalcola.IsEnabled = true;
        }
    }
}
