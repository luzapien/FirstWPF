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
using System.Windows.Shapes;

namespace PhoneBook
{
    /// <summary>
    /// Interaction logic for Image.xaml
    /// </summary>
    public partial class Image : Window
    {
        public Image()
        {
            InitializeComponent();
        }

        private void load_butt_Click(object sender, RoutedEventArgs e)
        {
            String fn;
            fn = "C:\\Users\\pc-desarrollo\\Documents\\curso\\FirstWPFSn\\PhoneBook\\Data\\Pics\\pumpkin.jpeg";
            //------------------------------------------
            Uri img_path = new Uri(fn);
            this.my_image.Source = new BitmapImage(img_path);
        }
    }
}
