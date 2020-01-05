using System;
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

namespace NataleExs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            int pari = 0;
            int dispari = 0;
            int n1 = int.Parse(txb1.Text);
            int n2 = int.Parse(txb2.Text);
            int n3 = int.Parse(txb3.Text);
            int n4 = int.Parse(txb4.Text);
            int n5 = int.Parse(txb5.Text);
            int n6 = int.Parse(txb6.Text);
            if( n1 % 2 == 0)
            {
                pari++;
            }
            else
            {
                dispari++;
            }
            if (n2 % 2 == 0)
            {
                pari++;
            }
            else
            {
                dispari++;
            }
            if (n3 % 2 == 0)
            {
                pari++;
            }
            else
            {
                dispari++;
            }
            if (n4 % 2 == 0)
            {
                pari++;
            }
            else
            {
                dispari++;
            }
            if (n5 % 2 == 0)
            {
                pari++;
            }
            else
            {
                dispari++;
            }
            if (n6 % 2 == 0)
            {
                pari++;
            }
            else
            {
                dispari++;
            }
            LblRisultato.Content = $"sono stati inseriti {pari} pari e sono stati inseriti {dispari} dispari";
        }
    }
}
