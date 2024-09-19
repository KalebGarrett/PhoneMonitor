using System;
using System.IO;
using System.Reflection;
using Microsoft.Toolkit.Uwp.Notifications;

namespace PhoneMonitor.App.Services
{
    public class ToastService
    {
        public void SendPushNotification()
        {
            var random = new Random();
            var conversationId = random.Next(1, 10000);
            
            var imgPathUri = Path.GetFullPath(@"Images\finger-shake-judge-judy.gif");
            
            var toast = new ToastContentBuilder();
            toast.AddArgument("action", "viewConversation");
            toast.AddArgument("conversationId", conversationId);
            toast.AddText("Get off your phone! You are working.");
            toast.AddInlineImage(new Uri(imgPathUri));
            toast.Show();
        }
    }
}