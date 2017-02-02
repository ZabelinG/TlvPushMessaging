using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.NotificationHubs;


namespace SendToNotificationHubConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            SendNotificationAsync();
            Console.ReadLine();
        }

        private static async void SendNotificationAsync()
        {

            string hubName = "tlvnotificationhub";

            string DefaultFullSharedAccessSignature = "Endpoint=sb://tlvnotificationnamespace.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=kNKB0R5+nDJMgXOt6BLN5UgAorNEqc2Ax5hTJqdJVEg=";
            string DefaultListenSharedAccessSignature = "Endpoint=sb://tlvnotificationnamespace.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=k/JsAgjfA8lmySBlMU4kgXAqdzMevmDRDQPA7Qs/5A0=";
            

            NotificationHubClient hub = NotificationHubClient.CreateClientFromConnectionString(DefaultFullSharedAccessSignature, hubName);
            var toast = @"<toast><visual><binding template=""ToastText01""><text id=""1"">Hello Gilad from a .NET App!</text></binding></visual></toast>";
            await hub.SendWindowsNativeNotificationAsync(toast);
        }
    }
}
