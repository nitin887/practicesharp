/*
🔴 ADVANCED LEVEL
1️⃣5️⃣ Notification System

Concept: Abstraction

Problem:
Abstract class Notification

Method: Send()

Derived:

EmailNotification

SMSNotification

PushNotification
*/
using System.Security.Claims;

abstract class Notification
{
    public abstract void Send();
    
}
class EmailNotification:Notification
{
    public override void Send()
    {
        Console.WriteLine("you recieved a mail");
    }
    
}
class SmsNotification:Notification
{
    public override void Send()
    {
        Console.WriteLine("you recieved a sms");
    }
    
}
class PushNotifictaion:Notification
{
    public override void Send()
    {
        Console.WriteLine("you need to push a notification");
    }
    
}
class NotificationSysytem
{
    static void Main(string[] args)
    {
      List<Notification> notifications = new List<Notification>
      {
          new EmailNotification(),
          new SmsNotification(),
          new PushNotifictaion()
       };
       foreach(Notification notification in notifications)
        {
            notification.Send();
        }
        
    }
    
}