using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MusicCastCompanion.Services;

namespace MusicCastCompanion
{
    public partial class MainWindow : Window
    {
        private MusicCastClient? receiver;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Connect_Click(
            object sender,
            RoutedEventArgs e)
        {
            receiver = new MusicCastClient(
                IpAddressBox.Text);

            MessageBox.Show(
                $"Connected to {IpAddressBox.Text}");
        }
        private async void PowerOn_Click(
            object sender,
            RoutedEventArgs e)
        {
            if (receiver == null)
            {
                MessageBox.Show("Please connect to a receiver first.");
                return;
            }

            await receiver.PowerOn();

            MessageBox.Show("Power command sent!");
        }

        private async void PowerOff_Click(
            object sender,
            RoutedEventArgs e)
        {
            if (receiver == null)
            {
                MessageBox.Show("Please connect to a receiver first.");
                return;
            }

            await receiver.PowerOff();

            MessageBox.Show("Power command sent!");
        }

        private async void PowerOnZone2_Click(
            object sender,
            RoutedEventArgs e)
        {
            if (receiver == null)
            {
                MessageBox.Show("Please connect to a receiver first.");
                return;
            }

            await receiver.PowerOnZone2();

            MessageBox.Show("Zone 2 power command sent!");
        }

        private async void PowerOffZone2_Click(
            object sender,
            RoutedEventArgs e)
        {
            if (receiver == null)
            {
                MessageBox.Show("Please connect to a receiver first.");
                return;
            }

            await receiver.PowerOffZone2();

            MessageBox.Show("Zone 2 power command sent!");
        }
    }
}