using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartZone.Models.Devices.IoTDevices
{
    public class IotDeviceModel
    {
        public string Icon { get; set; }
        public string FontFamily { get; set; }
        public string DeviceName { get; set; }
        public string RoomName { get; set; }
        public string GradientColor1 { get; set; }
        public string GradientColor2 { get; set; }
    }
    public class FakeIoTDevicesData
    {
        public static ObservableCollection<IotDeviceModel> GetData()
        {
            var data = new ObservableCollection<IotDeviceModel>();
            data.Add(new IotDeviceModel()
            {
                Icon = "\uEA80",
                FontFamily = "Segoe MDL2 Assets",
                DeviceName = "Đèn 1",
                RoomName = "Phòng 1",
                GradientColor1 = "#FDC830",
                GradientColor2 = "#F37335"
            });
            data.Add(new IotDeviceModel()
            {
                Icon = "\uEA80",
                FontFamily = "Segoe MDL2 Assets",
                DeviceName = "Đèn 2",
                RoomName = "Phòng 1",
                GradientColor1 = "#FDC830",
                GradientColor2 = "#F37335"
            });
            data.Add(new IotDeviceModel()
            {
                Icon = "\u2746",
                FontFamily = "Segoe UI Emoji",
                DeviceName = "Máy lạnh 1",
                RoomName = "Phòng 1",
                GradientColor1 = "#56CCF2",
                GradientColor2 = "#2F80ED"
            });
            data.Add(new IotDeviceModel()
            {
                Icon = "\u2746",
                FontFamily = "Segoe UI Emoji",
                DeviceName = "Máy lạnh 2",
                RoomName = "Phòng 1",
                GradientColor1 = "#56CCF2",
                GradientColor2 = "#2F80ED"
            });
            data.Add(new IotDeviceModel()
            {
                Icon = "\uE960",
                FontFamily = "Segoe MDL2 Assets",
                DeviceName = "Camera 1",
                RoomName = "Phòng 1",
                GradientColor1 = "#DA22FF",
                GradientColor2 = "#9733EE"
            });
            data.Add(new IotDeviceModel()
            {
                Icon = "\uE960",
                FontFamily = "Segoe MDL2 Assets",
                DeviceName = "Camera 2",
                RoomName = "Phòng 1",
                GradientColor1 = "#DA22FF",
                GradientColor2 = "#9733EE"
            });
            data.Add(new IotDeviceModel()
            {
                Icon = "\uE95D",
                FontFamily = "Segoe MDL2 Assets",
                DeviceName = "Máy chiếu 1",
                RoomName = "Phòng 1"
            });
            data.Add(new IotDeviceModel()
            {
                Icon = "\uE7F5",
                FontFamily = "Segoe MDL2 Assets",
                DeviceName = "Loa 1",
                RoomName = "Phòng 1",
                GradientColor1 = "#FDFC47",
                GradientColor2 = "#24FE41"
            });
            data.Add(new IotDeviceModel()
            {
                Icon = "\uE7F5",
                FontFamily = "Segoe MDL2 Assets",
                DeviceName = "Loa 2",
                RoomName = "Phòng 1",
                GradientColor1 = "#FDFC47",
                GradientColor2 = "#24FE41"
            });
            data.Add(new IotDeviceModel()
            {
                Icon = "\uE7F5",
                FontFamily = "Segoe MDL2 Assets",
                DeviceName = "Loa 3",
                RoomName = "Phòng 1",
                GradientColor1 = "#FDFC47",
                GradientColor2 = "#24FE41"
            });
            return data;
        }
    }
}
