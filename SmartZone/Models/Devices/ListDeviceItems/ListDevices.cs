using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartZone.Models.Devices.ListDeviceItems
{
    public class ListDevices
    {
        public string Icon { get; set; }
        public string DeviceCategory { get; set; }
    }
    public class FakeDevicesData
    {
        public static ObservableCollection<ListDevices> GetData()
        {
            var data = new ObservableCollection<ListDevices>();
            data.Add(new ListDevices()
            {
                Icon = "\uE957",
                DeviceCategory = "Command Center"
            });
            data.Add(new ListDevices()
            {
                Icon = "\uEA80",
                DeviceCategory = "Đèn"
            });
            data.Add(new ListDevices()
            {
                Icon = "\uE960",
                DeviceCategory = "Camera"
            });
            data.Add(new ListDevices()
            {
                Icon = "\uE95D",
                DeviceCategory = "Máy chiếu"
            });
            data.Add(new ListDevices()
            {
                Icon = "\uE7F5",
                DeviceCategory = "Loa"
            });
            return data;
        }
    }
}
