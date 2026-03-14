/*
🔹 INTERMEDIATE LEVEL
5️⃣ Multicast Delegate – Notification System

Create a delegate Notify.

Requirements:

Create methods: SendEmail, SendSMS

Attach both methods to delegate

Invoke once → should trigger both methods

*/
class NotificationSystem
{
    static void Main(string[] args)
    {
        Mydelegate mydelegate = SendEmail;
        mydelegate += SendSms;
        mydelegate();




    }
    delegate void Mydelegate();
    static void SendEmail()
    {
        Console.WriteLine("email has been recieved");

    }
    static void SendSms()
    {
        Console.WriteLine("sms has been recieved");

    }
}