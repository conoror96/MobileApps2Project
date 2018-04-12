using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Vinylist
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();


            
        }

        // Hamburger Menu
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            Hb_menu.IsPaneOpen = true;
        }

        //Navigation Collection from main page
        private void collectionButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.collection), collectionTextbox.Text);
        }

        private void collectionTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //navigation wantlist from main page

        private void wantlistButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.wantlist), wantlistTextbox.Text);
        }

        private void wantlistTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //from hamburger to collection button
        private void menu1btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.collection), collectionTextbox.Text);
        }

        //from hamburger to wantlist button
        private void menu2btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.wantlist), wantlistTextbox.Text);
        }

        //from hamburger to about button
        private void menu3btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.about));
        }

        //from hamburger to contact button
        private void menu4btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.contact));
        }

      
    }
}
