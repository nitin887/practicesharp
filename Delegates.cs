/*
Perfect 👍
Here are problem statements only (no solutions) for:

Delegates • Predicate • Action • Func • Events • Anonymous Methods • Lambda Expressions

🔹 BASIC LEVEL


2️⃣ Predicate Delegate – Even Number Filter

Given a list of integers:

Requirements:

Use Predicate<int>

Filter even numbers

Use List<T>.FindAll()

3️⃣ Action Delegate – Logger

Create a logging system.

Requirements:

Use Action<string>

Print messages to console

Pass different messages dynamically

4️⃣ Func Delegate – Square Calculator

Create a function using Func<int, int>.

Requirements:

Accept a number

Return its square

Print result

🔹 INTERMEDIATE LEVEL
5️⃣ Multicast Delegate – Notification System

Create a delegate Notify.

Requirements:

Create methods: SendEmail, SendSMS

Attach both methods to delegate

Invoke once → should trigger both methods

6️⃣ Custom Event – Temperature Monitor

Create a class TemperatureSensor.

Requirements:

Create event TemperatureExceeded

Trigger event when temperature > 100

Another class should subscribe and display warning

7️⃣ Anonymous Method – Discount System

Create a delegate for calculating discount.

Requirements:

Use anonymous method (not lambda)

Calculate 10% discount

Apply on product price

8️⃣ Lambda Expression – Student Filter

Given a list of students:

Requirements:

Use lambda expression

Filter students with Marks > 75

Print names

🔹 ADVANCED LEVEL
9️⃣ Event-Driven Order Processing System

Create an Order class.

Requirements:

Event OrderPlaced

Event OrderShipped

Trigger events in correct sequence

Subscribe handlers that log messages

🔟 Func + LINQ + Lambda Combination

Given a list of employees:

Requirements:

Use Func<Employee, bool>

Filter employees with Salary > 50,000

Use LINQ with lambda

Sort by salary descending

1️⃣1️⃣ Predicate + RemoveAll

Given a list of products:

Requirements:

Use Predicate<Product>

Remove products that are out of stock

Print remaining products

1️⃣2️⃣ Event with Multiple Subscribers (Advanced)

Create a BankAccount class.

Requirements:

Event BalanceChanged

When deposit/withdraw happens, trigger event

Multiple subscribers:

SMS notification

Email notification

Audit logger

🔥 VERY ADVANCED (Interview Level)
1️⃣3️⃣ Build Your Own Custom Delegate Framework

Requirements:

Create a custom delegate Validator<T>

Accept any type

Use lambda expressions

Validate:

Email format

Password strength

Return true/false

1️⃣4️⃣ Asynchronous Event Handler

Requirements:

Create event FileProcessed

Event handler must be async

Simulate processing delay

Ensure proper await handling
*/
using System.Diagnostics;

class Delegates
{
    /*
    1️⃣ Simple Delegate Calculator

     Create a delegate that performs a mathematical operation on two numbers.

     Requirements:

     Define a delegate Operation

    Create methods: Add, Subtract, Multiply

    Assign methods to delegate dynamically

    Execute based on user choice
    */
    static void Main(string[] args)
    {
        Console.WriteLine("enter the two numbers:");

    }

}