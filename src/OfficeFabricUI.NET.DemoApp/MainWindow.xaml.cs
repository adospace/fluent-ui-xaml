using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace OfficeFabricUI.DemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FabricWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            lstIcons.ItemsSource = Enum.GetValues(typeof(FabricIconEnum));

            this.Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            listView.ItemsSource = await GetUserList();
            dataGrid.ItemsSource = DummyData.Get();
        }

        private async Task<IEnumerable> GetUserList()
        {
            using var httpClient = new HttpClient();
            using var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/users");
            string apiResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<User>>(apiResponse);
        }

        private void lstIcons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count != 1) return;
            var icon = e.AddedItems.Cast<FabricIconEnum>().First();
            Clipboard.SetText($"<fabric:FabricIcon Icon=\"{icon}\" />");
        }

        
    }
}
