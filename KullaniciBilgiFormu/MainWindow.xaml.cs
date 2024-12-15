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

namespace KullaniciBilgiFormu
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

        private void butonEkle_Click(object sender, RoutedEventArgs e)
        {
            string ad = textAd.Text.Trim();
            string soyad = textSoyad.Text.Trim();
            string yas = textYas.Text.Trim();


            
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(yas))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }

            
            if (!int.TryParse(yas, out int yasDegeri) || yasDegeri < 0)
            {
                MessageBox.Show("Lütfen geçerli bir yaş girin!");
                return;
            }

          
            string bilgi = $"{ad} {soyad}, {yasDegeri} yaşında";
            listBilgiler.Items.Add(bilgi);

            
            textAd.Clear();
            textSoyad.Clear();
            textYas.Clear();
        }

        
    }
}

        
    
