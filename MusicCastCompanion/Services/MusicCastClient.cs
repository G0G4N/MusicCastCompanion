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
using System.Net.Http;
using System.Threading.Tasks;


namespace MusicCastCompanion.Services
{
    internal class MusicCastClient
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;

        public MusicCastClient(string ip)
        {
            _client = new HttpClient();
            _baseUrl = $"http://{ip}/YamahaExtendedControl/v1";
        }

        public async Task PowerOn()
        {
            await _client.GetAsync(
                $"{_baseUrl}/main/setPower?power=on");
        }

        public async Task PowerOff()
        {
            await _client.GetAsync(
                $"{_baseUrl}/main/setPower?power=standby");
        }
    }
}