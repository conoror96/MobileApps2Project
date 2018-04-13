using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
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
    public sealed partial class contact : Page
    {

        DataTransferManager dataTransferManager = DataTransferManager.GetForCurrentView();

        public contact()
        {
            this.InitializeComponent();

            // ============= LIST FOR ITEMS IN COLLECTION =========================
            ObservableCollection<ContactClass> dataList = new ObservableCollection<ContactClass>();

            ContactClass c1 = new ContactClass() { Website = "Twitter", Handle = "@Vinylist" };

            ContactClass c2 = new ContactClass() { Website = "Discogs", Handle = "@VinylistApp." };
            
            ContactClass c3 = new ContactClass() { Website = "Instagram", Handle = "@TheVinylist" };

            dataList.Add(c1);

            dataList.Add(c2);

            dataList.Add(c3);

            ContactList.ItemsSource = dataList;

        }

        // ===========================CONTRACT SHARING=====================================

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            dataTransferManager = DataTransferManager.GetForCurrentView();
            dataTransferManager.DataRequested += DataTransferManager_DataRequested;
        }

        private void DataTransferManager_DataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {
            DataRequest request = args.Request;
            request.Data.Properties.Title = "Share Some Feedback!";

            request.Data.SetText(shareBox.Text);
            request.Data.SetWebLink(new Uri("https://www.microsoft.com/en-ie/store/appsvnext/windows"));
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            dataTransferManager.DataRequested -= DataTransferManager_DataRequested;
        }

        private void postbtnShare_Click(object sender, RoutedEventArgs e)
        {
            DataTransferManager.ShowShareUI();
        }


        // ===================BACK BUTTON============================
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }
    }
}
