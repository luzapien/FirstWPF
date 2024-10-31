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

namespace PhoneBook.Coding
{
    /// <summary>
    /// Interaction logic for FirstCode.xaml
    /// </summary>
    public partial class FirstCode : Window
    {
        public FirstCode()
        {
            InitializeComponent();
        }

        private void FirstButt_Click(object sender, RoutedEventArgs e)
        {
            //Show a messagebox to user
            System.Windows.MessageBox.Show("Hi!");//Show msgbox
            System.Windows.MessageBox.Show("Hi! line 2");
        }


        private void SecondButt_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I am second button!", "Warning");
        }

        private void TitleButt_Click(object sender, RoutedEventArgs e)
        {
            //this.Title = "Hi there!";
            FirstCodeWind.Title = "Hi there";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeContentButt_Click(object sender, RoutedEventArgs e)
        {
            //=================================================
            ChangeContentButt.Content = "I am button";
            ContentLb.Content = "I am Label!";
            //-----------change de text-----------------------
            ContentTbox.Text = "I am textbox!";
        }


        private void change_bg_Click(object sender, RoutedEventArgs e)
        {
            FirstCodeWind.Background = System.Windows.Media.Brushes.YellowGreen;
            this.change_bg.Background = System.Windows.Media.Brushes.Yellow;
        }

        private void change_text_color_Click(object sender, RoutedEventArgs e)
        {
            this.change_text_color.Foreground= System.Windows.Media.Brushes.Red;
            this.ContentLb.Foreground = System.Windows.Media.Brushes.Red;
        }

        private void change_border_color_Click(object sender, RoutedEventArgs e)
        {
            this.change_border_color.BorderBrush = System.Windows.Media.Brushes.Blue;
            this.change_border_color.BorderThickness = new Thickness(4,0,4,0);
        }

        private void enable_btn_Click(object sender, RoutedEventArgs e)
        {
           // this.FirstButt.IsEnabled = true;
            this.child_grid.IsEnabled = true;
        }

        private void disable_btn_Click(object sender, RoutedEventArgs e)
        {
            //this.FirstButt.IsEnabled = false;
            this.child_grid.IsEnabled = false;
        }

        private void show_btn_Click(object sender, RoutedEventArgs e)
        {
            this.child_grid.Visibility = Visibility.Visible;
        }

        private void hide_btn_Click(object sender, RoutedEventArgs e)
        {
            this.child_grid.Visibility = Visibility.Hidden;
        }
    }
}
