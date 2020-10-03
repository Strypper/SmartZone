using SmartZone.Models.Devices.IoTDevices;
using SmartZone.Models.Devices.ListDeviceItems;
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

namespace SmartZone
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RoomPage : Page
    {
        private ObservableCollection<ListDevices> deviceCategory;
        private ObservableCollection<IotDeviceModel> ioTDevices;
        public RoomPage()
        {
            this.InitializeComponent();
            deviceCategory = FakeDevicesData.GetData();
            ioTDevices = FakeIoTDevicesData.GetData();
            NavLinksList.ItemsSource = deviceCategory;
            IoTDevicesList.ItemsSource = ioTDevices;
        }
    }
}
