using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Vinylist.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class about : Page
    {
        public about()
        {
            this.InitializeComponent();

            // ============= LIST FOR ITEMS IN COLLECTION =========================
            ObservableCollection<AboutClass> dataList = new ObservableCollection<AboutClass>();

            AboutClass c1 = new AboutClass() { Artist = "Danny Brown", Album = "XXX", Year = "2012" };

            AboutClass c2 = new AboutClass() { Artist = "Kendrick Lamar", Album = "DAMN.", Year = "2017" };

            AboutClass c3 = new AboutClass() { Artist = "Gorillaz", Album = "Demon Days", Year = "2006" };

            dataList.Add(c1);

            dataList.Add(c2);

            dataList.Add(c3);

            AboutList.ItemsSource = dataList;
            // ====================================================================

        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }
    }
}
