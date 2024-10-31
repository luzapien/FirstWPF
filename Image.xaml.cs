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
           fn = "C:\\Users\\pc-desarrollo\\Documents\\curso\\FirstWPFSn\\PhoneBook\\Data\\Pics\\autum.jpeg";
           //fn = System.AppDomain.CurrentDomain.BaseDirectory+Data\\Pics\\autum.jpeg;
            //------------------------------------------
            fn = this.text_box.Text;
            //------------------------------------------
            if(fn =="")
            {
                MessageBox.Show("File name is empty");
            }
            else
            {
                Uri img_path = new Uri(fn);
                this.my_image.Source = new BitmapImage(img_path);
            }
           
        }

        private void fill_butt_Click(object sender, RoutedEventArgs e)
        {
            this.my_image.Stretch = Stretch.Fill;
        }

        private void zoom_butt_Click(object sender, RoutedEventArgs e)
        {
            this.my_image.Stretch = Stretch.Uniform;
        }

        private void browser_button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            //--------------------------
            ofd.Title = "Select your image";
            //
            ofd.ShowDialog();
            //-------------------------
            this.text_box.Text = ofd.FileName;
        }
    }
}
