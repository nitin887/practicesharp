/*
🧩 15. Real-World Simulation (Booking System)
🎯 Concept: Synchronization + Race Condition

Problem:
Simulate ticket booking:

⚠️ Requirements:
Limited seats
Multiple users (threads) booking
Prevent overbooking using synchronization
*/
class BookingSystem
{
    bool status = false;
    static int seats = 10;
    static object lockobj = new object();

    public void Booking()
    {
        lock (lockobj)
        {
            while (seats > 0)
            {
                status = true;
                int a = 1;
                seats -= a;
                Console.WriteLine("seat has been booked");
                if (seats == 0)
                {
                    status = false;
                }
                if (status == false)
                {
                    Console.WriteLine("unavailable seats");

                }

            }

        }




    }

    static void Main()
    {
        BookingSystem bookingSystem = new BookingSystem();

        try
        {
            Console.WriteLine("Enter your choice:\n1.book\n 2.cancel");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:

                    bookingSystem.Booking();

                    break;
                case 2:
                    Console.WriteLine("you not seem to be interested in booking");
                    break;
            }
            Thread first = new Thread(bookingSystem.Booking);
            Thread second = new Thread(bookingSystem.Booking);
            first.Start();
            second.Start();
            first.Join();
            second.Join();
        }
        catch (FormatException ep)
        {
            Console.WriteLine(ep.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }





    }
}