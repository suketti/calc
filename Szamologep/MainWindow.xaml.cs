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

namespace Szamologep
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

        private void btnAdditionClick(object sender, RoutedEventArgs e)
        {
            String res = $"{txtANum.Text} + {txtBNum.Text} = {Convert.ToDouble(txtANum.Text) + Convert.ToDouble(txtBNum.Text)}";
            MessageBox.Show("Az összeadás eredménye: " + res);
            lbResults.Items.Add(res);
        }

        private void btnSubstractClick(object sender, RoutedEventArgs e)
        {
            String res = $"{txtANum.Text} - {txtBNum.Text} = {Convert.ToDouble(txtANum.Text) - Convert.ToDouble(txtBNum.Text)}";
            MessageBox.Show("A kivonás eredménye: " + res);
            lbResults.Items.Add(res);
        }

        private void btnMultiplicationClick(object sender, RoutedEventArgs e)
        {
            String res = $"{txtANum.Text} ✕ {txtBNum.Text} = {Convert.ToDouble(txtANum.Text) * Convert.ToDouble(txtBNum.Text)}";
            MessageBox.Show("A szorzás eredménye: " + res);
            lbResults.Items.Add(res);
        }

        private void btnDivisionClick(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(txtBNum.Text) == 0)
            {
                MessageBox.Show("Nullával nem osztunk!");
            } 
            else
            {
                String res = $"{txtANum.Text} / {txtBNum.Text} = {Convert.ToDouble(txtANum.Text) / Convert.ToDouble(txtBNum.Text)}";
                MessageBox.Show("Az osztás eredménye: " + res);
                lbResults.Items.Add(res);
            }
        }
    }
}
